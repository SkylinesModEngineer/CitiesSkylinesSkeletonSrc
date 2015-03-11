// ------------------------------------------------------------------------------------------------------
//  ChirpLog: Chirp log represents a single log made using DebugChirp. It's purpose is simply as a
//    storage class to be contained in and used by the DebugChirp class
//  Written By: Pedro Engana (http://www.pedroengana.com)
// ------------------------------------------------------------------------------------------------------

using System;

namespace ChirpLogger.Internal
{

  public enum ChirpType { Debug, Info, Warning, Error }

  public class Chirp {

    private ChirpType _type;
    private string _message;
    private DateTime _timestamp;

    public Chirp(string message, ChirpType type, DateTime timestamp)
    {
      _message = message;
      _type = type;
      _timestamp = timestamp;
    }

    public string message
    {
      get
      {
        return _message;
      }
    }
    public ChirpType type
    {
      get
      {
        return _type;
      }
    }

    public DateTime timestamp
    {
      get
      {
        return _timestamp;
      }
    }

    public override string ToString()
    {
      return "[" + _timestamp.Hour + ":" + _timestamp.Minute + ":" + _timestamp.Second + ":" + _timestamp.Millisecond + "]" + 
              "[" + StringForLogType() + "]" +
              " " + message;
    }

    private string StringForLogType()
    {
      switch (_type)
        {
          case ChirpType.Debug:
            return "Debug";
          case ChirpType.Info:
            return "Info";
          case ChirpType.Warning:
            return "Warning";
          case ChirpType.Error:
            return "Error";
          default :
            return "INVALID_CHIRP_LOG_TYPE";
        }
    }

  }

}