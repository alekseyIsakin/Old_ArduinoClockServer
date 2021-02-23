using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseLib
{
    public abstract class AbstrPageEl
    {
        public int ID { get; protected set; }

        public abstract void SetID(int id);

        public abstract List<byte> GenSendData();
        public abstract byte GetTypeEl();
    }
}
