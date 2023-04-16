char entry;
Console.WriteLine("Please Enter Character");
bool character=char.TryParse(Console.ReadLine(),out entry);
if (character == true)
{   
    int ascii=((int)entry);
    Console.WriteLine("Ascii Number:"+ascii);
    
    double binarycode = 0;
    int i = 0;

    while (ascii >= 2)
    {
        binarycode = binarycode + (ascii % 2) * (Math.Pow(10, i));
        ascii = ascii / 2;
        i++;
    }
    binarycode = binarycode + (ascii * Math.Pow(10, i));
    Console.WriteLine(binarycode);
    Console.ReadLine();
}
else
{
    Console.WriteLine("Wrong");
}
Console.ReadLine();