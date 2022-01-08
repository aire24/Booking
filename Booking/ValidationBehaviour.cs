using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xamarin.Forms;
using Xamarin.Essentials;
using Color = Xamarin.Forms.Color;

namespace Booking
{
    class ValidationBehaviour : Behavior<Editor>
    {
        protected override void OnAttachedTo(Editor entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }
        protected override void OnDetachingFrom(Editor entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }
        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            ((Editor)sender).BackgroundColor = string.IsNullOrEmpty(args.NewTextValue) ? Xamarin.Forms.Color.Red : Color.Default;
        }
    }
}