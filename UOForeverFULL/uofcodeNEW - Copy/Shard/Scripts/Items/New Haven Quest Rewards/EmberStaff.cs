using System;
using Server;

namespace Server.Items
{
	public class EmberStaff : QuarterStaff
	{
		public override int LabelNumber{ get{ return 1077582; } } // Ember Staff

		[Constructable]
		public EmberStaff()
		{
			LootType = LootType.Blessed;
		}

		public EmberStaff( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
}
