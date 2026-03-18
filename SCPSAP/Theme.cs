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
                    ctl.ForeColor = Foreground;

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
                        case Panel p:
                        case GroupBox gb:
                            ctl.BackColor = Surface;
                            break;
                        default:
                            // controles generales
                            ctl.BackColor = Color.Transparent;
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

        private static void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Accent;
            btn.ForeColor = Color.White;
            btn.Cursor = Cursors.Hand;
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

        // Para DataGridView selection colors compat (compatibilidad .NET Framework)
        private static void SetSelectionColors(DataGridView dgv)
        {
            // helper si necesitas más control; por ahora usamos propiedades anteriores
        }
    }
}
