using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//var products = new List<string> { "لپتاپ", "موبایل", "کتاب" };
var products = new List<string> { "لپتاپ", "موبایل", "کتاب", "تبلت" };

app.MapGet("/products", () => products);

app.MapPost("/products", (string newProduct) =>
{
    products.Add(newProduct);
    return Results.Ok(newProduct);
});

app.Run("http://0.0.0.0:5000");
