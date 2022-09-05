using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject[] food;
    private int index ;
    public int Index { get => index; set => index = value; }

    // Update is called once per frame
    void Update()
    {
        bool mouseClick = Input.GetKeyDown(KeyCode.E);
        if (mouseClick)
        {
            GameObject.Instantiate(food[index], transform.position, food[index].transform.rotation);
        }
    }
}
