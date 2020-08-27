// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PhaseTemplateMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PhaseTemplateMaintService : ProcessObjectTemplateMaintBase
  {
    public PhaseTemplateMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPhaseTemplateMaintService), userProfile);
    }

    public ResultStatus Delete(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      result = (PhaseTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateMaintService) this._Channel).Delete(this._UserProfile, phaseTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateMaintMethod(phaseTemplateMaint, PhaseTemplateMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((PhaseTemplateMaint) null, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus Delete(PhaseTemplateMaint phaseTemplateMaint)
    {
      return this.Delete(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus Delete(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      return this.Delete(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      result = (PhaseTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateMaintService) this._Channel).Freeze(this._UserProfile, phaseTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateMaintMethod(phaseTemplateMaint, PhaseTemplateMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((PhaseTemplateMaint) null, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus Freeze(PhaseTemplateMaint phaseTemplateMaint)
    {
      return this.Freeze(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus Freeze(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      return this.Freeze(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      result = (PhaseTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateMaintService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, phaseTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateMaintMethod(phaseTemplateMaint, PhaseTemplateMaintMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((PhaseTemplateMaint) null, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(PhaseTemplateMaint phaseTemplateMaint)
    {
      return this.GetApprovalSheetTemplate(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      return this.GetApprovalSheetTemplate(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      result = (PhaseTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateMaintService) this._Channel).GetWIPMsgs(this._UserProfile, phaseTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateMaintMethod(phaseTemplateMaint, PhaseTemplateMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PhaseTemplateMaint) null, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(PhaseTemplateMaint phaseTemplateMaint)
    {
      return this.GetWIPMsgs(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      return this.GetWIPMsgs(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      result = (PhaseTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateMaintService) this._Channel).Load(this._UserProfile, phaseTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateMaintMethod(phaseTemplateMaint, PhaseTemplateMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PhaseTemplateMaint) null, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus Load(PhaseTemplateMaint phaseTemplateMaint)
    {
      return this.Load(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus Load(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      return this.Load(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadBusinessRules(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      result = (PhaseTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (LoadBusinessRules), (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateMaintService) this._Channel).LoadBusinessRules(this._UserProfile, phaseTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateMaintMethod(phaseTemplateMaint, PhaseTemplateMaintMethods.LoadBusinessRules, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadBusinessRules), res, (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadBusinessRules()
    {
      return this.LoadBusinessRules((PhaseTemplateMaint) null, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(PhaseTemplateMaint phaseTemplateMaint)
    {
      return this.LoadBusinessRules(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      return this.LoadBusinessRules(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadChecklistTemplate(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      result = (PhaseTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (LoadChecklistTemplate), (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateMaintService) this._Channel).LoadChecklistTemplate(this._UserProfile, phaseTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateMaintMethod(phaseTemplateMaint, PhaseTemplateMaintMethods.LoadChecklistTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadChecklistTemplate), res, (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadChecklistTemplate()
    {
      return this.LoadChecklistTemplate((PhaseTemplateMaint) null, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(PhaseTemplateMaint phaseTemplateMaint)
    {
      return this.LoadChecklistTemplate(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      return this.LoadChecklistTemplate(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_LoadESigDetails_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      result = (PhaseTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateMaintService) this._Channel).LoadESigDetails(this._UserProfile, phaseTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateMaintMethod(phaseTemplateMaint, PhaseTemplateMaintMethods.LoadESigDetails, (PhaseTemplateMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PhaseTemplateMaint) null, (PhaseTemplateMaint_LoadESigDetails_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(PhaseTemplateMaint phaseTemplateMaint)
    {
      return this.LoadESigDetails(phaseTemplateMaint, (PhaseTemplateMaint_LoadESigDetails_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      return this.LoadESigDetails(phaseTemplateMaint, (PhaseTemplateMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      result = (PhaseTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateMaintService) this._Channel).New(this._UserProfile, phaseTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateMaintMethod(phaseTemplateMaint, PhaseTemplateMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((PhaseTemplateMaint) null, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus New(PhaseTemplateMaint phaseTemplateMaint)
    {
      return this.New(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus New(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      return this.New(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      result = (PhaseTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateMaintService) this._Channel).NewCopy(this._UserProfile, phaseTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateMaintMethod(phaseTemplateMaint, PhaseTemplateMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((PhaseTemplateMaint) null, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(PhaseTemplateMaint phaseTemplateMaint)
    {
      return this.NewCopy(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      return this.NewCopy(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus PreviewChecklist(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      result = (PhaseTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (PreviewChecklist), (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateMaintService) this._Channel).PreviewChecklist(this._UserProfile, phaseTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateMaintMethod(phaseTemplateMaint, PhaseTemplateMaintMethods.PreviewChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreviewChecklist), res, (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreviewChecklist()
    {
      return this.PreviewChecklist((PhaseTemplateMaint) null, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus PreviewChecklist(PhaseTemplateMaint phaseTemplateMaint)
    {
      return this.PreviewChecklist(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      return this.PreviewChecklist(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      result = (PhaseTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateMaintService) this._Channel).SaveAs(this._UserProfile, phaseTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateMaintMethod(phaseTemplateMaint, PhaseTemplateMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((PhaseTemplateMaint) null, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(PhaseTemplateMaint phaseTemplateMaint)
    {
      return this.SaveAs(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      return this.SaveAs(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      result = (PhaseTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateMaintService) this._Channel).UnFreeze(this._UserProfile, phaseTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateMaintMethod(phaseTemplateMaint, PhaseTemplateMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) phaseTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((PhaseTemplateMaint) null, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(PhaseTemplateMaint phaseTemplateMaint)
    {
      return this.UnFreeze(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      return this.UnFreeze(phaseTemplateMaint, (PhaseTemplateMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetApprovalSheetTemplate(
      DCObject phaseTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateMaint_Result result1;
        ResultStatus approvalSheetTemplate = this.GetApprovalSheetTemplate((PhaseTemplateMaint) phaseTemplateMaint, (PhaseTemplateMaint_Parameters) parameters, (PhaseTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return approvalSheetTemplate;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadBusinessRules(
      DCObject phaseTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateMaint_Result result1;
        ResultStatus resultStatus = this.LoadBusinessRules((PhaseTemplateMaint) phaseTemplateMaint, (PhaseTemplateMaint_Parameters) parameters, (PhaseTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadChecklistTemplate(
      DCObject phaseTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateMaint_Result result1;
        ResultStatus resultStatus = this.LoadChecklistTemplate((PhaseTemplateMaint) phaseTemplateMaint, (PhaseTemplateMaint_Parameters) parameters, (PhaseTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnPreviewChecklist(
      DCObject phaseTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateMaint_Result result1;
        ResultStatus resultStatus = this.PreviewChecklist((PhaseTemplateMaint) phaseTemplateMaint, (PhaseTemplateMaint_Parameters) parameters, (PhaseTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject phaseTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Delete((PhaseTemplateMaint) phaseTemplateMaint, (PhaseTemplateMaint_Parameters) parameters, (PhaseTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject phaseTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((PhaseTemplateMaint) phaseTemplateMaint, (PhaseTemplateMaint_Parameters) parameters, (PhaseTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject phaseTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PhaseTemplateMaint) phaseTemplateMaint, (PhaseTemplateMaint_LoadESigDetails_Parameters) parameters, (PhaseTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject phaseTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateMaint_Result result1;
        ResultStatus resultStatus = this.New((PhaseTemplateMaint) phaseTemplateMaint, (PhaseTemplateMaint_Parameters) parameters, (PhaseTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject phaseTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((PhaseTemplateMaint) phaseTemplateMaint, (PhaseTemplateMaint_Parameters) parameters, (PhaseTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject phaseTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((PhaseTemplateMaint) phaseTemplateMaint, (PhaseTemplateMaint_Parameters) parameters, (PhaseTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject phaseTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((PhaseTemplateMaint) phaseTemplateMaint, (PhaseTemplateMaint_Parameters) parameters, (PhaseTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject phaseTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Load((PhaseTemplateMaint) phaseTemplateMaint, (PhaseTemplateMaint_Parameters) parameters, (PhaseTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject phaseTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PhaseTemplateMaint) phaseTemplateMaint, (PhaseTemplateMaint_Parameters) parameters, (PhaseTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      result = (PhaseTemplateMaint_Result) null;
      try
      {
        PhaseTemplateMaintMethod[] methods = new PhaseTemplateMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPhaseTemplateMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PhaseTemplateMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PhaseTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PhaseTemplateMaint cdo,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      result = (PhaseTemplateMaint_Result) null;
      try
      {
        return ((IPhaseTemplateMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PhaseTemplateMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((PhaseTemplateMaint) cdo, (PhaseTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      return this.GetEnvironment((PhaseTemplateMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PhaseTemplateMaint cdo,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      result = (PhaseTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PhaseTemplateMaintMethod(cdo, PhaseTemplateMaintMethods.ExecuteTransaction, (PhaseTemplateMaint_Parameters) null));
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
        PhaseTemplateMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PhaseTemplateMaint) cdo, (PhaseTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PhaseTemplateMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (PhaseTemplateMaint_Request) null, out PhaseTemplateMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result)
    {
      return this.ExecuteTransaction((PhaseTemplateMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PhaseTemplateMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PhaseTemplateMaintMethod(cdo, PhaseTemplateMaintMethods.AddDataTransaction, (PhaseTemplateMaint_Parameters) null));
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
        return this.AddDataTransaction((PhaseTemplateMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
