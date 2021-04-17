
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
    public partial class SearchPolice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["PoliceId"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            if (!Page.IsPostBack)
            {

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



        protected void DropDownListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DropDownListType.SelectedItem.Value) == 1)
            {
                Label1.Visible = true;
                name.Visible = true;
                ButtonSearchPolice.Visible = true;
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
                name.Visible = false;
                ButtonSearchPolice.Visible = false;
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
            this.SearchPoliceDiv(Convert.ToInt32(DropDownDivision.SelectedItem.Value));
        }

        protected void DropDownDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label13.Visible = true;
            DropDownBranch.Visible = true;
            RequiredFieldValidator30.Visible = true;
            this.LoadBranch();
            this.SearchPoliceDis(Convert.ToInt32(DropDownDistrict.SelectedItem.Value));
        }

        protected void DropDownBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SearchPoliceBranch(Convert.ToInt32(DropDownBranch.SelectedItem.Value));
        }

        private void SearchPoliceBy(string name)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT PoliceId,PoliceName,(Select Rank2Name From Rank2 Where Rank2Id=PoliceCurrentRank2)As Rank FROM Police WHERE PoliceName LIKE '%" + name + "%'";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewPoliceList.DataSource = reader;
            GridViewPoliceList.DataBind();
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

        private void SearchPoliceDiv(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT PoliceId,PoliceName,(Select Rank2Name From Rank2 Where Rank2Id=PoliceCurrentRank2)As Rank FROM Police WHERE PoliceDivision=" + id + "";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewPoliceList.DataSource = reader;
            GridViewPoliceList.DataBind();
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
        private void SearchPoliceDis(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT PoliceId,PoliceName,(Select Rank2Name From Rank2 Where Rank2Id=PoliceCurrentRank2)As Rank FROM Police WHERE PoliceDistrict=" + id + "";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewPoliceList.DataSource = reader;
            GridViewPoliceList.DataBind();
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
        private void SearchPoliceBranch(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT PoliceId,PoliceName,(Select Rank2Name From Rank2 Where Rank2Id=PoliceCurrentRank2)As Rank FROM Police WHERE PoliceBranch = " + id + "";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewPoliceList.DataSource = reader;
            GridViewPoliceList.DataBind();
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

        protected void ButtonSearchPolice_Click(object sender, EventArgs e)
        {
            this.SearchPoliceBy(name.Text);
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

        protected void GridViewPoliceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["PoliceId1"] = GridViewPoliceList.SelectedRow.Cells[1].Text;
            Response.Redirect("ViewPolice.aspx");
        }
    }
}