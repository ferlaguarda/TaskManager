#region Using
using System.Text.Json;
using Task.Entities;
using Tesk.Persistencia.Interfaces; 
#endregion

namespace Tesk.Persistencia.DalArchivos
{
    public class CuentaArchivo : ICuenta
    {
        private readonly string filePath = Path
            .Combine(Constantes.RUTA_ARCHIVOS, $"{Constantes.ARCHIVO_CUENTAS}.json");
       
        public int GuardarCuenta(Cuenta cuenta)
        {
            List<Cuenta> cuentas = LeerCuentas();
            cuentas.Add(cuenta);
            //List<Cuenta> cuentas1 = new List<Cuenta>();
            //cuentas1.Add(cuenta);
            //List<Cuenta> cuentas21 = [cuenta];
            var fileContent = System.Text.Json.JsonSerializer.Serialize(cuentas);
            File.WriteAllText(filePath, fileContent);
            return 1;
        }

        public Cuenta? BuscarCuentaPorOwner(string correo)
        {
            var cuentas = LeerCuentas();
            foreach(var cuenta in cuentas)
            {
                if(cuenta.Owner.Email.Equals(correo))
                    return cuenta;
            }
            return null;
        }

        private List<Cuenta> LeerCuentas()
        {
            if (!File.Exists(filePath))
                return new List<Cuenta>();

            var fileContent = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Cuenta>>(fileContent)??
                new List<Cuenta>();
        }
    }

}
