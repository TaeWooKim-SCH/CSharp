namespace CSharp
{
    // OOP(은닉성/상속성/다형성)
    // 다형성
    // 오버라이딩: 어떤 함수에 실제 타입에 따라 다양한 형태로 동작하도록 하는 것
    
    class Player {
        protected int hp;
        protected int attack;

        public virtual void Move() {
            Console.WriteLine("Player 이동!");
        }
    }

    class Knight: Player {
        public sealed void Move() { // sealed: 나까지만 건드릴 수 있고 이후 자식들은 오버라이딩 불가능
            base.Move();
            Console.WriteLine("Knight 이동!");
        }
    }

    class Mage: Player {
        public int mp;

        public override void Move() {
            Console.WriteLine("Mage 이동!");
        }
    }

    class SuperKnight: Knight {
        public override void Move() {
            Console.WriteLine("SuperKnight 이동!");
        }
    }

    internal class Program {
        static void EnterGame(Player player) {
            player.Move();
            Mage mage = (player as Mage);
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
            knight.Move();
            EnterGame(mage);
        }
    }
}
