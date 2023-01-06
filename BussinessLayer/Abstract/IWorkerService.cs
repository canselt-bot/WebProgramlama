using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IWorkerService
    {
        void WorkerAdd(Worker worker);
        void WorkerRemove(Worker worker);
        void WorkerUpdate(Worker worker);
        List<Worker> GetAllWorkers();
        Worker GetById(int id);
    }
}
