using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
     public class Client
    {
        public long IdentifiantClient { get; set; }
        public string NomDuClient { get; set; }
        public string PrenomDuClient { get; set; }
        public string VilleDuClient { get; set; }
      

        public string Affichage { get; set; }
    }
}
