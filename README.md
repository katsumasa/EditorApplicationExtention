# EditorApplicationExtention

![GitHub package.json version](https://img.shields.io/github/package-json/v/katsumasa/EditorApplicationExtention?style=plastic)

## 概要

[UnityEditor.EditorApplication](https://docs.unity3d.com/ja/current/ScriptReference/EditorApplication.html)クラスで不足している機能や非公開のメソッドやプロパティを使用出来るClassを目指しています。

## プロパティ

### editorApplicationQuit

public static UnityAction editorApplicationQuit

#### 説明

UnityEditorが終了する時に実行されるUnityActionです。

## API

### Reboot

public static void Reboot()

#### 説明

UnityEditorをリブートします。UnityEditorを起動する際に使用した引数を引き継ぎます。
MenuItemの`File > Reboot`で実行することが可能です。

![11b589b5d36c2d22b42b21ab2c9e68d1](https://user-images.githubusercontent.com/29646672/150082291-34a3db47-587b-4c00-9c3c-dd3b81ab35d8.gif)
