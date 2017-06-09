// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLFutureSalts : TLObject 
	{
		public Int64 ReqMsgId { get; set; }
		public Int32 Now { get; set; }
		public TLVector<TLFutureSalt> Salts { get; set; }

		public TLFutureSalts() { }
		public TLFutureSalts(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.FutureSalts; } }

		public override void Read(TLBinaryReader from)
		{
			ReqMsgId = from.ReadInt64();
			Now = from.ReadInt32();
			Salts = TLFactory.Read<TLVector<TLFutureSalt>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt64(ReqMsgId);
			to.WriteInt32(Now);
			to.WriteObject(Salts);
		}
	}
}