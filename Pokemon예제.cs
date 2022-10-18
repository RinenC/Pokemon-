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
            Console.WriteLine("가지고 있는 포켓몬의 정보입니다.");
            for (int i = 0; i < pokemons.Count; i++)
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

        public Pokemon Throw(int idx)
        {
            return pokemons[idx];
        }

        public Pokemon Throw(string name)
        {
            return pokemons.Find(pokemons => pokemons.name == name);
        }
    }

    class Pokemon
    {
        public int atk;
        public int hp;
        public string name;

        public void Attack(Pokemon target)
        {
            target.hp = target.hp - this.atk;
        }

        public bool Death()
        {
            if (hp > 0)
                return false;
            else
                return true;
        }

        public void Display(string msg)
        {
            Console.WriteLine("##### " + msg + " #######");
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Demage:" + atk);
            Console.WriteLine("HP:" + hp);
            Console.WriteLine("###################");
        }

        public Pokemon(string _name, int _atk, int _hp)
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
            Console.WriteLine("스테이지를 선택하세요. 숲, 바다");
            strStage = Console.ReadLine();

            switch (strStage)
            {
                case "숲":
                    Console.WriteLine(strStage + "를 선택하셨습니다.");
                    ForestRandomSpawnMain();
                    break;
                case "바다":
                    Console.WriteLine(strStage + "를 선택하셨습니다.");
                    BeachRandomSpawnMain();
                    break;
                default:
                    Console.WriteLine("잘못 선택하셨습니다.");
                    StageChoose();
                    break;
            }
        }

        static void ForestRandomSpawnMain()
        {
            Console.WriteLine();
            Console.WriteLine("숲에 도착했다.");
            Console.WriteLine();
            List<Pokemon> Monster = new List<Pokemon>();
            Monster.Add(new Pokemon("우츠보트", 10, 100));
            Monster.Add(new Pokemon("피존", 10, 100));

            Random aRandom = new Random();
            int a = aRandom.Next(0, 2);
            if (a == 0)
            {
                Random bRandom = new Random();
                int b = bRandom.Next(0, Monster.Count);
                Console.WriteLine("야생 포켓몬이 나타났다!");
                Console.WriteLine();
                Pokemon sMonster = Monster[b];
                sMonster.Display(sMonster.name);
                Console.WriteLine();
                Console.WriteLine("배틀!");
                Console.WriteLine();
                Console.WriteLine("배틀에 내보낼 포켓몬을 선택해주세요.");
                Console.WriteLine();
                Player.PokemonCheck();
                Console.WriteLine();
                int throwpokemon;
                throwpokemon = int.Parse(Console.ReadLine());
                Console.WriteLine(throwpokemon);
                Pokemon myPokemon = Player.Throw(throwpokemon);
                BattleMain(myPokemon, sMonster);
            }
            else
            {
                Console.WriteLine("몬스터가 나타나지 않았습니다.");
                StageChoose();
            }
        }

        static void BeachRandomSpawnMain()
        {
            Console.WriteLine();
            Console.WriteLine("바다에 도착했다.");
            Console.WriteLine();
            List<Pokemon> Monster = new List<Pokemon>();
            Monster.Add(new Pokemon("잉어킹", 10, 100));
            Monster.Add(new Pokemon("모래두지", 10, 100));

            Random aRandom = new Random();
            int a = aRandom.Next(0, 2);
            if (a == 0)
            {
                Random bRandom = new Random();
                int b = bRandom.Next(0, Monster.Count);
                Console.WriteLine("야생 포켓몬이 나타났다!");
                Console.WriteLine();
                Pokemon sMonster = Monster[b];
                sMonster.Display(sMonster.name);
                Console.WriteLine();
                Console.WriteLine("배틀!");
                Console.WriteLine();
                Console.WriteLine("배틀에 내보낼 포켓몬을 선택해주세요.");
                Console.WriteLine();
                int throwpokemon;
                throwpokemon = int.Parse(Console.ReadLine());
                Console.WriteLine(throwpokemon);
                Pokemon myPokemon = Player.Throw(throwpokemon);
                BattleMain(myPokemon, sMonster);
            }
            else
            {
                Console.WriteLine("몬스터가 나타나지 않았습니다.");
                StageChoose();
            }
        }

        static void BattleMain(Pokemon myPokemon, Pokemon wildPokemon)
        {
            while (true)
            {
                if(myPokemon.Death() == false)
                {
                    myPokemon.Attack(wildPokemon);
                    wildPokemon.Display(myPokemon.name + "의 공격!");
                }
                else
                {
                    Console.WriteLine(wildPokemon.name + "Win!");
                    break;
                }
                if(wildPokemon.Death() == false)
                {
                    wildPokemon.Attack(myPokemon);
                    myPokemon.Display(wildPokemon.name + "의 공격!");
                }
                else
                {
                    Console.WriteLine(myPokemon.name + "Win!");
                    break;
                }
            }
        }
    }
}
