using System;
using System.ComponentModel;
using System.Windows.Input;
//using Xamarin.Forms;
using LsTraining602.Models;
using LsTraining602.BasePages;
using LsTraining602.Commands;

namespace LsTraining602.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// カウントモデルのインスタンスを保持
        /// </summary>
        public Count _count = new Count();

        /// <summary>
        /// コマンドバインドプロパティ
        /// </summary>
        public ICommand CountUpCommand { get; }

        /// <summary>
        /// カウント数値バインドプロパティ
        /// </summary>
        public int CurrentNumber { get { return _count.CountValue; } }

        /// <summary>
        /// イニシャライズ
        /// </summary>
        public MainViewModel()
        {
            // コマンド発行時に処理する内容の紐付け
            CountUpCommand = new CountUpCommand(Increment);
        }

        /// <summary>
        /// カウントアップ処理
        /// </summary>
        private void Increment()
        {
                // Modelクラスのカウントアップメソッド呼び出し
                _count.Increment();
                // UIに変更通知を行う為の指定
                OnPropertyChanged(nameof(CurrentNumber));
        }
    }
}
