using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms 
{
  public static partial class Algorithms 
  {
    public static T[] Quicksort<T>(IEnumerable<T> elems) where T : IComparable<T>
    {
      var elemsAsArr = elems as T[] ?? elems.ToArray<T>();
      var elemsAsSpan = new Span<T>(elemsAsArr);
      SpanQuicksort<T>(elemsAsSpan);
      return elemsAsArr;
    }

    public static void SpanQuicksort<T>(Span<T> elems) where T : IComparable<T>
    {
      if(elems.Length <= 1) return;

      var pivot = elems[0];
      var pivotIndex = Partition(elems, pivot);

      SpanQuicksort(elems.Slice(0, pivotIndex));
      if(pivotIndex + 1 < elems.Length) 
        SpanQuicksort(elems.Slice(pivotIndex + 1));
    }

    private static int Partition<T>(Span<T> elems, T pivot) where T : IComparable<T>
    {
      var left = 0;
      var right = elems.Length - 1;

      while(left < right)
      {
        while(left < elems.Length && elems[left].CompareTo(pivot) <= 0) left++;
        while(elems[right].CompareTo(pivot) > 0) right--;

        if(left < right) Swap(elems, left, right);
      }
      Swap(elems, 0, right);

      return right;
    }

    private static void Swap<T>(Span<T> elems, int left, int right) where T : IComparable<T>
    {
      var temp = elems[left];
      elems[left] = elems[right];
      elems[right] = temp;
    }
  } 
}