﻿using EnglishTrainer.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTrainer.Entities.DTO.Create
{
    public class ExampleCreateDTO
    {
        public string EnglishSentence { get; set; }
        public string? RussianSentence { get; set; }

    }
}
