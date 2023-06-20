// See https://aka.ms/new-console-template for more information
using System;

namespace MyNamespace {
    class ChooseProgram{
        static void Main(string[] args){
            Console.WriteLine("Hello, Choose a Program to run!");
            Console.WriteLine("1. Hello World");
            Console.WriteLine("2. Sum of 2 numbers");
            Console.WriteLine("3. Multiplication of 2 numbers");
            Console.WriteLine("4. Division of 2 numbers");
            Console.WriteLine("5. Subtraction of 2 numbers");
            Console.WriteLine("6. Fibonnaci Sequence");
            Console.WriteLine("7. Rock-Paper-Scissors");
            Console.WriteLine("8. Exit");
            switch (Console.ReadLine()){
                case "1":
                    Hello();
                    break;
                case "2":
                    Sum();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

    static void Hello(){
     Console.WriteLine("Hello, World!");
    }
    static void Sum(){
            Console.WriteLine("Enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The sum of two numbers is " + (num1 + num2));
            
    }

    static void Multiplication(){
            Console.WriteLine("Enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The multiplication of two numbers is " + (num1 * num2));
            
    }

    static void Division(){
            Console.WriteLine("Enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The division of two numbers is " + (num1 / num2));
            
    }

    static void Substraction(){
        Console.WriteLine("Enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The substraction of two numbers is " + (num1 - num2));
    }

    static void Fibonnaci(){
        Console.WriteLine("Enter the number of sequence");
        int num = Convert.ToInt32(Console.ReadLine());
        int a = 0;
        int b = 1;
        int c = 0;
        for ( int i = 0 ; i < num ; i++){
            c = a + b;
            a = b;
            b = c;
            if (i == num - 1){
                Console.Write(c);
            }
            else{
                Console.Write(c + " , ");
            }
        }
        
    }

    static void game(){
        while(true){
        Console.WriteLine("Enter your choice");
        Console.WriteLine("1. Rock");
        Console.WriteLine("2. Paper");
        Console.WriteLine("3. Scissors");
        int choice = Convert.ToInt32(Console.ReadLine());
        Random rnd = new Random();
        int computer = rnd.Next(1,4);
        if (choice == 1){
            if (computer == 1){
                Console.WriteLine("Draw");
            }
            else if (computer == 2){
                Console.WriteLine("You lose");
            }
            else{
                Console.WriteLine("You win");
            }
        }
        else if (choice == 2){
            if (computer == 1){
                Console.WriteLine("You win");
            }
            else if (computer == 2){
                Console.WriteLine("Draw");
            }
            else{
                Console.WriteLine("You lose");
            }
        }
        else if (choice == 3){
            if (computer == 1){
                Console.WriteLine("You lose");
            }
            else if (computer == 2){
                Console.WriteLine("You win");
            }
            else{
                Console.WriteLine("Draw");
            }
        }
        else{
            Console.WriteLine("Invalid input");
        }
        Console.WriteLine("Do you want to play again? (y/n)");
        string answer = Console.ReadLine();
        if (answer == "n"){
            break;
        }
        else if (answer == "y"){
            continue;
        }
        else{
            Console.WriteLine("Invalid input");
        }

    }


}
}
}
