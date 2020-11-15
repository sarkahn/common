using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace Sark.Common
{
    public static class MathUtil
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int mod(int x, int period)
        {
            return ((x % period) + period) % period;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 mod(int2 xy, int2 period)
        {
            return ((xy % period) + period) % period;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 mod(int3 xyz, int3 period)
        {
            return ((xyz % period) + period) % period;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float roundedincrement(float value, float increments)
        {
            increments = 1f / increments;
            return math.round(value * increments) / increments;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 roundedincrement(float2 v, float2 increments)
        {
            increments = new float2(1, 1) / increments;
            return math.round(v * increments) / increments;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 roundedincrement(float3 value, float3 increments)
        {
            increments = new float3(1) / increments;
            return math.round(value * increments) / increments;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float flooredincrement(float value, float increments)
        {
            increments = 1f / increments;
            return math.floor(value * increments) / increments;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 flooredincrement(float2 v, float2 increments)
        {
            increments = new float2(1) / increments;
            return math.floor(v * increments) / increments;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 flooredincrement(float3 value, float3 increments)
        {
            increments = new float3(1) / increments;
            return math.floor(value * increments) / increments;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int convertrange(
            int value,
            int originalStart, int originalEnd,
            int newStart, int newEnd )
        {
            double scale = (double)(newEnd - newStart) / (originalEnd - originalStart);
            return (int)(newStart + ((value - originalStart) * scale));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float convertrange(
            float value,
            float originalStart, float originalEnd, // original range
            float newStart, float newEnd) // value to convert
        {
            double scale = (double)(newEnd - newStart) / (originalEnd - originalStart);
            return (float)(newStart + ((value - originalStart) * scale));
        }
    }
}