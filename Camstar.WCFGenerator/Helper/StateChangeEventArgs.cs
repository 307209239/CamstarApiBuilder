// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.StateChangeEventArgs
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using System;

namespace Camstar.WCF.Generator.Helper
{
  public class StateChangeEventArgs : EventArgs
  {
    private GeneratorStateType generatorState;
    private int totalPercent;
    private int percent;
    private string processName;
    private string processItemName;
    private TimeSpan timeRemaining;

    public GeneratorStateType GeneratorState
    {
      get
      {
        return this.generatorState;
      }
    }

    public int TotalPercent
    {
      get
      {
        return this.totalPercent;
      }
    }

    public int Percent
    {
      get
      {
        return this.percent;
      }
    }

    public string ProcessName
    {
      get
      {
        return this.processName;
      }
    }

    public string ProcessItemName
    {
      get
      {
        return this.processItemName;
      }
    }

    public TimeSpan TimeRemaining
    {
      get
      {
        return this.timeRemaining;
      }
    }

    internal StateChangeEventArgs(
      GeneratorStateType generatorState,
      int totalPercent,
      int percent,
      string processName,
      string processItemName,
      TimeSpan timeRemaining)
    {
      this.generatorState = generatorState;
      this.totalPercent = totalPercent;
      this.percent = percent;
      this.processName = processName;
      this.processItemName = processItemName;
      this.timeRemaining = timeRemaining;
    }

    internal StateChangeEventArgs(GeneratorStateType generatorState)
    {
      this.generatorState = generatorState;
      this.totalPercent = 0;
      this.percent = 0;
      this.processName = string.Empty;
      this.processItemName = string.Empty;
      this.timeRemaining = TimeSpan.MinValue;
    }
  }
}
