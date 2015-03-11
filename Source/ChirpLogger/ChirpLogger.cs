// ------------------------------------------------------------------------------------------------------
//  DebugChirp: Singleton class and public API to the debug logging tool Debug Chirp
//      This tool is able to log and store debug messages, errors, warnings and info's to later flush
//      to a file, or present through an in-game UI.
//      The purpose of this tool is to allow easier debug logging facilities to Cities Skylines modders
//  Written By: Pedro Engana (http://www.pedroengana.com)
// ------------------------------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

using ChirpLogger.Internal;


namespace ChirpLogger
{
  public class ChirpLog
  {
    private const string _c_dump_folder_ = "_DebugChirpLogs/Skeleton_v1.0";
    private const string _c_debug_filename_ = "DEBUG";
    private const string _c_info_filename_ = "INFO";
    private const string _c_warning_filename_ = "WARNING";
    private const string _c_error_filename_ = "ERROR";

    private static ChirpLog _instance;

    private List<Chirp> _logList;

    /// <summary>
    /// Singleton access property
    /// </summary>
    public static ChirpLog instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new ChirpLog();
        }
        return _instance;
      }
    }

    private ChirpLog() 
    {
      _logList = new List<Chirp>();
    }

    #region public API

    public static void Debug(string log)
    {
      instance.PrivateDebug(log);
    }
    public static void Info(string inf)
    {
      instance.PrivateInfo(inf);
    }
    public static void Warning(string war)
    {
      instance.PrivateWarning(war);
    }
    public static void Error(string err)
    {
      instance.PrivateError(err);
    }

    public static void Flush()
    {
      instance.PrivateDumpToFiles();
    }

    #endregion

    #region Private implementation of log methods
    private void PrivateDebug(string log)
    {
      _logList.Add(new Chirp(log, ChirpType.Debug, DateTime.Now));
    }
    private void PrivateInfo(string inf)
    {
      _logList.Add(new Chirp(inf, ChirpType.Info, DateTime.Now));
    }
    private void PrivateWarning(string war)
    {
      _logList.Add(new Chirp(war, ChirpType.Warning, DateTime.Now));
    }
    private void PrivateError(string err)
    {
      _logList.Add(new Chirp(err, ChirpType.Error, DateTime.Now));
    }
    private void PrivateDumpToFiles()
    {
      string logOutput = "";
      string infoOutput = "";
      string warningOutput = "";
      string errorOutput = "";

      foreach(Chirp chirp in _logList)
      {
        switch (chirp.type)
        {
          case ChirpType.Debug:
            logOutput += chirp.ToString() + "\n";
            break;
          case ChirpType.Info:
            infoOutput += chirp.ToString() + "\n";
            break;
          case ChirpType.Warning:
            warningOutput += chirp.ToString() + "\n";
            break;
          case ChirpType.Error:
            errorOutput += chirp.ToString() + "\n";
            break;
        }
      }

      if (!System.IO.Directory.Exists(_c_dump_folder_))
        System.IO.Directory.CreateDirectory(_c_dump_folder_);

      using (StreamWriter sw = new StreamWriter(File.Create(_c_dump_folder_ + "/" + FormattedDateTimeNow() + "_" + _c_debug_filename_ + ".txt")))
      {
        sw.Write(logOutput);
      }

      using (StreamWriter sw = new StreamWriter(File.Create(_c_dump_folder_ + "/" + FormattedDateTimeNow() + "_" + _c_info_filename_ + ".txt")))
      {
        sw.Write(infoOutput);
      }

      using (StreamWriter sw = new StreamWriter(File.Create(_c_dump_folder_ + "/" + FormattedDateTimeNow() + "_" + _c_warning_filename_ + ".txt")))
      {
        sw.Write(warningOutput);
      }

      using (StreamWriter sw = new StreamWriter(File.Create(_c_dump_folder_ + "/" + FormattedDateTimeNow() + "_" + _c_error_filename_ + ".txt")))
      {
        sw.Write(errorOutput);
      }

    }

    private string FormattedDateTimeNow()
    {
      DateTime dt = DateTime.Now;
      return dt.Day + "-" + dt.Month + "-" + dt.Year + "_" + dt.Hour + "h" + dt.Minute + "m" + dt.Second + "s";
    }

    #endregion
  }

}