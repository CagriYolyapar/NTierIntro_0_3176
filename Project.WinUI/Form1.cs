using Project.BLL.DesignPatterns.GenericRepository.EFConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {
        //Category



        CategoryRepository _cr;
        public Form1()
        {
            InitializeComponent();
            _cr = new CategoryRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetCategories();
        }



        private void BtnEkle_Click(object sender, EventArgs e)
        {
            AddCategory();
            GetCategories();
        }




        Category _secilen;
        private void LstResult_Click(object sender, EventArgs e)
        {
            if (LstResult.SelectedItem != null)
            {
                _secilen = (Category)LstResult.SelectedItem;
                TxtIsim.Text = _secilen.CategoryName;
                TxtAciklama.Text = _secilen.Description;
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            UpdateCategory();
            GetCategories();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DeleteCategory();
            GetCategories();
        }

        private void BtnYokEt_Click(object sender, EventArgs e)
        {
            DestroyCategory();
            GetCategories();
        }

        #region TasarimsalMetotlar
        private void GetCategories()
        {
            LstResult.DataSource = _cr.GetAll();

        }
        private void AddCategory()
        {
            _cr.Add(new Category
            {
                CategoryName = TxtIsim.Text,
                Description = TxtAciklama.Text
            });
        }

        private void UpdateCategory()
        {
            if (_secilen != null)
            {
                _secilen.CategoryName = TxtIsim.Text;
                _secilen.Description = TxtAciklama.Text;
                _cr.Update(_secilen);
            }
            else
            {
                MessageBox.Show("Lütfen önce Kategori seciniz");

            }
        }

        private void DeleteCategory()
        {
            if (_secilen != null) _cr.Delete(_secilen);
            else MessageBox.Show("Lütfen bir Kategori seciniz");

        }

        private void DestroyCategory()
        {
            if (_secilen != null) MessageBox.Show(_cr.Destroy(_secilen));
            else MessageBox.Show("Lütfen önce kategori seciniz");
        }

        #endregion

        private void BtnPasif_Click(object sender, EventArgs e)
        {
            LstResult.DataSource = _cr.GetActives();


           
        }

        private void BtnGuncel_Click(object sender, EventArgs e)
        {
            LstResult.DataSource = _cr.GetModifieds();
        }

        private void BtnPasif_Click_1(object sender, EventArgs e)
        {
            LstResult.DataSource = _cr.GetPassives();
        }
    }
}
