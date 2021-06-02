using System;

namespace GenericConstraints_Example_1
{
    public class GenericClass<T> where T : class
    {
        private T Name;
        private T location;
        public void genericMethod(T Name, T location)
        {
            this.Name = Name;
            this.location = location;
        }
        public void Display()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", location);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> obj = new GenericClass<string>();
            obj.genericMethod("Rohit", "Bhimavaram");
            obj.Display();
        }
    }
}
