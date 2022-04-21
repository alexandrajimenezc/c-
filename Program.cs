//Escribe un programa que reciba tu nombre y lo escriba por consola.
Console.WriteLine("Introduce tu nombre: ");
string name = Console.ReadLine();
Console.WriteLine(name);

//Escribe un programa que tome la hora y la escriba por pantalla.
string getTime = DateTime.Now.ToString("hh:mm:ss tt");
Console.WriteLine("La hora es: " + getTime);