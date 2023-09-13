using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code for the PoopBuff that will overwrite the Pickup method.
public class PoopBuff : Pickup
{
    public override IEnumerator Interact(Player player)
    {
        Item item = GetComponent<Item>();
        player.sfxSource.PlayOneShot(player.sfxClips[3]);
        player.enraged = true;
        Destroy(gameObject);
        yield return new WaitForSeconds(3);
        player.enraged = false;
        //Destroy(gameObject);
    }
}
