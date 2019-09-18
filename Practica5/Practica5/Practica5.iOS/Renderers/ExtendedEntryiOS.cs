﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Practica5.Controls;
using Practica5.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryiOS))]

namespace Practica5.iOS.Renderers
{
    public class ExtendedEntryiOS : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BackgroundColor = UIColor.Green;
                Control.BorderStyle = UIKit.UITextBorderStyle.None;
            }
        }

    }
}