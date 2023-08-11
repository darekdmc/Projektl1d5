var name = "Ewa";
var gender = "Kobieta";
var age = 33;

if (gender == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (gender != "Kobieta" && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
// Program wyświetla prawidłowe komunikaty przy deklaracji różnych zmiennych