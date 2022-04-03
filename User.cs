using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class User
    {
        private INotificationService _consoleNotification;
        public User(string Name, INotificationService notificationService)
        {
            Name = name;
            _consoleNotification = notificationService;
        }

        public string name { get; private set; }

        public void changeName(string newName)
        {
            name = newName;
            _consoleNotification.NotifyNameChanged(this);
        }
    }
}
