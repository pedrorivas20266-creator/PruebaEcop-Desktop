namespace PruebaEcopDesktop.Views.Interfaces
{
    public interface ILoginView
    {
        string NombreUsuario { get; }
        string ClaveUsuario { get; }
        void MostrarError(string mensaje);
        void MostrarCargando(bool mostrar);
        void CerrarFormulario();
        void LimpiarCampos();
    }
}