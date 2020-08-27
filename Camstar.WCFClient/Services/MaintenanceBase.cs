// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MaintenanceBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;

namespace Camstar.WCF.Services
{
  public class MaintenanceBase : UpdateBase, IMaintenanceBase
  {
    protected virtual ResultStatus OnDelete(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("Delete");
    }

    ResultStatus IMaintenanceBase.Delete(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnDelete(maintenance, parameters, request, out result);
    }

    ResultStatus IMaintenanceBase.Delete()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002EDelete((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IMaintenanceBase.Delete(DCObject maintenance)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002EDelete(maintenance, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IMaintenanceBase.Delete(
      DCObject maintenance,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002EDelete(maintenance, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnFreeze(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("Freeze");
    }

    ResultStatus IMaintenanceBase.Freeze(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnFreeze(maintenance, parameters, request, out result);
    }

    ResultStatus IMaintenanceBase.Freeze()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002EFreeze((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IMaintenanceBase.Freeze(DCObject maintenance)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002EFreeze(maintenance, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IMaintenanceBase.Freeze(
      DCObject maintenance,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002EFreeze(maintenance, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnLoadESigDetails(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("LoadESigDetails");
    }

    ResultStatus IMaintenanceBase.LoadESigDetails(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnLoadESigDetails(maintenance, parameters, request, out result);
    }

    ResultStatus IMaintenanceBase.LoadESigDetails()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002ELoadESigDetails((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IMaintenanceBase.LoadESigDetails(DCObject maintenance)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002ELoadESigDetails(maintenance, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IMaintenanceBase.LoadESigDetails(
      DCObject maintenance,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002ELoadESigDetails(maintenance, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnNew(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("New");
    }

    ResultStatus IMaintenanceBase.New(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnNew(maintenance, parameters, request, out result);
    }

    ResultStatus IMaintenanceBase.New()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002ENew((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IMaintenanceBase.New(DCObject maintenance)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002ENew(maintenance, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IMaintenanceBase.New(
      DCObject maintenance,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002ENew(maintenance, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnNewCopy(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("NewCopy");
    }

    ResultStatus IMaintenanceBase.NewCopy(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnNewCopy(maintenance, parameters, request, out result);
    }

    ResultStatus IMaintenanceBase.NewCopy()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002ENewCopy((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IMaintenanceBase.NewCopy(DCObject maintenance)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002ENewCopy(maintenance, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IMaintenanceBase.NewCopy(
      DCObject maintenance,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002ENewCopy(maintenance, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnSaveAs(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("SaveAs");
    }

    ResultStatus IMaintenanceBase.SaveAs(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnSaveAs(maintenance, parameters, request, out result);
    }

    ResultStatus IMaintenanceBase.SaveAs()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002ESaveAs((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IMaintenanceBase.SaveAs(DCObject maintenance)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002ESaveAs(maintenance, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IMaintenanceBase.SaveAs(
      DCObject maintenance,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002ESaveAs(maintenance, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnUnFreeze(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("UnFreeze");
    }

    ResultStatus IMaintenanceBase.UnFreeze(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnUnFreeze(maintenance, parameters, request, out result);
    }

    ResultStatus IMaintenanceBase.UnFreeze()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002EUnFreeze((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IMaintenanceBase.UnFreeze(DCObject maintenance)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002EUnFreeze(maintenance, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IMaintenanceBase.UnFreeze(
      DCObject maintenance,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIMaintenanceBase\u002EUnFreeze(maintenance, (Parameters) null, request, out result);
    }
  }
}
