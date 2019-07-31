using System;
using System.Collections.Generic;

namespace Lab_9_Mahruchi_Rhee
{
    class Program
    {
        public static Student addStudent()
        {


            Console.WriteLine("Please input student name");
            string name = Console.ReadLine().Trim();

            if (name == "") 
            {
                Console.WriteLine("Input was blank, please try again!");
            }


            Console.WriteLine("Please input student Home Town.");
            string homeT = Console.ReadLine().Trim();


            if (homeT == "")
            {
                Console.WriteLine("Input was blank, please try again!");
            }

            Console.WriteLine("Please input student favorite food.");
            string favFood = Console.ReadLine().Trim();

            if (favFood == "")
            {
                Console.WriteLine("Input was blank, please try again!");
            }

            Console.WriteLine("Please input student favorite color.");
            string favColor = Console.ReadLine().Trim();


            if (favColor== "")
            {
                Console.WriteLine("Input was blank, please try again!");
            }
            Student input = new Student(name, homeT, favFood, favColor);
            return input;
        }

        static void Main(string[] args)
        {
            string letsGoAgain = "Y";
            while (letsGoAgain == "Y" || letsGoAgain == "y")
            {

            Console.WriteLine("1. Would you like to learn about a student?");
            Console.WriteLine("2. Would you like to add an entry?");
                string response = Console.ReadLine().Trim();

                                          
                if (response == "")
                {
                    Console.WriteLine("Input was blank, please try again!");
                }
                 else if (response == "1")
                {

                    Student s1 = new Student("Flaka", "Pristina", "Thai", "Red");
                    Student s2 = new Student("Manik", "Cox's Bazar", "Spicy Beef Curry", "Blue");
                    Student s3 = new Student("Moise", "Grand Rapids", "Lasagna", "Yellow");
                    Student s4 = new Student("Liz", "Planet Earth", "Smoked Salmon", "Pink");
                    Student s5 = new Student("Moise", "Grand Rapids", "Lasagna", "Orange");
                    Student s6 = new Student("Maricela", "Morelia, Mexico", "Tacos", "Brown");
                    Student s7 = new Student("James", "Grand Rapids", "Cheeseburgers / French Fries", "Beige");

                    List<Student> students = new List<Student>();
                    students.Add(s1);
                    students.Add(s2);
                    students.Add(s3);
                    students.Add(s4);
                    students.Add(s5);
                    students.Add(s6);
                    students.Add(s7);




                    Console.WriteLine("Which Student would you like to learn about? 0-6");
                    
                    for (int i = 0; i < students.Count; i++)

                    {
                        
                        Student stu = students[i];
                        Console.WriteLine(i + " " + stu.GetName());
                    }

                    int pick = 0;
                    try
                    {
                        string input = Console.ReadLine().Trim();
                        pick = int.Parse(input);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("A Valid int was not given");
                    }
       

                    Student s;
                    try
                    {
                        s = students[pick];
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("Incorrect input I'm assuming you want the person");
                        s = students[0];
                    }
                    string name = s.GetName(); //call the method withing your class not the variable. 
                    Console.WriteLine(name);
                    Console.WriteLine($"what would you like to learn about {name}?");
                    Console.WriteLine("1) Favorite food ff");
                    Console.WriteLine("2) Home Town ht");
                    Console.WriteLine("3) Color cl");
                    string input2 = Console.ReadLine().ToLower().Trim();



                    if (input2 == "1" || input2 == "ff")
                    {
                        Console.WriteLine(s.FavoriteFood);
                    }

                    else if (input2 == "")
                    {
                        Console.WriteLine("Invalid entry! Please try again!");
                    }

                    else if (input2 == "2" || input2 == "ht")
                    {
                        Console.WriteLine(s.HomeTown);
                    }

                    else if (input2 == "3" || input2 == "cl")
                    {
                        Console.WriteLine(s.FavColor);
                    }

                    Console.WriteLine($"what else would you like to learn about {name}?");
                    Console.WriteLine("1) Favorite food ff");
                    Console.WriteLine("2) Home Town ht");
                    Console.WriteLine("3) Color cl");
                    string input3 = Console.ReadLine().ToLower().Trim();


                    if (input3 == "1" || input3 == "ff")
                    {
                        Console.WriteLine(s.FavoriteFood);
                    }
                  else if (input3 == "")
                    {
                        Console.WriteLine("Invalid entry! Please try again!");
                    }
                    else if (input3 == "2" || input3 == "ht")
                    {
                        Console.WriteLine(s.HomeTown);
                    }

                    else if (input3 == "3" || input3 == "cl")
                    {
                        Console.WriteLine(s.FavColor);
                    }

                    Console.WriteLine($"what else would you like to learn about {name}?");
                    Console.WriteLine("1) Favorite food ff");
                    Console.WriteLine("2) Home Town ht");
                    Console.WriteLine("3) Color cl");
                    string input4 = Console.ReadLine().ToLower().Trim();


                    if (input4 == "1" || input4 == "ff")
                    {
                        Console.WriteLine(s.FavoriteFood);
                    }
                    else if (input4 == "")
                    {
                        Console.WriteLine("Invalid entry! Please try again!");
                    }
                    else if (input4 == "2" || input4 == "ht")
                    {
                        Console.WriteLine(s.HomeTown);
                    }

                    else if (input4 == "3" || input4 == "cl")
                    {
                        Console.WriteLine(s.FavColor);
                    }

                    Console.WriteLine("Would you like to run this again?");
                    letsGoAgain = Console.ReadLine().Trim();

                    if (letsGoAgain == "N" || letsGoAgain == "n")
                    {
                        Console.WriteLine("Good Bye");
                    }
                }
                
               if (response == "2")

                {

                    Student anotherOne = addStudent();
                    Console.WriteLine(anotherOne);




                    Student s1 = new Student("Flaka", "Pristina", "Thai", "Red");
                    Student s2 = new Student("Manik", "Cox's Bazar", "Spicy Beef Curry", "Blue");
                    Student s3 = new Student("Moise", "Grand Rapids", "Lasagna", "Yellow");
                    Student s4 = new Student("Liz", "Planet Earth", "Smoked Salmon", "Pink");
                    Student s5 = new Student("Moise", "Grand Rapids", "Lasagna", "Orange");
                    Student s6 = new Student("Maricela", "Morelia, Mexico", "Tacos", "Brown");
                    Student s7 = new Student("James", "Grand Rapids", "Cheeseburgers / French Fries", "Beige");

                    List<Student> students = new List<Student>();
                    students.Add(s1);
                    students.Add(s2);
                    students.Add(s3);
                    students.Add(s4);
                    students.Add(s5);
                    students.Add(s6);
                    students.Add(s7);

                    students.Add(anotherOne);



                    Console.WriteLine("Which Student would you like to learn about? 0-6");
                    for (int i = 0; i < students.Count; i++)
                    {
                        Student stu = students[i];
                        Console.WriteLine(i + " " + stu.GetName());
                    }

                    int pick = 0;
                    try
                    {
                        string input = Console.ReadLine();
                        pick = int.Parse(input);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("A Valid int was not given");
                    }

                    Student s;
                    try
                    {
                        s = students[pick];
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("Incorrect input I'm assuming you want the person");
                        s = students[0];
                    }
                    string name = s.GetName(); //call the method withing your class not the variable. 
                    Console.WriteLine(name);
                    Console.WriteLine($"what would you like to learn about {name}?");
                    Console.WriteLine("1) Favorite food ff");
                    Console.WriteLine("2) Home Town ht");
                    Console.WriteLine("3) Color cl");
                    string input2 = Console.ReadLine().ToLower().Trim();

                    if (input2 == "")
                    {
                        Console.WriteLine("Invalid entry! Please try again!");
                    }
                    if (input2 == "1" || input2 == "ff")
                    {
                        Console.WriteLine(s.FavoriteFood);
                    }

                    else if (input2 == "2" || input2 == "ht")
                    {
                        Console.WriteLine(s.HomeTown);
                    }

                    else if (input2 == "3" || input2 == "cl")
                    {
                        Console.WriteLine(s.FavColor);
                    }

                    Console.WriteLine($"what else would you like to learn about {name}?");
                    Console.WriteLine("1) Favorite food ff");
                    Console.WriteLine("2) Home Town ht");
                    Console.WriteLine("3) Color cl");
                    string input3 = Console.ReadLine().ToLower().Trim();

                    if (input3 == "")
                    {
                        Console.WriteLine("Invalid entry! Please try again!");
                    }

                    if (input3 == "1" || input3 == "ff")
                    {
                        Console.WriteLine(s.FavoriteFood);
                    }

                    else if (input3 == "2" || input3 == "ht")
                    {
                        Console.WriteLine(s.HomeTown);
                    }

                    else if (input3 == "3" || input3 == "cl")
                    {
                        Console.WriteLine(s.FavColor);
                    }
                    Console.WriteLine($"what else would you like to learn about {name}?");
                    Console.WriteLine("1) Favorite food ff");
                    Console.WriteLine("2) Home Town ht");
                    Console.WriteLine("3) Color cl");
                    string input4 = Console.ReadLine().ToLower().Trim();


                    if (input4 == "1" || input4 == "ff")
                    {
                        Console.WriteLine(s.FavoriteFood);
                    }
                    else if (input4 == "")
                    {
                        Console.WriteLine("Invalid entry! Please try again!");
                    }
                    else if (input4 == "2" || input4 == "ht")
                    {
                        Console.WriteLine(s.HomeTown);
                    }

                    else if (input4 == "3" || input4 == "cl")
                    {
                        Console.WriteLine(s.FavColor);
                    }

                    Console.WriteLine("Would you like to run this again?");
                    letsGoAgain = Console.ReadLine();
                    if (letsGoAgain == "N" || letsGoAgain == "n")
                    {
                        Console.WriteLine("Good Bye");
                    }

                }
            }
        }
    }
}





    //Student s8 = new Student(name, homeT, favFood, favColor);
    //List<Student> students = new List<Student>();
    //students.Add(s8);
    //                    break;



    //public static Student StudentAdd( x, string y, string z, string c)
    //{
    //    Student input = new Student(x, y, z, c);
    //    List<Student> students = new List<Student>();
    //    students.Add(input);
    //    return students;
    //}






