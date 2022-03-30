using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class depth_script : MonoBehaviour
{
    public Material material;
    public int height= 1080; // Change to desired height
	public int width = 1080; // Change to desired width
	private Camera cam;
	private RenderTexture rt;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>(); 
        cam.depthTextureMode = DepthTextureMode.Depth;
    }

    void OnRenderImage (RenderTexture source, RenderTexture dest){
		Graphics.Blit(source, dest, material);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
