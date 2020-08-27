// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.GeneratingCompletedEventArgs
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using System;

namespace Camstar.WCF.Generator.Helper
{
  public class GeneratingCompletedEventArgs : EventArgs
  {
    private CompleteInformation mCompleteInformation;

    public CompleteInformation CompleteInformation
    {
      get
      {
        return this.mCompleteInformation;
      }
    }

    internal GeneratingCompletedEventArgs(CompleteInformation completeInformation)
    {
      this.mCompleteInformation = completeInformation;
    }
  }
}
