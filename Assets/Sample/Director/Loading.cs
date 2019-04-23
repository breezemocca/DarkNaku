using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour, ILoader {
	[SerializeField] private Image _curtain = null;

    public IEnumerator CoInAnimation() {
		float elapsed = 0F;

		while (elapsed < 1F) {
			elapsed += Time.deltaTime;
			_curtain.color = new Color(0F, 0F, 0F, Mathf.Lerp(1F, 0F, elapsed));
			yield return null;
		}
	}

    public void OnProgress(float progress) {
		Debug.Log(progress);
	}

    public IEnumerator CoOutAnimation() {
		float elapsed = 0F;

		while (elapsed < 1F) {
			elapsed += Time.deltaTime;
			_curtain.color = new Color(0F, 0F, 0F, Mathf.Lerp(0F, 1F, elapsed));
			yield return null;
		}
	}
}