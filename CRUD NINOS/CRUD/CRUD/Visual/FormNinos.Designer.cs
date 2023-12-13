namespace CRUD.Visual
{
    partial class FormNinos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNinos));
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dgvNinos = new System.Windows.Forms.DataGridView();
            this.colRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoSangre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCiudadNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdentificacionAcudiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdentificadorJardin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEPS = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtIdentificacionAcudiente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCiudadNacimiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdentificadorJardin = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtTipoSangre = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNinos)).BeginInit();
            this.pnlBusqueda.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBackground.Controls.Add(this.dtpFechaNacimiento);
            this.pnlBackground.Controls.Add(this.dgvNinos);
            this.pnlBackground.Controls.Add(this.label5);
            this.pnlBackground.Controls.Add(this.label4);
            this.pnlBackground.Controls.Add(this.label3);
            this.pnlBackground.Controls.Add(this.txtEPS);
            this.pnlBackground.Controls.Add(this.txtDireccion);
            this.pnlBackground.Controls.Add(this.txtTelefono);
            this.pnlBackground.Controls.Add(this.txtIdentificacionAcudiente);
            this.pnlBackground.Controls.Add(this.label2);
            this.pnlBackground.Controls.Add(this.txtCiudadNacimiento);
            this.pnlBackground.Controls.Add(this.label1);
            this.pnlBackground.Controls.Add(this.btnLimpiar);
            this.pnlBackground.Controls.Add(this.btnSalir);
            this.pnlBackground.Controls.Add(this.pnlBusqueda);
            this.pnlBackground.Controls.Add(this.btnEliminar);
            this.pnlBackground.Controls.Add(this.btnModificar);
            this.pnlBackground.Controls.Add(this.btnAgregar);
            this.pnlBackground.Controls.Add(this.lblEstado);
            this.pnlBackground.Controls.Add(this.lblDireccion);
            this.pnlBackground.Controls.Add(this.lblNombre);
            this.pnlBackground.Controls.Add(this.txtTipoSangre);
            this.pnlBackground.Controls.Add(this.txtNombre);
            this.pnlBackground.Controls.Add(this.panel2);
            this.pnlBackground.Location = new System.Drawing.Point(4, 9);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(540, 563);
            this.pnlBackground.TabIndex = 2;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(91, 88);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(165, 20);
            this.dtpFechaNacimiento.TabIndex = 25;
            // 
            // dgvNinos
            // 
            this.dgvNinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNinos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRegistro,
            this.colNombre,
            this.colFechaNacimiento,
            this.colTipoSangre,
            this.colCiudadNacimiento,
            this.colIdentificacionAcudiente,
            this.colTelefono,
            this.colDireccion,
            this.colEPS,
            this.colIdentificadorJardin,
            this.colIDUsuario});
            this.dgvNinos.Location = new System.Drawing.Point(20, 269);
            this.dgvNinos.Name = "dgvNinos";
            this.dgvNinos.Size = new System.Drawing.Size(509, 150);
            this.dgvNinos.TabIndex = 24;
            this.dgvNinos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvNinos_MouseClick);
            // 
            // colRegistro
            // 
            this.colRegistro.DataPropertyName = "Registro";
            this.colRegistro.HeaderText = "Registro";
            this.colRegistro.Name = "colRegistro";
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "Nombre_n";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colFechaNacimiento
            // 
            this.colFechaNacimiento.DataPropertyName = "Fecha_nacimiento";
            this.colFechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.colFechaNacimiento.Name = "colFechaNacimiento";
            // 
            // colTipoSangre
            // 
            this.colTipoSangre.DataPropertyName = "Tipo_sangre";
            this.colTipoSangre.HeaderText = "Tipo Sangre";
            this.colTipoSangre.Name = "colTipoSangre";
            // 
            // colCiudadNacimiento
            // 
            this.colCiudadNacimiento.DataPropertyName = "Ciudad_nacimiento";
            this.colCiudadNacimiento.HeaderText = "Ciudad Nacimiento";
            this.colCiudadNacimiento.Name = "colCiudadNacimiento";
            // 
            // colIdentificacionAcudiente
            // 
            this.colIdentificacionAcudiente.DataPropertyName = "Identificacion_acudiente";
            this.colIdentificacionAcudiente.HeaderText = "Id Acudiente";
            this.colIdentificacionAcudiente.Name = "colIdentificacionAcudiente";
            // 
            // colTelefono
            // 
            this.colTelefono.DataPropertyName = "Telefono";
            this.colTelefono.HeaderText = "Telefono";
            this.colTelefono.Name = "colTelefono";
            // 
            // colDireccion
            // 
            this.colDireccion.DataPropertyName = "Direccion_n";
            this.colDireccion.HeaderText = "Direccion";
            this.colDireccion.Name = "colDireccion";
            // 
            // colEPS
            // 
            this.colEPS.DataPropertyName = "EPS";
            this.colEPS.HeaderText = "EPS";
            this.colEPS.Name = "colEPS";
            // 
            // colIdentificadorJardin
            // 
            this.colIdentificadorJardin.DataPropertyName = "Identificador_Jardin";
            this.colIdentificadorJardin.HeaderText = "Id Nino";
            this.colIdentificadorJardin.Name = "colIdentificadorJardin";
            // 
            // colIDUsuario
            // 
            this.colIDUsuario.DataPropertyName = "ID_usuario";
            this.colIDUsuario.HeaderText = "Id Usuario";
            this.colIDUsuario.Name = "colIDUsuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(325, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Eps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(284, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(287, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Telefono";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtEPS
            // 
            this.txtEPS.Location = new System.Drawing.Point(359, 164);
            this.txtEPS.Margin = new System.Windows.Forms.Padding(2);
            this.txtEPS.Name = "txtEPS";
            this.txtEPS.Size = new System.Drawing.Size(165, 20);
            this.txtEPS.TabIndex = 20;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(359, 126);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(165, 20);
            this.txtDireccion.TabIndex = 19;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(359, 88);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(165, 20);
            this.txtTelefono.TabIndex = 18;
            // 
            // txtIdentificacionAcudiente
            // 
            this.txtIdentificacionAcudiente.Location = new System.Drawing.Point(359, 55);
            this.txtIdentificacionAcudiente.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentificacionAcudiente.Name = "txtIdentificacionAcudiente";
            this.txtIdentificacionAcudiente.Size = new System.Drawing.Size(165, 20);
            this.txtIdentificacionAcudiente.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ciudad Nac";
            // 
            // txtCiudadNacimiento
            // 
            this.txtCiudadNacimiento.Location = new System.Drawing.Point(91, 164);
            this.txtCiudadNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.txtCiudadNacimiento.Name = "txtCiudadNacimiento";
            this.txtCiudadNacimiento.Size = new System.Drawing.Size(165, 20);
            this.txtCiudadNacimiento.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(260, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id Acudiente";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::CRUD.Properties.Resources.clean2;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(328, 515);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 34);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar  ";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::CRUD.Properties.Resources.logout;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(442, 515);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 34);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir  ";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlBusqueda.Controls.Add(this.txtRegistro);
            this.pnlBusqueda.Controls.Add(this.label7);
            this.pnlBusqueda.Controls.Add(this.label6);
            this.pnlBusqueda.Controls.Add(this.txtIdentificadorJardin);
            this.pnlBusqueda.Location = new System.Drawing.Point(20, 213);
            this.pnlBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(509, 51);
            this.pnlBusqueda.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(7, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Id Jard";
            // 
            // txtIdentificadorJardin
            // 
            this.txtIdentificadorJardin.Location = new System.Drawing.Point(68, 17);
            this.txtIdentificadorJardin.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentificadorJardin.Name = "txtIdentificadorJardin";
            this.txtIdentificadorJardin.Size = new System.Drawing.Size(155, 20);
            this.txtIdentificadorJardin.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(227, 515);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 34);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar  ";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(115, 515);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 34);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar  ";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(20, 515);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 34);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEstado.Location = new System.Drawing.Point(32, 127);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(57, 19);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Sangre";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDireccion.Location = new System.Drawing.Point(9, 89);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(80, 19);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Fecha Nac";
            this.lblDireccion.Click += new System.EventHandler(this.lblDireccion_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(27, 55);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 19);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txtTipoSangre
            // 
            this.txtTipoSangre.Location = new System.Drawing.Point(91, 126);
            this.txtTipoSangre.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipoSangre.Name = "txtTipoSangre";
            this.txtTipoSangre.Size = new System.Drawing.Size(165, 20);
            this.txtTipoSangre.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 55);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 51);
            this.panel2.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(36, 15);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(159, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CRUD de Niños";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(252, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Id Registro";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(339, 19);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Size = new System.Drawing.Size(155, 20);
            this.txtRegistro.TabIndex = 10;
            // 
            // FormNinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 580);
            this.Controls.Add(this.pnlBackground);
            this.Name = "FormNinos";
            this.Text = "FormNinos";
            this.Load += new System.EventHandler(this.FormNinos_Load_1);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNinos)).EndInit();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtTipoSangre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEPS;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtIdentificacionAcudiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCiudadNacimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoSangre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCiudadNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdentificacionAcudiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdentificadorJardin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDUsuario;
        private System.Windows.Forms.TextBox txtIdentificadorJardin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRegistro;
    }
}