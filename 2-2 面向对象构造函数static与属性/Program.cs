using System;

namespace _2_2_面向对象构造函数static与属性
{
    /* 访问控制关键词
     * public 公开的，类定义内外均可使用
     * private 私有的，类定义外无法使用。如果不写，默认是private
     * protected 受保护的，类似私有，等学到“继承”的概念的时深究
     */

    /* 对public和private的说明
     * public的字段，可以在类之外读取或修改
     * public的方法，可以在类之外调用
     * private的方法和字段，在类的外面均不可使用（从外面看不到）
     * 私有字段用private修饰，然后配合public的方法使用，是比较推荐的做法
     */
    class Character
    {
        public string name;
        public int attack;
        public int def;

        private int hp;  // 在class定义的内部是随便改的，出了class不能访问了

        // 默认构造函数
        public Character()
        { name = "未知名字"; }

        // 构造函数
        public Character(string name, int hp, int attack, int def)
        {
            this.name = name;
            this.hp = hp;
            this.attack = attack;
            this.def = def;
        }

        // 只有两个参数的构造函数
        public Character(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
            this.attack = 1;
            this.def = 0;
        }

        // 在类里面写一个扣血的函数
        public void CostHp(int cost)
        {
            this.hp -= cost;
            if (this.hp <= 0)
            { this.hp = 0; }
        }
        public bool IsDead()
        {
            return hp <= 0;
        }

        public override string ToString()
        {
            return $"角色： {name} HP:{hp} 攻击力{attack}   防御力： {def}";  // 这里main函数中 Console.WriteLine($"{c2}");会去主动寻找字符串转化
        }
    }

    class Program
    {
        //static void CostHp(Character c ,int cost)
        //{
        //    c.hp -= cost;
        //    if (c.hp <= 0)
        //    { c.hp = 0; }
        //}
        static void Main(string[] args)
        {
            // 创建对象并初始化
            Character c1 = new Character("汤姆", 100, 15, 1);

            Character c2 = new Character("杰瑞", 10, 150, 10);

            Character c3 = new Character();

            Character c4 = new Character("赛维", 23);

            // 战斗过程
            while (!c1.IsDead() && !c2.IsDead())
            {
                int cost = c1.attack - c2.def;
                c2.CostHp(cost);


                Console.WriteLine($"{c1.name}攻击了{c2.name},{c2.name}损失了{cost}血量");
                Console.WriteLine($"{c2}");
                //Console.WriteLine($"{c2.ToString()}"); 这种方式和上面是一样的，属于累赘式的写法

                if (c2.IsDead())
                { break; }

                cost = c2.attack - c1.def;
                c1.CostHp(cost);

                Console.WriteLine($"{c2.name}攻击了{c1.name},{c1.name}损失了{cost}血量");
                Console.WriteLine($"{c1}");
            }

            // 判断胜负
            if (c1.IsDead())
            { Console.WriteLine($"------{c2.name}胜利！------"); }
            else
            { Console.WriteLine($"------{c1.name}胜利！------"); }
            Console.ReadKey();
        }
    }
}
