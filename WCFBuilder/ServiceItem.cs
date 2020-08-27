// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Builder.ServiceItem
// Assembly: WCFBuilder, Version=7.8.7004.31024, Culture=neutral, PublicKeyToken=null
// MVID: CD6CE187-0F31-415C-A6CA-288D0368C79C
// Assembly location: E:\WCFServicesGenerator\WCFBuilder.exe

using Camstar.WCF.Generator.Helper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

namespace Camstar.WCF.Builder
{
  public class ServiceItem
  {
    private IService service;

    [Category("Service")]
    [System.ComponentModel.Description("Service name.")]
    public string Name
    {
      get
      {
        return this.service.Name;
      }
    }

    [Category("Service")]
    [System.ComponentModel.Description("Service description.")]
    public string Description
    {
      get
      {
        return this.service.Description;
      }
    }

    [Category("State")]
    [System.ComponentModel.Description("Method Exposed Type.")]
    public ExposedServiceStateType ExposedState
    {
      get
      {
        return this.service.ExposedState;
      }
      set
      {
        this.service.ExposedState = value;
      }
    }

    [Browsable(false)]
    public IService Service
    {
      get
      {
        return this.service;
      }
    }

    [Category("Service methods")]
    [Editor(typeof (MethodsEditor), typeof (UITypeEditor))]
    [System.ComponentModel.Description("Service methods.")]
    public List<IMethod> MethodCollection
    {
      get
      {
        return this.service.Methods;
      }
    }

    public ServiceItem(IService service)
    {
      this.service = service;
    }
  }
}
