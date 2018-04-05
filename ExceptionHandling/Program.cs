/*
1. Ask the user for his age.
2. Display the year user born.
3. Exceptions must be handled using "try .. catch".
4. Display appropriate error messages if user enters zero or negative numbers.
5. Display a general message if exception caused by anything else.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
                try
                {
                    Console.WriteLine("Please enter your age");
                    int userAge = int.Parse(Console.ReadLine());
                    if (userAge == 0)
                    {
                        Console.WriteLine("If your age is 0, I encourage you to contact Ripley's Believe It or Not, because you being able to type is unbelievable!");
                        Console.ReadKey();
                    }
                    else if (userAge < 0)
                    {
                        Console.WriteLine("Are you telling me, you found a way to travel back in time?!");
                        Console.ReadKey();
                    }
                    else
                    {
                        try
                        {
                            Console.WriteLine("Have you had your birthday yet this year?");
                            string yes = Console.ReadLine().ToLower();
                            DateTime dtNow = DateTime.Now;

                            if (yes == "yes" || yes == "ya" || yes == "y" || yes == "yea" || yes == "yeah" || yes == "yah" || yes == "yeh")
                            {
                                var yearOfBirth = dtNow.Year - userAge;
                                Console.WriteLine($"You were born in the year {yearOfBirth}");
                            }
                            else if (yes == "no" || yes == "nope" || yes == "n" || yes == "naw" || yes == "nah")
                            {
                                var yearOfBirthMinus1 = dtNow.Year - userAge - 1;
                                Console.WriteLine($"You were born in the year {yearOfBirthMinus1}");
                            }
                            else
                            {
                                throw new Exception("Please enter Yes or No.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Console.WriteLine("Please contact your System Admin.");
                }

            

            Console.ReadKey();
        }
    }
}
