// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");





bool isWork = true;

while (isWork)
{
    string command = Console.ReadLine();

    switch (command)
    {
        case "lekcii11": Lekcii11(); break;
        case "lekcii12": Lekcii12(); break;
        case "lekcii13": Lekcii13(); break;
        case "lekcii14": Lekcii14(); break;
        case "exit": isWork = false; break;
    }
}



void Lekcii11()
{
    Console.WriteLine("Введите ваше имя");  //предлагает ввести имя в консоль
    string username = Console.ReadLine();  //Создали строку с "коробочкой" username,
                                           //куда считывается(складывается) то, что вводится в Консоли
    Console.WriteLine("Привет, ");   //выводит из "коробочки" то,
    Console.WriteLine(username);      //что туда ввели выше
}

void Lekcii12()
{
    int numberA = 3; //вводим переменную А (int-целое число)
    int numberB = 5;
    //Console.WriteLine(numberA+ numberB); //выводим их сумму
    int result = numberA + numberB;
    Console.WriteLine(result);
}

void Lekcii13()
{
    double numberA = 12; //вводим переменную А (double - число с запятыми)
    double numberB = 5;
    double result = numberA / numberB; 
    Console.WriteLine(result); //выводим результат деления в консоль
}

void Lekcii14()
{
    int numberA = new Random() .Next(1 ,10); //вводим случайное число от 1 до 9
    Console.WriteLine(numberA);              //видим какое число
    int numberB = new Random() .Next(1 ,10);
    Console.WriteLine(numberB);
    int result = numberA + numberB;
    Console.WriteLine(result); //выводим результат  в консоль
}





