namespace P04.Recharge
{
    public abstract class Worker : IWorker
    {
        protected Worker(string id, int workingHours)
        {
            Id = id;
            WorkingHours = workingHours;
        }

        public string Id { get; set; }

        public int WorkingHours { get; set; }

        public void Work(int hours)
        {
            WorkingHours += hours;
        }
    }
}