using System;
using System.Collections.Generic;

#nullable disable

namespace economiegr.Models
{
    public partial class PblStep
    {
        public PblStep()
        {
            RelStepActTools = new HashSet<RelStepActTool>();
            Relations = new HashSet<Relation>();
        }

        public int IdpblStep { get; set; }
        public string StepName { get; set; }

        public virtual ICollection<RelStepActTool> RelStepActTools { get; set; }
        public virtual ICollection<Relation> Relations { get; set; }
    }
}
