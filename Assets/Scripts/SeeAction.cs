using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "See", menuName = "ScriptableObject/Action/SeeAction")]
public class SeeAction : Action
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
