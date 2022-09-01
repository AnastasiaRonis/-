Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if(a>max) 
{
    max=a;
}
else if(b>max) 
{
    max=b;
}
else if(c>max) 
{
    max=c;
}

Console.WriteLine(max);

