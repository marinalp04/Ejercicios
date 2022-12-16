Console.WriteLine("Introduzca un caracter");
string estadocivil = Console.ReadLine();
estadocivil = estadocivil.ToUpper();
switch (estadocivil)
{
    case "C":
        Console.WriteLine("El estado civil es Casado");
        break;

    case "S":
        Console.WriteLine(" El estado civil es Soltero");
        break;
    case "V":
        Console.WriteLine(" El estado civil es Viudo");
        break;

    case "D":
        Console.WriteLine(" El estado civil es Divorciado");
        break;
    default:
        Console.WriteLine("Este estado civil no existe");
        break;
}
Console.ReadLine();
