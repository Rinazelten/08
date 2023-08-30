// Вид 1
void Method1()
{
    System.Console.WriteLine("Автор Екатерина");
}
//Method1();










//Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method21(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg:"Текст", count: 3);
//Method21(count:3 , msg:"новый текст");



// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);


//Вид 4
string Method4(int count ,string c)
{
    string result = String.Empty;
for (int i = 0; i < count; i++);
    {
        result = result + c;
    }
    return result;
}

string res = Method4(10, "pig");
//Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
}


//=====Работа с текстом
// Дан текст. в тексте все пробел нужно заменить черточками
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

//string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
  //  + "ежели бы вас послали вместо нашего милого Винценгероде, "
   // + "вы бы взяли приступом согласие прусского короля. "
    //+ "Вы так красноречивы. Вы дадите мне чаю?";

    // string s = "qwerty"
    //             012
    // s[3] // r

 /*string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Lenght;
    for (int i = 0; i < lenght; i++)
    {
        if (text [i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text [i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
//Console.WriteLine(newText);

//Задача  24 Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А

/*int res = GetSumFrom1ToN(10);
Console.WriteLine(res);

int res = GetSumFrom1ToN(int a)
{
    int result = 0
    int count = 0
    
    while (count <= a);
    {
        result += count;
        count++;
    }

    return result;
}

*/
//Задача 26 напишите программу, которая принимает на вход число и выдает количество цифр в числе

Console.WriteLine(GetLenghtNum(12966));
int GetLenghtNum(int num)
{
    int lenght = default;

    while (num > 0)
    {
        lenght ++;
        num /= 10;
    }
    
    return lenght;
}

//Напишите программу которая выводит массив из 8 элементов , заполненный нулями и единицами в случайном порядке.




