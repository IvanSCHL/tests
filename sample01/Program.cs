string path = @"c:\vscode\001\test02.txt";

// find count lines in file
var lineCount = File.ReadAllLines(path).Length;
int mass = lineCount;

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
    //Continue to read until you reach end of file
    while (line != null)
    {

        RS[i] = Convert.ToDouble(line);

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

