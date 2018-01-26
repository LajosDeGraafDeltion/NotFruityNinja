using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingDestroyer : MonoBehaviour {

	void Start () {
		
	}

    public void OnMouseDown()
    {
        ScoreManager.scoreManager.RemoveScore();
        Camera.main.backgroundColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        print("click");
        Destroy(gameObject);
    }
}
