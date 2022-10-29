using kpz_2_UI.ViewModels;
using Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using kpz_2_UI.Base;

namespace kpz_2_UI
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        DataModel _model;
        DataViewModel _viewModel;
        public App()
        {
            new Mapping().Create();
            _model = DataModel.Load();
            _viewModel = Mapper.Map<DataModel, DataViewModel>(_model);
            var window = new MainWindow() { DataContext = _viewModel };
            window.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
               
                _model = Mapper.Map<DataViewModel, DataModel>(_viewModel);
                _model.Save();
            }
            catch(Exception)
            {
                base.OnExit(e);
                throw;
            }
        }


    }
}
