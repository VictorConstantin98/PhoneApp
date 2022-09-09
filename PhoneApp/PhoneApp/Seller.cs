using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp
{
    internal class Seller
    {
        private static string sellerCod;

        public readonly string id;

        public static string name;
        public string description;
        public string adresa;
        public string cif; //F/13/21/2020 sau J/12/20/2019

        public int cantitate;
        public double pret;

        //Constructor implicit
        public Seller()
        {
            adresa = "Bucuresti";
            cif = "J/12/21/2021";
        }

        //Constructor explicit partial
        public Seller(string id)
        {
            this.id = id;
        }

        //Constructor explicit
        public Seller(string sellerCod, string id, string name, string description, string adresa, string cif, int cantitate, double pret)
        {
            Seller.sellerCod = sellerCod;
            this.id = id;
            Seller.name = name;
            this.description = description;
            this.adresa = adresa;
            this.cif = cif;
            this.cantitate = cantitate;
            this.pret = pret;
        }

        //Getters and setters
        
        //Sellercod
        public string getSellercod()
        {
            return Seller.sellerCod;
        }
        public void setSellerCod(string sellercod)
        {
            Seller.sellerCod = sellercod;
        }

        //Id
        public string getId()
        {
            return this.id;
        }

        //Name
        public string getName()
        {
            return Seller.name;
        }
        public void setName(string name)
        {
            Seller.name = name;
        }

        //Description
        public string getDescription()
        {
            return this.description;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }

        //Adresa
        public string getAdresa()
        {
            return this.adresa;
        }
        public void setAdresa(string adresa)
        {
            this.adresa = adresa;
        }

        //CIF
        public string getCif()
        {
            return this.cif;
        }
        public void setCif(string cif)
        {
            if(VerificareCifStart(cif))
            {
                this.cif = cif;
            }
            else
            {
                Console.Error.WriteLine("Cif-ul nu incepe cu J sau F.");
            }
        }

        //Cantitate
        public int getCantitate()
        {
            return this.cantitate;
        }
        public void setCantitate(int cantitate)
        {
            this.cantitate = cantitate;
        }

        //Pret
        public double getPret()
        {
            return this.pret;
        }
        public void setPret(double pret)
        {
            this.pret = pret;
        }
        public void afisare()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Cif: " + sellerCod + cif);
            Console.WriteLine(Calculate.cifraDeAfaceri(this.cantitate, this.pret));
        }

        public static void changeSellerCod(string sellerCod)
        {
            Seller.sellerCod = sellerCod;
        }

        //Modificare
        public void modificareSeller(string id, string description)
        {
            this.description = description;
            /*this.id = id;*/  // Nu poate fi modificat.
        }

        /*public static void changeDescription(string description)
        {

        }*/

        //NU ARE SET READONLY
        public void setId(string Id)
        {
            if (Utilities.IsDigitOnly(Id))
            {
                /*this.id = id;*/
            }
            else
            {
                Console.Error.WriteLine("Is not digit only");
            }
        }

        //Verificare daca cif este valid
        public bool VerificareCifStart(string cif)
        {
           if(cif.StartsWith("F")||cif.StartsWith("J"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*public bool VerificareCifUltimeleCaractere(string cif)
        {
            if ()
            {

            }
        }*/
    }
}
