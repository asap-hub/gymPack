﻿using gym.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace gym.Application.DTOs.ProgressDtos
{
    public class ProgressDto : BaseIdDto
    {
        public string Status { get; set; }  
        public int Percentage { get; set; }
        public bool Completed { get; set; }
        public bool Confirmed { get; set; }
        public string ConfirmedBy { get; set; } 
    }
}
