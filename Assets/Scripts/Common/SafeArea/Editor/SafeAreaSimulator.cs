/*


### 【Unity】エディタ拡張でstaticなフィールドに置いたインスタンスが、コンパイル/再生時に初期化される問題の対策について
http://tsubakit1.hateblo.jp/entry/2017/01/31/235730

- 上記を参考に、コンパイル単位でクリアされないようにしたい。
- ただ、ここでやりたいことはEditor領域での永続化。
- どうするのが適切か。scriptable objectあたりに保存するとどうなるかな……。


*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class SafeAreaSimulator {

	const string MENU_BASE = "Window/SafeArea/";

	enum Checkes{
		None,
		IPhoneX,
	}

	// static readonly Dictionary<Checkes,string> pathes = new Dictionary<Checkes,string>{
	// 	{ Checkes.None, "None" }
	// };


	[MenuItem("Window/SafeArea/None")]
	static void none ()
	{
		// var checked_menu = Menu.GetChecked (menuPath);
		ClearChecks();
		Menu.SetChecked (MENU_BASE+Checkes.None, true);
	}

	[MenuItem("Window/SafeArea/IPhoneX")]
	static void iPhoneX ()
	{
		ClearChecks();
		Menu.SetChecked (MENU_BASE+Checkes.IPhoneX, true);
	}

	static void ClearChecks(){
		// Menu.SetChecked (menuPath, !checked_menu);
		// Menu.SetChecked (menuPath, !checked_menu);
		foreach (Checkes check in Checkes.GetValues(typeof(Checkes)))
		{
			Menu.SetChecked (MENU_BASE+check, false);
		}
	}

}