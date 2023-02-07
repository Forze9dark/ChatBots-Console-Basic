using System;
using System.Collections.Generic;
using ChatBots;

namespace ChatBots
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Bienvenido a la IA, ¿en qué puedo ayudarte?");
            while (true)
            {
                Console.Write("Pregunta: ");
                string pregunta = Console.ReadLine();
                if (Diccionary.conocimientos.ContainsKey(pregunta))
                {
                    Console.WriteLine("Respuesta: " + Diccionary.conocimientos[pregunta]());
                }
                else
                {
                    Console.WriteLine("Lo siento, no tengo la respuesta a esa pregunta.");
                    Console.Write("¿Quieres agregar una respuesta a esta pregunta? (s/n) ");
                    string agregar = Console.ReadLine();
                    if (agregar == "s")
                    {
                        Console.Write("Respuesta: ");
                        string respuesta = Console.ReadLine();
                        Diccionary.conocimientos.Add(pregunta, () => respuesta);
                        Console.WriteLine("La pregunta y respuesta se han agregado a mi base de conocimiento.");
                    }
                }
            }



        }
    }
}
