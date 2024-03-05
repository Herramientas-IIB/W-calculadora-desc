using System;

namespace CalculadoraDescuentos
{
    public class Descuento
    {

        public float descuentoPorCantidad(float precio, int cantidad, string cupon)
        {
            float totalDescuento = 0;

            if (!string.IsNullOrEmpty(cupon)){
                totalDescuento = cantidad > 1 ? Convert.ToInt64(precio * 0.50) : Convert.ToInt64(precio * 0.30);
            } else {
                totalDescuento = cantidad > 1 ? Convert.ToInt64(precio * 0.35) : Convert.ToInt64(precio * 0.20);
            }
            return totalDescuento;
        }

        public float descuentoCombinacionPrenda(Producto producto1 = null, Producto producto2 = null, string cupon = "")
        {
            float descuentoTotal = 0;
            if (producto1 != null && producto2 != null)
            {
                if (producto1.Nombre == "Camisa" && producto2.Nombre == "Pantalon")
                {
                    if ( !string.IsNullOrEmpty(cupon) ){
                        descuentoTotal = Convert.ToInt64((producto1.Precio + producto2.Precio) * 0.6);
                    } else {
                        descuentoTotal = Convert.ToInt64((producto1.Precio + producto2.Precio) * 0.4);
                    }
                }
            }
            return descuentoTotal;
        }
    }
}
