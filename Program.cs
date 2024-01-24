var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Uppdatera länken för att göra olika typer av uträkningar\n\n /add för Addition\n /sub för Subtraction \n /multi för Multiplikation\n /div för Division\n\n\n Sedan lägger du till följande:\n\n ?num1=A&num2=B\n\n Där A och B är tal");

app.MapGet("/add", (int num1, int num2) => AddNumbers(num1, num2));
app.MapGet("/sub", (int num1, int num2) => SubtractNumbers(num1, num2));
app.MapGet("/multi", (int num1, int num2) => MultiplyNumbers(num1, num2));
app.MapGet("/div", (float num1, float num2) => DivideNumbers(num1, num2));


app.Run();

string AddNumbers(int num1, int num2)
{
    return $"Summan av {num1} och {num2} är {num1 + num2}";
}
string SubtractNumbers(int num1, int num2)
{
    return $"Differensen av {num1} och {num2} är {num1 - num2}";
}
string MultiplyNumbers(int num1, int num2)
{
    return $"Produkten av {num1} och {num2} är {num1 * num2}";
}
string DivideNumbers(float num1, float num2)
{
    return $"Kvoten av {num1} och {num2} är {num1 / num2}";
}


