using System;
using System.Collections.Generic;

namespace CliLayoutRenderTools
{
    class Program
    {
        static void Main(string[] args)
        {
            var rd = new Renderer()
            {
                FrameWidth = 70
            };

            rd.AddMultipleVisualResources(new Dictionary<string, string>()
            {
                {
                    "intro",
                    "Bienvenue ! C'est cool "
                },
            });

            string test = rd.GetResourceRepr("5*[intro]");

            var welcomeScreen = new ScreenTemplate();

        }
    }
}
