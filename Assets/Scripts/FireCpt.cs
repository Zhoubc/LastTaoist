//自动开火组件

using UnityEngine;
using System.Collections;

public class FireCpt : MonoBehaviour {

	public GameObject bulletPre;
	public float spaceTime = 0.1f;  //发射间隔


	// Use this for initialization
	void Start () {
//		InvokeRepeating("Fire", 1, spaceTime);
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKeyUp(KeyCode.J)) {
			Fire ();
		}
	}

	void Fire (){
		Instantiate(bulletPre, gameObject.transform.position + new Vector3(0,0,1f), Quaternion.identity);
	}
}
