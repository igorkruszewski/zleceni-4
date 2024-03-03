const int cel = 100000;
const int wwe = 5;
int element = 1;
int ilość = 1;
for (element = 1; element <= cel; element++)
{
    if (element %wwe == 0)
    {
        element = element++;
        Console.WriteLine(ilość++ +" " + "element:"+ element);
    }
}