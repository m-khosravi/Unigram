// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLKeyboardButtonRequestGeoLocation : TLKeyboardButtonBase 
	{
		public TLKeyboardButtonRequestGeoLocation() { }
		public TLKeyboardButtonRequestGeoLocation(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.KeyboardButtonRequestGeoLocation; } }

		public override void Read(TLBinaryReader from)
		{
			Text = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xFC796B3F);
			to.Write(Text);
		}
	}
}