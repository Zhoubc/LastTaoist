using UnityEngine;
using System.Collections;

public class MoveCpt : MonoBehaviour {

	// Use this for initialization
	Vector3 beginPos;
	public float speed = 1f;
	public float jumpForce = 500f;
	public bool isRight = true;

	public Transform gorundPos;
	public bool isGrounded = false;
	public LayerMask groundLayer;
	float r = 0.2f;

	Animator animator;
	Rigidbody2D rigib2D;

	void Start () {
		beginPos = gameObject.transform.position;
		animator = GetComponent<Animator> ();
		rigib2D = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate(){
		//地面检查
		isGrounded = Physics2D.OverlapCircle(gorundPos.position, r, groundLayer);

		float dir = Input.GetAxis ("Horizontal");
		animator.SetFloat ("speed", Mathf.Abs (dir));
		rigib2D.velocity = new Vector2 (dir * speed, rigib2D.velocity.y);
		if (dir > 0 && isRight == false) {  //面向右
			Flip();
		}
		if (dir < 0 && isRight == true) {
			Flip ();
		}
	}

	// Update is called once per frame
	void Update () {
		if(isGrounded && Input.GetKeyDown(KeyCode.Space)){
			rigib2D.AddForce (new Vector2 (0, jumpForce));
			isGrounded = false;
		}

		if (gameObject.transform.position.y < -10f) {
			MoveToBeginPos ();
		}

	}

	void Flip(){
		isRight = !isRight;
		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
	}

	void MoveToBeginPos() 
	{ 
		gameObject.transform.position = beginPos;
		rigib2D.velocity = Vector2.zero;
	} 


}
