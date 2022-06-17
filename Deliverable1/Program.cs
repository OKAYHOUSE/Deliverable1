using System;

class Program
{
    public static void Main(string[] args)
    {
        bool keepLoop = true;
        while (keepLoop)
        {

            Console.Write("\n" + "How many people are we making PB and J sandwiches for? ");
            int numofsandwiches = int.Parse(Console.ReadLine());
            int slicesofbread = 2;
            int slicesinLoaf = 28;
            int PNBtablespoons = 2;
            int PeanutButterJar = 32;
            int jellyteaspoons = 4;
            int jellyjarsteaspoons = 48;
            int totalSlicesNeeded = numofsandwiches * slicesofbread;
            int totalLoavesNeeded = totalSlicesNeeded / slicesinLoaf;
            int totalPeanutButterNeeded = numofsandwiches * PNBtablespoons;
            int totalPeanutButterJarsNeeded = totalPeanutButterNeeded / PeanutButterJar;
            int totaljellyNeeded = numofsandwiches * jellyteaspoons;
            int totaljellyjarsNeeded = totaljellyNeeded / jellyjarsteaspoons;
            if (totalSlicesNeeded % slicesinLoaf != 0) { totalLoavesNeeded++; }
            if (totalPeanutButterNeeded % PeanutButterJar != 0) { totalPeanutButterJarsNeeded++; }
            if (totaljellyNeeded % jellyjarsteaspoons != 0) { totaljellyjarsNeeded++; }
            Console.WriteLine("\n" + "For " + numofsandwiches + " sandwiches, you need:" + "\n" + "\n" + totalSlicesNeeded + " slices of bread" + "\n" + totalPeanutButterNeeded + " tablespoons of butter" + "\n" + totaljellyNeeded + " teaspoons of jelly" + "\n" + "\n" + "which will be:" + "\n" + "\n" + totalLoavesNeeded + " loaf/loaves of bread" + "\n" + totalPeanutButterNeeded + " jar/jars of peanut butter" + "\n" + totaljellyjarsNeeded + " jar/jars of jelly" + "\n");
            Console.Write("Would you like to restart? Enter yes or y to continue, or enter any other key to exit. ");
            string restart = Console.ReadLine();
            switch (restart)
            {
                case "yes": continue;
                case "Yes": continue;
                case "y": continue;
                default:
                    Console.WriteLine("Goodbye!");
                    keepLoop = false;
                    break;
            }
        }
    }
}