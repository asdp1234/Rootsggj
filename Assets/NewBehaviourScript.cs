using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    public int length;
    public LineRenderer lr;
    public Vector3[] segmentspos;
    public Vector3[] smeg;

    public Transform target;

    public float speed;
    public float dis;

    public Transform rootbase;
    
    private void Start()
    {
        lr.positionCount = 3;
        segmentspos = new Vector3[3];
        smeg = new Vector3[3];

    }

    private void Update()
    {
        segmentspos[0] = target.position;
        
                for (int i = 1; i < segmentspos.Length - 1; i++)
                {
                    segmentspos[i] = Vector3.SmoothDamp(segmentspos[i], segmentspos[i-1]+target.right * dis,ref smeg[i],speed);
                }
        
        segmentspos[segmentspos.Length - 1] = rootbase.position;
        lr.SetPositions(segmentspos);

    }
}
