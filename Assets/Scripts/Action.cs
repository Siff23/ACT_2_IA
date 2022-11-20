using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INDICA QUE PARTE DE SCRIPT ABLE OBJECT
public abstract class Action : ScriptableObject 
{
	public abstract bool Check(GameObject owner);
}
