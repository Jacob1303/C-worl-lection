// Метод который ничего не принимает и ничего не возвращает
// Данный метод просто выдаёт информацию заранее указанную автором. Поле переменной () пустое
void Method1()
{
    //Console.WriteLine("Avtor...");
}

Method1(); // функция вызова данного метода

// Метод, который принимает информацию, но не возвращает

void Method2(string msg)
{
    //Console.WriteLine(msg);
}
// При обращении к методу выводится сообщение, указанное в поле переменной

Method2("Текст сообщения");

// Возможно использование нескольких переменных разнотипных, например:

void Method3(string msg, int count)
{
    // в теле метода указывается требуемый алгоритм
}

// Вызов метода

Method3("Сообщение", 4);
Method3(msg: "Text", count: 4); // пример использования именованных аргументов. 

// В этом случае порядок введения информации неважен. Можно ввести сначала count, потом msg

// Методы, которые что-то возвращают, но ничего не принимают

//int Method4()
{
    //return DataTime.Now.Year;
}

int year = Method4();
//Console.WriteLine(year);

// В методе реализована выдача пользователю текущего значения года. Обязательно использование оператора RETURN.
// Далее идёт присвоение результатов работы метода переменной и выдача значения пользователю.


// Методы, которые принимают и выдают информацию

//string Method5(int count, string text)
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

string res = Method5(10, "asd");
//Console.WriteLine(res);

// Данный пример метода склеивает вводимый текст count раз. Интересное решение с пустой исходной строкой String.Empty
// Обращать внимание на совпадение всех типов переменных.

//ЦИКЛ FOR (ЦИКЛ СО СЧЁТЧИКОМ). Пример работы из предыдущего метода


//string Method6(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

//string res = Method6(10,"asd");
//Console.WriteLine(res);

// Использование цикла в цикле на примере вывода таблицы умножения на экран


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}

