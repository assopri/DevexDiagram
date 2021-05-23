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
        }
    }
}
