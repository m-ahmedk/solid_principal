using SOLID.Repository.Interface;

namespace SOLID.Repository.Service.ISP
{
    /*
     * Here we separated responsibilities/purposes, distributed them on multiple interfaces, 
     * and provided good abstraction.
     */

    public class TeamLead : ILead, IProgrammer
    {
        public async Task CreateTask()
        {
            // create task
        }

        public async Task AssignTask()
        {
            // assign task to programmers
        }

        public async Task DeleteTask()
        {
            // delete task
        }

        public async Task WorkOnTask()
        {
            // work on task
        }
    }
}
