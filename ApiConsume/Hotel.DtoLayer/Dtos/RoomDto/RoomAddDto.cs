﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage = "Oda numarası boş bırakılamaz")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Fiyat bilgisi girilmesi gerekiyor")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Oda bilgisi girilmesi gerekiyor")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Yatak sayısı bilgisi girilmesi gerekiyor")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Banyo sayısı bilgisi girilmesi gerekiyor")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
