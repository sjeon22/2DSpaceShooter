using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_controller : MonoBehaviour
{
    public float scrollSpeed; // rate at which background will move on plane

    private Renderer renderer;
    private Vector2 savedOffset; // math for the scroll

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.Repeat(Time.time * scrollSpeed, 1); // loop the value max -> 0 -> max -> 0
        Vector2 offset = new Vector2(0, y); // each update is going to position 
        renderer.sharedMaterial.SetTextureOffset("_MainTex", offset); // sharedmaterial used to offset a texture on object
        // give image sprite Repeat mode under 'Wrap Mode'
    }
}
