using UnityEngine;
using System.Collections;

public class sphere : MonoBehaviour {

	private float kHeroSpeed = .05f;
	public float kHeroRotateSpeed = 90f/1f; //90deg in 1 seconds
	private float ypos = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += kHeroSpeed * (Input.GetAxis ("Vertical")) * (-1 * this.transform.forward);
		transform.Rotate((-1 * Vector3.up), -1f * Input.GetAxis("Horizontal") * (kHeroRotateSpeed * Time.smoothDeltaTime));
	}
}
