// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPhoneCallDiscardReasonHangup : TLPhoneCallDiscardReasonBase 
	{
		public TLPhoneCallDiscardReasonHangup() { }
		public TLPhoneCallDiscardReasonHangup(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.PhoneCallDiscardReasonHangup; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x57ADC690);
			if (cache) WriteToCache(to);
		}
	}
}