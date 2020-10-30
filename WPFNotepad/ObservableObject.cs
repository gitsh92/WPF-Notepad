using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFNotepad
{
  public class ObservableObject : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged<T>(ref T property, T value, [CallerMemberName] string propertyName = "")
    {
      property = value;
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
