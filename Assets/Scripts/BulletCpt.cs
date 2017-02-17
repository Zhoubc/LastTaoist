using UnityEngine;
using System.Collections;

public class BulletCpt : MonoBehaviour {

	public float speed = 200f;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.left * speed * Time.deltaTime);
	}
	 
	void OnTriggerEnter2D(Collider2D collider){
		if(collider.gameObject.CompareTag("Wall")){
			speed = 0;
			anim.SetBool ("Boom", true);
		}

		if(collider.gameObject.CompareTag("Foe")){
			Destroy(collider.gameObject); 
			speed = 0;
			anim.SetBool ("Boom", true);
		}
	}
		
	void OnBecameInvisible() 
	{ 
		Destroy(gameObject); 
	} 
}
