﻿// Decompiled with JetBrains decompiler
// Type: Camstar.Exceptions.ExceptionUtil
// Assembly: Camstar.Exceptions, Version=7.8.7004.31019, Culture=neutral, PublicKeyToken=null
// MVID: DCD1F3EE-20E6-4307-A2E0-3C6DF5B436BE
// Assembly location: E:\WCFServicesGenerator\Camstar.Exceptions.dll

using System.Globalization;
using System.Resources;
using System.Threading;

namespace Camstar.Exceptions
{
  public class ExceptionUtil
  {
    public const string StringResourcesSuffix = ".StringResources";
    public const string IdKeySuffix = "_Id";
    public const string MessageKeySuffix = "_Message";
    public const string ParameterMarker = "%";

    public static string GetStringResourcesBaseName(string callerNamespace)
    {
      if (callerNamespace == null)
        callerNamespace = string.Empty;
      return callerNamespace + ".StringResources";
    }

    public static string GetIdKey(string key)
    {
      if (key == null)
        key = string.Empty;
      return key + "_Id";
    }

    public static string GetMessageKey(string key)
    {
      if (key == null)
        key = string.Empty;
      return key + "_Message";
    }

    public static string GetIdValue(ResourceManager rm, string key)
    {
      return ExceptionUtil.GetResourceString(rm, ExceptionUtil.GetIdKey(key));
    }

    public static string GetMessageValue(ResourceManager rm, string key, string[] parameters)
    {
      string resourceString = ExceptionUtil.GetResourceString(rm, ExceptionUtil.GetMessageKey(key));
      return parameters == null ? resourceString : ExceptionUtil.ParseParameters(resourceString, parameters);
    }

    public static string GetResourceString(ResourceManager rm, string key)
    {
      string str = string.Empty;
      if (rm != null)
      {
        CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
        try
        {
          str = rm.GetString(key, currentCulture);
        }
        catch
        {
        }
      }
      if (str == null || str == string.Empty)
        str = key;
      return str;
    }

    public static string ParseParameters(string message, string[] parameters)
    {
      if (message == null)
        message = string.Empty;
      if (message.Length > 0 && parameters != null)
      {
        for (int lowerBound = parameters.GetLowerBound(0); lowerBound <= parameters.GetUpperBound(0); ++lowerBound)
        {
          string oldValue = "%" + (object) (lowerBound + 1);
          string parameter = parameters[lowerBound];
          message = message.Replace(oldValue, parameter);
        }
      }
      return message;
    }
  }
}
