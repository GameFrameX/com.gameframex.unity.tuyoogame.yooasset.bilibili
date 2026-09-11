<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X YooAsset BiliBili

[![License](https://img.shields.io/badge/license-blue.svg)](LICENSE.md)
[![Version](https://img.shields.io/github/v/release/gameframex/com.gameframex.unity.tuyoogame.yooasset.bilibili)](https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.bilibili/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

[![Discord](https://img.shields.io/badge/-5865F2?logo=discord&logoColor=white)](https://discord.gg/VDWUjWMDw9)
[![GitHub](https://img.shields.io/badge/-181717?logo=github&logoColor=white)](https://github.com/GameFrameX/gameframex)
[![Bilibili](https://img.shields.io/badge/-00A1D6?logo=bilibili&logoColor=white)](https://www.bilibili.com/video/BV1yrpeepEn7)
[![Gitee](https://img.shields.io/badge/-C71D23?logo=gitee&logoColor=white)](https://gitee.com/GameFrameX/gameframex)

独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使

<br />

[文档](https://gameframex.doc.alianblank.com) · [快速开始](#快速开始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 项目简介

`com.gameframex.unity.tuyoogame.yooasset.bilibili` 为 Unity 在 B站小游戏 WebGL 平台上提供 YooAsset `IFileSystem` 适配器，使 B站小游戏能够顺畅接入 YooAsset 资源热更新流程。

## 功能特性

- 专为 B站小游戏运行时提供的 `IFileSystem` 实现（`BiliBiliFileSystem`）。
- 集成 B站小游戏 SDK 的 `AssetBundle` 下载与缓存子系统。
- 内置资源包版本请求、清单加载与资源包下载/加载流程。
- 可插拔的远端服务接口（`IRemoteServices`），支持自定义 CDN。
- 与 YooAsset 标准 `WebPlayModeParameters` 初始化流程完全兼容。

## 快速开始

### 安装

选择以下任一方式：

1. 编辑 Unity 项目的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：

   ```json
   {
     "scopedRegistries": [
       {
         "name": "GameFrameX",
         "url": "https://gameframex.upm.alianblank.uk",
         "scopes": [
           "com.gameframex"
         ]
       }
     ],
     "dependencies": {
       "com.gameframex.unity.tuyoogame.yooasset.bilibili": "1.0.0"
     }
   }
   ```

   `scopes` 控制哪些包通过此注册表解析。只有以 `com.gameframex` 开头的包才会从这个注册表获取。

2. 直接在 `manifest.json` 的 `dependencies` 节点下添加以下内容：

   ```json
   {
     "com.gameframex.unity.tuyoogame.yooasset.bilibili": "https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.bilibili.git"
   }
   ```

3. 在 Unity 的 **Package Manager** 中使用 **Git URL** 的方式添加库，地址为：`https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.bilibili.git`

4. 直接下载仓库放置到 Unity 项目的 `Packages` 目录下，会自动加载识别。

### 使用示例

将 B站小游戏文件系统接入 YooAsset 的 `WebPlayModeParameters`，让 WebGL 端通过 B站小游戏适配器获取并缓存资源包：

```csharp
using YooAsset;

var createParameters = new WebPlayModeParameters();
createParameters.WebFileSystemParameters = BiliBiliFileSystemCreater.CreateBiliBiliFileSystemParameters(remoteServices);
```

## 依赖

| 包 | 说明 |
| --- | --- |
| `com.gameframex.unity.tuyoogame.yooasset` 2.9.4 | YooAsset 核心运行时与 API。 |
| `com.gameframex.unity.asset` 3.1.1 | GameFrameX 资源/运行时集成。 |

## 文档与资源

- [官方文档](https://gameframex.doc.alianblank.com)

## 社区与支持

![QQ](https://img.shields.io/badge/QQ-467608841%2F233840761-EB1923?style=for-the-badge&logo=qq&logoColor=white)
[![Bilibili](https://img.shields.io/badge/Bilibili-00A1D6?style=for-the-badge&logo=bilibili&logoColor=white)](https://www.bilibili.com/video/BV1yrpeepEn7)
[![Gitee](https://img.shields.io/badge/Gitee-C71D23?style=for-the-badge&logo=gitee&logoColor=white)](https://gitee.com/GameFrameX/gameframex)
[![Discord](https://img.shields.io/badge/Discord-5865F2?style=for-the-badge&logo=discord&logoColor=white)](https://discord.gg/VDWUjWMDw9)
[![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/GameFrameX/gameframex)
[<img src="https://cdn.jsdelivr.net/npm/devicon@2/icons/linkedin/linkedin-original.svg" height="28" alt="LinkedIn" />](https://www.linkedin.com/in/alianblank)
[![Reddit](https://img.shields.io/badge/Reddit-FF4500?style=for-the-badge&logo=reddit&logoColor=white)](https://www.reddit.com/r/GameFrameX/)
[![X](https://img.shields.io/badge/X-000000?style=for-the-badge&logo=x&logoColor=white)](https://x.com/alian_blank)
[![YouTube](https://img.shields.io/badge/YouTube-FF0000?style=for-the-badge&logo=youtube&logoColor=white)](https://www.youtube.com/channel/UCD9QhSFJ5xZkn5NTSV-DVAw)
[![Bluesky](https://img.shields.io/badge/Bluesky-0285FF?style=for-the-badge&logo=bluesky&logoColor=white)](https://bsky.app/profile/alianblank.bsky.social)

## 更新日志

查看 [Releases](https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.bilibili/releases) 了解更新日志。

## 开源协议

详见 [LICENSE.md](LICENSE.md) 文件。
