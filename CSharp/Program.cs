namespace CSharp
{
    // 객체 (OOP Object Oriented Programming)

    // Knight
    // 속성: hp, attack, pos
    // 기능: Move, Attack, Die

    // Ref 참조
    class Knight {
        static public int counter; // 오로지 1개만 존재! -> 각 다른 객체들이 모두 공유해서 하나만 사용한다!

        public int id;
        public int hp; // public이 없으면 해당 클래스 내부에서만 사용한다는 의미
        public int attack;

        static public void Test() {
            counter++;
        }

        static public Knight CreateKnight() {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }

        public Knight () {
            id = counter;
            counter++;

            hp = 100;
            attack = 0;
            Console.WriteLine("생성자 호출");
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
