using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DarkNaku;

public class Second : MonoBehaviour, ISceneHandler {
	private void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) Director.ChangeScene("Loading", "First");
	}

    public void OnStartOutAnimation() {
		Debug.Log("Second OnStartOutAnimation");
	}

    public void OnUnloadScene() {
		Debug.Log("Second OnUnloadScene");
	}

    public void OnLoadScene() {
		Debug.Log("Second OnLoadScene");
	}

    public void OnEndInAnimation() {
		Debug.Log("Second OnEndInAnimation");
	}
}
