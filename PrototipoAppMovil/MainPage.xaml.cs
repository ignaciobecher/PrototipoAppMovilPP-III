using PrototipoAppMovil.DataAccess;
using PrototipoAppMovil.Modelos;
using System;

namespace PrototipoAppMovil
{
    public partial class MainPage : ContentPage
    {
        private readonly AppDbContext _dbcontext;
        private Menus selectedMenu; 

        public MainPage(AppDbContext dbContext)
        {
            _dbcontext = dbContext;
            InitializeComponent();

            //_dbcontext.Menues.Add(new Menus
            //{
            //    idMenu = Guid.NewGuid().ToString("N"),
            //    descripcion = "Hamburguesas con papas",
            //    valor = 2
            //});
            //_dbcontext.Menues.Add(new Menus
            //{
            //    idMenu = Guid.NewGuid().ToString("N"),
            //    descripcion = "Milanesas con puré",
            //    valor = 4
            //});
            //_dbcontext.Menues.Add(new Menus
            //{
            //    idMenu = Guid.NewGuid().ToString("N"),
            //    descripcion = "Pizza",
            //    valor = 3
            //});
            //_dbcontext.SaveChanges();

            lvMenus.ItemsSource = _dbcontext.Menues.ToList();
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            selectedMenu = e.SelectedItem as Menus; 

            OrderButton.IsEnabled = selectedMenu != null;
        }

        private void OnOrderClicked(object sender, EventArgs e)
        {
            if (selectedMenu != null)
            {
                SuccessLabel.IsVisible = true;
                OrderButton.IsEnabled = false; 
                lvMenus.SelectedItem = null; 
            }
        }
    }
}
