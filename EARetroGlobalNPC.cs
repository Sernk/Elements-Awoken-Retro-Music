using ElementsAwoken.Content.Events.VoidEvent.Enemies.Phase2.ShadeWyrm;
using ElementsAwoken.Content.NPCs.Bosses.Aqueous;
using ElementsAwoken.Content.NPCs.Bosses.Infernace;
using ElementsAwoken.Content.NPCs.Bosses.Obsidious;
using ElementsAwoken.Content.NPCs.Bosses.Permafrost;
using ElementsAwoken.Content.NPCs.Bosses.Regaroth;
using ElementsAwoken.Content.NPCs.Bosses.ScourgeFighter;
using ElementsAwoken.Content.NPCs.Bosses.VoidLeviathan;
using ElementsAwoken.Content.NPCs.Bosses.Wasteland;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace EARetroMusic
{
    public class EARetroGlobalNPC : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            EARConfig instance = GetInstance<EARConfig>();
            if (instance.WastelandOldTheme && npc.type == NPCType<Wasteland>())
            {
                npc.ModNPC.Music = MusicLoader.GetMusicSlot(EARetroMusic.SoundName("WastelandOLD"));
            }
            if (instance.InfernaceOldTheme && npc.type == NPCType<Infernace>())
            {
                npc.ModNPC.Music = MusicLoader.GetMusicSlot(EARetroMusic.SoundName("InfernaceOLD"));
            }
            if (instance.ScourgeFighterOldTheme && npc.type == NPCType<ScourgeFighter>())
            {
                npc.ModNPC.Music = MusicLoader.GetMusicSlot(EARetroMusic.SoundName("ScourgeFighterOLD"));
            }
            if (instance.RegarothOldTheme && npc.type == NPCType<RegarothHead>())
            {
                npc.ModNPC.Music = MusicLoader.GetMusicSlot(EARetroMusic.SoundName("RegarothOLD"));
            }
            if (instance.ObsidiousOldTheme && npc.type == NPCType<Obsidious>())
            {
                npc.ModNPC.Music = MusicLoader.GetMusicSlot(EARetroMusic.SoundName("ObsidiousOLD"));
            }
            if (instance.PermafrostOldTheme && npc.type == NPCType<Permafrost>())
            {
                npc.ModNPC.Music = MusicLoader.GetMusicSlot(EARetroMusic.SoundName("PermafrostOLD"));
            }
            if (instance.AqueousOldTheme && npc.type == NPCType<Aqueous>())
            {
                npc.ModNPC.Music = MusicLoader.GetMusicSlot(EARetroMusic.SoundName("AqueousOLD"));
            }
            if (instance.VoidEventOldTheme && npc.type == NPCType<ShadeWyrmHead>())
            {
                npc.ModNPC.Music = MusicLoader.GetMusicSlot(EARetroMusic.SoundName("VoidEventMinibossOLD"));
            }
            if (instance.VleviOldTheme && npc.type == NPCType<VoidLeviathanHead>())
            {
                npc.ModNPC.Music = MusicLoader.GetMusicSlot(EARetroMusic.SoundName("VoidLeviathanOLD"));
            }
        }
    }
}
