using Practica_EF.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practica_EF.MVC.Models
{
    public class TerritoriesView
    {
        [Required]
        [StringLength(20)]
        public string Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

       
    }
}