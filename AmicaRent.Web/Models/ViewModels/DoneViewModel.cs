﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.ViewModels
{
    public class DoneViewModel
    {
        public int Islem_Tipi { get; set; } = 3;

        [Required(ErrorMessage = "{0} Gerekli")]
        [Display(Name = "Ödeme Tipi")]
        public int? OdemeTipi_ID { get; set; }

        [Required(ErrorMessage = "{0} Gerekli")]
        [Display(Name = "Tahsilat Açıklama")]
        public string Tahsilat_Aciklama { get; set; }

        [Required(ErrorMessage = "{0} Gerekli")]
        [Display(Name = "Tahsil Edilen Ücret")]
        public double? Islem_TahsilEdilen { get; set; }


        [Required(ErrorMessage = "{0} Gerekli")]
        [Display(Name = "Tahsil Edilen Ücret")]
        public double? Islem_ToplamKiralamaUcreti { get; set; }

        [Required(ErrorMessage = "{0} Gerekli")]
        [Display(Name = "Toplam KM Aşım Ücreti")]
        public double? Islem_ToplamKMAsimUcreti { get; set; }

        [Required(ErrorMessage = "{0} Gerekli")]
        [Display(Name = "Toplam Ekstra Hizmetler")]
        public double? Islem_ToplamEkstraHizmetler { get; set; }

        [Required(ErrorMessage = "{0} Gerekli")]
        [Display(Name = "Toplam Vale Hizmetleri")]
        public double? Islem_ToplamValeHizmetleri { get; set; }

        [Required(ErrorMessage = "{0} Gerekli")]
        [Display(Name = "Toplam Diğer Ücretler")]
        public double? Islem_ToplamDigerUcretler { get; set; }

        [Required(ErrorMessage = "{0} Gerekli")]
        [Display(Name = "Son KM")]
        public int? Islem_SonKM { get; set; }

    }
}