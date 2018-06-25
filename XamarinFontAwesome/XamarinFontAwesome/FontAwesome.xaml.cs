using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFontAwesome
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FontAwesome : Label
	{
		public FontAwesome ()
		{
			InitializeComponent ();

			if (Device.RuntimePlatform == Device.Android)
			{
				Resources.Add("FontAwesome-Regular", "FontAwesomeRegular.ttf#Font Awesome 5 Free");
				Resources.Add("FontAwesome-Solid", "FontAwesomeSolid.ttf#Font Awesome 5 Free");
			}
			else
			{
				Resources.Add("FontAwesome-Regular", "FontAwesome5FreeRegular");
				Resources.Add("FontAwesome-Solid", "FontAwesome5FreeSolid");
			}
		}
	}
}