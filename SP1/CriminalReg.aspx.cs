using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using SP1.Models;
using SP1.Models.Mapping;
using System.Data.Entity;


namespace SP1
{
    public partial class CriminalReg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PoliceId"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            {
                string state = (string)Session["state"];
                if (!string.IsNullOrEmpty(state))
                {
                    this.ShowSuccessMessage("Criminal added Successfully!");
                    Session.Remove("state");
                }
            }

            if (!Page.IsPostBack)
            {
                CalendarDOB.Visible = false;
                this.LoadDivision();
            }
        }


        private void LoadDivision()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT * FROM Division";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownDivision.DataSource = dt;
            DropDownDivision.DataTextField = "DivisionName";
            DropDownDivision.DataValueField = "DivisionId";
            DropDownDivision.DataBind();
            con.Close();
        }
        private void LoadDistrict()
        {

            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string sql = "SELECT * FROM District WHERE DivisionId= " + DropDownDivision.SelectedItem.Value;
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownDistrict.DataSource = dt;
            DropDownDistrict.DataTextField = "DistrictName";
            DropDownDistrict.DataValueField = "DistrictId";
            DropDownDistrict.DataBind();
            con.Close();
        }

        private void LoadBranch()
        {


            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string sql = "SELECT * FROM Branch WHERE DistrictId=" + DropDownDistrict.SelectedItem.Value;
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownBranch.DataSource = dt;
            DropDownBranch.DataTextField = "BranchName";
            DropDownBranch.DataValueField = "BranchId";
            DropDownBranch.DataBind();
            con.Close();
        }

        protected void DropDownDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadDistrict();
        }

        protected void DropDownDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadBranch();
        }

        protected void ButtonDOB_Click(object sender, EventArgs e)
        {
            if (CalendarDOB.Visible)
            {
                CalendarDOB.Visible = false;
            }
            else
            {
                CalendarDOB.Visible = true;
            }
        }

        protected void CalendarDOB_SelectionChanged(object sender, EventArgs e)
        {
            dob.Text = CalendarDOB.SelectedDate.ToString("yyyy-MM-dd");
            CalendarDOB.Visible = false;
        }

        protected void CalendarDOB_DayRender(object sender, DayRenderEventArgs e)
        {
            DateTime startDate = DateTime.Now.AddYears(-100);

            DateTime endDate = DateTime.Now.AddYears(-18);

            e.Day.IsSelectable = e.Day.Date >= startDate & e.Day.Date <= endDate;
        }

        protected void Submit_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                try
                {
                    using (var data = new SPContext())
                    {
                        Criminal criminal = new Criminal();
                        criminal.CriminalName = name.Text;
                        criminal.CriminalAlternateName = altname.Text;
                        criminal.CriminalFathersName = fname.Text;
                        criminal.CriminalMothersName = mname.Text;
                        criminal.CriminalCurrentAddress = caddress.Text;
                        criminal.CriminalPermanentAddress = paddress.Text;
                        criminal.CriminalDivision = Convert.ToInt32(DropDownDivision.SelectedItem.Value);
                        criminal.CriminalDistrict = Convert.ToInt32(DropDownDistrict.SelectedItem.Value);
                        criminal.CriminalBranch = Convert.ToInt32(DropDownBranch.SelectedItem.Value);
                        criminal.CriminalDateOfBirth = dob.Text;
                        criminal.CriminalGender = RadioButtonGender.SelectedItem.Value;
                        criminal.CriminalBirthCertificateId = birid.Text;
                        criminal.CriminalNationalId = natid.Text;
                        criminal.CriminalPassportId = passid.Text;
                        criminal.CriminalDrivingLicenseId = driveid.Text;
                        criminal.CriminalContactNo = contactno.Text;
                        criminal.CriminalRemarkableMarks = remarkmarks.Text;
                        criminal.CriminalMaterialStatus = DropDownMaterial.SelectedItem.Value;
                        criminal.CriminalPartnerName = partnername.Text;
                        criminal.CriminalNoOfChild = Convert.ToInt32(DropDownNoOfChild.SelectedItem.Value);
                        criminal.CriminalStatus = DropDownListCriminalStatus.SelectedItem.Value;
                        criminal.CriminalAddedOn = Convert.ToDateTime(System.DateTime.Now);
                        data.Criminals.Add(criminal);
                        data.SaveChanges();
                        Session["CriminalID"] = criminal.CriminalId;
                        Case_Criminal cm = new Case_Criminal();
                        cm.CaseId = Convert.ToInt32(Session["CaseID"]);
                        cm.CriminalId = Convert.ToInt32(Session["CriminalID"]);
                        cm.AddedOn = Convert.ToDateTime(System.DateTime.Now);
                        data.Case_Criminal.Add(cm);
                        data.SaveChanges();
                        Session["state"] = "success";
                        Response.Redirect("/CriminalReg.aspx");
                    }

                }
                catch (Exception ex)
                {
                    this.ShowErrorMessage(ex.ToString());
                }
            }
            else
            {
                this.ShowErrorMessage("Validation Failed,One or More Error Occured!");
            }
        }

        protected void DropDownMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownMaterial.SelectedItem.Value == "Married")
            {
                Label28.Enabled = true;
                Label28.Visible = true;
                partnername.Enabled = true;
                partnername.Visible = true;
                RequiredFieldValidator28.Enabled = true;
                Label29.Enabled = true;
                Label29.Visible = true;
                DropDownNoOfChild.Enabled = true;
                DropDownNoOfChild.Visible = true;
                RequiredFieldValidator33.Enabled = true;
            }
            else
            {
                Label28.Enabled = false;
                Label28.Visible = false;
                partnername.Enabled = false;
                partnername.Visible = false;
                RequiredFieldValidator28.Enabled = false;
                Label29.Enabled = false;
                Label29.Visible = false;
                DropDownNoOfChild.Enabled = false;
                DropDownNoOfChild.Visible = false;
                RequiredFieldValidator33.Enabled = false;
            }

        }

        protected void ButtonNext_Click(object sender, EventArgs e)
        {
            string state = (string)Session["PlaintiffCivilian"];
            if (!string.IsNullOrEmpty(state))
            {
                Response.Redirect("/PlaintiffReg.aspx");
            }
            else
            {
                Response.Redirect("WitnessReg.aspx");
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

        protected void DrivingIDValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            using (var context = new SPContext())
            {
                Criminal criminal = new Criminal();
                var result = from m in context.Criminals where m.CriminalDrivingLicenseId == driveid.Text select m;
                if (result.Count() == 0)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }

        protected void BirthIDValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            using (var context = new SPContext())
            {
                Criminal criminal = new Criminal();
                var result = from m in context.Criminals where m.CriminalBirthCertificateId == birid.Text select m;
                if (result.Count() == 0)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }

        protected void NationalIdValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            using (var context = new SPContext())
            {
                Criminal criminal = new Criminal();
                var result = from m in context.Criminals where m.CriminalNationalId == natid.Text select m;
                if (result.Count() == 0)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }

        protected void PassportIDValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            using (var context = new SPContext())
            {
                Criminal criminal = new Criminal();
                var result = from m in context.Criminals where m.CriminalPassportId == passid.Text select m;
                if (result.Count() == 0)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }

        protected void ContactValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            using (var context = new SPContext())
            {
                Criminal criminal = new Criminal();
                var result = from  m in context.Criminals where m.CriminalContactNo == contactno.Text select m;
                if (result.Count() == 0)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }

        protected void ButtonCrimanlExist_Click(object sender, EventArgs e)
        {
            Response.Redirect("/CriminalExisting.aspx");
        }
    }
}