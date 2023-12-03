using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entitiy;
namespace DiziYorumProje.AdminSayfalar
{
    public partial class Yorulmar : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var valuesYorum = (from x in db.TBLYORUM
                               select new
                               {
                                   x.YORUMID,
                                   x.KULLANICIAD,
                                   x.TBLBLOG,
                                   x.MAIL,
                                   x.YORUMICERIK,
                                   x.TBLBLOG.BLOGBASLIK
                               }).ToList();
            Repeater1.DataSource = valuesYorum;
            Repeater1.DataBind();
        }
    }
}