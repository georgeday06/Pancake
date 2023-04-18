Console.WriteLine("How many pancakes are you looking to make?");
int pancake = Convert.ToInt32(Console.ReadLine());

int number = 4 + (pancake + pancake % 2);
Console.WriteLine(number);

