// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PlanTemplateMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PlanTemplateMaintService : ProcessObjectTemplateMaintBase
  {
    public PlanTemplateMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPlanTemplateMaintService), userProfile);
    }

    public ResultStatus Delete(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      result = (PlanTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateMaintService) this._Channel).Delete(this._UserProfile, planTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateMaintMethod(planTemplateMaint, PlanTemplateMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((PlanTemplateMaint) null, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus Delete(PlanTemplateMaint planTemplateMaint)
    {
      return this.Delete(planTemplateMaint, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus Delete(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      return this.Delete(planTemplateMaint, (PlanTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      result = (PlanTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateMaintService) this._Channel).Freeze(this._UserProfile, planTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateMaintMethod(planTemplateMaint, PlanTemplateMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((PlanTemplateMaint) null, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus Freeze(PlanTemplateMaint planTemplateMaint)
    {
      return this.Freeze(planTemplateMaint, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus Freeze(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      return this.Freeze(planTemplateMaint, (PlanTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      result = (PlanTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateMaintService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, planTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateMaintMethod(planTemplateMaint, PlanTemplateMaintMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((PlanTemplateMaint) null, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(PlanTemplateMaint planTemplateMaint)
    {
      return this.GetApprovalSheetTemplate(planTemplateMaint, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      return this.GetApprovalSheetTemplate(planTemplateMaint, (PlanTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      result = (PlanTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateMaintService) this._Channel).GetWIPMsgs(this._UserProfile, planTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateMaintMethod(planTemplateMaint, PlanTemplateMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PlanTemplateMaint) null, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(PlanTemplateMaint planTemplateMaint)
    {
      return this.GetWIPMsgs(planTemplateMaint, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      return this.GetWIPMsgs(planTemplateMaint, (PlanTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      result = (PlanTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateMaintService) this._Channel).Load(this._UserProfile, planTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateMaintMethod(planTemplateMaint, PlanTemplateMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PlanTemplateMaint) null, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus Load(PlanTemplateMaint planTemplateMaint)
    {
      return this.Load(planTemplateMaint, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus Load(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      return this.Load(planTemplateMaint, (PlanTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadBusinessRules(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      result = (PlanTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (LoadBusinessRules), (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateMaintService) this._Channel).LoadBusinessRules(this._UserProfile, planTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateMaintMethod(planTemplateMaint, PlanTemplateMaintMethods.LoadBusinessRules, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadBusinessRules), res, (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadBusinessRules()
    {
      return this.LoadBusinessRules((PlanTemplateMaint) null, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(PlanTemplateMaint planTemplateMaint)
    {
      return this.LoadBusinessRules(planTemplateMaint, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      return this.LoadBusinessRules(planTemplateMaint, (PlanTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadChecklistTemplate(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      result = (PlanTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (LoadChecklistTemplate), (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateMaintService) this._Channel).LoadChecklistTemplate(this._UserProfile, planTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateMaintMethod(planTemplateMaint, PlanTemplateMaintMethods.LoadChecklistTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadChecklistTemplate), res, (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadChecklistTemplate()
    {
      return this.LoadChecklistTemplate((PlanTemplateMaint) null, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(PlanTemplateMaint planTemplateMaint)
    {
      return this.LoadChecklistTemplate(planTemplateMaint, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      return this.LoadChecklistTemplate(planTemplateMaint, (PlanTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_LoadESigDetails_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      result = (PlanTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateMaintService) this._Channel).LoadESigDetails(this._UserProfile, planTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateMaintMethod(planTemplateMaint, PlanTemplateMaintMethods.LoadESigDetails, (PlanTemplateMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PlanTemplateMaint) null, (PlanTemplateMaint_LoadESigDetails_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(PlanTemplateMaint planTemplateMaint)
    {
      return this.LoadESigDetails(planTemplateMaint, (PlanTemplateMaint_LoadESigDetails_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      return this.LoadESigDetails(planTemplateMaint, (PlanTemplateMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      result = (PlanTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateMaintService) this._Channel).New(this._UserProfile, planTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateMaintMethod(planTemplateMaint, PlanTemplateMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((PlanTemplateMaint) null, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus New(PlanTemplateMaint planTemplateMaint)
    {
      return this.New(planTemplateMaint, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus New(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      return this.New(planTemplateMaint, (PlanTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      result = (PlanTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateMaintService) this._Channel).NewCopy(this._UserProfile, planTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateMaintMethod(planTemplateMaint, PlanTemplateMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((PlanTemplateMaint) null, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(PlanTemplateMaint planTemplateMaint)
    {
      return this.NewCopy(planTemplateMaint, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      return this.NewCopy(planTemplateMaint, (PlanTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus PreviewChecklist(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      result = (PlanTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (PreviewChecklist), (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateMaintService) this._Channel).PreviewChecklist(this._UserProfile, planTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateMaintMethod(planTemplateMaint, PlanTemplateMaintMethods.PreviewChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreviewChecklist), res, (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreviewChecklist()
    {
      return this.PreviewChecklist((PlanTemplateMaint) null, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus PreviewChecklist(PlanTemplateMaint planTemplateMaint)
    {
      return this.PreviewChecklist(planTemplateMaint, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      return this.PreviewChecklist(planTemplateMaint, (PlanTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      result = (PlanTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateMaintService) this._Channel).SaveAs(this._UserProfile, planTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateMaintMethod(planTemplateMaint, PlanTemplateMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((PlanTemplateMaint) null, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(PlanTemplateMaint planTemplateMaint)
    {
      return this.SaveAs(planTemplateMaint, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      return this.SaveAs(planTemplateMaint, (PlanTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      result = (PlanTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateMaintService) this._Channel).UnFreeze(this._UserProfile, planTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateMaintMethod(planTemplateMaint, PlanTemplateMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) planTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((PlanTemplateMaint) null, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(PlanTemplateMaint planTemplateMaint)
    {
      return this.UnFreeze(planTemplateMaint, (PlanTemplateMaint_Parameters) null, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      return this.UnFreeze(planTemplateMaint, (PlanTemplateMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetApprovalSheetTemplate(
      DCObject planTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateMaint_Result result1;
        ResultStatus approvalSheetTemplate = this.GetApprovalSheetTemplate((PlanTemplateMaint) planTemplateMaint, (PlanTemplateMaint_Parameters) parameters, (PlanTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return approvalSheetTemplate;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadBusinessRules(
      DCObject planTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateMaint_Result result1;
        ResultStatus resultStatus = this.LoadBusinessRules((PlanTemplateMaint) planTemplateMaint, (PlanTemplateMaint_Parameters) parameters, (PlanTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadChecklistTemplate(
      DCObject planTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateMaint_Result result1;
        ResultStatus resultStatus = this.LoadChecklistTemplate((PlanTemplateMaint) planTemplateMaint, (PlanTemplateMaint_Parameters) parameters, (PlanTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnPreviewChecklist(
      DCObject planTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateMaint_Result result1;
        ResultStatus resultStatus = this.PreviewChecklist((PlanTemplateMaint) planTemplateMaint, (PlanTemplateMaint_Parameters) parameters, (PlanTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject planTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Delete((PlanTemplateMaint) planTemplateMaint, (PlanTemplateMaint_Parameters) parameters, (PlanTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject planTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((PlanTemplateMaint) planTemplateMaint, (PlanTemplateMaint_Parameters) parameters, (PlanTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject planTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PlanTemplateMaint) planTemplateMaint, (PlanTemplateMaint_LoadESigDetails_Parameters) parameters, (PlanTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject planTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateMaint_Result result1;
        ResultStatus resultStatus = this.New((PlanTemplateMaint) planTemplateMaint, (PlanTemplateMaint_Parameters) parameters, (PlanTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject planTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((PlanTemplateMaint) planTemplateMaint, (PlanTemplateMaint_Parameters) parameters, (PlanTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject planTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((PlanTemplateMaint) planTemplateMaint, (PlanTemplateMaint_Parameters) parameters, (PlanTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject planTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((PlanTemplateMaint) planTemplateMaint, (PlanTemplateMaint_Parameters) parameters, (PlanTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject planTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Load((PlanTemplateMaint) planTemplateMaint, (PlanTemplateMaint_Parameters) parameters, (PlanTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject planTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PlanTemplateMaint) planTemplateMaint, (PlanTemplateMaint_Parameters) parameters, (PlanTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      result = (PlanTemplateMaint_Result) null;
      try
      {
        PlanTemplateMaintMethod[] methods = new PlanTemplateMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPlanTemplateMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PlanTemplateMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PlanTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PlanTemplateMaint cdo,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      result = (PlanTemplateMaint_Result) null;
      try
      {
        return ((IPlanTemplateMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PlanTemplateMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((PlanTemplateMaint) cdo, (PlanTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      return this.GetEnvironment((PlanTemplateMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PlanTemplateMaint cdo,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      result = (PlanTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PlanTemplateMaintMethod(cdo, PlanTemplateMaintMethods.ExecuteTransaction, (PlanTemplateMaint_Parameters) null));
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
        PlanTemplateMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PlanTemplateMaint) cdo, (PlanTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PlanTemplateMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (PlanTemplateMaint_Request) null, out PlanTemplateMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result)
    {
      return this.ExecuteTransaction((PlanTemplateMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PlanTemplateMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PlanTemplateMaintMethod(cdo, PlanTemplateMaintMethods.AddDataTransaction, (PlanTemplateMaint_Parameters) null));
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
        return this.AddDataTransaction((PlanTemplateMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
