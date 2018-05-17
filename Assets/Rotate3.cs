﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate3 : MonoBehaviour {

    private void OnMouseUpAsButton()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("avion3");

        if (gos.Length == 0)
        {
            Debug.Log("ERROR!!!! No game objects are tagged with avion3");
        }
        else
        {
            GameObject go;
            go = GameObject.FindGameObjectWithTag("avion3");
            //Debug.Log(go.ToString());
            //transform.Rotate(0, 0, 90);
            go.transform.Rotate(0, 0, 90);

        }
    }

}
