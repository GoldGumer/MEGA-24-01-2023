using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVector3
{
    public float x, y, z;

    public MyVector3(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    //Static functions
    static MyVector3 AddVector(MyVector3 a, MyVector3 b)
    {
        float x, y, z;
        x = a.x + b.x;
        y = a.y + b.y;
        z = a.z + b.z;
        return new MyVector3(x, y, z);
    }

    static MyVector3 SubtractVector(MyVector3 a, MyVector3 b)
    {
        float x, y, z;
        x = a.x - b.x;
        y = a.y - b.y;
        z = a.z - b.z;
        return new MyVector3(x, y, z);
    }

    static MyVector3 MultiplyVector(MyVector3 a, float b)
    {
        float x, y, z;
        x = a.x * b;
        y = a.y * b;
        z = a.z * b;
        return new MyVector3(x, y, z);
    }

    static MyVector3 DivideVector(MyVector3 a, float b)
    {
        float x, y, z;
        x = a.x / b;
        y = a.y / b;
        z = a.z / b;
        return new MyVector3(x, y, z);
    }

    public static MyVector3 operator +(MyVector3 a, MyVector3 b)
    {
        return AddVector(a, b);
    }

    public static MyVector3 operator -(MyVector3 a, MyVector3 b)
    {
        return SubtractVector(a, b);
    }

    public static MyVector3 operator *(MyVector3 a, float b)
    {
        return MultiplyVector(a, b);
    }

    public static MyVector3 operator /(MyVector3 a, float b)
    {
        return DivideVector(a, b);
    }

    public static MyVector3 Normalize(MyVector3 myVector3)
    {
        return myVector3 / myVector3.Length();
    }

    public static float DotProduct(MyVector3 a, MyVector3 b)
    {
        MyVector3 normA, normB;
        normA = Normalize(a);
        normB = Normalize(b);

        float dotProd = normA.x * normB.x + normA.y * normB.y + normA.z * normB.z;

        return dotProd;
    }

    //Non-Static functions
    public float LengthSquared()
    {
        return x * x + y * y + z * z;
    }

    public float Length()
    {
        return Mathf.Sqrt(LengthSquared());
    }

    public Vector3 GetUnityVect3()
    {
        return new Vector3(x, y, z);
    }
}
