using System;

namespace Server.Items
{
	public class LeatherHaidate : BaseArmor
	{
		
		
		
		
		

		public override int InitMinHits{ get{ return 30; } }
		public override int InitMaxHits{ get{ return 40; } }

		
		public override int OldStrReq{ get{ return 20; } }

		public override int ArmorBase{ get{ return 3; } }

		public override ArmorMaterialType MaterialType { get { return ArmorMaterialType.Leather; } }
		public override CraftResource DefaultResource { get { return CraftResource.RegularLeather; } }


		public override ArmorMeditationAllowance DefMedAllowance{ get{ return ArmorMeditationAllowance.All; } }

		[Constructable]
		public LeatherHaidate() : base( 0x278A )
		{
			Weight = 4.0;
			Dyable = true;
		}

		public LeatherHaidate( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}