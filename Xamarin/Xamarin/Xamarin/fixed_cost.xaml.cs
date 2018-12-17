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
	public partial class fixed_cost : ContentPage
	{
		public fixed_cost ()
		{
			InitializeComponent ();

            var komokuList = new List<string>
        {

            "通信費",
            "光熱費",
            "保険関係",
            
        };

            foreach (var item in komokuList)
            {
                this.komoku.Items.Add(item);
            }


        }
    }
}