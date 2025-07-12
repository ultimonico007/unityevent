using UnityEngine;
using UnityEngine.Events;

public class Playerhealth : MonoBehaviour
{
    public int salud = 100;

    public UnityEvent onHealthChanged;

    public void TomarDa�o(int da�o)
    {
        salud -= da�o;
        if (salud < 0) salud = 0;

        if (onHealthChanged != null)
            onHealthChanged.Invoke(); 
    }
}
