double a=0, b=0, otvet;
int vibor, viborF;
bool flag = false; 

while (true)
{
    if (flag == true)
    {
        Console.WriteLine("Хотите поменять переменные? \n Где 1-это да, а 2-это нет \n Ваш выбор? ");
        viborF = Convert.ToInt32(Console.ReadLine());
        switch (viborF)
        {
            case 1:
                flag = false;
                break;
            case 2:
                break;
        }
    }
    if (flag == false)
    {
        Console.WriteLine("Введите 1 переменную a= ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите 2 переменную b= ");
        b = Convert.ToDouble(Console.ReadLine());
        flag = true;
    }
    Console.WriteLine("Выбирите операцию \n 1-Сложение + \n 2-Вычитание - \n 3-Умножение * \n 4-Деление / \n 5-Выход ");
    vibor = Convert.ToInt32(Console.ReadLine());
    switch (vibor)
    {
        case 1:
            otvet = a + b;
            Console.WriteLine("Результат операции= "+otvet);
            break;
       
        case 2:
            otvet = a - b;
            Console.WriteLine("Результат операции= " + otvet);
            break;
        
        case 3:
            otvet = a * b;
            Console.WriteLine("Результат операции= " + otvet);
            break;

        case 4:
            otvet = a / b;
            Console.WriteLine("Результат операции= " + otvet);
            break;

        case 5:
            Environment.Exit(0);
            break;
    }
        


}

