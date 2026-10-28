using Task.Entities;
using Task.Entities.Enumerators;
using Tesk.Persistencia.Interfaces;
using Tesk.Persistencia.DalArchivos;

namespace Task.LogicaNegocio
{
    public class ManagerAutenticacion
    {
        ICuenta _cuentaDal;

        public ManagerAutenticacion()
        {
            _cuentaDal = new CuentaArchivo();
        }

        public Cuenta CrearCuenta(string nombre, string correo, string contrasenia)
        {
            //Validar datos de entrada
            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");
            if (string.IsNullOrEmpty(correo))
                throw new ArgumentException("El E-Mail no puede estar vacío.");
            if (string.IsNullOrEmpty(contrasenia))
                throw new ArgumentException("La contraseña es requerida.");
            //TODO: Validar formato de correo electrónico
            // TODO: Validar formato de contraseña (mínimo 8 caracteres,
            // al menos una letra mayúscula, una letra minúscula y un número).
            // Investigar como aplicarlo con Expresiones regulares (Regex) en C#.

            //Validar existencia de cuenta con el mismo correo
            
            
            var nuevaCuenta = new Cuenta()
            {
                Owner = new Administrador()
                {
                    Nombre = nombre,
                    Email = correo,
                    Password = contrasenia
                },
                TipoCuenta = TipoCuenta.Personal
            };
            _cuentaDal.GuardarCuenta(nuevaCuenta);
            return nuevaCuenta;
        }

    }
}
