using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportHelper
{
    public interface ISubject
    {
        void RegisterObs(IMainObserver ob);
        void UnregisterObs(IMainObserver ob);
        void NotifyObs();
    }
}
