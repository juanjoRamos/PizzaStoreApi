# PizzaStoreApi
Este repositorio está dedicado a mi aprendizaje y exploración de las Minimal APIs en .NET. Aquí documentaré mi progreso y compartiré los códigos que desarrolle en el camino.

Paso 1: He realizado ha sido comprobar que tenia la última versión de net 8 instalado antes de la creación del proyecto con el comando:
> dotnet --list-sdks

El siguiente paso ha sido crear un proyecto básico de apis minimas.
> dotnet new web -o PizzaStore -f net8.0

Y probamos que la creación ha sido correcta lanzando la aplicacion. Abriendo una terminal, estando en el mismo directorio de la solución.
> dotnet run

En mi caso usando el visual studio code con la configuración del launchproperties y dando click en el debug me lo lanzó en el navegador
y me mostró el "Hello World!" que tenemos el Program.cs
app.MapGet("/", () => "Hello World!");

Paso 2: Agregar Swagger para documentar los endpoints y poder visualizarlos de una forma gráfica.
Con la terminal he tenido que acceder al directorio del proyecto dónde se encuentra el PizzaStore.csproj y allí ejecutar el comando:
> dotnet add PizzaStore.csproj package Swashbuckle.AspNetCore -v 6.5.0

Se ha descargado el nugget de OpenApi con swagger, añadadido las líneas del 2 commit y he probado la aplicación. Para poder acceder
a swagger al final de la url le añadimos /swagger y nos lleva directamente.
