using SP1.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SP1
{
    public partial class ViewPolice1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PoliceId"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            int a = Convert.ToInt32(Session["PoliceId1"]);
            this.LoadProfile(a);
            this.RankCheck();
        }

        private void RankCheck()
        {
            int a = Convert.ToInt32(Session["PoliceId"]);
            int b = Convert.ToInt32(Session["PoliceId1"]);
            using (var context = new SPContext())
            {

                Police police = context.Police.SingleOrDefault(x => x.PoliceId == a);
                Police police1 = context.Police.SingleOrDefault(x => x.PoliceId == b);
               if( police.PoliceCurrentRank2<police1.PoliceCurrentRank2)
                {
                    Up.Enabled = true;
                    Up.Visible = true;
                    Down.Enabled = true;
                    Down.Visible = true;
                    DropDownUnit1.Enabled = true;
                    DropDownUnit1.Visible = true;
                    UpdateUnit.Enabled = true;
                    UpdateUnit.Visible = true;
                    DropDownDivision.Enabled = true;
                    DropDownDivision.Visible = true;
                    DropDownDistrict.Enabled = true;
                    DropDownDistrict.Visible = true;
                    DropDownBranch.Enabled = true;
                    DropDownBranch.Visible = true;
                    UpdateD.Enabled = true;
                    UpdateD.Visible = true;
                    UpdateStatus.Enabled = true;
                    UpdateStatus.Visible = true;
                    DropDownStatus.Enabled = true;
                    DropDownStatus.Visible = true;
                    if (!Page.IsPostBack)
                    {
                        this.LoadDivision();
                        this.LoadUnit1();

                    }
                    
                }
            }
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
                LabelStatus.Text = police.PoliceStatus;
                int m = police.PoliceJoiningRank;
                Rank2 joinrank = context.Rank2.SingleOrDefault(x => x.Rank2Id == m);
                LabelJoinRank.Text = joinrank.Rank2Name;
                LabelJoinDate.Text = police.PoliceJoiningDate.ToShortDateString();
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

        protected void Down_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Session["PoliceId"]);
            int b = Convert.ToInt32(Session["PoliceId1"]);
            using (var context = new SPContext())
            {

                Police police = context.Police.SingleOrDefault(x => x.PoliceId == a);
                Police police1 = context.Police.SingleOrDefault(x => x.PoliceId == b);
                int ar = Convert.ToInt32(police.PoliceCurrentRank2);
                int br = Convert.ToInt32(police1.PoliceCurrentRank2);
                if (br != 14)
                {
                    if (ar < br && br > 1)
                    {    
                        br++;

                        if (br >= 12 && br <= 14)
                        {
                            police1.PoliceCurrentRank1 = 4;
                            police1.PoliceCurrentRank2 = br;
                        }
                        else if (br >= 10 && br <= 11)
                        {
                            police1.PoliceCurrentRank1 = 3;
                            police1.PoliceCurrentRank2 = br;
                        }
                        else if (br == 9)
                        {
                            police1.PoliceCurrentRank1 = 2;
                            police1.PoliceCurrentRank2 = br;
                        }
                        else if (br > 1 && br <= 8)
                        {
                            police1.PoliceCurrentRank1 = 1;
                            police1.PoliceCurrentRank2 = br;
                        }
                        context.SaveChanges();
                        ShowSuccessMessage("1 Rank Down !");
                    }
                    else
                    {
                        ShowErrorMessage("You can't update rank to your current rank or higher");
                    }
                }
                else
                {
                    ShowErrorMessage("This is the last rank !");
                }
                }
            }
        

        protected void Up_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Session["PoliceId"]);
            int b = Convert.ToInt32(Session["PoliceId1"]);
            using (var context = new SPContext())
            {

                Police police = context.Police.SingleOrDefault(x => x.PoliceId == a);
                Police police1 = context.Police.SingleOrDefault(x => x.PoliceId == b);
                int ar = Convert.ToInt32(police.PoliceCurrentRank2);
                int br= Convert.ToInt32(police1.PoliceCurrentRank2);
                if (br != 2)
                {
                    if (ar < br && br > 1)
                {
                        br--;
                        if (br >= 12 && br <= 14)
                        {
                            police1.PoliceCurrentRank1 = 4;
                            police1.PoliceCurrentRank2 = br;
                        }
                        else if (br >= 10 && br <= 11)
                        {
                            police1.PoliceCurrentRank1 = 3;
                            police1.PoliceCurrentRank2 = br;
                        }
                        else if (br == 9)
                        {
                            police1.PoliceCurrentRank1 = 2;
                            police1.PoliceCurrentRank2 = br;
                        }
                        else if (br > 1 && br <= 8)
                        {
                            police1.PoliceCurrentRank1 = 1;
                            police1.PoliceCurrentRank2 = br;
                            police1.PoliceBranch = null;
                            if(br <= 4)
                            {
                                police1.PoliceDistrict = null;
                            }

                        }
                        context.SaveChanges();
                        ShowSuccessMessage("1 Rank Up !");
                    }
                    else
                    {
                        ShowErrorMessage("You can't update rank to your current rank or higher");
                    }
                }
                else
                {
                    ShowErrorMessage("This is the highest Rank!");
                }

            }
        }
        protected void DropDownUnit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DropDownUnit1.SelectedItem.Value) == 10)
            {
                this.LoadUnit2();
                DropDownUnit2.Enabled = true;
                DropDownUnit2.Visible = true;
                

            }
            else
            {
                DropDownUnit2.Enabled = false;
                DropDownUnit2.Visible = false;
                

            }
        }

        protected void DropDownDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadDistrict();
        }

        protected void DropDownDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadBranch();
        }

        protected void UpdateRank_Click(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void UpdateUnit_Click(object sender, EventArgs e)
        {
            using (var context = new SPContext())
            {
                int b = Convert.ToInt32(Session["PoliceId1"]);
                Police police1 = context.Police.SingleOrDefault(x => x.PoliceId == b);
                police1.PoliceCurrentUnit1 = Convert.ToInt32(DropDownUnit1.SelectedItem.Value);
                if (DropDownUnit2.Enabled == true)
                {
                    police1.PoliceCurrentUnit2 = Convert.ToInt32(DropDownUnit2.SelectedItem.Value);
                }
                else
                {
                    police1.PoliceCurrentUnit2 = 0;
                }
                context.SaveChanges();
                ShowSuccessMessage("Unit Has Successfully been changed !");
            }
        }

        protected void UpdateD_Click(object sender, EventArgs e)
        {
            using (var context = new SPContext())
            {
                int b = Convert.ToInt32(Session["PoliceId1"]);
                Police police1 = context.Police.SingleOrDefault(x => x.PoliceId == b);
                if (police1.PoliceCurrentRank2 > 8)
                {
                    police1.PoliceDivision = Convert.ToInt32(DropDownDivision.SelectedItem.Value);
                    police1.PoliceDistrict = Convert.ToInt32(DropDownDistrict.SelectedItem.Value);
                    police1.PoliceBranch = Convert.ToInt32(DropDownBranch.SelectedItem.Value);
                    context.SaveChanges();
                    this.ShowSuccessMessage("Working Division, District & Branch has been updated !");
                }
                else if (police1.PoliceCurrentRank2 > 4 && police1.PoliceCurrentRank2 <= 8)
                {

                    police1.PoliceDivision = Convert.ToInt32(DropDownDivision.SelectedItem.Value);
                    police1.PoliceDistrict = Convert.ToInt32(DropDownDistrict.SelectedItem.Value);
                    context.SaveChanges();
                    this.ShowSuccessMessage("Working Division, District has been updated ! Branch has been ignored as per rank");
                }
                else
                {
                    ShowErrorMessage("Working Branch can't be added for some higher rank officers ");
                }
            }
        }

        protected void UpdateStatus_Click(object sender, EventArgs e)
        {
            using (var context = new SPContext())
            {
                int b = Convert.ToInt32(Session["PoliceId1"]);
                Police police1 = context.Police.SingleOrDefault(x => x.PoliceId == b);
                police1.PoliceStatus = DropDownStatus.SelectedItem.Value;
                context.SaveChanges();
                this.ShowSuccessMessage("Status Changed !");
            }
        }
    }
}