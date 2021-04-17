using SP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SP1
{
    public partial class AddVerdict : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            using (var context = new SPContext())
            {
                int a = Convert.ToInt32(Session["CaseId"]);
                Case ca = context.Cases.SingleOrDefault(x => x.CaseId == a);
                Verdict verdict = new Verdict();
                verdict.CaseId = Convert.ToInt32(Session["CaseId"]);
                verdict.CourtId = Convert.ToInt32(ca.CaseCurrentCourtId);
                verdict.Verdict1 = Verdict.Text;
                if(ca.CaseType == "Criminal")
                {
                    if(ca.CaseCurrentCourtId != 10)
                    {
                        ca.CaseCurrentCourtId = ca.CaseCurrentCourtId--;
                        ca.CaseStatus = "Under Trial";
                    }
                    else
                    {
                        ca.CaseStatus = "Awaiting Execution";
                    }
                }
                else
                {
                    if (ca.CaseCurrentCourtId != 0)
                    {
                        ca.CaseCurrentCourtId = ca.CaseCurrentCourtId--;
                        ca.CaseStatus = "Under Trial";
                    }
                    else
                    {
                        ca.CaseStatus = "Awaiting Execution";
                    }

                }
                context.Verdicts.Add(verdict);
                context.SaveChanges();
                ShowSuccessMessage("Verdict Has successfully added");


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