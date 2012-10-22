using System;
using System.Collections.Generic;

namespace Sorting
{
	public abstract class Sorter<T> where T : IComparable<T>
	{
		int Compare(T one, T other){
			return one.CompareTo(other);
		}

		public void Sort (IList<T> list)
		{
			//InsertionSort (list);
			MergeSort (list,0,list.Count-1);
			//Quicksort (0,list.Count-1,list);
		}

		private void InsertionSort(IList<T> list){
			for(int i=1;i<list.Count;i++){
				int j=i-1;
				while(j>=0 && Compare (list[i],list[j])<0){
					Swap (i--,j,list);
					j--;
				}
			}
		}

		private void MergeSort (IList<T> list, int s, int e)
		{
			if (e > s) {
				int center = (int)Math.Floor ((double)((s+e) / 2));
				MergeSort (list, s, center);
				MergeSort (list, center + 1, e);
				Quicksort (s, e, list);
			}
		}
		
		private void Quicksort(int startIndex, int endIndex, IList<T> list){

			//pivot is the last element
			T pivot = list [endIndex];
			
			int swapIndex=startIndex;
			for (int i=startIndex;i<endIndex;i++) {
				if(Compare(list[i],pivot) < 0){
					Swap(i,swapIndex,list);
					swapIndex++;
				}
			}
			//restore pivot
			Swap (swapIndex,endIndex,list);
			
			if(Math.Abs(startIndex-swapIndex)>1)
				Quicksort(startIndex,swapIndex-1,list);
			if(Math.Abs(swapIndex+1-endIndex)>1)
				Quicksort(swapIndex+1,endIndex,list);
		}
		
		public void Swap(int a, int b, IList<T> list){
			T temp = list[a];
			list[a] = list[b];
			list[b] = temp;
		}
	}


}

