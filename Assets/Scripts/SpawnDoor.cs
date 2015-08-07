using UnityEngine;
using System.Collections;

public class SpawnDoor : MonoBehaviour {
	public GameObject door;
    void Awake()
	{
		Vector3 doorAdj = new Vector3(0,0,0);
		Instantiate(door,transform.position + doorAdj,transform.rotation);
	}
}
