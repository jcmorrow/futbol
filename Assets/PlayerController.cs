using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;

	public float speed;
	public float turnSpeed;

	void Start () {
		rb = GetComponent<Rigidbody>();
		RenderSettings.ambientLight = Color.black;
	}

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (0, 0, moveVertical);

		rb.AddRelativeForce (movement * speed);
	}

	void Update () {
		rb.AddTorque(new Vector3(0.0f, Input.GetAxis ("Horizontal") * turnSpeed, 0.0f));
	}
}
