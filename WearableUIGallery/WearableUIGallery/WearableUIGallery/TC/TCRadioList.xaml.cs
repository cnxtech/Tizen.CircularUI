﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.CircularUI;
using Xamarin.Forms.Xaml;

namespace WearableUIGallery.TC
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TCRadioList : CirclePage
	{
		public TCRadioList()
		{
			InitializeComponent ();
		}

        public void OnItemTapped(object sender, ItemTappedEventArgs args)
        {
            if (args.Item == null) return;

            var desc = args.Item as TCDescribe;
            if (desc != null && desc.Class != null)
            {
                Type pageType = desc.Class;

                var page = Activator.CreateInstance(pageType) as Page;
                NavigationPage.SetHasNavigationBar(page, false);
                Navigation.PushAsync(page as Page);
            }
        }
    }
}