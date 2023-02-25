using System;
					
public class Program
{
	public static void Main()
	{
		Student s = new Student();
		s.Name = "Enes";
		s.lastName = "Yağız";
		s.studentNo = 123478;
		s.studentClass = 12;
		s.StudentPrinter();
		Console.WriteLine("**********");
		s.IncreaseClass();
		s.StudentPrinter();
		Console.WriteLine("**********");
		s.DecreaseClass();
		s.StudentPrinter();

        // Test 3
        Console.WriteLine("***** TEST 3 *****");
        Student s1 = new Student("Deniz", "Arda", 256, 1);
        s1.DecreaseClass();
        s1.DecreaseClass();
        s1.StudentPrinter();
	}
	
	class Student
	{
		private string _Name;
		private string _lastName;
		private int _studentNo;
		private int _studentClass;
		
		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}
		
		public string lastName { get => _lastName; set => _lastName = value; }
		public int studentNo { get => _studentNo; set => _studentNo = value; }
		public int studentClass {
            get => _studentClass; 
            set
            {
                if(value < 1){
                    Console.WriteLine("Value cannot be decrease");
                    value = 1;
                }
                else
                    _studentClass = value;
            }
        }
		
		public Student(string name, string lastname, int studentno, int studentclass)
		{
			Name = name;
			lastName = lastname;
			studentNo = studentno;
			studentClass = studentclass;
		}
		public Student() { } 
		
		// public methods
		public void StudentPrinter()
		{
			Console.WriteLine("Student Name: {0}",Name);
			Console.WriteLine("Student Last Name: {0}",lastName);
			Console.WriteLine("Student Student No: {0}",studentNo);
			Console.WriteLine("Student Class: {0}",studentClass);
		}
		public void IncreaseClass()
		{
			this.studentClass = this.studentClass + 1;
		}
		public void DecreaseClass()
		{
			this.studentClass = this.studentClass - 1;
		}
	}
}