using System.Web;
using WebApplication1.App_Code;

public class FormHandler : IHttpHandler
{
    public bool IsReusable => false;

    public void ProcessRequest(HttpContext context)
    {
        HttpRequest request = context.Request;
        HttpResponse response = context.Response;
        double a = double.Parse(request.QueryString["a"]);
        double b = double.Parse(request.QueryString["b"]);
        double c = double.Parse(request.QueryString["c"]);
        Calc calc = new Calc();
        response.Write($"<html><body><h1>{calc.Calculate(a, b, c)}</h1></body></html>");
    }
}
