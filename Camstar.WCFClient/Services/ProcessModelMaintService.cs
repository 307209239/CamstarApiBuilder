// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProcessModelMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ProcessModelMaintService : ProcessObjectMaintBase
  {
    public ProcessModelMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IProcessModelMaintService), userProfile);
    }

    public ResultStatus Delete(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      result = (ProcessModelMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) processModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelMaintService) this._Channel).Delete(this._UserProfile, processModelMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelMaintMethod(processModelMaint, ProcessModelMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) processModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ProcessModelMaint) null, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus Delete(ProcessModelMaint processModelMaint)
    {
      return this.Delete(processModelMaint, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus Delete(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      return this.Delete(processModelMaint, (ProcessModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      result = (ProcessModelMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) processModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelMaintService) this._Channel).Freeze(this._UserProfile, processModelMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelMaintMethod(processModelMaint, ProcessModelMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) processModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ProcessModelMaint) null, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus Freeze(ProcessModelMaint processModelMaint)
    {
      return this.Freeze(processModelMaint, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus Freeze(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      return this.Freeze(processModelMaint, (ProcessModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      result = (ProcessModelMaint_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) processModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelMaintService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, processModelMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelMaintMethod(processModelMaint, ProcessModelMaintMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) processModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((ProcessModelMaint) null, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(ProcessModelMaint processModelMaint)
    {
      return this.GetApprovalSheetTemplate(processModelMaint, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      return this.GetApprovalSheetTemplate(processModelMaint, (ProcessModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      result = (ProcessModelMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) processModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelMaintService) this._Channel).GetWIPMsgs(this._UserProfile, processModelMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelMaintMethod(processModelMaint, ProcessModelMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) processModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ProcessModelMaint) null, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ProcessModelMaint processModelMaint)
    {
      return this.GetWIPMsgs(processModelMaint, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      return this.GetWIPMsgs(processModelMaint, (ProcessModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      result = (ProcessModelMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) processModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelMaintService) this._Channel).Load(this._UserProfile, processModelMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelMaintMethod(processModelMaint, ProcessModelMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) processModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ProcessModelMaint) null, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus Load(ProcessModelMaint processModelMaint)
    {
      return this.Load(processModelMaint, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus Load(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      return this.Load(processModelMaint, (ProcessModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadBusinessRules(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      result = (ProcessModelMaint_Result) null;
      this.OnBeforeCall(nameof (LoadBusinessRules), (DCObject) processModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelMaintService) this._Channel).LoadBusinessRules(this._UserProfile, processModelMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelMaintMethod(processModelMaint, ProcessModelMaintMethods.LoadBusinessRules, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadBusinessRules), res, (DCObject) processModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadBusinessRules()
    {
      return this.LoadBusinessRules((ProcessModelMaint) null, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(ProcessModelMaint processModelMaint)
    {
      return this.LoadBusinessRules(processModelMaint, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      return this.LoadBusinessRules(processModelMaint, (ProcessModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadChecklistTemplate(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      result = (ProcessModelMaint_Result) null;
      this.OnBeforeCall(nameof (LoadChecklistTemplate), (DCObject) processModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelMaintService) this._Channel).LoadChecklistTemplate(this._UserProfile, processModelMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelMaintMethod(processModelMaint, ProcessModelMaintMethods.LoadChecklistTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadChecklistTemplate), res, (DCObject) processModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadChecklistTemplate()
    {
      return this.LoadChecklistTemplate((ProcessModelMaint) null, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(ProcessModelMaint processModelMaint)
    {
      return this.LoadChecklistTemplate(processModelMaint, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      return this.LoadChecklistTemplate(processModelMaint, (ProcessModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_LoadESigDetails_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      result = (ProcessModelMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) processModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelMaintService) this._Channel).LoadESigDetails(this._UserProfile, processModelMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelMaintMethod(processModelMaint, ProcessModelMaintMethods.LoadESigDetails, (ProcessModelMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) processModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ProcessModelMaint) null, (ProcessModelMaint_LoadESigDetails_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ProcessModelMaint processModelMaint)
    {
      return this.LoadESigDetails(processModelMaint, (ProcessModelMaint_LoadESigDetails_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      return this.LoadESigDetails(processModelMaint, (ProcessModelMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus LoadTemplate(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      result = (ProcessModelMaint_Result) null;
      this.OnBeforeCall(nameof (LoadTemplate), (DCObject) processModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelMaintService) this._Channel).LoadTemplate(this._UserProfile, processModelMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelMaintMethod(processModelMaint, ProcessModelMaintMethods.LoadTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadTemplate), res, (DCObject) processModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadTemplate()
    {
      return this.LoadTemplate((ProcessModelMaint) null, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus LoadTemplate(ProcessModelMaint processModelMaint)
    {
      return this.LoadTemplate(processModelMaint, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus LoadTemplate(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      return this.LoadTemplate(processModelMaint, (ProcessModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      result = (ProcessModelMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) processModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelMaintService) this._Channel).New(this._UserProfile, processModelMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelMaintMethod(processModelMaint, ProcessModelMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) processModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ProcessModelMaint) null, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus New(ProcessModelMaint processModelMaint)
    {
      return this.New(processModelMaint, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus New(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      return this.New(processModelMaint, (ProcessModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      result = (ProcessModelMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) processModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelMaintService) this._Channel).NewCopy(this._UserProfile, processModelMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelMaintMethod(processModelMaint, ProcessModelMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) processModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ProcessModelMaint) null, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus NewCopy(ProcessModelMaint processModelMaint)
    {
      return this.NewCopy(processModelMaint, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus NewCopy(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      return this.NewCopy(processModelMaint, (ProcessModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus PreviewChecklist(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      result = (ProcessModelMaint_Result) null;
      this.OnBeforeCall(nameof (PreviewChecklist), (DCObject) processModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelMaintService) this._Channel).PreviewChecklist(this._UserProfile, processModelMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelMaintMethod(processModelMaint, ProcessModelMaintMethods.PreviewChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreviewChecklist), res, (DCObject) processModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreviewChecklist()
    {
      return this.PreviewChecklist((ProcessModelMaint) null, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus PreviewChecklist(ProcessModelMaint processModelMaint)
    {
      return this.PreviewChecklist(processModelMaint, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      return this.PreviewChecklist(processModelMaint, (ProcessModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      result = (ProcessModelMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) processModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelMaintService) this._Channel).SaveAs(this._UserProfile, processModelMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelMaintMethod(processModelMaint, ProcessModelMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) processModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ProcessModelMaint) null, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus SaveAs(ProcessModelMaint processModelMaint)
    {
      return this.SaveAs(processModelMaint, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus SaveAs(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      return this.SaveAs(processModelMaint, (ProcessModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      result = (ProcessModelMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) processModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelMaintService) this._Channel).UnFreeze(this._UserProfile, processModelMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelMaintMethod(processModelMaint, ProcessModelMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) processModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ProcessModelMaint) null, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus UnFreeze(ProcessModelMaint processModelMaint)
    {
      return this.UnFreeze(processModelMaint, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      return this.UnFreeze(processModelMaint, (ProcessModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus ValidateStageOnAdd(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      result = (ProcessModelMaint_Result) null;
      this.OnBeforeCall(nameof (ValidateStageOnAdd), (DCObject) processModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelMaintService) this._Channel).ValidateStageOnAdd(this._UserProfile, processModelMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelMaintMethod(processModelMaint, ProcessModelMaintMethods.ValidateStageOnAdd, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateStageOnAdd), res, (DCObject) processModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateStageOnAdd()
    {
      return this.ValidateStageOnAdd((ProcessModelMaint) null, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus ValidateStageOnAdd(ProcessModelMaint processModelMaint)
    {
      return this.ValidateStageOnAdd(processModelMaint, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus ValidateStageOnAdd(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      return this.ValidateStageOnAdd(processModelMaint, (ProcessModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus ValidateStageOnDelete(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      result = (ProcessModelMaint_Result) null;
      this.OnBeforeCall(nameof (ValidateStageOnDelete), (DCObject) processModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelMaintService) this._Channel).ValidateStageOnDelete(this._UserProfile, processModelMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelMaintMethod(processModelMaint, ProcessModelMaintMethods.ValidateStageOnDelete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateStageOnDelete), res, (DCObject) processModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateStageOnDelete()
    {
      return this.ValidateStageOnDelete((ProcessModelMaint) null, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus ValidateStageOnDelete(ProcessModelMaint processModelMaint)
    {
      return this.ValidateStageOnDelete(processModelMaint, (ProcessModelMaint_Parameters) null, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus ValidateStageOnDelete(
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      return this.ValidateStageOnDelete(processModelMaint, (ProcessModelMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetApprovalSheetTemplate(
      DCObject processModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelMaint_Result result1;
        ResultStatus approvalSheetTemplate = this.GetApprovalSheetTemplate((ProcessModelMaint) processModelMaint, (ProcessModelMaint_Parameters) parameters, (ProcessModelMaint_Request) request, out result1);
        result = (Result) result1;
        return approvalSheetTemplate;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadBusinessRules(
      DCObject processModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelMaint_Result result1;
        ResultStatus resultStatus = this.LoadBusinessRules((ProcessModelMaint) processModelMaint, (ProcessModelMaint_Parameters) parameters, (ProcessModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadChecklistTemplate(
      DCObject processModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelMaint_Result result1;
        ResultStatus resultStatus = this.LoadChecklistTemplate((ProcessModelMaint) processModelMaint, (ProcessModelMaint_Parameters) parameters, (ProcessModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadTemplate(
      DCObject processModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelMaint_Result result1;
        ResultStatus resultStatus = this.LoadTemplate((ProcessModelMaint) processModelMaint, (ProcessModelMaint_Parameters) parameters, (ProcessModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnPreviewChecklist(
      DCObject processModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelMaint_Result result1;
        ResultStatus resultStatus = this.PreviewChecklist((ProcessModelMaint) processModelMaint, (ProcessModelMaint_Parameters) parameters, (ProcessModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject processModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ProcessModelMaint) processModelMaint, (ProcessModelMaint_Parameters) parameters, (ProcessModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject processModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ProcessModelMaint) processModelMaint, (ProcessModelMaint_Parameters) parameters, (ProcessModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject processModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ProcessModelMaint) processModelMaint, (ProcessModelMaint_LoadESigDetails_Parameters) parameters, (ProcessModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject processModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelMaint_Result result1;
        ResultStatus resultStatus = this.New((ProcessModelMaint) processModelMaint, (ProcessModelMaint_Parameters) parameters, (ProcessModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject processModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ProcessModelMaint) processModelMaint, (ProcessModelMaint_Parameters) parameters, (ProcessModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject processModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ProcessModelMaint) processModelMaint, (ProcessModelMaint_Parameters) parameters, (ProcessModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject processModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ProcessModelMaint) processModelMaint, (ProcessModelMaint_Parameters) parameters, (ProcessModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject processModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelMaint_Result result1;
        ResultStatus resultStatus = this.Load((ProcessModelMaint) processModelMaint, (ProcessModelMaint_Parameters) parameters, (ProcessModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject processModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ProcessModelMaint) processModelMaint, (ProcessModelMaint_Parameters) parameters, (ProcessModelMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      result = (ProcessModelMaint_Result) null;
      try
      {
        ProcessModelMaintMethod[] methods = new ProcessModelMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IProcessModelMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ProcessModelMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ProcessModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProcessModelMaint cdo,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      result = (ProcessModelMaint_Result) null;
      try
      {
        return ((IProcessModelMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ProcessModelMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ProcessModelMaint) cdo, (ProcessModelMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      return this.GetEnvironment((ProcessModelMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ProcessModelMaint cdo,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      result = (ProcessModelMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ProcessModelMaintMethod(cdo, ProcessModelMaintMethods.ExecuteTransaction, (ProcessModelMaint_Parameters) null));
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
        ProcessModelMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ProcessModelMaint) cdo, (ProcessModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ProcessModelMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ProcessModelMaint_Request) null, out ProcessModelMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result)
    {
      return this.ExecuteTransaction((ProcessModelMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ProcessModelMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ProcessModelMaintMethod(cdo, ProcessModelMaintMethods.AddDataTransaction, (ProcessModelMaint_Parameters) null));
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
        return this.AddDataTransaction((ProcessModelMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
