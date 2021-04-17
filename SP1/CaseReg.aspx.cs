using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using SP1.Models;

namespace SP1
{
    public partial class casereg : System.Web.UI.Page
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
                this.LoadCrimeCategory();
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
        private void LoadCrimeCategory()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT * FROM CrimeCategory";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownCrimeCategory.DataSource = dt;
            DropDownCrimeCategory.DataTextField = "CategoryName";
            DropDownCrimeCategory.DataValueField = "CategoryId";
            DropDownCrimeCategory.DataBind();
            con.Close();
        }

        private void SearchInvestOfficer(string name)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT PoliceId,PoliceName,(Select Rank2Name From Rank2 Where Rank2Id=PoliceCurrentRank2)As Rank FROM Police WHERE PoliceName LIKE '%" + name + "%'";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewInvestOfficer.DataSource = reader;
            GridViewInvestOfficer.DataBind();
            con.Close();
        }
        protected void DropDownCaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownCaseType.SelectedItem.Value == "Civil")
            {

                Label11.Enabled = true;
                Label11.Visible = true;
                cdefendent.Enabled = true;
                cdefendent.Visible = true;
                RequiredFieldValidator34.Enabled = true;
                Label26.Enabled = false;
                Label26.Visible = false;
                DropDownCrimeCategory.Enabled = false;
                DropDownCrimeCategory.Visible = false;
                RequiredFieldValidator38.Enabled = false;


            }
            else
            {

                Label11.Enabled = false;
                Label11.Visible = false;
                cdefendent.Enabled = false;
                cdefendent.Visible = false;
                RequiredFieldValidator34.Enabled = false;
                Label26.Enabled = true;
                Label26.Visible = true;
                DropDownCrimeCategory.Enabled = true;
                DropDownCrimeCategory.Visible = true;
                RequiredFieldValidator38.Enabled = true;

            }
        }


        protected void officersearchplaintiff_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownCaseBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SearchInvestigationOfficer_Click(object sender, EventArgs e)
        {
            this.SearchInvestOfficer(officersearchinvest.Text);
        }

        protected void GridViewInvestOfficer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Name = GridViewInvestOfficer.SelectedRow.Cells[2].Text;
            Session["InvestigationOfficerId"] = Convert.ToInt32(GridViewInvestOfficer.SelectedRow.Cells[1].Text);
            InvestOfficerName.Text = Name;

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var data = new SPContext())
                {
                    Case cas = new Case();
                    cas.CaseType = DropDownCaseType.SelectedItem.Value;
                    cas.CaseDetails = cdetails.Text;
                    cas.CaseInventory = cinvent.Text;
                    cas.CaseDivisionId = Convert.ToInt32(DropDownDivision.SelectedItem.Value);
                    cas.CaseDistrictId = Convert.ToInt32(DropDownDistrict.SelectedItem.Value);
                    cas.CaseBranchId = Convert.ToInt32(DropDownBranch.SelectedItem.Value);
                    cas.CaseInvestigationOfficerId = Convert.ToInt32(Session["InvestigationOfficerId"]);
                    cas.CaseInvOfficerOn = Convert.ToDateTime(System.DateTime.Now);
                    if (DropDownCaseBy.SelectedItem.Value == "Police")
                    {
                        cas.CasePlaintiffedOfficerId = Convert.ToInt32(Session["PoliceId"]);
                       // Session["PlaintiffCivilian"] = "false";
                    }
                    else
                    {
                        Session["PlaintiffCivilian"] = "true";
                    }
                    if (DropDownCaseType.SelectedItem.Value == "Civil")
                    {
                        cas.CaseDefendents = cdefendent.Text;
                        cas.CaseCurrentCourtId = 7;
                    }
                    else if (DropDownCaseType.SelectedItem.Value == "Criminal")
                    {
                        cas.CrimeCategoryId = Convert.ToInt32(DropDownCrimeCategory.SelectedItem.Value);
                        cas.CaseCurrentCourtId = 19;
                    }
                    cas.CaseStatus = "Under Investigation";
                    cas.CaseAddedOn = Convert.ToDateTime(System.DateTime.Now);
                    data.Cases.Add(cas);
                    data.SaveChanges();
                    Session["CaseID"] = cas.CaseId;
                    if (DropDownCaseType.SelectedItem.Value == "Criminal")
                    {
                        Response.Redirect("/CriminalReg.aspx");
                    }
                    else
                    {
                        Response.Redirect("/WitnessReg.aspx");
                    }

                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex.ToString());
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
    }
}