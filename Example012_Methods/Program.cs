// Вид 1

void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();  //Так вызывается метод. Обязательно со скобками!

// Вид 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения"); 

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4); // Method2(msg: "Текст", count: 4); 

// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4

string Method4 (int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "Z");
Console.WriteLine(res);


// Цикл for

string Method5 (int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res1 = Method5(10, "Z");
Console.WriteLine(res1);


// Цикл в цикле (Таблица умножения)

for (int i = 2; i < 10; i++)
{
    for (int j =1; j < 10; j++)
    {
        Console.Write(i*j + " "); // Console.WriteLine($"{i} x {j} = {i * j}"); - интерполяция строк
    }
    Console.WriteLine();
}