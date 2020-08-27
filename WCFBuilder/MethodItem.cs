// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Builder.MethodItem
// Assembly: WCFBuilder, Version=7.8.7004.31024, Culture=neutral, PublicKeyToken=null
// MVID: CD6CE187-0F31-415C-A6CA-288D0368C79C
// Assembly location: E:\WCFServicesGenerator\WCFBuilder.exe

using Camstar.WCF.Generator.Helper;
using System.ComponentModel;

namespace Camstar.WCF.Builder
{
  [DefaultProperty("ExposedState")]
  internal class MethodItem
  {
    private IMethod method;

    [Category("Method")]
    [System.ComponentModel.Description("Method name.")]
    public string Name
    {
      get
      {
        return this.method.Name;
      }
    }

    [Category("Method")]
    [System.ComponentModel.Description("Method description.")]
    public string Description
    {
      get
      {
        return this.method.Description;
      }
    }

    [Category("State")]
    [System.ComponentModel.Description("Method Exposed Type.")]
    public ExposedMethodStateType ExposedState
    {
      get
      {
        return this.method.ExposedState;
      }
      set
      {
        this.method.ExposedState = value;
      }
    }

    [Browsable(false)]
    public IMethod Method
    {
      get
      {
        return this.method;
      }
    }

    public MethodItem(IMethod method)
    {
      this.method = method;
    }
  }
}
