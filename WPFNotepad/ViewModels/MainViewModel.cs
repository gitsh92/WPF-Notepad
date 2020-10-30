using WPFNotepad.Models;

namespace WPFNotepad.ViewModels
{
  public class MainViewModel
  {
    // shared active document to edit/load/save
    private DocumentModel _document;

    // manages user input for document and format styles
    public EditorViewModel Editor { get; set; }

    // manages saving and loading files
    public FileViewModel File { get; set; }

    // manage help dialog
    public HelpViewModel Help { get; set; }

    public MainViewModel()
    {
      _document = new DocumentModel();
      Help = new HelpViewModel();
      Editor = new EditorViewModel(_document);
      File = new FileViewModel(_document);
    }
  }
}
