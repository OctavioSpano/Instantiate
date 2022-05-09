using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;

    public int cant;
    public void CloneObject()
    
    {
        int i = 0;
        while (i < cant)
        {
            Instantiate(objectToClone);
            i++;
        }
    }
}
