using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("w"))
        {
            MovePlayer(Vector3.up);
        }
        if (Input.GetKeyDown("a"))
        {
            MovePlayer(Vector3.left);
        }
        if (Input.GetKeyDown("s"))
        {
            MovePlayer(Vector3.down);
        }
        if (Input.GetKeyDown("d"))
        {
            MovePlayer(Vector3.right);
        }
    }

    void MovePlayer(Vector3 direction)
    {
        transform.Translate(direction);
    }
}
