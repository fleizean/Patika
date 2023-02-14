using System;

namespace static_sinif
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Emplooye Count: {0}", Employees.employeeCount);

            Employees e1 = new Employees("Enes", "Yağız", "IK");
            Console.WriteLine("Emplooye Count: {0}", Employees.employeeCount);
            Employees e2 = new Employees("Sıdık", "Devir", "IK");
            Employees e3 = new Employees("Dilaver", "Guclu", "IK");
            Console.WriteLine("Emplooye Count: {0}", Employees.employeeCount);

            Console.WriteLine("Sum Result: {0}", Calculate.Sum(100,200));
            Console.WriteLine("Difference Result: {0}", Calculate.Difference(400,200));
        }
    }
    class Employees
    {
        private static int _employeeCount;

        public static int employeeCount { get => _employeeCount; }

        private string _Name;
        private string _lastName;
        private string _Department;

        static Employees()
        {
            _employeeCount = 0;
        }

        public Employees(string name, string lastname, string department)
        {
            this._Name = name;
            this._lastName = lastname;
            this._Department = department;
            _employeeCount++;
        }
    }

    static class Calculate
    {
        public static long Sum(int num1, int num2)
        {
            return (num1 + num2);
        }

        public static long Difference(int num1, int num2)
        {
            return (num1 - num2);
        }
    
    }
}