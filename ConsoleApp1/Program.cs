using System.Net.Security;
#region 
    

//Задача 1
Console.WriteLine("Задача 1");
Console.WriteLine("Hello, World!");
#endregion
#region 
//Задача 2
Console.WriteLine("Задача 2");
int a = 12;
int b = -9;
if(a<0)
{
    a = a * -1;
}
if(b<0)
{
    b = b * -1;
}
Console.WriteLine($"{a}");
Console.WriteLine($"{b}");
#endregion
#region 
//Задача 3
Console.WriteLine("Задача 3");
int a1 = 3;
int b1 = 8;

Console.WriteLine("Първоначални стойности: ");
Console.WriteLine($"a = {a1}");
Console.WriteLine($"b = {b1}");

int temp = a1;
a1 = b1;
b1 = temp;

Console.WriteLine("След размяната: ");
Console.WriteLine($"a = {a1}");
Console.WriteLine($"b = {b1}");
#endregion
#region 
//Задача 4
Console.WriteLine("Задача 4");

Console.WriteLine("Въведете число 1: ");
double number1 = double.Parse(Console.ReadLine());

Console.WriteLine("Въведете число 2: ");
double number2 = double.Parse(Console.ReadLine());

Console.WriteLine("Въведете число 3: ");
double number3 = double.Parse(Console.ReadLine());

double average = (number1+number2+number3) / 3;

Console.WriteLine($"Средната стойност е: {average}");
#endregion

#region 
//Задача 5
 Console.WriteLine("Въведете пет цели числа:");

int[] numbers = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Число {i + 1}: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

int minNumber = numbers[0];
int maxNumber = numbers[0];

for (int i = 1; i < 5; i++)
{
if (numbers[i] < minNumber)
{
    minNumber = numbers[i];
}

if (numbers[i] > maxNumber)
{
    maxNumber = numbers[i];
}
}

Console.WriteLine($"Най-малкото число е: {minNumber}");
Console.WriteLine($"Най-голямото число е: {maxNumber}");
#endregion
#region 
//Задача 6
Console.WriteLine("Въведете дължина в инчове: ");
double inches = double.Parse(Console.ReadLine());

double centimeters = inches * 2.54;
Console.WriteLine($"{inches} инча са равни на {centimeters} сантиметра.");
#endregion

#region 
//Задача 7
Console.WriteLine("Задача 7");
Console.WriteLine("Въведете да или не: ");
string userInput = Console.ReadLine();
bool resultat;
if (userInput.ToLower() == "da")
{
    resultat = true;
}
else if (userInput.ToLower() == "ne")
{
    resultat = false;
}
else 
{
    Console.WriteLine("Въведеният текст не е нито да или не");
    return;
}
Console.WriteLine(resultat);
#endregion
#region
//Задача 8
Console.WriteLine("Задача 8");
Console.WriteLine("Въведете температура в целзий: ");
var farenheit = double.Parse(Console.ReadLine());
var celsius = farenheit * 9/5 + 32;
Console.WriteLine("фаренхайт: ");
Console.WriteLine(celsius);
#endregion
#region
//Задача 9
Console.WriteLine("Задача 9");
int num = int.Parse(Console.ReadLine());
if(num % 2 == 0)
{
    Console.WriteLine("Числото е четно");
}
else
{
    Console.WriteLine("Числото е нечетно");
}
#endregion

#region
//Задача 1
Console.WriteLine("Задача 1");
Console.WriteLine("Въведете вашето име: ");
string name = Console.ReadLine();
Console.WriteLine($"Здравей, {name}");
//Отговор на задача 1
#endregion

#region
//Задача 2
double pi = Math.PI;
Console.WriteLine($"Числото π до втората цифра след десетичната запетая: {pi:F2}");
//Отговор на задача 2
#endregion

#region
//Задача 3
Console.WriteLine("Задача 3");
Console.WriteLine("Въведете число a: ");
int a3 = int.Parse(Console.ReadLine());
Console.WriteLine("Въведете число b: ");
int b3 = int.Parse(Console.ReadLine());

int sum = (a3+b3);
Console.WriteLine("Сумата от двете числа е: " + sum);
//Отговор на Задача 3
#endregion

#region
//Задача 4
Console.WriteLine("Задача 4");
Console.Write("Въведете число: ");
Console.WriteLine($"{number} * 1 = {number * 1}");
Console.WriteLine($"{number} * 2 = {number * 2}");
Console.WriteLine($"{number} * 3 = {number * 3}");
Console.WriteLine($"{number} * 4 = {number * 4}");
Console.WriteLine($"{number} * 5 = {number * 5}");
Console.WriteLine($"{number} * 6 = {number * 6}");
Console.WriteLine($"{number} * 7 = {number * 7}");
Console.WriteLine($"{number} * 8 = {number * 8}");
Console.WriteLine($"{number} * 9 = {number * 9}");
Console.WriteLine($"{number} * 10 = {number * 10}");
//Отговор на Задача 4
#endregion

#region
//Задача 5
Console.WriteLine("Задача 5");
Console.WriteLine("Въведете текст: ");
string text = Console.ReadLine();
Console.WriteLine("Въведете текст 2: ");
string vtoritext = Console.ReadLine();

Console.WriteLine($"{text}"  +  $"{vtoritext}");
//Отговор на Задача 5
#endregion
#region
//Задача 6
Console.WriteLine("Въведете ъгъл в радиани: ");
double radians = double.Parse(Console.ReadLine());
double degrees = radians * (180/Math.PI);
Console.WriteLine($"{radians} радиани са {degrees} градуса.");
//Отговор на Задача 6
#endregion

#region 
//Задача 7
Console.WriteLine("Въведете изречение: ");
string izrechenie = Console.ReadLine();
string zapetaiki = izrechenie.Replace(' ', ',');
Console.WriteLine($"Модифицираното изречение: {zapetaiki}");
//Отговор на Задача 7
#endregion

#region 
//Задача 8
Console.Write("Въведете вашето име: ");
string ime = Console.ReadLine();
char[] imeNaobratno = ime.ToCharArray();
Array.Reverse(imeNaobratno);
string reversedName = new string(imeNaobratno);
Console.WriteLine($"Името ви на обратно е: {reversedName}");
//Отговор на Задача 8
#endregion

#region 
//Задача 9
Console.WriteLine("Въведете дължина: ");
double duljina = double.Parse(Console.ReadLine());
Console.WriteLine("Въведете ширина: ");
double shirina = double.Parse(Console.ReadLine());
double P = duljina * shirina;
Console.WriteLine($"Площта на правоъгълника е: {P} ");
//Отговор на Задача 9
#endregion

#region 
//Задача 10
Console.WriteLine("Въведете време в секунди: ");
int seconds = int.Parse(Console.ReadLine());
int hours = seconds / 3600;
int minutes = (seconds % 3600) / 60;
int second = seconds % 60;
Console.WriteLine($"{seconds} секунди са {hours} часа, {minutes} минути и {second} секунди.");
#endregion
#region
//Задача 1
Console.WriteLine("Въведете число 1: ");
double chislo1 = double.Parse(Console.ReadLine());
Console.WriteLine("Въведете число 2: ");
double chislo2 = double.Parse(Console.ReadLine());
if (chislo1 > chislo2)
{
    Console.WriteLine($"По-голямото число е: {chislo1}");
}
else
{
    Console.WriteLine($"По-голямото число е: {chislo2}");
}
//Отговор на Задача 1
#endregion

#region 
//Задача 2
Console.WriteLine("Въведете число: ");
int num1 = int.Parse(Console.ReadLine());

if (num1 % 5 == 0 && num1 % 7 == 0)
{
    Console.WriteLine("Числото се дели и на 5, и на 7.");
}
else
{
    Console.WriteLine("Числото не се дели и на 5, и на 7.");
}
//Отговор на Задача 2
#endregion

#region

#region 


//Задача 3
Console.WriteLine("Въведете първо число: ");
double numb1 = double.Parse(Console.ReadLine());
Console.WriteLine("Въведете второ число: ");
double numb2 = double.Parse(Console.ReadLine());
Console.WriteLine("Въведете трето число: ");
double numb3 = double.Parse(Console.ReadLine());
double temp1;
if (numb1 > numb2)
{
    temp1 = numb1;
    numb1 = numb2;
    numb2 = temp1;
}
if (numb2 > numb3)
{
    temp1 = numb2;
    numb2 = numb3;
    numb3 = temp1;
}
if (numb1 > numb2)
{
    temp1 = numb1;
    numb1 = numb2;
    numb2 = temp1;
}
Console.WriteLine($"Сортирани във възходящ ред са: {numb1}, {numb2}, {numb3}");
//Отговор на Задача 3
#endregion

#region 
Console.WriteLine("Въведете число от 1 до 7: ");
int den = int.Parse(Console.ReadLine());
string den1;

if (den == 1)
{
    den1 = "Понеделник";
}
else if (den == 2)
{
    den1 = "Вторник";
}
else if (den == 3)
{
    den1 = "Сряда";
}
else if (den == 4)
{
    den1 = "Четвъртък";
}
else if (den == 5)
{
    den1 = "Петък";
}
else if (den == 6)
{
    den1 = "Събота";
}
else
{
    den1 = "Неделя";
}
Console.WriteLine($"Денят от седмицата е: {den1}");
#endregion

#region 
 Console.WriteLine("Do you choose rock,paper or scissors");
            string userChoice = Console.ReadLine();

            Random r = new Random();
            int computerChoice = r.Next(4);

                if (computerChoice == 1)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("It is a tie ");                     
                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("It is a tie ");

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("It is a tie ");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock,paper or scissors!");

                    }

                }

                else if (computerChoice == 2)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("Sorry you lose,paper beat rock");

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("Sorry you lose,scissors beat paper ");

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("Sorry you lose,rock beats scissors");                       
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock,paper or scissors!");        
                    }
                }
                else if (computerChoice == 3)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("You win,rock beats scissors");

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("You win,paper beats rock");

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("You win,scissors beat paper");

                    }
                    else
                    {
                        Console.WriteLine("You must choose rock,paper or scissors!");

                    }

                }

            Console.ReadLine();
#endregion




