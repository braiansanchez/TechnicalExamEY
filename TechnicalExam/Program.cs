// See https://aka.ms/new-console-template for more information
Console.WriteLine("Text input: ");

var text = Console.ReadLine();
var textWithoutSpaces = text.Replace(" ", string.Empty);
var length = textWithoutSpaces.Length;
var rows = Math.Round(Math.Sqrt(length));
var columns = (int)Math.Round(length / rows);

var condition = ((rows * columns) >= length);
if (!condition)
{
    columns++;
}

//Convert to string array
string[] strArray =  new string[(int)rows];
var index = 0;
var lenghtString = columns;
for (int i = 0; i < rows; i++)
{
    string leftSubString = textWithoutSpaces.Substring(index);

    if (leftSubString.Length < lenghtString)
        lenghtString = leftSubString.Length;

    strArray[i] = textWithoutSpaces.Substring(index, lenghtString);
    index += columns;
}

/*//Watch strArray
for (int i = 0; i < rows; i++)
{
    Console.WriteLine(strArray[i]);
}*/

//Change order
string[] newStrArray = new string[(int)columns];
for (int i = 0; i < rows; i++)
{
    var strRow = strArray[i];
    for (int j = 0; j < strRow.Length; j++)
    {
        newStrArray[j] += strRow.Substring(j, 1);
    }
}

/*//Watch newStrArray
for (int i = 0; i < columns; i++)
{
    Console.WriteLine(newStrArray[i]);
}*/


//OutPut
Console.WriteLine();
Console.WriteLine("OutPut");
Console.WriteLine(string.Join(" ", newStrArray));
Console.WriteLine();
Console.ReadLine();