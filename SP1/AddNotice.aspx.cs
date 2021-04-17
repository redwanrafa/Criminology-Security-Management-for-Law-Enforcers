using SP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SP1
{
    public partial class AddNotice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PoliceId"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            using (var data = new SPContext())
            {
                Notice notice = new Notice();
                notice.Notice1 = TextBox1.Text;
                notice.NoticeSubject = TextBox2.Text;
                notice.NoticeDate = System.DateTime.Now;
                data.Notices.Add(notice);
                data.SaveChanges();
                this.ShowSuccessMessage("Notice Added!");
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