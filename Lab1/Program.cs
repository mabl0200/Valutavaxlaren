using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Valutaväxlare";
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.WriteLine("Ange vilken valuta du vill växla från, välj mellan 1-3:");
                string fromMoney = ChooseMoney(); //Anropa metod för att få reda på valuta att växla från
                Console.WriteLine("Ange beloppet du vill växla? OBS vi tar endast emot jämna valörer");
                int amount = ChosenAmount(); //Anropa metod för att ta reda på belopp
                Console.WriteLine("Ange vilken valuta du vill växla till, välj mellan 1-3:");
                string toMoney = ChooseMoney(); //Anropa metod för att få reda på valuta att växla till

                if (fromMoney == "SEK") //if sats för att utifrån input kunna göra uträckningar utefter de val som gjorts.
                {
                    if (toMoney == "SEK")
                    {
                        Console.Clear();
                        Console.WriteLine(amount + " kr");
                        Console.WriteLine("Du vill växla " + amount + " " + fromMoney + " till " + amount + " " + toMoney);
                        Console.WriteLine("Du får tillbaka samma summa");
                        countSek(amount);
                    }
                    else if (toMoney == "USD")
                    {
                        double change = 1 / 8.08;
                        double sum = amount * change;
                        var sumRound = Math.Round(sum, 2);
                        Console.Clear();
                        Console.WriteLine(sumRound + " $");
                        Console.WriteLine("Du vill växla " + amount + " " + fromMoney + " till " + sumRound + " " + toMoney);
                        countUsd(sumRound);
                    }
                    else if (toMoney == "EUR")
                    {
                        double change = 1 / 9.48;
                        double sum = amount * change;
                        var sumRound = Math.Round(sum, 2);
                        Console.Clear();
                        Console.WriteLine(sumRound + " Eur");
                        Console.WriteLine("Du vill växla " + amount + " " + fromMoney + " till " + sumRound + " " + toMoney);
                        countEur(sumRound);
                    }
                }
                else if (fromMoney == "USD")
                {
                    if (toMoney == "SEK")
                    {
                        double change = 1 * 8.08;
                        double sum = amount * change;
                        double sumRound = Math.Round(sum); //Eftersom SEK inte har öre valde jag att inte lägga till (, 2) i koden.
                        Console.Clear();
                        Console.WriteLine(sumRound + " kr");
                        Console.WriteLine("Du vill växla " + amount + " " + fromMoney + " till " + sumRound + " " + toMoney);
                        countSek(sumRound);
                    }
                    else if (toMoney == "USD")
                    {
                        double change = 1 * 1;
                        double sum = amount * change;
                        double sumRound = Math.Round(sum, 2);
                        Console.Clear();
                        Console.WriteLine(amount + " $");
                        Console.WriteLine("Du vill växla " + amount + " " + fromMoney + " till " + sumRound + " " + toMoney);
                        Console.WriteLine("Du får tillbaka samma summa");
                        countUsd(sumRound);
                    }
                    else if (toMoney == "EUR")
                    {
                        double change = 1 * 0.85;
                        double sum = amount * change;
                        var sumRound = Math.Round(sum, 2);
                        Console.Clear();
                        Console.WriteLine(sumRound + " Eur");
                        Console.WriteLine("Du vill växla " + amount + " " + fromMoney + " till " + sumRound + " " + toMoney);
                        countEur(sumRound);
                    }
                }
                else if (fromMoney == "EUR")
                {
                    if (toMoney == "SEK")
                    {
                        double change = 1 * 9.48;
                        double sum = amount * change;
                        var sumRound = Math.Round(sum); //Eftersom SEK inte har öre valde jag att inte lägga till (, 2) i koden.
                        Console.Clear();
                        Console.WriteLine(sumRound + " kr");
                        Console.WriteLine("Du vill växla " + amount + " " + fromMoney + " till " + sumRound + " " + toMoney);
                        countSek(sumRound);
                    }
                    else if (toMoney == "USD")
                    {
                        double change = 1 / 0.85;
                        double sum = amount * change;
                        var sumRound = Math.Round(sum, 2);
                        Console.Clear();
                        Console.WriteLine(sumRound + " $");
                        Console.WriteLine("Du vill växla " + amount + " " + fromMoney + " till " + sumRound + " " + toMoney);
                        countUsd(sumRound);
                    }
                    else if (toMoney == "EUR")
                    {
                        double change = 1 / 1;
                        double sum = amount * change;
                        var sumRound = Math.Round(sum, 2);
                        Console.Clear();
                        Console.WriteLine(amount + " Eur");
                        Console.WriteLine("Du vill växla " + amount + " " + fromMoney + " till " + sumRound + " " + toMoney);
                        Console.WriteLine("Du får tillbaka samma summa");
                        countEur(sumRound);
                    }
                }
                Console.WriteLine("Tryck Enter för att fortsätta:");
                Console.WriteLine("Tryck Q för att avsluta:");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "q":
                        keepLooping = false;   
                        break;                                    
          
                } Console.Clear();
            }
        }
        static String ChooseMoney() //Metod som ger användaren alternativ att välja mellan valutor, om fel input så loopas metoden om tills rätt input ges.
        {
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.WriteLine("1: Svenska kronor (SEK)");
                Console.WriteLine("2: Amerikanska dollars (USD)");
                Console.WriteLine("3: Euro (EUR)");
                string money = Console.ReadLine();
                int value = int.Parse(money);

                if (value >= 1 && value <= 3)
                {
                    switch (money)
                    {
                        case "1":
                            money = "SEK";
                            Console.Clear();
                            break;
                        case "2":
                            money = "USD";
                            Console.Clear();
                            break;
                        case "3":
                            money = "EUR";
                            Console.Clear();
                            break;
                        default:
                            break;
                    }
                    return money;
                }
                else
                {
                    Console.WriteLine("Opps, något gick fel testa igen");
                }
            }
            Console.Clear();
            return (Console.ReadLine());
        }
        static int ChosenAmount() //Metod som efterfrågar ett belopp från användaren
        {
            string input = Console.ReadLine();
            int beloppInput = int.Parse(input);            
            Console.Clear();
            return beloppInput;
        }         
        public static void countSek(double sumRound) //Metod som räknar ut valörerna i kronor
        {
            int[] notesSek = new int[] { 500, 100, 50, 20, 10, 1 };
            Console.WriteLine("Du får dessa valörer: ");
            
            for (int i = 0; i < notesSek.Length; i++)
            {
                int counter = 0;
                while (Math.Round(sumRound) >= (notesSek[i]))
                {
                    sumRound = sumRound - notesSek[i];
                    counter++; 
                }
                if (counter > 0)
                {
                    Console.WriteLine(counter + " st: " + notesSek[i] + " kr ");
                }        
            }   
        }               
        public static void countUsd(double sumRound) //Metod som räknar ut valörerna i dollar
        {
            double[] notesUsd = new double[] { 100, 50, 20, 10, 5, 2, 1, 0.50, 0.25, 0.10, 0.05, 0.01 }; //valörer
            Console.WriteLine("Du får dessa valörer ");           
            
            for (int i = 0; i < notesUsd.Length; i++) //håller koll på arrayen.
            {
                int counter = 0;
                while (Math.Round(sumRound, 2) >= notesUsd[i]) //när true körs while
                {
                    sumRound = sumRound - notesUsd[i];
                    counter++;
                }
                if (counter > 0)
                {
                    if (notesUsd[i] >= 1) //villkor för att veta om det ska skrivas ut i dollar eller cent
                    {
                       Console.WriteLine(counter + " st: " + notesUsd[i] + " $ "); 
                    }
                    else
                    {
                        Console.WriteLine(counter + " st: " + (notesUsd[i] * 100) + " cent "); //valör * 100 för att cent ska skrivas ut utan decimaler
                    }
                }    
            }   
        }    
        public static void countEur(double sumRound) //Metod som räknar ut valörerna i euro
        {
            double[] notesEur = new double[] { 500, 200, 100, 50, 20, 10, 5, 2, 1, 0.50, 0.20, 0.10, 0.05, 0.02, 0.01 };
            Console.WriteLine("Du får dessa valörer ");

            for (int i = 0; i < notesEur.Length; i++) //håller koll på arrayen.
            {
                int counter = 0;
                while (Math.Round(sumRound, 2) >= (notesEur[i])) //när true körs while
                {
                    sumRound = sumRound - notesEur[i];
                    counter++;
                }
                if (counter > 0)
                {
                    if (notesEur[i] >= 1) //villkor för att veta om det ska skrivas ut euro eller cent
                    {
                        Console.WriteLine(counter + " st: " + notesEur[i] + " Eur ");
                    }
                    else
                    {
                        Console.WriteLine(counter + " st: " + (notesEur[i] * 100) + " cent ");
                    }
                } 
        }   }  
    }   
}
