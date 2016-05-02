using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetalNameGenWebApp.ViewModels
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            List<SelectListItem> nameCountOptions = new List<SelectListItem>();

            for(int i = 1; i <= 3; i++) {
                nameCountOptions.Add(new SelectListItem() { Value = i.ToString(), Text =  i.ToString()});
            }

            NameCountOptions = nameCountOptions;
        }

        
        [Required]
        public int SelectedNameCountOptionValue { get; set; }

        public string MetalName { get; set; }

        public IEnumerable<SelectListItem> NameCountOptions { get; set; }
    }
}