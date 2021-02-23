using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

using ArdClock.src.ArdPage.PageElements;

using BaseLib;

namespace ArdClock.src.UIGenerate
{
    public class UIBaseEl : AbstrUIBase
    {
        private ContextMenu DPContextMenu;

        public UIBaseEl(int Height)
        {
            DPContextMenu = new ContextMenu();
            MenuItem mi = new MenuItem();

            Container = new DockPanel();
            ((DockPanel)Container).LastChildFill = false;

            Container.Height = Height;
            
            mi.Header = "Del";
            mi.Click += delClick;
            
            DPContextMenu.Items.Add(mi);

            Container.ContextMenu = DPContextMenu;
            Container.AllowDrop = true;
        }

        public new void delClick(Object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
            MessageBox.Show(System.Windows.Input.Mouse.LeftButton.ToString());   
        }

        private void lbl1_MouseDown(object sender, EventArgs e)
        {
            DockPanel lbl = (DockPanel)sender;
            DragDrop.DoDragDrop(lbl, ID, DragDropEffects.Copy);
        }

        public override AbstrPageEl CompileElement() {
            return null; 
        }
    }
}
