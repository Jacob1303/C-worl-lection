int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 135;
int b1 = 11;
int c1 = 13452;
int a2 = 143;
int b2 = 3001;
int c2 = 431;
int a3 = 134;
int b3 = 1350;
int c3 = 165;

//Данные вариант решения с присвоением дополнительным переменным значений максимумов из 3 чисел;
//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

// Данный вариант - это встраивание функции в функцию, избегая дополнительных переменных;
int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));

Console.WriteLine(max);