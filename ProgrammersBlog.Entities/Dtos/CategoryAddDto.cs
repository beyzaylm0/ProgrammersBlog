﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
  public class CategoryAddDto
    {
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage="{0} Boş Geçilemez.")]
        [MaxLength(70,ErrorMessage ="{0} {1} Karakterden Büyük Olamaz.")]
        [MinLength(1,ErrorMessage ="{0} {1} Karakterden Az Olamaz.")]
        public string Name { get; set; }
        [DisplayName("Kategori Açıklaması")]
        [MaxLength(500, ErrorMessage = "{0} {1} Karakterden Büyük Olamaz.")]
        [MinLength(1, ErrorMessage = "{0} {1} Karakterden Az Olamaz.")]
        public string Description { get; set; }
        [DisplayName("Kategori Özel Not")]
        [MaxLength(500, ErrorMessage = "{0} {1} Karakterden Büyük Olamaz.")]
      
        public string Note { get; set; }
        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} Boş Geçilemez.")]
        public bool IsActive{ get; set; }
    }
}
