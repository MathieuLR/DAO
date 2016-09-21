using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DAL
{
     public class ClientDAO
    {
        public void insert(Client cli)
        {
            //try
            //{
                SqlConnection connect = new SqlConnection("server =.; database=fil_rouge; integrated security=true");
                connect.Open();

                SqlCommand requetebis = new SqlCommand("select MAX(IdentifiantClient) from Client", connect);
                long IdentifiantClient = (long)requetebis.ExecuteScalar();
                cli.IdentifiantClient = IdentifiantClient + 1;


                SqlCommand requete = new SqlCommand("insert into Client(IdentifiantClient, NomDuClient,PrenomDuClient,VilleDuClient) values(@id,@nom,@prenom,@ville)", connect);

                requete.Parameters.AddWithValue("@nom", cli.NomDuClient);
                requete.Parameters.AddWithValue("@prenom", cli.PrenomDuClient);
                requete.Parameters.AddWithValue("@ville", cli.VilleDuClient);
                requete.Parameters.AddWithValue("@id", cli.IdentifiantClient);

                requete.ExecuteNonQuery();

                //SqlCommand requeteter = new SqlCommand("select MAX(IdentifiantClient) from Client", connect);


                connect.Close();
            //}
            //catch
            //{
            //    throw new Exception("Problème lors de l'ajout !");
            //}
        }
            public void update(Client cli)
        {
            try
            {
                SqlConnection connect = new SqlConnection("server=.; database=fil_rouge; integrated security=true");
                connect.Open();
                SqlCommand requete = new SqlCommand("update Client set NomDuClient = (@nom),PrenomDuClient = (@prenom),VilleDuClient= (@ville) where IdentifiantClient = @IdentifiantClient", connect);

                requete.Parameters.AddWithValue("@IdentifiantClient", cli.IdentifiantClient);
                requete.Parameters.AddWithValue("@nom", cli.NomDuClient);
                requete.Parameters.AddWithValue("@prenom", cli.PrenomDuClient);
                requete.Parameters.AddWithValue("@ville", cli.VilleDuClient);

                requete.ExecuteNonQuery();
                connect.Close();
            }
            catch
            {
                throw new Exception("Problème lors de la mise a jour!");
            }

        }

        public void delete(Client cli)
        {
            try { 
            SqlConnection connect = new SqlConnection("server=.; database=fil_rouge; integrated security=true");
            connect.Open();
            SqlCommand requete = new SqlCommand("delete from Client where IdentifiantClient = @IdentifiantClient", connect);


            requete.Parameters.AddWithValue("@IdentifiantClient", cli.IdentifiantClient);
         
            requete.ExecuteNonQuery();
            connect.Close();
        }
            catch
            {
                throw new Exception("Problème lors de la suppression !");
    }
}

        public Client find(long ID)
        {
            try { 
            SqlConnection connect = new SqlConnection("server=.; database=fil_rouge; integrated security=true");
            connect.Open();
            SqlCommand requete = new SqlCommand("select * from Client where IdentifiantClient = @IdentifiantClient", connect);
            requete.Parameters.AddWithValue("@IdentifiantClient", ID);
            SqlDataReader lecture = requete.ExecuteReader();

            //requete.Parameters.AddWithValue("@IdentifiantClient", ID);
          
            Client cli = new Client();
           
            while (lecture.Read())
            {
               
                cli.NomDuClient = Convert.ToString(lecture["NomDuClient"]);
                cli.PrenomDuClient = Convert.ToString(lecture["PrenomDuClient"]);
                cli.VilleDuClient = Convert.ToString(lecture["VilleDuClient"]);
                cli.Affichage = Convert.ToString(lecture["NomDuClient"]) + " " + Convert.ToString(lecture["PrenomDuClient"]) + " " + Convert.ToString(lecture["VilleDuClient"]);
            }
            connect.Close();
            return cli;
        }
            catch
            {
                throw new Exception("Problème lors de la recherche !");
    }

}
        public List<Client> List()
        {
            try { 
            List<Client> resultat = new List<Client>();
            SqlConnection connect = new SqlConnection("server=.; database=fil_rouge; integrated security=true");
            connect.Open();
            SqlCommand requete = new SqlCommand("select * from client", connect);

            SqlDataReader lecture = requete.ExecuteReader();
            while (lecture.Read())
            {
                Client cli = new Client();
                cli.IdentifiantClient = Convert.ToInt32(lecture["IdentifiantClient"]);
                cli.NomDuClient = Convert.ToString(lecture["NomDuClient"]);
                cli.PrenomDuClient = Convert.ToString(lecture["PrenomDuClient"]);
                cli.VilleDuClient = Convert.ToString(lecture["VilleDuClient"]);
                cli.Affichage = Convert.ToString(lecture["NomDuClient"]) + " " + Convert.ToString(lecture["PrenomDuClient"]) + " " + Convert.ToString(lecture["VilleDuClient"]);
                resultat.Add(cli);
            }
            lecture.Close();
            connect.Close();
            return resultat;

        }
            catch
            {
                throw new Exception("Problème lors de l'initialisation de la liste !");
           }
}
     }
}
