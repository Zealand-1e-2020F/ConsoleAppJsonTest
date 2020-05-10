using System;

namespace ConsoleAppJsonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serialize and Deserialize!");
            Console.WriteLine("Formål: At forstå Json, og hvordan der kan serialiseres og deseriliseres med Json");

            //I dette projekt er der en klasse "Student" som du skal bruge i denne opgave, tag et kig i denne klasse, og læs summary

            //Opgave 1: Installer Newtonsoft Json via Nuget : Tools->NuGet Package Manager  -> Manage ..  for solution

            Console.WriteLine("Serialize C# objekter til Json streng");
            //Opgave 2: Opret et nyt Student objekt med værdier for navn og adresse, serialiser det med JSonConvert til en variabel, skriv ud til konsollen 


            //Opgave 3: Opret en liste List<Student>. Tilføj et antal objekter til listen, serialiser det med JsonConvert til en variabel, skriv ud til konsollen


            Console.WriteLine("Deserialiser en json streng til C# objekter");

            //Opgave 4: Brug variablen jsonStudent til at give værdier til et C# objekt (Student), deserialiser det med JSonConvert, print C# objektet ud i konsollen
            //OBS: bemærk at der er brugt escape karakteren \ foran alle citationstegn \" for at jeg kan have teksten direkte her i koden, disse vil ikke være med i json stregne normalt
            string jsonStudent = "{\"navn\":\"Mette\",\"adresse\":\"Roskilde\"}";

            //Opgave 5: Brug variablen jsonStudentListe til at give værdier til en liste List<Student>, deserialiser med JsonConvert, foreach over lisen og print hver værdi ud
            string jsonStudentListe = "[{\"navn\":\"Mette\",\"adresse\":\"Roskilde\"},{\"navn\":\"Anders And\",\"adresse\":\"AndeBy\"},{\"navn\":\"Batman\",\"adresse\":\"Gotham City\"}]";


        }
    }
}
