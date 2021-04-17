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
    public partial class ViewCase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PoliceId"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            int a = Convert.ToInt32(Session["CaseId"]);
            this.LoadCase(a);
            this.InvOfficerCheck();
            this.InvOfficerReassign();
            this.LoadVerdict(a);
        }

        private void LoadVerdict(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string sql = "Select Verdict,(Select CourtName from Court where Court.CourtId=Verdict.CourtId)As CourtName,VerdictAddedOn From Verdict Where CaseId=" + id;
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewVerdict.DataSource = reader;
            GridViewVerdict.DataBind();
        }
        private void LoadCase(int id)
        {
            using (var context = new SPContext())
            {
                Case ca = context.Cases.SingleOrDefault(x => x.CaseId == id);
                LabelType.Text = ca.CaseType;
                if(ca.CaseType== "Criminal")
                {
                    Label11.Enabled = false;
                    Label11.Visible = false;
                    LabelCDefendent.Enabled = false;
                    LabelCDefendent.Visible = false;
                    CrimeCategory ccat = context.CrimeCategories.SingleOrDefault(x => x.CategoryId == ca.CrimeCategoryId);
                    LabelCrimeCat.Text = ccat.CategoryName;
                    this.LoadCriminal(Convert.ToInt32(Session["CaseId"]));
                }
                else
                {
                    Label26.Visible = false;
                    Label26.Enabled = false;
                    LabelCrimeCat.Visible = false;
                    LabelCrimeCat.Enabled = false;
                    Label29.Visible = false;
                    Label29.Enabled = false;
                    GridViewCriminal.Visible = false;
                    GridViewCriminal.Enabled = false;
                    Label11.Enabled = true;
                    Label11.Visible = true;
                    LabelCDefendent.Text = ca.CaseDefendents;

                }
                LabelCDetails.Text = ca.CaseDetails;
                LabelInventory.Text = ca.CaseInventory;
                int f = ca.CaseDivisionId;
                int g = ca.CaseDistrictId;
                int h = ca.CaseBranchId;
                Division division = context.Divisions.SingleOrDefault(x => x.DivisionId == f);
                LabelDivision.Text = division.DivisionName;
                District district = context.Districts.SingleOrDefault(x => x.DistrictId == g);
                LabelDistrict.Text = district.DistrictName;
                Branch branch = context.Branches.SingleOrDefault(x => x.BranchId == h);
                LabelBranch.Text = branch.BranchName;
                Police po = context.Police.SingleOrDefault(x => x.PoliceId == ca.CaseInvestigationOfficerId);
                LabelInvName.Text = po.PoliceName;
                if (ca.CasePlaintiffedOfficerId != null)
                {
                    LabelCPlaintiffBy.Text = "Police";
                    Police po1 = context.Police.SingleOrDefault(x => x.PoliceId == ca.CasePlaintiffedOfficerId);
                    LabelPlaintiffByName.Text = po1.PoliceName;
                    GridViewPlaintiff.Visible = false;
                    GridViewPlaintiff.Enabled = false;

                }
                else
                {
                    LabelCPlaintiffBy.Text = "Civilian";
                    LabelPlaintiffByName.Visible = false;
                    this.LoadPlaintiff(Convert.ToInt32(Session["CaseId"]));

                }
                LabelStatus.Text = ca.CaseStatus;
                this.LoadWitness(Convert.ToInt32(Session["CaseId"]));
                Court court = context.Courts.SingleOrDefault(x => x.CourtId == ca.CaseCurrentCourtId);
                LabelCourt.Text = court.CourtName;
                LabelCaseAddOn.Text = ca.CaseAddedOn.ToShortDateString();
                LabelInvReport.Text = ca.CaseInvestigationReport;
                DateTime? invdate = ca.CaseInvestigationReportOn;
                if (invdate != null)
                {
                    LabelInvAddOn.Text =invdate.Value.ToShortDateString();

                }
                DateTime? enddate = ca.CaseInvOfficerOn;
                if (enddate != null)
                {
                    LabelInvTimeRemain.Text = (enddate.Value.AddDays(45) - (System.DateTime.Now)).Days.ToString();
                     
                 }
            }
        }

        private void LoadCriminal(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string sql = "SELECT CriminalId,CriminalName,CriminalFathersName,CriminalMothersName,CriminalGender,(Select DivisionName From Division Where DivisionId=CriminalDivision)As Division,(Select DistrictName From District Where DistrictId=CriminalDistrict)As District,(Select BranchName From Branch Where BranchId=CriminalBranch)As Branch,CriminalStatus FROM Criminal WHERE CriminalId IN (Select CriminalId from Case_Criminal Where CaseId=" + id+")";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewCriminal.DataSource = reader;
            GridViewCriminal.DataBind();
        }

        private void LoadWitness(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string sql = "SELECT WitnessId,WitnessName,WitnessFathersName,WitnessMothersName,(Select DivisionName From Division Where DivisionId=WitnessDivision)As Division,(Select DistrictName From District Where DistrictId=WitnessDistrict)As District,(Select BranchName From Branch Where BranchId=WitnessBranch)As Branch FROM Witness Where WitnessId IN (Select WitnessId from Case_Witness Where CaseId=" + id + ")";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewWitness.DataSource = reader;
            GridViewWitness.DataBind();
        }

        private void InvOfficerReassign()
        {
            using (var context = new SPContext())
            {
                int a = Convert.ToInt32(Session["CaseId"]);
                Case ca = context.Cases.SingleOrDefault(x => x.CaseId == a);
                int b = Convert.ToInt32(Session["PoliceId"]);
                int c = ca.CaseInvestigationOfficerId;
                Police police = context.Police.SingleOrDefault(x => x.PoliceId == b);
                Police police1 = context.Police.SingleOrDefault(x => x.PoliceId == c);
                if(police.PoliceCurrentRank2 < police1.PoliceCurrentRank2 && police.PoliceCurrentRank2 < 10)
                {
                    ButtonReassignInv.Enabled = true;
                    ButtonReassignInv.Visible = true;
                }
            }

        }

        private void InvOfficerCheck()
        {
            using (var context = new SPContext())
            {
                int a = Convert.ToInt32(Session["CaseId"]);
                Case ca = context.Cases.SingleOrDefault(x => x.CaseId == a );
                if(Convert.ToInt32(Session["PoliceId"])==ca.CaseInvestigationOfficerId)
                {
                    if (ca.CaseInvestigationReport == null)
                    {
                        if (ca.CaseType == "Criminal")
                        {
                            ButtonInvReport.Enabled = true;
                            ButtonInvReport.Visible = true;
                            ButtonCriminal.Enabled = true;
                            ButtonCriminal.Visible = true;
                            ButtonWitness.Enabled = true;
                            ButtonWitness.Visible = true;
                            ButtonCharge.Enabled = true;
                            ButtonCharge.Visible = true;
                            if (ca.CasePlaintiffedOfficerId == null)
                            {
                                ButtonVerdict.Enabled = true;
                                ButtonVerdict.Visible = true;
                            }
                        }
                        else
                        {
                            ButtonInvReport.Enabled = true;
                            ButtonInvReport.Visible = true;
                            ButtonWitness.Enabled = true;
                            ButtonWitness.Visible = true;
                            if (ca.CasePlaintiffedOfficerId == null)
                            {
                                ButtonVerdict.Enabled = true;
                                ButtonVerdict.Visible = true;
                            }
                        }
                    }
                    else
                    {
                        if (ca.CasePlaintiffedOfficerId == null)
                        {
                            ButtonVerdict.Enabled = true;
                            ButtonVerdict.Visible = true;
                        }
                    }  
                }
                if(ca.CasePlaintiffedOfficerId != null && ca.CasePlaintiffedOfficerId==Convert.ToInt32(Session["PoliceId"]))
                {
                    ButtonVerdict.Enabled = true;
                    ButtonVerdict.Visible = true;
                }
            }
        }
        private void LoadPlaintiff(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string sql = "SELECT PlaintiffId,PlaintiffName,PlaintiffFathersName,PlaintiffMothersName,(Select DivisionName From Division Where DivisionId=PlaintiffDivision)As Division,(Select DistrictName From District Where DistrictId=PlaintiffDistrict)As District,(Select BranchName From Branch Where BranchId=PlaintiffBranch)As Branch FROM Plaintiff Where PlaintiffId IN (Select PlaintiffId from Case_Plaintiff Where CaseId=" + id + ")";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridViewPlaintiff.DataSource = reader;
            GridViewPlaintiff.DataBind();
        }

        protected void GridViewWitness_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["WitnessId"]=GridViewWitness.SelectedRow.Cells[1].Text;
            Response.Redirect("/ViewWitness.aspx");
        }

        protected void GridViewCriminal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["CriminalId"]=GridViewCriminal.SelectedRow.Cells[1].Text;
            Response.Redirect("/ViewCriminal2.aspx");
        }

        protected void GridViewPlaintiff_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["PlaintiffId"] = GridViewPlaintiff.SelectedRow.Cells[1].Text;
            Response.Redirect("/ViewPlaintiff.aspx");
        }

        protected void ButtonCriminal_Click(object sender, EventArgs e)
        {
            Response.Redirect("/CriminalReg2.aspx");
        }

        protected void ButtonWitness_Click(object sender, EventArgs e)
        {
            Response.Redirect("/WitnessReg2.aspx");
        }

        protected void ButtonInvReport_Click(object sender, EventArgs e)
        {
            this.ShowErrorMessage("Reminder! You must have to full fill all other information regarding to case before clicking submit button , Once submit button is clicked Case can not be modified further more !!!");
            if (InvReport.Enabled == false)
            {
                InvReport.Enabled = true;
                InvReport.Visible = true;
                Submit.Enabled = true;
                Submit.Visible = true;
            }
            else
            {
                InvReport.Enabled = false;
                InvReport.Visible = false;
                Submit.Enabled = false;
                Submit.Visible = false;
            }

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new SPContext())
                {
                    int a = Convert.ToInt32(Session["CaseId"]);
                    Case ca = context.Cases.SingleOrDefault(x => x.CaseId == a);
                    ca.CaseInvestigationReport = InvReport.Text;
                    ca.CaseInvestigationReportOn = Convert.ToDateTime(System.DateTime.Now);
                    ca.CaseStatus = "Under Trial";
                    context.SaveChanges();
                    this.ShowSuccessMessage("Investigation Report Has Successfully been submitted!");

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

        protected void ButtonReassignInv_Click(object sender, EventArgs e)
        {
            if(Label36.Enabled == false)
            {
                Label36.Enabled = true;
                Label36.Visible = true;
                InvestOfficerName.Enabled = true;
                InvestOfficerName.Visible = true;
                AddInvOfficer.Enabled = true;
                AddInvOfficer.Visible = true;
                officersearchinvest.Enabled = true;
                officersearchinvest.Visible = true;
                SearchInvestigationOfficer.Enabled = true;
                SearchInvestigationOfficer.Visible = true;
                GridViewInvestOfficer.Enabled = true;
                GridViewInvestOfficer.Visible = true;
            }
            else
            {
                Label36.Enabled = false;
                Label36.Visible = false;
                InvestOfficerName.Enabled = false;
                InvestOfficerName.Visible = false;
                AddInvOfficer.Enabled = false;
                AddInvOfficer.Visible = false;
                officersearchinvest.Enabled = false;
                officersearchinvest.Visible = false;
                SearchInvestigationOfficer.Enabled = false;
                SearchInvestigationOfficer.Visible = false;
                GridViewInvestOfficer.Enabled = false;
                GridViewInvestOfficer.Visible = false;
            }
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

        protected void AddInvOfficer_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new SPContext())
                {
                    int a = Convert.ToInt32(Session["CaseId"]);
                    Case ca = context.Cases.SingleOrDefault(x => x.CaseId == a);
                    ca.CaseInvestigationOfficerId = Convert.ToInt32(Session["InvestigationOfficerId"]);
                    ca.CaseInvOfficerOn = Convert.ToDateTime(System.DateTime.Now);
                    context.SaveChanges();
                    this.ShowSuccessMessage("Investigation officer Has Successfully been Reassigned!");

                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex.ToString());
            }
        }

        protected void ButtonCharge_Click(object sender, EventArgs e)
        {
            using (var context = new SPContext())
            {
                int a = Convert.ToInt32(Session["CaseId"]);
                Case ca = context.Cases.SingleOrDefault(x => x.CaseId == a);
                Session["CrimeCatagory"] = ca.CrimeCategoryId;
                Session["CriminalId"] = null;
                Response.Redirect("/AddCharges.aspx");


            }
        }

        protected void ButtonVerdict_Click(object sender, EventArgs e)
        {
            using (var context = new SPContext())
            {
                int a = Convert.ToInt32(Session["CaseId"]);
                Case ca = context.Cases.SingleOrDefault(x => x.CaseId == a);
                if (ca.CaseStatus == "Under Trial")
                {
                    Response.Redirect("/AddVerdict.aspx");
                }
                else
                {
                    ShowErrorMessage("Investigation Report Must need to be submitted first !");
                }
                }
        }
    }
}