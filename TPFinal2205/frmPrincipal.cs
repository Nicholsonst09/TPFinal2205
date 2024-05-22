namespace TPFinal2205
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cmbLocal.Items.Add("Quenaken");
            cmbLocal.Items.Add("Onas");
            cmbLocal.Items.Add("Tobas");
            cmbLocal.SelectedIndex = -1;

            int filas = 4;
            int columnas = 5;


            for (int fila = 0; fila < filas; fila++)
            {

                for (int columna = 0; columna < columnas; columna++)
                {

                    Panel asiento = new Panel();


                    PictureBox img = new PictureBox();
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                    img.Image = Properties.Resources.verde;


                    asiento.Controls.Add(img);


                    Label lbl = new Label();
                    lbl.Text = ((fila * columnas) + columna + 1).ToString();
                    asiento.Controls.Add(lbl);


                    tlbPanel.Controls.Add(asiento, columna, fila);
                }
            }
            tlbPanel.Visible = true;

            //este còdigo de arriba irìa en un mètodo en cada clase de los locales
            //(dependiendo de cuàl haya seleccionado en el combobox)
            //para mostrar los asientos disponibles teniendo en cuenta el color
            //y la cantidad de filas y columnas
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDatosSolicitante frm2 = new frmDatosSolicitante();
            frm2.Show();

            //int nro = 1;
            //Panel asiento = new Panel();
            //PictureBox img = new PictureBox();
            //img.Image = Properties.Resources.verde;
            //asiento.Controls.Add(img);
            //Label lbl = new Label();
            //lbl.Text = nro.ToString();
            //asiento.Controls.Add(lbl);
            //tlbPanel.Controls.Add(asiento, 0, 0);

            
        }
    }
}
