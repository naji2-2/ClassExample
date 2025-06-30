using System;

namespace ClassExample
{
    public class Dog : Animal
    {
        public new void Eat()
        {
            Console.WriteLine("강아지가 냠냠 먹습니다.");
        }
    }
}