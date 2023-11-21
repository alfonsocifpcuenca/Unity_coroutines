using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coroutine_02 : MonoBehaviour
{
    private Renderer renderer;

    private void Start()
    {
        this.renderer = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        Color c = renderer.material.color;
        for (float alpha = 1f; alpha >= 0; alpha -= 0.1f)
        {
            c.a = alpha;
            renderer.material.color = c;
            yield return new WaitForSeconds(.1f);
        }

        c.a = 0f;
        renderer.material.color = c;
    }
}
