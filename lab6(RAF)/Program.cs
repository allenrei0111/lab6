using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab6_RAF_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an object from the class and assign a value of 1 to the event number property and a value of Calgary to the location property.
            Event myEvent = new Event(1, "Calgary");

            //Use serialization to serialize the object to a file called event.txt.
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("event.txt", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, myEvent);
            }

            //Use deserialization to deserialize the object from the file and display the values on the Console.
            using (Stream stream = new FileStream("event.txt", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                Event deserializedEvent = (Event)formatter.Deserialize(stream);
                Console.WriteLine($"Event Number: {deserializedEvent.EventNumber}");
                Console.WriteLine($"Location: {deserializedEvent.Location}");
            }
            ReadFromFile();
        }
        //Create a method called ReadFromFile,       
        static void ReadFromFile()
    {
        Console.WriteLine("Tech Competition");
            //  write the word “Hackathon” to the file,
            using (StreamWriter writer = File.CreateText("event.txt"))
        {
            writer.Write("Hackathon");
        }

            // Read the first, middle, and last characters of the file
            //using StreamWriter and the Seek method.
            using (Stream stream = new FileStream("event.txt", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                stream.Seek(0, SeekOrigin.Begin);
                char first = (char)stream.ReadByte();
                stream.Seek(stream.Length / 2, SeekOrigin.Begin);
                char middle = (char)stream.ReadByte();
                stream.Seek(-1, SeekOrigin.End);
                char last = (char)stream.ReadByte();

                Console.WriteLine($"In Word: Hackathon");
                Console.WriteLine($"The First Character is: \"{first}\"");
                Console.WriteLine($"The Middle Character is: \"{middle}\"");
                Console.WriteLine($"The Last Character is: \"{last}\"");
            }
        }
    }
}







