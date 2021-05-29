using DevExpress.Diagram.Core;
using DevExpress.Utils;
using DevExpress.XtraDiagram;
using DevExpress.XtraEditors;
using OrgChartControllerExample.Model;
using OrgChartControllerExample.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            MainViewModel model = new MainViewModel();
            diagramOrgChartController1.DataSource = model.Contacts;
            diagramControl1.MouseDoubleClick += DiagramControl1_MouseDoubleClick;
            diagramControl1.MouseMove += DiagramControl1_MouseMove;
            diagramControl1.KeyDown += DiagramControl1_KeyDown;
            diagramControl1.ItemsMoving += DiagramControl1_ItemsMoving;

            foreach (var item in diagramControl1.Items)
            {
                if(item is DiagramConnector)
                {
                    //(item as DiagramConnector).cur
                }
                else
                {
                    item.CanHideSubordinates = true;
                }
            }

            // https://supportcenter.devexpress.com/ticket/details/t1000542/how-can-i-use-mindmap-layout-instead-of-orgchart-layout-in-this-sample
            //diagramOrgChartController1.LayoutKind = DiagramLayoutKind.MindMapTree;
            //diagramControl1.ApplyMindMapTreeLayout(); //OrientationKind.Vertical

            // To make connectors curved, set the DiagramConnector.Type property to "Curved".To set this property automatically for newly created connectors, handle the ItemInitializing event.
            diagramControl1.ItemInitializing += DiagramControl1_ItemInitializing;
        }

        private void DiagramControl1_ItemInitializing(object sender, DiagramItemInitializingEventArgs e)
        {
            DiagramConnector connector = e.Item as DiagramConnector;
            if (connector != null)
            {
                connector.EndArrow = ArrowDescriptions.FilledDot;
                connector.BeginArrow = ArrowDescriptions.ClosedDoubleArrow;
                connector.Type = ConnectorType.Curved;
            }
                
        }

        private void DiagramControl1_ItemsMoving(object sender, DiagramItemsMovingEventArgs e)
        {
            // TODO: It's possible that the NewParent property is not updated in your usage scenario, because containers don't allow adding new children. You can try setting DiagramContainer.CanAddItems to true to check if this is the case. Your solution is correct, so you can keep using it.
            // https://supportcenter.devexpress.com/ticket/details/t998796/can-i-implement-following-type-of-node-connection-creation-behaviours-with-mind-map
            if (e.Stage == DiagramActionStage.Finished)
            {
                DiagramShape targetShape = diagramControl1.Items.OfType<DiagramShape>().FirstOrDefault(item => item.Bounds.Contains(e.Items[0].NewDiagramPosition));
                if (targetShape != null)
                {
                    diagramControl1.Items.Add(new DiagramConnector() { BeginItem = e.Items[0].Item, EndItem = targetShape });
                }
                //code modification for containers 
                {
                    DiagramContainer targetContainer = diagramControl1.Items.OfType<DiagramContainer>().FirstOrDefault(item => item.Bounds.Contains(e.Items[0].NewDiagramPosition));

                    if(targetContainer != null)
                    {
                        diagramControl1.Items.Add(new DiagramConnector() { BeginItem = targetContainer, EndItem = e.Items[0].Item });

                        //to prevent adding the dragged item to the container
                        e.Cancel = true;
                    }
                }
            }

            //if (e.Stage == DiagramActionStage.Finished)
            //{
            //    DiagramContainer dc = null; 

            //    DiagramShape targetItem = diagramControl1.Items.OfType<DiagramShape>().FirstOrDefault(item => item.Bounds.Contains(e.Items[0].NewDiagramPosition));
            //    if(targetItem==null)
            //    {
            //        dc = diagramControl1.Items.OfType<DiagramContainer>().FirstOrDefault(item => item.Bounds.Contains(e.Items[0].NewDiagramPosition));
            //        //targetItem = dc.Items[0];
            //    }
            //    if (targetItem != null)
            //    {
            //        diagramControl1.Items.Add(new DiagramConnector() { BeginItem = e.Items[0].Item, EndItem = dc.Items[0] });
            //    }
            //}
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

            (diagramOrgChartController1.DataSource as ObservableCollection<Contact>).Clear(); 
        }

      

        private void searchControl1_TextChanged(object sender, EventArgs e)
        {
            //following this example https://supportcenter.devexpress.com/ticket/details/t448980/how-to-use-a-search-box-to-search-for-shapes-at-the-diagram-surface

            SearchControl searchControl = (SearchControl)sender;
            foreach (DiagramItem item in diagramControl1.Items)
            {
                Type itemType = item.GetType();
                if (itemType == typeof(DiagramShape))
                {
                    DiagramShape shape = item as DiagramShape;
                    if (shape == null)
                        continue;
                    if (shape.Content.Contains(searchControl.Text.ToLower()))
                    {
                        diagramControl1.SelectItem(shape);
                        diagramControl1.BringSelectionIntoView();
                        //diagramControl1.FitToItems(new DiagramItem[] { shape });
                        break;
                    }
                }
                else if(itemType == typeof(DiagramContainer))
                {
                    DiagramContainer container = item as DiagramContainer;
                    if (container == null)
                        continue;
                    string s = (container.DataContext as Contact).FirstName.ToString();
                    if (s.Contains(searchControl.Text.ToLower()))
                    {
                        diagramControl1.SelectItem(container);
                        diagramControl1.BringSelectionIntoView();
                        //diagramControl1.FitToItems(new DiagramItem[] { shape });
                        break;
                    }
                }

            }
        }
    }
}
