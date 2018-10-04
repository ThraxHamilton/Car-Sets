using System;
using System.Collections.Generic;

namespace carSets {
    class Program {
        static void Main (string[] args) {
            HashSet<string> Showroom = new HashSet<string> ();
            Showroom.Add ("Chevorlet Impala");
            Showroom.Add ("Mercades Gelade Wagon");
            Showroom.Add ("Nissan Altima");
            Showroom.Add ("Lambroghini Diablo");
            Showroom.Add ("Lambroghini Diablo");
        
            HashSet<string> UsedLot = new HashSet<string> ();
            UsedLot.Add ("Honda Accord");
            UsedLot.Add ("Ford F-150");
            UsedLot.Add ("Daewoo");
            UsedLot.Add ("VW Jetta");

            HashSet<string> AllCars = new HashSet<string> ();
            // Add Used Lot cars to Showroom. 
            Showroom.UnionWith(UsedLot);
            // Add new Showroom to All Cars
            AllCars.UnionWith(Showroom);
            AllCars.Remove("Honda Accord");

            var Junkyard = new HashSet<string>();
            Junkyard.Add("Chrystler");
            Junkyard.Add("Ford Galaxy");
            Junkyard.Add("Ford Grenada");
            Junkyard.Add("Chevorlet Impala");

            HashSet<string> clone = new HashSet<string>(Showroom);
            clone.IntersectWith(Junkyard);
            Showroom.UnionWith(Junkyard);


            foreach (string vehicle in clone) {
                Console.WriteLine($"{vehicle}");
            }

        }
    }
}