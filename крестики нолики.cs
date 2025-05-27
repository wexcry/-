﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace гн
{
    internal class Program
    {
            static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            static int currentPlayer = 1;

            static void Main()
            {
                int choice;
                bool validInput;

                do
                {
                    Console.Clear();
                    DrawBoard();

                    Console.WriteLine($"Игрок {currentPlayer}, введите номер ячейки:");


                    validInput = int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 9 && board[choice - 1] != 'X' && board[choice - 1] != 'O';

                    if (validInput)
                    {

                        board[choice - 1] = (currentPlayer == 1) ? 'X' : 'O';


                        if (CheckForWin())
                        {
                            Console.Clear();
                            DrawBoard();
                            Console.WriteLine($"Победил игрок {currentPlayer}!");
                            break;
                        }


                        if (CheckForDraw())
                        {
                            Console.Clear();
                            DrawBoard();
                            Console.WriteLine("Ничья!");
                            break;
                        }


                        currentPlayer = (currentPlayer == 1) ? 2 : 1;
                    }
                    else
                        Console.WriteLine("Некорректный ввод. Попробуйте снова.");

                } while (true);
            }


            static void DrawBoard()
            {
                Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
                Console.WriteLine("-----------");
                Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
                Console.WriteLine("-----------");
                Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
            }


            static bool CheckForWin()
            {
                return (board[0] == board[1] && board[1] == board[2]) ||
                    (board[3] == board[4] && board[4] == board[5]) ||
                    (board[6] == board[7] && board[7] == board[8]) ||
                    (board[0] == board[3] && board[3] == board[6]) ||
                    (board[1] == board[4] && board[4] == board[7]) ||
                    (board[2] == board[5] && board[5] == board[8]) ||
                    (board[0] == board[4] && board[4] == board[8]) ||
                    (board[2] == board[4] && board[4] == board[6]);
            }


            static bool CheckForDraw()
            {

                foreach (char cell in board)
                {
                    if (cell != 'X' && cell != 'O')
                        return false;
                }
                return true;
            }
    }
}
