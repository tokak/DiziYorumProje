using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entitiy;

namespace DiziYorumProje
{
    public partial class Default : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var bloglar = db.TBLBLOG.ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();

            var kategoriler = db.TBLKATEGORI.ToList();
            Repeater2.DataSource = kategoriler;
            Repeater2.DataBind();

            var sonBloglar = db.TBLBLOG.OrderByDescending(x=>x.BLOGBASLIK).Take(5).ToList();
            Repeater3.DataSource = sonBloglar;
            Repeater3.DataBind();

            var sonYorumlar = db.TBLYORUM.OrderByDescending(x => x.YORUMID).Take(5).ToList();            
            Repeater4.DataSource = sonYorumlar;
            Repeater4.DataBind();

        



        }
    }
}