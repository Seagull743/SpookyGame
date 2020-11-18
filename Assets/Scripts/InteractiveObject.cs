using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{



    public virtual void PlayerInteraction() { }




    void OnMouseOver()
    {

        if (Vector3.Distance(gameObject.transform.position, GM.instance.player.transform.position) <= PlayerRaycast.MaxDistance)
        {
            GM.instance.InteractCross();
        }

       
    }

    private void OnMouseExit()
    {
        GM.instance.Normalcross();
    }

}