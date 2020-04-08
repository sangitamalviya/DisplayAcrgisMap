using Esri.ArcGISRuntime.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DisplayMap
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MapDisplay : ContentPage
	{
		public MapDisplay ()
		{
			InitializeComponent ();
            Initialize();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _ = Navigation.PopAsync();
        }
         async void Initialize()
        {
            Map uxMap = null;
            ArcGISTiledLayer tiledLayer = new ArcGISTiledLayer(new Uri("https://services.arcgisonline.com/ArcGIS/rest/services/World_Topo_Map/MapServer"));
            await tiledLayer.LoadAsync();
            Basemap basemap = new Basemap(tiledLayer);
            uxMap = new Map(basemap);
            MyMapView.Map = uxMap;
        }
    }
}