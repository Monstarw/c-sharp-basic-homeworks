/*
1．编写一个函数，用于计算1！+2！+3！+4！+5！，在控制台或页面输出运行结果。
*/

using System;

class cs3_01{
	public static void Main(){
		int i, j, product, sum = 0;
		for (i = 1; i <= 5; i++){
			product = 1;
			for (j = 1; j <= i; j++){
				product = product * j;
			}
			sum = sum + product;
		}
		Console.WriteLine("{0}", sum);
	}
}
