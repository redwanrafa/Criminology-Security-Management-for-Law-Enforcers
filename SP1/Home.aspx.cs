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
    public partial class Home : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["PoliceId"]==null)
            {
                Response.Redirect("/Login.aspx");
            }
          
            //Label1.Text =Convert.ToString(Session["PoliceName"]);
            //Label2.Text = Convert.ToString(Session["Rank2Name"]);
            this.LoadCase(Convert.ToInt32(Session["PoliceId"]));
            this.LoadNotice();
        }
        private void LoadCase(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT CaseId,CaseType,(Select DivisionName From Division Where DivisionId=CaseDivisionId)As Division,(Select DistrictName From District Where DistrictId=CaseDistrictId)As District,(Select BranchName From Branch Where BranchId=CaseBranchId)As Branch,CaseAddedOn,(Select CategoryName From CrimeCategory Where CategoryId=CrimeCategoryId)As CrimeCategory,CaseStatus FROM [Case] WHERE CaseInvestigationOfficerId =" + id + " AND CaseStatus ='Under Investigation'";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewOnGoingCases.DataSource = reader;
            GridViewOnGoingCases.DataBind();
            con.Close();
        }

        private void LoadNotice()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string sql = "SELECT NoticeId,NoticeSubject,NoticeDate from Notice";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewNoticeBoard.DataSource = reader;
            GridViewNoticeBoard.DataBind();
            con.Close();
        }

        protected void GridViewOnGoingCases_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                Session["CaseId"] = GridViewOnGoingCases.SelectedRow.Cells[1].Text;
                Response.Redirect("/ViewCase.aspx");
            
        }

        protected void GridViewNoticeBoard_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["NoticeId"] = GridViewNoticeBoard.SelectedRow.Cells[1].Text;
            Response.Redirect("/ViewNotice.aspx");
        }
    }
}