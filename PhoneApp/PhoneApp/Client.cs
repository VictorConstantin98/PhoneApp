using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp
{
    internal class Client
    {
        private int id;
        public string username;
        private string phoneNumber;
        private string email;
        private int varsta;
        private long cnp;
        private char gender; // pentru data viitoare validare si modificare in functie de cnp;
        public Client()
        {
            id = 0;
            username = "costi01";
            phoneNumber = "";
            email = "";
        }
        //Copy constructor
        public Client(Client client)
        {
            this.id = client.id;
            this.username = client.username;
            this.phoneNumber = client.phoneNumber;
            this.email = client.email;
            this.varsta = client.varsta;
            this.gender = client.gender;
            this.cnp = client.cnp;

        }

        //Getters and setters

        //Username
        public string getUsername()
        {
            return this.username;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }

        //Phone number
        public string getPhoneNumber()
        {
            return this.phoneNumber;
        }
        public void setPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length == 10 && this.IsDigitOnly(phoneNumber))
            {
                this.phoneNumber = phoneNumber;
            }
            else
            {
                Console.Error.WriteLine("numar invalid");
            }
        }

        //Email
        public string getEmail()
        {
            return this.email;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }

        //Varsta
        public void setVarsta(int varsta)
        {
            if (varsta >= 1 && varsta <= 100)
            {
                this.varsta = varsta;
            }
            else
            {
                Console.Error.WriteLine("varsta invalida");
            }
        }
        public int getVarsta()
        {
            return this.varsta;
        }

        //CNP
        public long getCnp()
        {
            return this.cnp;
        }
        public void setCnp()
        {
            this.cnp = cnp;
        }

        //Gender

        public char getGender()
        {
            return this.gender;
        }
        public void setGender(char gender)
        {
            this.gender = gender;
        }


        //Metoda cnp pt a determina gender
       /* private bool tellGenderViaCnp(long cnp)
        {
            if()
        }*/
        private bool IsDigitOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        /*public void afisare()
        {
            Calculate.cifraDeAfaceri
        }*/



    }
}
