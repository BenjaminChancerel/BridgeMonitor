using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BridgeMonitor.Models
{
    public class BridgeFermeture
    {
        public string boat_name { get; set; }
        public string closing_type { get; set; }
        public DateTime closing_date { get; set; }
        public DateTime reopening_date { get; set; }
    }
}
