# 元祖本家らーめん田森家
## このリポジトリの説明
- [Hack Azure! #1 - Azure Serverless でオンライン決済基盤をつくる](https://msdevjp.connpass.com/event/179232/) で開催されたハッカソンの `ramen` チームの発表です。
- [Stripe](https://stripe.com/) のライブラリを使用して決済機能を実装した WEB サイトです。
- ラーメンをクリックすると決済画面が表示されラーメンを購入することができます（実際には購入できません）。

## ビルド方法
- 環境変数に `StripeApiKey` として API のシークレットキーを設定してください。
- シークレットキーの取得方法は ダッシュボード→ホーム→テスト API キー取得→シークレットキー で取得できます。
- `index.cshtml` のリダイレクト URL （`successUrl`, `cancelUrl`） を適宜修正してください。
- F5(デバッグ)で実行します。
