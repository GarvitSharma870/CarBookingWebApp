using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class TimeZone : BaseEntity
    {
        public int Id { get; set; }

        public string TimeZoneName { get; set; }

        public string UTCOffset { get; set; }

    }
}
