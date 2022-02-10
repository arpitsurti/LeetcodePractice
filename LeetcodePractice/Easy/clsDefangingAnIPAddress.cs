﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodePractice.Easy
{
    /*1108. Defanging an IP Address
     * Given a valid (IPv4) IP address, return a defanged version of that IP address.

    A defanged IP address replaces every period "." with "[.]".

    Example 1:
    Input: address = "1.1.1.1"
    Output: "1[.]1[.]1[.]1"

    Example 2:
    Input: address = "255.100.50.0"
    Output: "255[.]100[.]50[.]0"
    
    Constraints:
    The given address is a valid IPv4 address.
    */
    class clsDefangingAnIPAddress
    {
        public string DefangIPaddr(string address)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == '.')
                    sb.Append("[.]");
                else
                    sb.Append(address[i]);
            }
            return sb.ToString();
        }
    }
}
