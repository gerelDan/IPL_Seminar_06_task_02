// Задача 2: Задайте строку, содержащую латинские буквы
//в обоих регистрах. Сформируйте строку,
//в которой все заглавные буквы заменены на строчные.

string str = "asdFadGewTkj";
Console.WriteLine(str);
// Вариант 1
string resultString =str.ToLower();
Console.WriteLine(resultString);
// Вариант 2
string ToLow(string str)
{
    string result = String.Empty;
    byte[] res = System.Text.Encoding.Default.GetBytes(str);
    for (int i = 0; i < res.Length; i++)
    {
        if (res[i] < 97)
        {
            result += Convert.ToChar(res[i]+32);
        }
        else result += Convert.ToChar(res[i]);
    }
    return result;
}
string result = ToLow(str);
Console.WriteLine(result);