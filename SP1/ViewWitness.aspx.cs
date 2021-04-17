using SP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SP1
{
    public partial class ViewWitness : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PoliceId"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            int a = Convert.ToInt32(Session["WitnessId"]);
            this.LoadWitness(a);
        }

        private void LoadWitness(int id)
        {
            using (var context = new SPContext())
            {
                Witness wit = context.Witnesses.SingleOrDefault(x => x.WitnessId == id);
                LabelName.Text = wit.WitnessName;
                LabelFName.Text = wit.WitnessFathersName;
                LabelMName.Text = wit.WitnessMothersName;
                LabelCAddress.Text = wit.WitnessAddress;
                int f = wit.WitnessDivision;
                int g = wit.WitnessDistrict;
                int h = wit.WitnessBranch;
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