using UnityEngine;
using System.Collections;

public class MoveCpt : MonoBehaviour {

	// Use this for initialization
	public float speed = 5f;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKey(KeyCode.W)) {
			transform.Translate (Vector2.up * speed * Time.deltaTime);
		}

		if( Input.GetKey(KeyCode.S)) {
			transform.Translate (Vector2.down * speed * Time.deltaTime);
		}

		if( Input.GetKey(KeyCode.A)) {
			transform.Translate (Vector2.left * speed * Time.deltaTime);
		}

		if( Input.GetKey(KeyCode.D)) {
			transform.Translate (Vector2.right * speed * Time.deltaTime);
		}

		if( Input.GetMouseButton(0) ){
			gameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0f ,0f ,10f);
		}

	}
}
