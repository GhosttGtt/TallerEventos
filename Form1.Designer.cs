namespace TellerEventos
{
    partial class ControlTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlTareas));
            txtNombreTarea = new TextBox();
            flowPanelTareaPendientes = new FlowLayoutPanel();
            btnEliminarUltimaTarea = new Button();
            flowPanelTareaEnProgreso = new FlowLayoutPanel();
            flowPanelTareaFinalizada = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            contador1 = new Label();
            contador2 = new Label();
            contador3 = new Label();
            Selector = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtNombreTarea
            // 
            txtNombreTarea.BorderStyle = BorderStyle.FixedSingle;
            txtNombreTarea.Location = new Point(290, 45);
            txtNombreTarea.Margin = new Padding(3, 2, 3, 2);
            txtNombreTarea.Name = "txtNombreTarea";
            txtNombreTarea.PlaceholderText = "Ingrese su tarea";
            txtNombreTarea.Size = new Size(253, 23);
            txtNombreTarea.TabIndex = 0;
            txtNombreTarea.KeyDown += enviarConEnter2;
            // 
            // flowPanelTareaPendientes
            // 
            flowPanelTareaPendientes.AutoScroll = true;
            flowPanelTareaPendientes.BorderStyle = BorderStyle.FixedSingle;
            flowPanelTareaPendientes.FlowDirection = FlowDirection.TopDown;
            flowPanelTareaPendientes.Location = new Point(17, 120);
            flowPanelTareaPendientes.Margin = new Padding(3, 2, 3, 2);
            flowPanelTareaPendientes.Name = "flowPanelTareaPendientes";
            flowPanelTareaPendientes.Size = new Size(253, 369);
            flowPanelTareaPendientes.TabIndex = 2;
            flowPanelTareaPendientes.WrapContents = false;
            // 
            // btnEliminarUltimaTarea
            // 
            btnEliminarUltimaTarea.BackColor = Color.Red;
            btnEliminarUltimaTarea.Cursor = Cursors.Hand;
            btnEliminarUltimaTarea.FlatAppearance.BorderSize = 0;
            btnEliminarUltimaTarea.FlatStyle = FlatStyle.Flat;
            btnEliminarUltimaTarea.ForeColor = SystemColors.ControlLightLight;
            btnEliminarUltimaTarea.Location = new Point(17, 493);
            btnEliminarUltimaTarea.Margin = new Padding(3, 2, 3, 2);
            btnEliminarUltimaTarea.Name = "btnEliminarUltimaTarea";
            btnEliminarUltimaTarea.Size = new Size(253, 25);
            btnEliminarUltimaTarea.TabIndex = 3;
            btnEliminarUltimaTarea.Text = "Eliminar última tarea pendiente";
            btnEliminarUltimaTarea.UseVisualStyleBackColor = false;
            btnEliminarUltimaTarea.Click += btnEliminarUltimaTarea_Click;
            // 
            // flowPanelTareaEnProgreso
            // 
            flowPanelTareaEnProgreso.AutoScroll = true;
            flowPanelTareaEnProgreso.BorderStyle = BorderStyle.FixedSingle;
            flowPanelTareaEnProgreso.FlowDirection = FlowDirection.TopDown;
            flowPanelTareaEnProgreso.Location = new Point(292, 120);
            flowPanelTareaEnProgreso.Margin = new Padding(3, 2, 3, 2);
            flowPanelTareaEnProgreso.Name = "flowPanelTareaEnProgreso";
            flowPanelTareaEnProgreso.Size = new Size(253, 369);
            flowPanelTareaEnProgreso.TabIndex = 3;
            flowPanelTareaEnProgreso.WrapContents = false;
            flowPanelTareaEnProgreso.Paint += flowPanelTareaEnProgreso_Paint;
            // 
            // flowPanelTareaFinalizada
            // 
            flowPanelTareaFinalizada.AccessibleRole = AccessibleRole.None;
            flowPanelTareaFinalizada.AutoScroll = true;
            flowPanelTareaFinalizada.BorderStyle = BorderStyle.FixedSingle;
            flowPanelTareaFinalizada.FlowDirection = FlowDirection.TopDown;
            flowPanelTareaFinalizada.Location = new Point(569, 120);
            flowPanelTareaFinalizada.Margin = new Padding(3, 2, 3, 2);
            flowPanelTareaFinalizada.Name = "flowPanelTareaFinalizada";
            flowPanelTareaFinalizada.Size = new Size(253, 369);
            flowPanelTareaFinalizada.TabIndex = 4;
            flowPanelTareaFinalizada.WrapContents = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 97);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Pendiente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 97);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 5;
            label2.Text = "En progreso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(578, 97);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Finalizado";
            // 
            // contador1
            // 
            contador1.AutoSize = true;
            contador1.Location = new Point(87, 97);
            contador1.Name = "contador1";
            contador1.Size = new Size(13, 15);
            contador1.TabIndex = 5;
            contador1.Text = "0";
            // 
            // contador2
            // 
            contador2.AutoSize = true;
            contador2.Location = new Point(378, 97);
            contador2.Name = "contador2";
            contador2.Size = new Size(13, 15);
            contador2.TabIndex = 5;
            contador2.Text = "0";
            // 
            // contador3
            // 
            contador3.AutoSize = true;
            contador3.Location = new Point(644, 97);
            contador3.Name = "contador3";
            contador3.Size = new Size(13, 15);
            contador3.TabIndex = 5;
            contador3.Text = "0";
            // 
            // Selector
            // 
            Selector.DropDownStyle = ComboBoxStyle.DropDownList;
            Selector.FlatStyle = FlatStyle.Flat;
            Selector.FormattingEnabled = true;
            Selector.Location = new Point(15, 45);
            Selector.Name = "Selector";
            Selector.Size = new Size(253, 23);
            Selector.TabIndex = 6;
            Selector.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 18);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 5;
            label4.Text = "Estado de la tarea";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(290, 18);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 5;
            label5.Text = "Nombre de la tarea";
            label5.Click += label4_Click;
            // 
            // ControlTareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 535);
            Controls.Add(Selector);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(contador3);
            Controls.Add(contador2);
            Controls.Add(contador1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(flowPanelTareaFinalizada);
            Controls.Add(flowPanelTareaEnProgreso);
            Controls.Add(btnEliminarUltimaTarea);
            Controls.Add(flowPanelTareaPendientes);
            Controls.Add(txtNombreTarea);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "ControlTareas";
            Text = "ControlTareas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreTarea;
        private FlowLayoutPanel flowPanelTareaPendientes;
        private Button btnEliminarUltimaTarea;
        private FlowLayoutPanel flowPanelTareaEnProgreso;
        private FlowLayoutPanel flowPanelTareaFinalizada;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label contador1;
        private Label contador2;
        private Label contador3;
        private ComboBox Selector;
        private Label label4;
        private Label label5;
    }
}
