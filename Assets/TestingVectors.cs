using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingVectors : MonoBehaviour
{
    [SerializeField] float[] floatA, floatB;
    [SerializeField] float divA;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MyVector3 a = new MyVector3(floatA[0], floatA[1], floatA[2]);
        MyVector3 b = new MyVector3(floatB[0], floatB[1], floatB[2]);
        Debug.DrawRay(new Vector3(0, 0, 0), a.GetUnityVect3(), Color.red);
        Debug.DrawRay(new Vector3(0, 0, 0), b.GetUnityVect3(), Color.green);
    }
}
