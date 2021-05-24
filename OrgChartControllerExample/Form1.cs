using DevExpress.Utils;
using DevExpress.XtraDiagram;
using OrgChartControllerExample.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrgChartControllerExample
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            var model = new MainViewModel();
            diagramOrgChartController1.DataSource = model.Contacts;
            diagramControl1.MouseDoubleClick += DiagramControl1_MouseDoubleClick;
            diagramControl1.MouseMove += DiagramControl1_MouseMove;
        }

        private void DiagramControl1_MouseMove(object sender, MouseEventArgs e)
        {
            //done from sample here https://supportcenter.devexpress.com/ticket/details/t1000248/how-to-activate-the-connector-tool-on-mouse-hover

            if (Control.ModifierKeys.HasFlag(Keys.Control))
            {

                var shape = diagramControl1.CalcHitItem(new DevExpress.Utils.PointFloat(e.X, e.Y));
                if (shape != null)
                {
                    diagramControl1.OptionsBehavior.ActiveTool = diagramControl1.OptionsBehavior.ConnectorTool;
                }
            }
            else
            {
                diagramControl1.OptionsBehavior.ActiveTool = diagramControl1.OptionsBehavior.PointerTool;
            }
        }

        private void DiagramControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {            
            PointFloat canvasPoint = diagramControl1.PointToDocument(new PointFloat(e.X, e.Y));
            
            DiagramShape ds = new DiagramShape() { Width = 100, Height = 100, Position = canvasPoint, Content = "hello" };
            diagramControl1.Items.Add(ds);
            diagramControl1.SelectItem(ds);
        }
    }
}
