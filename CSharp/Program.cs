namespace CSharp
{
    // 객체 (OOP Object Oriented Programming)
    // - 은닉성, 상속성, 다형성
    class Player { // 부모 / 기반 클래스
        // 필드
        static public int counter = 1; // 오로지 1개만 존재!
        public int id;
        public int hp;
        public int attack;

        public Player() {
            Console.WriteLine("Player 생성자 호출!");
        }

        public Player(int hp) {
            this.hp = hp;
            Console.WriteLine("Player hp 생성자 호출!");
        }
    }

    class Mage: Player { // 자식 / 파생

    }

    class Archer: Player {

    }

    // Ref 참조
    class Knight: Player {
        int c;

        public Knight(): base(100) {
            Console.WriteLine("Knight 생성자 호출");
        }

        static public Knight CreateKnight() {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }

        public Knight Clone() {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }

        public void Move() {
            Console.WriteLine("Knight Move");
        }
        public void Attack() {
            Console.WriteLine("Knight Attack");
        }
    }

    internal class Program {

        static void Main(string[] args) {
            Knight knight = Knight.CreateKnight(); // static
            knight.Move(); // 일반

            Console.WriteLine();

            Random rand = new Random();
            rand.Next(0, 2);
        }
    }
}
