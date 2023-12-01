using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

public class RegistroSolicitudesMiddleware
{
    private readonly RequestDelegate _next;

    public RegistroSolicitudesMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        RegistrarSolicitudAntes(context);

        await _next(context);

        RegistrarSolicitudDespues(context);
    }

    private void RegistrarSolicitudAntes(HttpContext context)
    {
        Console.WriteLine($"Solicitud recibida en {DateTime.Now}: {context.Request.Path}");
    }

    private void RegistrarSolicitudDespues(HttpContext context)
    {
        Console.WriteLine($"Solicitud completada en {DateTime.Now}: {context.Request.Path}");
    }
}
