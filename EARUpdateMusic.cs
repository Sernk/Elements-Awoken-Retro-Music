using ElementsAwoken;
using Terraria;
using Terraria.ModLoader;

namespace EARetroMusic
{
    public class EARUpdateMusic : ModSceneEffect
    {
        int music;
        public override int Music => music;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override bool IsSceneEffectActive(Player player)
        {
            if (Main.myPlayer != -1 && !Main.gameMenu && Main.LocalPlayer.active && Main.invasionX == (double)Main.spawnTileX && MyWorld.voidInvasionUp && ModContent.GetInstance<EARConfig>().VoidEventOldTheme)
            {
                music = MusicLoader.GetMusicSlot(EARetroMusic.SoundName("VoidEventOLD"));
                return true;
            }
            else return false;
        }
    }
}