
// This file has been generated by the GUI designer. Do not modify.
namespace CommBug
{
	public partial class PreferenceWindow
	{
		private global::Gtk.HPaned hpanedMain;

		private global::Gtk.ScrolledWindow scrolledwindowLeft;

		private global::Gtk.VBox vboxLeft;

		private global::Gtk.Label labelTest;

		private global::Gtk.Notebook notebookRight;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget CommBug.PreferenceWindow
			this.Name = "CommBug.PreferenceWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("首选项");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-preferences", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child CommBug.PreferenceWindow.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "PreferenceWindow_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child PreferenceWindow_VBox.Gtk.Box+BoxChild
			this.hpanedMain = new global::Gtk.HPaned ();
			this.hpanedMain.CanFocus = true;
			this.hpanedMain.Name = "hpanedMain";
			this.hpanedMain.Position = 294;
			// Container child hpanedMain.Gtk.Paned+PanedChild
			this.scrolledwindowLeft = new global::Gtk.ScrolledWindow ();
			this.scrolledwindowLeft.CanFocus = true;
			this.scrolledwindowLeft.Name = "scrolledwindowLeft";
			this.scrolledwindowLeft.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindowLeft.Gtk.Container+ContainerChild
			global::Gtk.Viewport w2 = new global::Gtk.Viewport ();
			w2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.vboxLeft = new global::Gtk.VBox ();
			this.vboxLeft.Name = "vboxLeft";
			this.vboxLeft.Spacing = 6;
			// Container child vboxLeft.Gtk.Box+BoxChild
			this.labelTest = new global::Gtk.Label ();
			this.labelTest.Name = "labelTest";
			this.labelTest.LabelProp = global::Mono.Unix.Catalog.GetString ("该功能测试中,不可用.请关注下一个版本.");
			this.vboxLeft.Add (this.labelTest);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vboxLeft[this.labelTest]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			w2.Add (this.vboxLeft);
			this.scrolledwindowLeft.Add (w2);
			this.hpanedMain.Add (this.scrolledwindowLeft);
			global::Gtk.Paned.PanedChild w6 = ((global::Gtk.Paned.PanedChild)(this.hpanedMain[this.scrolledwindowLeft]));
			w6.Resize = false;
			// Container child hpanedMain.Gtk.Paned+PanedChild
			this.notebookRight = new global::Gtk.Notebook ();
			this.notebookRight.CanFocus = true;
			this.notebookRight.Name = "notebookRight";
			this.notebookRight.CurrentPage = -1;
			this.notebookRight.Scrollable = true;
			this.hpanedMain.Add (this.notebookRight);
			w1.Add (this.hpanedMain);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(w1[this.hpanedMain]));
			w8.Position = 0;
			// Internal child CommBug.PreferenceWindow.ActionArea
			global::Gtk.HButtonBox w9 = this.ActionArea;
			w9.Name = "PreferenceWindow_ActionArea";
			w9.Spacing = 10;
			w9.BorderWidth = ((uint)(5));
			w9.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child PreferenceWindow_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w10 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w9[this.buttonCancel]));
			w10.Expand = false;
			w10.Fill = false;
			// Container child PreferenceWindow_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w11 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w9[this.buttonOk]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 663;
			this.DefaultHeight = 463;
			this.buttonOk.HasDefault = true;
			this.Show ();
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
