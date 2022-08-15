
//необходимо сменить в программе параметры локализации и сделать их западными: en-US.
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

string path = @"c:\vscode\001\test11.txt";
int x = 1;

// find count lines in file
var lineCount = File.ReadAllLines(path).Length;
int mass = lineCount;
Console.WriteLine(mass);

static string RazdelitelStroki(string stroka, int numberStr)
{
    string[] dats = stroka.Split(',');
    string[] zna4 = new string[8];
    int i = 0;
    foreach (var dat in dats)
    {
        zna4[i] = dat;
        i++;
    }
    return (zna4[numberStr]);

}



String line;
double[] RS = new double[mass];
string[] RSst = new string[mass];
int i = 0;

try
{
    //Pass the file path and file name to the StreamReader constructor
    StreamReader sr = new StreamReader(path);
    //Read the first line of text
    line = sr.ReadLine();
    //Console.WriteLine(line);
    //Continue to read until you reach end of file
    while (line != null)
    {

        string qwe = RazdelitelStroki(line, x);
        //Console.WriteLine(qwe);
        RS[i] = Convert.ToDouble(qwe);
        //Console.WriteLine(RS[i]);
        //Read the next line
        line = sr.ReadLine();

        i++;

    }
    //close the file
    sr.Close();
    Console.ReadLine();

}

catch (Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
finally
{
    Console.WriteLine("Executing finally block.");
}
//initial variables
double mean = 0;
double sum = 0;
double stddev = 0;
double stddev2 = 0;
double stddevPR = 0;

for (i = 0; i < mass; i++)
{
    sum = sum + RS[i];
}
mean = sum / (mass);
for (i = 0; i < mass; i++)
{
    stddev2 = stddev2 + (RS[i] - mean) * (RS[i] - mean);
}
stddev = Math.Sqrt(stddev2 / mass);

stddevPR = stddev / mean * 100;
Console.WriteLine("сумма значений измерений");
Console.WriteLine(sum);
Console.WriteLine("среднее значение измерений");
Console.WriteLine(mean);
Console.WriteLine("значение дисперсии");
Console.WriteLine(stddev2);
Console.WriteLine("значение среднеквадратичного отклонения");
Console.WriteLine(stddev);
Console.WriteLine("значение среднеквадратичного отклонения в процентах");
Console.WriteLine(stddevPR);

