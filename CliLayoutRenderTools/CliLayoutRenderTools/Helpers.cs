using System;
using System.Collections.Generic;
using System.Text;

namespace CliLayoutRenderTools
{
    // A simple class used to help the Renderer to frame content
    static class RendererHelper
    {
        public static string Pad(this string line, int padding)
        {
            return $"{new string(' ', padding)}{line}";
        }

        public static bool IsOdd(this int value)
        {
            return value % 2 != 0;
        }
    }
}
