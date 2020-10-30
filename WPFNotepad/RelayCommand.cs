﻿using System;
using System.Windows.Input;

namespace WPFNotepad
{
  public class RelayCommand : ICommand
  {
    private readonly Action _execute;
    private readonly Func<bool> _canExecute;

    public event EventHandler CanExecuteChanged
    {
      add { CommandManager.RequerySuggested += value; }
      remove { CommandManager.RequerySuggested -= value; }
    }

    public RelayCommand(Action execute, Func<bool> canExecute)
    {
      _execute = execute ?? throw new ArgumentNullException(nameof(execute));
      _canExecute = canExecute;
    }

    public RelayCommand(Action execute) : this(execute, null) { }

    public bool CanExecute(object parameter)
    {
      return _canExecute == null || _canExecute();
    }

    public void Execute(object parameter)
    {
      _execute();
    }
  }
}