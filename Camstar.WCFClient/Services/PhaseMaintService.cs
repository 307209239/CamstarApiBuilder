// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PhaseMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PhaseMaintService : ProcessObjectMaintBase
  {
    public PhaseMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPhaseMaintService), userProfile);
    }

    public ResultStatus Delete(
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      result = (PhaseMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) phaseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseMaintService) this._Channel).Delete(this._UserProfile, phaseMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseMaintMethod(phaseMaint, PhaseMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) phaseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((PhaseMaint) null, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus Delete(PhaseMaint phaseMaint)
    {
      return this.Delete(phaseMaint, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus Delete(
      PhaseMaint phaseMaint,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      return this.Delete(phaseMaint, (PhaseMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      result = (PhaseMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) phaseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseMaintService) this._Channel).Freeze(this._UserProfile, phaseMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseMaintMethod(phaseMaint, PhaseMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) phaseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((PhaseMaint) null, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus Freeze(PhaseMaint phaseMaint)
    {
      return this.Freeze(phaseMaint, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus Freeze(
      PhaseMaint phaseMaint,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      return this.Freeze(phaseMaint, (PhaseMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      result = (PhaseMaint_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) phaseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseMaintService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, phaseMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseMaintMethod(phaseMaint, PhaseMaintMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) phaseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((PhaseMaint) null, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(PhaseMaint phaseMaint)
    {
      return this.GetApprovalSheetTemplate(phaseMaint, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PhaseMaint phaseMaint,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      return this.GetApprovalSheetTemplate(phaseMaint, (PhaseMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      result = (PhaseMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) phaseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseMaintService) this._Channel).GetWIPMsgs(this._UserProfile, phaseMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseMaintMethod(phaseMaint, PhaseMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) phaseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PhaseMaint) null, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(PhaseMaint phaseMaint)
    {
      return this.GetWIPMsgs(phaseMaint, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PhaseMaint phaseMaint,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      return this.GetWIPMsgs(phaseMaint, (PhaseMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      result = (PhaseMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) phaseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseMaintService) this._Channel).Load(this._UserProfile, phaseMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseMaintMethod(phaseMaint, PhaseMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) phaseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PhaseMaint) null, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus Load(PhaseMaint phaseMaint)
    {
      return this.Load(phaseMaint, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus Load(
      PhaseMaint phaseMaint,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      return this.Load(phaseMaint, (PhaseMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadBusinessRules(
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      result = (PhaseMaint_Result) null;
      this.OnBeforeCall(nameof (LoadBusinessRules), (DCObject) phaseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseMaintService) this._Channel).LoadBusinessRules(this._UserProfile, phaseMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseMaintMethod(phaseMaint, PhaseMaintMethods.LoadBusinessRules, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadBusinessRules), res, (DCObject) phaseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadBusinessRules()
    {
      return this.LoadBusinessRules((PhaseMaint) null, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(PhaseMaint phaseMaint)
    {
      return this.LoadBusinessRules(phaseMaint, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      PhaseMaint phaseMaint,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      return this.LoadBusinessRules(phaseMaint, (PhaseMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadChecklistTemplate(
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      result = (PhaseMaint_Result) null;
      this.OnBeforeCall(nameof (LoadChecklistTemplate), (DCObject) phaseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseMaintService) this._Channel).LoadChecklistTemplate(this._UserProfile, phaseMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseMaintMethod(phaseMaint, PhaseMaintMethods.LoadChecklistTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadChecklistTemplate), res, (DCObject) phaseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadChecklistTemplate()
    {
      return this.LoadChecklistTemplate((PhaseMaint) null, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(PhaseMaint phaseMaint)
    {
      return this.LoadChecklistTemplate(phaseMaint, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      PhaseMaint phaseMaint,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      return this.LoadChecklistTemplate(phaseMaint, (PhaseMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PhaseMaint phaseMaint,
      PhaseMaint_LoadESigDetails_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      result = (PhaseMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) phaseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseMaintService) this._Channel).LoadESigDetails(this._UserProfile, phaseMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseMaintMethod(phaseMaint, PhaseMaintMethods.LoadESigDetails, (PhaseMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) phaseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PhaseMaint) null, (PhaseMaint_LoadESigDetails_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus LoadESigDetails(PhaseMaint phaseMaint)
    {
      return this.LoadESigDetails(phaseMaint, (PhaseMaint_LoadESigDetails_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PhaseMaint phaseMaint,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      return this.LoadESigDetails(phaseMaint, (PhaseMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus LoadTemplate(
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      result = (PhaseMaint_Result) null;
      this.OnBeforeCall(nameof (LoadTemplate), (DCObject) phaseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseMaintService) this._Channel).LoadTemplate(this._UserProfile, phaseMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseMaintMethod(phaseMaint, PhaseMaintMethods.LoadTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadTemplate), res, (DCObject) phaseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadTemplate()
    {
      return this.LoadTemplate((PhaseMaint) null, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus LoadTemplate(PhaseMaint phaseMaint)
    {
      return this.LoadTemplate(phaseMaint, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus LoadTemplate(
      PhaseMaint phaseMaint,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      return this.LoadTemplate(phaseMaint, (PhaseMaint_Parameters) null, request, out result);
    }

    public ResultStatus New(
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      result = (PhaseMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) phaseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseMaintService) this._Channel).New(this._UserProfile, phaseMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseMaintMethod(phaseMaint, PhaseMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) phaseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((PhaseMaint) null, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus New(PhaseMaint phaseMaint)
    {
      return this.New(phaseMaint, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus New(
      PhaseMaint phaseMaint,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      return this.New(phaseMaint, (PhaseMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      result = (PhaseMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) phaseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseMaintService) this._Channel).NewCopy(this._UserProfile, phaseMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseMaintMethod(phaseMaint, PhaseMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) phaseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((PhaseMaint) null, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus NewCopy(PhaseMaint phaseMaint)
    {
      return this.NewCopy(phaseMaint, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus NewCopy(
      PhaseMaint phaseMaint,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      return this.NewCopy(phaseMaint, (PhaseMaint_Parameters) null, request, out result);
    }

    public ResultStatus PreviewChecklist(
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      result = (PhaseMaint_Result) null;
      this.OnBeforeCall(nameof (PreviewChecklist), (DCObject) phaseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseMaintService) this._Channel).PreviewChecklist(this._UserProfile, phaseMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseMaintMethod(phaseMaint, PhaseMaintMethods.PreviewChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreviewChecklist), res, (DCObject) phaseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreviewChecklist()
    {
      return this.PreviewChecklist((PhaseMaint) null, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus PreviewChecklist(PhaseMaint phaseMaint)
    {
      return this.PreviewChecklist(phaseMaint, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      PhaseMaint phaseMaint,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      return this.PreviewChecklist(phaseMaint, (PhaseMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      result = (PhaseMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) phaseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseMaintService) this._Channel).SaveAs(this._UserProfile, phaseMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseMaintMethod(phaseMaint, PhaseMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) phaseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((PhaseMaint) null, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus SaveAs(PhaseMaint phaseMaint)
    {
      return this.SaveAs(phaseMaint, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus SaveAs(
      PhaseMaint phaseMaint,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      return this.SaveAs(phaseMaint, (PhaseMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      result = (PhaseMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) phaseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseMaintService) this._Channel).UnFreeze(this._UserProfile, phaseMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseMaintMethod(phaseMaint, PhaseMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) phaseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((PhaseMaint) null, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus UnFreeze(PhaseMaint phaseMaint)
    {
      return this.UnFreeze(phaseMaint, (PhaseMaint_Parameters) null, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PhaseMaint phaseMaint,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      return this.UnFreeze(phaseMaint, (PhaseMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetApprovalSheetTemplate(
      DCObject phaseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseMaint_Result result1;
        ResultStatus approvalSheetTemplate = this.GetApprovalSheetTemplate((PhaseMaint) phaseMaint, (PhaseMaint_Parameters) parameters, (PhaseMaint_Request) request, out result1);
        result = (Result) result1;
        return approvalSheetTemplate;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadBusinessRules(
      DCObject phaseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseMaint_Result result1;
        ResultStatus resultStatus = this.LoadBusinessRules((PhaseMaint) phaseMaint, (PhaseMaint_Parameters) parameters, (PhaseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadChecklistTemplate(
      DCObject phaseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseMaint_Result result1;
        ResultStatus resultStatus = this.LoadChecklistTemplate((PhaseMaint) phaseMaint, (PhaseMaint_Parameters) parameters, (PhaseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadTemplate(
      DCObject phaseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseMaint_Result result1;
        ResultStatus resultStatus = this.LoadTemplate((PhaseMaint) phaseMaint, (PhaseMaint_Parameters) parameters, (PhaseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnPreviewChecklist(
      DCObject phaseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseMaint_Result result1;
        ResultStatus resultStatus = this.PreviewChecklist((PhaseMaint) phaseMaint, (PhaseMaint_Parameters) parameters, (PhaseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject phaseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseMaint_Result result1;
        ResultStatus resultStatus = this.Delete((PhaseMaint) phaseMaint, (PhaseMaint_Parameters) parameters, (PhaseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject phaseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((PhaseMaint) phaseMaint, (PhaseMaint_Parameters) parameters, (PhaseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject phaseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PhaseMaint) phaseMaint, (PhaseMaint_LoadESigDetails_Parameters) parameters, (PhaseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject phaseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseMaint_Result result1;
        ResultStatus resultStatus = this.New((PhaseMaint) phaseMaint, (PhaseMaint_Parameters) parameters, (PhaseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject phaseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((PhaseMaint) phaseMaint, (PhaseMaint_Parameters) parameters, (PhaseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject phaseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((PhaseMaint) phaseMaint, (PhaseMaint_Parameters) parameters, (PhaseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject phaseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((PhaseMaint) phaseMaint, (PhaseMaint_Parameters) parameters, (PhaseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject phaseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseMaint_Result result1;
        ResultStatus resultStatus = this.Load((PhaseMaint) phaseMaint, (PhaseMaint_Parameters) parameters, (PhaseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject phaseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PhaseMaint) phaseMaint, (PhaseMaint_Parameters) parameters, (PhaseMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      result = (PhaseMaint_Result) null;
      try
      {
        PhaseMaintMethod[] methods = new PhaseMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPhaseMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PhaseMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PhaseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PhaseMaint cdo,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      result = (PhaseMaint_Result) null;
      try
      {
        return ((IPhaseMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PhaseMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((PhaseMaint) cdo, (PhaseMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      return this.GetEnvironment((PhaseMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PhaseMaint cdo,
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      result = (PhaseMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PhaseMaintMethod(cdo, PhaseMaintMethods.ExecuteTransaction, (PhaseMaint_Parameters) null));
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
        PhaseMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PhaseMaint) cdo, (PhaseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PhaseMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (PhaseMaint_Request) null, out PhaseMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PhaseMaint_Request request,
      out PhaseMaint_Result result)
    {
      return this.ExecuteTransaction((PhaseMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PhaseMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PhaseMaintMethod(cdo, PhaseMaintMethods.AddDataTransaction, (PhaseMaint_Parameters) null));
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
        return this.AddDataTransaction((PhaseMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
