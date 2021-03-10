using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApplicatie
{
    public static class StringExtention
    {
        public static int AantalWoorden(this string waarde)
        {
            string[] aantalWoorden = waarde.Split(' ');
            return aantalWoorden.Length;
        }
    }
}
