namespace ConsoleApp13
{
    public class BaseClass<T>
    {
        public T[] _arr;

        public BaseClass()
        {
            _arr = new T[0];
        }
        public void Add(T obj)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = obj;
        }

        public void Clear()
        {
            Array.Resize(ref _arr, 0);
        }

        public void ShowAll()
        {
            foreach (T obj in _arr)
            {
                Console.WriteLine(obj);
            }
        }

        public void customAddRange(List<T> list)
        {
            foreach (var item in list)
            {
                Add(item);
            }
        }

        public bool customContains(T obj)
        {
            foreach (T item in _arr)
            {
                if (Equals(item, obj)) return true;
            }
            return false;
        }

        public int FirstIndexOf(T obj)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (Equals(obj, _arr[i])) return i;
            }
            return -1;
        }

        public void customRemove(T obj)
        {
            for (int i = 0; i <= _arr.Length - 1; i++)
            {
                if (Equals(_arr[i], obj))
                {
                    _arr[i] = default;
                    for (int j = i; j < _arr.Length - 1; j++)
                    {
                        _arr[j] = _arr[j + 1];
                    }
                    Array.Resize(ref _arr, _arr.Length - 1);
                }
            }
        }
    }
}
