using System;

namespace LeetcodePractice.Easy
{
    /*20. Valid Parentheses
        Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        An input string is valid if:
        Open brackets must be closed by the same type of brackets.
        Open brackets must be closed in the correct order.

        Example 1:
        Input: s = "()"
        Output: true

        Example 2:
        Input: s = "()[]{}"
        Output: true

        Example 3:
        Input: s = "(]"
        Output: false

        Constraints:
        1 <= s.length <= 104
        s consists of parentheses only '()[]{}'.
    */
	public class clsValidParentheses
	{
        public bool IsValid(string s)
        {
            Stack<char> st = new Stack<char>();
            st.Push(s[0]);
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                    st.Push(s[i]);
                else if (st.Count > 0 && st.Peek() == '(' && s[i] == ')')
                    st.Pop();
                else if (st.Count > 0 && st.Peek() == '{' && s[i] == '}')
                    st.Pop();
                else if (st.Count > 0 && st.Peek() == '[' && s[i] == ']')
                    st.Pop();
                else
                    return false;
            }
            return st.Count == 0;
        }
    }
}