using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hola : MonoBehaviour
{

    public GameObject CubePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ClonarCubos()
    {
        Instantiate(CubePrefab);
    }
}
