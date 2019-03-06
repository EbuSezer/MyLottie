using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyLottie
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyLottiePage : ContentPage
	{
		public MyLottiePage ()
		{
			InitializeComponent ();
		}

        private void AnimationView2_OnClick(object sender, EventArgs e)
        {
            animationView2.Play();
        }
    }
}