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
    
    public partial class Servis
    {
        public int Servis_ID { get; set; }
        public Nullable<int> Arac_ID { get; set; }
        public Nullable<System.DateTime> Servis_ServisZamani { get; set; }
        public Nullable<int> ServisFirma_ID { get; set; }
        public string Servis_Notlar { get; set; }
        public Nullable<double> Servis_Ucreti { get; set; }
        public Nullable<System.DateTime> Servis_CreateDate { get; set; }
    }
}
