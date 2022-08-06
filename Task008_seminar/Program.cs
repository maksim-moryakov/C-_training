using System.Globalization;
using System.Text;


Console.WriteLine("Input week day number");

int weekday = Convert.ToInt32(Console.ReadLine());

Console.Write(Enum.GetName(typeof(DayOfWeek),weekday));


var rusculture = new System.Globalization.CultureInfo("ru-RUS");
DateTimeFormatInfo rusDateFormat = rusculture.DateTimeFormat;

string[] rusDays = rusDateFormat.DayNames;
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine(rusDays[weekday]);
