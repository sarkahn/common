using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace Sark.Common.CameraExtensions
{
    public static class CameraExtensions
    {
        /// <summary>
        /// Returns a position aligned to the camera's viewport.
        /// </summary>
        /// <param name="p">The viewport position to align to. [0 to 1]</param>
        /// <param name="align">How to align the position based on the given size. [-1 to 1]</param>
        /// <param name="size">The size of the thing being aligned.</param>
        /// <returns></returns>
        public static float3 GetAlignedViewportPosition(this Camera camera,
            float2 p, float2 align, float2 size)
        {
            float3 transformed = camera.ViewportToWorldPoint(new float3(p, 0));
            transformed.z = 0;

            align = size * align;

            transformed.xy += align * .5f;

            return transformed;
        }
    }
}