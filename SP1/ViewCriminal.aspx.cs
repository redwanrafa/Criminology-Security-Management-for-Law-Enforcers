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
    public partial class ViewCriminal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PoliceId"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            int a =Convert.ToInt32(Session["CriminalId"]);
            this.LoadProfile(a);
            this.LoadCharges(a);
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

        protected void GridViewCharges_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["CaseId"] = GridViewCharges.SelectedRow.Cells[1].Text;
            Response.Redirect("/ViewCase.aspx");
        }
    }
}