﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using ASM.Models;

namespace ASM.ViewModel
{
    public class CreateBookViewModel
    {
        public Book Book { get; set; } = null!;

        [ValidateNever]
        public SelectList Categories { get; set; } = null!;
    }
}
