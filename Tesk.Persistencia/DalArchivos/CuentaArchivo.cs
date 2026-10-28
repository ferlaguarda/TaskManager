using Task.Entities;
using Tesk.Persistencia.Interfaces;

namespace Tesk.Persistencia.DalArchivos
{
    public class CuentaArchivo : ICuenta
    {
        public int GuardarCuenta(Cuenta cuenta)
        {
            List<Cuenta> cuentas = new List<Cuenta>() { cuenta };
            //List<Cuenta> cuentas1 = new List<Cuenta>();
            //cuentas1.Add(cuenta);
            //List<Cuenta> cuentas21 = [cuenta];
            var filePath = Path.Combine(Constantes.RUTA_ARCHIVOS, $"{Constantes.ARCHIVO_CUENTAS}.json");
            var fileContent = System.Text.Json.JsonSerializer.Serialize(cuentas);
            File.WriteAllText(filePath, fileContent);
            return 1;
        }

        public Cuenta? BuscarCuentaPorOwner(string correo)
        {
            throw new NotImplementedException();
        }
    }
}
