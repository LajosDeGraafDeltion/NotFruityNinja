using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopParticle : MonoBehaviour {


	void Start ()
    {
        StartCoroutine(ParticleDelete());
	}

    public IEnumerator ParticleDelete()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
