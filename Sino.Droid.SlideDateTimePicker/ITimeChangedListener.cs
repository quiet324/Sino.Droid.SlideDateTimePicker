using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Sino.Droid.SlideDateTimePicker
{
    public interface ITimeChangedListener
    {
        void OnTimeChanged(int hour, int minute);
    }
}