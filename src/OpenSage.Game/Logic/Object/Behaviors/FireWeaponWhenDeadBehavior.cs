﻿using OpenSage.Data.Ini;
using OpenSage.Data.Ini.Parser;

namespace OpenSage.Logic.Object
{
    public sealed class FireWeaponWhenDeadBehavior : ObjectBehavior
    {
        internal static FireWeaponWhenDeadBehavior Parse(IniParser parser) => parser.ParseBlock(FieldParseTable);

        private static readonly IniParseTable<FireWeaponWhenDeadBehavior> FieldParseTable = new IniParseTable<FireWeaponWhenDeadBehavior>
        {
            { "DeathWeapon", (parser, x) => x.DeathWeapon = parser.ParseAssetReference() },
            { "StartsActive", (parser, x) => x.StartsActive = parser.ParseBoolean() },
            { "DeathTypes", (parser, x) => x.DeathTypes = parser.ParseEnumBitArray<DeathType>() },
            { "ConflictsWith", (parser, x) => x.ConflictsWith = parser.ParseAssetReference() },
            { "TriggeredBy", (parser, x) => x.TriggeredBy = parser.ParseAssetReference() }
        };

        public string DeathWeapon { get; private set; }
        public bool StartsActive { get; private set; }
        public BitArray<DeathType> DeathTypes { get; private set; }
        public string ConflictsWith { get; private set; }
        public string TriggeredBy { get; private set; }
    }
}