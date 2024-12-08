using CSharkEgitimKampi301.BusinessLayer.Abstract;
using CSharkEgitimKampi301.BusinessLayer.Concrete;
using CSharkEgitimKampi301.DataAccessLayer.Abstract;
using CSharkEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharkEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharkEgitimKampi301.PresentationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {

        }

        private void rdbPassive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            btnList_Click(sender, e);
            MessageBox.Show("Succesfully added.");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            int updatedId = int.Parse(txtCategoryId.Text);
            var updatedValue = _categoryService.TGetById(updatedId);
            updatedValue.CategoryName = txtCategoryName.Text;
            updatedValue.CategoryStatus = true;
            _categoryService.TUpdate(updatedValue);
            btnList_Click(sender,e);
            MessageBox.Show("Succesfully updated.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var deletedValues = _categoryService.TGetById(id);
            _categoryService.TDelete(deletedValues);
            btnList_Click(sender, e);
            MessageBox.Show("Successfully deleted.");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var values = _categoryService.TGetById(id);
            dataGridView1.DataSource = new List<object> { values };
        }
    }
}
