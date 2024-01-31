using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

int dupeCount = 0;
List<string> compressed = new List<string>();
List<string> toCompress = new List<string>();
string wort;
string add;
void doCompress()
{
    compressed.Clear();
    string lastitem = toCompress[0];
    foreach (var item in toCompress)

    {
        if (item == lastitem)
        {
            dupeCount++;

        }
        else if (dupeCount >= 4)
        {
            compressed.Add("$");
            compressed.Add(dupeCount.ToString());
            compressed.Add(lastitem);
            dupeCount = 0;
            compressed.Add(item);
        }
        else if (dupeCount > 0)
        {
            while (dupeCount > 0)
                {
                    compressed.Add(lastitem);
                    dupeCount--;
                }
            compressed.Add(item);
        }
        else
        {
            compressed.Add(item);

        }
        lastitem = item;
 
    }
    foreach (var item in compressed)
    {
        Console.Write(item);
    }

}

Console.WriteLine("Bitte geben sie den zu komprimierenden String ein");
wort = Console.ReadLine().ToString();

for (int i = 0; i < wort.Length; i++)
{
    toCompress.Add(wort[i].ToString());
}
doCompress();

while (true)
{
    Console.WriteLine("     Wollen sie etwas den Text hinzufügen?");
    add = Console.ReadLine().ToString();
    for (int l = 0; l < add.Length; l++)
    {
        toCompress.Add(add[l].ToString());
    }
    doCompress();

}


