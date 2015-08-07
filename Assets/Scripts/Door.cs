using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	private Animator anim;
	public Transform doorFrontPos;
	private Vector2 doorFrontVec;
	void Awake()
	{
		doorFrontVec = new Vector2((doorFrontPos.position.x - transform.position.x),(doorFrontPos.position.z - transform.position.z));
		anim = GetComponent<Animator>();
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "player")
		{
			Vector2 player2door = new Vector2 ((other.gameObject.transform.position.x-transform.position.x),
			                                   (other.gameObject.transform.position.z-transform.position.z));
			if(Vector2.Dot(player2door,doorFrontVec) < 0)
			   anim.SetBool("open1",true);
			else
			   anim.SetBool("open2",true);

		}
	}	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.name == "player")
		{
			anim.SetBool("open1",false);
			anim.SetBool("open2",false);

		}
	}
}