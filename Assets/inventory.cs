using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Inventory : MonoBehaviour
{
    public int cantidadObjetos = 0;
    public UnityEvent onInventoryChanged;

    public void AddItem()
    {
        cantidadObjetos++;
        Debug.Log("Objeto recogido. Total: " + cantidadObjetos);

        if (onInventoryChanged != null)
            onInventoryChanged.Invoke(); 
    }
}