using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipesCatalog
{
    public partial class Form1 : Form
    {
        private Form activeForm;



        public Form1()
        {
            InitializeComponent();
        }


        //Бутон за салати
        private void btnSalads_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SaladsForm(), sender);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHome(), sender);
        }


        //Функционалността за менюто и способност за кликането на бутони
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelButtons.Controls.Add(childForm);
            this.panelButtons.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        //"Home" бутона  
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHome(), sender);
        }


        //Бутона за Продукти(Products)
        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ProductsForm(), sender);
        }


        //Бутона за Favourites
        private void btnFavourites_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FavouritesForm(), sender);
        }


        //Бутона за добавяне на рецепти(AddRecipe)
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AddRecipeForm(), sender);
        }


        //Бутона за предястията(Appetizers)
        private void btnAppetizers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AppetizerForm(), sender);
        }


        //Бутона за основно ястие(Main Courses)
        private void btnMain_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MainCoursesForm(), sender);
        }


        //Бутона за десертите(Deserts)
        private void btnCourses_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DesertsForm(), sender);
        }

        private void panelButtons_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
