﻿using System;
using System.ComponentModel.DataAnnotations;
using CSharpToPlantUML.Converter;
using CSharpToPlantUML.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpToPlantUML.Pages
{
    public class IndexModel : PageModel
    {
        [Required]
        [BindProperty]
        public string CSharpSource { get; set; }

        [Required]
        [BindProperty]
        public DiagramInputFormat InputFormat { get; set; }

        [Required]
        [BindProperty]
        public DiagramOutputFormat OutputFormat { get; set; }

        [BindProperty]
        public Conversion Conversion { get; set; }
        
        public IActionResult OnPost()
        {
            try
            {
                string puml;
                if(InputFormat== DiagramInputFormat.CSharp) 
                    puml = SourceToPlantUMLConverter.GetPlantUml(CSharpSource);
                else puml = CSharpSource;

                Conversion = Conversion.FromPlantUML(puml);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Conversion = Conversion.Failure();
            }
            return Page();
        }
    }
}