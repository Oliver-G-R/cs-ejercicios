# Ejercicios de C#

## Antes de empezar  
El proyecto esta construido con dotnet en su version 5,
para evitar problemas al iniciar se agrego  
a **ejercicios-c#.csproj** una linea que hace referencia al 
punto de entrada.

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <StartupObject>ejercicios_c_.Program</StartupObject> <!-- Aqí -->
  </PropertyGroup>

</Project>
```  
Esto para no ocacionar problemas con los demas archivos que contienen el mismo punto de entrada.  

## Iniciar 
Para iniciar el proyecto se deben ejecutar los siguientes comandos:

```bash
cp Ejercicios/ejercicio.cs Program.cs
```  
Despues de esto solo asegurate de quitar el número   
que se encuentra en el espacio de nombres de Program.cs.

```csharp
using System;

namespace ejercicios_c_1 // => ejercicios_c_ 
{
    class Program
    {
    }
}
```

De la forma mas manual, solo toma todo lo que tiene el ejercicio que quieres ejecutar,
y borra el número a la derecha  
en el nombre de espacio, y ejecuta el comando:

```bash
dotnet run
```


