using System;
using System.Collections.Generic;

namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = " ";
            string lastName = " ";
            string subject = " ";
            int grade = 0;
            string comment = " ";
            List<string> details = new List<string>();

            Console.Write("Enter first name: ");
            firstName = (Console.ReadLine());

            Console.Write("Enter last name: ");
            lastName = (Console.ReadLine());

            Console.Write("Enter your subject: ");
            subject = Console.ReadLine();

            Console.Write("Enter your grade: ");
            grade = int.Parse(Console.ReadLine());

                if(grade >= 70){
                comment = "You made an A";
                }
                else if(grade >= 60 && grade < 70){
                comment = "You made a B";
                }
                else if(grade >= 50 && grade < 60){
                comment = "You made a C";
                }
                else{
                    comment = "You failed";
                }

            details.Add(firstName);
            details.Add(lastName);
            details.Add(subject);
            details.Add(comment);

            details.ForEach(Console.WriteLine);
        }
    }
}
