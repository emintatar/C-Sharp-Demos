namespace StudentManagementSystem
{
    class Program
    {
        private static void showOptions()
        {
            Console.WriteLine("1. Show student's informations");
            Console.WriteLine("2. Show student's GPA");
            Console.WriteLine("3. Show student's university");
            Console.WriteLine("4. Exit");
        }

        static void Main(string[] args)
        {
            bool control = true;
            Student sampleStudent = new Student(48, "Emin", "Tatar", 80, 80, 80, "Marmara University");

            while (control)
            {
                showOptions();

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        sampleStudent.showStudentInfos();
                        break;

                    case "2":
                        Console.WriteLine(sampleStudent.showGpa());
                        break;

                    case "3":
                        sampleStudent.showUniversity();
                        break;

                    case "4":
                        control= false; 
                        break;
                }
            }
        }
    }
}