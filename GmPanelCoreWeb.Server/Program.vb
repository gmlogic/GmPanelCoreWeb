
' Add services to the container.

' Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

' Configure the HTTP request pipeline.
''' Cannot convert GlobalStatementSyntax, CONVERSION ERROR: Conversion for GlobalStatement not implemented, please report this issue in 'var builder = Microsoft.Asp...' at character 0
''' 
''' 
''' Input:
''' var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);
''' 
''' 
''' Cannot convert GlobalStatementSyntax, CONVERSION ERROR: Conversion for GlobalStatement not implemented, please report this issue in 'builder.Services.AddControl...' at character 119
''' 
''' 
''' Input:
''' 
''' // Add services to the container.
''' 
''' builder.Services.AddControllers();
''' 
''' 
''' Cannot convert GlobalStatementSyntax, CONVERSION ERROR: Conversion for GlobalStatement not implemented, please report this issue in 'builder.Services.AddEndpoin...' at character 245
''' 
''' 
''' Input:
''' // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
''' builder.Services.AddEndpointsApiExplorer();
''' 
''' 
''' Cannot convert GlobalStatementSyntax, CONVERSION ERROR: Conversion for GlobalStatement not implemented, please report this issue in 'builder.Services.AddSwagger...' at character 290
''' 
''' 
''' Input:
''' builder.Services.AddSwaggerGen();
''' 
''' 
''' Cannot convert GlobalStatementSyntax, CONVERSION ERROR: Conversion for GlobalStatement not implemented, please report this issue in 'var app = builder.Build();' at character 327
''' 
''' 
''' Input:
''' 
''' var app = builder.Build();
''' 
''' 
''' Cannot convert GlobalStatementSyntax, CONVERSION ERROR: Conversion for GlobalStatement not implemented, please report this issue in 'app.UseDefaultFiles();' at character 357
''' 
''' 
''' Input:
''' 
''' app.UseDefaultFiles();
''' 
''' 
''' Cannot convert GlobalStatementSyntax, CONVERSION ERROR: Conversion for GlobalStatement not implemented, please report this issue in 'app.UseStaticFiles();' at character 381
''' 
''' 
''' Input:
''' app.UseStaticFiles();
''' 
''' 
''' Cannot convert GlobalStatementSyntax, CONVERSION ERROR: Conversion for GlobalStatement not implemented, please report this issue in 'if (app.Environment.IsDevel...' at character 447
''' 
''' 
''' Input:
''' 
''' // Configure the HTTP request pipeline.
''' if (app.Environment.IsDevelopment())
''' {
'''     app.UseSwagger();
'''     app.UseSwaggerUI();
''' }
''' 
''' 
''' Cannot convert GlobalStatementSyntax, CONVERSION ERROR: Conversion for GlobalStatement not implemented, please report this issue in 'app.UseHttpsRedirection();' at character 541
''' 
''' 
''' Input:
''' 
''' app.UseHttpsRedirection();
''' 
''' 
''' Cannot convert GlobalStatementSyntax, CONVERSION ERROR: Conversion for GlobalStatement not implemented, please report this issue in 'app.UseAuthorization();' at character 571
''' 
''' 
''' Input:
''' 
''' app.UseAuthorization();
''' 
''' 
''' Cannot convert GlobalStatementSyntax, CONVERSION ERROR: Conversion for GlobalStatement not implemented, please report this issue in 'app.MapControllers();' at character 598
''' 
''' 
''' Input:
''' 
''' app.MapControllers();
''' 
''' 
''' Cannot convert GlobalStatementSyntax, CONVERSION ERROR: Conversion for GlobalStatement not implemented, please report this issue in 'app.MapFallbackToFile("/ind...' at character 623
''' 
''' 
''' Input:
''' 
''' app.MapFallbackToFile("/index.html");
''' 
''' 
''' Cannot convert GlobalStatementSyntax, CONVERSION ERROR: Conversion for GlobalStatement not implemented, please report this issue in 'app.Run();' at character 664
''' 
''' 
''' Input:
''' 
''' app.Run();
''' 
''' 
Imports Microsoft.AspNetCore.Builder
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting

Module Program
    Sub Main(args As String())
        Debug.WriteLine("ASPNETCORE_HTTPS_PORT = " & Environment.GetEnvironmentVariable("ASPNETCORE_HTTPS_PORT"))
        Debug.WriteLine("ASPNETCORE_URLS = " & Environment.GetEnvironmentVariable("ASPNETCORE_URLS"))
        Debug.WriteLine("DEV_SERVER_PORT = " & Environment.GetEnvironmentVariable("DEV_SERVER_PORT"))

        Console.WriteLine("ASPNETCORE_HTTPS_PORT = " & Environment.GetEnvironmentVariable("ASPNETCORE_HTTPS_PORT"))
        Console.WriteLine("ASPNETCORE_URLS = " & Environment.GetEnvironmentVariable("ASPNETCORE_URLS"))
        Console.WriteLine("DEV_SERVER_PORT = " & Environment.GetEnvironmentVariable("DEV_SERVER_PORT"))

        Dim builder = WebApplication.CreateBuilder(args)

        builder.Services.AddControllers()
        builder.Services.AddEndpointsApiExplorer()
        builder.Services.AddSwaggerGen()

        Dim app = builder.Build()

        If app.Environment.IsDevelopment() Then
            app.UseSwagger()
            app.UseSwaggerUI()
        End If

        app.UseRouting()
        app.MapControllers()

        app.Run()
    End Sub
End Module
