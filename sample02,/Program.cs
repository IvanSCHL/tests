string a = "Site 1:,462.470593,0.000000,180.000000,0.000000,0.000000,462.470593,Valid Measurement";
Console.WriteLine(a);

int x=1;

static string RazdelitelStroki(string stroka, int numberStr)
{
    string[] dats = stroka.Split(',');

    string[] zna4 = new string[8];
    int i = 0;
    foreach (var dat in dats)
    {
        zna4[i] = dat;
        //Console.WriteLine(dat);
        i++;
    }

    //Console.WriteLine(zna4[numberStr]);
    return (zna4[numberStr]);

}

try
{
double qwe = Convert.ToDouble(RazdelitelStroki(a, x));

Console.WriteLine (qwe);

}

catch (Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
string qwe = RazdelitelStroki(a, x);
    Console.WriteLine (qwe);
}
finally
{
    Console.WriteLine("Executing finally block.");
}


