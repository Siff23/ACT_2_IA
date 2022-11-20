using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Rest", menuName = "ScriptableObject/States/RestState")]
public class RestState : State
{
	public override State Run(GameObject owner)
	{
		if (action.Check(owner))
		{
			return nextState;
		}

		return null;
	}
}
