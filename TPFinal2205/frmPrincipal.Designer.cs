namespace TPFinal2205
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbLocal = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            btnReservar = new Button();
            tlbPanel = new TableLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 25);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "LOCAL";
            // 
            // cmbLocal
            // 
            cmbLocal.FormattingEnabled = true;
            cmbLocal.Location = new Point(84, 17);
            cmbLocal.Name = "cmbLocal";
            cmbLocal.Size = new Size(121, 23);
            cmbLocal.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(301, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 25);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha";
            // 
            // btnReservar
            // 
            btnReservar.Location = new Point(335, 225);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(75, 23);
            btnReservar.TabIndex = 4;
            btnReservar.Text = "&RESERVAR";
            btnReservar.UseVisualStyleBackColor = true;
            btnReservar.Click += button1_Click;
            // 
            // tlbPanel
            // 
            tlbPanel.ColumnCount = 5;
            tlbPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlbPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlbPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlbPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlbPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlbPanel.Location = new Point(72, 95);
            tlbPanel.Name = "tlbPanel";
            tlbPanel.RowCount = 4;
            tlbPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlbPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlbPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlbPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlbPanel.Size = new Size(200, 100);
            tlbPanel.TabIndex = 9;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 271);
            Controls.Add(tlbPanel);
            Controls.Add(label1);
            Controls.Add(btnReservar);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(cmbLocal);
            Name = "frmPrincipal";
            Text = "RESERVA DE UBICACIONES";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbLocal;
        private TextBox textBox1;
        private Label label2;
        private Button btnReservar;
        private TableLayoutPanel tlbPanel;
    }
}
