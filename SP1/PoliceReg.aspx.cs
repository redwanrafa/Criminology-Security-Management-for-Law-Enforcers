using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using SP1.Models.Mapping;
using SP1.Models;
using System.Data.Entity;

namespace SP1
{
    public partial class PoliceReg : System.Web.UI.Page
    {
        public int a1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PoliceId"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            string state = (string)Session["state"];
            if (!string.IsNullOrEmpty(state))
            {
                this.ShowSuccessMessage("Police Added Successfully");
                Session.Remove("state");
            }


            if (!Page.IsPostBack)
            {
                CalendarDOB.Visible = false;
                this.LoadRank1();
                this.LoadUnit1();
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

        private void LoadRank1()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT * FROM Rank1";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownRank1.DataSource = dt;
            DropDownRank1.DataTextField = "Rank1Name";
            DropDownRank1.DataValueField = "Rank1Id";
            DropDownRank1.DataBind();
            con.Close();
        }

        private void LoadRank2()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string sql = "SELECT * FROM Rank2 WHERE Rank1Id= " + DropDownRank1.SelectedItem.Value;
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownRank2.DataSource = dt;
            DropDownRank2.DataTextField = "Rank2Name";
            DropDownRank2.DataValueField = "Rank2Id";
            DropDownRank2.DataBind();
            con.Close();
            
        }

        private void LoadUnit1()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT * FROM Unit1";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownUnit1.DataSource = dt;
            DropDownUnit1.DataTextField = "Unit1Name";
            DropDownUnit1.DataValueField = "Unit1Id";
            DropDownUnit1.DataBind();
            con.Close();
        }

        private void LoadUnit2()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string sql = "SELECT * FROM Unit2 WHERE Unit1Id= " + DropDownUnit1.SelectedItem.Value;
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownUnit2.DataSource = dt;
            DropDownUnit2.DataTextField = "Unit2Name";
            DropDownUnit2.DataValueField = "Unit2Id";
            DropDownUnit2.DataBind();
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

        protected void DropDownRank1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadRank2();
        }

        protected void DropDownUnit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DropDownUnit1.SelectedItem.Value) == 10)
            {
                this.LoadUnit2();
                DropDownUnit2.Enabled = true;
                DropDownUnit2.Visible = true;
                RequiredFieldValidator27.Enabled = true;

            }
            else
            {
                DropDownUnit2.Enabled = false;
                DropDownUnit2.Visible = false;
                RequiredFieldValidator27.Enabled = false;

            }


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
            DateTime startDate = DateTime.Now.AddYears(-60);

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
                        Police police = new Police();

                        police.PoliceName = name.Text;
                        police.PoliceFathersName = fname.Text;
                        police.PoliceMothersName = mname.Text;
                        police.PoliceCurrentAddress = caddress.Text;
                        police.PolicePermanentAddress = paddress.Text;
                        police.PoliceDateOfBirth = dob.Text;
                        police.PoliceGender = RadioButtonGender.SelectedItem.Value;
                        police.PoliceBirthCertificateId = birid.Text;
                        police.PoliceNationalId = natid.Text;
                        police.PolicePassportId = passid.Text;
                        police.PoliceDrivingLicenseId = driveid.Text;
                        police.PoliceMaterialStatus = DropDownMaterial.SelectedItem.Value;
                        police.PoliceCurrentRank1 = Convert.ToInt32(DropDownRank1.SelectedItem.Value);
                        int a = Convert.ToInt32(Session["Rank2"]);
                        if (Convert.ToInt32(DropDownRank2.SelectedItem.Value) < a)
                        {
                            this.ShowErrorMessage("You Can not add higher rank Officer , Select a Rank below your current Rank ");
                        }
                        else
                        {
                            police.PoliceCurrentRank2 = Convert.ToInt32(DropDownRank2.SelectedItem.Value);
                        }
                        police.PoliceCurrentUnit1 = Convert.ToInt32(DropDownUnit1.SelectedItem.Value);
                        if (DropDownUnit2.Enabled == true)
                        {
                            police.PoliceCurrentUnit2 = Convert.ToInt32(DropDownUnit2.SelectedItem.Value);
                        }
                        else
                        {
                            police.PoliceCurrentUnit2 = 0;
                        }
                        if (Convert.ToInt32(DropDownRank2.SelectedItem.Value) > 8)
                        {
                            police.PoliceDivision = Convert.ToInt32(DropDownDivision.SelectedItem.Value);
                            police.PoliceDistrict = Convert.ToInt32(DropDownDistrict.SelectedItem.Value);
                            police.PoliceBranch = Convert.ToInt32(DropDownBranch.SelectedItem.Value);
                        }
                        else if ((Convert.ToInt32(DropDownRank2.SelectedItem.Value) > 4 && (Convert.ToInt32(DropDownRank2.SelectedItem.Value) <= 8)))


                            {
                            police.PoliceDivision = Convert.ToInt32(DropDownDivision.SelectedItem.Value);
                            police.PoliceDistrict = Convert.ToInt32(DropDownDistrict.SelectedItem.Value);
                            police.PoliceBranch = null;
                        }
                        else
                        {
                            police.PoliceDivision = null;
                            police.PoliceDistrict = null;
                            police.PoliceBranch = null;
                        }

                        police.PoliceEmail = email.Text;
                        police.PoliceContactNo = contactno.Text;
                        police.PoliceUserName = username.Text;
                        police.PolicePassword = pass.Text;
                        police.PoliceJoiningDate = Convert.ToDateTime(System.DateTime.Now);
                        police.PoliceJoiningRank = Convert.ToInt32(DropDownRank2.SelectedItem.Value);
                        police.PoliceRewardRankId = 10;
                        police.PoliceXP = 50;
                        police.PoliceStatus = "Active";
                        data.Police.Add(police);
                        data.SaveChanges();
                        Session["state"] = "success";
                        Response.Redirect("/PoliceReg.aspx");


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


        protected void UserNameValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            using (var context = new SPContext())
            {
                Police police = new Police();
                var result = from m in context.Police where m.PoliceUserName == username.Text select m;
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

        protected void EmailValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            using (var context = new SPContext())
            {
                Police police = new Police();
                var result = from m in context.Police where m.PoliceEmail == email.Text select m;
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
                Police police = new Police();
                var result = from m in context.Police where m.PoliceContactNo == contactno.Text select m;
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
                Police police = new Police();
                var result = from m in context.Police where m.PoliceBirthCertificateId == birid.Text select m;
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
                Police police = new Police();
                var result = from m in context.Police where m.PoliceNationalId == natid.Text select m;
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
                Police police = new Police();
                var result = from m in context.Police where m.PolicePassportId == passid.Text select m;
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

        protected void DrivingIDValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            using (var context = new SPContext())
            {
                Police police = new Police();
                var result = from m in context.Police where m.PoliceDrivingLicenseId == driveid.Text select m;
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

        protected void RankValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            using (var context = new SPContext())
            {
                Police police = new Police();
                var result = from m in context.Police where m.PoliceCurrentRank2== 1 select m;
                if (result.Count() > 0 && Convert.ToInt32(DropDownRank2.SelectedItem.Value)==1)
                {
                    args.IsValid = false;
                }
                else
                {
                    args.IsValid = true;
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

        protected void DropDownRank2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }    
}