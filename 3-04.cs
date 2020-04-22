/*
4．计算两个数的商，在控制台或页面输出结果，要求包含异常处理。
*/

using System;

class cs3_04{
	public static void Main(){
		decimal dividend, divisor, quotient;
		try{
			Console.Write("请输入被除数：");
			dividend = Decimal.Parse(Console.ReadLine());
			Console.Write("请输入除数：");
			divisor = Decimal.Parse(Console.ReadLine());
			quotient = dividend / divisor;
			Console.WriteLine("商为 {0}", quotient);
		}catch(FormatException){
			Console.WriteLine("你自己看看你输的啥玩意儿 那是数吗");
		}catch(OverflowException){
			Console.WriteLine("。咱能输点儿阳间的数么");
			Console.WriteLine("（指绝对值不超过79228162514264337593543950335）");
		}catch(DivideByZeroException){
			Console.WriteLine("商为 无穷大");
			Console.WriteLine("逗你玩儿呢 除数不能为0啊大哥");
		}
	}
}