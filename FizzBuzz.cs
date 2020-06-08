using System;


//Fizz Buzz Challenge: Write a program that prints the numbers from 1 to 100
//For numbers divisible by 3, print “Fizz”
//For numbers divisible by 5, print “Buzz”
//For numbers divisible by both 3 and 5, print “FizzBuzz”


public class FizzBuzz {
    static void Main () {
        for (int i = 1; i <= 100; i++) {
            if (i % 3 == 0 && i % 5 == 0) {  
                Console.WriteLine ("FizzBuzz");
            }
            if (i % 3 == 0) {
                Console.WriteLine ("Fizz");
            } else if (i % 5 == 0) {
                Console.WriteLine ("Buzz");
            } else {
                Console.WriteLine (i);
            }
        }
    }
}