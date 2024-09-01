namespace CSharp
{
    // 객체 (OOP Object Oriented Programming)

    // Knight
    // 속성: hp, attack, pos
    // 기능: Move, Attack, Die
    class Knight {
        public int hp; // public이 없으면 해당 클래스 내부에서만 사용한다는 의미
        public int attack;

        public void Move() {
            Console.WriteLine("Knight Move");
        }
        public void Attack() {
            Console.WriteLine("Knight Attack");
        }
    }
    internal class Program {
        static void Main(string[] args) {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;

            knight.Move();
            knight.Attack();
        }
    }
}
