namespace Lab12_LiliyBukhtik
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
                       

            app.Run(async (context) =>
            {                
                context.Response.ContentType = "text/html; charset=utf-8";
                var stringBuilder = new System.Text.StringBuilder();

                stringBuilder.Append($"<h1>Name: Lilia Bukhtik</h1>"); 
                stringBuilder.Append($"<h2>Date: {DateTime.Now}</h2>");
                stringBuilder.Append($"<h3>Environment: {builder.Environment.EnvironmentName}</h3>");
                stringBuilder.Append($"<h3>ApplicationName: {builder.Environment.ApplicationName}</h3>");
                stringBuilder.Append($"<h2>Host: {context.Request.Host}</h2>");
                stringBuilder.Append($"<h1>Protocol: {context.Request.Protocol}</h1>");

                await context.Response.WriteAsync(stringBuilder.ToString());
            });
            app.Run();
        }
    }
}