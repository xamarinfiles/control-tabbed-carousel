﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace TabbedCarouselDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            TabbedCarousel.TabNames =
            // new string[] {"abc", "def", "ghi", "jkl", "mno", "pqr", "stu","vwx", "yz"};
                new List<string>
                {
                    "Motorcycle", "Car", "Plane", "Boat", "Bike", "Jeep", "Train", "Truck"
                };

            //TabbedCarousel.TabView = new DataTemplate(typeof(TabbedView));

            TabbedCarousel.TabViews =
                // new string[] {"abc", "def", "ghi", "jkl", "mno", "pqr", "stu","vwx", "yz"};
                new ObservableCollection<View>
                {
                    new Label
                    {
                        Text = "Motorcycle",
                        BackgroundColor = Color.Yellow,
                        TextColor = Color.Black,
                        FontAttributes = FontAttributes.Bold,
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center
                    },
                    new Label
                    {
                        Text = "Car",
                        BackgroundColor = Color.Salmon,
                        TextColor = Color.Black,
                        FontAttributes = FontAttributes.Bold,
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center
                    },
                    new Label
                    {
                        Text = "Plane",
                        BackgroundColor = Color.DarkSeaGreen,
                        TextColor = Color.Black,
                        FontAttributes = FontAttributes.Bold,
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center
                    },
                    new Label
                    {
                        Text = "Boat",
                        BackgroundColor = Color.PaleVioletRed,
                        TextColor = Color.Black,
                        FontAttributes = FontAttributes.Bold,
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center
                    },
                    new Label
                    {
                        Text = "Bike",
                        BackgroundColor = Color.Orange,
                        TextColor = Color.Black,
                        FontAttributes = FontAttributes.Bold,
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center
                    },
                    new Label
                    {
                        Text = "Jeep",
                        BackgroundColor = Color.CornflowerBlue,
                        TextColor = Color.Black,
                        FontAttributes = FontAttributes.Bold,
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center
                    },
                    new Label
                    {
                        Text = "Train",
                        BackgroundColor = Color.LightSlateGray,
                        TextColor = Color.Black,
                        FontAttributes = FontAttributes.Bold,
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center
                    },
                    new Label
                    {
                        Text = "Truck",
                        BackgroundColor = Color.MediumPurple,
                        TextColor = Color.Black,
                        FontAttributes = FontAttributes.Bold,
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center
                    }

                    //"Motorcycle", "Car", "Plane", "Boat", "Bike", "Jeep", "Train", "Truck"
                };
        }
    }
}