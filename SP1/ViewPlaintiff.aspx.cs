using SP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SP1
{
    public partial class ViewPlaintiff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PoliceId"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            int a = Convert.ToInt32(Session["PlaintiffId"]);
            this.LoadPlaintiff(a);
        }

        private void LoadPlaintiff(int id)
        {
            using (var context = new SPContext())
            {
                Plaintiff plaintiff = context.Plaintiffs.SingleOrDefault(x => x.PlaintiffId == id);
                LabelName.Text = plaintiff.PlaintiffName;
                LabelFName.Text = plaintiff.PlaintiffFathersName;
                LabelMName.Text = plaintiff.PlaintiffMothersName;
                LabelCAddress.Text = plaintiff.PlaintiffAddress;
                int f = plaintiff.PlaintiffDivision;
                int g = plaintiff.PlaintiffDistrict;
                int h = plaintiff.PlaintiffBranch;
                Division division = context.Divisions.SingleOrDefault(x => x.DivisionId == f);
                LabelDivision.Text = division.DivisionName;
                District district = context.Districts.SingleOrDefault(x => x.DistrictId == g);
                LabelDistrict.Text = district.DistrictName;
                Branch branch = context.Branches.SingleOrDefault(x => x.BranchId == h);
                LabelBranch.Text = branch.BranchName;
            }
        }
    }
}