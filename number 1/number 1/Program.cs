using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //this is a program developed by James Mulligan to help wingspan national bird of prey center maintain and store their data better
            Console.Write("Bird object created and default data loaded... \n\n");

            Console.Write("PLEASE UPDATE BIRD DATA \n\n");
            //here I am obtaining the information about the bird and saving them to variables 
            Console.Write("Enter Bird name: ");
            string bName = Console.ReadLine();
            Console.Write("Enter Species: ");
            string bSpecies = Console.ReadLine();
            Console.Write("Enter sex of Bird: ");
            string bSex = Console.ReadLine();
            Console.Write("Enter weight of Bird in grams: ");
            int bWeight = int.Parse(Console.ReadLine());
            Console.Write("Enter Band number of Bird: ");
            string bBandNo = (Console.ReadLine());
            
            Console.Write("******************************************\n");
            //I've created a Bird object using the contructor and populating it with the variables we saved about the bird 
            BIRD b1 = new BIRD(bName, bSpecies, bSex, bWeight, bBandNo);
            //I'm displaying the info back to the user using Bird object (b1)
            Console.WriteLine(b1.DisplayBird());
            Console.Write("******************************************");

            Console.ReadLine();
        }
    }
    class BIRD
    {
        //5 auto implemented properties
        public string Name { get; set; }
        public string Species { get; set; }
        public string Sex { get; set; }
        public int Weight { get; set; }
        public string BandNo { get; set; }

        //here is my constuctor 
        public BIRD(string _name, string _species, string _sex, int _weight, string _bandNo)
        {
            Name = _name;
            Species = _species;
            Sex = _sex;
            Weight = _weight;
            BandNo = _bandNo;
        }
        //here is my method to display all data back to the user
        public string DisplayBird()
        {
            return ($"BIRD OF PREY DATA OUTPUT\nBird name: {Name}\nSpecies: {Species}\nSex: {Sex}\nWeight: {Weight}grams\nBandNumber: {BandNo}");
        }



    }

    
}
