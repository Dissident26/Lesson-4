
minMaxMessage firstIntervalWithMessage = new minMaxMessage(0, 30, "первый интервал");
minMaxMessage secondIntervalWithMessage = new minMaxMessage(31, 60, "второй интервал");
minMaxMessage thirdIntervalWithMessage = new minMaxMessage(61, 100, "третий интервал");

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
getGap(number, firstIntervalWithMessage, secondIntervalWithMessage, thirdIntervalWithMessage);

string result = getNumbersInIntervalDividesBy(200, 500, 17);
Console.WriteLine(result);

void getGap(int number, params minMaxMessage[] intervalsWithMessages){
    foreach (var item in intervalsWithMessages)
    {
        if(item.min <= number && number <= item.max)
        {
            Console.WriteLine("число {0} входит в {1}", number, item.message);
            return;
        }
    }

    Console.WriteLine("число не найдено");
}

string getNumbersInIntervalDividesBy(int min, int max, int divider)
{
    int iteration = min;
    string result = "";

    while (iteration < max) 
    {
        if(iteration % divider == 0)
        {
            result += iteration + ", ";
        }
       iteration++; 
    }

    return result.Trim(new Char[] { ' ', ',' });
}
struct minMaxMessage
{
    public int min;
    public int max;
    public string message;
    public minMaxMessage(int min, int max, string message)
    {
        this.min = min;
        this.max = max;
        this.message = message;
    }
}