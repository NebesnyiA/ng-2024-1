
int a = 5;

object o = a; //boxing
int unboxedValue = (int)o; //unboxing

Dog dog1 = new Dog("Ben");
dog1.MakeHello();

int num = 1;
float num2 = 1.2f;
double num3 = 1.23d;
decimal num4 = 123.123m;

char symbol = 'A';
string str = "Hello World";

Console.WriteLine(str, num, num4, num2, num3, symbol);
public class Animal
{
	//field of this class
	public string Name { get; set; }

	public Animal(string name)
	{
		Name = name;
	}

	public virtual void MakeHello()
	{
		Console.WriteLine("sound");
	}
}

public class Dog : Animal
{
	public Dog(string name) : base(name) { }

	public override void MakeHello()
	{
		Console.WriteLine("Raf");
	}
}


