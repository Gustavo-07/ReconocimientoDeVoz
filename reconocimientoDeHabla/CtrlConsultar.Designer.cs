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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.BtnDetener = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgLibros
            // 
            this.DtgLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgLibros.Location = new System.Drawing.Point(283, 136);
            this.DtgLibros.Name = "DtgLibros";
            this.DtgLibros.Size = new System.Drawing.Size(445, 319);
            this.DtgLibros.TabIndex = 0;
            this.DtgLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(527, 88);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(201, 20);
            this.txtTexto.TabIndex = 5;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            // 
            // BtnDetener
            // 
            this.BtnDetener.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnDetener.FlatAppearance.BorderSize = 0;
            this.BtnDetener.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(120)))));
            this.BtnDetener.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.BtnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDetener.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDetener.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDetener.Image = global::reconocimientoDeHabla.Properties.Resources.icons8_stop_circled_24;
            this.BtnDetener.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDetener.Location = new System.Drawing.Point(392, 82);
            this.BtnDetener.Name = "BtnDetener";
            this.BtnDetener.Size = new System.Drawing.Size(90, 31);
            this.BtnDetener.TabIndex = 7;
            this.BtnDetener.Text = "Detener";
            this.BtnDetener.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDetener.UseVisualStyleBackColor = false;
            this.BtnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnIniciar.FlatAppearance.BorderSize = 0;
            this.BtnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(120)))));
            this.BtnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnIniciar.Image = global::reconocimientoDeHabla.Properties.Resources.icons8_audio_wave_24;
            this.BtnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIniciar.Location = new System.Drawing.Point(283, 82);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(75, 31);
            this.BtnIniciar.TabIndex = 6;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
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
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnDetener;
    }
}
