#if UNITY_WEBGL && ENABLE_BILIBILI_MINI_GAME
using YooAsset;

namespace GameFrameX.Asset.YooAsset.Minigame.BiliBili.Runtime
{

[UnityEngine.Scripting.Preserve]
internal partial class BLBFSInitializeOperation : FSInitializeFileSystemOperation
{
    private readonly BiliBiliFileSystem _fileSystem;

    [UnityEngine.Scripting.Preserve]
    public BLBFSInitializeOperation(BiliBiliFileSystem fileSystem)
    {
        _fileSystem = fileSystem;
    }

    [UnityEngine.Scripting.Preserve]
    public override void InternalOnStart()
    {
        Status = EOperationStatus.Succeed;
    }

    [UnityEngine.Scripting.Preserve]
    public override void InternalOnUpdate()
    {
    }
}
}
#endif