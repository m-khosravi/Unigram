// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLDocumentAttributeHasStickers : TLDocumentAttributeBase 
	{
		public TLDocumentAttributeHasStickers() { }
		public TLDocumentAttributeHasStickers(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.DocumentAttributeHasStickers; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9801D2F7);
		}
	}
}