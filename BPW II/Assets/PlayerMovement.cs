using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

 public class PlayerMovement : MonoBehaviour
 {
     public Tilemap groundTilemap;
     public Tilemap collisionTilemap;
     
    void Update()
    {
        
        if (Input.GetKeyDown("w")) { MovePlayer(Vector3.up); }
        if (Input.GetKeyDown("a")) { MovePlayer(Vector3.left); }
        if (Input.GetKeyDown("s")) { MovePlayer(Vector3.down); }
        if (Input.GetKeyDown("d")) { MovePlayer(Vector3.right); }
    }

    void MovePlayer(Vector3 direction)
    {   
        if (CanMove(direction))
        {
            transform.Translate(direction);
        }
        
    }

    bool CanMove(Vector3 direction)
    {
        Vector3Int gridPosition = groundTilemap.WorldToCell(transform.position + direction);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, 1f);

        if (hit.collider != null)
        {
            return false;
        }
        if (!groundTilemap.HasTile(gridPosition))
        {
            return false;
        }
        // if (collisionTilemap.HasTile(gridPosition))
        // {
        //     return false;
        // }

        return true;
    }
}
