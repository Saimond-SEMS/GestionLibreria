namespace Libreria
{
    internal static class Program
    {
        public static List<Producto> productos = new();
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static bool RegistrarProducto( Producto _producto )
        {
			if ( CodigoEstaDisponible(_producto.codigo) )
			{
                productos.Add(_producto);
                return true;
			}
            return false;
		}

        public static bool CodigoEstaDisponible( string _codigo)
        {
			foreach (Producto producto in productos)
			{
				if ( producto.codigo == _codigo)
				{
                    return false;
				}
			}
            return true;
		}
        public static Producto? BuscarProductoPorCodigo( string _codigo)
        {
			foreach (Producto producto in productos)
			{
				if ( producto.codigo == _codigo)
				{
					return producto;
				}
			}
            return null;
		}
    }
}