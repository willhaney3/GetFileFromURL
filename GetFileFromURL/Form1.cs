using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetFileFromURL
{
  // added chamges to test source control branch
  // add another
  public partial class Form1 : Form
  {
    #region Events
    public Form1()
    {
      InitializeComponent();
    }

    private async void btnExecute_Click(object sender, EventArgs e)
    {
      //show witing cursor
      Application.UseWaitCursor = true;
      try
      {
        // get file from url
        await Task.Run(() => GetFileFormURLAsynch(txtURL.Text, txtPath.Text));
        // display message        
        MessageBox.Show("File has been downloaded to folder.");
      }
      catch (Exception exception)
      {
        MessageBox.Show(exception.Message);
      }
      // show default cursor
      Application.UseWaitCursor = false;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      // exit application
      BO.Exit();
    }

    private void btnFolder_Click(object sender, EventArgs e)
    {
      // get folder
      GetFolder();
    }

    #endregion

    #region Methods
    private static void GetFileFormURLAsynch(string URL, string Path)
    {
      BO.DownloadFile(URL, Path);
    }

    private void GetFolder()
    {
      // get folder
      txtPath.Text = BO.GetFolder();
    }
    #endregion
  }
}
