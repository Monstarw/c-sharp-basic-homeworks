/*
6．假设某动物园管理员每天需要给他所负责饲养的狮子、猴子和鸽子喂食。请用一个程序来模拟他喂食的过程。
要求：
（1）饲养员喂食时，不同动物执行不同的吃的功能，例如狮子吃肉、猴子吃香蕉、鸽子吃大米等。
（2）饲养员喂动物时，不能使用判断语句判断动物类型。
（3）使用虚方法或抽象方法实现喂养不同动物的多态，不能使用方法重载。 
提示：需要建一个动物类，动物类有一个虚的或抽象的吃方法，动物类下面有几个子类，不同的子类重写父类的吃方法。饲养员类提供喂食方法。然后，在Main方法中一一调用吃的方法。
*/

using System;

abstract class Animal{
	public abstract void Eat();
}

class Lion: Animal{
	public override void Eat(){
		Console.WriteLine("狮子吃肉");
	}
}

class Monkey: Animal{
	public override void Eat(){
		Console.WriteLine("猴子吃香蕉");
	}
}

class Pigeon: Animal{
	public override void Eat(){
		Console.WriteLine("鸽子吃大米");
	}
}

class Breeder{
	public void Feed(Animal animal){
		animal.Eat();
	}
}

class cs3_06{
	public static void Main(){
		Breeder breeder = new Breeder();
		Lion lion = new Lion();
		Monkey monkey = new Monkey();
		Pigeon pigeon = new Pigeon();
		breeder.Feed(lion);
		breeder.Feed(monkey);
		breeder.Feed(pigeon);
		/*
		“然后，在Main方法中一一调用吃的方法。”？
		“吃的方法”→喂的方法
		*/
	}
}