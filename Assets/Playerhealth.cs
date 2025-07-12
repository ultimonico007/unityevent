using UnityEngine;
using UnityEngine.Events;

public class Playerhealth : MonoBehaviour
{
    public int salud = 100;

    public UnityEvent onHealthChanged;

    public void TomarDaño(int daño)
    {
        salud -= daño;
        if (salud < 0) salud = 0;

        if (onHealthChanged != null)
            onHealthChanged.Invoke(); 
    }
}
