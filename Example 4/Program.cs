namespace Generic_Constraints_4
{
    public class Sample<T> where T : new()
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample<ClassA> obj1 = new Sample<ClassA>(); //No Error, as ClassA has constructor of no parameters.

            //Sample<ClassB> obj2 = new Sample<ClassB>(); //Error, as ClassB has constructor which takes parameters.

        }
    }
    public class ClassA
    {
        public ClassA()
        {

        }
    }

    public class ClassB
    {
        public ClassB(string customerName)
        {

        }
    }
}
