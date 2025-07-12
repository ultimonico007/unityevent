using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class mov : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        float movimiento = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * movimiento * velocidad * Time.deltaTime);
    }
}