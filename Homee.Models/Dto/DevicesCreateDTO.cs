﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homee.Models.Dto;

public class DevicesCreateDTO
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string DeviceType { get; set; }
    public string Location { get; set; }
}