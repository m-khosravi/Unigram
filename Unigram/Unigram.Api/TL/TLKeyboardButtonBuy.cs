// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLKeyboardButtonBuy : TLKeyboardButtonBase 
	{
		public TLKeyboardButtonBuy() { }
		public TLKeyboardButtonBuy(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.KeyboardButtonBuy; } }

		public override void Read(TLBinaryReader from)
		{
			Text = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xAFD93FBB);
			to.Write(Text);
		}
	}
}