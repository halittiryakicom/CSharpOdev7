//1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
Console.WriteLine("----------Konsol ekranına 10 kere \"Kendime inanıyorum, ben bu yazılım işini hallederim!----------");
int count = 0;
while (count < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!"); 
    count++;
}

//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız. 
Console.WriteLine("----------1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.----------");
count = 1;
while (count <= 20)
{
    Console.WriteLine(count);
    count++;
}

//3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
Console.WriteLine("----------1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.----------");
count = 0;
while (count <= 20)
{
    Console.WriteLine(count);
    count += 2;
}

//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
Console.WriteLine("----------50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.----------");
count = 50;
int sum = 0;
while (count <= 150)
{
    sum += count;
    count++;
}
Console.WriteLine("Sayıların toplamı: "+sum);

//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
Console.WriteLine("----------1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.----------");
count = 1;
int sumOdd=0, sumEven=0;
while (count <= 120)
{
    if (count % 2 == 0)
        sumEven += count;
    else
        sumOdd += count;
    count++;
}
Console.WriteLine("Çift sayıların toplamı: "+sumEven+". Tek sayılarun toplamı: "+sumOdd);