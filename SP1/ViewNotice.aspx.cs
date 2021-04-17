using SP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SP1
{
    public partial class ViewNotice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PoliceId"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            int a = Convert.ToInt32(Session["NoticeId"]);
            this.LoadNotice(a);
            this.InvOfficerCheck();
        }

        private void LoadNotice(int id)
        {
            using (var data = new SPContext())
            {
                Notice notice = data.Notices.SingleOrDefault(x => x.NoticeId == id);
                LabelDate.Text = Convert.ToString(notice.NoticeDate);
                LabelSubject.Text = notice.NoticeSubject;
                Notice.Text = notice.Notice1;
            }

        }

        private void InvOfficerCheck()
        {
            if (Convert.ToInt32(Session["Rank2"]) < 5)
            {
                Delete.Enabled = true;
                Delete.Visible = true;
            }
        }
            

        private void DeleteNotice(int id)
        {
            using (var data = new SPContext())
            {
                Notice notice = data.Notices.SingleOrDefault(x => x.NoticeId == id);
                data.Notices.Remove(notice);
                data.SaveChanges();
                Response.Redirect("/Home.aspx");
            }
            }

        protected void Delete_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Session["NoticeId"]);
            this.DeleteNotice(a);
        }
    }
}