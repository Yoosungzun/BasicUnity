using System;
using UnityEngine;

public class FunctionExample : MonoBehaviour
{
    void Start()
    {
        SayHello(); //함수 호출출
        int total = AddNumbers(3, 5);
    }

    private int AddNumbers(int v1, int v2)
    {
        throw new NotImplementedException();
    }

    private void SayHello()
    {
        throw new NotImplementedException();
    }
}
