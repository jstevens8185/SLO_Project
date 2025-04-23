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
        /******************************************************
         * Function Name: DataGridView
         *
         * Parameters: None
         *
         * Return Type: void (Constructor)
         * 
         * Description: Initializes the DataGridView form.
         *********************************************************/

        public DataGridView()
        {
            InitializeComponent();
        }

        // Entity Framework database context for accessing SLO data
        private SlosClassLibrary.SloDatabaseEntities dbcontext =
            new SlosClassLibrary.SloDatabaseEntities();


        /******************************************************
         * Function Name: Form1_Load
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Calls LoadDB() when form loads
         *********************************************************/

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        /******************************************************
         * Function Name: LoadDB
         *
         * Parameters: None
         *
         * Return Type: async Task (void-like)
         * 
         * Description: Asynchronously loads SLO data from the database,
         * orders it by SLO_ID, and binds it to the sLOBindingSource.
         *********************************************************/

        private async void LoadDB()
        {
            await dbcontext.SLOs.OrderBy(slo => slo.SLO_ID).LoadAsync();

            sLOBindingSource.DataSource = dbcontext.SLOs.Local;
        }


        /******************************************************
         * Function Name: sLOBindingNavigatorSaveItem_Click
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Validates and commits changes to the SLOs.
         * Handles validation errors and displays an error message if
         * required fields (Description and Title) are empty.
         *********************************************************/

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
