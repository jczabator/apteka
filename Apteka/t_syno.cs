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
    
    public partial class t_syno
    {
        public t_syno()
        {
            this.t_informacje = new HashSet<t_informacje>();
        }
    
        public int pk_syno_id_num { get; set; }
        public string nazwa_char { get; set; }
    
        public virtual ICollection<t_informacje> t_informacje { get; set; }
    }
}