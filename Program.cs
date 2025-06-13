using System;

namespace ClassExample
{
    internal class Program
    {
        class Parent
        {
            public static int counter = 0;

            public void CountParent()
            {
                Parent.counter++;
            }

            public Parent() { Console.WriteLine("Parent()"); }
            public Parent(string name) { Console.WriteLine("Parent(string name)"); }
            public Parent(double param) { Console.WriteLine("Parent(double param)"); }
        }

        class Child : Parent{

            public void CountChild()
            {
                Child.counter++;
            }

            public Child() : base("child")
            {
                Console.WriteLine("Child()");
            }

            public Child(string name) : base(name)
            {
                Console.WriteLine("Child(string name)");
            }

            public Child(double param) : base(param)
            {
                Console.WriteLine("Child(double param)");
            }
        }

        static void Main(string[] args)
        {
            Child childA = new Child("abc");
            Child childB = new Child(3);

            Parent parent = new Parent();
            Child child = new Child();

            parent.CountParent();
            child.CountChild();

            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);

        }
    }
}
