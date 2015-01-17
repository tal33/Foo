using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;
using Foo.Core.Models;
using Foo.Core.Services;

namespace Foo.Core.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        public class SavedState
        {
            public string Super { get; set; }
        }

        private readonly IFooService _fooService;
        private FooModel _model;

        #region SuperFoo


        public string SuperFoo
        {
            get { return _model.Super; }
            set
            {
                _model.Super = value;
                RaisePropertyChanged(() => SuperFoo);
            }
        }

        #endregion

        #region GoFirstCommand
        private MvxCommand _goFirstCommand;

        public ICommand GoFirstCommand
        {
            get
            {
                _goFirstCommand = _goFirstCommand ?? new MvxCommand(() => {
                    this._fooService.UpdateModel(this._model);
                    ShowViewModel<FirstViewModel>();
                });
                return _goFirstCommand;
            }
        }
        #endregion

        #region GoThirdCommand
        private MvxCommand _goThirdCommand;

        public ICommand GoThirdCommand
        {
            get
            {
                _goThirdCommand = _goThirdCommand ?? new MvxCommand(() =>
                {
                    this._fooService.UpdateModel(this._model);
                    ShowViewModel<ThirdViewModel>();
                });
                return _goThirdCommand;
            }
        }
        #endregion

        #region GoBackCommand
        private MvxCommand _goBackCommand;

        public ICommand GoBackCommand
        {
            get
            {
                _goBackCommand = _goBackCommand ?? new MvxCommand(() =>
                {
                    this._fooService.UpdateModel(this._model);
                    Close(this);
                });
                return _goBackCommand;
            }
        }
        #endregion

        public SecondViewModel(IFooService fooService)
        {
            _fooService = fooService;
        }

        public void Init()
        {
            this._model = this._fooService.GetModel();
        }

        public SavedState SaveState()
        {
            return new SavedState() { Super = this.SuperFoo };
        }

        public void ReloadState(SavedState savedState)
        {
            this.SuperFoo = savedState.Super;
        }
         
    }
}
