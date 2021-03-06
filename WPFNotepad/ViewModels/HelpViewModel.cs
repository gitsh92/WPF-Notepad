﻿using System.Windows.Input;

namespace WPFNotepad.ViewModels
{
  public class HelpViewModel : ObservableObject
  {
    public ICommand HelpCommand { get; }

    public HelpViewModel()
    {
      HelpCommand = new RelayCommand(DisplayAbout);
    }

    private void DisplayAbout()
    {
      new HelpDialog().ShowDialog();
    }
  }
}
