using System;

#region Challenge 1
Console.Write("Type a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= num; i++)
{
    sum += i;
}
Console.WriteLine(sum);
#endregion

Console.WriteLine("--------------------");

#region Challenge 2
Console.Write("Type a word or a sentence: ");
string input = Console.ReadLine();


static string VowelCount(string str)
{
    int vowelCount = 0;
    foreach (char c in str)
    {
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
            c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
        {
            vowelCount++;
        }
    }
    return $"Vowel Count: {vowelCount}";
}
Console.WriteLine(VowelCount(input));

#endregion

Console.WriteLine("--------------------");

#region Challenge 3

Console.Write("Enter a number: ");
int numb = Convert.ToInt32(Console.ReadLine());
static int FirstFactorial(int numb)
    {
        if (numb < 0)
        {
            return -1;
        }
        else if (numb == 0)
        {
            return 1;
        }
        else
        {
            int factorial = 1;
            for (int i = 1; i <= numb; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
 Console.WriteLine(FirstFactorial(numb));

#endregion

Console.WriteLine("--------------------");

#region Challenge 4
Console.Write("Enter a number: ");
string number = Console.ReadLine();
static string SimpleEvens(string number)

{
    string numString = number.ToString();
    foreach (char digit in numString)
    {
        if (Convert.ToInt32(digit.ToString()) % 2 != 0)
        {
            return "false";
        }
    }
    return "true";
}
Console.WriteLine(SimpleEvens(number));

#endregion

Console.WriteLine("-------------------");

#region Challenge 5
Console.Write("Enter a number: ");
string str2 = Console.ReadLine();
static int OneDecremented(string str2)
    {
        int count = 0;
        for (int i = 1; i < str2.Length; i++)
        {
            if (Convert.ToInt32(str2[i]) == Convert.ToInt32(str2[i - 1]) - 1)
            {
                count++;
            }
        }
        return count;
    }
Console.Write(OneDecremented(str2));


#endregion


