using DevExpress.XtraDiagram;
using DevExpress.XtraDiagram.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrgChartControllerExample.Classes
{
    // example from this ticket https://supportcenter.devexpress.com/ticket/details/t1000249/how-to-manually-close-a-shape-s-editor
    public class DiagramControlEx : DiagramControl
    {
        public DiagramControlEx()
        {
            this.ClosedEditor += DiagramControlEx_ClosedEditor;
        }
        private void DiagramControlEx_ClosedEditor(object sender, DiagramClosedEditorEventArgs e)
        {
            editor.KeyDown -= Editor_KeyDown;
        }
        DiagramMaskBox editor;
        protected override DiagramMaskBox CreateDiagramEditor()
        {
            editor = base.CreateDiagramEditor();
            editor.KeyDown += Editor_KeyDown;
            return editor;
        }
        private void Editor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Controller.FinishInplaceEditing();
        }
    }
}
