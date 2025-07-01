using System.Text.Json; // esto tambien
using System.Text.Json.Serialization; // usamos esto
using Tareas; // usamos la clase de tareas
namespace ApiNsp // noimbre del namespace
{ // lllave de abertura
    public static class API{ // static porque no requiere crear instancia
        
        public static async Task<List<tarea>> GetDatos() // getDato nombre de la funcion EL METODO DEBE SER STATIC PQ LA CLASE LO ES
        {
            var url = "https://jsonplaceholder.typicode.com/todos/"; // url de la api
            HttpClient client = new HttpClient(); // creamos el objeto de httpClient
            HttpResponseMessage response = await client.GetAsync(url);  // obtiene los datos de la api
            response.EnsureSuccessStatusCode(); // avisa si llega algo o no
            string responseBody = await response.Content.ReadAsStringAsync(); // pasa a string los datos obtenidos en response
            List<tarea> listTarea = JsonSerializer.Deserialize<List<tarea>>(responseBody); // transforma los datos del stirng al objeto usando la deserializacion
            return listTarea; // retorna la lista de tarea
         } // lave de cierre
    } // llave de cierre
}