using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bees
{
    public partial class Form1 : Form
    {
        List<Bee> hive;
        public Form1()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_DamageBees_Click(object sender, EventArgs e)
        {
            DamageBees(this.hive);
            UpdateDataGrid();
        }


       

        private void Btn_CreateHive_Click(object sender, EventArgs e)
        {
            hive = CreateHive();
            btn_CreateHive.Enabled = false;
            UpdateDataGrid();


        }

        void UpdateDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var bee in hive)
            {
                dataGridView1.Rows.Add(bee.number, bee.type, bee.health, bee.isAlive ? "alive" : "dead");
            }

        }


        List<Bee> CreateHive()
        {            
            int eachTypeSize = 10;

            BeeFactory beeFactory = new BeeFactory();
            List<Bee> hive = new List<Bee>();

            foreach (int beeNum in Enumerable.Range(1, eachTypeSize))
            {
                hive.Add(beeFactory.CreateQueen(beeNum));
                hive.Add(beeFactory.CreateWorker(beeNum));
                hive.Add(beeFactory.CreateDrone(beeNum));

            }
            return hive;
        }


        void DamageBees(List<Bee> hive)
        {
            Random rnd = new Random();
            foreach (var bee in hive)
            {
                var randomValue = rnd.Next(0, 80);
                bee.Damage(randomValue);
            }
        }
    }
}
