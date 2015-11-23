using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms
{
    public class Ultilities
    {
        public static string WindowsForms = "\\WindowsForms\\bin\\Debug";

        public static string Website = "\\Website\\Images\\SanPham\\";

        public static void DataGridViewFormat(DataGridView dgv, string[] columns)
        {
            foreach (DataGridViewColumn cl in dgv.Columns)
            {
                if (!columns.Contains(cl.DataPropertyName))
                    cl.Visible = false;
            }
        }

    }
}
