# 2-2-static-
C# （构造函数的结构是public + 函数名，中间不需要加入返回值，构造函数有几种方式1.默认构造函数2.只有两个参数的构造函数。访问控制关键词这边。改为private以后就不能使用过程式的编程方式，采用的应该是c1.CostHp(cost);这样的方式。除此以外关于不能访问Hp的问题，可以抽象一个函数叫做是否死亡，class里面可以使用到Hp，这样用bool的方式判断即可，即如果IsBool为True那么就意味着hp&lt;=0。除此以外打印血量的时候除了可以使用在上面抽象出函数的方式，还可以用一种特殊的方式，即OverrideToString的方式，Main函数中的 Console.WriteLine($"{c2}");会主动到上方去寻找ToString的转化。）