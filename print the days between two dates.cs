using System;

namespace Calender
{
    class Program
    {
        static void Main(string[] args)
        {
            int day1 = 0, day2 = 0, year1 = 0, year2 = 0, n = 0, monthint1 = 0, monthint2 = 0;
            string month1 = "";
            string month2 = "";
            

            Console.Write("Please enter the first year: ");  //Receiving the year input from the user
            year1 = Convert.ToInt16(Console.ReadLine());

            if (year1 >= 2015)
            {

            }
            else
            {
                while (year1 < 2015)
                {
                    Console.WriteLine("Year must be equal to or greater than 2015");
                    Console.Write("Please enter the first year again: ");
                    year1 = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("Please enter the first month: "); //Receiving the month input from the user
            month1 = Console.ReadLine();
            month1 = month1.ToLower();

            while (monthint1 == 0)
            {
                if (month1 == "january")
                {
                    monthint1 = 1;

                }
                else if (month1 == "february")
                {
                    monthint1 = 2;

                }
                else if (month1 == "march")
                {
                    monthint1 = 3;

                }
                else if (month1 == "april")
                {
                    monthint1 = 4;

                }
                else if (month1 == "may")
                {
                    monthint1 = 5;

                }
                else if (month1 == "june")
                {
                    monthint1 = 6;

                }
                else if (month1 == "july")
                {
                    monthint1 = 7;

                }
                else if (month1 == "august")
                {
                    monthint1 = 8;

                }
                else if (month1 == "september")
                {
                    monthint1 = 9;

                }
                else if (month1 == "october")
                {
                    monthint1 = 10;

                }
                else if (month1 == "november")
                {
                    monthint1 = 11;

                }
                else if (month1 == "december")
                {
                    monthint1 = 12;

                }
                else
                {

                    Console.WriteLine("You entered the first month incorrectly. Please enter the first month again: ");
                    month1 = Console.ReadLine();
                    month1 = month1.ToLower();
                }

            }

            int daymax = 0;
            
            void monthstr_1() // Function used to display the entered month as a string in the console
            {
                if (monthint1 == 1)
                {
                    Console.Write("January");
                }
                else if (monthint1 == 2)
                {
                    Console.Write("February");
                }
                else if (monthint1 == 3)
                {
                    Console.Write("March");
                }
                else if (monthint1 == 4)
                {
                    Console.Write("April");
                }
                else if (monthint1 == 5)
                {
                    Console.Write("May");
                }
                else if (monthint1 == 6)
                {
                    Console.Write("June");
                }
                else if (monthint1 == 7)
                {
                    Console.Write("July");
                }
                else if (monthint1 == 8)
                {
                    Console.Write("August");
                }
                else if (monthint1 == 9)
                {
                    Console.Write("September");
                }
                else if (monthint1 == 10)
                {
                    Console.Write("October");
                }
                else if (monthint1 == 11)
                {
                    Console.Write("November");
                }
                else if (monthint1 == 12)
                {
                    Console.Write("December");
                }
            }
            void monthstr_2() //function used to display the entered month as a string in the console
            {
                if (monthint2 == 1)
                {
                    Console.Write("January");
                }
                else if (monthint2 == 2)
                {
                    Console.Write("February");
                }
                else if (monthint2 == 3)
                {
                    Console.Write("March");
                }
                else if (monthint2 == 4)
                {
                    Console.Write("April");
                }
                else if (monthint2 == 5)
                {
                    Console.Write("May");
                }
                else if (monthint2 == 6)
                {
                    Console.Write("June");
                }
                else if (monthint2 == 7)
                {
                    Console.Write("July");
                }
                else if (monthint2 == 8)
                {
                    Console.Write("August");
                }
                else if (monthint2 == 9)
                {
                    Console.Write("September");
                }
                else if (monthint2 == 10)
                {
                    Console.Write("October");
                }
                else if (monthint2 == 11)
                {
                    Console.Write("November");
                }
                else if (monthint2 == 12)
                {
                    Console.Write("December");
                }
            }

            int monthint_1() //Function that shows how many days a month has
            {
                if (monthint1 == 1)
                {
                    daymax = 31;
                }
                else if (monthint1 == 2)
                {
                    if (year1 % 4 == 0)
                    {
                        if (year1 % 100 == 0)
                        {
                            if (year1 % 400 == 0)
                            {
                                //artık yıl
                                daymax = 29;
                            }
                            else
                            {
                                //normal yıl
                                daymax = 28;
                            }
                        }
                        else
                        {
                            daymax = 29;
                        }
                    }
                    else
                    {
                        daymax = 28;
                    }
                }
                else if (monthint1 == 3)
                {
                    daymax = 31;
                }
                else if (monthint1 == 4)
                {
                    daymax = 30;
                }
                else if (monthint1 == 5)
                {
                    daymax = 31;
                }
                else if (monthint1 == 6)
                {
                    daymax = 30;
                }
                else if (monthint1 == 7)
                {
                    daymax = 31;
                }
                else if (monthint1 == 8)
                {
                    daymax = 31;
                }
                else if (monthint1 == 9)
                {
                    daymax = 30;
                }
                else if (monthint1 == 10)
                {
                    daymax = 31;
                }
                else if (monthint1 == 11)
                {
                    daymax = 30;
                }
                else if (monthint1 == 12)
                {
                    daymax = 31;
                }

                int result = daymax;
                return result;
            }
            int monthint_2() //Function that shows how many days a month has
            {
                if (monthint2 == 1)
                {
                    daymax = 31;
                }
                else if (monthint2 == 2)
                {
                    if (year2 % 4 == 0)
                    {
                        if (year2 % 100 == 0)
                        {
                            if (year2 % 400 == 0)
                            {
                                //artık yıl
                                daymax = 29;
                            }
                            else
                            {
                                //normal yıl
                                daymax = 28;
                            }
                        }
                        else
                        {
                            daymax = 29;
                        }
                    }
                    else
                    {
                        daymax = 28;
                    }
                }
                else if (monthint2 == 3)
                {
                    daymax = 31;
                }
                else if (monthint2 == 4)
                {
                    daymax = 30;
                }
                else if (monthint2 == 5)
                {
                    daymax = 31;
                }
                else if (monthint2 == 6)
                {
                    daymax = 30;
                }
                else if (monthint2 == 7)
                {
                    daymax = 31;
                }
                else if (monthint2 == 8)
                {
                    daymax = 31;
                }
                else if (monthint2 == 9)
                {
                    daymax = 30;
                }
                else if (monthint2 == 10)
                {
                    daymax = 31;
                }
                else if (monthint2 == 11)
                {
                    daymax = 30;
                }
                else if (monthint2 == 12)
                {
                    daymax = 31;
                }

                int result = daymax;
                return result;
            }


            if (year1 % 4 == 0) // Taking the day input from the user by making leap year calculation
            {
                if (year1 % 100 == 0)
                {
                    if (year1 % 400 == 0)
                    {
                        //artık yıl 29
                        if (monthint1 == 1 | monthint1 == 3 | monthint1 == 5 | monthint1 == 7 | monthint1 == 8 | monthint1 == 10 | monthint1 == 12)
                        {
                            Console.Write("Please enter the first day: ");
                            day1 = Convert.ToInt16(Console.ReadLine());
                            if (day1 < 32 & day1 > 0)
                            {

                            }
                            else
                            {
                                while (day1 > 31 | day1 < 1)
                                {
                                    Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 31");
                                    Console.Write("Please enter the first day again: ");
                                    day1 = Convert.ToInt16(Console.ReadLine());
                                }
                            }
                        }
                        else if (monthint1 == 4 | monthint1 == 6 | monthint1 == 9 | monthint1 == 11)
                        {
                            Console.Write("Please enter the first day: ");
                            day1 = Convert.ToInt16(Console.ReadLine());
                            if (day1 < 31 & day1 > 0)
                            {

                            }
                            else
                            {
                                while (day1 > 30 | day1 < 1)
                                {
                                    Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 30");
                                    Console.Write("Please enter the first day again: ");
                                    day1 = Convert.ToInt16(Console.ReadLine());
                                }
                            }
                        }
                        else if (monthint1 == 2)
                        {
                            Console.Write("Please enter the first day: ");
                            day1 = Convert.ToInt16(Console.ReadLine());
                            if (day1 < 30 & day1 > 0)
                            {

                            }
                            else
                            {
                                while (day1 > 29 | day1 < 1)
                                {
                                    Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 29");
                                    Console.Write("Please enter the first day again: ");
                                    day1 = Convert.ToInt16(Console.ReadLine());
                                }
                            }
                        }
                    }
                    else
                    {
                        //artık yıl değil 28
                        if (monthint1 == 1 | monthint1 == 3 | monthint1 == 5 | monthint1 == 7 | monthint1 == 8 | monthint1 == 10 | monthint1 == 12)
                        {
                            Console.Write("Please enter the first day: ");
                            day1 = Convert.ToInt16(Console.ReadLine());
                            if (day1 < 32 & day1 > 0)
                            {

                            }
                            else
                            {
                                while (day1 > 31 | day1 < 1)
                                {
                                    Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 31");
                                    Console.Write("Please enter the first day again: ");
                                    day1 = Convert.ToInt16(Console.ReadLine());
                                }
                            }
                        }
                        else if (monthint1 == 4 | monthint1 == 6 | monthint1 == 9 | monthint1 == 11)
                        {
                            Console.Write("Please enter the first day: ");
                            day1 = Convert.ToInt16(Console.ReadLine());
                            if (day1 < 31 & day1 > 0)
                            {

                            }
                            else
                            {
                                while (day1 > 30 | day1 < 1)
                                {
                                    Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 30");
                                    Console.Write("Please enter the first day again: ");
                                    day1 = Convert.ToInt16(Console.ReadLine());
                                }
                            }
                        }
                        else if (monthint1 == 2)
                        {
                            Console.Write("Please enter the first day: ");
                            day1 = Convert.ToInt16(Console.ReadLine());
                            if (day1 < 29 & day1 > 0)
                            {

                            }
                            else
                            {
                                while (day1 > 28 | day1 < 1)
                                {
                                    Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 28");
                                    Console.Write("Please enter the first day again: ");
                                    day1 = Convert.ToInt16(Console.ReadLine());
                                }
                            }
                        }
                    }
                }
                else
                {
                    //artık yıl 29
                    if (monthint1 == 1 | monthint1 == 3 | monthint1 == 5 | monthint1 == 7 | monthint1 == 8 | monthint1 == 10 | monthint1 == 12)
                    {
                        Console.Write("Please enter the first day: ");
                        day1 = Convert.ToInt16(Console.ReadLine());
                        if (day1 < 32 & day1 > 0)
                        {

                        }
                        else
                        {
                            while (day1 > 31 | day1 < 1)
                            {
                                Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 31");
                                Console.Write("Please enter the first day again: ");
                                day1 = Convert.ToInt16(Console.ReadLine());
                            }
                        }
                    }
                    else if (monthint1 == 4 | monthint1 == 6 | monthint1 == 9 | monthint1 == 11)
                    {
                        Console.Write("Please enter the first day: ");
                        day1 = Convert.ToInt16(Console.ReadLine());
                        if (day1 < 31 & day1 > 0)
                        {

                        }
                        else
                        {
                            while (day1 > 30 | day1 < 1)
                            {
                                Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 30");
                                Console.Write("Please enter the first day again: ");
                                day1 = Convert.ToInt16(Console.ReadLine());
                            }
                        }
                    }
                    else if (monthint1 == 2)
                    {
                        Console.Write("Please enter the first day: ");
                        day1 = Convert.ToInt16(Console.ReadLine());
                        if (day1 < 30 & day1 > 0)
                        {

                        }
                        else
                        {
                            while (day1 > 29 | day1 < 1)
                            {
                                Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 29");
                                Console.Write("Please enter the first day again: ");
                                day1 = Convert.ToInt16(Console.ReadLine());
                            }
                        }
                    }
                }
            }
            else
            {
                //artık yıl değil 28
                if (monthint1 == 1 | monthint1 == 3 | monthint1 == 5 | monthint1 == 7 | monthint1 == 8 | monthint1 == 10 | monthint1 == 12)
                {
                    Console.Write("Please enter the first day: ");
                    day1 = Convert.ToInt16(Console.ReadLine());
                    if (day1 < 32 & day1 > 0)
                    {

                    }
                    else
                    {
                        while (day1 > 31 | day1 < 1)
                        {
                            Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 31");
                            Console.Write("Please enter the first day again: ");
                            day1 = Convert.ToInt16(Console.ReadLine());
                        }
                    }
                }
                else if (monthint1 == 4 | monthint1 == 6 | monthint1 == 9 | monthint1 == 11)
                {
                    Console.Write("Please enter the first day: ");
                    day1 = Convert.ToInt16(Console.ReadLine());
                    if (day1 < 31 & day1 > 0)
                    {

                    }
                    else
                    {
                        while (day1 > 30 | day1 < 1)
                        {
                            Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 30");
                            Console.Write("Please enter the first day again: ");
                            day1 = Convert.ToInt16(Console.ReadLine());
                        }
                    }
                }
                else if (monthint1 == 2)
                {
                    Console.Write("Please enter the first day: ");
                    day1 = Convert.ToInt16(Console.ReadLine());
                    if (day1 < 29 & day1 > 0)
                    {

                    }
                    else
                    {
                        while (day1 > 28 | day1 < 1)
                        {
                            Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 28");
                            Console.Write("Please enter the first day again: ");
                            day1 = Convert.ToInt16(Console.ReadLine());
                        }
                    }
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.Write("Please enter the second year: ");
            year2 = Convert.ToInt16(Console.ReadLine());    //Receiving the year input from the user

            if (year2 >= 2015)
            {

            }
            else
            {
                while (year2 < 2015)
                {
                    Console.WriteLine("Year must be equal to or greater than 2015");
                    Console.Write("Please enter the second year again: ");
                    year2 = Convert.ToInt16(Console.ReadLine());
                }

            }
            Console.WriteLine("Please enter the second month: "); //Receiving the month input from the user
            month2 = Console.ReadLine();
            month2 = month2.ToLower();

            while (monthint2 == 0)
            {
                if (month2 == "january")
                {
                    monthint2 = 1;
                }
                else if (month2 == "february")
                {
                    monthint2 = 2;
                }
                else if (month2 == "march")
                {
                    monthint2 = 3;
                }
                else if (month2 == "april")
                {
                    monthint2 = 4;
                }
                else if (month2 == "may")
                {
                    monthint2 = 5;
                }
                else if (month2 == "june")
                {
                    monthint2 = 6;
                }
                else if (month2 == "july")
                {
                    monthint2 = 7;
                }
                else if (month2 == "august")
                {
                    monthint2 = 8;
                }
                else if (month2 == "september")
                {
                    monthint2 = 9;
                }
                else if (month2 == "october")
                {
                    monthint2 = 10;
                }
                else if (month2 == "november")
                {
                    monthint2 = 11;
                }
                else if (month2 == "december")
                {
                    monthint2 = 12;
                }
                else
                {
                    Console.WriteLine("You entered the second month incorrectly. Please enter the second month again: ");
                    month2 = Console.ReadLine();
                    month2 = month2.ToLower();
                }
            }
       
            if (year2 % 4 == 0) // Taking the day input from the user by making leap year calculation
            {
                if (year2 % 100 == 0)
                {
                    if (year2 % 400 == 0)
                    {
                        //artık yıl 29
                        if (monthint2 == 1 | monthint2 == 3 | monthint2 == 5 | monthint2 == 7 | monthint2 == 8 | monthint2 == 10 | monthint2 == 12)
                        {
                            Console.Write("Please enter the second day: ");
                            day2 = Convert.ToInt16(Console.ReadLine());
                            if (day2 < 32 & day2 > 0)
                            {

                            }
                            else
                            {
                                while (day2 > 31 | day2 < 1)
                                {
                                    Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 31");
                                    Console.Write("Please enter the second day again: ");
                                    day2 = Convert.ToInt16(Console.ReadLine());

                                }
                            }
                        }
                        else if (monthint2 == 4 | monthint2 == 6 | monthint2 == 9 | monthint2 == 11)
                        {
                            Console.Write("Please enter the second day: ");
                            day2 = Convert.ToInt16(Console.ReadLine());
                            if (day2 < 31 & day2 > 0)
                            {

                            }
                            else
                            {
                                while (day2 > 30 | day2 < 1)
                                {
                                    Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 30");
                                    Console.Write("Please enter the second day again: ");
                                    day2 = Convert.ToInt16(Console.ReadLine());

                                }
                            }
                        }
                        else if (monthint2 == 2)
                        {
                            Console.Write("Please enter the second day: ");
                            day2 = Convert.ToInt16(Console.ReadLine());
                            if (day2 < 30 & day2 > 0)
                            {

                            }
                            else
                            {
                                while (day2 > 29 | day2 < 1)
                                {
                                    Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 29");
                                    Console.Write("Please enter the second day again: ");
                                    day2 = Convert.ToInt16(Console.ReadLine());

                                }
                            }
                        }
                    }
                    else
                    {
                        //artık yıl değil 28
                        if (monthint2 == 1 | monthint2 == 3 | monthint2 == 5 | monthint2 == 7 | monthint2 == 8 | monthint2 == 10 | monthint2 == 12)
                        {
                            Console.Write("Please enter the second day: ");
                            day2 = Convert.ToInt16(Console.ReadLine());
                            if (day2 < 32 & day2 > 0)
                            {

                            }
                            else
                            {
                                while (day2 > 31 | day2 < 1)
                                {
                                    Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 31");
                                    Console.Write("Please enter the second day again: ");
                                    day2 = Convert.ToInt16(Console.ReadLine());

                                }
                            }
                        }
                        else if (monthint2 == 4 | monthint2 == 6 | monthint2 == 9 | monthint2 == 11)
                        {
                            Console.Write("Please enter the second day: ");
                            day2 = Convert.ToInt16(Console.ReadLine());
                            if (day2 < 31 & day2 > 0)
                            {

                            }
                            else
                            {
                                while (day2 > 30 | day2 < 1)
                                {
                                    Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 30");
                                    Console.Write("Please enter the second day again: ");
                                    day2 = Convert.ToInt16(Console.ReadLine());

                                }
                            }
                        }
                        else if (monthint2 == 2)
                        {
                            Console.Write("Please enter the second day: ");
                            day2 = Convert.ToInt16(Console.ReadLine());
                            if (day2 < 29 & day2 > 0)
                            {

                            }
                            else
                            {
                                while (day2 > 28 | day2 < 1)
                                {
                                    Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 28");
                                    Console.Write("Please enter the second day again: ");
                                    day2 = Convert.ToInt16(Console.ReadLine());

                                }
                            }
                        }
                    }
                }
                else
                {
                    //artık yıl 29
                    if (monthint2 == 1 | monthint2 == 3 | monthint2 == 5 | monthint2 == 7 | monthint2 == 8 | monthint2 == 10 | monthint2 == 12)
                    {
                        Console.Write("Please enter the second day: ");
                        day2 = Convert.ToInt16(Console.ReadLine());
                        if (day2 < 32 & day2 > 0)
                        {

                        }
                        else
                        {
                            while (day2 > 31 | day2 < 1)
                            {
                                Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 31");
                                Console.Write("Please enter the second day again: ");
                                day2 = Convert.ToInt16(Console.ReadLine());

                            }
                        }
                    }
                    else if (monthint2 == 4 | monthint2 == 6 | monthint2 == 9 | monthint2 == 11)
                    {
                        Console.Write("Please enter the second day: ");
                        day2 = Convert.ToInt16(Console.ReadLine());
                        if (day2 < 31 & day2 > 0)
                        {

                        }
                        else
                        {
                            while (day2 > 30 | day2 < 1)
                            {
                                Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 30");
                                Console.Write("Please enter the second day again: ");
                                day2 = Convert.ToInt16(Console.ReadLine());

                            }
                        }
                    }
                    else if (monthint2 == 2)
                    {
                        Console.Write("Please enter the second day: ");
                        day2 = Convert.ToInt16(Console.ReadLine());
                        if (day2 < 30 & day2 > 0)
                        {

                        }
                        else
                        {
                            while (day2 > 29 | day2 < 1)
                            {
                                Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 29");
                                Console.Write("Please enter the second day again: ");
                                day2 = Convert.ToInt16(Console.ReadLine());

                            }
                        }
                    }
                }
            }
            else
            {
                //artık yıl değil 28
                if (monthint2 == 1 | monthint2 == 3 | monthint2 == 5 | monthint2 == 7 | monthint2 == 8 | monthint2 == 10 | monthint2 == 12)
                {
                    Console.Write("Please enter the second day: ");
                    day2 = Convert.ToInt16(Console.ReadLine());
                    if (day2 < 32 & day2 > 0)
                    {

                    }
                    else
                    {
                        while (day2 > 31 | day2 < 1)
                        {
                            Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 31");
                            Console.Write("Please enter the second day again: ");
                            day2 = Convert.ToInt16(Console.ReadLine());

                        }

                    }
                }
                else if (monthint2 == 4 | monthint2 == 6 | monthint2 == 9 | monthint2 == 11)
                {
                    Console.Write("Please enter the second day: ");
                    day2 = Convert.ToInt16(Console.ReadLine());
                    if (day2 < 31 & day2 > 0)
                    {

                    }
                    else
                    {
                        while (day2 > 30 | day2 < 1)
                        {
                            Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 30");
                            Console.Write("Please enter the second day again: ");
                            day2 = Convert.ToInt16(Console.ReadLine());
                        }
                    }
                }
                else if (monthint2 == 2)
                {
                    Console.Write("Please enter the second day: ");
                    day2 = Convert.ToInt16(Console.ReadLine());
                    if (day2 < 29 & day2 > 0)
                    {

                    }
                    else
                    {
                        while (day2 > 28 | day2 < 1)
                        {
                            Console.WriteLine("Entered date is incorrect. Please enter values between these values including 1 and 28");
                            Console.Write("Please enter the second day again: ");
                            day2 = Convert.ToInt16(Console.ReadLine());

                        }
                    }
                }
            }
            ///////////////////////////////////////////////////////////////////////////////
            int findday1() //function used to find which day the entered date is.
            {
                int t = 0;
                if (monthint1 - 1 == 0)
                {
                    t = 0;
                }
                else if (monthint1 - 1 == 1)
                {
                    t = 3;
                }
                else if (monthint1 - 1 ==2)
                {
                    t = 2;
                }
                else if (monthint1 - 1 == 3)
                {
                    t = 5;
                }
                else if (monthint1 - 1 == 4)
                {
                    t = 0;
                }
                else if (monthint1 - 1 == 5)
                {
                    t = 3;
                }
                else if (monthint1 - 1 == 6)
                {
                    t = 5;
                }
                else if (monthint1 - 1 == 7)
                {
                    t = 1;
                }
                else if (monthint1 - 1 == 8)
                {
                    t = 4;
                }
                else if (monthint1 - 1 == 9)
                {
                    t = 6;
                }
                else if (monthint1 - 1 == 10)
                {
                    t = 2;
                }
                else if (monthint1 - 1 == 11)
                {
                    t = 4;
                }

                if (monthint1 < 3)
                {
                    year1 -= 1;
                }
                if (day1 == 32)
                {
                    day1 = 1;
                }
                int f = year1 + (year1 / 4) - (year1 / 100) + (year1 / 400) + t + day1;
                f = f % 7;
                if (monthint1 <3)
                {
                    year1 += 1;
                }

                if (f == 1)
                {
                    Console.WriteLine("Monday");
                }
                else if (f == 2)
                {
                    Console.WriteLine("Tuesday");
                }
                else if (f == 3)
                {
                    Console.WriteLine("Wednesday");
                }
                else if (f == 4)
                {
                    Console.WriteLine("Thursday");
                }
                else if (f == 5)
                {
                    Console.WriteLine("Friday");
                }
                else if (f == 6)
                {
                    Console.WriteLine("Saturday");
                }
                else if (f == 0)
                {
                    Console.WriteLine("Sunday");
                }
                return f;
            }

            int findday2() //function used to find which day the entered date is.
            {
                int t = 0;
                if (monthint2 - 1 == 0)
                {
                    t = 0;
                }
                else if (monthint2 - 1 == 1)
                {
                    t = 3;
                }
                else if (monthint2 - 1 == 2)
                {
                    t = 2;
                }
                else if (monthint2 - 1 == 3)
                {
                    t = 5;
                }
                else if (monthint2 - 1 == 4)
                {
                    t = 0;
                }
                else if (monthint2 - 1 == 5)
                {
                    t = 3;
                }
                else if (monthint2 - 1 == 6)
                {
                    t = 5;
                }
                else if (monthint2 - 1 == 7)
                {
                    t = 1;
                }
                else if (monthint2 - 1 == 8)
                {
                    t = 4;
                }
                else if (monthint2 - 1 == 9)
                {
                    t = 6;
                }
                else if (monthint2 - 1 == 10)
                {
                    t = 2;
                }
                else if (monthint2 - 1 == 11)
                {
                    t = 4;
                }

                if (monthint2 < 3)
                {
                    year2 -= 1;
                }
                if (day2 == 32)
                {
                    day2 = 1;
                }
                int f = year2 + (year2 / 4) - (year2 / 100) + (year2 / 400) + t + day2;
                f = f % 7;
                if (monthint2 < 3)
                {
                    year2 += 1;
                }

                if (f == 1)
                {
                    Console.WriteLine("Monday");
                }
                else if (f == 2)
                {
                    Console.WriteLine("Tuesday");
                }
                else if (f == 3)
                {
                    Console.WriteLine("Wednesday");
                }
                else if (f == 4)
                {
                    Console.WriteLine("Thursday");
                }
                else if (f == 5)
                {
                    Console.WriteLine("Friday");
                }
                else if (f == 6)
                {
                    Console.WriteLine("Saturday");
                }
                else if (f == 0)
                {
                    Console.WriteLine("Sunday");
                }
                return f;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////
            
            void season1() //Function used to find which season the entered date is.
            {
                if (monthint1 == 12 || monthint1 == 1 || monthint1 == 2)
                {
                    Console.WriteLine("WINTER");
                }
                else if (monthint1 == 3 || monthint1 == 4 || monthint1 == 5)
                {
                    Console.WriteLine("SPRING");
                }
                else if (monthint1 == 6 || monthint1 == 7 || monthint1 == 8)
                {
                    Console.WriteLine("SUMMER");
                }
                else if (monthint1 == 9 || monthint1 == 10 || monthint1 == 11)
                {
                    Console.WriteLine("AUTUMN");
                }
            }
            void season2() //Function used to find which season the entered date is.
            {
                if (monthint2 == 12 || monthint2 == 1 || monthint2 == 2)
                {
                    Console.WriteLine("WINTER");
                }
                else if (monthint2 == 3 || monthint2 == 4 || monthint2 == 5)
                {
                    Console.WriteLine("SPRING");
                }
                else if (monthint2 == 6 || monthint2 == 7 || monthint2 == 8)
                {
                    Console.WriteLine("SUMMER");
                }
                else if (monthint2 == 9 || monthint2 == 10 || monthint2 == 11)
                {
                    Console.WriteLine("AUTUMN");
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            Console.Write("Enter how many days apart you want to list the calendar. n: "); //Receiving n positive numbers from the user.
            n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");
            //////////////////////////////////////////////////////////////////////////////////////////////
            
            if (year1 < year2) //küçükten büyüğe doğru sıralayabilmek için yılların büyüklük küçüklük ve eşitlik durumlarına göre ayırdım.
            {
                while (year1 < year2)
                {
                    for (; monthint1 < 12; monthint1 += 1)
                    {
                        while (monthint1 < 12)
                        {
                            if (monthint1 < 12)
                            {
                                season1();
                                for (; day1 <= monthint_1(); day1 += n)
                                {
                                    
                                    Console.Write(day1 + " ");
                                    monthstr_1();
                                    Console.Write(" " + year1 + " ");
                                    findday1();
                                }
                                day1 = n - (monthint_1() - day1) - n;
                                monthint1 = monthint1 + 1;  
                            }   
                        }
                        
                    }
                    if (monthint1 == 13 || monthint1 == 12)
                    {
                        monthint1 = 12;
                        season1();
                        for (; day1 <= 31; day1 += n)
                        {

                            Console.Write(day1 + " ");
                            monthstr_1();
                            Console.Write(" " + year1 + " ");
                            findday1();

                        }
                        year1 = year1 + 1;
                        monthint1 = 0;
                        day1 -= 1;
                    }

                }
                
                while (year1 == year2)
                {
                    for (monthint1 = 1; monthint1 <= monthint2; monthint1++)
                    {
                        if (monthint1 == monthint2)
                        {
                            day1 += 1;
                            while (monthint1 == monthint2)
                            {
                                season1();
                                for (day1 = n - (monthint_1() - day1) - n; day1 <= day2; day1 += n)
                                {
                                    Console.Write(day1 + " ");
                                    monthstr_1();
                                    Console.Write(" " + year1 + " ");
                                    findday1();

                                }
                                break;
                            }
                            break;
                        }
                        
                        monthint1 = 0;
                        while (monthint1 < monthint2)
                        {
                            
                            for (; day1 <= monthint_1(); day1 += n)
                            {
                                Console.Write(day1 + " ");
                                monthstr_1();
                                Console.Write(" " + year1 + " ");
                                findday1();
                            }
                            
                            day1 = n - (monthint_1() - day1) - n;
                            monthint1 += 1;
                            season1();

                            if (monthint1 == monthint2)
                            {
                                

                                for (; day1 <= day2; day1 += n)
                                {
                                    Console.Write(day1 + " ");
                                    monthstr_1();
                                    Console.Write(" " + year1 + " ");
                                    findday1();

                                }
                                monthint1 += 1;
                                break;
                            }
                        }
                        
                    }
                    break;
                }    
            }
            ///////////////////////////////////////////////////////////////////////////////////////////
            else if (year1 > year2)
            {
                while (year2 < year1)
                {
                    for (; monthint2 < 12; monthint2 += 1)
                    {
                        while (monthint2 < 12)
                        {
                            if (monthint2 < 12)
                            {
                                season2();
                                for (; day2 <= monthint_2(); day2 += n)
                                {

                                    Console.Write(day2 + " ");
                                    monthstr_2();
                                    Console.Write(" " + year2 + " ");
                                    findday2();
                                }
                                day2 = n - (monthint_2() - day2) - n;
                                monthint2 = monthint2 + 1;
                            }
                        }

                    }
                    if (monthint2 == 13 || monthint2 == 12)
                    {
                        monthint2 = 12;
                        season2();
                        for (; day2 <= 31; day2 += n)
                        {

                            Console.Write(day2 + " ");
                            monthstr_2();
                            Console.Write(" " + year2 + " ");
                            findday2();

                        }
                        year2 = year2 + 1;
                        monthint2 = 0;
                        day2 -= 1;
                    }

                }

                while (year1 == year2)
                {
                    for (monthint2 = 1; monthint2 <= monthint1; monthint2++)
                    {
                        if (monthint1 == monthint2)
                        {
                            day2 += 1;
                            while (monthint1 == monthint2)
                            {
                                season2();
                                for (day2 = n - (monthint_2() - day2) - n; day2 <= day1; day2 += n)
                                {
                                    Console.Write(day2 + " ");
                                    monthstr_2();
                                    Console.Write(" " + year2 + " ");
                                    findday2();

                                }
                                break;
                            }
                            break;
                        }

                        monthint2 = 0;
                        while (monthint2 < monthint1)
                        {

                            for (; day2 <= monthint_2(); day2 += n)
                            {
                                Console.Write(day2 + " ");
                                monthstr_2();
                                Console.Write(" " + year2 + " ");
                                findday2();
                            }

                            day2 = n - (monthint_2() - day2) - n;
                            monthint2 += 1;
                            season2();

                            if (monthint1 == monthint2)
                            {


                                for (; day2 <= day1; day2 += n)
                                {
                                    Console.Write(day2 + " ");
                                    monthstr_2();
                                    Console.Write(" " + year2 + " ");
                                    findday2();

                                }
                                monthint2 += 1;
                                break;
                            }
                        }

                    }
                    break;
                }
            }
            
            ///////////////////////////////////////////////////////////////////////////////////////////

            else if(year1 == year2)// year1 == year2
            {
                if (monthint1 < monthint2)
                {
                    season1();
                    while (monthint1 < monthint2)
                    {

                        for (; day1 <= monthint_1(); day1 += n)
                        {
                            Console.Write(day1 + " ");
                            monthstr_1();
                            Console.Write(" " + year1 + " ");
                            findday1();
                        }

                        day1 = n - (monthint_1() - day1) - n;
                        monthint1 += 1;
                        season1();

                        if (monthint1 == monthint2)
                        {


                            for (; day1 <= day2; day1 += n)
                            {
                                Console.Write(day1 + " ");
                                monthstr_1();
                                Console.Write(" " + year1 + " ");
                                findday1();

                            }
                            monthint1 += 1;
                            break;
                        }
                    }
                }
                else if (monthint1 > monthint2)
                {
                    season2();
                    while (monthint2 < monthint1)
                    {

                        for (; day2 <= monthint_2(); day2 += n)
                        {
                            Console.Write(day2 + " ");
                            monthstr_2();
                            Console.Write(" " + year2 + " ");
                            findday2();
                        }

                        day2 = n - (monthint_2() - day2) - n;
                        monthint2 += 1;
                        season2();

                        if (monthint1 == monthint2)
                        {


                            for (; day2 <= day1; day2 += n)
                            {
                                Console.Write(day2 + " ");
                                monthstr_2();
                                Console.Write(" " + year2 + " ");
                                findday2();

                            }
                            monthint2 += 1;
                            break;
                        }
                    }

                }
                else // month1 = month2
                {
                    int maxday, minday;
                    minday = Math.Min(day1, day2);
                    maxday = Math.Max(day1, day2);

                    if (minday == day1)
                    {
                        season1();
                        for (; day1 <= day2; day1 += n)
                        {
                            Console.Write(day1 + " ");
                            monthstr_1();
                            Console.Write(" " + year1 + " ");
                            findday1();
                        }
                    }
                    else if (minday == day2)
                    {
                        season2();
                        for (; day2 <= day1; day2 += n)
                        {
                            Console.Write(day2 + " ");
                            monthstr_2();
                            Console.Write(" " + year1 + " ");
                            findday2();
                        }
                    }
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.ReadLine();
        
        }   
    }         
}
