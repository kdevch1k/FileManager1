// ConsoleKey key;
//         while ((key = Console.ReadKey(true).Key) != ConsoleKey.Enter)
//         {
//             switch (key)
//             {
//                 case ConsoleKey.UpArrow:
//                     Console.WriteLine("Вверх");
//                     break;
//                 case ConsoleKey.DownArrow:
//                     Console.WriteLine("Вниз");
//                     break;
//                 case ConsoleKey.RightArrow:
//                     Console.WriteLine("Вправо");
//                     break;
//                 case ConsoleKey.LeftArrow:
//                     Console.WriteLine("Влево");
//                     break;
//             }
//         }
using System.Collections;
using System.Net;
using System.Text;


public class InputHandler
{
     public void KeyListen()
    {
        ConsoleKeyInfo input;
        do{
            input = Console.ReadKey(true);

            StringBuilder output = new StringBuilder(
                        String.Format("{0}", input.Key.ToString()));
            bool modifiers = false;

            if (input.Modifiers.HasFlag(ConsoleModifiers.Alt)) {
                output.Append(", together with " + ConsoleModifiers.Alt.ToString());
                modifiers = true;
            }
            if (input.Modifiers.HasFlag(ConsoleModifiers.Control))
            {
                if (modifiers) {
                output.Append(" and ");
                }
                else {
                output.Append(", together with ");
                modifiers = true;
                }
                output.Append(ConsoleModifiers.Control.ToString());
            }
            if (input.Modifiers.HasFlag(ConsoleModifiers.Shift))
            {
                if (modifiers) {
                output.Append(" and ");
                }
                else {
                output.Append(", together with ");
                modifiers = true;
                }
                output.Append(ConsoleModifiers.Shift.ToString());
            }
            output.Append(".");
            Console.WriteLine(output.ToString());
            Console.WriteLine();
        } while (input.Key != ConsoleKey.Escape);
    }
}
