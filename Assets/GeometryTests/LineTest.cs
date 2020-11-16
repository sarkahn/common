using Sark.Common;
using Sark.Common.Geometry;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class LineTest : MonoBehaviour
{
    [SerializeField]
    Transform _p2;

    private void OnDrawGizmos()
    {
        if (_p2 == null)
            return;

        float3 p1 = transform.position;
        float3 p2 = _p2.position;

        var line = new Line2D((int2)p1.xy, (int2)p2.xy);

        foreach(var p in line)
        {
            float3 point = new float3(p, 0);
            Gizmos.DrawCube(point, Vector3.one);
        }

        p1.y += 3;
        p2.y += 3;

        var lineNoDiags = new Line2DNoDiagonals((int2)p1.xy, (int2)p2.xy);
        //var lineNoDiags = new Line2DNoDiagonals((int2)p1.xy, (int2)p2.xy).GetListOfPoints();

        foreach(var p in lineNoDiags)
        {
            float3 point = new float3(p, 0);
            Gizmos.DrawCube(point, Vector3.one);
        }
    }
}
