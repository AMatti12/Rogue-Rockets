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
        Vector2 netPos = transform.position;
        netPos.y = Random.Range(200f, 650f);
        transform.position = netPos;
            //Debug.Log(netPos);

        
       //transform.position = netPos;
           // Debug.Log(netPos);
        
    }

/*
if (tag =="Internal")
        {
            transform.position = netPos;
            //Debug.Log(netPos);
        }
        else
        {
            netPos.y += 443;
            transform.position = netPos;
            Debug.Log(netPos);
        }
*/
//50 = min
//650 = max
}
