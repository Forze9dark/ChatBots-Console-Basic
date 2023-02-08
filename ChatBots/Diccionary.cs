using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace ChatBots
{
    internal class Diccionary
    {

        // Crea un objeto de síntesis de voz
        public static SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        // Palabras a aprender.
        public static Dictionary<string, Func<string>> conocimientos = new Dictionary<string, Func<string>>()
        {
            { "hora", () => "La hora actual es " + DateTime.Now.ToString("h:mm tt") },
            { "dia", () => "Hoy es " + DateTime.Now.ToString("dddd, dd MMMM yyyy") },
            { "cual es tu nombre", () => {
                Utilities.SpeakWithText("Soy un chatbot creado por OpenAI.");
                return "";
                } 
            },
            { "defecto", () => "Lo siento, no entiendo la pregunta." },
            { "abre el navegador", () => { 
                return  irAPaginaWeb();
            }
            }

        };

        private static string irAPaginaWeb()
        {
            Console.Write("Para mas facilidad solo escribe el nombre de la pagina como por ejemplo 'google', yo completare el resto por ti.");
            // Hace que el objeto hable
            synthesizer.Speak("Para mas facilidad solo escribe el nombre de la pagina como por ejemplo 'google', yo completare el resto por ti.");

            Console.WriteLine("\nIngresa informacion: ");
            string url = Console.ReadLine();

            string chromePath = Path.Combine(Environment.GetEnvironmentVariable("ProgramFiles"), "Google\\Chrome\\Application\\chrome.exe");
            Process.Start(chromePath, "https://www." + url + ".com");
            synthesizer.Speak("Abriendo " + url);
            return $"Abriendo {url}";
        }
    }
}
