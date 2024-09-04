namespace CSharp
{
    // OOP(은닉성/상속성/다형성)
    
    class Player {
        protected int hp;
        protected int attack;
    }

    class Knight: Player {

    }

    class Mage: Player {
        public int mp;
    }

    internal class Program {
        static void EnterGame(Player player) {
            Mage mage = player as Mage;
            if (mage != null) {
                mage.mp = 10;
                Console.WriteLine("mp 변경됨");
                return;
            } else {
                Console.WriteLine("끝");
                return;
            }
        }
        static void Main(string[] args) {
            Knight knight = new Knight();
            Mage mage = new Mage();

            EnterGame(mage);
        }
    }
}
