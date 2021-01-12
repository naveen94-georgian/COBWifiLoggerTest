using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COBWifiApiTest.Models
{
    public class Xirrus
    {
        [Key]
        public string id { get; set; }
        public string hostName { get; set; }
        public string locationName { get; set; }
        public string locationTable { get; set; }
    }

    public class XirrusViewModel
    {
        public IEnumerable<Xirrus> Xirruss { get; set; }
    }
}
