using Sark.Common;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

using Sark.Common.CameraExtensions;

public class AlignTest : MonoBehaviour
{
    [SerializeField]
    float2 _pos;

    [SerializeField]
    float2 _align = 0;

    [SerializeField]
    float2 _size = 5;

    private void OnDrawGizmos()
    {
        var p = Camera.main.GetAlignedViewportPosition(_pos, _align, _size);
        Gizmos.DrawCube(p, new float3(_size, 1));
    }
}
