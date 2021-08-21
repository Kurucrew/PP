using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePiece : MonoBehaviour
{
    public GameObject SelectedPiece;
    private bool press;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))//ÁÂÅ¬¸¯À» ´­·¶À» °æ¿ì
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if(hit.transform.CompareTag("Piece"))
            {
                if(!hit.transform.GetComponent<PiecesTable>().InRightPosition)
                {
                    SelectedPiece = hit.transform.gameObject;
                }        
            }
            //press = true;
        }
        
        if(Input.GetMouseButtonUp(0))
        {
            SelectedPiece = null;
            //press = false;
        }

        //if (press == true)
        if(SelectedPiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }

    }
}
