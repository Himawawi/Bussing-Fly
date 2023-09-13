using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This method is for the ability to pick and gain effects based on the Item(SO).
public abstract class Pickup : MonoBehaviour
{
    /* Based on which ScriptableObject will be picked by the Player, this 
     * Method will be Overwritten with that Item's code/effect. */
    //public abstract void Interact(Player player);

    public abstract IEnumerator Interact(Player player);
}
