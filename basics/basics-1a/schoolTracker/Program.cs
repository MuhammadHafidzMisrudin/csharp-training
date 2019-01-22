using System;
using System.Collections.Generic;

namespace schoolTracker
{
    enum School
    {
        MIT = 0,
        Caltech,
        NYU,
        UBerkeley,
        UCLA
    }

    class Program
    {
        // Initialise dynamic list collection with Student type.
        static List<Student> studentList = new List<Student>();

        static void Main(string[] args)
        {
            // Uncomment this for test.
            // Console.WriteLine("How many students in your class?");
            // var studentCount = int.Parse(Console.ReadLine());

            // Initialise and specify the sizes of Arrays.
            // var studentNames = new string[studentCount];
            // var studentGrades = new int[studentCount];

            // Invoke ImportData()
            ImportData();

            // Create payroll instance and invoke payment method.
            PayRoll payroll = new PayRoll();
            payroll.PayAll();
            Console.WriteLine();

            // Initialise dynamic lists collection with types (string, int, Student).
            var studentNames = new List<string>();
            var studentGrades = new List<int>();
            // var studentList = new List<Student>();

            // Console.WriteLine("Capacity studentNames: {0}", studentNames.Capacity);
            // Console.WriteLine("Capacity studentGrades: {0}", studentGrades.Capacity);
            Console.WriteLine("Capacity studentList: {0}", studentList.Capacity);

            // Set a flag.
            var addElement = true;

            // Use while loop for dynamic data insertion.
            while (addElement)
            {

                // Implement try-catch exception handling for specific case of input exception.
                try
                {
                    // Create a student object.
                    var studentObject = new Student();

                    Console.WriteLine();

                    // Set propeties values.
                    // Console.WriteLine("Student Name: ");
                    // studentObject.Name = Console.ReadLine();
                    studentObject.Name = Util.Console.AskInputConsole("Student Name: ");

                    // Console.WriteLine("Student Grade: ");
                    // studentObject.Grade = int.Parse(Console.ReadLine());
                    // studentObject.Grade = int.Parse(Util.Console.AskInputConsole("Student Grade: "));
                    // var resultInputGrade = int.TryParse(Util.Console.AskInputConsole("Student Grade: "), out studentObject.Grade);
                    studentObject.Grade = Util.Console.AskInputInteger("Student Grade: ");


                    studentObject.School = (School) Util.Console.AskInputInteger("School Name [type the corresponding number]: \n(0) MIT \n(1) Caltech \n(2) NYU \n(3) UBerkeley \n(4) UCLA");

                    // Add exception handling statement to check input validation.
                    // if (!resultInputGrade) {
                    //   Console.WriteLine("Error, input Grade must be integer.");
                    // }

                    // Console.WriteLine("Student Birthday: ");
                    // studentObject.Birthday = Console.ReadLine();
                    studentObject.Birthday = Util.Console.AskInputConsole("Student Birthday: ");

                    // Console.WriteLine("Student Address: ");
                    // studentObject.Address = Console.ReadLine();
                    studentObject.Address = Util.Console.AskInputConsole("Student Address: ");

                    // Console.WriteLine("Student Phone: ");
                    // studentObject.Phone = int.Parse(Console.ReadLine());
                    // studentObject.SetPhoneNumber(int.Parse(Console.ReadLine()));
                    // studentObject.Phone = int.Parse(Util.Console.AskInputConsole("Student Phone: "));
                    studentObject.Phone = Util.Console.AskInputInteger("Student Phone: ");

                    // Add new created student object (& details) to the student list.
                    studentList.Add(studentObject);

                    // Count student.
                    Student.CountStudent++;
                    Console.WriteLine("Student => {0}", Student.CountStudent);

                    Console.WriteLine("Add another? y/n: ");
                    var inputDetails = Console.ReadLine();

                    if (inputDetails != "y" && inputDetails != "Y")
                    {
                        addElement = false;
                    }
                }
                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error adding student, please try again.");
                }
            } // end while loop.

            Console.WriteLine();
            // Console.WriteLine("Capacity studentNames: {0}", studentNames.Capacity);
            // Console.WriteLine("Total studentNames: {0}", studentNames.Count);
            // Console.WriteLine("Capacity studentGrades: {0}", studentGrades.Capacity);
            // Console.WriteLine("Total studentNames: {0}", studentGrades.Count);
            Console.WriteLine("Capacity in studentList: {0}", studentList.Capacity);
            Console.WriteLine("Total students in studentList: {0}", studentList.Count);
            Console.WriteLine();

            // Uncomment this for test.
            // Store and insert data for both Arrays.
            // for (int i=0; i<studentCount; i++) {
            //   Console.WriteLine("Student Name: ");
            //   studentNames[i] = Console.ReadLine();
            //
            //   Console.WriteLine("Student Grade: ");
            //   studentGrades[i] = int.Parse(Console.ReadLine());
            // }

            // Display output of student details.
            for (int i = 0; i < studentList.Count; i++)
            {
                Console.WriteLine("List => {0}, Name: {1}, Grade: {2}, Birthday: {3}, Address: {4}, Phone: {5}", studentList[i],
                                                                                                                 studentList[i].Name,
                                                                                                                 studentList[i].Grade,
                                                                                                                 studentList[i].Birthday,
                                                                                                                 studentList[i].Address,
                                                                                                                 studentList[i].Phone);
            }

            // Export the student data based on School.
            Exports();

            // Uncomment to use foreach.
            // foreach (var student in studentList)
            //    {
            //        Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            //    }
            Console.ReadKey();
        }

        // Add function to allow spreadsheet importer to import student data.
        static void ImportData()
        {
            var importedStudentData = new Student("Inma", 90, "03/1992", "Sydney CBD", 98765);
            Console.WriteLine(importedStudentData.Name);
            Console.WriteLine(importedStudentData.Grade);
            Console.WriteLine(importedStudentData.Birthday);
            Console.WriteLine(importedStudentData.Address);
            Console.WriteLine(importedStudentData.Phone);
            Console.WriteLine();
        }

        static void Exports()
        {
            foreach (var student in studentList)
            {
                switch(student.School)
                {
                    case School.MIT:
                        Console.WriteLine("\nExporting to MIT");
                        break;
                    case School.Caltech:
                        Console.WriteLine("\nExporting to Caltech");
                        break;
                    case School.NYU:
                        Console.WriteLine("\nExporting to NYU");
                        break;
                    case School.UBerkeley:
                        Console.WriteLine("\nExporting to Berkeley ");
                        break;
                    case School.UCLA:
                        Console.WriteLine("\nExporting to UCLA");
                        break;
                }
            }
        }
    }

    // Implement Object-Oriented.
    // Base Class, SchoolMember.
    class SchoolMember
    {

        // Initialise fields.
        public string Name;
        public string Address;
        protected int phone;

        // Implement Phone property.
        // Add properties.
        public int Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }
    }

    // Implement Object-Oriented.
    // Derived Class, Student.
    class Student : SchoolMember
    {

        // Initialise fields.
        // public string Name;
        public int Grade;
        public string Birthday;
        public School School; // Use enum (enumerator) type.
        // public string Address;
        // private int phone;

        // Initialise static member variable.
        // Variable to count number of student when input.
        public static int CountStudent = 0;

        // Empty Constructor class.
        public Student()
        {

        }

        // Initialise a constructor for Student class.
        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Console.WriteLine("Constructor() executes when the object is instantiated");
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }

        // Implement encapsulation.
        // Add function to set value for private variable Phone.
        // public void SetPhoneNumber(int number) {
        //   phone = number;
        // }

        // Add function to get value for private variable Phone.
        // public int GetPhoneNumber() {
        //   return phone;
        // }

        // Implement Phone property.
        // Add properties.
        // public int Phone {
        //   get {
        //     return this.phone;
        //   }
        //   set {
        //     this.phone = value;
        //   }
        // }
    }

    // Implement Object-Oriented.
    // Derived Class, Teacher.
    //class Teacher : SchoolMember
    //{

    //    // Initialise fields.
    //    // public string Name;
    //    // public string Address;
    //    // public int Phone;
    //    public string Subject;
    //    public string Class;
    //}
}
