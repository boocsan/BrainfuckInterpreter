using System;
using System.Collections.Generic;
using System.Linq;

namespace BrainfuckInterpreter.Core
{
    public static class Interpreter
    {
        public static string Run(string input)
        {
            var pointer = 0;
            var memory = Enumerable.Repeat(0, 256).ToArray();
            var output = new List<char>();

            for (var i = 0; i < input.Length; i++)
            {
                var c = input[i];
                // ReSharper disable once ConvertIfStatementToSwitchStatement
                if (input[i] == '+') memory[pointer] += 1;
                else if (input[i] == '-') memory[pointer] -= 1;
                else if (input[i] == '>') pointer++;
                else if (input[i] == '<') pointer--;
                else if (input[i] == '.') output.Add((char) memory[pointer]);
                else if (input[i] == ',') memory[pointer] = Console.Read();
                else if (input[i] == '[')
                {
                    if (memory[pointer] != 0) continue;
                    var nestCount = 1;
                    while (0 < nestCount)
                    {
                        i++;
                        if (input[i] == '[') nestCount++;
                        if (input[i] == ']') nestCount--;
                    }
                }
                else if (input[i] == ']')
                {
                    if (memory[pointer] == 0) continue;
                    var nestCount = 1;
                    while (0 < nestCount)
                    {
                        i--;
                        if (input[i] == '[') nestCount--;
                        if (input[i] == ']') nestCount++;
                    }
                }
            }

            return output.Aggregate("", (c, cc) => c + cc).Trim();
        }
    }
}
