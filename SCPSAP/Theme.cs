using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaUI
{
    public static class Theme
    {
        // Paleta
        public static readonly Color Background = Color.White;
        public static readonly Color Surface = Color.FromArgb(250, 250, 250);
        public static readonly Color Foreground = Color.FromArgb(34, 34, 34);
        public static readonly Color Muted = Color.FromArgb(120, 120, 120);
        public static readonly Color Accent = Color.FromArgb(0, 86, 154); // azul oscuro conservador
        public static readonly Color Border = Color.FromArgb(225, 225, 225);
        public static readonly Font DefaultFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);

        // Colores para controles deshabilitados
        public static readonly Color DisabledForeground = Color.FromArgb(150, 150, 150);
        public static readonly Color DisabledBackground = Color.FromArgb(245, 245, 245);
        public static readonly Color DisabledBorder = Color.FromArgb(235, 235, 235);
        public static readonly Color DisabledButtonBack = Color.FromArgb(230, 230, 230);

        // Aplica estilo recursivamente a un control (Form o UserControl)
        public static void ApplyTo(Control root)
        {
            if (root == null) return;

            // Form o UserControl root
            root.BackColor = Background;
            root.ForeColor = Foreground;
            root.Font = DefaultFont;

            // Aplicar a hijos
            ApplyToChildren(root);
        }

        private static void ApplyToChildren(Control parent)
        {
            foreach (Control ctl in parent.Controls.Cast<Control>())
            {
                try
                {
                    ctl.Font = DefaultFont;

                    // Suscribir evento EnabledChanged una sola vez (evitar duplicados)
                    ctl.EnabledChanged -= Control_EnabledChanged;
                    ctl.EnabledChanged += Control_EnabledChanged;

                    // Aplicar estilo según tipo (estado inicial incluido)
                    switch (ctl)
                    {
                        case Button btn:
                            StyleButton(btn);
                            UpdateControlEnabledVisual(btn);
                            break;
                        case Label lbl:
                            StyleLabel(lbl);
                            UpdateControlEnabledVisual(lbl);
                            break;
                        case TextBox tb:
                            StyleTextBox(tb);
                            UpdateControlEnabledVisual(tb);
                            break;
                        case ComboBox cb:
                            StyleComboBox(cb);
                            UpdateControlEnabledVisual(cb);
                            break;
                        case DataGridView dgv:
                            StyleDataGridView(dgv);
                            UpdateControlEnabledVisual(dgv);
                            break;
                        case Panel p:
                        case GroupBox gb:
                            ctl.BackColor = Surface;
                            UpdateControlEnabledVisual(ctl);
                            break;
                        default:
                            // controles generales
                            ctl.BackColor = Color.Transparent;
                            UpdateControlEnabledVisual(ctl);
                            break;
                    }

                    // Recursión
                    if (ctl.HasChildren)
                        ApplyToChildren(ctl);
                }
                catch
                {
                    // No romper UI por errores de estilo
                }
            }
        }

        private static void Control_EnabledChanged(object sender, EventArgs e)
        {
            var ctl = sender as Control;
            if (ctl == null) return;
            UpdateControlEnabledVisual(ctl);
        }

        private static void UpdateControlEnabledVisual(Control ctl)
        {
            if (ctl == null) return;

            // Aplica visual disabled o enabled según ctl.Enabled
            if (ctl.Enabled)
            {
                // Restaurar apariencia "enabled" por tipo
                switch (ctl)
                {
                    case Button btn:
                        StyleButton(btn);
                        break;
                    case Label lbl:
                        StyleLabel(lbl);
                        break;
                    case TextBox tb:
                        StyleTextBox(tb);
                        break;
                    case ComboBox cb:
                        StyleComboBox(cb);
                        break;
                    case DataGridView dgv:
                        StyleDataGridView(dgv);
                        break;
                    default:
                        ctl.ForeColor = Foreground;
                        // No forzar background para contenedores (permitir transparencias)
                        break;
                }
            }
            else
            {
                // Apariencia deshabilitada
                switch (ctl)
                {
                    case Button btn:
                        StyleButtonDisabled(btn);
                        break;
                    case Label lbl:
                        lbl.ForeColor = DisabledForeground;
                        break;
                    case TextBox tb:
                        tb.ForeColor = DisabledForeground;
                        tb.BackColor = DisabledBackground;
                        break;
                    case ComboBox cb:
                        cb.ForeColor = DisabledForeground;
                        cb.BackColor = DisabledBackground;
                        break;
                    case DataGridView dgv:
                        StyleDataGridViewDisabled(dgv);
                        break;
                    default:
                        ctl.ForeColor = DisabledForeground;
                        break;
                }
            }
        }

        private static void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Accent;
            btn.ForeColor = Color.White;
            btn.Cursor = Cursors.Hand;
            btn.Padding = new Padding(8, 4, 8, 4);
        }

        private static void StyleButtonDisabled(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = DisabledButtonBack;
            btn.ForeColor = DisabledForeground;
            btn.Cursor = Cursors.Default;
            btn.Padding = new Padding(8, 4, 8, 4);
        }

        private static void StyleLabel(Label lbl)
        {
            lbl.BackColor = Color.Transparent;
            lbl.ForeColor = Foreground;
        }

        private static void StyleTextBox(TextBox tb)
        {
            tb.BackColor = Color.White;
            tb.ForeColor = Foreground;
            tb.BorderStyle = BorderStyle.FixedSingle;
        }

        private static void StyleComboBox(ComboBox cb)
        {
            cb.BackColor = Color.White;
            cb.ForeColor = Foreground;
            cb.FlatStyle = FlatStyle.Flat;
        }

        private static void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Surface;
            dgv.GridColor = Border;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Foreground;
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Surface;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Foreground;
            dgv.ColumnHeadersDefaultCellStyle.Font = DefaultFont;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.SelectionBackColor = Accent;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.BorderStyle = BorderStyle.None;
            dgv.RowTemplate.Height = 26;
        }

        private static void StyleDataGridViewDisabled(DataGridView dgv)
        {
            dgv.BackgroundColor = DisabledBackground;
            dgv.GridColor = DisabledBorder;

            dgv.DefaultCellStyle.BackColor = DisabledBackground;
            dgv.DefaultCellStyle.ForeColor = DisabledForeground;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = DisabledBackground;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = DisabledBackground;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = DisabledForeground;

            // Mantener selección visual pero atenuada
            dgv.DefaultCellStyle.SelectionBackColor = DisabledBorder;
            dgv.DefaultCellStyle.SelectionForeColor = DisabledForeground;
        }

        // Para DataGridView selection colors compat (compatibilidad .NET Framework)
        private static void SetSelectionColors(DataGridView dgv)
        {
            // helper si necesitas más control; por ahora usamos propiedades anteriores
        }
    }
}
