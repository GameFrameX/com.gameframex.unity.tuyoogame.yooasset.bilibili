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

インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援

<br />

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#クイックスタート) · QQグループ: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

</div>

## プロジェクト概要

`com.gameframex.unity.tuyoogame.yooasset.bilibili` は、Unity の BiliBili ミニゲーム WebGL プラットフォーム向けに YooAsset `IFileSystem` アダプタを提供し、BiliBili ミニゲーム内でアセットのホットアップデートをシームレスに実現します。

## 機能概要

- BiliBili ミニゲームランタイム専用の `IFileSystem` 実装（`BiliBiliFileSystem`）。
- BiliBili SDK の `AssetBundle` ダウンロード/キャッシュ機能と統合。
- パッケージバージョンリクエスト、マニフェスト読込、バンドルダウンロード/読込フローを内蔵。
- カスタム CDN 用のプラガブルなリモートサービスインターフェース（`IRemoteServices`）。
- 標準的な YooAsset `WebPlayModeParameters` 初期化フローと互換。

## クイックスタート

### インストール

以下のいずれかの方法を選択してください：

1. Unity プロジェクトの `Packages/manifest.json` を編集し、`scopedRegistries` セクションを追加してください：

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

   `scopes` は、どのパッケージをこのレジストリから解決するかを制御します。`com.gameframex` で始まるパッケージのみがこのレジストリから取得されます。

2. `manifest.json` の `dependencies` に直接追加：

   ```json
   {
     "com.gameframex.unity.tuyoogame.yooasset.bilibili": "https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.bilibili.git"
   }
   ```

3. Unity の **Package Manager** で **Git URL** を使用して追加：`https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.bilibili.git`

4. リポジトリを Unity プロジェクトの `Packages` ディレクトリにクローンしてください。自動的に読み込まれます。

### 使用例

BiliBili ファイルシステムを YooAsset の `WebPlayModeParameters` に組み込み、WebGL プレイヤーが BiliBili アダプタを使ってバンドルを取得・キャッシュできるようにします：

```csharp
using YooAsset;

var createParameters = new WebPlayModeParameters();
createParameters.WebFileSystemParameters = BiliBiliFileSystemCreater.CreateBiliBiliFileSystemParameters(remoteServices);
```

## 依存関係

| パッケージ | 説明 |
| --- | --- |
| `com.gameframex.unity.tuyoogame.yooasset` 2.9.4 | YooAsset コアランタイムと API。 |
| `com.gameframex.unity.asset` 3.1.1 | GameFrameX アセット/ランタイム統合。 |

## ドキュメントとリソース

- [公式ドキュメント](https://gameframex.doc.alianblank.com)

## コミュニティとサポート

[![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/GameFrameX/gameframex)
[![Discord](https://img.shields.io/badge/Discord-5865F2?style=for-the-badge&logo=discord&logoColor=white)](https://discord.gg/VDWUjWMDw9)
[<img src="https://cdn.jsdelivr.net/npm/devicon@2/icons/linkedin/linkedin-original.svg" height="28" alt="LinkedIn" />](https://www.linkedin.com/in/alianblank)
[![Reddit](https://img.shields.io/badge/Reddit-FF4500?style=for-the-badge&logo=reddit&logoColor=white)](https://www.reddit.com/r/GameFrameX/)
[![X](https://img.shields.io/badge/X-000000?style=for-the-badge&logo=x&logoColor=white)](https://x.com/alian_blank)
[![YouTube](https://img.shields.io/badge/YouTube-FF0000?style=for-the-badge&logo=youtube&logoColor=white)](https://www.youtube.com/channel/UCD9QhSFJ5xZkn5NTSV-DVAw)
[![Bluesky](https://img.shields.io/badge/Bluesky-0285FF?style=for-the-badge&logo=bluesky&logoColor=white)](https://bsky.app/profile/alianblank.bsky.social)
[![Bilibili](https://img.shields.io/badge/Bilibili-00A1D6?style=for-the-badge&logo=bilibili&logoColor=white)](https://www.bilibili.com/video/BV1yrpeepEn7)
[![Gitee](https://img.shields.io/badge/Gitee-C71D23?style=for-the-badge&logo=gitee&logoColor=white)](https://gitee.com/GameFrameX/gameframex)
![QQ](https://img.shields.io/badge/QQ-467608841%2F233840761-EB1923?style=for-the-badge&logo=qq&logoColor=white)

## 変更履歴

変更履歴は [Releases](https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.bilibili/releases) をご覧ください。

## ライセンス

詳しくは [LICENSE.md](LICENSE.md) をご参照ください。
