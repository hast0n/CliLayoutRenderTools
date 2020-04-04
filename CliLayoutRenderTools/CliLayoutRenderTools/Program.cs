using System.Collections.Generic;
using CliLayoutRenderTools.Demo;

namespace CliLayoutRenderTools
{
    class App
    {
        static void Main(string[] args)
        {
            Renderer console = new Renderer() { FrameWidth = 70 };

            console.SetDefaultResources();
            console.AddVisualResources(new Dictionary<string, string>() {
                {
                    "appName",
                    "--- PROJECT MANAGER ---"
                },
                {
                    "userStatus",
                    "$userStatus"
                }
            });
            


            LoginPage LoginView = new LoginPage(console.VisualResources, console.SplitChar);

            HomePage homePage = new HomePage(console.VisualResources, new Dictionary<string, string>()
            {
                {"userName", "Martin" },
                {"qqch", "ceci est bleu par exemple" }
            });

            SelectorTestView selectorTestView = new SelectorTestView(console.VisualResources, console.SplitChar);



            console.Render(LoginView);

            console.Render(homePage);

            console.Render(selectorTestView);
        }


    }
}

// TODO: Lock edition to active field
// TODO: Press Return to edit next field
// TODO:    --> add "completed" attribute to modifierDictionary for inputs
// TODO: Empty active field & backspace to access previous one