using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Chase", menuName = "ScriptableObject/States/ChaseState")]

public class ChaseState : State
{
	public override State Run(GameObject owner)
	{
		GameObject obj = owner.GetComponent<PlayerRef>().player;
		owner.GetComponent<NavMeshAgent>().SetDestination(obj.transform.position);

		if (!action.Check(owner))
		{
			return nextState;
		}
		return this;
	}
}
