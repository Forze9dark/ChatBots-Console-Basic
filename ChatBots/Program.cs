using System;
using System.Collections.Generic;
using ChatBots;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using static System.Net.Mime.MediaTypeNames;

namespace ChatBots
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities.SpeakWithText("Bienvenido a la IA, ¿en qué puedo ayudarte?");

            while (true)
            {
                Console.Write("Pregunta: ");
                string pregunta = Console.ReadLine();


                var result = Diccionary.conocimientos.Where(x => x.Key.Contains(pregunta));

                // Diccionary.conocimientos.ContainsKey(pregunta.ToLower())
                // Diccionary.conocimientos.ContainsKey(found.Key) || found.Key != null || found.Value != null
                var found = Diccionary.conocimientos.FirstOrDefault(x => x.Key.Contains(pregunta?.ToString()));

                if (Diccionary.conocimientos.ContainsKey(pregunta.ToLower()))
                {

                    Console.WriteLine(Diccionary.conocimientos[pregunta]());
                }
                else
                {
                    Utilities.SpeakWithText("Lo siento, no tengo la respuesta a esa pregunta.");

                    Utilities.SpeakWithText("¿Quieres agregar una respuesta a esta pregunta? (s/n) ");

                    string agregar = Console.ReadLine();
                    if (agregar == "s")
                    {
                        Console.Write("Respuesta: ");
                        string respuesta = Console.ReadLine();
                        Diccionary.conocimientos.Add(pregunta, () => respuesta);
                        Utilities.SpeakWithText("La pregunta y respuesta se han agregado a mi base de conocimiento.");
                    }
                }
            }
        }

    }
}
