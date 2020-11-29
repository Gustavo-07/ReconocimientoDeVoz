namespace reconocimientoDeHabla
{
    partial class CtrlConsultar
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DtgLibros = new System.Windows.Forms.DataGridView();
            this.BtnDetener = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgLibros
            // 
            this.DtgLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgLibros.Location = new System.Drawing.Point(352, 172);
            this.DtgLibros.Name = "DtgLibros";
            this.DtgLibros.Size = new System.Drawing.Size(337, 238);
            this.DtgLibros.TabIndex = 0;
            this.DtgLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnDetener
            // 
            this.BtnDetener.Location = new System.Drawing.Point(355, 124);
            this.BtnDetener.Name = "BtnDetener";
            this.BtnDetener.Size = new System.Drawing.Size(75, 23);
            this.BtnDetener.TabIndex = 3;
            this.BtnDetener.Text = "Detener";
            this.BtnDetener.UseVisualStyleBackColor = true;
            this.BtnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(478, 124);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(75, 23);
            this.BtnIniciar.TabIndex = 4;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(352, 74);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(201, 20);
            this.txtTexto.TabIndex = 5;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            // 
            // CtrlConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnDetener);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.DtgLibros);
            this.Name = "CtrlConsultar";
            this.Size = new System.Drawing.Size(812, 522);
            this.Load += new System.EventHandler(this.CtrlConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgLibros;
        private System.Windows.Forms.Button BtnDetener;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.TextBox txtTexto;
    }
}
