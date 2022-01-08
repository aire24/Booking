﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Booking.Data;
using System.IO;

namespace Booking
{
    public partial class App : Application
    {
        static ReservationListDatabase database;
        public static ReservationListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                   ReservationListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                   LocalApplicationData), "ReservationList.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ListEntryPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
