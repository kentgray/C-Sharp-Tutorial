using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Animal
    {
        public double height {get; set;}
        public double weight {get; set;}
        public string sound {get; set;}
        
        public string name;
        public string Name
        {
            get {return name;}
            set {name = value;}
            
        }
        
        publiAnimal()
        {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name";
            this.sound = "No Sound";
        }
        
        publicAnimal(double height, double weight, string name, string soun d)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;
        }
        
        
        
        
        static void Main(string[] args)
        {
  
        }
     }
}