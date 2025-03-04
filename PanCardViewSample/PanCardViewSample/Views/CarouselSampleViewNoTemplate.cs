﻿using PanCardView;
using PanCardView.Controls;
using Xamarin.Forms;
using CardCarouselView = PanCardView.CarouselView;
namespace PanCardViewSample.Views
{
    public class CarouselSampleViewNoTemplate : ContentPage
    {
        public CarouselSampleViewNoTemplate()
        {
            Title = "CarouselSampleViewNoTemplate";

            var carousel = new CardCarouselView
            {
                IsHorizontalOrientation = false,
                HeightRequest = 500,
                ItemsSource = new[] {
                    new BoxView { Color = Color.Red },
                    new BoxView { Color = Color.Blue},
                    new BoxView { Color = Color.Yellow}
                },
                IsCyclical = true,
            };

            var button = new Button { Text = "Select last" };
            button.Clicked += (sender, args) => { carousel.SelectedIndex = 2; };

            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Children = {
                        new StackLayout
                        {
                            Children = {
                                carousel
                            }
                        },
                        button
                    }
                }
            };
        }
    }
}