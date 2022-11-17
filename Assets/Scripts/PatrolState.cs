using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Patrol", menuName = "ScriptableObject/States/PatrolState")]

public class PatrolState : State
{
	public override State Run(GameObject owner)
	{
		GameObject obj = owner.GetComponent<PlayerRef>().player;
		owner.GetComponent<NavMeshAgent>().SetDestination(new Vector3(0, 0, 0));

		if (action.Check(owner))
		{
			return nextState;
		}
		return this;
	}
}