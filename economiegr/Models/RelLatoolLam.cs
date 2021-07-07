using System;
using System.Collections.Generic;

#nullable disable

namespace economiegr.Models
{
    public partial class RelLatoolLam
    {
        public int? Idrel4 { get; set; }
        public int Techid { get; set; }
        public int Lamid { get; set; }

        public virtual LaMethod Lam { get; set; }
        public virtual Technology Tech { get; set; }
    }
}
