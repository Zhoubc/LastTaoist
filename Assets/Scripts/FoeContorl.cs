using UnityEngine;
using System.Collections;

public class FoeContorl : MonoBehaviour {

	public float speed = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.down * speed * Time.deltaTime);
	}
		
	void OnBecameInvisible() 
	{ 
		Destroy(gameObject); 
	} 

}
