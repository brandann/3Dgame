using UnityEngine;
using System.Collections;

public class CollisionKillCamera : MonoBehaviour {

	GameObject camera;
	// Use this for initialization
	void Start () {
		camera = GameObject.FindGameObjectsWithTag ("MainCamera")[0];
	}
	
	// Update is called once per frame
	void Update () {
		//print (camera.transform.position);
	}

	void OnTriggerEnter (Collider col)
	{

		if(col.gameObject.tag == "Player")
		{
			print("kill");
			col.gameObject.transform.position = new Vector3(4,5,6);
		}
	}
}
