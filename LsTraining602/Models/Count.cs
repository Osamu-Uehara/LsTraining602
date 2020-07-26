using System;
namespace LsTraining602.Models
{
    public class Count
    {
        private int _countValue;
        public int CountValue
        {
            get { return _countValue; }
            set { _countValue = value; }
        }

        public void Increment()
        {
            _countValue += 1;
        }
    }
}
