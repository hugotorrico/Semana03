namespace Semana03
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnListarGrilla = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGrillaDesconectado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLastName2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchFilter = new System.Windows.Forms.Button();
            this.txtLastName3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(86, 110);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(119, 59);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(254, 110);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(131, 59);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(86, 217);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(119, 59);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "Listar Desconectado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListarGrilla
            // 
            this.btnListarGrilla.Location = new System.Drawing.Point(419, 217);
            this.btnListarGrilla.Name = "btnListarGrilla";
            this.btnListarGrilla.Size = new System.Drawing.Size(119, 59);
            this.btnListarGrilla.TabIndex = 4;
            this.btnListarGrilla.Text = "Listar Grilla";
            this.btnListarGrilla.UseVisualStyleBackColor = true;
            this.btnListarGrilla.Click += new System.EventHandler(this.btnListarGrilla_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(89, 525);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(640, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnGrillaDesconectado
            // 
            this.btnGrillaDesconectado.Location = new System.Drawing.Point(586, 217);
            this.btnGrillaDesconectado.Name = "btnGrillaDesconectado";
            this.btnGrillaDesconectado.Size = new System.Drawing.Size(119, 59);
            this.btnGrillaDesconectado.TabIndex = 6;
            this.btnGrillaDesconectado.Text = "Listar Grilla Desconectado";
            this.btnGrillaDesconectado.UseVisualStyleBackColor = true;
            this.btnGrillaDesconectado.Click += new System.EventHandler(this.btnGrillaDesconectado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "LastName";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(193, 362);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(335, 325);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 59);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtLastName2
            // 
            this.txtLastName2.Location = new System.Drawing.Point(193, 430);
            this.txtLastName2.Name = "txtLastName2";
            this.txtLastName2.Size = new System.Drawing.Size(100, 22);
            this.txtLastName2.TabIndex = 11;
            this.txtLastName2.TextChanged += new System.EventHandler(this.txtLastName2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "LastName";
            // 
            // btnSearchFilter
            // 
            this.btnSearchFilter.Location = new System.Drawing.Point(586, 446);
            this.btnSearchFilter.Name = "btnSearchFilter";
            this.btnSearchFilter.Size = new System.Drawing.Size(119, 59);
            this.btnSearchFilter.TabIndex = 14;
            this.btnSearchFilter.Text = "Search";
            this.btnSearchFilter.UseVisualStyleBackColor = true;
            this.btnSearchFilter.Click += new System.EventHandler(this.btnSearchFilter_Click);
            // 
            // txtLastName3
            // 
            this.txtLastName3.Location = new System.Drawing.Point(190, 478);
            this.txtLastName3.Name = "txtLastName3";
            this.txtLastName3.Size = new System.Drawing.Size(100, 22);
            this.txtLastName3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "LastName";
            // 
            // txtFirstName3
            // 
            this.txtFirstName3.Location = new System.Drawing.Point(449, 483);
            this.txtFirstName3.Name = "txtFirstName3";
            this.txtFirstName3.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "FirstName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 708);
            this.Controls.Add(this.txtFirstName3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearchFilter);
            this.Controls.Add(this.txtLastName3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastName2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGrillaDesconectado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListarGrilla);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnListarGrilla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGrillaDesconectado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtLastName2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchFilter;
        private System.Windows.Forms.TextBox txtLastName3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName3;
        private System.Windows.Forms.Label label4;
    }
}

