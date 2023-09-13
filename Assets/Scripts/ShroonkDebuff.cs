using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code for the ShroonkDebuff that will overwrite the Pickup method.
public class ShroonkDebuff : Pickup
{
    public override IEnumerator Interact(Player player)
    {
        Item item = GetComponent<Item>();
        player.velocity *= item.item.ChangeVelocity;
        player.transform.localScale -= item.item.ChangeSize;
        player.sfxSource.PlayOneShot(player.sfxClips[2]);
        Destroy(gameObject);
        yield return new WaitForSeconds(5);
        player.velocity /= item.item.ChangeVelocity;
        player.transform.localScale += item.item.ChangeSize;
        //Destroy(gameObject);
    }
}
