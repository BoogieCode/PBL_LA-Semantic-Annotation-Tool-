using System;
using System.Collections.Generic;

#nullable disable

namespace economiegr.Models
{
    public partial class RelToolDatum
    {
        public int? Idrel2 { get; set; }
        public int Dataid { get; set; }
        public int Techid { get; set; }

        public virtual Datum Data { get; set; }
        public virtual Technology Tech { get; set; }
    }
}
