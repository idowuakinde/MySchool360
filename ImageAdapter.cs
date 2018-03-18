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

namespace MySchool360
{
	//Create a new class called ImageAdapter that will subclass BaseAdapter:
	public class ImageAdapter : BaseAdapter
	{
		private readonly Context context;

		public ImageAdapter(Context c)
		{
			context = c;
		}

		public override int Count
		{
			get { return thumbIds.Length; }
		}

		public override Java.Lang.Object GetItem(int position)
		{
			return null;
		}

		public override long GetItemId(int position)
		{
			return 0;
		}
		//create a new ImageView for each item referenced by the Adapter
		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			ImageView imageView;

			if (convertView == null)
			{
				// if it's not recycled, initialize some attributes
				imageView = new ImageView(context);
				imageView.LayoutParameters = new AbsListView.LayoutParams(85, 85);
				imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
				imageView.SetPadding(8, 8, 8, 8);
			}
			else
			{
				imageView = (ImageView) convertView;
			}
			imageView.SetImageResource(thumbIds[position]);
			return imageView;
		}
		//references to our images
		private readonly int[] thumbIds = {
			Resource.Drawable.logo_1, 
			Resource.Drawable.logo_2,
			Resource.Drawable.logo_3, 
			Resource.Drawable.logo_4,
			Resource.Drawable.logo_5, 
			Resource.Drawable.logo_6,
			Resource.Drawable.logo_7,
			Resource.Drawable.logo_8
		};
	}
}
