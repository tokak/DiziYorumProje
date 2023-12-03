using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entitiy;
namespace DiziYorumProje.AdminSayfalar
{
    public partial class YeniBlog : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var valuesTur = (from x in db.TBLTUR
                                 select new
                                 {
                                     x.TURAD,
                                     x.TURID
                                 }).ToList();
                DropDownList1.DataSource = valuesTur;
                DropDownList1.DataBind();
                var valuesKategori = (from x in db.TBLKATEGORI
                                      select new
                                      {
                                          x.KATEGORIAD,
                                          x.KATEGORIID
                                      }).ToList();
                DropDownList2.DataSource = valuesKategori;
                DropDownList2.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLBLOG t = new TBLBLOG();
            t.BLOGBASLIK = TextBox1.Text;
            t.BLOGGORSER = TextBox3.Text;
            t.BLOGICERIK = TextBox4.Text;
            t.BLOGTARIH = Convert.ToDateTime(TextBox2.Text);
            t.BLOGTUR = int.Parse(DropDownList1.SelectedValue);
            t.BLOGKATEGORI = int.Parse(DropDownList2.SelectedValue);
            db.TBLBLOG.Add(t);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");
        }
    }
}