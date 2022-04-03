using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetPos : MonoBehaviour
{
    //float panelWidth = menuCanvasRectTransform.rect.width * menuCanvasRectTransform.localScale.x;
    //float panelHeight = menuCanvasRectTransform.rect.height * menuCanvasRectTransform.localScale.y;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 netPos = new Vector2(transform.position.x, Random.Range(690f, 545f));
        transform.position = netPos;

        /*
        Canvas canvas = FindObjectOfType<Canvas>();
        float h = canvas.GetComponent<RectTransform>().rect.height;
        Debug.Log(h);*/
    }

}
