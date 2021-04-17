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
    public partial class WitnessExisting : System.Web.UI.Page
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



        protected void GridViewWitnessList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var data = new SPContext())
                {
                    Case_Witness cm = new Case_Witness();
                    cm.CaseId = Convert.ToInt32(Session["CaseID"]);
                    cm.WitnessId = Convert.ToInt32(GridViewWitnessList.SelectedRow.Cells[2].Text);
                    cm.AddedOn = Convert.ToDateTime(System.DateTime.Now);
                    data.Case_Witness.Add(cm);
                    data.SaveChanges();
                }
                ShowSuccessMessage("Insert Successful");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.ToString());
            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/WitnessReg.aspx");
        }

        protected void DropDownListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DropDownListType.SelectedItem.Value) == 1)
            {
                Label1.Visible = true;
                name.Visible = true;
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
                name.Visible = false;
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
            this.SearchWitnessDiv(Convert.ToInt32(DropDownDivision.SelectedItem.Value));
        }

        protected void DropDownDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label13.Visible = true;
            DropDownBranch.Visible = true;
            RequiredFieldValidator30.Visible = true;
            this.LoadBranch();
            this.SearchWitnessDis(Convert.ToInt32(DropDownDistrict.SelectedItem.Value));
        }

        protected void DropDownBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SearchWitnessBranch(Convert.ToInt32(DropDownBranch.SelectedItem.Value));
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            this.SearchWitness(name.Text);
        }

        private void SearchWitness(string name)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT WitnessId,WitnessName,WitnessFathersName,WitnessMothersName,(Select DivisionName From Division Where DivisionId=WitnessDivision)As Division,(Select DistrictName From District Where DistrictId=WitnessDistrict)As District,(Select BranchName From Branch Where BranchId=WitnessBranch)As Branch FROM Witness WHERE WitnessName LIKE '%" + name + "%'";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewWitnessList.DataSource = reader;
            GridViewWitnessList.DataBind();
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

        private void SearchWitnessDiv(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT WitnessId,WitnessName,WitnessFathersName,WitnessMothersName,(Select DivisionName From Division Where DivisionId=WitnessDivision)As Division,(Select DistrictName From District Where DistrictId=WitnessDistrict)As District,(Select BranchName From Branch Where BranchId=WitnessBranch)As Branch FROM Witness WHERE WitnessDivision=" + id + "";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewWitnessList.DataSource = reader;
            GridViewWitnessList.DataBind();
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
        private void SearchWitnessDis(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT WitnessId,WitnessName,WitnessFathersName,WitnessMothersName,(Select DivisionName From Division Where DivisionId=WitnessDivision)As Division,(Select DistrictName From District Where DistrictId=WitnessDistrict)As District,(Select BranchName From Branch Where BranchId=WitnessBranch)As Branch FROM Witness WHERE WitnessDistrict=" + id + "";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewWitnessList.DataSource = reader;
            GridViewWitnessList.DataBind();
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
        private void SearchWitnessBranch(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT WitnessId,WitnessName,WitnessFathersName,WitnessMothersName,(Select DivisionName From Division Where DivisionId=WitnessDivision)As Division,(Select DistrictName From District Where DistrictId=WitnessDistrict)As District,(Select BranchName From Branch Where BranchId=WitnessBranch)As Branch FROM Witness WHERE WitnessBranch=" + id + "";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewWitnessList.DataSource = reader;
            GridViewWitnessList.DataBind();
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
    }
}