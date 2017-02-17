using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {

	public GameObject foePre;

	// Use this for initialization
	void Start () {
		InvokeRepeating("createFoe", 0.5f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void createFoe() {
		float x = Random.Range(-4, 4);
		Instantiate(foePre, new Vector2(x, 7f), Quaternion.identity);
	}

}
