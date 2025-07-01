// See https://aka.ms/new-console-template for more information
// PAGINA PARA CONVERTIR JSON https://json2csharp.com/
using Tareas;
using ApiNsp;

//var api= new API();
List<tarea> listaTareas= await API.GetDatos(); //va el await porque es asincronico
foreach (var item in listaTareas)
{
    Console.WriteLine(item.Title);
} 