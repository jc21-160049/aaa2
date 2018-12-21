using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class insert : TabbedPage
	{
        public static List<DateTime> f1 = new List<DateTime>();
        //public static string f1;
		public insert (List<DateTime> dt)
		{
			InitializeComponent ();

            aaa.Text = dt[0].ToString("日付：yyyy年MM月dd日");
            f1 = dt;

            //string1.Text = "金額：";
            b1.Clicked += b1Clicked;
            b2.Clicked += b2Clicked;
            b3.Clicked += b3Clicked;
            b4.Clicked += b4Clicked;
            b5.Clicked += b5Clicked;
            b6.Clicked += b6Clicked;
            b7.Clicked += b7Clicked;
            b8.Clicked += b8Clicked;
            b9.Clicked += b9Clicked;

            var entry = new Entry { Keyboard = Keyboard.Numeric };
        }


        private void b1Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b1.Text;
        }
        private void b2Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b2.Text;
        }
        private void b3Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b3.Text;
        }
        private void b4Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b4.Text;
        }
        private void b5Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b5.Text;
        }
        private void b6Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b6.Text;
        }
        private void b7Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b7.Text;
        }
        private void b8Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b8.Text;
        }
        private void b9Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b9.Text;
        }



    }

}