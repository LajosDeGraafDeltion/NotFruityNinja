using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour {

    public GameObject particleFX;

    public void OnMouseOver()
    {
        if (Input.GetButton("Fire1"))
        {
            ScoreManager.scoreManager.AddScore();
            Camera.main.backgroundColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            print("click");
            Instantiate(particleFX, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
