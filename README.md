# ScaleAI

[![Nuget package](https://img.shields.io/nuget/vpre/ScaleAI)](https://www.nuget.org/packages/ScaleAI/)
[![dotnet](https://github.com/tryAGI/ScaleAI/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/ScaleAI/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/ScaleAI)](https://github.com/tryAGI/ScaleAI/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features
- Fully generated C# SDK for the [Scale AI API](https://scale.com/docs/api-reference/) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Data labeling, RLHF, and AI evaluation workflows
- Projects, batches, tasks, files, and team management
- AIFunction tools for use with any `IChatClient`
- All modern .NET features - nullability, trimming, NativeAOT, etc.

### Usage
```csharp
using ScaleAI;

using var client = new ScaleAIClient(apiKey);
```

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/ScaleAI/issues
Priority place for ideas and general questions: https://github.com/tryAGI/ScaleAI/discussions
Discord: https://discord.gg/Ca2xhfBf3v

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
