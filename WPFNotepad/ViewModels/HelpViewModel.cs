using System.Windows.Input;

namespace WPFNotepad.ViewModels
{
  public class HelpViewModel : ObservableObject
  {
    public ICommand HelpCommand { get; }

    public HelpViewModel()
    {
      HelpCommand = new RelayCommand(null);
    }

    private void DisplayAbout()
    {
      // open help dialog
    }
  }
}
