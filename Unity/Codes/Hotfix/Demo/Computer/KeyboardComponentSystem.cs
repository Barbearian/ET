using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class KeyboardComponentSystem
    {
        public static void Start(this KeyboardComponent self) {
            Log.Debug("Keyboard Attached");
        }
    }
}
