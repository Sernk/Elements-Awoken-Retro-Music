using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace EARetroMusic
{
    public class EARConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Header("$Mods.EARetroMusic.Config.EARConfig")]
        [DefaultValue(true)]
        [LabelKey("$Mods.EARetroMusic.Config.WastelandMusic")] // Old Wasteland Music
        [TooltipKey("$Mods.EARetroMusic.Config.Enabled")] // Replaces the current EA music with the old version
        public bool WastelandOldTheme { get; set; }

        [DefaultValue(true)]
        [LabelKey("$Mods.EARetroMusic.Config.InfernaceMusic")] // Old Infernace Music
        [TooltipKey("$Mods.EARetroMusic.Config.Enabled")]
        public bool InfernaceOldTheme { get; set; }

        [DefaultValue(true)]
        [LabelKey("$Mods.EARetroMusic.Config.ScourgeFighterMusic")]// Old Scourge Fighter Music
        [TooltipKey("$Mods.EARetroMusic.Config.Enabled")]
        public bool ScourgeFighterOldTheme { get; set; }

        [DefaultValue(true)]
        [LabelKey("$Mods.EARetroMusic.Config.RegarothMusic")] // Old Regaroth Music
        [TooltipKey("$Mods.EARetroMusic.Config.Enabled")]
        public bool RegarothOldTheme { get; set; }

        [DefaultValue(true)]
        [LabelKey("$Mods.EARetroMusic.Config.ObsidiousMusic")] // Old Obsidious Music
        [TooltipKey("$Mods.EARetroMusic.Config.Enabled")]
        public bool ObsidiousOldTheme { get; set; }

        [DefaultValue(true)]
        [LabelKey("$Mods.EARetroMusic.Config.PermafrostMusic")] // Old Permafrost Music
        [TooltipKey("$Mods.EARetroMusic.Config.Enabled")]
        public bool PermafrostOldTheme { get; set; }

        [DefaultValue(true)]
        [LabelKey("$Mods.EARetroMusic.Config.AqueousMusic")] // Old Aqueous Music
        [TooltipKey("$Mods.EARetroMusic.Config.Enabled")]
        public bool AqueousOldTheme { get; set; }

        [DefaultValue(true)]
        [LabelKey("$Mods.EARetroMusic.Config.DawnoftheVoidMusic")] // Old Dawn of the Void Music
        [TooltipKey("$Mods.EARetroMusic.Config.Enabled")]
        public bool VoidEventOldTheme { get; set; }

        [DefaultValue(true)]
        [LabelKey("$Mods.EARetroMusic.Config.VoidLeviathanMusic")] // Old Void Leviathan Music
        [TooltipKey("$Mods.EARetroMusic.Config.Enabled")]
        public bool VleviOldTheme { get; set; }
    }
}