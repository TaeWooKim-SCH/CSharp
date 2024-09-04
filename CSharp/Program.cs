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

        public void Move() {
            Console.WriteLine("Player Move");
        }
        public void Attack() {
            Console.WriteLine("Player Attack");
        }
    }

    class Mage: Player { // 자식 / 파생

    }

    class Archer: Player {

    }

    // Ref 참조
    class Knight: Player {
        public void Stun() {

        }
    }

    internal class Program {

        static void Main(string[] args) {
            Knight knight = new Knight(); // static
            knight.Move();
        }
    }
}
