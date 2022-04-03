using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class ConsoleNotification : INotificationService
    {

        public void NotifyNameChanged(User user)
        {
            Console.WriteLine($"Name has been changed to: {user.name}");
        }
    }
}
