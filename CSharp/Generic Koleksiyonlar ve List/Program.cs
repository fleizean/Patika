using System;
using System.Collections.Generic;

namespace generic_list
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> sumArray = new List<int>();
            sumArray.Add(23);
            sumArray.Add(10);
            sumArray.Add(4);
            sumArray.Add(5);
            sumArray.Add(92);
            sumArray.Add(34);

            List<string> colorArray = new List<string>();
            colorArray.Add("Red");
            colorArray.Add("Blue");
            colorArray.Add("Orange");
            colorArray.Add("Purple");
            colorArray.Add("Yellow");
            colorArray.Add("Pink");
            colorArray.Add("Green");

            Console.WriteLine(sumArray.Count);
            Console.WriteLine(colorArray.Count);

            foreach(var item in sumArray)
                Console.WriteLine(item);
            foreach(var item in colorArray)
                Console.WriteLine(item);
            
            colorArray.ForEach(color=> Console.WriteLine(color));
            sumArray.ForEach(sum=> Console.WriteLine(sum));
        
            sumArray.Remove(4);
            colorArray.Remove("Red");

            colorArray.ForEach(color=> Console.WriteLine(color));
            sumArray.ForEach(sum=> Console.WriteLine(sum));
        
            sumArray.RemoveAt(0);
            colorArray.RemoveAt(1);
        
            colorArray.ForEach(color=> Console.WriteLine(color));
            sumArray.ForEach(sum=> Console.WriteLine(sum));
        
            if(sumArray.Contains(10))
                Console.WriteLine("We found 10 sum in sumArray");
            Console.WriteLine(colorArray.BinarySearch("Yellow"));

            string[] pets = {"Cat", "Bird", "Dog"};
            List<string> petArray = new List<string>(pets);

            petArray.Clear();

            List<Customers> customerList = new List<Customers>();
            Customers c1 = new Customers();
            c1.gsName = "Frank";
            c1.gsLastName = "Parker";
            c1.gsAge = 28;

            Customers c2 = new Customers();
            c1.gsName = "Alice";
            c1.gsLastName = "Stin";
            c1.gsAge = 23;

            customerList.Add(c1);
            customerList.Add(c2);

            List<Customers> newList = new List<Customers>();
            newList.Add(new Customers(){
                gsName = "Jack",
                gsLastName = "Lovato",
                gsAge = 21
            });

            foreach(var item in customerList)
                Console.WriteLine("Customer name: {0}\nCustomer surname: {1}\nCustomer age: {2}",item.gsName, item.gsLastName, item.gsAge);
        
            newList.Clear();
        }
    }

    public class Customers
    {
        private string _name;
        private string _lastname;
        private int _age;

        public string gsName{ get => _name; set => _name = value; }
        public string gsLastName{ get => _lastname; set => _lastname = value; }
        public int gsAge{ get => _age; set => _age = value; }
    }
}