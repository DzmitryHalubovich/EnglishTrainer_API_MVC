﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTrainer.Entities.DTO.Create
{
    public class WordCreateDTO
    {
        public string Name { get; set; }
        public string Translations { get; set; }
        public string? Description { get; set; }
    }
}
