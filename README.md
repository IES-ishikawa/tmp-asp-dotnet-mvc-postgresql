## 概要

このリポジトリは ASP.NET Core(MVC) + PostgreSQL の環境を Visual Studio Code の Dev Container を使用して迅速にスタートアップするためのテンプレートリポジトリです。

## 前提

以下がローカル環境にインストールされていること。  
拡張機能はインストールされていない場合、Visual Studio Code で開いたタイミングでインストールするか聞かれるので、インストールしてください。

- [Visual Studio Code](https://azure.microsoft.com/ja-jp/products/visual-studio-code)
  - [Dev Container](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.remote-containers)拡張機能(または[ExtensionPacks](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.vscode-remote-extensionpack))
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)

## 使用方法

1.Docker Desktop を起動します。  

2.このリポジトリを Visual Studio Code で開きます。  

3.画面右下の「コンテナーで再度開く」を選択します。(Dev Container 拡張機能がないと出てきません)  

![image1](https://github.com/IES-ishikawa/assets/blob/main/tmp-asp-dotnet-mvc-postgresql/image1.png)

または画面左下のリモートウィンドウを開き「コンテナーで再度開く」を選択します。  

![image2](https://github.com/IES-ishikawa/assets/blob/main/tmp-asp-dotnet-mvc-postgresql/image2.png)  

![image3](https://github.com/IES-ishikawa/assets/blob/main/tmp-asp-dotnet-mvc-postgresql/image3.png)

4.右下にスナックバーが表示され、Docker コンテナの構築が始まりますのでしばらく待ちます。  

![image4](https://github.com/IES-ishikawa/assets/blob/main/tmp-asp-dotnet-mvc-postgresql/image4.png)

5.右下のスナックバーが消えたらコンテナの構築は完了です。  

![image5](https://github.com/IES-ishikawa/assets/blob/main/tmp-asp-dotnet-mvc-postgresql/image5.png)

6.「F5」キーを押すとポート 5143 で デバッグサーバー が立ち、デバッグ出来ます。  

![image6](https://github.com/IES-ishikawa/assets/blob/main/tmp-asp-dotnet-mvc-postgresql/image6.png)  

![image7](https://github.com/IES-ishikawa/assets/blob/main/tmp-asp-dotnet-mvc-postgresql/image7.png)

7.開発コンテナー名を変える場合は[devcontainer.json](.devcontainer/devcontainer.json) 2 行目の"name"の値を変えてください。

8.PostgreSQL はホスト PC のポート 5432(PostgreSQL のデフォルト)を使います。  

既にホスト PC に PostgreSQL がインストールされていて、5432 は使っているという場合は
[.docker-compose.yml](./.devcontainer/docker-compose.yml)ファイルの 21 行目「5432:5432」のコロンより左側の値を変えてください。  
例: 「5433:5432」

9.Let's Hack!

## 注意点

- [このリポジトリ](https://github.com/IES-ishikawa/tmp-asp-dotnet-mvc-postgresql.git)にはプッシュしないでください
