using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//RUTA DEL GUARDADO DE LOS ESTADOS > PERSEGUIR EN ESTE CASO
[CreateAssetMenu(fileName = "Chase", menuName = "ScriptableObject/States/ChaseState")]

//INDICA QUE PARTE DE ESTADO
public class ChaseState : State
{
	public override State Run(GameObject owner)
	{
		//ACCEDER A PLAYER REF
		GameObject obj = owner.GetComponent<PlayerRef>().player; 
		//ACCEDO AL COMPONENTE NAV MESH AGENT Y LO ENVIAS A LA POSICION DEL PLAYER 
		owner.GetComponent<NavMeshAgent>().SetDestination(obj.transform.position);

		//ACCION QUE TE LLEVA A OTRO ESTADO
		if (!action.Check(owner)) 
		{
			return nextState;
		}
		return this;
	}
}
