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
    public partial class ViewPolice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PoliceId"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            /* Label1.Text = Convert.ToString(Session["PoliceName"]);
             Label2.Text = Convert.ToString(Session["Rank2Name"]);*/
            int a = Convert.ToInt32(Session["PoliceId"]);
            this.LoadProfile(a);
            
        }

        private void LoadProfile(int id)
        {
            using (var context = new SPContext())
            {
                
                Police police = context.Police.SingleOrDefault(x => x.PoliceId == id);
                LabelName.Text = police.PoliceName;
                LabelFName.Text = police.PoliceFathersName;
                LabelMName.Text = police.PoliceMothersName;
                LabelCAddress.Text = police.PoliceCurrentAddress;
                LabelPAddress.Text = police.PolicePermanentAddress;
                LabelDOB.Text = Convert.ToString(police.PoliceDateOfBirth);
                LabelGender.Text = police.PoliceGender;
                LabelBirthId.Text = police.PoliceBirthCertificateId;
                LabelNationalId.Text = police.PoliceNationalId;
                LabelPassportId.Text = police.PolicePassportId;
                LabelDrivingId.Text = police.PoliceDrivingLicenseId;
                LabelMaterialStatus.Text = police.PoliceMaterialStatus;
                int b = police.PoliceCurrentRank2;
                Rank2 rank = context.Rank2.SingleOrDefault(x => x.Rank2Id == b);
                LabelRank.Text = rank.Rank2Name;
                int c = police.PoliceCurrentUnit1;
                Unit1 unit1 = context.Unit1.SingleOrDefault(x => x.Unit1Id == c);
                LabelUnit1.Text = unit1.Unit1Name;
                if (police.PoliceCurrentUnit2 != null)
                {
                    LabelUnit2.Text = " ";
                }
                else
                {
                    int? d = police.PoliceCurrentUnit2;
                    Unit2 unit2 = context.Unit2.SingleOrDefault(x => x.Unit2Id == d);
                    LabelUnit2.Text = unit2.Unit2Name;

                }
               
                int? f = police.PoliceDivision;
                int? g = police.PoliceDistrict;
                int? h = police.PoliceBranch;
                if (f != null)
                {
                    Division division = context.Divisions.SingleOrDefault(x => x.DivisionId == f);
                    LabelDivision.Text = division.DivisionName;
                }
                if (g != null)
                {
                    District district = context.Districts.SingleOrDefault(x => x.DistrictId == g);
                    LabelDistrict.Text = district.DistrictName;
                }
                if (h != null)
                {
                    Branch branch = context.Branches.SingleOrDefault(x => x.BranchId == h);
                    LabelBranch.Text = branch.BranchName;
                }
                LabelEmail.Text = police.PoliceEmail;
                LabelContact.Text = police.PoliceContactNo;
                LabelUserName.Text = police.PoliceUserName;
                int m = police.PoliceJoiningRank;
                Rank2 joinrank = context.Rank2.SingleOrDefault(x => x.Rank2Id == m);
                LabelJoinRank.Text = joinrank.Rank2Name;
                LabelJoinDate.Text =police.PoliceJoiningDate.ToShortDateString();
                Salary salary = context.Salaries.SingleOrDefault(x => x.Rank2Id == b);
                LabelSalary.Text = Convert.ToString(salary.Salary1);
                int n = police.PoliceRewardRankId;
                /*RewardRank rrank = context.RewardRanks.SingleOrDefault(x => x.RewardRankId == n);
                LabelRewardRank.Text = rrank.RewardRankName;
                */
                LabelXP.Text = Convert.ToString(police.PoliceXP);
                this.LoadAchievment(id);

            }
        }

        private void LoadAchievment(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT AchievmentName FROM Achievment Where AchievmentId IN(Select AchievmentId from Police_Achievment Where PoliceId =" + id + ")";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
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

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                using (var context = new SPContext())
                {
                    int a = Convert.ToInt32(Session["PoliceId"]);
                    Police police = context.Police.SingleOrDefault(x => x.PoliceId == a);
                    police.PoliceEmail = email.Text;
                    context.SaveChanges();
                    this.ShowSuccessMessage("Email Has Successfully been updated!");
                }
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                using (var context = new SPContext())
                {
                    int a = Convert.ToInt32(Session["PoliceId"]);
                    Police police = context.Police.SingleOrDefault(x => x.PoliceId == a);
                    police.PoliceContactNo = contactno.Text;
                    context.SaveChanges();
                    this.ShowSuccessMessage("Contact No Has Successfully been updated!");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label31.Enabled = true;
            Label31.Visible = true;
            email.Enabled = true;
            email.Visible = true;
            Button3.Enabled = true;
            Button3.Visible = true;
            Label32.Enabled = true;
            Label32.Visible = true;
            contactno.Enabled = true;
            contactno.Visible = true;
            Button4.Enabled = true;
            Button4.Visible = true;
            Label34.Enabled = true;
            Label34.Visible = true;
            caddress.Enabled = true;
            caddress.Visible = true;
            Button6.Enabled = true;
            Button6.Visible = true;

            Label21.Enabled = false;
            Label21.Visible = false;
            pass.Enabled = false;
            pass.Visible = false;
            Label22.Enabled = false;
            Label22.Visible = false;
            confpass.Enabled = false;
            confpass.Visible = false;
            Button5.Enabled = false;
            Button5.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label21.Enabled = true;
            Label21.Visible = true;
            pass.Enabled = true;
            pass.Visible = true;
            Label22.Enabled = true;
            Label22.Visible = true;
            confpass.Enabled = true;
            confpass.Visible = true;
            Button5.Enabled = true;
            Button5.Visible = true;

            Label31.Enabled = false;
            Label31.Visible = false;
            email.Enabled = false;
            email.Visible = false;
            Button3.Enabled = false;
            Button3.Visible = false;
            Label32.Enabled = false;
            Label32.Visible = false;
            contactno.Enabled = false;
            contactno.Visible = false;
            Button4.Enabled = false;
            Button4.Visible = false;
            Label34.Enabled = false;
            Label34.Visible = false;
            caddress.Enabled = false;
            caddress.Visible = false;
            Button6.Enabled = false;
            Button6.Visible = false;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            using (var context = new SPContext())
            {
                int a = Convert.ToInt32(Session["PoliceId"]);
                Police police = context.Police.SingleOrDefault(x => x.PoliceId == a);
                police.PoliceCurrentAddress = caddress.Text;
                context.SaveChanges();
                this.ShowSuccessMessage("Current Address Has Successfully been updated!");
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

        protected void Button5_Click(object sender, EventArgs e)
        {
            using (var context = new SPContext())
            {
                int a = Convert.ToInt32(Session["PoliceId"]);
                Police police = context.Police.SingleOrDefault(x => x.PoliceId == a);
                police.PolicePassword = pass.Text;
                context.SaveChanges();
                this.ShowSuccessMessage("Password Has Successfully been updated!");
            }
        }
    }
}