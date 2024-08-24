using System.Drawing.Printing;
using System.Windows.Forms;
using TellerEventos.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TellerEventos
{
    public partial class ControlTareas : Form
    {
        List<Tarea> tareas = new List<Tarea>();
        public ControlTareas()
        {
            InitializeComponent();
            btnEliminarUltimaTarea.Enabled = false;
            if (!btnEliminarUltimaTarea.Enabled)
            {
                btnEliminarUltimaTarea.BackColor = Color.LightGray;
                btnEliminarUltimaTarea.ForeColor = Color.White;
            }
            UpdateItemCounts();

            Selector.Items.Add(new ComboBoxItem("Pendiente", flowPanelTareaPendientes));
            Selector.Items.Add(new ComboBoxItem("En progreso", flowPanelTareaEnProgreso));
            Selector.Items.Add(new ComboBoxItem("Finalizado", flowPanelTareaFinalizada));
            if (Selector.Items.Count > 0)
            {
                Selector.SelectedIndex = 0;
            }
            txtNombreTarea.KeyDown += enviarConEnter2;
        }



        private void UpdateItemCounts()
        {

            int countPanel1 = flowPanelTareaPendientes.Controls.Count;
            contador1.Text = $"{countPanel1}";
            if (countPanel1 > 0)
            {
                btnEliminarUltimaTarea.Enabled = true;
                btnEliminarUltimaTarea.BackColor = Color.Red;
                btnEliminarUltimaTarea.ForeColor = Color.White;
                
            }
            else
            {
                btnEliminarUltimaTarea.Enabled = false;
                btnEliminarUltimaTarea.BackColor = Color.LightGray;
                btnEliminarUltimaTarea.ForeColor = Color.White;
            }

            int countPanel2 = flowPanelTareaEnProgreso.Controls.Count;
            contador2.Text = $"{countPanel2}";

            int countPanel3 = flowPanelTareaFinalizada.Controls.Count;
            contador3.Text = $"{countPanel3}";
        }
        private void MoverTarea1(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                flowPanelTareaPendientes.Controls.Remove(control);
                flowPanelTareaEnProgreso.Controls.Add(control);
                UpdateItemCounts();
            }
        }
        private void MoverTarea2(object sender, EventArgs e)
        {
            if (sender is Control control)
            {

                flowPanelTareaEnProgreso.Controls.Remove(control);
                flowPanelTareaFinalizada.Controls.Add(control);
                UpdateItemCounts();
            }
        }
        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {

            ComboBoxItem selectedItem = (ComboBoxItem)Selector.SelectedItem;
            FlowLayoutPanel selectedPanel = selectedItem.Panel;

            string nuevaTarea = txtNombreTarea.Text;
            if (!string.IsNullOrEmpty(nuevaTarea))
            {
                Label newLabel = new Label
                {
                    Text = nuevaTarea,
                    AutoSize = true,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(5),
                    Margin = new Padding(3)
                };
                newLabel.MouseHover += (sender, e) =>
                {
                    newLabel.BackColor = Color.LightGray;
                    newLabel.Font = new Font(newLabel.Font, FontStyle.Bold);
                    newLabel.Cursor = Cursors.Hand;
                };
                newLabel.MouseLeave += (sender, e) =>
                {
                    newLabel.BackColor = Color.White;
                    newLabel.Font = new Font(newLabel.Font, FontStyle.Regular);
                };
                selectedPanel.Controls.Add(newLabel);
                newLabel.DoubleClick += MoverTarea1;
                txtNombreTarea.Clear();

            }
            else
            {
                MessageBox.Show("Por favor, ingresa un texto válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UpdateItemCounts();

        }

        private void renderizarTareas()
        {
            flowPanelTareaPendientes.Controls.Clear();
            foreach (Tarea tarea in tareas)
            {
                Label tarjeta = new Label();
                tarjeta.Text = tarea.nombre;
                tarjeta.AutoSize = true;
                tarjeta.Width = 150;
                tarjeta.MinimumSize = new Size(200, 40);
                tarjeta.Padding = new Padding(10);
                tarjeta.Margin = new Padding(5);
                tarjeta.BackColor = Color.White;
                tarjeta.ForeColor = Color.Black;
                tarjeta.BorderStyle = BorderStyle.FixedSingle;

                tarjeta.MouseHover += (sender, e) =>
                {
                    tarjeta.BackColor = Color.LightGray;
                    tarjeta.Font = new Font(tarjeta.Font, FontStyle.Bold);
                    tarjeta.Cursor = Cursors.Hand;
                };

                tarjeta.MouseLeave += (sender, e) =>
                {
                    tarjeta.BackColor = Color.White;
                    tarjeta.Font = new Font(tarjeta.Font, FontStyle.Regular);
                };


                flowPanelTareaPendientes.Controls.Add(tarjeta);
            }
            foreach (Control control in flowPanelTareaPendientes.Controls)
            {
                control.DoubleClick += MoverTarea1;
            }
        }


        private void btnEliminarUltimaTarea_Click(object sender, EventArgs e)
        {
            Control lastControl = flowPanelTareaPendientes.Controls[flowPanelTareaPendientes.Controls.Count - 1];
            flowPanelTareaPendientes.Controls.Remove(lastControl);
            lastControl.Dispose();
            UpdateItemCounts();
        }

        private void flowPanelTareaEnProgreso_Paint(object sender, PaintEventArgs e)
        {
            foreach (Control control in flowPanelTareaEnProgreso.Controls)
            {
                control.DoubleClick += MoverTarea2;
                UpdateItemCounts();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void enviarConEnter(object sender, KeyPressEventArgs e)
        {

        }

        private void enviarConEnter(object sender, KeyEventArgs e)
        {

        }

        private void enviarConEnter2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newItem = txtNombreTarea.Text.Trim();

                if (!string.IsNullOrEmpty(newItem))
                {
                    btnAgregarTarea_Click(newItem, e);
                }

                e.SuppressKeyPress = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    public class ComboBoxItem
    {
        public string Name { get; set; }
        public FlowLayoutPanel Panel { get; set; }

        public ComboBoxItem(string name, FlowLayoutPanel panel)
        {
            Name = name;
            Panel = panel;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
