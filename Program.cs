using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleNotification notificationService = new ConsoleNotification();

            User user1 = new User("Tim", notificationService);
            user1.changeName("Steve");
        }
    }
}
