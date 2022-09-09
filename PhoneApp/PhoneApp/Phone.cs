using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp
{
    internal class Phone
    {
        //Atribute
        public string brand;
        public string model;
        public long imei;
        public string shape;
        public string collor;
        public int ramMemory;
        public bool touchscreenDisplay;

        //Constructor
        public Phone()     //constructor implicit
        {
            brand = "Samsung";
            imei = 456879;
        }
        // Constructor explicit partial
        public Phone(string model, long imei, bool touchscreenDisplay)
        {
            // this-> referentiaza tot obiectul/clasa in care sunt
            this.model = model;
            this.imei = imei;
            this.touchscreenDisplay = touchscreenDisplay;
        }
        // Constructor explicit 
        public Phone(string brand, string model, long imei, string shape, string collor, int ramMemory, bool touchscreenDisplay)
        {
            this.brand = brand;
            this.model = model;
            this.imei = imei;
            this.shape = shape;
            this.collor = collor;
            this.ramMemory = ramMemory;
            this.touchscreenDisplay = true;
        }
        //Copy constructor 
        public Phone(Phone phone)
        {
            this.brand = phone.brand;
            this.model = phone.model;
            this.imei = phone.imei;
            this.shape = phone.shape;
            this.collor = phone.collor;
            this.ramMemory = phone.ramMemory;
            this.touchscreenDisplay = phone.touchscreenDisplay;
        }

        //Gett-eri si sett-eri

        //Brand
        public string getBrand ()
        {
            return this.brand;
        }
        public void setBrand(string brand)
        {
            if(this.ValidareBrand(brand))
            {
                this.brand = brand;
            }
            else
            {
                Console.Error.WriteLine("Brandul nu este Samsung");
            }
        }
        //Model
        public string getModel()
        {
            return this.model;
        }
        public void setModel(string model)
        {
            this.model = model;
        }
        //Imei
        public long getImei()
        {
            return this.imei;
        }
        public void setImei(long imei)
        {
            this.imei = imei;
        }
        //Shape
        public string getShape()
        {
            return this.shape;
        }
        public void setShape(string shape)
        {
            if(ValidareShape(shape))
            {
                this.shape = shape;
            }
            else
            {
                Console.Error.WriteLine("Shape-ul nu este valid.");
            }
        }
        //Collor
        public string getCollor()
        {
            return this.collor;
        }
        public void setCollor(string collor)
        {
            this.collor = collor;
        }
        //Ram memory
        public int getRamMemory()
        {
            return this.ramMemory;
        }
        public void setRamMemory(int ramMemory)
        {
            if(ValidareRam(ramMemory))
            {
                this.ramMemory = ramMemory;
            }
            else
            {
                Console.Error.WriteLine("Valoarea memoriei ram nu este valida.");
            }
        }
        //Touchscreen Display
        public bool getTouchscreenDisplay()
        {
            return this.touchscreenDisplay;
        }
        public void setTouchscreenDisplay(bool touchscreenDisplay)
        {
            this.touchscreenDisplay = touchscreenDisplay; 
        }

        //Functie validare brand
        public bool ValidareBrand(string brand)
        {
            if (brand == "Samsung")
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        //Functie validare shape doar rectangulare/square
        public bool ValidareShape(string shape)
        {
            if(shape == "Rectangulare" || shape == "Square")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Functie validare ram: multiplu de 16 si pozitiv
        public bool ValidareRam(int ramMemory)
        {
            if(ramMemory % 16 == 0 && ramMemory > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Functie
        public void writeToConsole()
        {
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Imei: " + imei);
            Console.WriteLine("Shape: " + shape);
            Console.WriteLine("Collor: " + collor);
            Console.WriteLine("ramMemory: " + ramMemory);
            Console.WriteLine("Touch Screen: " + touchscreenDisplay);
        }
    }
}
