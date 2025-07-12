using System;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;
namespace Assignment_Session03
{
    class Person
    {
        public string Name;
        public string id;
        public int age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Write a program that allows the user to enter a number then print it.

            //Console.Write("Please enter a number:");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The number is {number}");

            #endregion

            #region Q2 - Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen

            //string input = "abc";

            //int number = int.Parse(input);                       /*there is an exception*/
            //Console.WriteLine($"Converted number is {number}");
            #endregion

            #region Q3 - Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //double a = 5.2;
            //double b = 2.0;
            //double add = a + b;
            //Console.WriteLine($"Addition: {a} + {b} = {add}");
            #endregion

            #region Q4 - Write C# program that Extract a substring from a given string.

            //string fullText = "Hello, ahmed";
            //string subStr = fullText.Substring(7, 5);
            //Console.WriteLine($"Original string: {fullText}");
            //Console.WriteLine($"Extracted substring: {subStr}");
            #endregion

            #region Q5 - Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            //int a = 10;
            //int b = a;
            //b = 20;
            //Console.WriteLine($"a = {a}");
            //Console.WriteLine($"b = {b}"); // b gets a copy of a then b only will be modified
            #endregion

            #region Q6 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //Person person1 = new Person();
            //person1.Name = "fahd";

            //Person person2 = person1; 

            //person2.Name = "ahmed"; 

            //Console.WriteLine($"person1.Name = {person1.Name}");
            //Console.WriteLine($"person2.Name = {person2.Name}"); //the two reference will be changed when we chaged the second to ahmed, becsuse both variables point to the same object in memory

            #endregion

            #region Q7 - Write C# program that take two string variables and print them as one variable 
            //string fName = "Ahmed";
            //string lName = "Toghian";
            //string fullName = fName + " " + lName;
            //Console.WriteLine("Full Name: " + fullName);

            #endregion

            #region Q8 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time
            // Note :  The formula for simple interest is Interest = (principal * rate * time ) /100.

            //Console.Write("Enter Principal amount: ");
            //double principal = double.Parse(Console.ReadLine());

            //Console.Write("Enter Rate of Interest (%): ");
            //double rate = double.Parse(Console.ReadLine());

            //Console.Write("Enter Time (in years): ");
            //double time = double.Parse(Console.ReadLine());

            //double interest = (principal * rate * time) / 100;

            //Console.WriteLine($"Simple Interest = {interest}");
            #endregion

            #region Q9 - Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            // Note: The formula for BMI is BMI = (Weight) / (Height * Height)

            //Console.Write("Enter your weight in kilograms: ");
            //double weight = double.Parse(Console.ReadLine());

            //Console.Write("Enter your height in meters: ");
            //double height = double.Parse(Console.ReadLine());
            //Console.Clear();

            //double bmi = weight / (height * height);

            //Console.WriteLine($"Your BMI is {bmi:f2}");

            #endregion

            #region Q10 - Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result.
            ///that below 10 degrees is "Just Cold"
            ///above 30 degrees is "Just Hot"
            ///anything else is "Just Good"
            ///

            //Console.Write("Enter the temperature in °C: ");
            //int temp = int.Parse(Console.ReadLine());
            //Console.Clear();

            //string result = (temp < 10) ? "Just Cold" :
            //                (temp > 30) ? "Just Hot" :
            //                "Just Good";

            //Console.WriteLine($"Temperature Status: {result}");

            #endregion

            #region Q11  Write a program that takes the date from the user and displays it in various formats using string interpolation.
            ///Ex:
            ///Today’s date : 20 , 11 , 2001
            ///Today's date : 20 / 11 / 2001
            ///Today's date : 20 – 11 – 2001

            //Console.Write("Enter day: ");
            //int day = int.Parse(Console.ReadLine());

            //Console.Write("Enter month: ");
            //int month = int.Parse(Console.ReadLine());

            //Console.Write("Enter year: ");
            //int year = int.Parse(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine();
            //Console.WriteLine($"Today's date : {day} , {month} , {year}");
            //Console.WriteLine($"Today's date : {day} / {month} / {year}");
            //Console.WriteLine($"Today's date : {day} – {month} – {year}");

            #endregion

            #region Q12 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            ///Example(1)
            ///Input: 12
            ///Output: Yes
            ///Example(2)
            ///Input: 9
            ///Output: No
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //string result = (number % 3 == 0 && number % 4 == 0) ? "Yes" : "No";
            //Console.WriteLine(result);

            #endregion

            #region Q13 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            ///Example(1)
            ///Input: -5
            ///Output: negative
            ///Example(2)
            ///Input: 10
            ///Output: positive

            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.Clear();
            //string result = (number < 0) ? "negative" : "positive";
            //Console.WriteLine(result);

            #endregion

            #region Q14 - Write a program that takes 3 integers from the user then prints the max element and the min element.
            ///Example(1)
            ///Input: 7,8,5
            ///Output:
            ///max element = 8
            ///min element = 5
            ///Example(2)
            ///Input: 3 6 9
            ///Outputs:
            ///Max element = 9
            ///Min element = 3


            //Console.Write("Enter the first number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the third number: ");
            //int num3 = int.Parse(Console.ReadLine());

            //int max = Math.Max(num1, Math.Max(num2, num3));
            //int min = Math.Min(num1, Math.Min(num2, num3));

            //Console.WriteLine($"Max element = {max}");
            //Console.WriteLine($"Min element = {min}");


            #endregion

            #region Q15 - Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("Enter an integer number: ");
            //int number = int.Parse(Console.ReadLine());

            //string result = (number % 2 == 0) ? "Even" : "Odd";

            //Console.WriteLine($"The number {number} is {result}.");

            #endregion

            #region Q16 - Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            ///Example(1)
            ///Input: O
            ///Output: vowel
            ///Example(2)
            ///Input: b
            ///Output: Consonant

            //Console.Write("Enter a single character: ");
            //char inputChar = char.Parse(Console.ReadLine());

            //char ch = char.ToLower(inputChar);

            //string res = (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') ? "vowel" : "consonant";

            //Console.WriteLine($"The character '{inputChar}' is a {res}.");
            #endregion

            #region Q17 - Write a program to input the month number and print the number of days in that month.
            /// Example
            /// Input: Month Number: 1
            /// Output: Days in Month: 31
            Console.Write("Enter the month number (1–12): ");
            int month = int.Parse(Console.ReadLine());

            int days;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 2:
                    days = 28; 
                    break;
                default:
                    Console.WriteLine("Invalid month number!");
                    return;
            }
            Console.Clear();
            Console.WriteLine($"Days in Month: {days}");
            #endregion

        }
	}
}
