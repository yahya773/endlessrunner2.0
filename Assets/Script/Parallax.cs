using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    GameObject player;
    Renderer rend;

    float playerStartPos;
    public float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        rend = GetComponent<Renderer>(); //Find the renderer
        playerStartPos = player.transform.position.x; //Save our starting position
        
    }

    // Update is called once per frame
    void Update()
    {
        float offset = (player.transform.position.x - playerStartPos) * speed;
        //^^^^^^^^^^^ This line finds out much to offset the texture by.
        //We do this by subtracting our starting X position from our current X position
        //We do then multiply the offset by the speed, so that we can have different layers
        //moving at different speeds

        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0f));
    }
}
