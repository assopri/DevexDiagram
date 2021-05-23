namespace OrgChartControllerExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.diagramControl1 = new DevExpress.XtraDiagram.DiagramControl();
            this.diagramOrgChartController1 = new DevExpress.XtraDiagram.DiagramOrgChartController(this.components);
            this.diagramContainer1 = new DevExpress.XtraDiagram.DiagramContainer();
            this.diagramImage1 = new DevExpress.XtraDiagram.DiagramImage();
            this.diagramShape1 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape2 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape3 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramConnector1 = new DevExpress.XtraDiagram.DiagramConnector();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramOrgChartController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramOrgChartController1.TemplateDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // diagramControl1
            // 
            this.diagramControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramControl1.Location = new System.Drawing.Point(0, 0);
            this.diagramControl1.Name = "diagramControl1";
            this.diagramControl1.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[0]);
            this.diagramControl1.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramControl1.OptionsView.ShowGrid = false;
            this.diagramControl1.OptionsView.ShowPageBreaks = false;
            this.diagramControl1.OptionsView.ShowRulers = false;
            this.diagramControl1.Size = new System.Drawing.Size(1009, 711);
            this.diagramControl1.TabIndex = 0;
            // 
            // diagramOrgChartController1
            // 
            this.diagramOrgChartController1.Diagram = this.diagramControl1;
            this.diagramOrgChartController1.KeyMember = "Id";
            this.diagramOrgChartController1.ParentMember = "ParentId";
            // 
            // 
            // 
            this.diagramOrgChartController1.TemplateDiagram.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramContainer1,
            this.diagramConnector1});
            this.diagramOrgChartController1.TemplateDiagram.Location = new System.Drawing.Point(0, 0);
            this.diagramOrgChartController1.TemplateDiagram.Name = "";
            this.diagramOrgChartController1.TemplateDiagram.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "TemplateDesigner"});
            this.diagramOrgChartController1.TemplateDiagram.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill;
            this.diagramOrgChartController1.TemplateDiagram.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramOrgChartController1.TemplateDiagram.OptionsView.ShowPageBreaks = false;
            this.diagramOrgChartController1.TemplateDiagram.TabIndex = 0;
            // 
            // diagramContainer1
            // 
            this.diagramContainer1.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramContainer1.CanAddItems = false;
            this.diagramContainer1.CanCopyWithoutParent = true;
            this.diagramContainer1.ConnectionPoints = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(0.5F, 0F),
            new DevExpress.Utils.PointFloat(1F, 0.5F),
            new DevExpress.Utils.PointFloat(0.5F, 1F),
            new DevExpress.Utils.PointFloat(0F, 0.5F)});
            this.diagramContainer1.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint;
            this.diagramContainer1.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramImage1,
            this.diagramShape1,
            this.diagramShape2,
            this.diagramShape3});
            this.diagramContainer1.ItemsCanAttachConnectorBeginPoint = false;
            this.diagramContainer1.ItemsCanAttachConnectorEndPoint = false;
            this.diagramContainer1.ItemsCanChangeParent = false;
            this.diagramContainer1.ItemsCanCopyWithoutParent = false;
            this.diagramContainer1.ItemsCanDeleteWithoutParent = false;
            this.diagramContainer1.ItemsCanEdit = false;
            this.diagramContainer1.ItemsCanMove = false;
            this.diagramContainer1.ItemsCanResize = false;
            this.diagramContainer1.ItemsCanRotate = false;
            this.diagramContainer1.ItemsCanSelect = false;
            this.diagramContainer1.ItemsCanSnapToOtherItems = false;
            this.diagramContainer1.ItemsCanSnapToThisItem = false;
            this.diagramContainer1.Padding = new System.Windows.Forms.Padding(1);
            this.diagramContainer1.Position = new DevExpress.Utils.PointFloat(25F, 125F);
            this.diagramContainer1.Size = new System.Drawing.SizeF(320F, 190F);
            this.diagramContainer1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Moderate5;
            // 
            // diagramImage1
            // 
            this.diagramImage1.Anchors = ((DevExpress.Diagram.Core.Sides)((((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top) 
            | DevExpress.Diagram.Core.Sides.Right) 
            | DevExpress.Diagram.Core.Sides.Bottom)));
            this.diagramImage1.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Image", "Photo"));
            this.diagramImage1.CanCopy = false;
            this.diagramImage1.CanCopyWithoutParent = false;
            this.diagramImage1.CanMove = false;
            this.diagramImage1.CanResize = false;
            this.diagramImage1.CanRotate = false;
            this.diagramImage1.CanSelect = false;
            this.diagramImage1.CanSnapToOtherItems = false;
            this.diagramImage1.CanSnapToThisItem = false;
            this.diagramImage1.Position = new DevExpress.Utils.PointFloat(1F, 1F);
            this.diagramImage1.Size = new System.Drawing.SizeF(140F, 186F);
            this.diagramImage1.StretchMode = DevExpress.Diagram.Core.StretchMode.UniformToFill;
            this.diagramImage1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Balanced5;
            // 
            // diagramShape1
            // 
            this.diagramShape1.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Top | DevExpress.Diagram.Core.Sides.Right)));
            this.diagramShape1.Appearance.BorderSize = 0;
            this.diagramShape1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.diagramShape1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.diagramShape1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.diagramShape1.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "Phone"));
            this.diagramShape1.CanCopy = false;
            this.diagramShape1.CanCopyWithoutParent = false;
            this.diagramShape1.CanEdit = false;
            this.diagramShape1.CanMove = false;
            this.diagramShape1.CanResize = false;
            this.diagramShape1.CanRotate = false;
            this.diagramShape1.CanSelect = false;
            this.diagramShape1.CanSnapToOtherItems = false;
            this.diagramShape1.CanSnapToThisItem = false;
            this.diagramShape1.Position = new DevExpress.Utils.PointFloat(168F, 66F);
            this.diagramShape1.Size = new System.Drawing.SizeF(129F, 20F);
            this.diagramShape1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Moderate5;
            // 
            // diagramShape2
            // 
            this.diagramShape2.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Right | DevExpress.Diagram.Core.Sides.Bottom)));
            this.diagramShape2.Appearance.BorderSize = 0;
            this.diagramShape2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.diagramShape2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.diagramShape2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.diagramShape2.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "FirstName"));
            this.diagramShape2.CanCopy = false;
            this.diagramShape2.CanCopyWithoutParent = false;
            this.diagramShape2.CanEdit = false;
            this.diagramShape2.CanMove = false;
            this.diagramShape2.CanResize = false;
            this.diagramShape2.CanRotate = false;
            this.diagramShape2.CanSelect = false;
            this.diagramShape2.CanSnapToOtherItems = false;
            this.diagramShape2.CanSnapToThisItem = false;
            this.diagramShape2.Position = new DevExpress.Utils.PointFloat(168F, 94F);
            this.diagramShape2.Size = new System.Drawing.SizeF(129F, 20F);
            this.diagramShape2.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Moderate5;
            // 
            // diagramShape3
            // 
            this.diagramShape3.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Right | DevExpress.Diagram.Core.Sides.Bottom)));
            this.diagramShape3.Appearance.BorderSize = 0;
            this.diagramShape3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.diagramShape3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.diagramShape3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.diagramShape3.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "LastName"));
            this.diagramShape3.CanCopy = false;
            this.diagramShape3.CanCopyWithoutParent = false;
            this.diagramShape3.CanEdit = false;
            this.diagramShape3.CanMove = false;
            this.diagramShape3.CanResize = false;
            this.diagramShape3.CanRotate = false;
            this.diagramShape3.CanSelect = false;
            this.diagramShape3.CanSnapToOtherItems = false;
            this.diagramShape3.CanSnapToThisItem = false;
            this.diagramShape3.Position = new DevExpress.Utils.PointFloat(168F, 126F);
            this.diagramShape3.Size = new System.Drawing.SizeF(129F, 20F);
            this.diagramShape3.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Moderate5;
            // 
            // diagramConnector1
            // 
            this.diagramConnector1.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector1.BeginPoint = new DevExpress.Utils.PointFloat(370F, 60F);
            this.diagramConnector1.CanChangeRoute = false;
            this.diagramConnector1.CanDragBeginPoint = false;
            this.diagramConnector1.CanDragEndPoint = false;
            this.diagramConnector1.EndArrow = DevExpress.Diagram.Core.ArrowDescriptions.IndentedFilledArrow;
            this.diagramConnector1.EndArrowSize = new System.Drawing.SizeF(12F, 7F);
            this.diagramConnector1.EndPoint = new DevExpress.Utils.PointFloat(460F, 150F);
            this.diagramConnector1.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[0]);
            this.diagramConnector1.ThemeStyleId = DevExpress.Diagram.Core.DiagramConnectorStyleId.Intense5;
            this.diagramConnector1.Type = DevExpress.Diagram.Core.ConnectorType.Straight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 711);
            this.Controls.Add(this.diagramControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramOrgChartController1.TemplateDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramOrgChartController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDiagram.DiagramControl diagramControl1;
        private DevExpress.XtraDiagram.DiagramOrgChartController diagramOrgChartController1;
        private DevExpress.XtraDiagram.DiagramContainer diagramContainer1;
        private DevExpress.XtraDiagram.DiagramImage diagramImage1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape2;
        private DevExpress.XtraDiagram.DiagramShape diagramShape3;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector1;

    }
}

