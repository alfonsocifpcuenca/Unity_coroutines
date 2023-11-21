using System.Collections;
using UnityEngine;

public class Coroutine_01 : MonoBehaviour
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
        for (float alpha = 1f; alpha >= 0; alpha -= 0.01f)
        {
            c.a = alpha;
            renderer.material.color = c;
            yield return null;
        }

        c.a = 0f;
        renderer.material.color = c;
    }
}
