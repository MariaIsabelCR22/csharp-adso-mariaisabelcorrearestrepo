
using Inventario.Modelos;
using Inventario.Servicios;

namespace Inventario.Escritorio;

public partial class FormReportes : Form
{
    public FormReportes(ServicioInventario servicio)
    {
        InitializeComponent();

        CargarReportes(servicio);
    }

    private void CargarReportes(ServicioInventario servicio)
    {
        // Productos con mayor valor total (precio por stock)
        var productosValiosos = servicio.Listar()
            .OrderByDescending(p => p.Precio * p.Stock)
            .ToList();

        dgvValiosos.DataSource = productosValiosos;

        // Productos con menos de 5 unidades
        var productosStockBajo = servicio.StockBajo();

        dgvStockBajo.DataSource = productosStockBajo;

        ConfigurarTabla(dgvValiosos);
        ConfigurarTabla(dgvStockBajo);
    }

    private void ConfigurarTabla(DataGridView tabla)
    {
        if (tabla.Columns["Precio"] is DataGridViewColumn precio)
        {
            precio.DefaultCellStyle.Format = "C0";
        }
    }
}
