﻿using System;

namespace ClassExample
{
    public class Cat : Animal
    {
        public sealed override void Eat()
        {
            Console.WriteLine("고양이가 냠냠 먹습니다.");
        }
    }
}