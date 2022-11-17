using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Hear", menuName = "ScriptableObject/Action/HearAction")]
public class HearAction : Action
{
	public override bool Check(GameObject owner)
	{
		RaycastHit[] info = Physics.SphereCastAll(owner.transform.position, 20, Vector3.up);

		foreach (RaycastHit col in info)
		{
			if (col.collider.gameObject.GetComponent<PlayerController>())
			{
				return true;
			}
		}
		return false;
	}
}
