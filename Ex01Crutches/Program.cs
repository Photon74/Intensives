using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01Crutches
{
    class Program
    {
        static void DrawText(string text, int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(text);
        }

        static void Main(string[] args)
        {
            // Пишу

            //DrawText("Intensive C# Demo text", 629, 360);

            #region Explanation

            // 629
            // пусть ширина экрана будет 1280px, тогда середина 1280 / 2 - 640
            // в тексте "Intensive C# Demo text" 22 символа, чтобы отцентровать
            // по ширине, нужно от центральной точки отступить половину выводимых символов
            // т.к. ширина символа фиксированна. Таким образом 1280 / 2 - 11 = 629
            //
            // пусть высота экрана будет 720px
            // 720 / 2 = 360

            // https://ru.wikipedia.org/wiki/Магическое_число_(программирование)
            #endregion

            // Как лучше
            string caption = "Intensive C# Demo text", testCaption = String.Empty;
            int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
            int screenHeightPosition = Console.WindowHeight / 2;

            DrawText(caption, screenWidthPosition, screenHeightPosition);


            DrawText(
                //text: caption, 
                text: testCaption,
                left: screenWidthPosition,
                top: screenHeightPosition
                );

            string label = "";              // 111
            string address = String.Empty;  // 222

            int age = 123;      /// 111
            int salary;         /// 222
            int house = 182;    /// 333


        }
    }
}
