using System;
using System.Data;

namespace project1
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("What is your name:");
            string studentname = Console.ReadLine();
            float GPA = 0;
          
            DataTable gpa = new DataTable();
            gpa.Columns.Add("Course code");
            gpa.Columns.Add("Course unit");
            gpa.Columns.Add("Score");
            gpa.Columns.Add("Grade");
            gpa.Columns.Add("Grade points");
            Console.WriteLine("Enter  Course code, Course unit, Score separated by commas");
            for (int i = 0; i < 7; i++)
            {
               DataRow row = gpa.NewRow();
                string data = Console.ReadLine();
                string[] values = data.Split(",");
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
                    row["Grade"] = "c";
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
                gpa.Rows.Add(row);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Coursecode" + "\t " + "Courseunit" + "\t " + "Score" + "\t\t " + "Grade" + "\t\t" + "Gradepoints");
            foreach ( DataRow R in gpa.Rows)
            {
                
                Console.WriteLine(R["Course code"] + "\t\t " + R["Course unit"] + "\t\t " + R["Score"] + "\t\t " + R["Grade"] + "\t\t" + R["Grade points"]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Student name is {0}", studentname);

        }
    }

}

