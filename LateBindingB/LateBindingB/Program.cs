using System;

namespace LateBindingB
{
	public class MyControl{
		public int left=0, top=0;
		public MyControl(){
		}
		public MyControl(int left,int top)
		{
			this.left = left;
			this.top = top;
		}
		public virtual void DrawWindow()
		{
			Console.WriteLine ();
			Console.WriteLine ("DRAWING CONTROL AT({0},{1})", left, top);
		}
	}
	public class ListBox:MyControl
	{
		public String listcontent="";
		public ListBox(int left,int top,String listcontent)
		{
			base.top = top;
			base.left = left;
			this.listcontent = listcontent;
		}
		public override void DrawWindow ()
		{
			Console.WriteLine ();
			base.DrawWindow ();
			Console.WriteLine ("DRAWING LISTBOX AT({0},{1})->WITH CONTENT({2})",base.left,base.top,listcontent);
		}
	}
	public class Button:MyControl
	{
		public Button(int left,int top)
		{
			base.top = top;
			base.left = left;
		}
		public override void DrawWindow ()
		{
			Console.WriteLine ();
			base.DrawWindow ();
			Console.WriteLine ("DRAWING BUTTON AT({0},{1})",base.left,base.top);
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			MyControl m = new MyControl (10, 10);
			ListBox l = new ListBox (20, 20,"LIST BOX CONTENT");
			Button b = new Button (30, 30);
			m.DrawWindow ();
			l.DrawWindow ();
			b.DrawWindow ();

			MyControl[] marr = new MyControl[3];
			marr [0] = new MyControl (40, 40);
			marr [1] = new ListBox (50, 50,"LIST BOX CONTENT");
			marr [2] = new Button (60, 60);

			for (int i=0; i<3; i++) {
				marr [i].DrawWindow ();
			}

		}
	}

}
