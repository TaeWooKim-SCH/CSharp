namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 자료형
            // int, float, string, bool 등

            // 변수
            // [데이터 타입] [이름];
            // int hp;

            // [이름] = ?;
            // hp = 100;
            int hp = 100;
            int maxHp;
            maxHp = hp;

            // string -> int
            // int -> string
            string input;
            //input = Console.ReadLine();
            // Console.WriteLine(input);
            // int number = int.Parse(input);
            // Console.WriteLine(number);

            // 당신의 HP는 100입니다.
            // string message = string.Format("당신의 HP는 {0}/{1} 입니다", hp, maxHp);
             string message = $"당신의 HP는 {hp} / {maxHp} 입니다";
             Console.WriteLine(message);
            Console.WriteLine("hp" + hp);
            Console.WriteLine("max hp" + maxHp);
            
            // 산술 연산
            int value = 5;
            hp -= value;
            Console.WriteLine(hp);

            // < <= > >= == !=

            // 조건문
            bool isDead = (hp <= 0);
            
            if (isDead) {
                Console.WriteLine("You are dead!");
            } else {
                Console.WriteLine("You are alive");
            }

            int choice = 0; // 0: 가위 1: 바위 2: 보
            if (choice == 0) {
                Console.WriteLine("가위입니다.");
            } else if (choice == 1) {
                Console.WriteLine("바위입니다.");
            } else if (choice == 2) {
                Console.WriteLine("보입니다.");
            } else {
                Console.WriteLine("치트키입니다.");
            }

            switch (choice) {
                case 0:
                    Console.WriteLine("가위입니다.");
                    break;
                case 1:
                    Console.WriteLine("바위입니다.");
                    break;
                case 2:
                    Console.WriteLine("보입니다.");
                    break;
                case 3:
                    Console.WriteLine("치트키입니다.");
                    break;
                default:
                    Console.WriteLine("다 실패했습니다.");
                    break;
            }
        }
    }
}
