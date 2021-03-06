﻿using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class Company : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
    }
}
