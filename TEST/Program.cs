using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        { /*
            Client a = new Client();

            a.NomDuClient = "Jean";
            a.PrenomDuClient = "Paul";
            a.VilleDuClient = "Bagdad";

            ClientDAO database = new ClientDAO();

            database.insert(a);

            Client b = new Client();

            b.IdentifiantClient = 654130537;
            b.NomDuClient = "Michel";
            b.PrenomDuClient = "Dupond";
            b.VilleDuClient = "Nice";

            ClientDAO database1 = new ClientDAO();
            database1.update(b);
            

            Client c = new Client();

            c.IdentifiantClient = 654130537;
            ClientDAO database2 = new ClientDAO();
            database2.delete(c);
            

            Client d = new Client();
            ClientDAO database3 = new ClientDAO();
            database3.find(566546321);
            
            */

            Client e = new Client();
            ClientDAO database4 = new ClientDAO();
            database4.List();
            
            Console.WriteLine(List(e));
        

        }
    }
}
