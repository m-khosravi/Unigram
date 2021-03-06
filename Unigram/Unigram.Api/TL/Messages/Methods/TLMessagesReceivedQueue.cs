// <auto-generated/>
using System;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.receivedQueue.
	/// Returns <see cref="Telegram.Api.TL.TLVector<TLlong>"/>
	/// </summary>
	public partial class TLMessagesReceivedQueue : TLObject
	{
		public Int32 MaxQts { get; set; }

		public TLMessagesReceivedQueue() { }
		public TLMessagesReceivedQueue(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesReceivedQueue; } }

		public override void Read(TLBinaryReader from)
		{
			MaxQts = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x55A5BB66);
			to.Write(MaxQts);
		}
	}
}