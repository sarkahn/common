using Sark.Common;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

[ExecuteAlways]
public class PixelSnapTest : MonoBehaviour
{
    void Update()
    {
        float3 p = transform.position;
        p.xy = MathUtil.roundedincrement(p.xy, 1f / 8);
        transform.position = p;
    }
}
