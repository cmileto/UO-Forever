#region References

using Server.Items;

#endregion

namespace Server.Mobiles
{
    [CorpseName("an ore elemental corpse")]
    public class AgapiteElemental : BaseCreature
    {
        public override string DefaultName { get { return "an agapite elemental"; } }
        private static readonly int m_DefaultHue = CraftResources.GetInfo(CraftResource.Agapite).Hue;

        [Constructable]
        public AgapiteElemental() : this(2)
        {}

        [Constructable]
        public AgapiteElemental(int oreAmount) : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Body = 107;
            BaseSoundID = 268;
            Hue = m_DefaultHue;

            Alignment = Alignment.Elemental;

            SetStr(226, 255);
            SetDex(126, 145);
            SetInt(71, 92);

            SetHits(136, 153);

            SetDamage(28);


            SetSkill(SkillName.MagicResist, 50.1, 95.0);
            SetSkill(SkillName.Tactics, 60.1, 100.0);
            SetSkill(SkillName.Wrestling, 60.1, 100.0);

            Fame = 3500;
            Karma = -3500;

            VirtualArmor = 32;

            Item ore = new AgapiteOre(oreAmount);
            ore.ItemID = 0x19B9;
            PackItem(ore);
        }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
            AddLoot(LootPack.Gems, 2);
        }

        public override bool BleedImmune { get { return true; } }
        public override Poison PoisonImmune { get { return Poison.Deadly; } }
        public override bool AutoDispel { get { return true; } }
        public override int TreasureMapLevel { get { return 1; } }
        public override int DefaultBloodHue { get { return -1; } }

        public AgapiteElemental(Serial serial) : base(serial)
        {}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int) 0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}