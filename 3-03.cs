/*
3．输入10个以内的整数，输出该组整数的降序排列，要求采用数组实现。
*/

using System;

class cs3_03{
	public static void Main(){
		bool input_overflow;
		string[] input_split;
		do{
			string input_str = Console.ReadLine();
			input_split = input_str.Split(' ');
			input_overflow = input_split.Length >= 10;
			if(input_overflow){
				Console.WriteLine("输入整数的个数超过10个的上限，请重新输入");
			}
		}while(input_overflow);
		int[] nums_array = new int[input_split.Length];
		for(int i = 0; i < input_split.Length; i++){
			if(!Int32.TryParse(input_split[i], out nums_array[i])){
				Console.WriteLine("输入出错");
				return;
			}
		}
		Array.Sort(nums_array);
		Array.Reverse(nums_array);
		Console.Write(string.Join(" ", nums_array));
	}
}