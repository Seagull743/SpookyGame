using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDrawerTrigger : MonoBehaviour
{
    public GameObject Drawer;
    public DrawerOpenEvent DO;
    public GameObject trigger;


    void Start()
    {
        
      
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine("TriggerSpawnLater");
        }
    }

    IEnumerator TriggerSpawnLater()
    {
        Debug.Log("Drawer is going to open");
        yield return new WaitForSeconds(30);
        DO.DrawerOpen();
        Drawer.GetComponent<Animator>().SetBool("DrawOpened", true);
        Destroy(gameObject);
    }
}
