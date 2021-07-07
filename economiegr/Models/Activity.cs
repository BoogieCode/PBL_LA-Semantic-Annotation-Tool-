using System;
using System.Collections.Generic;

#nullable disable

namespace economiegr.Models
{
    public partial class Activity
    {
        public Activity()
        {
            RelStepActTools = new HashSet<RelStepActTool>();
            Relations = new HashSet<Relation>();
        }

        public int Idactivity { get; set; }
        public string ActivityName { get; set; }

        public virtual ICollection<RelStepActTool> RelStepActTools { get; set; }
        public virtual ICollection<Relation> Relations { get; set; }
    }
}
