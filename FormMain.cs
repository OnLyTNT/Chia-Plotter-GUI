using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using MetroSet_UI.Forms;
using MetroSet_UI.Controls;

namespace ChiaPlotterWinGUI
{
  enum ConfigMode
  { 
    Save,
    Execute
  }
  public partial class FormMain : MetroSetForm
  {
    private Process proc;
    public FormMain()
    {
      InitializeComponent();

      openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
      saveFileDialog1.InitialDirectory = openFileDialog1.InitialDirectory;
    }

    private void mstfinalDir_Click(object sender, EventArgs e)
    {
      if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        switch (((MetroSetTile)sender).Name)
        {
          case "mstFinalDir": tbFinalDir.Text = folderBrowserDialog1.SelectedPath; break;
          case "mstTempDir": tbTempDir.Text = folderBrowserDialog1.SelectedPath; break;
          case "mstTemp2Dir": tbTemp2Dir.Text = folderBrowserDialog1.SelectedPath; break;
          case "mstLogPath": tbLogPath.Text = folderBrowserDialog1.SelectedPath; break;
        }
      }
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("The configuration will be reset to defaults, continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
      {
        tbFinalDir.Text = "";
        tbTempDir.Text = "";
        tbTemp2Dir.Text = "";
        swAlternateTemps.Switched = false;
        swWait4Copy.Switched = false;
        cbPlots.SelectedIndex = -1;
        cbPlots.Text = "1";
        numThreads.Value = 4;
        numThreadX.Value = 1;
        numBuckets.Value = 0;
        numBuckets34.Value = 0;
        tbPoolKey.Text = "";
        tbFarmerKey.Text = "";
        tbContractKey.Text = "";
        swLogActive.Switched = false;
        tbLogPath.Text = "";
      }

//#if DEBUG
//      tbFinalDir.Text = "C:\\";
//      tbTempDir.Text = "C:\\";
//      tbTemp2Dir.Text = "C:\\";
//      swAlternateTemps.Switched = true;
//      swWait4Copy.Switched = true;
//      //cbPlots.SelectedIndex = -1;
//      cbPlots.Text = "1";
//      numThreads.Value = 8;
//      numThreadX.Value = 2;
//      numBuckets.Value = 1024;
//      numBuckets34.Value = 1024;
//      tbPoolKey.Text = "abcdefg";
//      tbFarmerKey.Text = "abcdefg";
//      tbContractKey.Text = "abcdefg";
//      swLogActive.Switched = true;
//      tbLogPath.Text = "C:\\";
//#endif
    }

    private void btnLoad_Click(object sender, EventArgs e)
    {
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        string[] config= File.ReadAllText(openFileDialog1.FileName).Split(" ");

        btnNew_Click(null, null);

        for (int i = 0; i < config.Length; i++)
        {
          switch(config[i])
          {
            case "-d": tbFinalDir.Text = config[i + 1]; break;
            case "-t": tbTempDir.Text = config[i + 1]; break;
            case "-2": tbTemp2Dir.Text = config[i + 1];  break;
            case "-G": swAlternateTemps.Switched = true; break;
            case "-w": swWait4Copy.Switched = true;  break;
            case "-n":
              if (config[i + 1] == "1")
                cbPlots.SelectedIndex = 0;
              else if (config[i + 1] == "-1")
                cbPlots.SelectedIndex = 1;
              else
                cbPlots.Text = config[i + 1]; break;
            case "-r": numThreads.Value = int.Parse(config[i + 1]); break;
            case "-K": numThreadX.Value = int.Parse(config[i + 1]); break;
            case "-u": numBuckets.Value = int.Parse(config[i + 1]); break;
            case "-v": numBuckets34.Value = int.Parse(config[i + 1]); break;
            case "-p": tbPoolKey.Text = config[i + 1]; break;
            case "-f": tbFarmerKey.Text = config[i + 1]; break;
            case "-c": tbContractKey.Text = config[i + 1]; break;
            case "-l":
              swLogActive.Switched = true;
              tbLogPath.Text = config[i + 1]; break;
          }
        }
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        File.WriteAllText(saveFileDialog1.FileName, GetConfig(ConfigMode.Save));
    }

    //-k, --size arg       K size(default = 32, k <= 32)
    //-x, --port arg       Network port(default = 8444, chives = 9699)
    //-n, --count arg      Number of plots to create(default = 1, -1 = infinite)
    //-r, --threads arg    Number of threads(default = 4)
    //-u, --buckets arg    Number of buckets(default = 256)
    //-v, --buckets3 arg   Number of buckets for phase 3+4 (default = buckets)
    //-t, --tmpdir arg     Temporary directory, needs ~220 GiB(default = $PWD)
    //-2, --tmpdir2 arg    Temporary directory 2, needs ~110 GiB[RAM] (default = <tmpdir>)
    //-d, --finaldir arg   Final directory(default = <tmpdir>)
    //-w, --waitforcopy Wait for copy to start next plot
    //-p, --poolkey arg    Pool Public Key(48 bytes)
    //-c, --contract arg   Pool Contract Address(62 chars)
    //-f, --farmerkey arg  Farmer Public Key(48 bytes)
    //-G, --tmptoggle Alternate tmpdir/tmpdir2(default = false)
    //-K, --rmulti2 arg    Thread multiplier for P2(default = 1)
    //    --help Print help

    private string GetConfig(ConfigMode cmode)
    {
      //string GetDirectoryPath(string path)
      //{
      //  string tempPath = path.Trim();

      //  if (tempPath != "" && !Directory.Exists(tempPath))
      //    throw new Exception(path + " is not a valid path");

      //  return tempPath;
      //}

      static string GetIntParam(string value)
      {
        int param = 0;

        if (int.TryParse(value.Trim(), out param))
          return param.ToString();
        else
          throw new Exception(value + " is not an integer value!");
      }

      string config = "";

      if (tbFinalDir.Text != "")
        config = String.Concat(config, "-d ", tbFinalDir.Text.Trim());

      if (tbTempDir.Text != "")
        config = String.Concat(config, " -t ", tbTempDir.Text.Trim());

      if (tbTemp2Dir.Text != "")
        config = String.Concat(config, " -2 ", tbTemp2Dir.Text.Trim());

      if (swAlternateTemps.Switched)
        config = String.Concat(config, " -G ");

      if (swWait4Copy.Switched)
        config = String.Concat(config, " -w ");

      string plotsValue = cbPlots.Text.Trim();

      if (plotsValue != "")
      {
        if (plotsValue == "Maximum")
          config = String.Concat(config, " -n ", "-1");
        else
          config = String.Concat(config, " -n ", GetIntParam(plotsValue));
      }

      if (numThreads.Value > 0)
        config = String.Concat(config, " -r ", numThreads.Value.ToString());

      if (numThreadX.Value > 0)
        config = String.Concat(config, " -K ", numThreadX.Value.ToString());

      if (numBuckets.Value > 0)
      {
        config = String.Concat(config, " -u ", numBuckets.Value.ToString());
        config = String.Concat(config, " -v ", numBuckets34.Value.ToString());
      }

      if (tbPoolKey.Text.Trim() != "")
        config = String.Concat(config, " -p ", tbPoolKey.Text.Trim());

      if (tbFarmerKey.Text.Trim() != "")
        config = String.Concat(config, " -f ", tbFarmerKey.Text.Trim());
      
      if (tbContractKey.Text.Trim() != "")
        config = String.Concat(config, " -c ", tbContractKey.Text.Trim());

      if (swLogActive.Switched)
      {
        if (tbLogPath.Text == "")
          throw new Exception("Choose a path for logging!");

        if (cmode == ConfigMode.Save)
          config = String.Concat(config, " -l ", tbLogPath.Text.Trim());

        if (cmode == ConfigMode.Execute)
          config = String.Concat(config, " | tee ", tbLogPath.Text.Trim(),
            "\\", DateTime.Today.ToShortDateString(), "_", DateTime.Now.ToShortTimeString(), ".log");
      }

      return config;
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
#if DEBUG
      MessageBox.Show(GetConfig(ConfigMode.Save));
#else
      tbProcOutput.Text = "";

      string fileChiaPlotter = Directory.GetCurrentDirectory() + "\\chia_plot.exe";
       
      if (!File.Exists(fileChiaPlotter))
          throw new Exception("\"chia_plot.exe\" exists in the working directory");

      proc = new Process
      {
        StartInfo = new ProcessStartInfo
        {
          FileName = fileChiaPlotter,
          Arguments = GetConfig(ConfigMode.Execute),
          UseShellExecute = false,
          RedirectStandardOutput = true,
          CreateNoWindow = true
        }
      };

      proc.Start();

      while(!proc.StandardOutput.EndOfStream)
      {
        tbProcOutput.Text = String.Concat(tbProcOutput.Text, proc.StandardOutput.ReadLine(), Environment.NewLine);
      }
#endif
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
      if (proc != null)
        proc.Close();
    }

    private void btnAbout_Click(object sender, EventArgs e)
    {
      FormAbout formAbout = new FormAbout();
      formAbout.ShowDialog();
    }
  }
}
