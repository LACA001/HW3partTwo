﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HW3partTwo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabPage : TabbedPage
    {
        public MainTabPage()
        {
            InitializeComponent();
        }

        private void OnAppearing(object sender, EventArgs e)
        {

        }

        private void OnDisappearing(object sender, EventArgs e)
        {

        }
    }
}