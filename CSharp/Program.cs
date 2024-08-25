namespace CSharp
{
    internal class Program
    {
        // Method 함수
        // 한정자 반환형식 이름(매개변수목록) { }
        static void HelloWord() {
            Console.WriteLine("Hello World");
        }
        
        // 덧셈 함수
        static int Add(int a, int b) {
            Console.WriteLine("int 호출!!");
            return a + b;
        }

        // 메소드 오버로딩 -> 함수 이름의 재사용 -> 매개변수 타입 또는 개수가 변경되어야 함
        static float Add(float a, float b) {
            Console.WriteLine("float 호출!!");
            return a + b;
        }

        // 참조형 매개변수 함수 -> AddOne(ref 매개변수)
        static void AddOne(ref int number) {
            number += 1;
        }

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
            //string message = $"당신의 HP는 {hp} / {maxHp} 입니다";
            //Console.WriteLine(message);
            //Console.WriteLine("hp" + hp);
            //Console.WriteLine("max hp" + maxHp);

            //// 산술 연산
            //int value = 5;
            //hp -= value;
            //Console.WriteLine(hp);

            //// < <= > >= == !=

            //// 조건문
            //bool isDead = (hp <= 0);

            //if (isDead) {
            //    Console.WriteLine("You are dead!");
            //} else {
            //    Console.WriteLine("You are alive");
            //}

            //const int SCISSORS = 0;
            //const int ROCK = 1;
            //const int PAPER = 2;

            //Random rand = new Random();
            //int aiChoice = rand.Next(0, 3); // 0~2 사이의 랜덤 값
            //int choice = Convert.ToInt32(Console.ReadLine());

            //switch (choice) {
            //    case (int)Choice.Scissors:
            //        Console.WriteLine("당신의 선택은 가위입니다.");
            //        break;
            //    case (int)Choice.Rock:
            //        Console.WriteLine("당신의 선택은 바위입니다.");
            //        break;
            //    case (int)Choice.Paper:                                         
            //        Console.WriteLine("당신의 선택은 보입니다.");
            //        break;
            //}
            //switch (aiChoice) {
            //    case SCISSORS:
            //        Console.WriteLine("컴퓨터의 선택은 가위입니다.");
            //        break;
            //    case ROCK:
            //        Console.WriteLine("컴퓨터의 선택은 바위입니다.");
            //        break;
            //    case PAPER:                                         
            //        Console.WriteLine("컴퓨터의 선택은 보입니다.");
            //        break;
            //}

            //// 승리 무승부 패배
            //if (choice == aiChoice) {
            //    Console.WriteLine("무승부입니다.");
            //} else if (choice == SCISSORS && aiChoice == PAPER) {
            //    Console.WriteLine("승리입니다.");
            //} else if (choice == ROCK && aiChoice == SCISSORS) {
            //    Console.WriteLine("승리입니다.");
            //} else if (choice == PAPER && aiChoice == ROCK) {
            //    Console.WriteLine("승리입니다.");
            //} else {
            //    Console.WriteLine("패배입니다.");
            //}

            //// while
            //int count = 0;
            //while (count < 5) {
            //    Console.WriteLine("Hello World [while]");
            //    count++;
            //}

            //// for (초기화식;조건식;반복식)
            //for (int i = 0; i < 5; i++) {
            //    Console.WriteLine("Hello World [for]");
            //}

            int result = Program.Add(4, 5);
            Console.WriteLine(result);

            int a = 0;
            Program.AddOne(ref a);
            Console.WriteLine(a);

            int ret1 = Program.Add(2, 3);
            Console.WriteLine(ret1);
            float ret2 = Program.Add(2.2f, 3.2f);
            Console.WriteLine(ret2);
        }
    }
}
