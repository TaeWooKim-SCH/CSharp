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

    // Copy 복사
    struct Mage {
        public int hp;
        public int attack;
    }
    internal class Program {
        static void KillMage(Mage mage) {
            mage.hp = 0;
        }

        static void KillKnight(Knight knight) {
            knight.hp = 0;
        }

        static void Main(string[] args) {
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;
            KillMage(mage); // hp = 100

            Mage mage2 = mage;
            mage2.hp = 0;

            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;

            Knight knight2 = knight.Clone();
            knight2.hp = 0;
        }
    }
}
