using SP1.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SP1
{
    public partial class ViewCriminal2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PoliceId"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            int a = Convert.ToInt32(Session["CriminalId"]);
            this.LoadProfile(a);
            this.LoadCharges(a);
            this.InvOfficerCheck();
        }

        private void LoadCharges(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string sql = "Select CaseId,(Select ChargeName from Charge where Charge.ChargeId=Charge_Criminal_Case.ChargeId)As Charges,ChargeAddedOn From Charge_Criminal_Case Where CriminalId=" + id;
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewCharges.DataSource = reader;
            GridViewCharges.DataBind();
        }

        private void InvOfficerCheck()
        {
            using (var context = new SPContext())
            {
                int a = Convert.ToInt32(Session["CaseId"]);
                Case ca = context.Cases.SingleOrDefault(x => x.CaseId == a);
                if (Convert.ToInt32(Session["PoliceId"]) == ca.CaseInvestigationOfficerId)
                {
                    ButtonCriminal.Enabled = true;
                    ButtonCriminal.Visible = true;
                }


                if (ca.CasePlaintiffedOfficerId != null && ca.CasePlaintiffedOfficerId == Convert.ToInt32(Session["PoliceId"]))
                {
                    ButtonCriminal.Enabled = true;
                    ButtonCriminal.Visible = true;
                }
            }
        }


        private void ShowSuccessMessage(string msg)
        {
            LabelMessage.ForeColor = System.Drawing.Color.Green;
            LabelMessage.Text = msg;
        }

        private void ShowErrorMessage(string msg)
        {
            LabelMessage.ForeColor = System.Drawing.Color.Red;
            LabelMessage.Text = msg;
        }


        private void LoadProfile(int id)
        {
            using (var context = new SPContext())
            {

                Criminal criminal = context.Criminals.SingleOrDefault(x => x.CriminalId == id);
                LabelName.Text = criminal.CriminalName;
                LabelFName.Text = criminal.CriminalFathersName;
                LabelMName.Text = criminal.CriminalMothersName;
                LabelCAddress.Text = criminal.CriminalCurrentAddress;
                LabelPAddress.Text = criminal.CriminalPermanentAddress;
                LabelDOB.Text = Convert.ToString(criminal.CriminalDateOfBirth);
                LabelGender.Text = criminal.CriminalGender;
                LabelBirthId.Text = criminal.CriminalBirthCertificateId;
                LabelNationalId.Text = criminal.CriminalNationalId;
                LabelPassportId.Text = criminal.CriminalPassportId;
                LabelDrivingId.Text = criminal.CriminalDrivingLicenseId;
                LabelMaterialStatus.Text = criminal.CriminalMaterialStatus;
                int f = criminal.CriminalDivision;
                int g = criminal.CriminalDistrict;
                int h = criminal.CriminalBranch;
                Division division = context.Divisions.SingleOrDefault(x => x.DivisionId == f);
                LabelDivision.Text = division.DivisionName;
                District district = context.Districts.SingleOrDefault(x => x.DistrictId == g);
                LabelDistrict.Text = district.DistrictName;
                Branch branch = context.Branches.SingleOrDefault(x => x.BranchId == h);
                LabelBranch.Text = branch.BranchName;
                LabelContact.Text = criminal.CriminalContactNo;
                LabelRMarks.Text = criminal.CriminalRemarkableMarks;
                LabelPName.Text = criminal.CriminalPartnerName;
                LabelAddOn.Text = criminal.CriminalAddedOn.ToShortDateString();
                LabelCStatus.Text = criminal.CriminalStatus;
                LabelNOC.Text = Convert.ToString(criminal.CriminalNoOfChild);


            }
        }

        protected void ButtonCriminal_Click(object sender, EventArgs e)
        {
            if(DropDownListCriminalStatus.Enabled == false)
            {
                DropDownListCriminalStatus.Enabled = true;
                DropDownListCriminalStatus.Visible = true;
                Add.Enabled = true;
                Add.Visible = true;
                LabelMessage.Visible = true;
            }
            else
            {
                DropDownListCriminalStatus.Enabled = false;
                DropDownListCriminalStatus.Visible = false;
                Add.Enabled = false;
                Add.Visible = false;
                LabelMessage.Visible = false;
            }
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            using (var context = new SPContext())
            {
                int id = Convert.ToInt32(Session["CriminalId"]);
                Criminal criminal = context.Criminals.SingleOrDefault(x => x.CriminalId == id);
                criminal.CriminalStatus = Convert.ToString(DropDownListCriminalStatus.SelectedItem.Value);
                context.SaveChanges();
                ShowSuccessMessage("Criminal Status has been changed !");
            }
        }

        protected void GridViewCharges_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["CaseId"] = GridViewCharges.SelectedRow.Cells[1].Text;
            Response.Redirect("/ViewCase.aspx");
        }
    }
}