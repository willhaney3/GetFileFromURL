﻿using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetFileFromURL
{
  // added changes to test source control branch
  // add another
  // github - willhaney3
  public partial class Form1 : Form
  {
    #region Events
    public Form1()
    {
      InitializeComponent();
    }

    private async void btnExecute_Click(object sender, EventArgs e)
    {
      //show waiting cursor
      Application.UseWaitCursor = true;
      try
      {
        // get file from url and save to file
        await Task.Run(() => GetFileFormURLAsynch(txtURL.Text, txtPath.Text));
        // display message        
        MessageBox.Show("File has been downloaded to folder.");
      }
      catch (Exception exception)
      {
        // display error message
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
      // download file
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
