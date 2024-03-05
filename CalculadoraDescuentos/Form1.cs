using System;
using System.Windows.Forms;

namespace CalculadoraDescuentos
{
    public partial class Form1 : Form
    {
        Descuento descuento = new Descuento();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            // TODO: Implementar el input del Cupon y aplicarlo a los respectivos métodos

            try
            {
                bool camposValidos1 = ((txtNom_Producto1.Text != "") && (float.Parse(txtPrecio_Producto1.Text) > 0) && (int.Parse(txtCant_Producto1.Text) > 0));
                bool camposValidos2 = ((txtNom_Producto2.Text != "") && (float.Parse(txtPrecio_Producto2.Text) > 0) && (int.Parse(txtCant_Producto2.Text) > 0));
                Producto producto;
                Producto producto2;

                // TODO: Cupón debe ser OPCIONAL

                if (camposValidos1 && !camposValidos2)
                {
                    producto = new Producto(txtNom_Producto1.Text, float.Parse(txtPrecio_Producto1.Text), int.Parse(txtCant_Producto1.Text), txtCupon.Text);

                    float descuentoCantidad = 0;
                    descuentoCantidad = descuento.descuentoPorCantidad(producto.Precio, producto.Cantidad, producto.Cupon);

                    MessageBox.Show($"El nombre del producto es: {producto.Nombre}\n" +
                                    $"El precio original del producto es: {producto.Precio}" +
                                    $"\nEl descuento total es: {descuentoCantidad}");
                }


                // TODO: Cupón debe ser OPCIONAL

                if (camposValidos2 && !camposValidos1)
                {
                    producto2 = new Producto(txtNom_Producto2.Text, float.Parse(txtPrecio_Producto2.Text), int.Parse(txtCant_Producto2.Text), txtCupon.Text);
                    float descuentoCantidad = 0;
                    descuentoCantidad = descuento.descuentoPorCantidad(producto2.Precio, producto2.Cantidad, producto2.Cupon);

                    MessageBox.Show($"El nombre del producto es: {producto2.Nombre}\n" +
                                    $"El precio original del producto es: {producto2.Precio}" +
                                    $"\nEl descuento total es: {descuentoCantidad}");
                }

                if (camposValidos1 && camposValidos2)
                {
                    producto = new Producto(txtNom_Producto1.Text, float.Parse(txtPrecio_Producto1.Text), int.Parse(txtCant_Producto1.Text), txtCupon.Text);
                    producto2 = new Producto(txtNom_Producto2.Text, float.Parse(txtPrecio_Producto2.Text), int.Parse(txtCant_Producto2.Text), txtCupon.Text);


                    float descuentoPorCombinacion = 0;
                    descuentoPorCombinacion = descuento.descuentoCombinacionPrenda(producto, producto2, txtCupon.Text);

                    MessageBox.Show($"El nombre del primer producto es: {producto.Nombre}\n" +
                                    $"El precio original del primer producto es: {producto.Precio}\n" +
                                    $"El nombre del segundo producto es: {producto2.Nombre}\n" +
                                    $"El precio original del segundo producto es: {producto2.Precio}\n" +
                                    $"\nEl descuento total es: {descuentoPorCombinacion}");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valida la información suministrada en los campos. ", "Revisar Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
