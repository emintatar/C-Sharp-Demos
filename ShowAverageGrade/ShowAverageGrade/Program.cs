namespace ShowAverageGrade
{
    // Write a program that takes the midterm and final grades of 5 students and finds the average grade, and then finds the average grade of the class.

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstExams = new int[5];
            int[] secondExams = new int[5];
            int[] finalExams = new int[5];

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.WriteLine("Student " + (i + 1));

                    Console.Write("Enter First Exam: ");
                    firstExams[i] = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Second Exam: ");
                    secondExams[i] = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Final Exam: ");
                    finalExams[i] = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();
                }

                catch (Exception ex) { } 
                {
                    Console.WriteLine("Enter Valid Number!");
                    i--;
                    
                }
            }

            int averageGradeStudent1 = (firstExams[0] + secondExams[0] + finalExams[0]) / 3;
            int averageGradeStudent2 = (firstExams[1] + secondExams[1] + finalExams[1]) / 3;
            int averageGradeStudent3 = (firstExams[2] + secondExams[2] + finalExams[2]) / 3;
            int averageGradeStudent4 = (firstExams[3] + secondExams[3] + finalExams[3]) / 3;
            int averageGradeStudent5 = (firstExams[4] + secondExams[4] + finalExams[4]) / 3;
            int averageGradeGeneral = (averageGradeStudent1 + averageGradeStudent2 + averageGradeStudent3 + averageGradeStudent4 + averageGradeStudent5) / 5;

            Console.WriteLine("Student 1 Average Grade: " + averageGradeStudent1);
            Console.WriteLine("Student 2 Average Grade: " + averageGradeStudent2);
            Console.WriteLine("Student 3 Average Grade: " + averageGradeStudent3);
            Console.WriteLine("Student 4 Average Grade: " + averageGradeStudent4);
            Console.WriteLine("Student 5 Average Grade: " + averageGradeStudent5);
            Console.WriteLine("General Average Grade: " + averageGradeGeneral);
        }
    }
}