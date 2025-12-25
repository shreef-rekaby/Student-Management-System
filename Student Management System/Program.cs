namespace Student_Management_System
{
    class Program
    {
        private static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("--- Student Management Menu ---");
                Console.WriteLine("1. Add Students");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Delete Students");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice)) continue;

                Console.WriteLine();
                if (choice == 4)
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }

                switch (choice)
                {
                    case 1:
                        AddStudents();
                        break;
                    case 2:
                        ViewStudents();
                        break;
                    case 3:
                        DeleteStudent();
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private static void AddStudents()
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Grade: ");
            double grade = double.Parse(Console.ReadLine());

            Console.Write("Select Department (0=IT, 1=CS, 2=IS, 3=SE): ");
            int depIdx = int.Parse(Console.ReadLine());
            
            Department dep = (Department)depIdx;

            Console.Write("Enter Street: ");
            string street = Console.ReadLine();

            Console.Write("Enter City: ");
            string city = Console.ReadLine();

            Console.Write("Enter Postal Code: ");
            string zip = Console.ReadLine();

            Address address = new Address(street, city, zip);
            Student student = new Student(id, name, grade, dep, address);

            students.Add(student);
            Console.WriteLine("\nStudent added successfully.\n");
        }

        private static void ViewStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No records found.");
            }
            else
            {
                foreach (Student st in students)
                {
                    st.DisplayStudentInfo();
                }
            }
        }

        private static void DeleteStudent()
        {
            Console.Write("Enter Student Id To Delete: ");
            int id = int.Parse(Console.ReadLine());

           
            int removedCount = students.RemoveAll(st => st.Id == id);

            if (removedCount > 0)
            {
                Console.WriteLine("Student deleted.");
            }
            else
            {
                Console.WriteLine("\nStudent not found.\n");
            }
        }
    }
}

