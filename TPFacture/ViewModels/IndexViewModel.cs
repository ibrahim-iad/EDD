using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TPFacture.ViewModels
{
    public class IndexViewModel
    {
        [Display(Name="Ancien index")]
        public int DernierIndex { get; set; }
        [Display(Name = "Index courant")]
        public int IndexActif { get; set; }
    }
}