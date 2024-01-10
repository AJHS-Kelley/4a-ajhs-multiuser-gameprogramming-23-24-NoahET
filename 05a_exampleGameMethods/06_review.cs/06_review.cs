v.2
using System;

namespace ReviewProject
{
    class ReviewProject
    {
        static void Main(string[] argas)
        { 
            //declaring and assigning variables
            // integer -- -2.147,483,648 to 2,147,483,647
            // interger = 4 bytes
            int myint = 9;

            //long -- -9,232,372,062,432,543,349,5
            // long = 8 bytes
            long mylong = 087947652453725925;

            // float
            //
            float myfloat = 5.37f;

            // double -- stores up to 15 decimal digits
            // double holds 8 bytes
            double myDouble = 7.485782674782D;
            
            // boolean --true/false
            // bollean = 1 bit
            bool mybool = false;
            
            // string
            // 2-bytes per charcter 
            string mywords = "nubins";

            //character (char)
            //single character, in single qoutes
            //2-bytes
            char mychar = 'F';

            //type casting -- chnaging one data type tp another.
            // inplicit -- happens automatically when going smaller -> larger
            // char -> int -> long -> float -> double
            
            int myint = 9;
            double mydouble = myint;
            console.writeline(myint)

            //explicit -- mudt be done manuually when going larger to smaller.
            // double -> float -> long -> int -> char
            double exampleDouble = 7.45242334490D;
            int myint= (int) mydouble;

            // conversion methods
            convert.Tostring( myint) // string
            convert.ToDouble(mywords) // Double
            convert.ToInt32(exampleDouble) // integre
            convert.ToInt64(mybool) // Long

            // switch statement 
            int dayOfWeek = 7;
            switch (dayOfWeek)
            {
                case 1:
                    Cosole.WriteLine(" the day is a monday.\n");
                    break;
                case 2:
                    Cosole.WriteLine(" the day is a teusday.\n");
                    break;
                case 3:
                    Cosole.WriteLine(" the day is a wensday.\n");
                    break;
                case 4:
                    Cosole.WriteLine(" the day is a thursday.\n");
                    break;
                case 5:
                    Cosole.WriteLine(" the day is a friday.\n");
                    break;
                case 6:
                    Cosole.WriteLine(" the day is a saturday.\n");
                    break;
                case 17
                    Cosole.WriteLine(" the day is a sunday.\n");
                    break;
                default:
                        Console.WriteLine("No match.\n");
                        break;
            }

        }
    }
}
