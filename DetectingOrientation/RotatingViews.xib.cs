
using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace DetectingOrientation
{
	public partial class RotatingViews : UIViewController
	{
		#region Constructors

		// The IntPtr and initWithCoder constructors are required for controllers that need 
		// to be able to be created from a xib rather than from managed code

		public RotatingViews (IntPtr handle) : base(handle)
		{
			Initialize ();
		}

		[Export("initWithCoder:")]
		public RotatingViews (NSCoder coder) : base(coder)
		{
			Initialize ();
		}

		public RotatingViews () : base("RotatingViews", null)
		{
			Initialize ();
		}

		void Initialize ()
		{
		
		}
		
		#endregion
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			return true;
		}

		
		public override void DidRotate (UIInterfaceOrientation fromInterfaceOrientation)
		{
			Console.WriteLine("Finished rotating from " + fromInterfaceOrientation.ToString());
		}

		
		public override void WillRotate (UIInterfaceOrientation toInterfaceOrientation, double duration)
		{
			label.Text = toInterfaceOrientation.ToString();
		}
		
		
	}
}
