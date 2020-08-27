// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.CompleteInformation
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using System;

namespace Camstar.WCF.Generator.Helper
{
  public class CompleteInformation
  {
    private WCFGeneratorException mException;
    private bool mIsSuccess;
    private int dCCount;
    private int sCCount;
    private TimeSpan mTotalTime;

    public CompleteInformation SilverlightCompleteInformation { get; set; }

    public int DCCount
    {
      get
      {
        return this.dCCount;
      }
    }

    public int SCCount
    {
      get
      {
        return this.sCCount;
      }
    }

    public TimeSpan TotalElapsedTime
    {
      get
      {
        return this.mTotalTime;
      }
    }

    public bool IsSuccess
    {
      get
      {
        return this.mIsSuccess;
      }
    }

    public WCFGeneratorException Exception
    {
      get
      {
        return this.mException;
      }
    }

    public override string ToString()
    {
      string str;
      if (this.mIsSuccess)
      {
        str = this.dCCount.ToString() + " Data Contracts;\n" + (object) this.sCCount + " Service Contracts;\n" + (object) TimeSpan.FromSeconds((double) (int) this.TotalElapsedTime.TotalSeconds) + " Generation Time.\n";
        if (this.SilverlightCompleteInformation != null)
          str = str + "Silverlight:\n" + (object) this.SilverlightCompleteInformation.DCCount + " Data Contracts;\n" + (object) this.SilverlightCompleteInformation.SCCount + " Service Contracts;\n" + (object) TimeSpan.FromSeconds((double) (int) this.SilverlightCompleteInformation.TotalElapsedTime.TotalSeconds) + " Generation Time.\n";
      }
      else
        str = this.mException.ToString();
      return str;
    }

    internal CompleteInformation(int dCCount, int sCCount, TimeSpan generationTime)
    {
      this.mIsSuccess = true;
      this.mException = (WCFGeneratorException) null;
      this.dCCount = dCCount;
      this.sCCount = sCCount;
      this.mTotalTime = generationTime;
    }

    internal CompleteInformation(WCFGeneratorException exception)
    {
      this.mIsSuccess = false;
      this.mException = exception;
      this.dCCount = 0;
      this.sCCount = 0;
      this.mTotalTime = TimeSpan.MinValue;
    }
  }
}
