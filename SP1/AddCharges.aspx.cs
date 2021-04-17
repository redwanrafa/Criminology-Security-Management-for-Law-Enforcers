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
    public partial class AddCharges : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadCriminal(Convert.ToInt32(Session["CaseId"]));
            this.LoadCharges(Convert.ToInt32(Session["CrimeCatagory"]));
            if (Session["CriminalId"] == null)
            {
                this.ShowErrorMessage("No Criminal are available ");
            }
            

        }

        private void LoadCriminal(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string sql = "SELECT CriminalId,CriminalName,CriminalFathersName,CriminalMothersName,CriminalGender,(Select DivisionName From Division Where DivisionId=CriminalDivision)As Division,(Select DistrictName From District Where DistrictId=CriminalDistrict)As District,(Select BranchName From Branch Where BranchId=CriminalBranch)As Branch,CriminalStatus FROM Criminal WHERE CriminalId IN (Select CriminalId from Case_Criminal Where CaseId=" + id + ")";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewCriminal.DataSource = reader;
            GridViewCriminal.DataBind();
        }

        private void LoadCharges(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string sql = "SELECT * FROM Charge WHERE CategoryId= " + id ;
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownListCharges.DataSource = dt;
            DropDownListCharges.DataTextField = "ChargeName";
            DropDownListCharges.DataValueField = "ChargeId";
            DropDownListCharges.DataBind();
            con.Close();

        }

        protected void GridViewCriminal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["CriminalId"] = GridViewCriminal.SelectedRow.Cells[1].Text;
            int a = Convert.ToInt32(Session["CriminalId"]);
            using (var context = new SPContext())
            {
                Criminal criminal = context.Criminals.SingleOrDefault(x => x.CriminalId == a);
                ShowSuccessMessage(criminal.CriminalName + " Has been selected");
                Add.Visible = true;
            }
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            try
            {
                using (var data = new SPContext())
                {
                    Charge_Criminal_Case ccc = new Charge_Criminal_Case();
                    ccc.CaseId = Convert.ToInt32(Session["CaseId"]);
                    ccc.CriminalId = Convert.ToInt32(Session["CriminalId"]);
                    ccc.ChargeId = Convert.ToInt32(DropDownListCharges.SelectedItem.Value);
                    ccc.ChargeAddedOn = Convert.ToDateTime(System.DateTime.Now);
                    data.Charge_Criminal_Case.Add(ccc);
                    data.SaveChanges();
                    this.ShowSuccessMessage("Charge Has been successfully added!");
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

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ViewCase.aspx");
        }
    }
}