﻿using System;

namespace AssignmentOperators {
    class Program {
        static void Main(string[] args) {

            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            s += "DEF";
            Console.WriteLine(s);

            for (int b = 0; b <= 10; b++) {
                a++;
                Console.WriteLine(a);
            }
            
        }
    }
}