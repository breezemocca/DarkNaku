using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DarkNaku;

public class First : MonoBehaviour, ISceneHandler {
	private void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) Director.ChangeScene("Loading", "Second");
	}

    public void OnStartOutAnimation() {
		Debug.Log("First OnStartOutAnimation");
	}

    public void OnUnloadScene() {
		Debug.Log("First OnUnloadScene");
	}

    public void OnLoadScene() {
		Debug.Log("First OnLoadScene");
	}

    public void OnEndInAnimation() {
		Debug.Log("First OnEndInAnimation");
	}
}
