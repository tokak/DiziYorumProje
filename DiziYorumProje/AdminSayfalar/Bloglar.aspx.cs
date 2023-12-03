using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entitiy;
namespace DiziYorumProje.AdminSayfalar
{
    public partial class Bloglar : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(Session["KULLANICI"].ToString());//sisteme giriş yapan kişinin adını yazdırma

            if (Session["KULLANICI"]==null)
            {
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                Response.Write("Hoşgeldiniz : "+Session["KULLANICI"].ToString());
            }
            var valuesBLog = db.TBLBLOG.ToList();
            Repeater1.DataSource = valuesBLog;
            Repeater1.DataBind();
        }
    }
}