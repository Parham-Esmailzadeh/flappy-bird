using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer mRenderer;
    public  float AnimationSpeed = 0.05f;

    void Awake(){
        mRenderer = GetComponent<MeshRenderer>();
    }

    void Update(){
        mRenderer.material.mainTextureOffset += new Vector2(AnimationSpeed * Time.deltaTime, 0);
    }
}
