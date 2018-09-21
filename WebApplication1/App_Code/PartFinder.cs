using System;

namespace WebApplication1.App_Code
{
    public class PartFinder
    {
        public void Part(string line, out double a, out double b, out double c)
        {
            a = 0;
            b = 0;
            c = 0;
            String[] inputLine = line.Split(new char[] { '/' });
            
            for (int i = 1; i < inputLine.Length; i++)
            {
                if (inputLine[i - 1].Contains(".php"))
                {
                    a = double.Parse(inputLine[i]);
                    if (i < inputLine.Length - 1)
                    {
                        b = double.Parse(inputLine[i + 1]);
                        if (i < inputLine.Length - 2)
                        {
                            c = double.Parse(inputLine[i + 2]);
                        }
                    }
                }
            }           
        }
    }
}