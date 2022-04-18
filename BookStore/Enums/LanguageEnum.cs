using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Enums
{
    public enum LanguageEnum
    {
        [Display(Name = "Telugu language")]
        Telugu = 10,
        [Display(Name = "English language")]
        English = 11,
        [Display(Name = "French language")]
        French = 12,
        [Display(Name = "Chinese language")]
        Chinese = 13,
        [Display(Name = "Spanish language")]
        Spanish = 14
    }
}