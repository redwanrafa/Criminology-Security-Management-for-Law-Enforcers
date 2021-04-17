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
    public partial class PlaintiffReg : System.Web.UI.Page
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
                    this.ShowSuccessMessage("Plaintiff added Successfully!");
                    Session.Remove("state");
                }
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

        protected void DropDownDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadDistrict();
        }

        protected void DropDownDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadBranch();
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var data = new SPContext())
                {
                    Plaintiff pt = new Plaintiff();
                    pt.PlaintiffName = name.Text;
                    pt.PlaintiffFathersName = fname.Text;
                    pt.PlaintiffMothersName = mname.Text;
                    pt.PlaintiffAddress = caddress.Text;
                    pt.PlaintiffDivision= Convert.ToInt32(DropDownDivision.SelectedItem.Value);
                    pt.PlaintiffDistrict = Convert.ToInt32(DropDownDistrict.SelectedItem.Value); 
                    pt.PlaintiffBranch = Convert.ToInt32(DropDownBranch.SelectedItem.Value);
                    data.Plaintiffs.Add(pt);
                    data.SaveChanges();
                    Session["PlaintiffId"] = pt.PlaintiffId;
                    Case_Plaintiff cpt = new Case_Plaintiff();
                    cpt.CaseId= Convert.ToInt32(Session["CaseID"]);
                    cpt.PlaintiffId= Convert.ToInt32(Session["PlaintiffId"]);
                    cpt.AddedOn= Convert.ToDateTime(System.DateTime.Now);
                    data.Case_Plaintiff.Add(cpt);
                    data.SaveChanges();
                    Session["state"] = "success";
                    Response.Redirect("/PlaintiffReg.aspx");
                    
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex.ToString());
            }
        }

        protected void ButtonNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("WitnessReg.aspx");
        }

        protected void ButtonPlaintiffExist_Click(object sender, EventArgs e)
        {
            Response.Redirect("PlaintiffExisting.aspx");
        }
    }
}