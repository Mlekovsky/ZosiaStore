using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class News : AuditableEntity
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
