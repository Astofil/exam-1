var minimum=new Minimum();

minimum.a=Convert.ToInt32(Console.ReadLine());
minimum.b=Convert.ToInt32(Console.ReadLine());
minimum.c=Convert.ToInt32(Console.ReadLine());
minimum.d=Convert.ToInt32(Console.ReadLine());

var MIN=minimum.FindMinimum();
Console.WriteLine(MIN);