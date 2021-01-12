using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beating : MonoBehaviour
{
    RectTransform rectTransform;
    int n = 0;
    Vector3 original;
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        original = rectTransform.localScale;
    }
    

    // Update is called once per frame
    void Update()
    {
        // rectTransform.localScale += Vector3.one * Mathf.Sin(Time.time);
        // rectTransform.localScale += new Vector3(Mathf.Sin(Time.time), 0.0f, 0.0f);
        rectTransform.localScale = original+ Vector3.one * Mathf.Sin(Time.time*8) * 0.1f;
        Debug.Log(1/Time.deltaTime);
    }
}
