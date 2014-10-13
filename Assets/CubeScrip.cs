using UnityEngine;
using System.Collections;

public class CubeScrip : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		//if (Input.GetKeyDown("f")) {
			StartCoroutine("Move");
		//}

	}

	IEnumerator Move()
	{
		for (int i=0; i <= 200; i++) 
		{
			transform.Translate(Vector3.forward * Time.deltaTime);

			yield return null;
		}
	}
}
