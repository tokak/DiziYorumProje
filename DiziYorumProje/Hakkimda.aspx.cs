using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entitiy;

namespace DiziYorumProje
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var aciklama = db.TBLHAKKIMIZDA.ToList();
            Repeater1.DataSource = aciklama;
            Repeater1.DataBind();
        }
    }
}