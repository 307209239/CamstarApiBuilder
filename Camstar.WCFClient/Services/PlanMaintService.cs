// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PlanMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PlanMaintService : ProcessObjectMaintBase
  {
    public PlanMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPlanMaintService), userProfile);
    }

    public ResultStatus Delete(
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      result = (PlanMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) planMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanMaintService) this._Channel).Delete(this._UserProfile, planMaint, parameters, request, out result) : this.AddMethod((Method) new PlanMaintMethod(planMaint, PlanMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) planMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((PlanMaint) null, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus Delete(PlanMaint planMaint)
    {
      return this.Delete(planMaint, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus Delete(
      PlanMaint planMaint,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      return this.Delete(planMaint, (PlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      result = (PlanMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) planMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanMaintService) this._Channel).Freeze(this._UserProfile, planMaint, parameters, request, out result) : this.AddMethod((Method) new PlanMaintMethod(planMaint, PlanMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) planMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((PlanMaint) null, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus Freeze(PlanMaint planMaint)
    {
      return this.Freeze(planMaint, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus Freeze(
      PlanMaint planMaint,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      return this.Freeze(planMaint, (PlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      result = (PlanMaint_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) planMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanMaintService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, planMaint, parameters, request, out result) : this.AddMethod((Method) new PlanMaintMethod(planMaint, PlanMaintMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) planMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((PlanMaint) null, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(PlanMaint planMaint)
    {
      return this.GetApprovalSheetTemplate(planMaint, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PlanMaint planMaint,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      return this.GetApprovalSheetTemplate(planMaint, (PlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      result = (PlanMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) planMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanMaintService) this._Channel).GetWIPMsgs(this._UserProfile, planMaint, parameters, request, out result) : this.AddMethod((Method) new PlanMaintMethod(planMaint, PlanMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) planMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PlanMaint) null, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(PlanMaint planMaint)
    {
      return this.GetWIPMsgs(planMaint, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PlanMaint planMaint,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      return this.GetWIPMsgs(planMaint, (PlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      result = (PlanMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) planMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanMaintService) this._Channel).Load(this._UserProfile, planMaint, parameters, request, out result) : this.AddMethod((Method) new PlanMaintMethod(planMaint, PlanMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) planMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PlanMaint) null, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus Load(PlanMaint planMaint)
    {
      return this.Load(planMaint, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus Load(
      PlanMaint planMaint,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      return this.Load(planMaint, (PlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadBusinessRules(
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      result = (PlanMaint_Result) null;
      this.OnBeforeCall(nameof (LoadBusinessRules), (DCObject) planMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanMaintService) this._Channel).LoadBusinessRules(this._UserProfile, planMaint, parameters, request, out result) : this.AddMethod((Method) new PlanMaintMethod(planMaint, PlanMaintMethods.LoadBusinessRules, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadBusinessRules), res, (DCObject) planMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadBusinessRules()
    {
      return this.LoadBusinessRules((PlanMaint) null, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(PlanMaint planMaint)
    {
      return this.LoadBusinessRules(planMaint, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      PlanMaint planMaint,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      return this.LoadBusinessRules(planMaint, (PlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadChecklistTemplate(
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      result = (PlanMaint_Result) null;
      this.OnBeforeCall(nameof (LoadChecklistTemplate), (DCObject) planMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanMaintService) this._Channel).LoadChecklistTemplate(this._UserProfile, planMaint, parameters, request, out result) : this.AddMethod((Method) new PlanMaintMethod(planMaint, PlanMaintMethods.LoadChecklistTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadChecklistTemplate), res, (DCObject) planMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadChecklistTemplate()
    {
      return this.LoadChecklistTemplate((PlanMaint) null, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(PlanMaint planMaint)
    {
      return this.LoadChecklistTemplate(planMaint, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      PlanMaint planMaint,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      return this.LoadChecklistTemplate(planMaint, (PlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PlanMaint planMaint,
      PlanMaint_LoadESigDetails_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      result = (PlanMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) planMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanMaintService) this._Channel).LoadESigDetails(this._UserProfile, planMaint, parameters, request, out result) : this.AddMethod((Method) new PlanMaintMethod(planMaint, PlanMaintMethods.LoadESigDetails, (PlanMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) planMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PlanMaint) null, (PlanMaint_LoadESigDetails_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus LoadESigDetails(PlanMaint planMaint)
    {
      return this.LoadESigDetails(planMaint, (PlanMaint_LoadESigDetails_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PlanMaint planMaint,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      return this.LoadESigDetails(planMaint, (PlanMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus LoadTemplate(
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      result = (PlanMaint_Result) null;
      this.OnBeforeCall(nameof (LoadTemplate), (DCObject) planMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanMaintService) this._Channel).LoadTemplate(this._UserProfile, planMaint, parameters, request, out result) : this.AddMethod((Method) new PlanMaintMethod(planMaint, PlanMaintMethods.LoadTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadTemplate), res, (DCObject) planMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadTemplate()
    {
      return this.LoadTemplate((PlanMaint) null, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus LoadTemplate(PlanMaint planMaint)
    {
      return this.LoadTemplate(planMaint, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus LoadTemplate(
      PlanMaint planMaint,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      return this.LoadTemplate(planMaint, (PlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus New(
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      result = (PlanMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) planMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanMaintService) this._Channel).New(this._UserProfile, planMaint, parameters, request, out result) : this.AddMethod((Method) new PlanMaintMethod(planMaint, PlanMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) planMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((PlanMaint) null, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus New(PlanMaint planMaint)
    {
      return this.New(planMaint, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus New(
      PlanMaint planMaint,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      return this.New(planMaint, (PlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      result = (PlanMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) planMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanMaintService) this._Channel).NewCopy(this._UserProfile, planMaint, parameters, request, out result) : this.AddMethod((Method) new PlanMaintMethod(planMaint, PlanMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) planMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((PlanMaint) null, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus NewCopy(PlanMaint planMaint)
    {
      return this.NewCopy(planMaint, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus NewCopy(
      PlanMaint planMaint,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      return this.NewCopy(planMaint, (PlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus PreviewChecklist(
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      result = (PlanMaint_Result) null;
      this.OnBeforeCall(nameof (PreviewChecklist), (DCObject) planMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanMaintService) this._Channel).PreviewChecklist(this._UserProfile, planMaint, parameters, request, out result) : this.AddMethod((Method) new PlanMaintMethod(planMaint, PlanMaintMethods.PreviewChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreviewChecklist), res, (DCObject) planMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreviewChecklist()
    {
      return this.PreviewChecklist((PlanMaint) null, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus PreviewChecklist(PlanMaint planMaint)
    {
      return this.PreviewChecklist(planMaint, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      PlanMaint planMaint,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      return this.PreviewChecklist(planMaint, (PlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      result = (PlanMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) planMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanMaintService) this._Channel).SaveAs(this._UserProfile, planMaint, parameters, request, out result) : this.AddMethod((Method) new PlanMaintMethod(planMaint, PlanMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) planMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((PlanMaint) null, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus SaveAs(PlanMaint planMaint)
    {
      return this.SaveAs(planMaint, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus SaveAs(
      PlanMaint planMaint,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      return this.SaveAs(planMaint, (PlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      result = (PlanMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) planMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanMaintService) this._Channel).UnFreeze(this._UserProfile, planMaint, parameters, request, out result) : this.AddMethod((Method) new PlanMaintMethod(planMaint, PlanMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) planMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((PlanMaint) null, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus UnFreeze(PlanMaint planMaint)
    {
      return this.UnFreeze(planMaint, (PlanMaint_Parameters) null, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PlanMaint planMaint,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      return this.UnFreeze(planMaint, (PlanMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetApprovalSheetTemplate(
      DCObject planMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanMaint_Result result1;
        ResultStatus approvalSheetTemplate = this.GetApprovalSheetTemplate((PlanMaint) planMaint, (PlanMaint_Parameters) parameters, (PlanMaint_Request) request, out result1);
        result = (Result) result1;
        return approvalSheetTemplate;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadBusinessRules(
      DCObject planMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanMaint_Result result1;
        ResultStatus resultStatus = this.LoadBusinessRules((PlanMaint) planMaint, (PlanMaint_Parameters) parameters, (PlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadChecklistTemplate(
      DCObject planMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanMaint_Result result1;
        ResultStatus resultStatus = this.LoadChecklistTemplate((PlanMaint) planMaint, (PlanMaint_Parameters) parameters, (PlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadTemplate(
      DCObject planMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanMaint_Result result1;
        ResultStatus resultStatus = this.LoadTemplate((PlanMaint) planMaint, (PlanMaint_Parameters) parameters, (PlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnPreviewChecklist(
      DCObject planMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanMaint_Result result1;
        ResultStatus resultStatus = this.PreviewChecklist((PlanMaint) planMaint, (PlanMaint_Parameters) parameters, (PlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject planMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanMaint_Result result1;
        ResultStatus resultStatus = this.Delete((PlanMaint) planMaint, (PlanMaint_Parameters) parameters, (PlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject planMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((PlanMaint) planMaint, (PlanMaint_Parameters) parameters, (PlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject planMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PlanMaint) planMaint, (PlanMaint_LoadESigDetails_Parameters) parameters, (PlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject planMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanMaint_Result result1;
        ResultStatus resultStatus = this.New((PlanMaint) planMaint, (PlanMaint_Parameters) parameters, (PlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject planMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((PlanMaint) planMaint, (PlanMaint_Parameters) parameters, (PlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject planMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((PlanMaint) planMaint, (PlanMaint_Parameters) parameters, (PlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject planMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((PlanMaint) planMaint, (PlanMaint_Parameters) parameters, (PlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject planMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanMaint_Result result1;
        ResultStatus resultStatus = this.Load((PlanMaint) planMaint, (PlanMaint_Parameters) parameters, (PlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject planMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PlanMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PlanMaint) planMaint, (PlanMaint_Parameters) parameters, (PlanMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      result = (PlanMaint_Result) null;
      try
      {
        PlanMaintMethod[] methods = new PlanMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPlanMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PlanMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PlanMaint cdo,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      result = (PlanMaint_Result) null;
      try
      {
        return ((IPlanMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PlanMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((PlanMaint) cdo, (PlanMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      return this.GetEnvironment((PlanMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PlanMaint cdo,
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      result = (PlanMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPlanMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PlanMaintMethod(cdo, PlanMaintMethods.ExecuteTransaction, (PlanMaint_Parameters) null));
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
        PlanMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PlanMaint) cdo, (PlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PlanMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (PlanMaint_Request) null, out PlanMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PlanMaint_Request request,
      out PlanMaint_Result result)
    {
      return this.ExecuteTransaction((PlanMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PlanMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PlanMaintMethod(cdo, PlanMaintMethods.AddDataTransaction, (PlanMaint_Parameters) null));
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
        return this.AddDataTransaction((PlanMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
