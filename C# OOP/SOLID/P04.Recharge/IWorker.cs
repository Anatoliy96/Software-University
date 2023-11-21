using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Recharge
{
    public interface IWorker
    {
        string Id { get; }
        int WorkingHours { get; }

        public void Work(int hours);
    }
}
