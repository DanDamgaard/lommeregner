using System;

namespace regneMaskine
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Du kan gange, plus, minus, eller divider 2 tal eller du kan skriv exit for at stoppe programmet" + Environment.NewLine + "------------------------------------------------------------------------------------------------");

            string ind = Console.ReadLine();
            double resultat = 0;
            bool workDone = false;
            bool lukke = false;
            bool stop = false;
            while (!lukke) {


                if (ind.Contains("+") && !workDone)
                {
                    string[] spl = ind.Split('+');
                    int tal1 = Convert.ToInt32(spl[0]);
                    int tal2 = Convert.ToInt32(spl[1]);
                    resultat = (double)tal1 + tal2;
                    workDone = true;

                }
                else if (ind.Contains("-") && !workDone)
                {
                    string[] spl = ind.Split('-');
                    int tal1 = Convert.ToInt32(spl[0]);
                    int tal2 = Convert.ToInt32(spl[1]);
                    resultat = (double)tal1 - tal2;
                    workDone = true;

                }
                else if (ind.Contains("/") && !workDone)
                {
                    string[] spl = ind.Split('/');
                    int tal1 = Convert.ToInt32(spl[0]);
                    int tal2 = Convert.ToInt32(spl[1]);
                    resultat = (double)tal1 / tal2;
                    workDone = true;

                }
                else if (ind.Contains("*") && !workDone )
                {
                    workDone = true;
                    string[] spl = ind.Split('*');
                    int tal1 = Convert.ToInt32(spl[0]);
                    int tal2 = Convert.ToInt32(spl[1]);
                    resultat = (double)tal1 * tal2;


                }
                else if (ind == "exit" || ind == "Exit" && !workDone)
                {
                    Console.WriteLine("Tryk enter for at lukke");
                    lukke = true;
                }
                else if (workDone)
                {
                    if (!stop)
                    {
                        Console.WriteLine(Environment.NewLine + "Dit resultat er: " + resultat);
                        stop = true;
                    } 
                    else
                    {
                        Console.WriteLine("Skriv et nyt regne stykkke eller exit");
                        ind = Console.ReadLine();
                        workDone = false;
                        stop = false;
                    }
                }
                else
                {
                    Console.WriteLine("Du kan kun regne med 2 tal eller exit alt andet er ugyldigt" + Environment.NewLine + "Prøv igen");
                    ind = Console.ReadLine();

                } 
            }


        }
    }
}
