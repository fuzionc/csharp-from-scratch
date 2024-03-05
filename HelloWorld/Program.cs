namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            // Crear una instancia de DateOnly para almacenar la fecha de nacimiento.
            DateOnly dateCoverted= new DateOnly();

            // Declarar variables para almacenar el nombre y la fecha de nacimiento.
            String nameInput;
            String birthdayInput;

             // Mostrar mensajes de bienvenida y solicitar al usuario que ingrese su nombre.
            Console.WriteLine("¡Hola,Bienvenido! Puedes calcular tus años aca");
            Console.WriteLine("Primero, escribe tu nombre:");
            nameInput=Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte: {nameInput}");

            // Solicitar al usuario que ingrese su fecha de nacimiento en formato: Dia/Mes/Año.
            Console.WriteLine("Escribe por favor, tu fecha de nacimiento en formato: Dia/Mes/Año");
            birthdayInput=Console.ReadLine();

            // Intentar convertir la cadena de fecha de nacimiento a un objeto DateOnly.
            bool isDateValid=DateOnly.TryParse(birthdayInput,out dateCoverted );
            // Verificar si la fecha de nacimiento es válida.
            if(isDateValid==false)  Console.WriteLine($"La fecha de nacimiento esta incorrecta, usted nos ha proporciado un dato erroneo. {birthdayInput}");

            var person = new Person{
                Name = nameInput,
                Birthday = dateCoverted,
                Age = DateTime.Now.Year - dateCoverted.Year
            
            };      
            Console.WriteLine($"Tu nombre es: {person.Name}");
            Console.WriteLine($"Tu fecha de nacimiento: {person.Birthday}");
            Console.WriteLine($"Tu edad es: {person.Age} Años");
            Console.ReadLine();
        }
    }

    public class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
    }
}