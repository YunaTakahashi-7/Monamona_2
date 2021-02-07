using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnswer : MonoBehaviour
{
   public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(this.gameObject);
            Debug.Log("せいかーい");
        }else if (Input.GetKeyDown(KeyCode.N))
        {
            Destroy(this.gameObject);
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            Destroy(this.gameObject);
        }
    }
}
