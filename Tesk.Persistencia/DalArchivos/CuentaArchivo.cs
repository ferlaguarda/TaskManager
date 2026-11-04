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

        private IFileProvider _fileProvider = new FileProviders.JsonFileProvider();


        public int GuardarCuenta(Cuenta cuenta)
        {
            List<Cuenta> cuentas = LeerCuentas();
            cuentas.Add(cuenta);
            _fileProvider.GuardarRegistros(filePath, cuentas);
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
            return _fileProvider.LeerRegistros<Cuenta>(filePath);
        }
    }

}
