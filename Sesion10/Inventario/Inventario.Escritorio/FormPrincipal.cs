
using Inventario.Datos;
using Inventario.Modelos;
using Inventario.Servicios;

namespace Inventario.Escritorio;

public partial class FormPrincipal : Form
{
    private readonly ServicioInventario _servicio =
        new(new RepositorioJson("inventario.json"));

    public FormPrincipal()
    {
        InitializeComponent();

        txtBuscar.TextChanged += txtBuscar_TextChanged;
        dgvProductos.DataBindingComplete += dgvProductos_DataBindingComplete;

        btnAgregar.Click += btnAgregar_Click;
        btnVender.Click += btnVender_Click;
        btnStock.Click += btnStock_Click;
        btnEliminar.Click += btnEliminar_Click;
        btnReportes.Click += btnReportes_Click;

        CargarProductos();
        dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
    }
    private void btnReportes_Click(object? sender, EventArgs e)
    {
        using var form = new FormReportes(_servicio);

        form.ShowDialog(this);
    }
    private void dgvProductos_CellDoubleClick(
    object? sender,
    DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
            return;

        Producto? producto = Seleccionado();

        if (producto == null)
            return;

        using var form = new FormProducto(producto);

        if (form.ShowDialog(this) != DialogResult.OK ||
            form.ProductoCreado == null)
        {
            return;
        }

        try
        {
            _servicio.Actualizar(form.ProductoCreado);

            CargarProductos();

            MessageBox.Show(
                "Producto actualizado correctamente.",
                "Inventario",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error al actualizar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    private void CargarProductos(List<Producto>? productos = null)
    {
        dgvProductos.DataSource = null;

        if (productos == null)
        {
            productos = _servicio.Listar();
        }

        productos = productos.OrderBy(p => p.Codigo).ToList();

        dgvProductos.DataSource = productos;

        decimal total = _servicio.Listar()
            .Sum(p => p.Precio * p.Stock);

        lblValor.Text = $"Valor total del inventario: {total:C0}";
    }

    private Producto? Seleccionado()
    {
        return dgvProductos.CurrentRow?.DataBoundItem as Producto;
    }

    private void txtBuscar_TextChanged(object? sender, EventArgs e)
    {
        var productos = _servicio.BuscarPorTexto(txtBuscar.Text);

        CargarProductos(productos);
    }

    private void dgvProductos_DataBindingComplete(
        object? sender,
        DataGridViewBindingCompleteEventArgs e)
    {
        if (dgvProductos.Columns["Precio"] is DataGridViewColumn precio)
        {
            precio.DefaultCellStyle.Format = "C0";
        }

        foreach (DataGridViewRow fila in dgvProductos.Rows)
        {
            if (fila.DataBoundItem is Producto producto)
            {
                if (producto.Stock < 5)
                {
                    fila.DefaultCellStyle.BackColor = Color.MistyRose;
                }
                else
                {
                    fila.DefaultCellStyle.BackColor =
                        dgvProductos.DefaultCellStyle.BackColor;
                }
            }
        }
    }

    private void btnAgregar_Click(object? sender, EventArgs e)
    {
        using var form = new FormProducto();

        if (form.ShowDialog(this) != DialogResult.OK ||
            form.ProductoCreado == null)
        {
            return;
        }

        try
        {
            _servicio.Agregar(form.ProductoCreado);

            CargarProductos();

            MessageBox.Show(
                "Producto agregado correctamente.",
                "Inventario",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(
                ex.Message,
                "No se pudo agregar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    private void btnVender_Click(object? sender, EventArgs e)
    {
        Producto? producto = Seleccionado();

        if (producto == null)
        {
            MessageBox.Show("Selecciona un producto.");

            return;
        }

        try
        {
            _servicio.Vender(
                producto.Codigo,
                (int)nudCantidad.Value);

            CargarProductos();

            MessageBox.Show(
                "Venta realizada correctamente.",
                "Inventario",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (StockInsuficienteException ex)
        {
            MessageBox.Show(
                ex.Message,
                "Stock insuficiente",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    private void btnStock_Click(object? sender, EventArgs e)
    {
        Producto? producto = Seleccionado();

        if (producto == null)
        {
            MessageBox.Show("Selecciona un producto.");

            return;
        }

        try
        {
            _servicio.AgregarStock(
                producto.Codigo,
                (int)nudCantidad.Value);

            CargarProductos();

            MessageBox.Show(
                "Stock actualizado correctamente.",
                "Inventario",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    private void btnEliminar_Click(object? sender, EventArgs e)
    {
        Producto? producto = Seleccionado();

        if (producto == null)
        {
            MessageBox.Show("Selecciona un producto.");

            return;
        }

        DialogResult respuesta = MessageBox.Show(
            $"Deseas eliminar el producto {producto.Nombre}?",
            "Confirmar eliminacion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (respuesta == DialogResult.Yes)
        {
            try
            {
                _servicio.Eliminar(producto.Codigo);

                CargarProductos();

                MessageBox.Show("Producto eliminado correctamente.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
