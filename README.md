# Game Frame X YooAsset BiliBili

YooAsset B站小游戏适配包，提供B站小游戏平台的资源文件系统（`BiliBiliFileSystem`）。运行时基于B站小游戏 Unity 转换 SDK（wx 同构 API，`WeChatWASM` 命名空间）。

## 依赖

- `com.gameframex.unity.tuyoogame.yooasset` >= 2.9.4
- B站小游戏 Unity 转换 SDK（`com.bilibili.gamesdk`）

## 激活条件

代码由 `UNITY_WEBGL && ENABLE_BILIBILI_MINI_GAME` 宏保护。安装B站 SDK（`com.bilibili.gamesdk`）后由 asmdef `versionDefines` 自动定义 `ENABLE_BILIBILI_MINI_GAME` 宏并激活。

## 使用

通过 `BiliBiliFileSystemCreater` 创建文件系统参数，接入 YooAsset 初始化流程：

```csharp
using GameFrameX.Asset.YooAsset.Minigame.BiliBili.Runtime;
using YooAsset;

var fileSystemParams = BiliBiliFileSystemCreater.CreateFileSystemParameters(remoteServices);
```
