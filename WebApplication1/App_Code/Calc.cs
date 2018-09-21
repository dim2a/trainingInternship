using System;

namespace WebApplication1.App_Code
{
    public class Calc
    {

        public string Calculate(double a, double b, double c)
        {
            double x1;
            double x2;
            double d = b * b - 4 * a * c;
            if (a == 0)
            {
                return $"Неправильно введены данные, значение 'а' не может быть равным нулю";
            }
            if (d >= 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return $"X<sub>1</sub> = {x1}; X<sub>2</sub> = {x2};";
            }
            else
            {
                double rp; //RealPart
                double ip; //ImaginaryPart
                rp = (-b / (2 * a));
                ip = ((Math.Sqrt(d * (-1))) / (2 * a));
                return $"X<sub>1</sub> = {rp}+{ip}*i; X<sub>2</sub> = {rp}-{ip}*i;";
            }
        }
       
    }
}