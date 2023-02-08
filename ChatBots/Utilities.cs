using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace ChatBots
{
    internal class Utilities
    {
        // Crea un objeto de síntesis de voz
        private static SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public static void OnlySpeak(string value)
        {
            synthesizer.Speak(value);
        }

        public static void SpeakWithText(string value)
        {
            Console.WriteLine(value);
            synthesizer.Speak(value);
        }
    }
}
