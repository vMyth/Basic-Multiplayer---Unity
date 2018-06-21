using UnityEngine;
using System.Collections;

public class Billboards : MonoBehaviour
{

    void Update()
    {
        transform.LookAt(Camera.main.transform);
    }
}