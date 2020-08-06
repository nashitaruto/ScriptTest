using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        for (int n = 4; n > -1; n--)
        {
            Debug.Log(array[n]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}