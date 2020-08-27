// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangeProcessBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;

namespace Camstar.WCF.Services
{
  public class ChangeProcessBase : ProcessObjectTxnBase, IChangeProcessBase
  {
    protected virtual ResultStatus OnDelete(
      DCObject changeProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("Delete");
    }

    ResultStatus IChangeProcessBase.Delete(
      DCObject changeProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnDelete(changeProcess, parameters, request, out result);
    }

    ResultStatus IChangeProcessBase.Delete()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIChangeProcessBase\u002EDelete((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IChangeProcessBase.Delete(DCObject changeProcess)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIChangeProcessBase\u002EDelete(changeProcess, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IChangeProcessBase.Delete(
      DCObject changeProcess,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIChangeProcessBase\u002EDelete(changeProcess, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnGetOrganization(
      DCObject changeProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("GetOrganization");
    }

    ResultStatus IChangeProcessBase.GetOrganization(
      DCObject changeProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnGetOrganization(changeProcess, parameters, request, out result);
    }

    ResultStatus IChangeProcessBase.GetOrganization()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIChangeProcessBase\u002EGetOrganization((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IChangeProcessBase.GetOrganization(
      DCObject changeProcess)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIChangeProcessBase\u002EGetOrganization(changeProcess, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IChangeProcessBase.GetOrganization(
      DCObject changeProcess,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIChangeProcessBase\u002EGetOrganization(changeProcess, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnNew(
      DCObject changeProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("New");
    }

    ResultStatus IChangeProcessBase.New(
      DCObject changeProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnNew(changeProcess, parameters, request, out result);
    }

    ResultStatus IChangeProcessBase.New()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIChangeProcessBase\u002ENew((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IChangeProcessBase.New(DCObject changeProcess)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIChangeProcessBase\u002ENew(changeProcess, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IChangeProcessBase.New(
      DCObject changeProcess,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIChangeProcessBase\u002ENew(changeProcess, (Parameters) null, request, out result);
    }
  }
}
