// Noah Thompson, Rubric, v0.4grey escape
using System;

namespace GreyEscape
{   
    class program
    {
       static void Main(string[] args)
       {
           MethodFour();
           
       }

       static void MethodOne()
       { path 1 = 
        
       }

        static void Methodtwo()
       {
        
       }

        static void WrongRight()
       { 
            int choices = 0; 
            // if wrong chouice then print "Wrong, try again"/ if right Print"your rigth , the next step to escaping was made"
            // After the first if all others should be else if and the final one should be else.  
            if (choices == 1) { console.writeline("your wrong, you lose a guess be more carefull. try again");
            }
            if (choices == 2) { Console.WriteLine("your rigth , the next step to escaping was made");
            }
            if (choices == 3) { Console.WriteLine(" Meh, its not totally wrong or rigth. move on ");
            }
            if else Console.WriteLine("just choose one of them or stop playing");

        static void GuessCounter()
       {
            //every choice made decreases the players guess count
            GuessChoices = -- if(choices == 1,2,3);       
       }

        static void DiceRoll()
       { 
           // random number gen 1 to 6
            Random rnd = new Random(); 
            int Guesscount = rnd.Next(1,7); //  1-3 = low vaue  4-5 = high value
            Console.WriteLine(" You rolled a " + Guesscount +" ,you have " + Guesscount +" guess Counts" );
            
       }
        
    
    
    }
}
    // Code reviewed by Takiyah Travis