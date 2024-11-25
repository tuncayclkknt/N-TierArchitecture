using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        EgitimKampiEFTravelDbEntities3 db = new EgitimKampiEFTravelDbEntities3();


        private void btnList_Click(object sender, EventArgs e)
        {
            List<TblGuide> values = db.TblGuide.ToList();

            dataGridView1.DataSource = values;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblGuide guide = new TblGuide();
            guide.GuideName = txtName.Text;
            guide.GuideSurname = txtSurname.Text;
            db.TblGuide.Add(guide);
            db.SaveChanges();
            btnList_Click(sender, e);
            MessageBox.Show("Guide added successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removeValue = db.TblGuide.Find(id);
            db.TblGuide.Remove(removeValue);
            db.SaveChanges();
            btnList_Click(sender, e);
            MessageBox.Show("Guide removed successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatedValue = db.TblGuide.Find(id);
            updatedValue.GuideName = txtName.Text;
            updatedValue.GuideSurname = txtSurname.Text;
            db.SaveChanges();
            btnList_Click(sender, e);
            MessageBox.Show("Guide updated successfully.","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.TblGuide.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = value;
            
        }
    }
}
