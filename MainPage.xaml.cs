﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
namespace App7
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {

            

            InitializeComponent();

           

        }
    }

    public class MyModel
    {
        public string FormattedDate { get; set; }
        public string TitleText { get; set; }
    }
}
