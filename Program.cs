using System;
using System.Collections.Generic;

namespace ClassExample
{
    internal class Program
    {
        class Parent
        {
            public static int counter = 0;
            public int variable = 273;

            // 하이딩
            public void Method()
            {
                Console.WriteLine("부모의 메소드");
            }

            // 오버라이딩
            public virtual void MethodO()
            {
                Console.WriteLine("부모의 메소드");
            }

            public void CountParent()
            {
                Parent.counter++;
            }

            public Parent() { Console.WriteLine("Parent()"); }
            public Parent(string name) { Console.WriteLine("Parent(string name)"); }
            public Parent(double param) { Console.WriteLine("Parent(double param)"); }
        }

        class Child : Parent{
            public string variable = "12345";
            public new void Method()
            {
                Console.WriteLine("자식의 메소드");
            }

            public override void MethodO()
            {
                Console.WriteLine("자식의 메소드");
            }

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

        public static int number = 10;

        static void Main(string[] args)
        {
            // 섀도잉
            int number = 20;
            Console.WriteLine(number);          // 클래스 변수 이름이 가려짐 (shadowing)
            Console.WriteLine(Program.number);  // 호출하고 싶으면 클래스 변수명으로 사용

            Child childA = new Child("abc");
            Child childB = new Child(3);

            Parent parent = new Parent();
            Child child = new Child();

            parent.CountParent();
            child.CountChild();

            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);

            // 변수 하이딩
            Child child3 = new Child();
            Console.WriteLine(child3.variable);             // 문자열 variable 출력
            Console.WriteLine(((Parent)child3).variable);   // 숫자 variable 출력

            // 메서드 하이딩
            child3.Method();            // 자식의 메서드 호출
            ((Parent)child3).Method();  // 부모의 메서드 호출

            // 메서드 하이딩
            child3.MethodO();            // 자식의 메서드 호출
            ((Parent)child3).MethodO();  // 자식의 메서드 호출  --> 부모의 메소드를 덮어썼기 때문

            // 강아지와 고양이로 알아보는 하이딩, 오버라이딩
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Cat(), new Cat(), new Dog(), new Dog()
            };
            foreach( var item in Animals)
            {
                item.Eat();
            }
        
        }
    }
}
