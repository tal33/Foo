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
    public class ThirdViewModel : MvxViewModel
    {
        public class SavedState
        {
            public string SubFoo { get; set; }
        }

        private readonly IFooService _fooService;
        private FooModel _model;

        public string SubFoo
        {
            get { return _model.Sub; }
            set
            {
                _model.Sub = value;
                RaisePropertyChanged(() => SubFoo);
            }
        }

        #region GoFirstCommand
        private MvxCommand _goFirstCommand;

        public ICommand GoFirstCommand
        {
            get
            {
                _goFirstCommand = _goFirstCommand ?? new MvxCommand(() =>
                {
                    this._fooService.UpdateModel(this._model);
                    ShowViewModel<FirstViewModel>();
                });
                return _goFirstCommand;
            }
        }
        #endregion

        private MvxCommand _goSecondCommand;
        public ICommand GoSecondCommand
        {
            get
            {
                _goSecondCommand = _goSecondCommand ?? new MvxCommand(() =>
                {
                    this._fooService.UpdateModel(this._model);
                    ShowViewModel<SecondViewModel>();
                });
                return _goSecondCommand;
            }
        }

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

        public ThirdViewModel(IFooService fooService)
        {
            _fooService = fooService;
        }

        public void Init()
        {
            this._model = this._fooService.GetModel();
        }

        public SavedState SaveState()
        {
            return new SavedState() { SubFoo = this.SubFoo};
        }

        public void ReloadState(SavedState savedState)
        {
            this.SubFoo = savedState.SubFoo;
        }
        
    }
}
