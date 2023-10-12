using MelonLoader;
using BTD_Mod_Helper;
using Blon;

[assembly: MelonInfo(typeof(Blon.Blon), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace Blon;

public class Blon : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<Blon>("Blon loaded!");
    }
}