using System;
using System.Data;

namespace ConsoleApp3
{
    class program
    {
        static void Main()
        {
            start:
            Console.WriteLine("What is your name:");
            string studentname = Console.ReadLine();
            Console.WriteLine("How many courses do you do?");
            int n = Convert.ToInt32(Console.ReadLine());
            int totalgp = 0;
            int totalcu = 0;
            float GPA = 0;

            DataTable gpa = new DataTable();
            gpa.Columns.Add("Course code");
            gpa.Columns.Add("Course unit");
            gpa.Columns.Add("Score");
            gpa.Columns.Add("Grade");
            gpa.Columns.Add("Grade points");
            gpa.Columns.Add("TotalGradepoint");
        Entry:
            try
            {
                Console.WriteLine("Enter  Course code, Course unit, Score separated by commas");
                for (int i = 0; i < n; i++)
                {
                    DataRow row = gpa.NewRow();
                    string data = Console.ReadLine();
                    string[] values = data.Split(',');
                    row["Course code"] = values[0];
                    row["Course unit"] = Convert.ToInt32(values[1]);
                    row["Score"] = Convert.ToInt32(values[2]);


                    if (Convert.ToInt32(row["Score"]) >= 70)
                    {
                        row["Grade"] = "A";
                        row["Grade points"] = 5;
                    }
                    else if (Convert.ToInt32(row["Score"]) < 70 && Convert.ToInt32(row["Score"]) >= 60)
                    {
                        row["Grade"] = "B";
                        row["Grade points"] = 4;
                    }
                    else if (Convert.ToInt32(row["Score"]) < 60 && Convert.ToInt32(row["Score"]) >= 50)
                    {
                        row["Grade"] = "C";
                        row["Grade points"] = 3;
                    }
                    else if (Convert.ToInt32(row["Score"]) < 50 && Convert.ToInt32(row["Score"]) >= 40)
                    {
                        row["Grade"] = "D";
                        row["Grade points"] = 2;
                    }
                    else if (Convert.ToInt32(row["Score"]) < 40 && Convert.ToInt32(row["Score"]) >= 30)
                    {
                        row["Grade"] = "E";
                        row["Grade points"] = 1;
                    }
                    else
                    {
                        row["Grade"] = "F";
                        row["Grade points"] = 0;
                    }
                    int g = Convert.ToInt32(row["Grade points"]);
                    int h = Convert.ToInt32(row["Course unit"]);
                    row["TotalGradepoint"] = g * h;
                    totalgp += Convert.ToInt32(row["TotalGradepoint"]);
                    totalcu += Convert.ToInt32(row["Course unit"]);
                    gpa.Rows.Add(row);
                }
            }
            catch (Exception hmm)
            {
                Console.WriteLine(hmm.Message);
                goto Entry;
            }

            Console.WriteLine("\n");
            Console.WriteLine("Coursecode" + "\t " + "Courseunit" + "\t " + "Score" + "\t\t " + "Grade" + "\t\t" + "Gradepoints" + "\t\t" + "TotalGradepoint");
            foreach (DataRow R in gpa.Rows)
            {

                Console.WriteLine(R["Course code"] + "\t\t" + R["Course unit"] + "\t\t " + R["Score"] + "\t\t " + R["Grade"] + "\t\t" + R["Grade points"] + "\t\t\t\t" + R["TotalGradepoint"]);


            }
            Console.WriteLine("\n");
            GPA = (totalgp / totalcu);
            Console.WriteLine("Student name is {0}", studentname);
            Console.WriteLine("Student's gpa is {0}", GPA);
        end:
            try
            {
                Console.WriteLine("do you want to go again? 1 for yes and 2 for no");
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 1)
                {
                    goto start;
                }
                else if (answer == 2)
                {
                    Console.WriteLine("Thank you for using our calculator");

                }
                else
                {
                    Console.WriteLine("wrong input try again");
                    goto end;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto end;
            }
        }
    }

}