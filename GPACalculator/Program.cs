using System;
using System.Collections.Generic;

namespace GPACalculator
{
    class Program
    {
        static void Main(string[] args)
        {




            //string studentName = "Sophia Johnson";
            //string course1Name = "English 101";
            //string course2Name = "Algebra 101";
            //string course3Name = "Biology 101";
            //string course4Name = "Computer Science I";
            //string course5Name = "Psychology 101";
            //Dictionary<string,List<dynamic>> myTest = new Dictionary<string,List<dynamic>>(){"myKey",{"val1","val2","val3"}};
            Dictionary<string,string> studentInfo = new Dictionary<string,string>(){{"studentName","Sophia Johnson"},{"course1Name","English 101"},{"course2Name","Algebra 101"},{"course3Name","Biology 101"},{"course4Name","Computer Science I"},{"course5Name","Psychology 101"}};


            //int course1Credit = 3;
            //int course2Credit = 3;
            //int course3Credit = 4;
            //int course4Credit = 4;
            //int course5Credit = 3;
            Dictionary<string,int> currentCourseCredit = new Dictionary<string,int>(){{"course1Credit",3},{"course2Credit",3},{"course3Credit",4},{"course4Credit",4},{"course5Credit",3}};


            //int gradeA = 4;
            //int gradeB = 3;
            //int gradeC = 2;
            //int gradeD = 1;
            Dictionary<string,int> standardGradesValues = new Dictionary<string,int>(){{"gradeA",4},{"gradeB",3},{"gradeC",2},{"gradeD",1}};



            //Course			    Grade
            //English 101		     A
            //Algebra 101		     B
            //Biology 101		     B
            //Computer Science I	 B
            //Psychology 101	     A
            Dictionary<string,string> studentCourseGrade = new Dictionary<string,string>(){{"course1Name","A"},{"course2Name","B"},{"course3Name","B"},{"course4Name","B"},{"course5Name","A"}};

            //gpa = (hrs*gd1+ hrs*gd2+ hrs*gd3+ hrs*gd4+ hrs*gd5)/total hrs
            Console.WriteLine($"Student: {studentInfo["studentName"]}\n\nCourse\t\t\t\tGrade\tCredit Hours\n");
            double gpaCalculator(){
                double result;
                double creditedGradeHours = 0;
                int totalHours = 0;

                foreach(var item in studentCourseGrade){

                    int grade = standardGradesValues[$"grade{item.Value}"];
                    int correspondingCreditHour = currentCourseCredit[$"{item.Key.Substring(0,7)}Credit"];

                    //tab indentation is an issue😀
                    string tabIndentation = studentInfo[item.Key].Length>=15?"\t\t":studentInfo[item.Key].Length>=12?"\t\t\t":"\t\t\t";
                    Console.WriteLine($"{studentInfo[item.Key]}{tabIndentation}{grade}\t\t{correspondingCreditHour}");

                    //calculate the credithour * gradeValues
                    double valueCal = grade*correspondingCreditHour;
                    creditedGradeHours+=valueCal;
                    //calculate total hours
                    totalHours+=correspondingCreditHour;


                }
                result = Math.Round(creditedGradeHours/totalHours,2);

                return result;
            }

            double finalGPA = gpaCalculator();
            Console.WriteLine($"\nFinal GPA:\t\t\t{finalGPA}");
            Console.ReadLine();








        }
    }
}
