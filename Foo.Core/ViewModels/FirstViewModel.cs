using System.Windows.Input;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using Foo.Core.Models;
using Foo.Core.Services;

namespace Foo.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
        public class SavedState
        {
            public string Hello { get; set; }    
        }

        private readonly IFooService _fooService;
        private FooModel _model;

        public string Hello
		{
            get { return _model.Hello; }
			set { _model.Hello = value; RaisePropertyChanged(() => Hello); }
		}

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

        public FirstViewModel(IFooService fooService)
        {
            _fooService = fooService;
        }

        public void Init()
        {
            this._model = this._fooService.GetModel();
        }

        public SavedState SaveState()
        {
            Mvx.Trace("SaveState: FirstViewModel");
            return new SavedState() { Hello = this.Hello };
        }

        //protected override void SaveStateToBundle(IMvxBundle bundle)
        //{
        //    bundle.Write(SaveState());
        //}

        public void ReloadState(SavedState savedState)
        {
            Mvx.Trace("ReloadState: FirstViewModel");
            this.Hello = savedState.Hello;
        }
    }
}
