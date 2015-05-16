namespace Server.Mobiles
{
    [CorpseName("an ophidian corpse")]
    public class OphidianWarrior : BaseCreature
    {
        private static readonly string[] m_Names = new string[]
        {
            "an ophidian warrior",
            "an ophidian enforcer"
        };

        [Constructable]
        public OphidianWarrior() : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = m_Names[Utility.Random(m_Names.Length)];
            Body = 86;
            BaseSoundID = 634;

            Alignment = Alignment.Inhuman;

            SetStr(150, 320);
            SetDex(94, 190);
            SetInt(64, 160);

            SetHits(128, 155);
            SetMana(0);

            SetDamage(5, 11);


            SetSkill(SkillName.MagicResist, 70.1, 85.0);
            SetSkill(SkillName.Swords, 60.1, 85.0);
            SetSkill(SkillName.Tactics, 75.1, 90.0);

            Fame = 4500;
            Karma = -4500;

            VirtualArmor = 36;
        }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
            AddLoot(LootPack.Average);
            AddLoot(LootPack.Gems);
        }

        public override int Meat { get { return 1; } }
        public override int TreasureMapLevel { get { return 1; } }

        public override OppositionGroup OppositionGroup { get { return OppositionGroup.TerathansAndOphidians; } }

        public OphidianWarrior(Serial serial) : base(serial)
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