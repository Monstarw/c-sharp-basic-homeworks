/*
2．在控制台或页面输出九九乘法表。
*/

using System;

class cs3_02{
	public static void Main(){
		int i, j;
		for(i = 1; i <= 9; i++){
			for(j = 1; j <= i; j++){
				Console.Write("{0}*{1}={2}\t", j, i, i * j);
			}
			Console.Write("\n");
		}
	}
}