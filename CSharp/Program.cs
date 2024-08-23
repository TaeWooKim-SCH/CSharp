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
        }
    }
}
