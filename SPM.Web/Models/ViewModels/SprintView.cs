﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPM.Web.Models.ViewModels
{
    public class SprintView
    {
        public Sprint Sprint { get; set; }
        public List<ItemView> Items { get; set; }
    }
}
