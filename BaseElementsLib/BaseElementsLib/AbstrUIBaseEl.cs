using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace BaseLib
{
    public abstract class AbstrUIBase
    {
        public int ID;
        public Panel Container;
        public event EventHandler DelClick;

        public abstract AbstrPageEl CompileElement();

        protected void delClick(object sender, EventArgs e)
        {
            if (DelClick != null)
                DelClick.Invoke(this, e);
        }
    }
}
