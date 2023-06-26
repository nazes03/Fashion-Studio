﻿using Fashion_Studio.Entities;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fashion_Studio.Pages
{
    /// <summary>
    /// Логика взаимодействия для ModelPage.xaml
    /// </summary>
    public partial class ModelPage : Page
    {
        Model1 context;
        public ModelPage(Model1 _context)
        {
            InitializeComponent();
            context = _context;
        }
    }
}