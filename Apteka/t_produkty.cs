//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apteka
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_produkty
    {
        public int Id { get; set; }
        public decimal cena { get; set; }
        public int sklep_id { get; set; }
        public int lek_id { get; set; }
        public int ilosc { get; set; }
    
        public virtual t_sklepy t_sklepy { get; set; }
        public virtual t_leki t_leki { get; set; }
    }
}