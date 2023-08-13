using SOLID.Repository.Interface;

namespace SOLID.Repository.Service.ISP
{
    /*
     * Since the Manager can't work on a task and, at the same time, no one can assign tasks to 
     * the Manager, the WorkOnTask() will not be in the Manager class, i.e ILead will should not 
     * have WorkOnTask(). WorkOnTask() method should have a different interface based on context
     **/

    public class Manager : ILead
    {
        public async Task CreateTask()
        {
            // Task created
        }

        public async Task AssignTask()
        {
            // Task assigned to programmer
        }

        public async Task DeleteTask()
        {
            // Task deleted
        }
    }
}
