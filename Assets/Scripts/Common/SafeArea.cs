/*
# SafeArea.cs

## about

fit iOS SafeArea, and emulate size on Unity Editor.

## copyright
nonchang.net 2018

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeArea : MonoBehaviour {

	[SerializeField] private CanvasScaler canvasScaler ;

	void Start () {
		if(canvasScaler==null){
			canvasScaler=transform.root.GetComponentInChildren<CanvasScaler>();
		}
		Debug.Log("canvasScaler size="+canvasScaler.referenceResolution);
	}
	
	void Update () {
		
	}

	// void OnGUI(){
	// 	Debug.Log("onGUI");
	// }
}
