using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace TipCalculator
{
	[Activity(Label = "TipCalculator", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		EditText inputBill;
		Button   calculateButton;
		TextView outputTip;
		TextView outputTotal;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Main);

			inputBill       = FindViewById<EditText>(Resource.Id.inputBill);
			calculateButton = FindViewById<Button  >(Resource.Id.calculateButton);
			outputTip       = FindViewById<TextView>(Resource.Id.outputTip);
			outputTotal     = FindViewById<TextView>(Resource.Id.outputTotal);

			calculateButton.Click += OnCalculateClick;
		}

		void OnCalculateClick(object sender, EventArgs e)
		{
			string text = inputBill.Text;

			double bill;

			if (double.TryParse(text, out bill))
			{

				var tip = bill * 0.15;
				var total = bill + tip;

				outputTip.Text = tip.ToString("C");
				outputTotal.Text = total.ToString("C");
			}
		}
	}
}