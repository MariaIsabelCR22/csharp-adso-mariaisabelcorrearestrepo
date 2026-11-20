
using Inventario.Modelos;

namespace Inventario.Escritorio;

public partial class FormProducto : Form
{
    public Producto? ProductoCreado { get; private set; }

    private readonly Producto? _productoOriginal;

    public FormProducto(Producto? producto = null)
    {
        InitializeComponent();

        _productoOriginal = producto;

        btnGuardar.Click += btnGuardar_Click;

        if (_productoOriginal != null)
        {
            Text = "Editar producto";

            txtCodigo.Text = _productoOriginal.Codigo;
            txtCodigo.Enabled = false;

            txtNombre.Text = _productoOriginal.Nombre;
            nudPrecio.Value = _productoOriginal.Precio;
            nudStock.Value = _productoOriginal.Stock;
        }
        else
        {
            Text = "Agregar producto";
        }
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        errorProvider1.Clear();

        try
        {
            if (_productoOriginal == null)
            {
                ProductoCreado = new Producto(
                    txtCodigo.Text,
                    txtNombre.Text,
                    nudPrecio.Value,
                    (int)nudStock.Value
                );
            }
            else
            {
                ProductoCreado = new Producto(
                    _productoOriginal.Codigo,
                    txtNombre.Text,
                    nudPrecio.Value,
                    _productoOriginal.Stock
                );
            }

            DialogResult = DialogResult.OK;
        }
        catch (ArgumentException ex)
        {
            ProductoCreado = null;
            errorProvider1.SetError(btnGuardar, ex.Message);
        }
    }
}
