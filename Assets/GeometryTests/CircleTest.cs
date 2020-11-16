using Sark.Common;
using Sark.Common.Geometry;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CircleTest : MonoBehaviour
{
    [SerializeField]
    int _radius = 5;

    private void OnDrawGizmos()
    {
        float3 pos = transform.position;
        int2 xy = (int2)pos.xy;
        var empty = new EmptyCircle(xy.x, xy.y, _radius);

        foreach(var p in empty)
        {
            float3 point = pos + new float3(p, 1);
            Gizmos.DrawCube(point, Vector3.one);
        }

        var filled = new FilledCircle(xy.x, xy.y, _radius);
        foreach (var p in filled)
        {
            float3 point = pos + new float3(p, 1) + new float3(_radius * 2 + 2, 0, 0);
            Gizmos.DrawCube(point, Vector3.one);
        }
    }
}
