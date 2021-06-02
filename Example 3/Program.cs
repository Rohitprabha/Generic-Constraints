using System;

namespace Generic_Constraints_3
{
    public class GenericClass<T, U> where T : struct where U : class
    {
        private T ID;
        private U Name;
        public void genericMethod(T ID, U Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public void Display()
        {
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Name: {0}", Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int, string> obj = new GenericClass<int, string>();
            obj.genericMethod(10, "Rohit");
            obj.Display();
        }
    }
}
