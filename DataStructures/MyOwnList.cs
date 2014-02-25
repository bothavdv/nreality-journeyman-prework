using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class MyOwnList<T>
    {
        T[] _innerArray = new T[0];
        int _currentSize = 0;
        int _capacity = 0;

        public MyOwnList(int initialSize)
        {
            _innerArray = new T[initialSize];
        }

        public MyOwnList()
        {

        }

        public void Add(T item)
        {
            // see if array needs to be resized
            if (_currentSize == _capacity)
            {
                // resize array
                _capacity = _capacity == 0 ? 4 : _capacity * 2;  // double capacity 
                var copy = new T[_capacity];    // create newly sized array
                Array.Copy(_innerArray, copy, _currentSize);  // copy over the array
                _innerArray = copy;    // assign innerArray to the new, larger array
            }

            _innerArray[_currentSize] = item;
            _currentSize++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _currentSize)
                    throw new IndexOutOfRangeException();
                return _innerArray[index];
            }
            set
            {
                if (index < 0 || index >= _currentSize)
                    throw new IndexOutOfRangeException();
                _innerArray[index] = value;
            }
        }

        public int BinarySearch(T item, IComparer<T> comparer)
        {
            //The zero-based index of item in the sorted List<T>, if item is found; otherwise, a negative number that is the bitwise complement 
            //of the index of the next element that is larger than item or, if there is no larger element, the bitwise complement of Count.
            for (var i = 0; i < _innerArray.Length; i++)
            {
                var index = comparer.Compare(item, _innerArray[i]);
                if (index == 0)
                    return index;
            }
            return -1;
        }
    }


}