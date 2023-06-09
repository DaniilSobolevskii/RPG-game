using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Outline>().OutlineWidth=3f;
            var bridge = FindObjectOfType<Bridge>();
          //  bridge.GetComponent<Collider>().enabled = false;
            bridge.enabled = false;
           
            Destroy(gameObject);
        }
    }
}
