using System;
using System.Collections.Concurrent;

namespace Lab3
{
	public abstract class BaseModule
	{
		internal int id;
		internal Manager messageManager;
		internal ConcurrentQueue<Message> messageQueue = new ConcurrentQueue<Message>();
		public BaseModule(int id, Manager messageManager)
		{
			this.id = id;
			this.messageManager = messageManager;
			messageManager.RegisterModule(this);
		}
		public void SendMessage(Message message)
		{
			messageManager.GetMessage(message);
		}

		public void ReceiveMessage(Message message)
		{
			messageQueue.Enqueue(message);
		}

		public bool HasMessage()
		{
			return !messageQueue.IsEmpty;
		}


		protected abstract void HandleMessage(Message message);

	}
}

