namespace Reto
{
    public partial class Form1 : Form
    {
        private readonly CuentaBancaria _cuenta =
            new CuentaBancaria("Maria Isabel Correa Restrepo", "001-123", 500000m);

        public Form1()
        {
            InitializeComponent();

            ActualizarSaldo();
        }

        private void ActualizarSaldo()
        {
            lblTitular.Text = "Titular: " + _cuenta.Titular;

            lblSaldo.Text = "Saldo: " + _cuenta.Saldo.ToString("C0");
        }

        private bool ValidarMonto()
        {
            decimal monto = nudMonto.Value;

            if (monto <= 0)
            {
                MessageBox.Show("El monto debe ser mayor a cero.");
                return false;
            }

            if (monto % 10000 != 0)
            {
                MessageBox.Show("El monto debe ser multiplo de 10.000.");
                return false;
            }

            return true;
        }

        private void RegistrarMovimiento(string tipo, decimal monto, string destinatario = "")
        {
            string texto = DateTime.Now.ToString("HH:mm:ss") +
                           " - " + tipo;

            if (destinatario != "")
            {
                texto += " a " + destinatario;
            }

            texto += " - " + monto.ToString("C0");

            lstMovimientos.Items.Insert(0, texto);
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (!ValidarMonto())
            {
                return;
            }

            decimal monto = nudMonto.Value;

            if (_cuenta.Depositar(monto))
            {
                ActualizarSaldo();
                RegistrarMovimiento("Deposito", monto);

                MessageBox.Show("Deposito realizado correctamente.");
            }
            else
            {
                MessageBox.Show("No se pudo realizar el deposito.");
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (!ValidarMonto())
            {
                return;
            }

            decimal monto = nudMonto.Value;

            if (_cuenta.Retirar(monto))
            {
                ActualizarSaldo();
                RegistrarMovimiento("Retiro", monto);

                MessageBox.Show("Retiro realizado correctamente.");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente para realizar el retiro.");
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDestinatario.Text))
            {
                MessageBox.Show("Escribe el nombre del destinatario.");
                return;
            }

            if (!ValidarMonto())
            {
                return;
            }

            string destinatario = txtDestinatario.Text.Trim();
            decimal monto = nudMonto.Value;

            CuentaBancaria cuentaDestino = new CuentaBancaria(destinatario, "002-456", 0);

            if (_cuenta.Transferir(cuentaDestino, monto))
            {
                ActualizarSaldo();
                RegistrarMovimiento("Transferencia", monto, destinatario);

                MessageBox.Show("Transferencia realizada correctamente a " + destinatario);

                txtDestinatario.Clear();
            }
            else
            {
                MessageBox.Show("No se pudo realizar la transferencia. " +
                                "Verifica el saldo disponible.");
            }
        }
    }
}