// See https://aka.ms/new-console-template for more information

// 1. Verilmiş 3 rəqəmli ədədin rəqəmlərinin hasilini tapan alqoritm.
// Misalçün alqoritmə 231 ədədini daxil etdikdə 2*3*1 in nəticəsini verməlidir.

Console.WriteLine("3 reqemli eded daxil edin");

int ucReqemliEded = Convert.ToInt32(Console.ReadLine());

int birlik = ucReqemliEded % 10; 
int onluq = (ucReqemliEded / 10) % 10;
int yuzluk = (ucReqemliEded / 100) % 10;

int hasil = birlik * onluq * yuzluk;

Console.WriteLine(hasil);

// 2. Supermarketdə belə bir aksiya keçirilir: 3 məhsul aldıqda ən ucuz məhsul pulsuz olur.Misalçün 40 ,
// 50 və 20 manatlıq mıəhsullar alsam ümumilikdə 40+50 manat ödənilir.3 Mıhsulun qiyməti verildikdə müştərinin
// nə qədər ödəməli olduğunu tapan alqoritm


int mehsul1 = Convert.ToInt32(Console.ReadLine());
int mehsul2 = Convert.ToInt32(Console.ReadLine());
int mehsul3 = Convert.ToInt32(Console.ReadLine());
int odenilecekMebleg = 0;

if (mehsul1 >= mehsul2 && mehsul2 >= mehsul3)
{
    odenilecekMebleg = mehsul1 + mehsul2;

}
else if (mehsul2 >= mehsul3 && mehsul3 >= mehsul1)
{
    odenilecekMebleg = mehsul2 + mehsul3;
}
else if (mehsul3 >= mehsul1 && mehsul1 >= mehsul2) ;
{
    odenilecekMebleg = mehsul1 + mehsul3 ;
}
else
{
    Console.WriteLine("Odenis edilmeyib");
}

Console.WriteLine(" Yekun odenilecek mebleg "+ odenilecekMebleg);


// 3. a ədədi 3-ə bölünən cüt ədəddirsə " ,3-ə bölünən tək ədəddirsə " ,
//3-e bolunur tekdir" əks halda "3-e bolunmur" sözünü ekranda çap edin.

int a = Convert.ToInt32(Console.ReadLine());

if (a % 3 == 0 && a % 2 == 0)
{
    Console.WriteLine("3 - e bolunur cutdur");
}
else if (a % 3 == 0 && a % 2 == 1)
{
    Console.WriteLine("3 - e bolunur tekdir");
}
else 
{
    Console.WriteLine("3-e bolunmur");
}

// 4. Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapın.


int a = Convert.ToInt32(Console.ReadLine());

if (a < 2 )
{
    Console.WriteLine("ne sade ne murekkeb");
}
else if (a %2 ==0 && a%3==0 && a%5==0 && a%7==0)
{
    Console.WriteLine("sade ededdir");
}
else
{
    Console.WriteLine("murekkeb ededdir");
}


// 5. X, Y, Z  ədədləri verilib. Bu ədədlərin ən kiçiyini tapan alqoritm qurun

int x = Convert.ToInt32(Console.ReadLine());

int y = Convert.ToInt32(Console.ReadLine());

int z = Convert.ToInt32(Console.ReadLine());

int enKicik = 0;
if  (x < y && x < z)
{
    enKicik = x;
}
else if (y < x && y < z)
{
    enKicik = y;
}
else if (z < x && z < y)
{
    enKicik = z;
}
else
{
    Console.WriteLine("0");
}
Console.WriteLine("en kicik reqem " + enKicik);

// 6. Verilmiş N ədədinin 3-ə və 7-ə bölünüb bölünmədiyini tapan alqoritm qurun

int a = Convert.ToInt32(Console.ReadLine());

if (a %21== 0)
{
    Console.WriteLine("eded 3 e ve 7 e tam bolunur");
}

else if (a %3==0 && a % 7 != 0)
{
    Console.WriteLine(" eded 3 e tam bolunur, 7 ey tam bolunmur");

}
else if (a%7== 0 && a % 3 != 0)
{
    Console.WriteLine("eded 7 ye tam bolunur, 3 e tam bolunmur");
}
else
{
    Console.WriteLine("eded 3 e ve 7 e tam bolunmur");
}

// 7. Verilmiş 3 ədəddən müsbət olanların sayını tapan alqoritm

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int musbetEdedler = 0;

if (a == 0 && b == 0 && c == 0)
{
    Console.WriteLine("Ne musbet ne de menfidir");
}
if ( a > 0)
    {
    musbetEdedler++;
    }
if (b > 0)
{
    musbetEdedler++;
}
if (c > 0)
{
    musbetEdedler++;
}
else
{
    Console.WriteLine("Ancaq menfi ededlerdir");
}

Console.WriteLine("Musbet ededlerin sayi: " + musbetEdedler);

// 8. Verilmiş M ədədindən verilmiş N ədədinədək olan ədədlərin cəmini tapan alqoritm


int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int araliqdakiEdedlerinCemi = 0;

for (int i = m; i <= n; i++)
{
    araliqdakiEdedlerinCemi += i;
}
Console.WriteLine(araliqdakiEdedlerinCemi);


// 9. 1-dən M-ədək ədədlər içərisində 15-ə bölünən ədədlərin sayını tapan alqoritm

int m = Convert.ToInt32(Console.ReadLine());
int result = 0;

for (int i = 1; i <= m; i++)
{
    if (i %15 == 0)
    {
        result++;
    }
}
Console.WriteLine(result);

// 10. 1-dən M-ədək ədədlər içərisində 21-ə bölünən ədədlərin ədədi ortasını tapan alqoritm


int m = Convert.ToInt32(Console.ReadLine());
int cem = 0;
int say = 0;

for (int i = 1; i <= m; i++)
{
    if (i % 21 == 0)
    {
        cem += i;
        say++;
    }
}
float edediOrtasi = cem / say;
Console.WriteLine(edediOrtasi);

// 11. Verilmiş N ədədinin rəqəmlərinin cəmini tapan alqoritm. (ədəd 3 və ya daha cox rəqəmdən ibarət ola bilər)

int eded = Convert.ToInt32(Console.ReadLine());

int cemi = 0;


while (eded !=0)
{
    int reqem= eded % 10;

    cemi +=reqem;

    eded= eded/ 10;

}
Console.WriteLine(cemi);

