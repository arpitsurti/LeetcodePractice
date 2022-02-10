using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodePractice.Easy
{
    /*1678. Goal Parser Interpretation
     * You own a Goal Parser that can interpret a string command. The command consists of an alphabet of "G", "()" and/or "(al)" in some order. The Goal Parser will interpret "G" as the string "G", "()" as the string "o", and "(al)" as the string "al". The interpreted strings are then concatenated in the original order.
        Given the string command, return the Goal Parser's interpretation of command.

        Example 1:
        Input: command = "G()(al)"
        Output: "Goal"
        Explanation: The Goal Parser interprets the command as follows:
        G -> G
        () -> o
        (al) -> al
        The final concatenated result is "Goal".

        Example 2:
        Input: command = "G()()()()(al)"
        Output: "Gooooal"

        Example 3:
        Input: command = "(al)G(al)()()G"
        Output: "alGalooG"
 
        Constraints:

        1 <= command.length <= 100
        command consists of "G", "()", and/or "(al)" in some order.
    */
    class clsGoalParserInterpretation
    {
        public string Interpret(string command)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while (i != command.Length)
            {
                if (command[i] == 'G')
                    sb.Append(command[i]);
                else if (command[i] == '(' && command[i + 1] == ')')
                {
                    sb.Append("o");
                    i++;
                }
                else
                {
                    sb.Append("al");
                    i += 3;
                }
                i++;
            }
            return sb.ToString();
        }
    }
}
