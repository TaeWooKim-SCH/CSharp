namespace CSharp
{
    // OOP(은닉성/상속성/다형성)
    // 자동차
    // 핸들 페달 차문
        // 전기장치 엔진 기름 <-> 외부 노출

    class Knight {
        // 접근 한정자(default = private)
        // public protected private
        // public: 모두 접근 가능
        // private: 해당 클래스 내에서만 접근 가능
        // protected: 상속을 받은 클래스는 접근 가능
        protected int hp;
        
    }

    class SuperKnight: Knight {
        void Test() {
            hp = 10;
        }
    }
    
    internal class Program {

        static void Main(string[] args) {
            Knight knight = new Knight();
            // knight.hp = 10; -> 접근 불가
        }
    }
}
