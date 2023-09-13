using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This will allow to Instantiate an "Item" Object in Unity with the given
 * parameters. */
[CreateAssetMenu(fileName = "New_Item",menuName = "Item/New_Item")]
public class Items_SO : ScriptableObject
{
    public float ChangeVelocity;
    public Vector3 ChangeSize;
}
