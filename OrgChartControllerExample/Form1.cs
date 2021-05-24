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
            diagramControl1.KeyDown += DiagramControl1_KeyDown;

            foreach (var item in diagramControl1.Items)
            {
                item.CanHideSubordinates = true;
                
            }
        }

        private void DiagramControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                AddItem(false);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                AddItem(true);
                e.Handled = true;
            }
        }

        void AddItem(bool addSibling)
        {
            if (diagramControl1.PrimarySelection != null &&
                diagramControl1.SelectedItems.Count == 1 &&
                !(diagramControl1.PrimarySelection is DiagramConnector))
            // if (diagramControl1.SelectedItems[0].GetType() == typeof(DiagramContainer))
            {
                DiagramItem selectedItem = diagramControl1.PrimarySelection;
                DiagramShape newShape = new DiagramShape()
                {
                    Width = selectedItem.Width,
                    Height = selectedItem.Height
                };
                DiagramItem parentItem = null;
                if (addSibling)
                {
                    if (selectedItem.IncomingConnectors.Any())
                        parentItem = (DiagramItem)selectedItem.IncomingConnectors.First().BeginItem;
                }
                else
                {
                    parentItem = selectedItem;
                }
                DiagramConnector newConnectyor = new DiagramConnector() { BeginItem = parentItem, EndItem = newShape };
                diagramControl1.Items.AddRange(newShape, newConnectyor);
                diagramControl1.ApplyTreeLayout();
            }
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
