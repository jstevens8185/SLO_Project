using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SloManager
{
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        private SlosClassLibrary.SloDatabaseEntities dbcontext =
            new SlosClassLibrary.SloDatabaseEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private async void LoadDB()
        {
            await dbcontext.SLOs.OrderBy(slo => slo.SLO_ID).LoadAsync();

            sLOBindingSource.DataSource = dbcontext.SLOs.Local;
        }

        private void sLOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            sLOBindingSource.EndEdit();

            try
            {
                dbcontext.SaveChanges();
            }
            catch(DbEntityValidationException)
            {
                MessageBox.Show("Description and Title Must contain values.", "Entity Validation Exception");
            }
        }
    }
}
