using System;
using Server.Network;

namespace Server.Items
{
	[FlipableAttribute( 0x13B8, 0x13B7 )]
	public class ThinLongsword : BaseSword
	{
		public override int OldStrengthReq{ get{ return 25; } }
		public override int NewMinDamage{ get{ return 5; } }
		public override int NewMaxDamage{ get{ return 33; } }
		public override int DiceDamage{ get{ return Utility.Dice( 2, 15, 3 ); } } // 2d15+3 (5-33)
		public override int OldSpeed{ get{ return 35; } }

		public override int DefHitSound{ get{ return 0x237; } }
		public override int DefMissSound{ get{ return 0x23A; } }

		public override int InitMinHits{ get{ return 31; } }
		public override int InitMaxHits{ get{ return 110; } }

		[Constructable]
		public ThinLongsword() : base( 0x13B8 )
		{
			Weight = 1.0;
		}

		public ThinLongsword( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}