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
    public partial class Reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Jan();
            this.Feb();
            this.Mar();
            this.Apr();
            this.May();
            this.Jun();
            this.Jul();
            this.Aug();
            this.Sep();
            this.Oct();
            this.Nov();
            this.Dec();
        }

        private void Jan()
        {
            using (var context = new SPContext())
            {
                DateTime End = Convert.ToDateTime("2017 - 01 - 31");
                DateTime Start = Convert.ToDateTime("2017 - 01 - 01");
                var result = from m in context.Cases where m.CaseAddedOn <= End && m.CaseAddedOn >= Start select m;
                int TotalAdded = result.Count();
                var result1 = from m in context.Cases where m.CaseInvestigationReportOn <= End && m.CaseInvestigationReportOn >= Start select m;
                int TotalSolved = result1.Count();
                Report r = context.Reports.SingleOrDefault(x => x.MonthId == 1);
                r.NoOfCaseAdded = TotalAdded;
                r.NoOfCaseSolved = TotalSolved;
                context.SaveChanges();

            }
        }

        private void Feb()
        {
            using (var context = new SPContext())
            {
                DateTime End = Convert.ToDateTime("2017 - 02 - 28");
                DateTime Start = Convert.ToDateTime("2017 - 02 - 01");
                var result = from m in context.Cases where m.CaseAddedOn <= End && m.CaseAddedOn >= Start select m;
                int TotalAdded = result.Count();
                var result1 = from m in context.Cases where m.CaseInvestigationReportOn <= End && m.CaseInvestigationReportOn >= Start select m;
                int TotalSolved = result1.Count();
                Report r = context.Reports.SingleOrDefault(x => x.MonthId == 2);
                r.NoOfCaseAdded = TotalAdded;
                r.NoOfCaseSolved = TotalSolved;
                context.SaveChanges();

            }
        }

        private void Mar()
        {
            using (var context = new SPContext())
            {
                DateTime End = Convert.ToDateTime("2017 - 03 - 31");
                DateTime Start = Convert.ToDateTime("2017 - 03 - 01");
                var result = from m in context.Cases where m.CaseAddedOn <= End && m.CaseAddedOn >= Start select m;
                int TotalAdded = result.Count();
                var result1 = from m in context.Cases where m.CaseInvestigationReportOn <= End && m.CaseInvestigationReportOn >= Start select m;
                int TotalSolved = result1.Count();
                Report r = context.Reports.SingleOrDefault(x => x.MonthId == 3);
                r.NoOfCaseAdded = TotalAdded;
                r.NoOfCaseSolved = TotalSolved;
                context.SaveChanges();

            }
        }

        private void Apr()
        {
            using (var context = new SPContext())
            {
                DateTime End = Convert.ToDateTime("2017 - 04 - 30");
                DateTime Start = Convert.ToDateTime("2017 - 04 - 01");
                var result = from m in context.Cases where m.CaseAddedOn <= End && m.CaseAddedOn >= Start select m;
                int TotalAdded = result.Count();
                var result1 = from m in context.Cases where m.CaseInvestigationReportOn <= End && m.CaseInvestigationReportOn >= Start select m;
                int TotalSolved = result1.Count();
                Report r = context.Reports.SingleOrDefault(x => x.MonthId == 4);
                r.NoOfCaseAdded = TotalAdded;
                r.NoOfCaseSolved = TotalSolved;
                context.SaveChanges();

            }
        }

        private void May()
        {
            using (var context = new SPContext())
            {
                DateTime End = Convert.ToDateTime("2017 - 05 - 31");
                DateTime Start = Convert.ToDateTime("2017 - 05 - 01");
                var result = from m in context.Cases where m.CaseAddedOn <= End && m.CaseAddedOn >= Start select m;
                int TotalAdded = result.Count();
                var result1 = from m in context.Cases where m.CaseInvestigationReportOn <= End && m.CaseInvestigationReportOn >= Start select m;
                int TotalSolved = result1.Count();
                Report r = context.Reports.SingleOrDefault(x => x.MonthId == 5);
                r.NoOfCaseAdded = TotalAdded;
                r.NoOfCaseSolved = TotalSolved;
                context.SaveChanges();

            }
        }

        private void Jun()
        {
            using (var context = new SPContext())
            {
                DateTime End = Convert.ToDateTime("2017 - 06 - 30");
                DateTime Start = Convert.ToDateTime("2017 - 06 - 01");
                var result = from m in context.Cases where m.CaseAddedOn <= End && m.CaseAddedOn >= Start select m;
                int TotalAdded = result.Count();
                var result1 = from m in context.Cases where m.CaseInvestigationReportOn <= End && m.CaseInvestigationReportOn >= Start select m;
                int TotalSolved = result1.Count();
                Report r = context.Reports.SingleOrDefault(x => x.MonthId == 6);
                r.NoOfCaseAdded = TotalAdded;
                r.NoOfCaseSolved = TotalSolved;
                context.SaveChanges();

            }
        }

        private void Jul()
        {
            using (var context = new SPContext())
            {
                DateTime End = Convert.ToDateTime("2017 - 07 - 31");
                DateTime Start = Convert.ToDateTime("2017 - 07 - 01");
                var result = from m in context.Cases where m.CaseAddedOn <= End && m.CaseAddedOn >= Start select m;
                int TotalAdded = result.Count();
                var result1 = from m in context.Cases where m.CaseInvestigationReportOn <= End && m.CaseInvestigationReportOn >= Start select m;
                int TotalSolved = result1.Count();
                Report r = context.Reports.SingleOrDefault(x => x.MonthId == 7);
                r.NoOfCaseAdded = TotalAdded;
                r.NoOfCaseSolved = TotalSolved;
                context.SaveChanges();

            }
        }

        private void Aug()
        {
            using (var context = new SPContext())
            {
                DateTime End = Convert.ToDateTime("2017 - 08 - 31");
                DateTime Start = Convert.ToDateTime("2017 - 08 - 01");
                var result = from m in context.Cases where m.CaseAddedOn <= End && m.CaseAddedOn >= Start select m;
                int TotalAdded = result.Count();
                var result1 = from m in context.Cases where m.CaseInvestigationReportOn <= End && m.CaseInvestigationReportOn >= Start select m;
                int TotalSolved = result1.Count();
                Report r = context.Reports.SingleOrDefault(x => x.MonthId == 8);
                r.NoOfCaseAdded = TotalAdded;
                r.NoOfCaseSolved = TotalSolved;
                context.SaveChanges();

            }
        }
        private void Sep()
        {
            using (var context = new SPContext())
            {
                DateTime End = Convert.ToDateTime("2017 - 09 - 30");
                DateTime Start = Convert.ToDateTime("2017 - 09 - 01");
                var result = from m in context.Cases where m.CaseAddedOn <= End && m.CaseAddedOn >= Start select m;
                int TotalAdded = result.Count();
                var result1 = from m in context.Cases where m.CaseInvestigationReportOn <= End && m.CaseInvestigationReportOn >= Start select m;
                int TotalSolved = result1.Count();
                Report r = context.Reports.SingleOrDefault(x => x.MonthId == 9);
                r.NoOfCaseAdded = TotalAdded;
                r.NoOfCaseSolved = TotalSolved;
                context.SaveChanges();

            }
        }

        private void Oct()
        {
            using (var context = new SPContext())
            {
                DateTime End = Convert.ToDateTime("2017 - 10 - 31");
                DateTime Start = Convert.ToDateTime("2017 - 10 - 01");
                var result = from m in context.Cases where m.CaseAddedOn <= End && m.CaseAddedOn >= Start select m;
                int TotalAdded = result.Count();
                var result1 = from m in context.Cases where m.CaseInvestigationReportOn <= End && m.CaseInvestigationReportOn >= Start select m;
                int TotalSolved = result1.Count();
                Report r = context.Reports.SingleOrDefault(x => x.MonthId == 10);
                r.NoOfCaseAdded = TotalAdded;
                r.NoOfCaseSolved = TotalSolved;
                context.SaveChanges();

            }
        }

        private void Nov()
        {
            using (var context = new SPContext())
            {
                DateTime End = Convert.ToDateTime("2017 - 11 - 30");
                DateTime Start = Convert.ToDateTime("2017 - 11 - 01");
                var result = from m in context.Cases where m.CaseAddedOn <= End && m.CaseAddedOn >= Start select m;
                int TotalAdded = result.Count();
                var result1 = from m in context.Cases where m.CaseInvestigationReportOn <= End && m.CaseInvestigationReportOn >= Start select m;
                int TotalSolved = result1.Count();
                Report r = context.Reports.SingleOrDefault(x => x.MonthId == 11);
                r.NoOfCaseAdded = TotalAdded;
                r.NoOfCaseSolved = TotalSolved;
                context.SaveChanges();

            }
        }

        private void Dec()
        {
            using (var context = new SPContext())
            {
                DateTime End = Convert.ToDateTime("2017 - 12 - 31");
                DateTime Start = Convert.ToDateTime("2017 - 12 - 01");
                var result = from m in context.Cases where m.CaseAddedOn <= End && m.CaseAddedOn >= Start select m;
                int TotalAdded = result.Count();
                var result1 = from m in context.Cases where m.CaseInvestigationReportOn <= End && m.CaseInvestigationReportOn >= Start select m;
                int TotalSolved = result1.Count();
                Report r = context.Reports.SingleOrDefault(x => x.MonthId == 12);
                r.NoOfCaseAdded = TotalAdded;
                r.NoOfCaseSolved = TotalSolved;
                context.SaveChanges();

            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Home.aspx");
        }
    }
    }
