//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiziYorumProje.Entitiy
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLBLOG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLBLOG()
        {
            this.TBLYORUM = new HashSet<TBLYORUM>();
        }
    
        public int BLOGID { get; set; }
        public string BLOGBASLIK { get; set; }
        public string BLOGICERIK { get; set; }
        public Nullable<System.DateTime> BLOGTARIH { get; set; }
        public string BLOGGORSER { get; set; }
        public Nullable<int> BLOGTUR { get; set; }
        public Nullable<int> BLOGKATEGORI { get; set; }
    
        public virtual TBLKATEGORI TBLKATEGORI { get; set; }
        public virtual TBLTUR TBLTUR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLYORUM> TBLYORUM { get; set; }
    }
}
