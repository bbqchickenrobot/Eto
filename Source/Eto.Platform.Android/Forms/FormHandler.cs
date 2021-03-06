using System;
using Eto.Forms;
using Eto.Drawing;
using a = Android;
using av = Android.Views;
using aw = Android.Widget;

namespace Eto.Platform.Android.Forms
{
	/// <summary>
	/// Handler for <see cref="IForm"/>
	/// </summary>
	/// <copyright>(c) 2013 by Curtis Wensley</copyright>
	/// <license type="BSD-3">See LICENSE for full terms</license>
	public class FormHandler : AndroidWindow<Form>, IForm
	{
		public void Show()
		{
			// TODO: create activity if it doesn't exist
			Activity.SetContentView(ContainerControl);
		}
	}
}

