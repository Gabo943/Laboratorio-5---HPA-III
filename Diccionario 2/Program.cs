namespace Diccionario_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Supongamos que estas son las cabeceras (las llaves de nuestro diccionario)
            Dictionary<string, object> misCabeceras = new Dictionary<string, object>();
            misCabeceras.Add("ID", 1);
            misCabeceras.Add("Usuario", "Irina");
            misCabeceras.Add("Rol", "Administrador");

            // Aquí recorremos la colección con el foreach
            foreach (var item in misCabeceras.Keys)
            {
                Console.WriteLine(item);
            }
        }
    }
}
