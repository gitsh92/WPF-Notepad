﻿using Microsoft.Win32;
using System.IO;
using System.Windows.Input;
using WPFNotepad.Models;

namespace WPFNotepad.ViewModels
{
  public class FileViewModel
  {
    public DocumentModel Document { get; private set; }

    // toolbar commands
    public ICommand NewCommand { get; }
    public ICommand SaveCommand { get; }
    public ICommand SaveAsCommand { get; }
    public ICommand OpenCommand { get; }

    public FileViewModel(DocumentModel document)
    {
      Document = document;
    }

    public void NewFile()
    {
      Document.FileName = string.Empty;
      Document.FilePath = string.Empty;
      Document.Text = string.Empty;
    }

    private void SaveFile()
    {
      File.WriteAllText(Document.FilePath, Document.Text);
    }

    private void SaveFileAs()
    {
      var saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "Text Documents (*.txt)|*.txt";
      if (saveFileDialog.ShowDialog() == true)
      {
        DockFile(saveFileDialog);
        File.WriteAllText(saveFileDialog.FileName, Document.Text);
      }
    }

    private void OpenFile()
    {
      var openFileDialog = new OpenFileDialog();
      if (openFileDialog.ShowDialog() == true)
      {
        DockFile(openFileDialog);
        Document.Text = File.ReadAllText(openFileDialog.FileName);
      }
    }

    private void DockFile<T>(T dialog) where T : FileDialog
    {
      Document.FilePath = dialog.FileName;
      Document.FileName = dialog.SafeFileName;
    }
  }
}