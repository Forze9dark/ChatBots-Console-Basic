using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBots
{
    internal class Diccionary
    {

        // Palabras a aprender.
        public static Dictionary<string, Func<string>> conocimientos = new Dictionary<string, Func<string>>()
        {
            { "hora", () => "La hora actual es " + DateTime.Now.ToString("h:mm tt") },
            { "dia", () => "Hoy es " + DateTime.Now.ToString("dddd, dd MMMM yyyy") },
            { "cual es tu nombre", () => "Soy un chatbot creado por OpenAI." },
            { "defecto", () => "Lo siento, no entiendo la pregunta." },
            { "abre el navegador", () => {
                string chromePath = Path.Combine(Environment.GetEnvironmentVariable("ProgramFiles"), "Google\\Chrome\\Application\\chrome.exe");
                Process.Start(chromePath, "https://www.google.com");
                return "Abriendo Google Chrome";
            }}

        };

    }
}
