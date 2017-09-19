using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	public Rigidbody2D rb2D;
	public BoxCollider2D trigger;

	public float movingSpeed;
	public float jumpSpeed;

	public bool possibleJump;

	void Start () {
		rb2D = GetComponent<Rigidbody2D> ();
		possibleJump = true;
	}

	void Update () {

		if (Input.GetAxis ("Horizontal") > 0) {
			//rb2D.AddForce (Vector2.right * movingSpeed);
			transform.Translate(Vector2.right * movingSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
		}
		if (Input.GetAxis ("Horizontal") < 0) {
			//rb2D.AddForce (Vector2.right * -movingSpeed);
			transform.Translate(Vector2.right * movingSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
		}

		if (Input.GetAxis ("Vertical") > 0 && possibleJump == true) {
			rb2D.AddForce (Vector2.up * jumpSpeed);
			possibleJump = false;
		}
	}
}
