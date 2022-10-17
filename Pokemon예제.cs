using System;
using System.Collections.Generic;

namespace Pokemon_예제
{
    class Trainner
    {
        List<string> Pokemons = new List<string>();

        public void Catch(string a)
        {
            Pokemons.Add(a);
        }

        public void Throw()
        {

        }
    }

    class Pokemon
    {
        private int Atk;
        private int HP;
        private string Name;

        public void Attack()
        {

        }

        public void Death()
        {

        }

        public void Display()
        {

        }

        List<string> Pokemons = new List<string>();
    }
    class Pokemon예제
    {
        Trainner Player = new Trainner();
        static void Main(string[] args)
        {
            StartMain();
        }

        static void StartMain()
        {
            string strMain;
            Console.WriteLine("가져갈 포켓몬을 선택하세요. 피카츄, 파이리, 꼬부기 :");
            strMain = Console.ReadLine();

            switch(strMain)
            {
                case "피카츄":
                    Console.WriteLine(strMain + "를 선택하셨습니다.");
                    break;
                case "파이리":
                    Console.WriteLine(strMain + "를 선택하셨습니다.");
                    break;
                case "꼬부기":
                    Console.WriteLine(strMain + "를 선택하셨습니다.");
                    break;
                default:
                    Console.WriteLine("잘못 선택하셨습니다.");
                    break;
            }
        }
    }
}
