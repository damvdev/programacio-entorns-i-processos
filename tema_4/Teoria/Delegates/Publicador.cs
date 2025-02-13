using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colleccions
{
    public class Publicador
    {
        public delegate void NotificacioEventHandler(string missatge);
        public event NotificacioEventHandler MissatgeEnviat;
        public void EnviarMissatge(string missatge) {
            MissatgeEnviat?.Invoke(missatge);
        }
    }
}
