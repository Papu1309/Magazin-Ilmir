using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Магазин.Datagrid;



namespace Магазин.Magas
{
    /// <summary>
    /// Логика взаимодействия для Vid.xaml
    /// </summary>
    public partial class aa : Page
    {
        //public BindingList<Spicok> Spicokk;
        public List<Spicok> Spicoks { get; set; }
        public aa()
        {
            InitializeComponent();
            LoadSpicoks();
            SpicokListWiew.ItemsSource = Spicoks;

        }
        public void LoadSpicoks()
        {
            Spicoks = new List<Spicok>
            {
                  new Spicok() {Name = "Свечи зажигания",Price = 560,Foto = "/Photo/AMORT.jpg"},
                  new Spicok() {Name = "Амортизаторы", Price = 7840,Foto = "/Photo/amortiz.jpg" },
                  new Spicok() {Name = "Генератор", Price = 13700,Foto = "/Photo/generator.jpg" },
                  new Spicok() {Name = "Радиатор", Price = 9800,Foto = "/Photo/radiator.jpg" },
                  new Spicok() {Name = "Ремень ГРМ c роликом в комплекте", Price = 1790,Foto = "/Photo/remen.jpg" },
                  new Spicok() {Name = "Воздушный фильтр", Price = 3700,Foto = "/Photo/vozd.jpg" },
                  new Spicok() {Name = "Масляной фильтр", Price = 680,Foto = "/Photo/masl filtr.jpg" },
                  new Spicok() {Name = "Водяной насос", Price = 3899,Foto = "/Photo/vod nasos.jpg" },
                  new Spicok() {Name = "Стартер", Price = 16700,Foto = "/Photo/starter.jpg" },
                  new Spicok() {Name = "Гидроусилитель руля", Price = 11399,Foto = "/Photo/gur.jpg" },
                  new Spicok() {Name = "Комплект сцепления", Price = 9399,Foto = "/Photo/sceplenie.jpg" },
                  new Spicok() {Name = "Тормозные колодки", Price = 2390,Foto = "/Photo/colodki.jpg" },
                  new Spicok() {Name = "Тормозные диски", Price = 3890,Foto = "/Photo/torm disci.jpg" },
                  new Spicok() {Name = "Шрус", Price = 5690,Foto = "/Photo/shrus.jpg" },
                  new Spicok() {Name = "Наконечник", Price = 6790,Foto = "/Photo/naconech.jpg" },
                  new Spicok() {Name = "Бескаркасные дворники", Price = 830,Foto = "/Photo/dvornici.jpg" },
                  new Spicok() {Name = "Лобовое стекло", Price = 12399,Foto = "/Photo/lobovoe.jpg" },
                  new Spicok() {Name = "Штампованный диск", Price = 1899,Foto = "/Photo/shtamp-disc.jpg" },
                  new Spicok() {Name = "Динамики", Price = 4799,Foto = "/Photo/dinamici.jpg" },
                  new Spicok() {Name = "Автомагнитола", Price = 1599,Foto = "/Photo/magnitola.jpg" },
                  new Spicok() {Name = "Руль", Price = 3599,Foto = "/Photo/rul.jpg" },
                  new Spicok() {Name = "Приборная панель", Price = 14899,Foto = "/Photo/panel.jpg" },
            };

        }
        public void Korzina_Click(object sender, RoutedEventArgs e)
        {
            List<Spicok> selectedSpicoks = new List<Spicok>();

            foreach (var Spicok in Spicoks)
            {
                if (Spicok.IsSelected)
                {
                    selectedSpicoks.Add(Spicok);
                }
            }
            Corzina corzina = new Corzina(selectedSpicoks);
            //this.Content = corzina;
            corzina.Show();
        }

        private void SpicokListWiew_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
