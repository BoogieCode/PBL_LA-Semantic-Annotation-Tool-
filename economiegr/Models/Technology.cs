using System;
using System.Collections.Generic;

#nullable disable

namespace economiegr.Models
{
    public partial class Technology
    {
        public Technology()
        {
            RelLatoolLams = new HashSet<RelLatoolLam>();
            RelStepActTools = new HashSet<RelStepActTool>();
            RelToolData = new HashSet<RelToolDatum>();
            Relations = new HashSet<Relation>();
        }

        public int Idtechnology { get; set; }
        public string TechName { get; set; }
        public string TechCategory { get; set; }

        public virtual ICollection<RelLatoolLam> RelLatoolLams { get; set; }
        public virtual ICollection<RelStepActTool> RelStepActTools { get; set; }
        public virtual ICollection<RelToolDatum> RelToolData { get; set; }
        public virtual ICollection<Relation> Relations { get; set; }
    }
}
