using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entitiy;


namespace DiziYorumProje.AdminSayfalar
{
    public partial class KategoriDetay : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var kategoriToBlog = db.TBLBLOG.Where(x => x.BLOGKATEGORI == id).ToList();
            var kategoriName = db.TBLKATEGORI.Where(x => x.KATEGORIID == id).Select(x => x.KATEGORIAD).FirstOrDefault();
            Label1.Text = kategoriName.ToString();
            Repeater1.DataSource = kategoriToBlog;
            Repeater1.DataBind();
            


        }
    }
}