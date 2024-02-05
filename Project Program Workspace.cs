using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static public char[,] tictac = new char[3, 3] { {' ', ' ', ' '}, {' ', ' ', ' '}, {' ', ' ', ' '}};


    static void Board()
    {
        Console.WriteLine();
        Console.WriteLine($" {tictac[0, 0]} | {tictac[0, 1]} | {tictac[0, 2]} ");
        Console.WriteLine($"-----------");
        Console.WriteLine($" {tictac[1, 0]} | {tictac[1, 1]} | {tictac[1, 2]} ");
        Console.WriteLine($"-----------");
        Console.WriteLine($" {tictac[2, 0]} | {tictac[2, 1]} | {tictac[2, 2]} "); 
    }

    static void PlayerOne()
    {
        try
        {
            char p1 = 'x';

            Console.WriteLine("\nPlayer 1 (x), enter a Row # from 1-3 : ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a Column # from 1-3 : ");
            int col = Convert.ToInt32(Console.ReadLine());

            if (tictac[row - 1, col - 1] != ' ')
            {
                Console.WriteLine("That space is already taken.");
                PlayerOne();
            }
            else
            {
                tictac[row - 1, col - 1] = p1;
            }
            
        }
        catch
        {
            Console.WriteLine("That is not a valid response.");
            PlayerOne();
        }
    }

    static void PlayerTwo()
    {
        try
        {
            char p2 = 'o';

            Console.WriteLine("\nPlayer 2 (o), enter a Row # from 1-3 : ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a Column # from 1-3 : ");
            int col = Convert.ToInt32(Console.ReadLine());

            if (tictac[row - 1, col - 1] != ' ')
            {
                Console.WriteLine("That space is already taken.");
                PlayerTwo();
            }

            else
            {
                tictac[row - 1, col - 1] = p2;
            }
            
        }

        catch
        {
            Console.WriteLine("That is not a valid response.");
            PlayerTwo();
        }
    }

    // start checking for victories tmrw

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to a game of Tic-Tac-Toe!");
        
        while (true)
        {
            PlayerOne();
            Board();
            PlayerTwo();
            Board();
        }

        Console.ReadKey();
    }

    

}