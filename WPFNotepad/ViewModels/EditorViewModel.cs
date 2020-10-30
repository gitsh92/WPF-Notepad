using System;
using System.Windows;
using System.Windows.Input;
using WPFNotepad.Models;

namespace WPFNotepad.ViewModels
{
  public class EditorViewModel
  {
    public ICommand FormatCommand { get; }
    public ICommand WrapCommand { get; }
    public FormatModel Format { get; set; }
    public DocumentModel Document { get; set; }

    public EditorViewModel(DocumentModel document)
    {
      Document = document;
      Format = new FormatModel();
      FormatCommand = new RelayCommand(OpenStyleDialog);
      WrapCommand = new RelayCommand(ToggleWrap);
    }

    private void OpenStyleDialog()
    {
      throw new NotImplementedException();
    }

    private void ToggleWrap()
    {
      if (Format.Wrap == TextWrapping.Wrap)
        Format.Wrap = TextWrapping.NoWrap;
      else
        Format.Wrap = TextWrapping.Wrap;
    }
  }
}
