using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms 
{
  public static partial class Algorithms 
  {
    public static T[] Mergesort<T>(IEnumerable<T> elems) where T : IComparable<T> 
    {
      var elemsAsArr = elems as T[] ?? elems.ToArray<T>();
      var elemsAsSpan = new Span<T>(elemsAsArr);
      SpanMergesort(elemsAsSpan);

      return elemsAsArr;
    }

    private static void SpanMergesort<T>(Span<T> elems) where T : IComparable<T>
    {
      if(elems.Length <= 1) return;

      var mid = elems.Length / 2;
      SpanMergesort<T>(elems.Slice(0, mid));
      SpanMergesort<T>(elems.Slice(mid));

      var merged = Merge(elems, mid);
      merged.CopyTo(elems);
    }

    private static Span<T> Merge<T>(Span<T> elems, int mid) where T : IComparable<T>
    {
      var merged = new Span<T>(new T[elems.Length]);

      var left = 0;
      var right = mid;
      var curr = 0;

      while(left < mid || right < elems.Length)
      {
        if(right >= elems.Length || left < mid && elems[left].CompareTo(elems[right]) < 0)
        {
          merged[curr] = elems[left];
          left++;
          curr++;
        }
        else
        {
          merged[curr] = elems[right];
          right++;
          curr++;
        }
      }

      return merged;
    }
  }
}