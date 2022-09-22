using ТестовоеЗаданиеОтMindBox.Class;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.MapRazorPages();
app.UseStaticFiles();
app.UseDefaultFiles();

app.Map("/", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("Pages/mainPage.html");
});

app.Map("/circle",async (context) => 
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("Pages/circlePage.html");
    
});
app.Map("/triangle", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("Pages/trianglePage.html");

});
app.Map("/square", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("Pages/squarePage.html");

});
app.Map("/trapeze", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("Pages/trapezePage.html");

});
app.Map("/cylinder", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("Pages/cylinderPage.html");

});
app.Map("/other", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("Pages/otherPage.html");

});


app.Map("/answer/circle", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("Pages/answerPage.html");

    var form = context.Request.Form;
    double radiusCircle = Convert.ToDouble(form["radiusCircle"]);

    double area = AreaСalculation.CalculatingAreaOfCircle(radiusCircle);
    await context.Response.WriteAsync($"<p id=textAreaOfShape>Площадь Круга равна:{area}</p>");

});
app.Map("/answer/triangle", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("Pages/answerPage.html");

    var form = context.Request.Form;
    double firstSideTriangle = Convert.ToDouble(form["firstSideTriangle"]);
    double secondSideTriangle = Convert.ToDouble(form["secondSideTriangle"]);
    double thirdSideTriangle = Convert.ToDouble(form["thirdSideTriangle"]);

    double area = AreaСalculation.CalculatingAreaOfTriangle(firstSideTriangle, secondSideTriangle, thirdSideTriangle);
    await context.Response.WriteAsync($"<p id = textAreaOfShape> Площадь Треугольника равна:{area}</p >");

});
app.Map("/answer/square", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("Pages/answerPage.html");

    var form = context.Request.Form;
    double sideSquare = Convert.ToDouble(form["sideSquare"]);

    double area = AreaСalculation.CalculatingAreaOfSquare(sideSquare);
    await context.Response.WriteAsync($"<p id = textAreaOfShape> Площадь Квадрата равна:{area}</p >");

});
app.Map("/answer/trapeze", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("Pages/answerPage.html");

    var form = context.Request.Form;
    double firstTrapezBaseLength = Convert.ToDouble(form["firstTrapezBaseLength"]);
    double secondTrapezBaseLength = Convert.ToDouble(form["secondTrapezBaseLength"]);
    double trapezHeight = Convert.ToDouble(form["trapezHeight"]);

    double area = AreaСalculation.CalculatingAreaOfTrapeze(firstTrapezBaseLength, secondTrapezBaseLength, trapezHeight);
    await context.Response.WriteAsync($"<p id = textAreaOfShape> Площадь Трапеции равна:{area}</p >");

});
app.Map("/answer/cylinder", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("Pages/answerPage.html");

    var form = context.Request.Form;
    double radiusCylinder = Convert.ToDouble(form["radiusCylinder"]);
    double cylinderHeight = Convert.ToDouble(form["cylinderHeight"]);

    double area = AreaСalculation.CalculatingAreaOfCylinder(cylinderHeight, radiusCylinder);
    await context.Response.WriteAsync($"<p id = textAreaOfShape> Площадь Цилиндра равна:{area}</p >");

});
app.Map("/answer/other", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("Pages/answerPage.html");

    var form = context.Request.Form;
    double radius = Convert.ToDouble(form["radius"]);
    double firstSide = Convert.ToDouble(form["firstSide"]);
    double secondSide = Convert.ToDouble(form["secondSide"]);
    double thirdSide = Convert.ToDouble(form["thirdSide"]);
    double firstTrapezBase = Convert.ToDouble(form["firstTrapezBase"]);
    double secondTrapezBase = Convert.ToDouble(form["secondTrapezBase"]);
    double height = Convert.ToDouble(form["height"]);

    double areaCircle = AreaСalculation.CalculatingAreaOfCircle(radius);
    double areaTriangle = AreaСalculation.CalculatingAreaOfTriangle(firstSide, secondSide, thirdSide);
    double areaCylinder = AreaСalculation.CalculatingAreaOfCylinder(height, radius);
    double areaSquare = AreaСalculation.CalculatingAreaOfSquare(firstSide);
    double areaTrapeze = AreaСalculation.CalculatingAreaOfTrapeze(firstTrapezBase, secondTrapezBase, height);

    await context.Response.WriteAsync($"<p class=textAreaOfShape>Площадь Круга равна:{areaCircle}</p><p class=textAreaOfShape>Площадь Треугольника равна:{areaTriangle}</p><p class=textAreaOfShape>Площадь Цилиндра равна:{areaCylinder}</p><p class=textAreaOfShape>Площадь Квадрата равна:{areaSquare}</p><p class=textAreaOfShape>Площадь Трапеции равна:{areaTrapeze}</p>");

});
//await context.Response.SendFileAsync("Html/PageArray.html");

app.Run();
