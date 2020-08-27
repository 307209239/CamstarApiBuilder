// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Log
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using Camstar.WCF.Generator.Helper;

namespace Camstar.WCF.Generator
{
  internal class Log
  {
    private static WCFGeneratorException mException;

    public static WCFGeneratorException Exception
    {
      get
      {
        return Log.mException;
      }
    }

    public static void SaveException(System.Exception e)
    {
      if (e is WCFGeneratorException)
        Log.mException = e as WCFGeneratorException;
      else
        Log.mException = new WCFGeneratorException(e);
    }
  }
}
