namespace FormularioPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != "") {
                MessageBox.Show("Tu nombre es: " + tbNombre.Text);
            }
            else{
                MessageBox.Show("Introduzca un nombre");
            }
        }
    }
}