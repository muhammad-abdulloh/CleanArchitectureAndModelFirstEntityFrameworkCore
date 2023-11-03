using Demo.Domain.BaseModels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.BaseModels.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public Status Status { get; set; } = Status.Created;

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifyDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
