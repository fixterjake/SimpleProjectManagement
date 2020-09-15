﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jacob.Boyles.SPM.Models
{
    public class TaskMember
    {
        [Key]
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int MemberId { get; set; }
    }
}