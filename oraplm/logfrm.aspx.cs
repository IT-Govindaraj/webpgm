using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bom_automation
{
    public partial class logfrm : System.Web.UI.Page
    {
        sqldata sd = new sqldata();
        DataTable dt1;
        protected void Page_Load(object sender, EventArgs e)
        {
            string qstr = Request.QueryString["urg"];
            Session["SRG"] = qstr;

            if (qstr != null)
            {
                Session.Add("SRG", qstr);
                Response.Redirect("addition.aspx", false);
            }
        }

        protected void cmdsub_Click(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
            else
            {
                txtuser.Text = txtuser.Text.Replace("' Or 1=1 --", "");
                txtpass.Text = txtpass.Text.Replace("' Or 1=1 --", "");
                if (txtuser.Text != String.Empty & txtpass.Text != String.Empty)
                {
                    dt1 = sd.sqlpass("SELECT UNAME,PWD,RG,ORG,ORG_ID FROM JAN_TOOL_LOGIN WHERE UNAME='" + txtuser.Text + "' AND PWD=JAN_ENCRYPT('" + txtpass.Text + "') AND USER_FOR='TL_APP'");

                    if (dt1.Rows.Count > 0)
                    {
                        Session.Add("suser", txtuser.Text);
                        Session.Add("spass", txtpass.Text);
                        foreach (DataRow Title in dt1.Rows)
                        {
                            Session.Add("SRGS", Convert.ToString(Title["ORG"]));
                            Session.Add("SRG", Convert.ToString(Title["RG"]));
                            Session.Add("SORGID", Convert.ToString(Title["ORG_ID"]));
                        }

                        Response.Redirect("main.aspx", false);
                    }
                    else
                    {
                        txtuser.Text = String.Empty;
                        txtpass.Text = String.Empty;
                    }
                }
            }
        }
    }
}