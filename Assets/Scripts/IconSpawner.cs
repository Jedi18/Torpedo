using UnityEngine;
using System.Collections;

public class IconSpawner : MonoBehaviour 
{
	public GameObject Icon;
	Pool IconPool;
	public static bool IsTorpedoInvisisble;
	void Start () 
	{
		IconPool = new Pool (Icon);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void Spawn(GameObject ParentTorpedo)
	{
		gameObject.transform.parent = ParentTorpedo.transform;
	}
}
