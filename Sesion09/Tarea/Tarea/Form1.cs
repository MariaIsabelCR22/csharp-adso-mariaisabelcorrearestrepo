namespace Tarea
{
    public partial class Form1 : Form
    {
        private ConversorTemperatura conversor = new ConversorTemperatura();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            lblResultado.Text = "";

            bool valido = true;
            decimal valor = 0;

            // Validar el valor
            if (string.IsNullOrWhiteSpace(txtValor.Text))
            {
                errorProvider1.SetError(txtValor, "Escribe un valor.");
                valido = false;
            }
            else if (!decimal.TryParse(txtValor.Text, out valor))
            {
                errorProvider1.SetError(txtValor, "Escribe un numero valido.");
                valido = false;
            }

            // Validar unidad de origen
            if (cmbOrigen.SelectedItem == null)
            {
                errorProvider1.SetError(cmbOrigen, "Selecciona la unidad de origen.");
                valido = false;
            }

            // Validar unidad de destino
            if (cmbDestino.SelectedItem == null)
            {
                errorProvider1.SetError(cmbDestino, "Selecciona la unidad de destino.");
                valido = false;
            }

            if (!valido)
            {
                return;
            }

            // Obtener las unidades seleccionadas
            string origen = cmbOrigen.SelectedItem!.ToString()!;
            string destino = cmbDestino.SelectedItem!.ToString()!;

            // Validar temperatura minima
            if (origen == "Kelvin" && valor < 0)
            {
                errorProvider1.SetError(txtValor, "Kelvin no puede ser negativo.");
                return;
            }

            // Realizar la conversion
            decimal resultado = conversor.Convertir(valor, origen, destino);

            // Mostrar el resultado
            lblResultado.Text = "Resultado: " + resultado.ToString("N2") + " " + destino;
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
