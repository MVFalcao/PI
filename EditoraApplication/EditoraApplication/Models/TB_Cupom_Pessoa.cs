//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EditoraApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_Cupom_Pessoa
    {
        public int ID_Cupom_Pessoa { get; set; }
        public int ID_Cupom { get; set; }
        public int ID_Pessoa { get; set; }
    
        public virtual TB_Cupom TB_Cupom { get; set; }
        public virtual TB_Pessoa TB_Pessoa { get; set; }
    }
}
