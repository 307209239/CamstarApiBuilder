// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PlanDispositionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PlanDispositionMaintService : PlanMaintBase
  {
    public PlanDispositionMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPlanDispositionMaintService), userProfile);
    }

    public ResultStatus Delete(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      result = (PlanDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanDispositionMaintService) this._Channel).Delete(this._UserProfile, planDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanDispositionMaintMethod(planDispositionMaint, PlanDispositionMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((PlanDispositionMaint) null, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus Delete(PlanDispositionMaint planDispositionMaint)
    {
      return this.Delete(planDispositionMaint, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus Delete(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      return this.Delete(planDispositionMaint, (PlanDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      result = (PlanDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanDispositionMaintService) this._Channel).Freeze(this._UserProfile, planDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanDispositionMaintMethod(planDispositionMaint, PlanDispositionMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((PlanDispositionMaint) null, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus Freeze(PlanDispositionMaint planDispositionMaint)
    {
      return this.Freeze(planDispositionMaint, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus Freeze(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      return this.Freeze(planDispositionMaint, (PlanDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      result = (PlanDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanDispositionMaintService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, planDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanDispositionMaintMethod(planDispositionMaint, PlanDispositionMaintMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((PlanDispositionMaint) null, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PlanDispositionMaint planDispositionMaint)
    {
      return this.GetApprovalSheetTemplate(planDispositionMaint, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      return this.GetApprovalSheetTemplate(planDispositionMaint, (PlanDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      result = (PlanDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanDispositionMaintService) this._Channel).GetWIPMsgs(this._UserProfile, planDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanDispositionMaintMethod(planDispositionMaint, PlanDispositionMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PlanDispositionMaint) null, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(PlanDispositionMaint planDispositionMaint)
    {
      return this.GetWIPMsgs(planDispositionMaint, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      return this.GetWIPMsgs(planDispositionMaint, (PlanDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      result = (PlanDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanDispositionMaintService) this._Channel).Load(this._UserProfile, planDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanDispositionMaintMethod(planDispositionMaint, PlanDispositionMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PlanDispositionMaint) null, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus Load(PlanDispositionMaint planDispositionMaint)
    {
      return this.Load(planDispositionMaint, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus Load(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      return this.Load(planDispositionMaint, (PlanDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadBusinessRules(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      result = (PlanDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadBusinessRules), (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanDispositionMaintService) this._Channel).LoadBusinessRules(this._UserProfile, planDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanDispositionMaintMethod(planDispositionMaint, PlanDispositionMaintMethods.LoadBusinessRules, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadBusinessRules), res, (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadBusinessRules()
    {
      return this.LoadBusinessRules((PlanDispositionMaint) null, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(PlanDispositionMaint planDispositionMaint)
    {
      return this.LoadBusinessRules(planDispositionMaint, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      return this.LoadBusinessRules(planDispositionMaint, (PlanDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadChecklistTemplate(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      result = (PlanDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadChecklistTemplate), (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanDispositionMaintService) this._Channel).LoadChecklistTemplate(this._UserProfile, planDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanDispositionMaintMethod(planDispositionMaint, PlanDispositionMaintMethods.LoadChecklistTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadChecklistTemplate), res, (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadChecklistTemplate()
    {
      return this.LoadChecklistTemplate((PlanDispositionMaint) null, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(PlanDispositionMaint planDispositionMaint)
    {
      return this.LoadChecklistTemplate(planDispositionMaint, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      return this.LoadChecklistTemplate(planDispositionMaint, (PlanDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_LoadESigDetails_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      result = (PlanDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanDispositionMaintService) this._Channel).LoadESigDetails(this._UserProfile, planDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanDispositionMaintMethod(planDispositionMaint, PlanDispositionMaintMethods.LoadESigDetails, (PlanDispositionMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PlanDispositionMaint) null, (PlanDispositionMaint_LoadESigDetails_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(PlanDispositionMaint planDispositionMaint)
    {
      return this.LoadESigDetails(planDispositionMaint, (PlanDispositionMaint_LoadESigDetails_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      return this.LoadESigDetails(planDispositionMaint, (PlanDispositionMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus LoadTemplate(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      result = (PlanDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadTemplate), (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanDispositionMaintService) this._Channel).LoadTemplate(this._UserProfile, planDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanDispositionMaintMethod(planDispositionMaint, PlanDispositionMaintMethods.LoadTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadTemplate), res, (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadTemplate()
    {
      return this.LoadTemplate((PlanDispositionMaint) null, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus LoadTemplate(PlanDispositionMaint planDispositionMaint)
    {
      return this.LoadTemplate(planDispositionMaint, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus LoadTemplate(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      return this.LoadTemplate(planDispositionMaint, (PlanDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus New(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      result = (PlanDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanDispositionMaintService) this._Channel).New(this._UserProfile, planDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanDispositionMaintMethod(planDispositionMaint, PlanDispositionMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((PlanDispositionMaint) null, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus New(PlanDispositionMaint planDispositionMaint)
    {
      return this.New(planDispositionMaint, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus New(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      return this.New(planDispositionMaint, (PlanDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      result = (PlanDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanDispositionMaintService) this._Channel).NewCopy(this._UserProfile, planDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanDispositionMaintMethod(planDispositionMaint, PlanDispositionMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((PlanDispositionMaint) null, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus NewCopy(PlanDispositionMaint planDispositionMaint)
    {
      return this.NewCopy(planDispositionMaint, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus NewCopy(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      return this.NewCopy(planDispositionMaint, (PlanDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus PreviewChecklist(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      result = (PlanDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (PreviewChecklist), (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanDispositionMaintService) this._Channel).PreviewChecklist(this._UserProfile, planDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanDispositionMaintMethod(planDispositionMaint, PlanDispositionMaintMethods.PreviewChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreviewChecklist), res, (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreviewChecklist()
    {
      return this.PreviewChecklist((PlanDispositionMaint) null, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus PreviewChecklist(PlanDispositionMaint planDispositionMaint)
    {
      return this.PreviewChecklist(planDispositionMaint, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      return this.PreviewChecklist(planDispositionMaint, (PlanDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      result = (PlanDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanDispositionMaintService) this._Channel).SaveAs(this._UserProfile, planDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanDispositionMaintMethod(planDispositionMaint, PlanDispositionMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((PlanDispositionMaint) null, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus SaveAs(PlanDispositionMaint planDispositionMaint)
    {
      return this.SaveAs(planDispositionMaint, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus SaveAs(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      return this.SaveAs(planDispositionMaint, (PlanDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      result = (PlanDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanDispositionMaintService) this._Channel).UnFreeze(this._UserProfile, planDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanDispositionMaintMethod(planDispositionMaint, PlanDispositionMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) planDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((PlanDispositionMaint) null, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus UnFreeze(PlanDispositionMaint planDispositionMaint)
    {
      return this.UnFreeze(planDispositionMaint, (PlanDispositionMaint_Parameters) null, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      return this.UnFreeze(planDispositionMaint, (PlanDispositionMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetApprovalSheetTemplate(
      DCObject planDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanDispositionMaint_Result result1;
        ResultStatus approvalSheetTemplate = this.GetApprovalSheetTemplate((PlanDispositionMaint) planDispositionMaint, (PlanDispositionMaint_Parameters) parameters, (PlanDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return approvalSheetTemplate;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadBusinessRules(
      DCObject planDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanDispositionMaint_Result result1;
        ResultStatus resultStatus = this.LoadBusinessRules((PlanDispositionMaint) planDispositionMaint, (PlanDispositionMaint_Parameters) parameters, (PlanDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadChecklistTemplate(
      DCObject planDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanDispositionMaint_Result result1;
        ResultStatus resultStatus = this.LoadChecklistTemplate((PlanDispositionMaint) planDispositionMaint, (PlanDispositionMaint_Parameters) parameters, (PlanDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadTemplate(
      DCObject planDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanDispositionMaint_Result result1;
        ResultStatus resultStatus = this.LoadTemplate((PlanDispositionMaint) planDispositionMaint, (PlanDispositionMaint_Parameters) parameters, (PlanDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnPreviewChecklist(
      DCObject planDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanDispositionMaint_Result result1;
        ResultStatus resultStatus = this.PreviewChecklist((PlanDispositionMaint) planDispositionMaint, (PlanDispositionMaint_Parameters) parameters, (PlanDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject planDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanDispositionMaint_Result result1;
        ResultStatus resultStatus = this.Delete((PlanDispositionMaint) planDispositionMaint, (PlanDispositionMaint_Parameters) parameters, (PlanDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject planDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanDispositionMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((PlanDispositionMaint) planDispositionMaint, (PlanDispositionMaint_Parameters) parameters, (PlanDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject planDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanDispositionMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PlanDispositionMaint) planDispositionMaint, (PlanDispositionMaint_LoadESigDetails_Parameters) parameters, (PlanDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject planDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanDispositionMaint_Result result1;
        ResultStatus resultStatus = this.New((PlanDispositionMaint) planDispositionMaint, (PlanDispositionMaint_Parameters) parameters, (PlanDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject planDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanDispositionMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((PlanDispositionMaint) planDispositionMaint, (PlanDispositionMaint_Parameters) parameters, (PlanDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject planDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanDispositionMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((PlanDispositionMaint) planDispositionMaint, (PlanDispositionMaint_Parameters) parameters, (PlanDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject planDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanDispositionMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((PlanDispositionMaint) planDispositionMaint, (PlanDispositionMaint_Parameters) parameters, (PlanDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject planDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanDispositionMaint_Result result1;
        ResultStatus resultStatus = this.Load((PlanDispositionMaint) planDispositionMaint, (PlanDispositionMaint_Parameters) parameters, (PlanDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject planDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanDispositionMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PlanDispositionMaint) planDispositionMaint, (PlanDispositionMaint_Parameters) parameters, (PlanDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      result = (PlanDispositionMaint_Result) null;
      try
      {
        PlanDispositionMaintMethod[] methods = new PlanDispositionMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPlanDispositionMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PlanDispositionMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PlanDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PlanDispositionMaint cdo,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      result = (PlanDispositionMaint_Result) null;
      try
      {
        return ((IPlanDispositionMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PlanDispositionMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((PlanDispositionMaint) cdo, (PlanDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      return this.GetEnvironment((PlanDispositionMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PlanDispositionMaint cdo,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      result = (PlanDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanDispositionMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PlanDispositionMaintMethod(cdo, PlanDispositionMaintMethods.ExecuteTransaction, (PlanDispositionMaint_Parameters) null));
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
        PlanDispositionMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PlanDispositionMaint) cdo, (PlanDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PlanDispositionMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (PlanDispositionMaint_Request) null, out PlanDispositionMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result)
    {
      return this.ExecuteTransaction((PlanDispositionMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PlanDispositionMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PlanDispositionMaintMethod(cdo, PlanDispositionMaintMethods.AddDataTransaction, (PlanDispositionMaint_Parameters) null));
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
        return this.AddDataTransaction((PlanDispositionMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
