using System;

namespace Server.Items
{
	[FlipableAttribute( 0x2647, 0x2648 )]
	public class DragonLegs : BaseArmor
	{
		public override int InitMinHits{ get{ return 55; } }
		public override int InitMaxHits{ get{ return 75; } }

		public override int OldStrReq{ get{ return 60; } }

		public override int OldDexBonus{ get{ return -2; } }

		public override int ArmorBase{ get{ return 40; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Dragon; } }
		public override CraftResource DefaultResource{ get{ return CraftResource.RedScales; } }
		public override int LabelNumber{ get{ return 1053142; } } // dragon scale leggings

		[Constructable]
		public DragonLegs() : base( 0x2647 )
		{
			Weight = 6.0;
		}

		public DragonLegs( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}