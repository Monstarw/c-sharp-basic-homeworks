/*
5．定义一个汽车类，该类具有重量和速度属性；再定义一个跑车类，该类继承汽车类的属性，并拥有自己的颜色属性；然后声明一个汽车类的对象和一个跑车类的对象，并把它们的属性输出到控制台上。
*/

using System;

class Car{
	public double weight, speed;
	public Car(double w, double s){
		this.weight = w;
		this.speed = s;
	}
}

class RacingCar: Car{
	public string color;
	public RacingCar(double w, double s, string c): base(w, s){
		this.color = c;
	}
}

class cs3_05{
	public static void Main(){
		Car car_1 = new Car(2000, 60);
		RacingCar racing_car_1 = new RacingCar(1500, 120, "红");
		Console.WriteLine("汽车的重量为{0} kg，速度为{1} km/s", car_1.weight, car_1.speed);
		Console.WriteLine("跑车的质量为{0} kg，速度为{1} km/s，颜色为{2}色", racing_car_1.weight, racing_car_1.speed, racing_car_1.color);
	}
}