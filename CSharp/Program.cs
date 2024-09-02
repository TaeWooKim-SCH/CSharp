namespace CSharp
{
    // 객체 (OOP Object Oriented Programming)

    // Knight
    // 속성: hp, attack, pos
    // 기능: Move, Attack, Die

    // Ref 참조
    class Knight {
        public int hp; // public이 없으면 해당 클래스 내부에서만 사용한다는 의미
        public int attack;

        public Knight () {
            hp = 100;
            attack = 0;
            Console.WriteLine("생성자 호출");
        }

        public Knight(int hp): this() {
            this.hp = hp;
            Console.WriteLine("int 생성자 호출!");
        }

        public Knight(int hp, int attack) {
            this.hp = hp;
            this.attack = attack;
            Console.WriteLine("int, int 생성자 호출!");
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
            Knight knight = new Knight(50, 5);
            
        }
    }
}
