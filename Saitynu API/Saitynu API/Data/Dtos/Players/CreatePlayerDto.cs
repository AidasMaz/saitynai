﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Saitynu_API.Data.Dtos.Players
{
    public record CreatePlayerDto([Required] string Nick, [Required] string Type);
}
