using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

System.Console.Write("Radiusni kiriting: ");
int radius = Convert.ToInt32(Console.ReadLine());
double doiraYuzi = Math.PI * Math.Pow(radius, 2);
double aylanaUzunligi = 2 * Math.PI * radius;

System.Console.WriteLine($"Doira yuzi: {doiraYuzi}");
System.Console.WriteLine($"Aylana uzunligi: {aylanaUzunligi}");

System.Console.Write("Konvertatsiya qilinadigan summani kiriting: ");
int summa = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Valyuta kursini kiriting: ");
int qiymat = Convert.ToInt32(Console.ReadLine());
int natija = summa * qiymat;
System.Console.WriteLine($"{summa} birligi kursi {qiymat} bo'lgan valyuta {natija} so'mga teng");

System.Console.Write("Tug'ilgan yilingizni kiriting: ");
int tugilganYil = Convert.ToInt32(Console.ReadLine());
int hozirgiYil = DateTime.Now.Year;
int yosh = hozirgiYil - tugilganYil;
int yoshKunlarda = yosh * 365;
System.Console.WriteLine($"Sizning yoshingiz kunlarda: {yoshKunlarda}");