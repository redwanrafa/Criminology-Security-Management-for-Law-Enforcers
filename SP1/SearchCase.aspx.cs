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
    public partial class SearchCase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PoliceId"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            if (!Page.IsPostBack)
            {
                CalendarDate.Visible = false;
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

        protected void ButtonDate_Click(object sender, EventArgs e)
        {
            if (CalendarDate.Visible)
            {
                CalendarDate.Visible = false;
            }
            else
            {
                CalendarDate.Visible = true;
            }
        }

        protected void CalendarDate_SelectionChanged(object sender, EventArgs e)
        {
            date.Text =CalendarDate.SelectedDate.ToString("yyyy-MM-dd");
            CalendarDate.Visible = false;
            


        }

        protected void DropDownListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DropDownListType.SelectedItem.Value) == 1)
            {
                Label1.Visible = true;
                date.Visible = true;
                ButtonDate.Visible = true;
                ButtonSearch.Visible = true;
                RequiredFieldValidator1.Enabled = true;
                Label24.Visible = false;
                DropDownDivision.Visible = false;
                RequiredFieldValidator28.Visible = false;
                Label14.Visible = false;
                DropDownDistrict.Visible = false;
                RequiredFieldValidator29.Visible = false;
                Label13.Visible = false;
                DropDownBranch.Visible = false;
                RequiredFieldValidator30.Visible = false;
            }
            else
            {
                Label1.Visible = false;
                date.Visible = false;
                ButtonDate.Visible = false;
                ButtonSearch.Visible = false;
                RequiredFieldValidator1.Enabled = false;
                Label24.Visible = true;
                DropDownDivision.Visible = true;
                RequiredFieldValidator28.Visible = true;

            }
        }

        protected void DropDownDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label14.Visible = true;
            DropDownDistrict.Visible = true;
            RequiredFieldValidator29.Visible = true;
            this.LoadDistrict();
            this.SearchCaseDiv(Convert.ToInt32(DropDownDivision.SelectedItem.Value));
        }

        protected void DropDownDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label13.Visible = true;
            DropDownBranch.Visible = true;
            RequiredFieldValidator30.Visible = true;
            this.LoadBranch();
            this.SearchCaseDis(Convert.ToInt32(DropDownDistrict.SelectedItem.Value));
        }

        protected void DropDownBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SearchCaseBranch(Convert.ToInt32(DropDownBranch.SelectedItem.Value));
        }

        private void SearchCaseDate(string date)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT CaseId,CaseType,(Select DivisionName From Division Where DivisionId=CaseDivisionId)As Division,(Select DistrictName From District Where DistrictId=CaseDistrictId)As District,(Select BranchName From Branch Where BranchId=CaseBranchId)As Branch,(Select PoliceName From Police Where PoliceId=CaseInvestigationOfficerId)As InvestigationOfficer,(Select Rank2Name From Rank2 Where Rank2Id=(Select PoliceCurrentRank2 From Police Where PoliceId=CaseInvestigationOfficerId))As InvestigationOfficerRank,CaseStatus FROM [Case] WHERE CaseAddedOn LIKE '%" + date + "%'";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewCaseList.DataSource = reader;
            GridViewCaseList.DataBind();
            if (reader.HasRows)
            {
                this.ShowSuccessMessage("Result Found!");
            }
            else
            {
                this.ShowErrorMessage("No Result Found");
            }
            con.Close();

        }

        private void SearchCaseDiv(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT CaseId,CaseType,(Select DivisionName From Division Where DivisionId=CaseDivisionId)As Division,(Select DistrictName From District Where DistrictId=CaseDistrictId)As District,(Select BranchName From Branch Where BranchId=CaseBranchId)As Branch,(Select PoliceName From Police Where PoliceId=CaseInvestigationOfficerId)As InvestigationOfficer,(Select Rank2Name From Rank2 Where Rank2Id=(Select PoliceCurrentRank2 From Police Where PoliceId=CaseInvestigationOfficerId))As InvestigationOfficerRank,CaseStatus FROM [Case] WHERE CaseDivisionId= " + id + "";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewCaseList.DataSource = reader;
            GridViewCaseList.DataBind();
            if (reader.HasRows)
            {
                this.ShowSuccessMessage("Result Found!");
            }
            else
            {
                this.ShowErrorMessage("No Result Found");
            }
            con.Close();

        }
        private void SearchCaseDis(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT CaseId,CaseType,(Select DivisionName From Division Where DivisionId=CaseDivisionId)As Division,(Select DistrictName From District Where DistrictId=CaseDistrictId)As District,(Select BranchName From Branch Where BranchId=CaseBranchId)As Branch,(Select PoliceName From Police Where PoliceId=CaseInvestigationOfficerId)As InvestigationOfficer,(Select Rank2Name From Rank2 Where Rank2Id=(Select PoliceCurrentRank2 From Police Where PoliceId=CaseInvestigationOfficerId))As InvestigationOfficerRank,CaseStatus FROM [Case] WHERE CaseDistrictId= " + id + "";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewCaseList.DataSource = reader;
            GridViewCaseList.DataBind();
            if (reader.HasRows)
            {
                this.ShowSuccessMessage("Result Found!");
            }
            else
            {
                this.ShowErrorMessage("No Result Found");
            }
            con.Close();

        }
        private void SearchCaseBranch(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT CaseId,CaseType,(Select DivisionName From Division Where DivisionId=CaseDivisionId)As Division,(Select DistrictName From District Where DistrictId=CaseDistrictId)As District,(Select BranchName From Branch Where BranchId=CaseBranchId)As Branch,(Select PoliceName From Police Where PoliceId=CaseInvestigationOfficerId)As InvestigationOfficer,(Select Rank2Name From Rank2 Where Rank2Id=(Select PoliceCurrentRank2 From Police Where PoliceId=CaseInvestigationOfficerId))As InvestigationOfficerRank,CaseStatus FROM [Case] WHERE CaseBranchId= " + id + "";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewCaseList.DataSource = reader;
            GridViewCaseList.DataBind();
            if (reader.HasRows)
            {
                this.ShowSuccessMessage("Result Found!");
            }
            else
            {
                this.ShowErrorMessage("No Result Found");
            }
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

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            string date = CalendarDate.SelectedDate.ToString("yyyy-MM-dd");
            this.SearchCaseDate(date);
        }

        protected void GridViewCaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["CaseId"]=GridViewCaseList.SelectedRow.Cells[1].Text;
            Response.Redirect("/ViewCase.aspx");
        }
    }
}