using SP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SP1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new SPContext())
                {
                    var result = from m in context.Police where m.PoliceUserName == Login1.UserName && m.PolicePassword == Login1.Password select m;
                    if (result.Count() > 0)
                    {

                        Police police = context.Police.SingleOrDefault(x => x.PoliceUserName == Login1.UserName);
                        if (police.PoliceStatus == "Active")
                        {
                            Session["PoliceId"] = Convert.ToInt32(police.PoliceId);
                            Session["PoliceName"] = police.PoliceName;
                            Session["Rank1"] = Convert.ToInt32(police.PoliceCurrentRank1);
                            Session["Rank2"] = Convert.ToInt32(police.PoliceCurrentRank2);
                            int a = Convert.ToInt32(Session["Rank2"]);
                            Rank2 rank2 = context.Rank2.SingleOrDefault(x => x.Rank2Id == a);
                            Session["Rank2Name"] = rank2.Rank2Name;
                            Response.Redirect("~/Home.aspx");
                            //Response.Write("Successful");
                        }
                        else
                        {
                            Login1.FailureText= "You have been suspended! Access Denied !";
                        }
                    }
                    else
                    {
                        
                        Login1.FailureText= "Error!User Name & Password does not Match";
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Login1.FailureText=ex.ToString();
            }
        }
    }
    }
