﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace SistemaGym.ventas
{
    /// <summary>
    /// Interaction logic for Ventas.xaml
    /// </summary>
    public partial class Ventas
    {
        public Ventas()
        {
            InitializeComponent();
            CajaEstado(true);
        }

        private void CajaEstado(bool estado)
        {
            if (estado) {
                AbrirCaja c = new AbrirCaja();
                c.ShowDialog();
            }
                
        }
        private void btn_buscar_prod_Click(object sender, RoutedEventArgs e)
        {
            ventas.Productos p = new ventas.Productos();
            p.Show();
        }
    }
}
