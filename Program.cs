using System;
using System.Collections.Generic;
using System.Linq;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //THIS IS A GPA CALCULATOR FOR 100 LEVEL STUDENT WAITING FOR PROMOTION, OFFERED NINE COURSES
            //I WENT FURTHER TO READ UP METHOD IN OTHER FOR MY CODE TO BE CONCISE, PARDON ME!!!
            //the one I submitted myGrade was string and I asked user to type in their grades by looking at the grade range popped up firstly
            //Also I added another method called myGrades

             int score = 0; int point = 0; double GPA = 0; char myGrade;


            // Courses with their Credit Loads
            int GST_111 = 2; int GST_112 = 2; int MTH_110 = 3; int MTH_112 = 3; int CHM_111 = 3; 
            int CHM_113 = 3; int PHY_101 = 2; int PHY_111 = 3; int PHY_113 = 3;

            //Courses Credit Loads on an Array of creditload
            double[] creditLoad = {2, 2, 3, 3, 3, 3, 2, 3, 3};  

            // List COURSESGRADES FOR STORING STUDENT GRADE
             List<string> CoursesGrades = new List<string>();

Console.WriteLine("WELCOME TO 100LEVEL GPA CALCULATOR, GRADES ARE AS FOLLOW \nSCORES: \n70 - 99: A \n60 - 69: B \n50 - 69: C \n40 - 49: D \n 0 - 39: F ");
            Console.WriteLine("\n"); 

            Console.Write("Enter your GST 111 Score Here: ");
            score = int.Parse(Console.ReadLine());
            point = myPointCal(score);
            // Console.Write("Enter the Course GRADE (IN CAP) as seen Above: ");
            // myGrade = Console.ReadLine();
            myGrade = myGrades(point);
            CoursesGrades.Add("GST 111  " + myGrade);
            int nGST_111 = GST_111 * point;
            
            Console.Write("Enter your GST 112 Score Here: ");
            score = int.Parse(Console.ReadLine());
            point = myPointCal(score);
            // Console.Write("Enter the Course GRADE (IN CAP) as seen Above: ");
            // myGrade = Console.ReadLine();
            myGrade = myGrades(point);
            CoursesGrades.Add("GST 112  " + myGrade);
            int nGST_112 = GST_112 * point;

            Console.Write("Enter your MTH 110 Score Here: ");
            score = int.Parse(Console.ReadLine());
            point = myPointCal(score); 
            // Console.Write("Enter the Course GRADE (IN CAP) as seen Above: ");
            // myGrade = Console.ReadLine(); 
            myGrade = myGrades(point);
            CoursesGrades.Add("MTH 110  " + myGrade);  
            int nMTH_110 = MTH_110 * point;

            Console.Write("Enter your MTH 112 Score Here: ");
            score = int.Parse(Console.ReadLine());
            point = myPointCal(score);
            // Console.Write("Enter the Course GRADE (IN CAP) as seen Above: ");
            // myGrade = Console.ReadLine();
            myGrade = myGrades(point);
            CoursesGrades.Add("MTH 112  " + myGrade);
            int nMTH_112 = MTH_112 * point;
            
            Console.Write("Enter your CHM 111 Score Here: ");
            score = int.Parse(Console.ReadLine());
            point = myPointCal(score);
            // Console.Write("Enter the Course GRADE (IN CAP) as seen Above: ");
            // myGrade = Console.ReadLine();//
            myGrade = myGrades(point);
            CoursesGrades.Add("CHM 111  " + myGrade);
            int nCHM_111 = CHM_111 * point;

            Console.Write("Enter your CHM 113 Score Here: ");
            score = int.Parse(Console.ReadLine());
            point = myPointCal(score);   
            // Console.Write("Enter the Course GRADE (IN CAP) as seen Above: ");
            // myGrade = Console.ReadLine();
            myGrade = myGrades(point);
            CoursesGrades.Add("CHM 113  " + myGrade); 
            int nCHM113 = CHM_113 * point;

            Console.Write("Enter your PHY 101 Score Here: ");
            score = int.Parse(Console.ReadLine());
            point = myPointCal(score);
            // Console.Write("Enter the Course GRADE (IN CAP) as seen Above: ");
            // myGrade = Console.ReadLine();
            myGrade = myGrades(point);
            CoursesGrades.Add("PHY 101  " + myGrade);
            int nPHY_101 = PHY_101 * point;
            
            Console.Write("Enter your PHY 111 Score Here: ");
            score = int.Parse(Console.ReadLine());
            point = myPointCal(score);
            // Console.Write("Enter the Course GRADE (IN CAP) as seen Above: ");
            // myGrade = Console.ReadLine();
            myGrade = myGrades(point);
            CoursesGrades.Add("PHY 111  " + myGrade);
            int nPHY_111 = PHY_111 * point;

            Console.Write("Enter your PHY 113 Score Here: ");
            score = int.Parse(Console.ReadLine());
            point = myPointCal(score);   
            // Console.Write("Enter the Course GRADE (IN CAP) as seen Above: ");
            // myGrade = Console.ReadLine();
            myGrade = myGrades(point);
            CoursesGrades.Add("PHY 113  " + myGrade); 
            int nPHY_113 = PHY_113 * point;

            Console.WriteLine("\n");

            //DISPLAYING THE CONTENT OF THE LIST ARRAY STORED
            Console.WriteLine(CoursesGrades[0]);
            Console.WriteLine(CoursesGrades[1]);
            Console.WriteLine(CoursesGrades[2]);   
            Console.WriteLine(CoursesGrades[3]);
            Console.WriteLine(CoursesGrades[4]);
            Console.WriteLine(CoursesGrades[5]); 
            Console.WriteLine(CoursesGrades[6]);
            Console.WriteLine(CoursesGrades[7]);
            Console.WriteLine(CoursesGrades[8]); 

            Console.WriteLine("\n");

            //THE SUM OF THE TOTAL CREDIT LOAD
            double sumOfCreditLoad = creditLoad.Sum();

            //THE FORMULAR FOR CALCULATING THE GPA
            GPA = (nGST_111 + nGST_112 + nMTH_110 + nMTH_112 + nCHM_111 + nCHM113 + nPHY_101 + nPHY_111 + nPHY_113) / sumOfCreditLoad;

            //THIS EVALUATES TO RATIO OF FIVE TO CHECK FOR RANK AND IF PROMOTED OR NOT
            if (GPA >= 4.5)
            {
                Console.WriteLine("CONGRATULATIONS!!! You made FIRST CLASS \nYour GPA is " + GPA + "\nPROMOTED");
            }
            else if(GPA < 4.5 && GPA >= 4.0)
            {
                Console.WriteLine("CONGRATULATIONS!!! You made SECOND CLASS UPPER \nYour GPA is " + GPA + "\nPROMOTED");
            }
            else if(GPA < 4.0 && GPA >= 3.5)
            {
                Console.WriteLine("CONGRATULATION!!! You made SECOND CLASS LOWER \nYour GPA is " + GPA + "\nPROMOTED");
            }
            else if(GPA < 3.5 && GPA >= 2.5)
            {
                Console.WriteLine("CONGRATULATIONS!!! You made THIRD CLASS but you need to BUCKLE UP \nYour GPA is " + GPA + "\nPROMOTED");
            }
            else
            {
                Console.WriteLine("SORRY, you FAILED \nYour GPA is " + GPA + "\nNOT PROMOTED");
            }
        }
        //THE METHOD FOR CHECKING THE SCORE RANGE INPUTTED IN OTHER TO DETERMINE THE POINT FOR THE CALCULATION
        static int myPointCal (int scores)
        {
            if ( scores >= 70 && scores < 100)
                {
                    return 5;
                }else if (scores >= 60 && scores < 70)
                {
                    return 4;
                }else if (scores >= 50 && scores < 60)
                { 
                    return 3;
                }else if (scores >= 40 && scores < 50)
                {
                    return 2;
                }else 
                {
                    return 1;
                }  
        }
        static char myGrades (int pointCheck)
        {
            char grade = 'S';

            switch (pointCheck)
            {
                case 5:
                    grade = 'A';
                    break;
                case 4:
                    grade = 'B';
                    break;
                case 3:
                    grade = 'C';
                    break;
                case 2:
                    grade = 'D';
                    break;
                case 1:
                    grade = 'F';
                    break;    
            }
            return grade;        
        }
        
    }
}
