// Noah Thompson,Program Template, v0.02
using system;

namespace helloworld
{   
    class program
    {
       static void Main(string[] args); 
       { 
          int MyInt1 = 7;
          int MyInt2 = 38;

           string MySting1 = "Its Fine";
           string MySting2 = "Almost Done";

           float myfloat1 = 0.145F;
           float myfloat2 = 0.062F;

           // arithmetic Operators
           Console.Writeline(int MyInt1 +int MyInt2);
           Console.Writeline(string MySting1 + string MySting2);
           Console.Writeline(float myfloat1 + float myfloat2);
           Console.Writeline(int MyInt1 + float myfloat2); 
           
           Console.Writeline(int MyInt1 - int MyInt2);
           Console.Writeline(string MySting1 - string MySting2);
           Console.Writeline(float myfloat1 - float myfloat2);
           Console.Writeline(int MyInt1 - float myfloat2);    

           Console.Writeline( int MyInt1 / int MyInt2);
           Console.Writeline(string MySting1 / string MySting2);
           Console.Writeline(float myfloat1 / float myfloat2);
           Console.Writeline(int MyInt1 / float myfloat2);    
           
           Console.Writeline(int MyInt1 * int MyInt2);
           Console.Writeline(string MySting1 * string MySting2);
           Console.Writeline(float myfloat1 * float myfloat2);
           Console.Writeline(int MyInt1 * float myfloat2);    
        // once you get ythese to worke commit and push to origin as v0.03
           // Modulus
        
        Console.Writeline("Modlus");
        Console.Writeline(12 % 4);
        Console.Writeline("Modlus");
        
        // increment
        int MyInt3;
        MyInt2++;
        Console.Writeline(MyInt3)

        // Decrement
        int MyInt4 = 3;
        MyInt3--;
        Console.WriteLine(MyInt4);

        //Assignment operators
        // This assignment Operator throws out old values
        MyInt3 = 5;
        // these assignment operators keep old values
        // +=
        MyInt3 = +3
        // =-
        MyInt3 = -2
        // *=
        MyInt3 = *3
        // /=
        MyInt3 /= 2
        Console.WriteLine(MyInt3);

        // Comparison operators
        // its equal to 
        Console.WriteLine(5 == 4);
        // Not Equal to
        Console.WriteLine(3 !=2);
        // Greater Than
        Console.WriteLine(5 > 3);
        // Greater thAN OR EQUAL to
        Console.WriteLine(55 >= 75);
        // LESS tHAN
        Console.WriteLine(-1 > -2);
        // LESS THAN OR EQUAL TO 
        Console.WriteLine(1 <= 5);
        

        // logical operators
        // an -- al conditions must be true for whole statement true
        Console.WriteLine(3 > 2 && 2 == 2); // TRue and true = true
        Console.WriteLine(3 > 2 && 5  > 6); // TRuer and false = false
        // or -- One condition must be true for the whole statement to be true 
        Console.WriteLine(5 < 9 || 5 != 4); // TRue and true = true
        Console.WriteLine(9 < 10 || 3 > 5); // TRuer and false = false
        // Not -- Find the opposite value .
        Console.WriteLine(!(5 > 4)); 
        Console.WriteLine(!True);









       }
    
    }
}
