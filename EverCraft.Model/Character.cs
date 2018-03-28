namespace EverCraft.Model
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Character
    {
        public string Name { get; set; }
        public CharacterAlignment Alignment { get; set; }
        public int ArmorClass { get; set; } = 10;
        public int HitPoints { get; set; } = 5;

    }
}
