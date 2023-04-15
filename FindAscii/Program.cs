char entry;
Console.WriteLine("Please Enter Character");
bool character=char.TryParse(Console.ReadLine(),out entry);
if (character == true)
{   
    int ascii=((int)entry);
    Console.WriteLine("Ascii Number:"+ascii);
}
else
{
    Console.WriteLine("Wrong");
}
Console.ReadLine();