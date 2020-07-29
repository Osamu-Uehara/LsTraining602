using System;
using System.ComponentModel;

namespace LsTraining602.BasePages
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// プロパティの変更があったときに発行されます。
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// PropertyChangedイベントを発行します。
        /// </summary>
        /// <param name="propertyName">プロパティ名</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            // UIに変更通知を行う為の設定
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
