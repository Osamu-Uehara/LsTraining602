using System;
using System.ComponentModel;
using Xamarin.Forms;
using LsTraining602.Models;
using LsTraining602.BasePages;

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
        public Command CountUpCommand { get; }

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
            CountUpCommand = new Command(() =>
            {
                // Modelクラスのカウントアップメソッド呼び出し
                _count.Increment();
                // UIに変更通知を行う為の指定
                OnPropertyChanged(nameof(CurrentNumber));
            });
        }
    }
}
