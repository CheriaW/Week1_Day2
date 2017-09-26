using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            // data tyoes we've covered thus far; int and string
            // an int is a whole number (no decimals)
            //a string is a collection of characters

            char firstInitial = 'D';
            // Characters or chars are single letters, numbers, or symbols


            bool isTired = true;
            //Boolean or bool is true or false

            //Other number data tyoes
            float number = 2.16440330497294849383961032f;
            decimal partialNum = 2.16440330497294849383961032m;
            double someNum = 2.16440330497294849383961032d;

            Console.WriteLine(number);
            Console.WriteLine(partialNum);
            Console.WriteLine(someNum);
            // Console.WriteLine(firstInitial);
            // Console.WriteLine(isTired);    

            //Now, lets talk about operators!
            // ARITHMATIC OPERATORS
            // + adds two operands
            // - Subtracts the second operand first
            // * multiplies both numbers
            // / as an operator, it divides one operand by another
            // % - Modulus - checks the remainder
            // ++ Increments operator by one and is used for ints primarily
            // -- Decrements operator by one and is used for ints primarily

            //RELATIONAL OPERATORS
            // == Checks if the values of two operands are equal 
            // and if they are, returns bool true
            // != Checks is values of two operands are ewual or
            // not, and if values are NOT equal , returns bool true.

            int jarrydAge = 29;
            int danielAge = 32;
            Console.WriteLine(jarrydAge == danielAge);

            /*
             * > Checks if the value on the left of the operand is greater than the value of the right of the operand
             * and if yes then condition is true
             * < Checks if the value on the left of the operand is less than the value of the right of the operand 
             * and if yes then condition is true
             * 
             * >= Checks is the value of the left operand is greater than or equal to the value of the right operand and 
             * if yes then condition is true
             * 
             * <= Checks if the value on the left is less than or equal to the value on the right of the operand and
             * if yes then condition is true
             * /

        }
    }
}
