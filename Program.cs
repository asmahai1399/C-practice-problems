using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // task1
            double grossSal;
            double dearAll = 0.4;
            double rentAll = 0.2;
            Console.Write("Enter your basic salary = ");
            int sal = Convert.ToInt32(Console.ReadLine());
            dearAll = dearAll * sal;
            rentAll = rentAll * sal;

            grossSal = sal + dearAll + rentAll;
            Console.WriteLine("Gross Salary is = " + grossSal);


            // task 2
            Console.Write("Enter distance between cities = ");
            double dist = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Distance in meters = " + toMeter(dist));
            Console.WriteLine("Distance in feet = " + toFeet(dist));
            Console.WriteLine("Distance in Inches = " + toInches(dist));
            Console.WriteLine("Distance in cm = " + toCM(dist));

            // task 3
            int[] marks = new int[5];
            int agg = 0;
            double per;
            int i = 0;
            while (i < marks.Length)
            {
                Console.Write("Enter marks for course = ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }

            for (i=0; i < marks.Length; i++)
            {
                agg = agg + marks[i];
            }
            Console.WriteLine("Aggregate marks = " + agg);

            per = (agg / 500.0)*100;
            Console.WriteLine("Percentage Obtained = " + per);

            // task 4
            Console.Write("Enter degrees (in F) = ");
            double f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Degree in Centigrade = " + toCentigrade(f));

            // task 5
            Console.Write("Enter lenght = ");
            double l = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter breadth = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Radius = ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area of Rectangle = " + areaRect(l, b));
            Console.WriteLine("Perimeter of Rectangle = " + Perimeter(l, b));
            Console.WriteLine("Area of Circle = " + areaCirc(r));
            Console.WriteLine("Circumference of Circle = " + circumference(r));

            // task 6
            Console.Write("Enter C = ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter D = ");
            int d = Convert.ToInt32(Console.ReadLine());
            // c- 4 d-5
            c = c + d;  // c=9
            d = c - d; // d = 4
            c = c - d; // c = 5

            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);

            // task 7
            Console.Write("Enter a 5-digit number = ");
            int num = Convert.ToInt32(Console.ReadLine());
            int m,n,o,p,q,add;
            m = num % 10;
            n = (num / 10) % 10;
            o = (num / 100) % 10;
            p = (num / 1000) % 10;
            q = (num / 10000) % 10;

            add = m + n + o + p + q;
            Console.WriteLine("Sum of 5-digit number is = " + add);


            // task 8
            Console.Write("Enter a 5-digit number = ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int m1, n1, o1, p1, q1, rev;
            m1 = num1 % 10;
            n1 = (num1 / 10) % 10;
            o1 = (num1 / 100) % 10;
            p1 = (num1 / 1000) % 10;
            q1 = (num1 / 10000);

            rev = m1*10000 + n1*1000 + o1*100 + p1*10 + q1;
            Console.WriteLine("Reverse of 5-digit number is = " + rev);


            // task 9
            Console.Write("Enter a 4-digit number = ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int x, y,add1;
            x = num2 % 10;
            y = (num2 / 1000) % 10;

            add1 = x + y;
            Console.WriteLine(add1);

            // task 10
            double pmen = 0.52;
            double pwomen = 0.48;
            double plit = 0.48;
            double plitmen = 0.35;

            int pop = 80000;
            double litmen, litwomen,litpop;

            litpop = plit * pop;
            litmen = plitmen * litpop;
            litwomen = (1.0 - plitmen) * litpop;

            Console.WriteLine("literate Population = " + litpop);
            Console.WriteLine("literate Men = " + litmen);
            Console.WriteLine("literate Women = " + litwomen);

            // task 11
            Console.Write("Enter a 5-digit number = ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int m2, n2, o2, p2, q2, add2;
            m2 = (num3 % 10)+1;
            n2 = ((num3 / 10) % 10)+1;
            o2 = ((num3 / 100) % 10)+1;
            p2 = ((num3 / 1000) % 10)+1;
            q2 = ((num3 / 10000))+1;

            add2 =(m2) + ((n2 * 10)) + ((o2 * 100)) + ((p2 * 1000)) + ((q2 * 10000));
            Console.WriteLine("Adding in 5-digit number is = " + add2);

            // task 12
            Console.Write("Enter cost price = ");
            double cprice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter selling price = ");
            double sprice = Convert.ToDouble(Console.ReadLine());

            double profit, loss;
            profit = ((sprice - cprice) / cprice) * 100;
            loss = ((cprice - sprice) / cprice) * 100;

            if (profit > loss)
            {
                Console.WriteLine("The seller has made a profit !");
            } else if (profit < loss)
            {
                Console.WriteLine("The seller has made a loss !");
            }
            else
            {
                Console.WriteLine("The seller has neither made a loss nor made a profit !");
            }

            // task 13
            Console.Write("enter a number = ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            if (num4 % 2 == 0)
            {
                Console.WriteLine("eneterd number is even !");
            } else if (num4 % 2 != 0)
            {
                Console.WriteLine("enetered number is odd !");
            }


            // task 15
            Console.Write("enter a year = ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 && year % 100 == 0)
            {
                Console.WriteLine("This year is not a leap year having 365 days !");
            } else if (year % 100 ==0 && year % 400 ==0)
            {
                Console.WriteLine("This year is a leap year having 366 days !");
            }

            // task 16
            Console.Write("enter a 5-digit number = ");
            int number = Convert.ToInt32(Console.ReadLine());

            int reverse = generateReverse(number);

            if (reverse == number)
            {
                Console.WriteLine("The two numbers are equal !");
            }
            else
            {
                Console.WriteLine("Numbers are not equal !");
            }

            // task 17
            int count = 0;
            double[] angles = new double[3];
            
            while (count < 3)
            {
                Console.Write("Enter angles of triangle = ");
                angles[count] = Convert.ToDouble(Console.ReadLine());
                count++;
            }

            double angle;
            angle = 0;
            for (i=0; i < angles.Length; i++)
            {
                angle = angle + angles[i];
            }

            if (angle == 180)
            {
                Console.WriteLine("Triangle is valid !");
            }
            else
            {
                Console.WriteLine("Triangle is not valid !");
            }


            // task 18
            Console.Write("Enter lenght of rectangle = ");
            double lenght = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter breadth of rectangle = ");
            double breadth = Convert.ToDouble(Console.ReadLine());

            double area = areaRect(lenght, breadth);
            double perimeter = Perimeter(lenght, breadth);

            if (area > perimeter)
            {
                Console.WriteLine("Area is greater than perimeter");
            }
            else
            {
                Console.WriteLine("Perimeter is greater than Area");
            }


            // task 19
            Console.Write("Input Character = ");
            char text = Convert.ToChar(Console.ReadLine());

            if (text >= 65 && text <= 90)
            {
                Console.WriteLine("Character is Capital Letter");
            }else if (text >= 97 && text <= 122)
            {
                Console.WriteLine("Character is small letter");
            }else if (text >= 48 && text <= 57)
            {
                Console.WriteLine("Character is a number");
            }else if ((text > 0 && text <= 47) || (text >= 58 && text <= 64) ||
               (text >= 91 && text <= 96) || (text >= 123 && text <= 127))
            {
                Console.WriteLine("Character is a special character");
            }


            // task 20
            Console.Write("enter age = ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("lives in (city/village) = ");
            string lives = Console.ReadLine();

            Console.Write("enter gender = ");
            string gender = Console.ReadLine();

            Console.Write("enter health (excellent/poor) = ");
            string health = Console.ReadLine();

            Console.WriteLine(calculateInsurance(age, lives, gender, health));

            // task 21
            Console.Write("enter hardness = ");
            double hardness = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter carbon content = ");
            double carbon = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter tensile strenght = ");
            double tensile = Convert.ToDouble(Console.ReadLine());

            if (hardness > 50 && carbon > 0.7 && tensile > 5600)
            {
                Console.WriteLine("Grade 10");
            }
            else if (hardness > 50 && carbon > 0.7 || tensile > 5600)
            {
                Console.WriteLine("Grade 9");
            }
            else if (carbon > 0.7 && tensile > 5600 || hardness > 50)
            {
                Console.WriteLine("Grade 8");
            }
            else if (hardness > 50 && tensile > 5600 || carbon > 0.7 )
            {
                Console.WriteLine("Grade 7");
            }
            else if (hardness > 50 || carbon > 0.7 || tensile > 5600)
            {
                Console.WriteLine("Grade 6");
            }
            else
            {
                Console.WriteLine("Grade 5");
            }

            // task 22
            Console.Write("enter days late  = ");
            int late = Convert.ToInt32(Console.ReadLine());

            if (late >= 1 && late <= 5)
            {
                Console.WriteLine("50 paise");
            }else if (late >= 6 && late <= 10)
            {
                Console.WriteLine("05 rupee");
            }
            else if (late >= 6 && late <= 10)
            {
                Console.WriteLine("05 rupee");
            }else if (late > 30)
            {
                Console.WriteLine("30 Days");
            }


            // task 23
            int i1, j, k;

            for (i1=1; i1 <= 3; i1++)
            {
                for (j=1; j<=3; j++)
                {
                    for (k = 1; k <= 3; k++)
                    {
                        Console.WriteLine(i1 + j + k);
                    }
                }
            }

            // task 24


            // task 25
            Console.Write("Input number = ");
            int table = Convert.ToInt32(Console.ReadLine());

            int counter = 1;

            while (counter == 10)
            {
                Console.WriteLine(table + " * " + counter + " = " + table * counter);
                counter++;
            }

            // task 26

            int s, t, u, space, numbers;
            numbers = 1;
            space = 7;
            
            for (s=1; s <= 4; s++)
            {
                for (u=space; u >= 1; u--)
                {
                    Console.WriteLine(" ");
                }
                for (t=1; t<=1; t++)
                {
                    Console.WriteLine(numbers);
                    numbers++;
                }
                space--;
            }

            Console.ReadLine();

        }

        // rwesusable function/methods

        static string calculateInsurance(int age,string lives,string gender,string health)
        {
            if (health == "excellent" && (age >= 25 && age <= 35) && lives == "city" && gender == "male" )
            {
                return "Insured !! with Rs. 4 per thousand and his policy amount cannot exceed Rs. 2 lakhs.";
            }else if (health == "excellent" && (age >= 25 && age <= 35) && lives == "city" && gender == "female")
            {
                return "Insured !! with is Rs. 3 per thousand and her policy amount cannot exceed Rs. 1 lakh.";
            }else if (health == "poor" && (age >= 25 && age <= 35) && lives == "village" && gender == "male")
            {
                return "Insured !! with Rs. 6 per thousand and his policy cannot exceed Rs. 10,000";
            }
            return "Not Insured !!";
        }

        static double toMeter(double lenght)
        {
            double m;
            m = lenght * 1000;
            return m;
        }

        static double toFeet(double lenght)
        {
            double f;
            f = lenght * 3281;
            return f;
        }

        static double toInches(double lenght)
        {
            double i;
            i = lenght * 39370;
            return i;
        }

        static double toCM(double lenght)
        {
            double c;
            c = lenght * 100000;
            return c;
        }

        static double toCentigrade(double fareinheit)
        {
            double c;
            c = (fareinheit - 32) * (5.0 / 9.0);
            return c;
        }

        static double areaRect(double l, double b)
        {
            double a;
            a = l * b;
            return a;
        }
        static double Perimeter(double l, double b)
        {
            double p;
            p = (2 * l) + (2 * b);
            return p;
        }

        static double areaCirc(double r)
        {
            double a;
            a = Math.PI * Math.Pow(r, 2);
            return a;
        }

        static double circumference(double r)
        {
            double c;
            c = 2 * Math.PI * r;
            return c;
        }

        static int generateReverse(int num)
        {
            int a,b,c,d,e, rev;
            a = num % 10;
            b = (num / 10) % 10;
            c = (num / 100) % 10;
            d = (num / 1000) % 10;
            e = (num / 10000);

            rev = a * 10000 + b* 1000 + c * 100 + d * 10 + e;
            return rev;
        }

        
    }
}
