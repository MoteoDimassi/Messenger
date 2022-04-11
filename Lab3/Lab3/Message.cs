using System;
namespace Lab3
{
	public class Message
	{
		internal string id;
		internal int sender;
		internal int recevier;
		internal DateTime sendTime;

		internal Message(string id, int sender, int recevier, DateTime dateTime)
        {
			this.id = id;
			this.sender = sender;
			this.recevier = recevier;
			this.sendTime = sendTime;
        }

		internal void Print()
        {
			Console.WriteLine($"id: {id}; sender: {sender}; recevier: {recevier}; sendTime: {sendTime}");
        }
	}
}

