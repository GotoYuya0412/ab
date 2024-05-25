using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector3 player_pos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x+1,
                transform.position.y,0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x - 1,
                transform.position.y, 0);
        }
        player_pos = transform.position; //player‚ÌˆÊ’u‚ğæ“¾

        //xˆÊ’u‚ªí‚É”ÍˆÍ“à‚©ŠÄ‹
        player_pos.x = Mathf.Clamp(player_pos.x, -6, 6);
        //”ÍˆÍ“à‚Å‚ ‚ê‚Îí‚É‚»‚ÌˆÊ’u‚ª‚»‚Ì‚Ü‚Ü“ü‚é
        transform.position = new Vector3(player_pos.x, player_pos.y, 0);
    }

 
}
