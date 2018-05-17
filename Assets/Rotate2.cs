using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2 : MonoBehaviour {

    private void OnMouseUpAsButton()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("avion2");

        if (gos.Length == 0)
        {
            Debug.Log("ERROR!!!! No game objects are tagged with avion2");
        }
        else
        {
            GameObject go;
            go = GameObject.FindGameObjectWithTag("avion2");
            //Debug.Log(go.ToString());
            //transform.Rotate(0, 0, 90);
            go.transform.Rotate(0, 0, 90);

        }
    }

}
