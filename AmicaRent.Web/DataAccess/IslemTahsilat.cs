//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class IslemTahsilat
    {
        public int IslemTahsilat_ID { get; set; }
        public Nullable<int> Islem_ID { get; set; }
        public Nullable<System.DateTime> IslemTahsilat_Tarih { get; set; }
        public string IslemTahsilat_Aciklama { get; set; }
        public Nullable<int> OdemeTipi_ID { get; set; }
        public Nullable<double> IslemTahsilat_Tutar { get; set; }
        public Nullable<System.DateTime> IslemTahsilat_CreateDate { get; set; }
    }
}
