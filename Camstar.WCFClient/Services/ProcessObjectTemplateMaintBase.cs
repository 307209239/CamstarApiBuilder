// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProcessObjectTemplateMaintBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;

namespace Camstar.WCF.Services
{
  public class ProcessObjectTemplateMaintBase : NamedDataObjectMaintBase, IProcessObjectTemplateMaintBase
  {
    protected virtual ResultStatus OnGetApprovalSheetTemplate(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("GetApprovalSheetTemplate");
    }

    ResultStatus IProcessObjectTemplateMaintBase.GetApprovalSheetTemplate(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnGetApprovalSheetTemplate(processObjectTemplateMaint, parameters, request, out result);
    }

    ResultStatus IProcessObjectTemplateMaintBase.GetApprovalSheetTemplate()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectTemplateMaintBase\u002EGetApprovalSheetTemplate((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IProcessObjectTemplateMaintBase.GetApprovalSheetTemplate(
      DCObject processObjectTemplateMaint)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectTemplateMaintBase\u002EGetApprovalSheetTemplate(processObjectTemplateMaint, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IProcessObjectTemplateMaintBase.GetApprovalSheetTemplate(
      DCObject processObjectTemplateMaint,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectTemplateMaintBase\u002EGetApprovalSheetTemplate(processObjectTemplateMaint, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnLoadBusinessRules(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("LoadBusinessRules");
    }

    ResultStatus IProcessObjectTemplateMaintBase.LoadBusinessRules(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnLoadBusinessRules(processObjectTemplateMaint, parameters, request, out result);
    }

    ResultStatus IProcessObjectTemplateMaintBase.LoadBusinessRules()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectTemplateMaintBase\u002ELoadBusinessRules((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IProcessObjectTemplateMaintBase.LoadBusinessRules(
      DCObject processObjectTemplateMaint)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectTemplateMaintBase\u002ELoadBusinessRules(processObjectTemplateMaint, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IProcessObjectTemplateMaintBase.LoadBusinessRules(
      DCObject processObjectTemplateMaint,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectTemplateMaintBase\u002ELoadBusinessRules(processObjectTemplateMaint, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnLoadChecklistTemplate(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("LoadChecklistTemplate");
    }

    ResultStatus IProcessObjectTemplateMaintBase.LoadChecklistTemplate(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnLoadChecklistTemplate(processObjectTemplateMaint, parameters, request, out result);
    }

    ResultStatus IProcessObjectTemplateMaintBase.LoadChecklistTemplate()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectTemplateMaintBase\u002ELoadChecklistTemplate((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IProcessObjectTemplateMaintBase.LoadChecklistTemplate(
      DCObject processObjectTemplateMaint)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectTemplateMaintBase\u002ELoadChecklistTemplate(processObjectTemplateMaint, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IProcessObjectTemplateMaintBase.LoadChecklistTemplate(
      DCObject processObjectTemplateMaint,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectTemplateMaintBase\u002ELoadChecklistTemplate(processObjectTemplateMaint, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnPreviewChecklist(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("PreviewChecklist");
    }

    ResultStatus IProcessObjectTemplateMaintBase.PreviewChecklist(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnPreviewChecklist(processObjectTemplateMaint, parameters, request, out result);
    }

    ResultStatus IProcessObjectTemplateMaintBase.PreviewChecklist()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectTemplateMaintBase\u002EPreviewChecklist((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IProcessObjectTemplateMaintBase.PreviewChecklist(
      DCObject processObjectTemplateMaint)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectTemplateMaintBase\u002EPreviewChecklist(processObjectTemplateMaint, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IProcessObjectTemplateMaintBase.PreviewChecklist(
      DCObject processObjectTemplateMaint,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIProcessObjectTemplateMaintBase\u002EPreviewChecklist(processObjectTemplateMaint, (Parameters) null, request, out result);
    }
  }
}
