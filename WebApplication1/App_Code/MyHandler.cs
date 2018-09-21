using System.Web;
using WebApplication1.App_Code;

public class MyHandler : IHttpHandler
{
    public MyHandler(){}

    public bool IsReusable => false;

    public void ProcessRequest(HttpContext context)
    {
        HttpRequest request = context.Request;
        HttpResponse response = context.Response;
        double a = 0;
        double b = 0;
        double c = 0;
        string inputLine = request.Url.ToString();
        PartFinder pf = new PartFinder();
        Calc calc = new Calc();

        pf.Part(inputLine, out a, out b, out c);

        response.Write("<html>");
        response.Write("<body>");
        response.Write("<h1>Hello</h1>");
        response.Write("<hr/>");
        response.Write($"a = {a}, b = {b}, c = {c}<br/>");
        response.Write(calc.Calculate(a, b, c));
        response.Write("<hr/>");
        response.Write("</body>");
        response.Write("</html>");
        
    }

    
        
    
}
