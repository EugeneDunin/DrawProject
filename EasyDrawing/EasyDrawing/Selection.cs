using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDrawing
{
    public partial class Main_Form
    {
        private bool MoveObject;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MoveObject = true;
        }
        private void SelectionButtonDisactivate_CheckedChanged(object sender, EventArgs e)
        {
            MoveObject = false;
        }
    }
}
