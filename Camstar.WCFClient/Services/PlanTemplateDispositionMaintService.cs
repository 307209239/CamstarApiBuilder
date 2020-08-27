// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PlanTemplateDispositionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PlanTemplateDispositionMaintService : PlanTemplateMaintBase
  {
    public PlanTemplateDispositionMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPlanTemplateDispositionMaintService), userProfile);
    }

    public ResultStatus Delete(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      result = (PlanTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateDispositionMaintService) this._Channel).Delete(this._UserProfile, planTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateDispositionMaintMethod(planTemplateDispositionMaint, PlanTemplateDispositionMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((PlanTemplateDispositionMaint) null, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus Delete(
      PlanTemplateDispositionMaint planTemplateDispositionMaint)
    {
      return this.Delete(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus Delete(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      return this.Delete(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      result = (PlanTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateDispositionMaintService) this._Channel).Freeze(this._UserProfile, planTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateDispositionMaintMethod(planTemplateDispositionMaint, PlanTemplateDispositionMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((PlanTemplateDispositionMaint) null, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus Freeze(
      PlanTemplateDispositionMaint planTemplateDispositionMaint)
    {
      return this.Freeze(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus Freeze(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      return this.Freeze(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      result = (PlanTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateDispositionMaintService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, planTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateDispositionMaintMethod(planTemplateDispositionMaint, PlanTemplateDispositionMaintMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((PlanTemplateDispositionMaint) null, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PlanTemplateDispositionMaint planTemplateDispositionMaint)
    {
      return this.GetApprovalSheetTemplate(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      return this.GetApprovalSheetTemplate(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      result = (PlanTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateDispositionMaintService) this._Channel).GetWIPMsgs(this._UserProfile, planTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateDispositionMaintMethod(planTemplateDispositionMaint, PlanTemplateDispositionMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PlanTemplateDispositionMaint) null, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PlanTemplateDispositionMaint planTemplateDispositionMaint)
    {
      return this.GetWIPMsgs(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      return this.GetWIPMsgs(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      result = (PlanTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateDispositionMaintService) this._Channel).Load(this._UserProfile, planTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateDispositionMaintMethod(planTemplateDispositionMaint, PlanTemplateDispositionMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PlanTemplateDispositionMaint) null, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus Load(
      PlanTemplateDispositionMaint planTemplateDispositionMaint)
    {
      return this.Load(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus Load(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      return this.Load(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadBusinessRules(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      result = (PlanTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadBusinessRules), (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateDispositionMaintService) this._Channel).LoadBusinessRules(this._UserProfile, planTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateDispositionMaintMethod(planTemplateDispositionMaint, PlanTemplateDispositionMaintMethods.LoadBusinessRules, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadBusinessRules), res, (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadBusinessRules()
    {
      return this.LoadBusinessRules((PlanTemplateDispositionMaint) null, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      PlanTemplateDispositionMaint planTemplateDispositionMaint)
    {
      return this.LoadBusinessRules(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      return this.LoadBusinessRules(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadChecklistTemplate(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      result = (PlanTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadChecklistTemplate), (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateDispositionMaintService) this._Channel).LoadChecklistTemplate(this._UserProfile, planTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateDispositionMaintMethod(planTemplateDispositionMaint, PlanTemplateDispositionMaintMethods.LoadChecklistTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadChecklistTemplate), res, (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadChecklistTemplate()
    {
      return this.LoadChecklistTemplate((PlanTemplateDispositionMaint) null, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      PlanTemplateDispositionMaint planTemplateDispositionMaint)
    {
      return this.LoadChecklistTemplate(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      return this.LoadChecklistTemplate(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_LoadESigDetails_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      result = (PlanTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateDispositionMaintService) this._Channel).LoadESigDetails(this._UserProfile, planTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateDispositionMaintMethod(planTemplateDispositionMaint, PlanTemplateDispositionMaintMethods.LoadESigDetails, (PlanTemplateDispositionMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PlanTemplateDispositionMaint) null, (PlanTemplateDispositionMaint_LoadESigDetails_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PlanTemplateDispositionMaint planTemplateDispositionMaint)
    {
      return this.LoadESigDetails(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_LoadESigDetails_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      return this.LoadESigDetails(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      result = (PlanTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateDispositionMaintService) this._Channel).New(this._UserProfile, planTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateDispositionMaintMethod(planTemplateDispositionMaint, PlanTemplateDispositionMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((PlanTemplateDispositionMaint) null, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus New(
      PlanTemplateDispositionMaint planTemplateDispositionMaint)
    {
      return this.New(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus New(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      return this.New(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      result = (PlanTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateDispositionMaintService) this._Channel).NewCopy(this._UserProfile, planTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateDispositionMaintMethod(planTemplateDispositionMaint, PlanTemplateDispositionMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((PlanTemplateDispositionMaint) null, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus NewCopy(
      PlanTemplateDispositionMaint planTemplateDispositionMaint)
    {
      return this.NewCopy(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus NewCopy(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      return this.NewCopy(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus PreviewChecklist(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      result = (PlanTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (PreviewChecklist), (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateDispositionMaintService) this._Channel).PreviewChecklist(this._UserProfile, planTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateDispositionMaintMethod(planTemplateDispositionMaint, PlanTemplateDispositionMaintMethods.PreviewChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreviewChecklist), res, (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreviewChecklist()
    {
      return this.PreviewChecklist((PlanTemplateDispositionMaint) null, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      PlanTemplateDispositionMaint planTemplateDispositionMaint)
    {
      return this.PreviewChecklist(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      return this.PreviewChecklist(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      result = (PlanTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateDispositionMaintService) this._Channel).SaveAs(this._UserProfile, planTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateDispositionMaintMethod(planTemplateDispositionMaint, PlanTemplateDispositionMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((PlanTemplateDispositionMaint) null, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus SaveAs(
      PlanTemplateDispositionMaint planTemplateDispositionMaint)
    {
      return this.SaveAs(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus SaveAs(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      return this.SaveAs(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      result = (PlanTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateDispositionMaintService) this._Channel).UnFreeze(this._UserProfile, planTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PlanTemplateDispositionMaintMethod(planTemplateDispositionMaint, PlanTemplateDispositionMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) planTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((PlanTemplateDispositionMaint) null, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PlanTemplateDispositionMaint planTemplateDispositionMaint)
    {
      return this.UnFreeze(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      return this.UnFreeze(planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetApprovalSheetTemplate(
      DCObject planTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateDispositionMaint_Result result1;
        ResultStatus approvalSheetTemplate = this.GetApprovalSheetTemplate((PlanTemplateDispositionMaint) planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) parameters, (PlanTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return approvalSheetTemplate;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadBusinessRules(
      DCObject planTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.LoadBusinessRules((PlanTemplateDispositionMaint) planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) parameters, (PlanTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadChecklistTemplate(
      DCObject planTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.LoadChecklistTemplate((PlanTemplateDispositionMaint) planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) parameters, (PlanTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnPreviewChecklist(
      DCObject planTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.PreviewChecklist((PlanTemplateDispositionMaint) planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) parameters, (PlanTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject planTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.Delete((PlanTemplateDispositionMaint) planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) parameters, (PlanTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject planTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((PlanTemplateDispositionMaint) planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) parameters, (PlanTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject planTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PlanTemplateDispositionMaint) planTemplateDispositionMaint, (PlanTemplateDispositionMaint_LoadESigDetails_Parameters) parameters, (PlanTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject planTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.New((PlanTemplateDispositionMaint) planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) parameters, (PlanTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject planTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((PlanTemplateDispositionMaint) planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) parameters, (PlanTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject planTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((PlanTemplateDispositionMaint) planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) parameters, (PlanTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject planTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((PlanTemplateDispositionMaint) planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) parameters, (PlanTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject planTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.Load((PlanTemplateDispositionMaint) planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) parameters, (PlanTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject planTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanTemplateDispositionMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PlanTemplateDispositionMaint) planTemplateDispositionMaint, (PlanTemplateDispositionMaint_Parameters) parameters, (PlanTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      result = (PlanTemplateDispositionMaint_Result) null;
      try
      {
        PlanTemplateDispositionMaintMethod[] methods = new PlanTemplateDispositionMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPlanTemplateDispositionMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PlanTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PlanTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PlanTemplateDispositionMaint cdo,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      result = (PlanTemplateDispositionMaint_Result) null;
      try
      {
        return ((IPlanTemplateDispositionMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PlanTemplateDispositionMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((PlanTemplateDispositionMaint) cdo, (PlanTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      return this.GetEnvironment((PlanTemplateDispositionMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PlanTemplateDispositionMaint cdo,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      result = (PlanTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanTemplateDispositionMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PlanTemplateDispositionMaintMethod(cdo, PlanTemplateDispositionMaintMethods.ExecuteTransaction, (PlanTemplateDispositionMaint_Parameters) null));
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
        PlanTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PlanTemplateDispositionMaint) cdo, (PlanTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PlanTemplateDispositionMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (PlanTemplateDispositionMaint_Request) null, out PlanTemplateDispositionMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result)
    {
      return this.ExecuteTransaction((PlanTemplateDispositionMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PlanTemplateDispositionMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PlanTemplateDispositionMaintMethod(cdo, PlanTemplateDispositionMaintMethods.AddDataTransaction, (PlanTemplateDispositionMaint_Parameters) null));
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
        return this.AddDataTransaction((PlanTemplateDispositionMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
