using System;
using System.Collections.Generic;

#nullable disable

namespace economiegr.Models
{
    public partial class Datum
    {
        public Datum()
        {
            RelToolData = new HashSet<RelToolDatum>();
            Relations = new HashSet<Relation>();
        }

        public int Iddata { get; set; }
        public string DataName { get; set; }

        public virtual ICollection<RelToolDatum> RelToolData { get; set; }
        public virtual ICollection<Relation> Relations { get; set; }
    }
}
