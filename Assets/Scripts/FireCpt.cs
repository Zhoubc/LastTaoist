//自动开火组件

using UnityEngine;
using System.Collections;

public class FireCpt : MonoBehaviour {

	public BulletCpt bulletPre;
	public float spaceTime = 0.1f;  //发射间隔
	MoveCpt moveCpt;

	// Use this for initialization
	void Start () {
//		InvokeRepeating("Fire", 1, spaceTime);
		moveCpt = GetComponent<MoveCpt> ();
		Debug.Log (moveCpt.isRight);
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKeyUp(KeyCode.J)) {
			Fire ();
		}
	}

	void Fire (){
		BulletCpt bullet = Instantiate(bulletPre, gameObject.transform.position, Quaternion.identity) as BulletCpt;
		bullet.dir = moveCpt.isRight ? Vector2.right : Vector2.left;
	}
}
