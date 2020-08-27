// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProcessObjectMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ProcessObjectMaintService : SubentityMaintenanceBase
  {
    public ProcessObjectMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IProcessObjectMaintService), userProfile);
    }

    public ResultStatus AddBusinessRule(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (AddBusinessRule), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).AddBusinessRule(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.AddBusinessRule, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddBusinessRule), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddBusinessRule()
    {
      return this.AddBusinessRule((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus AddBusinessRule(ProcessObjectMaint processObjectMaint)
    {
      return this.AddBusinessRule(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus AddBusinessRule(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.AddBusinessRule(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus CheckChecklist(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (CheckChecklist), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).CheckChecklist(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.CheckChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CheckChecklist), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CheckChecklist()
    {
      return this.CheckChecklist((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus CheckChecklist(ProcessObjectMaint processObjectMaint)
    {
      return this.CheckChecklist(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus CheckChecklist(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.CheckChecklist(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus CheckDataPointCollection(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (CheckDataPointCollection), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).CheckDataPointCollection(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.CheckDataPointCollection, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CheckDataPointCollection), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CheckDataPointCollection()
    {
      return this.CheckDataPointCollection((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus CheckDataPointCollection(ProcessObjectMaint processObjectMaint)
    {
      return this.CheckDataPointCollection(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus CheckDataPointCollection(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.CheckDataPointCollection(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus CreateStructureChanges(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (CreateStructureChanges), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).CreateStructureChanges(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.CreateStructureChanges, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateStructureChanges), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateStructureChanges()
    {
      return this.CreateStructureChanges((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus CreateStructureChanges(ProcessObjectMaint processObjectMaint)
    {
      return this.CreateStructureChanges(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus CreateStructureChanges(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.CreateStructureChanges(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus Delete(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).Delete(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus Delete(ProcessObjectMaint processObjectMaint)
    {
      return this.Delete(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus Delete(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.Delete(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).Freeze(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus Freeze(ProcessObjectMaint processObjectMaint)
    {
      return this.Freeze(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus Freeze(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.Freeze(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(ProcessObjectMaint processObjectMaint)
    {
      return this.GetApprovalSheetTemplate(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.GetApprovalSheetTemplate(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetOrganization(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (GetOrganization), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).GetOrganization(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.GetOrganization, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetOrganization), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetOrganization()
    {
      return this.GetOrganization((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus GetOrganization(ProcessObjectMaint processObjectMaint)
    {
      return this.GetOrganization(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus GetOrganization(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.GetOrganization(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetParentDataObjectStage(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (GetParentDataObjectStage), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).GetParentDataObjectStage(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.GetParentDataObjectStage, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetParentDataObjectStage), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetParentDataObjectStage()
    {
      return this.GetParentDataObjectStage((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus GetParentDataObjectStage(ProcessObjectMaint processObjectMaint)
    {
      return this.GetParentDataObjectStage(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus GetParentDataObjectStage(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.GetParentDataObjectStage(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetPrerequisites(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (GetPrerequisites), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).GetPrerequisites(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.GetPrerequisites, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetPrerequisites), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetPrerequisites()
    {
      return this.GetPrerequisites((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus GetPrerequisites(ProcessObjectMaint processObjectMaint)
    {
      return this.GetPrerequisites(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus GetPrerequisites(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.GetPrerequisites(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetStructureToChange(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (GetStructureToChange), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).GetStructureToChange(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.GetStructureToChange, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetStructureToChange), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetStructureToChange()
    {
      return this.GetStructureToChange((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus GetStructureToChange(ProcessObjectMaint processObjectMaint)
    {
      return this.GetStructureToChange(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus GetStructureToChange(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.GetStructureToChange(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).GetWIPMsgs(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ProcessObjectMaint processObjectMaint)
    {
      return this.GetWIPMsgs(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.GetWIPMsgs(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).Load(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus Load(ProcessObjectMaint processObjectMaint)
    {
      return this.Load(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus Load(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.Load(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadBusinessRules(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (LoadBusinessRules), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).LoadBusinessRules(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.LoadBusinessRules, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadBusinessRules), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadBusinessRules()
    {
      return this.LoadBusinessRules((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(ProcessObjectMaint processObjectMaint)
    {
      return this.LoadBusinessRules(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.LoadBusinessRules(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadChecklistTemplate(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (LoadChecklistTemplate), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).LoadChecklistTemplate(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.LoadChecklistTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadChecklistTemplate), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadChecklistTemplate()
    {
      return this.LoadChecklistTemplate((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(ProcessObjectMaint processObjectMaint)
    {
      return this.LoadChecklistTemplate(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.LoadChecklistTemplate(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_LoadESigDetails_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).LoadESigDetails(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.LoadESigDetails, (ProcessObjectMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ProcessObjectMaint) null, (ProcessObjectMaint_LoadESigDetails_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ProcessObjectMaint processObjectMaint)
    {
      return this.LoadESigDetails(processObjectMaint, (ProcessObjectMaint_LoadESigDetails_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.LoadESigDetails(processObjectMaint, (ProcessObjectMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus LoadTemplate(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (LoadTemplate), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).LoadTemplate(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.LoadTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadTemplate), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadTemplate()
    {
      return this.LoadTemplate((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus LoadTemplate(ProcessObjectMaint processObjectMaint)
    {
      return this.LoadTemplate(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus LoadTemplate(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.LoadTemplate(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).New(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus New(ProcessObjectMaint processObjectMaint)
    {
      return this.New(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus New(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.New(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).NewCopy(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus NewCopy(ProcessObjectMaint processObjectMaint)
    {
      return this.NewCopy(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus NewCopy(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.NewCopy(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus PostLoad_Sheet(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (PostLoad_Sheet), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).PostLoad_Sheet(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.PostLoad_Sheet, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PostLoad_Sheet), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PostLoad_Sheet()
    {
      return this.PostLoad_Sheet((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus PostLoad_Sheet(ProcessObjectMaint processObjectMaint)
    {
      return this.PostLoad_Sheet(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus PostLoad_Sheet(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.PostLoad_Sheet(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus PreviewChecklist(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (PreviewChecklist), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).PreviewChecklist(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.PreviewChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreviewChecklist), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreviewChecklist()
    {
      return this.PreviewChecklist((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus PreviewChecklist(ProcessObjectMaint processObjectMaint)
    {
      return this.PreviewChecklist(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.PreviewChecklist(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus RefreshApprovalSheet(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (RefreshApprovalSheet), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).RefreshApprovalSheet(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.RefreshApprovalSheet, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (RefreshApprovalSheet), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus RefreshApprovalSheet()
    {
      return this.RefreshApprovalSheet((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus RefreshApprovalSheet(ProcessObjectMaint processObjectMaint)
    {
      return this.RefreshApprovalSheet(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus RefreshApprovalSheet(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.RefreshApprovalSheet(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).SaveAs(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus SaveAs(ProcessObjectMaint processObjectMaint)
    {
      return this.SaveAs(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus SaveAs(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.SaveAs(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).UnFreeze(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus UnFreeze(ProcessObjectMaint processObjectMaint)
    {
      return this.UnFreeze(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.UnFreeze(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus ValidateEmployeeRoleCombination(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_ValidateEmployeeRoleCombination_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (ValidateEmployeeRoleCombination), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).ValidateEmployeeRoleCombination(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.ValidateEmployeeRoleCombination, (ProcessObjectMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateEmployeeRoleCombination), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateEmployeeRoleCombination()
    {
      return this.ValidateEmployeeRoleCombination((ProcessObjectMaint) null, (ProcessObjectMaint_ValidateEmployeeRoleCombination_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus ValidateEmployeeRoleCombination(
      ProcessObjectMaint processObjectMaint)
    {
      return this.ValidateEmployeeRoleCombination(processObjectMaint, (ProcessObjectMaint_ValidateEmployeeRoleCombination_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus ValidateEmployeeRoleCombination(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.ValidateEmployeeRoleCombination(processObjectMaint, (ProcessObjectMaint_ValidateEmployeeRoleCombination_Parameters) null, request, out result);
    }

    public ResultStatus ValidatePermissions(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (ValidatePermissions), (DCObject) processObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).ValidatePermissions(this._UserProfile, processObjectMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(processObjectMaint, ProcessObjectMaintMethods.ValidatePermissions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidatePermissions), res, (DCObject) processObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidatePermissions()
    {
      return this.ValidatePermissions((ProcessObjectMaint) null, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus ValidatePermissions(ProcessObjectMaint processObjectMaint)
    {
      return this.ValidatePermissions(processObjectMaint, (ProcessObjectMaint_Parameters) null, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus ValidatePermissions(
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.ValidatePermissions(processObjectMaint, (ProcessObjectMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ProcessObjectMaint) processObjectMaint, (ProcessObjectMaint_Parameters) parameters, (ProcessObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ProcessObjectMaint) processObjectMaint, (ProcessObjectMaint_Parameters) parameters, (ProcessObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ProcessObjectMaint) processObjectMaint, (ProcessObjectMaint_LoadESigDetails_Parameters) parameters, (ProcessObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectMaint_Result result1;
        ResultStatus resultStatus = this.New((ProcessObjectMaint) processObjectMaint, (ProcessObjectMaint_Parameters) parameters, (ProcessObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ProcessObjectMaint) processObjectMaint, (ProcessObjectMaint_Parameters) parameters, (ProcessObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ProcessObjectMaint) processObjectMaint, (ProcessObjectMaint_Parameters) parameters, (ProcessObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ProcessObjectMaint) processObjectMaint, (ProcessObjectMaint_Parameters) parameters, (ProcessObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectMaint_Result result1;
        ResultStatus resultStatus = this.Load((ProcessObjectMaint) processObjectMaint, (ProcessObjectMaint_Parameters) parameters, (ProcessObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ProcessObjectMaint) processObjectMaint, (ProcessObjectMaint_Parameters) parameters, (ProcessObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      try
      {
        ProcessObjectMaintMethod[] methods = new ProcessObjectMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IProcessObjectMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ProcessObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProcessObjectMaint cdo,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      try
      {
        return ((IProcessObjectMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ProcessObjectMaint) cdo, (ProcessObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.GetEnvironment((ProcessObjectMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ProcessObjectMaint cdo,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      result = (ProcessObjectMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ProcessObjectMaintMethod(cdo, ProcessObjectMaintMethods.ExecuteTransaction, (ProcessObjectMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ProcessObjectMaint) cdo, (ProcessObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ProcessObjectMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ProcessObjectMaint_Request) null, out ProcessObjectMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result)
    {
      return this.ExecuteTransaction((ProcessObjectMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ProcessObjectMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ProcessObjectMaintMethod(cdo, ProcessObjectMaintMethods.AddDataTransaction, (ProcessObjectMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((ProcessObjectMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
