using System;
using System.Collections.Generic;

namespace Pokemon_예제
{
    class Trainner
    {
        List<Pokemon> pokemons = new List<Pokemon>();

        public void Catch(Pokemon a)
        {
            pokemons.Add(a);
        }

        public void PokemonCheck()
        {
            Console.WriteLine("#############################");
            Console.WriteLine("선택하신 포켓몬의 정보입니다.");
            for(int i = 0; i < pokemons.Count; i++)
            {
                Console.Write("이름:");
                Console.WriteLine(pokemons[i].name);
                Console.Write("체력:");
                Console.WriteLine(pokemons[i].hp);
                Console.Write("공격력:");
                Console.WriteLine(pokemons[i].atk);
            }
            Console.WriteLine("#############################");
        }

        public void Throw()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("가지고 계신 포켓몬의 리스트입니다.");
            for (int i = 0; i < pokemons.Count; i++)
            {
                Console.WriteLine("################");
                Console.Write("이름:");
                Console.WriteLine(pokemons[i].name);
                Console.Write("체력:");
                Console.WriteLine(pokemons[i].hp);
                Console.Write("공격력:");
                Console.WriteLine(pokemons[i].atk);
                Console.WriteLine("################");
            }
        }
    }

    class Pokemon
    {
        public int atk;
        public int hp;
        public string name;

        public void Attack()
        {

        }

        public void Death()
        {

        }

        public void Display()
        {

        }

        public Pokemon(string _name, int _atk,int _hp)
        {
            name = _name;
            hp = _hp;
            atk = _atk;
        }

        public Pokemon()
        {

        }
    }
    class Pokemon예제
    {
        static Trainner Player = new Trainner();
        static Pokemon Monster = new Pokemon();
        static void Main(string[] args)
        {
            StartMain();
            Console.WriteLine();
            Player.PokemonCheck();
            Console.WriteLine();
            Console.WriteLine("모험이 시작됐다!");
            Console.WriteLine();
            StageChoose();
            Console.WriteLine();
        }
            
        static void StartMain()
        {
            string strMain;
            Console.WriteLine("가져갈 포켓몬을 선택하세요. 피카츄, 파이리, 꼬부기 :");
            strMain = Console.ReadLine();

            switch (strMain)
            {
                case "피카츄":
                    Console.WriteLine(strMain + "를 얻었다!");
                    Player.Catch(new Pokemon(strMain, 10, 100));
                    break;
                case "파이리":
                    Console.WriteLine(strMain + "를 얻었다!");
                    Player.Catch(new Pokemon(strMain, 10, 100));
                    break;
                case "꼬부기":
                    Console.WriteLine(strMain + "를 얻었다!");
                    Player.Catch(new Pokemon(strMain, 10, 100));
                    break;
                default:
                    Console.WriteLine("잘못 선택하셨습니다.");
                    StartMain();
                    break;
            }
        }

        static void StageChoose()
        {
            string strStage;
            Console.WriteLine("세갈래길이다. 어디로 갈까? 왼쪽, 오른쪽, 가운데");
            strStage = Console.ReadLine();

            switch(strStage)
            {
                case "왼쪽":
                    Console.WriteLine(strStage + "를 선택하셨습니다.");
                    break;
                case "오른쪽":
                    Console.WriteLine(strStage + "를 선택하셨습니다.");
                    break;
                case "가운데":
                    Console.WriteLine(strStage + "를 선택하셨습니다.");
                    break;
                default:
                    Console.WriteLine("잘못 선택하셨습니다.");
                    StageChoose();
                    break;
            }
        }

        static void RandomSpawnMain()
        {
            Random aRandom = new Random();
            int a = aRandom.Next(1,4);
            if(a == 1 || a == 2)
            {
                Random bRandom = new Random();
                int b = bRandom.Next(1, Monster.)
            }

        }

        static void BattleMain()
        {
            
        }
    }
}