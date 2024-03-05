namespace CalculadoraDescuentos
{
    public class Producto
    {
        public Producto(string nombre, float precio, int cantidad, string cupon)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.Cupon = cupon;
        }
        public string Nombre { get; set; }

        public float Precio { get; set; }

        public int Cantidad { get; set; }

        public string Cupon { get; set; } = "";

        public bool validarObjeto()
        {
            return (Nombre != "") && (Precio > 0) && (Cantidad > 0);
        }
    }
}
