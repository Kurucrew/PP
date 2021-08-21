using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiecesTable : MonoBehaviour
{

    private Vector3 RightPosition;
    public bool InRightPosition;
    // Start is called before the first frame update
    void Start()
    {
        RightPosition = transform.position;
        transform.position = new Vector3(Random.Range(11f, 18f), Random.Range(4f, -5f));// ���۽ÿ� ���� ���۵��� ���� ������ ��ҿ� ��ġ��Ű�� �ڵ�
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, RightPosition) < 0.5f)
        {
            transform.position = RightPosition;
            InRightPosition = true;
        }
    }
}
