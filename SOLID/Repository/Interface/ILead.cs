namespace SOLID.Repository.Interface
{
    public interface ILead
    {
        public Task AssignTask();
        public Task CreateTask();
        public Task DeleteTask();
    }
}
