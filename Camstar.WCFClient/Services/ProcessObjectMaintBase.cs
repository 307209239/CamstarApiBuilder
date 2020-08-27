// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProcessObjectMaintBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;

namespace Camstar.WCF.Services
{
  public class ProcessObjectMaintBase : SubentityMaintenanceBase, IProcessObjectMaintBase
  {
    protected virtual ResultStatus OnGetApprovalSheetTemplate(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("GetApprovalSheetTemplate");
    }

    ResultStatus IProcessObjectMaintBase.GetApprovalSheetTemplate(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnGetApprovalSheetTemplate(processObjectMaint, parameters, request, out result);
    }

    ResultStatus IProcessObjectMaintBase.GetApprovalSheetTemplate()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectMaintBase\u002EGetApprovalSheetTemplate((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IProcessObjectMaintBase.GetApprovalSheetTemplate(
      DCObject processObjectMaint)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectMaintBase\u002EGetApprovalSheetTemplate(processObjectMaint, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IProcessObjectMaintBase.GetApprovalSheetTemplate(
      DCObject processObjectMaint,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectMaintBase\u002EGetApprovalSheetTemplate(processObjectMaint, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnLoadBusinessRules(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("LoadBusinessRules");
    }

    ResultStatus IProcessObjectMaintBase.LoadBusinessRules(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnLoadBusinessRules(processObjectMaint, parameters, request, out result);
    }

    ResultStatus IProcessObjectMaintBase.LoadBusinessRules()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectMaintBase\u002ELoadBusinessRules((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IProcessObjectMaintBase.LoadBusinessRules(
      DCObject processObjectMaint)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectMaintBase\u002ELoadBusinessRules(processObjectMaint, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IProcessObjectMaintBase.LoadBusinessRules(
      DCObject processObjectMaint,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectMaintBase\u002ELoadBusinessRules(processObjectMaint, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnLoadChecklistTemplate(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("LoadChecklistTemplate");
    }

    ResultStatus IProcessObjectMaintBase.LoadChecklistTemplate(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnLoadChecklistTemplate(processObjectMaint, parameters, request, out result);
    }

    ResultStatus IProcessObjectMaintBase.LoadChecklistTemplate()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectMaintBase\u002ELoadChecklistTemplate((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IProcessObjectMaintBase.LoadChecklistTemplate(
      DCObject processObjectMaint)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectMaintBase\u002ELoadChecklistTemplate(processObjectMaint, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IProcessObjectMaintBase.LoadChecklistTemplate(
      DCObject processObjectMaint,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectMaintBase\u002ELoadChecklistTemplate(processObjectMaint, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnLoadTemplate(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("LoadTemplate");
    }

    ResultStatus IProcessObjectMaintBase.LoadTemplate(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnLoadTemplate(processObjectMaint, parameters, request, out result);
    }

    ResultStatus IProcessObjectMaintBase.LoadTemplate()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectMaintBase\u002ELoadTemplate((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IProcessObjectMaintBase.LoadTemplate(
      DCObject processObjectMaint)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectMaintBase\u002ELoadTemplate(processObjectMaint, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IProcessObjectMaintBase.LoadTemplate(
      DCObject processObjectMaint,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectMaintBase\u002ELoadTemplate(processObjectMaint, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnPreviewChecklist(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("PreviewChecklist");
    }

    ResultStatus IProcessObjectMaintBase.PreviewChecklist(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnPreviewChecklist(processObjectMaint, parameters, request, out result);
    }

    ResultStatus IProcessObjectMaintBase.PreviewChecklist()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectMaintBase\u002EPreviewChecklist((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IProcessObjectMaintBase.PreviewChecklist(
      DCObject processObjectMaint)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectMaintBase\u002EPreviewChecklist(processObjectMaint, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IProcessObjectMaintBase.PreviewChecklist(
      DCObject processObjectMaint,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectMaintBase\u002EPreviewChecklist(processObjectMaint, (Parameters) null, request, out result);
    }
  }
}
