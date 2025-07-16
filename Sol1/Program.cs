// Алгоритм компрессии
String s = "aaabbcccdde",
       compressWord = "";
int count = 1;


for (int i = 0; i < s.Length; i++)
{
    if (i == 0)
    {
        compressWord += Convert.ToString(s[i]);
    }
    else
    {
        if (s[i] == s[i - 1])
        {
            count++;
        }
        else
        {
            if (count != 1) compressWord += count;
            compressWord += s[i];
            count = 1;
        }
    }

}

Console.WriteLine(compressWord);

// Алгоритм декомпрессии
String decompres = "";
int cW_id = 0;
while (cW_id < compressWord.Length)
{
    if (compressWord[cW_id] > 47 && compressWord[cW_id] < 58)
    {
        cW_id++;
        continue;
    }
    int repCount;
    count = 0;
    //подсчёт длины числа
    //проверка на выход из диапазона
    cW_id++;
    while (cW_id + count < compressWord.Length && compressWord[cW_id + count] > 47 && compressWord[cW_id + count] < 58)
    {
        count++;
    }
    //выделение числа из строки
    if (count > 0)
        repCount = Convert.ToInt32(compressWord.Substring(cW_id, count));
    else
        repCount = 1;
    cW_id--;
    for (int i = 0; i < repCount; i++)
    {
        decompres += compressWord[cW_id];
    }
    cW_id++;
}

Console.WriteLine(decompres);