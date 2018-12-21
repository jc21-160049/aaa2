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
	public partial class notification : ContentPage
	{
		public notification ()
		{
			InitializeComponent ();
		}
        
        private void Button_Clicked(object sender, EventArgs e)
        {
            Button tb = new Button();
            tb.Text = "追加された";
            AbsoluteLayout          
        }
    }
}