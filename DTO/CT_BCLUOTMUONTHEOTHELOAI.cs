//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class CT_BCLUOTMUONTHEOTHELOAI
    {
        public string MaBaoCao { get; set; }
        public string MaTheLoai { get; set; }
        public Nullable<int> SoLuotMuon { get; set; }
        public Nullable<decimal> TiLe { get; set; }
    
        public virtual BCLUOTMUONTHEOTHELOAI BCLUOTMUONTHEOTHELOAI { get; set; }
        public virtual THELOAI THELOAI { get; set; }
    }
}