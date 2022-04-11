using System;
using System.Reflection;

namespace Lab3
{
	public class Manager
	{
		Dictionary<int, BaseModule> modules = new Dictionary<int, BaseModule>();

        public void GetMessage(Message message)
        {
            if (modules[message.recevier] != null)
            {
                SendMessage(message);
            }
            else
            {
                SendMessage(new Message("-1", message.sender,404, DateTime.Now));
            }

        }

        public void RegisterModule(BaseModule module)
        {
            modules.Add(module.id, module);
        }

        private void SendMessage(Message message)
        {
            modules[message.recevier].ReceiveMessage(message);

        }

    }
}

