using System;
using System.Collections.Specialized;
using System.Web;

public class MyHandler : IHttpHandler
{
    public MyHandler(){}
    public bool IsReusable
    {
        get { return false; }
    }

    public void ProcessRequest(HttpContext context)
    {
        HttpRequest request = context.Request;
        HttpResponse response = context.Response;
        int a = 0;
        int b = 0;
        int c = 0;
        //a = Convert.ToInt32(request.QueryString["a"]);
        //b = Convert.ToInt32(request.QueryString["b"]);
        //c = Convert.ToInt32(request.QueryString["c"]);        
        
        String[] inputLine = request.Url.ToString().Split(new char[] { '/' });

        for (int i=1; i <= inputLine.Length; i++)
        {
            if (inputLine[i - 1].Contains(".php"))
            {
                a = Convert.ToInt32(inputLine[i]);
                if (i < inputLine.Length - 1)
                {
                    b = Convert.ToInt32(inputLine[i + 1]);
                    if (i < inputLine.Length - 2)
                    {
                        c = Convert.ToInt32(inputLine[i + 2]);
                    }
                }                
            } 
        }        

        double d = b * b - 4 * a * c;
        double x1 = (-b + Math.Sqrt(d)) / (2 * a);
        double x2 = (-b - Math.Sqrt(d)) / (2 * a);

        response.Write("<html>");
        response.Write("<body>");
        response.Write("<h1>Hello</h1>");
        response.Write("<hr/>");
        response.Write($"a = {a}, b = {b}, c = {c}<br/>");
        response.Write($"X<sub>1</sub> = {x1}; X<sub>2</sub> = {x2};");
        response.Write("<hr/>");
        response.Write("</body>");
        response.Write("</html>");
        
    }

    
        
    
}
