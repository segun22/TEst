using UnityEngine;
using System.Collections;

public class TEST : MonoBehaviour {

	public GameObject hi;

	// Use this for initialization
	void Start () {
		hi = GameObject.Find("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
		hi.GetComponent<Transform> ().position = new Vector3 (10, 10, 10);s
	}
}
