using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using EXIFLog.EXIFLogLib;
using Newtonsoft;
namespace EXIFLog.GUI
{
    /// <summary>
    /// Interaction logic for RollBuilder.xaml
    /// </summary>
    public partial class RollBuilder : Window
    {
        public RollBuilder()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var name = "ISO" + txtISO.Text;
            bool colour = boxColour.IsChecked ?? false;
            if (colour) { name = "colour" + name; }
            else name = "BW" + name;
            name += ".json";
            var lib = new Builder();
            System.IO.File.WriteAllText(name, Newtonsoft.Json.JsonConvert.SerializeObject(lib.BuildRoll(int.Parse(txtSize.Text), txtCopyright.Text, colour, txtISO.Text)));
            this.Close();

        }
    }
}
