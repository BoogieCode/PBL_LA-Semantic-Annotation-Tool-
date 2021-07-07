using System;
using System.Collections.Generic;

#nullable disable

namespace economiegr.Models
{
    public partial class Relation
    {
        public int? Idrelation { get; set; }
        public int Actid { get; set; }
        public int Stepid { get; set; }
        public int Dataid { get; set; }
        public int Techid { get; set; }
        public int Lamid { get; set; }

        public virtual Activity Act { get; set; }
        public virtual Datum Data { get; set; }
        public virtual LaMethod Lam { get; set; }
        public virtual PblStep Step { get; set; }
        public virtual Technology Tech { get; set; }
    }
}
