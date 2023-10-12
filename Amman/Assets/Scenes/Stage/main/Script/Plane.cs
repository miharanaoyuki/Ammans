using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    [SerializeField] GameObject plane;

    void Start()
    {
        StartCoroutine("_Plane");
    }

    IEnumerator _Plane()
    {
        while (true)
        {
            Instantiate(
                plane,
                new Vector3(13.2f, 3.0f, 0.0f),
                transform.rotation
            );
            //ÅZïbÇ≤Ç∆Ç…é¿çsÇ∑ÇÈÅB
            yield return new WaitForSeconds(7.0f);
        }
    }
}