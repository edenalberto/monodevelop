
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Debugger
{
	public partial class ExpressionEvaluatorDialog
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Entry entry;
		private global::Gtk.Button buttonEval;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::MonoDevelop.Debugger.ObjectValueTreeView valueTree;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			MonoDevelop.Components.Gui.Initialize (this);
			// Widget MonoDevelop.Debugger.ExpressionEvaluatorDialog
			this.Name = "MonoDevelop.Debugger.ExpressionEvaluatorDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Expression Evaluator");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child MonoDevelop.Debugger.ExpressionEvaluatorDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(9));
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entry = new global::Gtk.Entry ();
			this.entry.CanFocus = true;
			this.entry.Name = "entry";
			this.entry.IsEditable = true;
			this.entry.ActivatesDefault = true;
			this.entry.InvisibleChar = '●';
			this.hbox1.Add (this.entry);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entry]));
			w2.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonEval = new global::Gtk.Button ();
			this.buttonEval.CanDefault = true;
			this.buttonEval.CanFocus = true;
			this.buttonEval.Name = "buttonEval";
			this.buttonEval.UseUnderline = true;
			this.buttonEval.Label = global::Mono.Unix.Catalog.GetString ("Evaluate");
			this.hbox1.Add (this.buttonEval);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonEval]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.valueTree = new global::MonoDevelop.Debugger.ObjectValueTreeView ();
			this.valueTree.CanFocus = true;
			this.valueTree.Name = "valueTree";
			this.valueTree.AllowAdding = false;
			this.valueTree.AllowEditing = false;
			this.valueTree.AllowPinning = false;
			this.valueTree.RootPinAlwaysVisible = false;
			this.valueTree.AllowExpanding = false;
			this.valueTree.CompactView = false;
			this.GtkScrolledWindow.Add (this.valueTree);
			this.vbox2.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow]));
			w6.Position = 1;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w7.Position = 0;
			// Internal child MonoDevelop.Debugger.ExpressionEvaluatorDialog.ActionArea
			global::Gtk.HButtonBox w8 = this.ActionArea;
			w8.Name = "dialog1_ActionArea";
			w8.Spacing = 6;
			w8.BorderWidth = ((uint)(5));
			w8.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-close";
			this.AddActionWidget (this.buttonOk, -7);
			global::Gtk.ButtonBox.ButtonBoxChild w9 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w8 [this.buttonOk]));
			w9.Expand = false;
			w9.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 716;
			this.DefaultHeight = 410;
			this.buttonEval.HasDefault = true;
			this.Hide ();
			this.buttonEval.Clicked += new global::System.EventHandler (this.OnButtonEvalClicked);
		}
	}
}
