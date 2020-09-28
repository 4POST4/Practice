using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp
{
    public partial class Result : Form
    {
        public Result ResultForm;
        
        public Result()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConBuilder.Command.CommandText = "SELECT TOP (10) [AddressID],[AddressLine1],[AddressLine2]" +
                ",[City],[StateProvinceID],[PostalCode],[rowguid],[ModifiedDate] FROM[TSOOPEX].[Person].[Address]";

            SqlConBuilder.Read(ref this.dataGridView1);
        }
    }
}
