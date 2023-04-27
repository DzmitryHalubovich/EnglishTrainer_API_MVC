﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTrainer.Entities.DTO.Read
{
    public record WordDTO(
        Guid Id,
        string Name,
        string? Translations,
        string? Description);
}
