/*
 * A feladat a github-on olvasható!
 */

using System;

namespace WarriorProject
{
    class Position
    {
        private int _x; private int _y;
        public Position(int x, int y)
        {
            _x = x;
            _y = y;

        }
        public int X { get => _x; }
        public int Y { get => _y; }

        public void ToConsole()
        {
            Console.WriteLine($"{X} x, {Y}y");
        }
    }
        class Warrior
        {
            private string _name;
            private Position _position;
            private int _x;
            private int _y;
            public Warrior(string name, Position position)
            {

                _name = name;
                _position = position;
                _x = position.X;
                _y = position.Y;

            }
            public void MoveHorizontal(int x)
            {
                _x += x;
            }
            public void MoveVertical(int y)
            {
               _y += y;
            }
            public void ToConsole()
            {
                Console.WriteLine($"{_name}, position({_x},{_y})");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Position position = new Position(2, -1);
                position.ToConsole();
                Warrior warrior = new Warrior("Peter the Iron Man", position);
                warrior.ToConsole();
                warrior.MoveHorizontal(3);
                warrior.MoveVertical(-2);
                warrior.ToConsole();
            }
        }
    }

