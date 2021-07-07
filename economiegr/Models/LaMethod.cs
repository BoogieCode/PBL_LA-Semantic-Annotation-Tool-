using System;
using System.Collections.Generic;

#nullable disable

namespace economiegr.Models
{
    public partial class LaMethod
    {
        public LaMethod()
        {
            RelLatoolLams = new HashSet<RelLatoolLam>();
            Relations = new HashSet<Relation>();
        }

        public int IdlaMethod { get; set; }
        public string LamethodName { get; set; }

        public virtual ICollection<RelLatoolLam> RelLatoolLams { get; set; }
        public virtual ICollection<Relation> Relations { get; set; }
    }
}
