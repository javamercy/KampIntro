using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K, V>
    {

        K[] _keyArray;
        V[] _valueArray;


        public MyDictionary()
        {
            _keyArray = new K[0];
            _valueArray = new V[0];

        }

        public void Add(K key, V value)
        {
            if (CheckIfKeyExists(key))
            {
                throw new Exception(key + " already exists.");
            }

            K[] tempKeyArray;
            V[] tempValueArray;

            tempKeyArray = _keyArray;
            tempValueArray = _valueArray;

            _keyArray = new K[_keyArray.Length + 1];
            _valueArray = new V[_valueArray.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {

                _keyArray[i] = tempKeyArray[i];
                _valueArray[i] = tempValueArray[i];

            }

            _keyArray[_keyArray.Length - 1] = key;
            _valueArray[_valueArray.Length - 1] = value;


        }



        private bool CheckIfKeyExists(K key)
        {

            foreach (K k in _keyArray)
            {
                if (k.Equals(key))
                {
                    return true;
                }
            }

            return false;
        }

        public int Count
        {
            get { return _keyArray.Length; }
        }

    }
}
