// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.Method
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using System.Collections.Generic;

namespace Camstar.WCF.Generator.Helper
{
  internal class Method : IMethod
  {
    private List<Parameter> mParameters = new List<Parameter>();
    private string mDescription;
    private string mName;
    private bool mIsInherited;
    private ExposedMethodStateType mExposedState;

    public Method(string name, ExposedMethodStateType exposedState, bool isInherited)
    {
      this.mName = name;
      this.mExposedState = exposedState;
      this.mDescription = string.Empty;
      this.mIsInherited = isInherited;
    }

    public string Name
    {
      get
      {
        return this.mName;
      }
    }

    public string Description
    {
      get
      {
        return this.mDescription;
      }
    }

    public bool HasParameters
    {
      get
      {
        return (uint) this.mParameters.Count > 0U;
      }
    }

    public bool IsInherited
    {
      get
      {
        return this.mIsInherited;
      }
      set
      {
        this.mIsInherited = value;
      }
    }

    public List<Parameter> Parameters
    {
      get
      {
        return this.mParameters;
      }
    }

    public ExposedMethodStateType ExposedState
    {
      get
      {
        return this.mExposedState;
      }
      set
      {
        this.mExposedState = value;
      }
    }

    public void SetState(ExposedMethodStateType exposedState)
    {
      this.mExposedState = exposedState;
    }
  }
}
