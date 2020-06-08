using System;

//Function that says whether a string is a palindrome or not

public class Program {
    public static void Main (String input) {
        for (int i = 0; i < input.length() / 2; i++) {
            if (input[i] != input[length - i - 1]){
                Console.Write ("False");
                return;
            }
        }
        Console.Write ("True");
    }
}