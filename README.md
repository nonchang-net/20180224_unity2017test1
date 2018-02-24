# Unity2017.3個人練習リポジトリ

## 概要

- 個人練習用リポジトリです。
- まるっとgithub公開。まさかプルリクは来ないだろうけど。






## 日別メモ

### 20180224

- 個人githubに公開。

- UniRxをサブモジュールとして追加。
	- git submodule add https://github.com/neuecc/UniRx Assets/3rdPartySubodules/UniRx
	- エラーが多発。.net 4.6(experimental)に変更。
	- Tests周りでエラー。うーん？
		- まずは場当たりで治せないか試してみる。
		- DecrementEnumeratorが重複してるので片方コメントアウト。
		- TestUtils.csが二つあるので、#if !NETFX_COREで始まってる方をコメントアウト。
		- ……ダメだ！ 新しいエラーが山ほど出てきた。事前情報が足りないのかもしれないけど、UniRxをsubmoduleで追加するのはやめよう。。

- UniRxをアセットストアから導入。
	- 

### 20180213

- Unity2017.3導入
	- serialがnot validと出た。手元のライセンスはサブスクリプションではないので、reactivateからpersonalで設定してUnity5との共存を確認。
	- この状態では2017以降で社用アプリをビルドしても、スプラッシュは改善しないので注意

- google docsにメモったHOB調査ログ確認しながら適用進める。

- 取り急ぎ、Unity2017テストプロジェクトにAssetBundle GraphToolとManager入れた。
	- AssetBundleManager
		https://www.assetstore.unity3d.com/en/?&_ga=2.15857910.137358407.1518485379-1836028312.1473222549#!/content/45836
		アセットストア配布なので、ストアから「AssetBundle Manager」で調べた方が早そう。
	- AssetBundleGraphTool
		- https://bitbucket.org/Unity-Technologies/assetbundlegraphtool/downloads/
		- zipを解凍して放り込む。
	- エラーが出るのでGraphTools関係のWebPlayer定義をコメントアウトしていく。本対応は後日。
	- assetメニューにsimulation modeが登場することを確認！





### 20180212短期目標をいくつか決める

- Unity5とUnity2017.3の変更点を把握。

- iOS/Androidビルドの自動化手順を少しまとめておく。
	- まずはシンプルなモックアップで。
	- 現状では、広告とかは入れない方向で考える。
	- pushなどはFirebaseで実装できないか検討。

- AssetBundleの利用。

- 「良い設計」を考える。
	- UniRxを試す。
		- 通信を含む、良い整備方法を考える。
	- 考え方をまとめていく。
		- モデルクラスの整備はクリーンアーキテクチャ踏襲でいいと思う。
		- DIについては保留するか？

- 「UIテスト自動化」について調べる。

- 今時のUI設計を少し考える。


`EOF`