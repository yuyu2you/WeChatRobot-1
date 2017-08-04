﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WXLogin
{
    public class WXUserViewModel : System.ComponentModel.INotifyPropertyChanged
    {
        private string _userName;
        private string _displayName;
        private UserType _userType;
        private string _headImgUrl;
        private bool? _isCheck = false;
        private string _fontColor= "#FF000000"; // black, #FFFF0000: red
        private bool _visiable = true;
        private object _bitMapImage;

        public object BitMapImage
        {
            set
            {
                _bitMapImage = value;
                OnPropertyChanged(nameof(BitMapImage));
            }
            get => _bitMapImage;
        }
        public bool Visiable
        {
            set
            {
                _visiable = value;
                OnPropertyChanged(nameof(Visiable));
            }
            get => _visiable;
        }
        public string FontColor
        {
            set
            {
                _fontColor = value;
                OnPropertyChanged(nameof(FontColor));
            }
            get => _fontColor;
        }
        public bool? IsCheck
        {
            set
            {
                _isCheck = value;
                OnPropertyChanged(nameof(IsCheck));
            }
            get => _isCheck;
        }
        public string UserName
        {
            set
            {
                _userName = value;
                OnPropertyChanged(nameof(UserName));
            }
            get => _userName;
        }
        public string DisplayName
        {
            set
            {
                _displayName = value;
                OnPropertyChanged(nameof(DisplayName));
            }
            get => _displayName;
        }
        public UserType UserType
        {
            set
            {
                _userType = value;
                OnPropertyChanged(nameof(UserType));
            }
            get => _userType;
        }

        public string HeadImgUrl
        {
            set
            {
                _headImgUrl = value;
                OnPropertyChanged(nameof(HeadImgUrl));
            }
            get => _headImgUrl;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
