﻿
using System;
namespace MyNamespace {
    class ChooseProgram{
        static void Main(string[] args){
            while(true){
            Console.WriteLine("Hello, Choose a Program to run!");
            Console.WriteLine("1. Hello World");
            Console.WriteLine("2. Sum of 2 numbers");
            Console.WriteLine("3. Multiplication of 2 numbers");
            Console.WriteLine("4. Division of 2 numbers");
            Console.WriteLine("5. Subtraction of 2 numbers");
            Console.WriteLine("6. Fibonnaci Sequence");
            Console.WriteLine("7. Rock-Paper-Scissors");
            Console.WriteLine("8. Prime Numbers");
            Console.WriteLine("9. Check Prime Numbers");
            Console.WriteLine("10. Case Converter");
            Console.WriteLine("11. Rational Numbers");
            Console.WriteLine("12. Swap without 3rd variable");
            Console.WriteLine("13. Floyd's Triangle");
            Console.WriteLine("14. Calculate the volume & surface area of a sphere");
            Console.WriteLine("15. Demonstrate BitWise Operators");
            Console.WriteLine("16. Demonstrate Jagged Array");
            Console.WriteLine("17. Exit");
            switch (Console.ReadLine()){
                case "1":
                    Hello();
                    break;
                case "2":
                    Sum();
                    break;
                case "3":
                    Multiplication();
                    break;

                case "4":
                    Division();
                    break;
                case "5":
                    Substraction();
                    break;  
                case "6":
                    Fibonnaci();
                    break;
                case "7":
                    game();
                    break;  
                case "8":
                    Prime();
                    break;
                case "9":
                    CheckPrime();
                    break;
                case "10":
                    CaseConverter();
                    break;
                case "11":
                    Rational();
                    break;
                case "12":
                    swap();
                    break;
                case "13":
                    floyd();
                    break;
                case "14":
                    sphere();
                    break;
                case "15":
                    bitwise();
                    break;
                case "16":
                    jagged();
                    break;
                case "17":
                    return;
                
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            Console.WriteLine("Do you want to continue? (y/n)");
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
                Console.Write(c+"\n");
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
        // make a string arr
        string[] arr = new string[3];
        arr[0] = "Rock";
        arr[1] = "Paper";
        arr[2] = "Scissors";
        //computer thinking time
        Console.WriteLine("Computer is thinking...");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Computer choice is " + arr[computer-1]);
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

  static void Prime(){
        //input the range and find all the prime numbers in the range
        Console.WriteLine("Enter the range");
        int range = Convert.ToInt32(Console.ReadLine());
        int counter = 0;
        for (int i =2;i<=range;i++){
            for (int j = 2; j <= i; j++){
                if (i % j == 0){
                    break;
                }
                else if (j == i - 1){
                    Console.Write(i+" ");
                    counter++;
                }
            }
        }
        Console.WriteLine("\nThere are "+counter+" prime numbers in the range");
    }

    static void CheckPrime(){
        Console.WriteLine("Enter the number");
        int num = Convert.ToInt32(Console.ReadLine());
        for( int i = 2; i <= num; i++){
            if(num % i == 0){
                Console.WriteLine("Not a prime number");
                break;
            }
            else if (i == num - 1){
                Console.WriteLine("Prime number");
                break;
            }
        }
    }

    static void CaseConverter(){
        Console.WriteLine("Enter the string");
        string str = Console.ReadLine();
        Console.WriteLine("Enter the choice");
        Console.WriteLine("1. Upper case");
        Console.WriteLine("2. Lower case");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1){
            Console.WriteLine(str.ToUpper());
        }
        else if (choice == 2){
            Console.WriteLine(str.ToLower());
        }
        else{
            Console.WriteLine("Invalid input");
    }

}

static void Rational(){
    Console.WriteLine("Enter the number");
    double num = Convert.ToDouble(Console.ReadLine());
    if(num % 1 == 0){
        Console.WriteLine("The number is rational");
    }
    else{
        Console.WriteLine("The number is irrational");
    }   
}

static void swap(){
     Console.WriteLine("Enter the number 1");
     double x = Convert.ToDouble(Console.ReadLine());
     Console.WriteLine("Enter the number 2");
     double y = Convert.ToDouble(Console.ReadLine());
     x = x + y;
     y = x - y;
     x = x - y;
    Console.WriteLine(" x is " + x);
    Console.WriteLine(" y is " + y);
    Console.WriteLine("After Swap x is " + x);
    Console.WriteLine("After Swap y is " + y);
}

static void smallest(){
    Console.WriteLine("Enter the size of array");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[size];
    for (int i = 0 ; i < size ; i++){
        Console.WriteLine("Enter the element");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    int smallest = arr[0];
    for (int i = 0;i < size ; i++){
        if (arr[i] < smallest){
            smallest = arr[i];
        }
    }
    Console.WriteLine("The smallest number is " + smallest);
}

static void floyd(){
    Console.WriteLine("Enter the number of rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    int num = 1;
    for( int i = 1; i<= rows; i++){
        for ( int j = i; j > 0; j--){
            Console.Write(num + " ");
            num++;
        }
        Console.WriteLine();
}   }

static void sphere(){
    Console.WriteLine("Enter the radius of the sphere");
    double radius = Convert.ToDouble(Console.ReadLine());
    double volume  = (4/3) * Math.PI * Math.Pow(radius,3);
    Console.WriteLine("The volume of the sphere is " + volume);
    double surfaceArea = 4 * Math.PI * Math.Pow(radius,2);
    Console.WriteLine("The surface area of the sphere is " + surfaceArea);
}

static void  bitwise(){
    //demonstrate bitwise operator
    Console.WriteLine("Enter the number 1");
    Console.WriteLine("Enter the number 2");
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    //convert to binary
    string binary1 = Convert.ToString(num1,2);
    string binary2 = Convert.ToString(num2,2);
    Console.WriteLine("The binary of number 1 is " + binary1);
    Console.WriteLine("The binary of number 2 is " + binary2);
    Console.WriteLine("The bitwise AND is " + (num1 & num2));
    Console.WriteLine("The bitwise OR is " + (num1 | num2));
    Console.WriteLine("The bitwise XOR is " + (num1 ^ num2));
    Console.WriteLine("The bitwise NOT of number 1 is " + (~num1));
    Console.WriteLine("The bitwise NOT of number 2 is " + (~num2));
}

static void jagged(){
    Console.WriteLine("Enter the number of rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    int[][] arr = new int[rows][];
    for (int i = 0; i< rows; i++){
        Console.WriteLine("Enter the numbers in the "+(i+1)+"th row ");
        int size = Convert.ToInt32(Console.ReadLine());
        for (int j = 0; j < size; j++){
            Console.WriteLine("Enter the element "+ (j+1));
            arr[i][j] = Convert.ToInt32(Console.ReadLine());
        }
    }

    //print the jagged 2d array
    Console.WriteLine("The jagged 2D array is ");
    for(int i = 0 ; i< rows;i++){
        for(int j = 0; j < arr[i].Length; j++){
            Console.Write(arr[i][j] + " ");
        }
        Console.WriteLine();
    }

}
}
}
