using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class insert2 : ContentPage
	{
        public static List<DateTime> sssList = new List<DateTime>();
        public insert2 ()
		{
			InitializeComponent ();
            aaa.Text = Home.ddd[0].ToString("日付：yyyy年MM月dd日"); ;
        }
    }
}