using System;
using System.Collections.Generic;

#nullable disable

namespace economiegr.Models
{
    public partial class RelStepActTool
    {
        public int? Idrel1 { get; set; }
        public int Actid { get; set; }
        public int Stepid { get; set; }
        public int Techid { get; set; }

        public virtual Activity Act { get; set; }
        public virtual PblStep Step { get; set; }
        public virtual Technology Tech { get; set; }
    }
}
