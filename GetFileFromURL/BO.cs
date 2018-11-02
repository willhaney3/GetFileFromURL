using System.IO;
using System.Net;
using System.Windows.Forms;

namespace GetFileFromURL
{
  public static class BO
  {
    public static void DownloadFile(string url, string folder)
    {
      // get web client and dispose when done
      using (var webclient = new WebClient())
      {
        // get file name from url
        var filename = url.Substring(url.LastIndexOf('/') + 1);
        // build destination path from folder and file name
        var destinationPath = Path.Combine(folder, filename);
        // read file from url
        var bytes = webclient.DownloadData(url);
        // writew file to detination
        File.WriteAllBytes(destinationPath, bytes);
      }
    }

    public static string GetFolder()
    {
      // results
      var results = string.Empty;
      using (var folderBrowserDialog = new FolderBrowserDialog())
      {
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
          results = folderBrowserDialog.SelectedPath;
        }
      }
      return results;
    }

    public static void Exit()
    {
      Application.Exit();
    }
    
  }
}
