using System;

namespace GenericConstraints_Example_2
{
    public class GenericClass<T> where T : struct
    {
        private T ID;
        private T Phno;
        public void genericMethod(T ID, T Phno)
        {
            this.ID = ID;
            this.Phno = Phno;
        }
        public void Display()
        {
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Phone Number: {0}", Phno);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<long> obj = new GenericClass<long>();
            obj.genericMethod(107, 9703002617);
            obj.Display();
        }
    }
}
