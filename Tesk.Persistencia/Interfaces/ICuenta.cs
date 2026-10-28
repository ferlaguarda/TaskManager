using Task.Entities;

namespace Tesk.Persistencia.Interfaces
{
    public interface ICuenta
    {
        int GuardarCuenta(Cuenta cuenta);

        Cuenta? BuscarCuentaPorOwner(string correo);
    }
}
