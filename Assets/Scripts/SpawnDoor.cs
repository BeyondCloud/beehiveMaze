using UnityEngine;
using System.Collections;

public class SpawnDoor : MonoBehaviour {
	public GameObject door;
    void Awake()
	{
		Vector3 doorAdj = new Vector3(0,0,0);
		Animator anim = door.GetComponent<Animator>();
		if(this.name == "X")
			anim.enabled = false;
		else
			anim.enabled = true;
		Instantiate(door,transform.position + doorAdj,transform.rotation);
	}
}
