// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

var input = "2022-07-29T00:00:00-04:00";

var input2 = "4/12/2024";


//var output = DateTime.Parse(input);
//var output = DateTime.ParseExact(input);


var outputx = DateTime.Parse(input);
var output = DateTimeOffset.Parse(input);
var output2 = DateTimeOffset.ParseExact(input, "yyyy-MM-ddTHH:mm:sszzzz", System.Globalization.CultureInfo.InvariantCulture);

var outputr = output.DateTime;
var output2r = output2.DateTime;

var out2 = DateTime.Parse(input2);



Console.WriteLine(outputx.ToString());
Console.WriteLine(outputr.ToString());
Console.WriteLine(output2r.ToString());


Console.WriteLine(output.Date.ToString("MM/dd/yyyy"));


Console.ReadLine();

