// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PhaseTemplateDispositionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PhaseTemplateDispositionMaintService : PhaseTemplateMaintBase
  {
    public PhaseTemplateDispositionMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPhaseTemplateDispositionMaintService), userProfile);
    }

    public ResultStatus Delete(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      result = (PhaseTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateDispositionMaintService) this._Channel).Delete(this._UserProfile, phaseTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateDispositionMaintMethod(phaseTemplateDispositionMaint, PhaseTemplateDispositionMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((PhaseTemplateDispositionMaint) null, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus Delete(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint)
    {
      return this.Delete(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus Delete(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      return this.Delete(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      result = (PhaseTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateDispositionMaintService) this._Channel).Freeze(this._UserProfile, phaseTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateDispositionMaintMethod(phaseTemplateDispositionMaint, PhaseTemplateDispositionMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((PhaseTemplateDispositionMaint) null, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus Freeze(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint)
    {
      return this.Freeze(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus Freeze(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      return this.Freeze(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      result = (PhaseTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateDispositionMaintService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, phaseTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateDispositionMaintMethod(phaseTemplateDispositionMaint, PhaseTemplateDispositionMaintMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((PhaseTemplateDispositionMaint) null, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint)
    {
      return this.GetApprovalSheetTemplate(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      return this.GetApprovalSheetTemplate(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      result = (PhaseTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateDispositionMaintService) this._Channel).GetWIPMsgs(this._UserProfile, phaseTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateDispositionMaintMethod(phaseTemplateDispositionMaint, PhaseTemplateDispositionMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PhaseTemplateDispositionMaint) null, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint)
    {
      return this.GetWIPMsgs(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      return this.GetWIPMsgs(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      result = (PhaseTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateDispositionMaintService) this._Channel).Load(this._UserProfile, phaseTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateDispositionMaintMethod(phaseTemplateDispositionMaint, PhaseTemplateDispositionMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PhaseTemplateDispositionMaint) null, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus Load(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint)
    {
      return this.Load(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus Load(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      return this.Load(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadBusinessRules(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      result = (PhaseTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadBusinessRules), (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateDispositionMaintService) this._Channel).LoadBusinessRules(this._UserProfile, phaseTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateDispositionMaintMethod(phaseTemplateDispositionMaint, PhaseTemplateDispositionMaintMethods.LoadBusinessRules, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadBusinessRules), res, (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadBusinessRules()
    {
      return this.LoadBusinessRules((PhaseTemplateDispositionMaint) null, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint)
    {
      return this.LoadBusinessRules(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      return this.LoadBusinessRules(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadChecklistTemplate(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      result = (PhaseTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadChecklistTemplate), (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateDispositionMaintService) this._Channel).LoadChecklistTemplate(this._UserProfile, phaseTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateDispositionMaintMethod(phaseTemplateDispositionMaint, PhaseTemplateDispositionMaintMethods.LoadChecklistTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadChecklistTemplate), res, (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadChecklistTemplate()
    {
      return this.LoadChecklistTemplate((PhaseTemplateDispositionMaint) null, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint)
    {
      return this.LoadChecklistTemplate(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      return this.LoadChecklistTemplate(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_LoadESigDetails_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      result = (PhaseTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateDispositionMaintService) this._Channel).LoadESigDetails(this._UserProfile, phaseTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateDispositionMaintMethod(phaseTemplateDispositionMaint, PhaseTemplateDispositionMaintMethods.LoadESigDetails, (PhaseTemplateDispositionMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PhaseTemplateDispositionMaint) null, (PhaseTemplateDispositionMaint_LoadESigDetails_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint)
    {
      return this.LoadESigDetails(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_LoadESigDetails_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      return this.LoadESigDetails(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      result = (PhaseTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateDispositionMaintService) this._Channel).New(this._UserProfile, phaseTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateDispositionMaintMethod(phaseTemplateDispositionMaint, PhaseTemplateDispositionMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((PhaseTemplateDispositionMaint) null, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus New(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint)
    {
      return this.New(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus New(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      return this.New(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      result = (PhaseTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateDispositionMaintService) this._Channel).NewCopy(this._UserProfile, phaseTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateDispositionMaintMethod(phaseTemplateDispositionMaint, PhaseTemplateDispositionMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((PhaseTemplateDispositionMaint) null, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus NewCopy(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint)
    {
      return this.NewCopy(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus NewCopy(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      return this.NewCopy(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus PreviewChecklist(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      result = (PhaseTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (PreviewChecklist), (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateDispositionMaintService) this._Channel).PreviewChecklist(this._UserProfile, phaseTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateDispositionMaintMethod(phaseTemplateDispositionMaint, PhaseTemplateDispositionMaintMethods.PreviewChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreviewChecklist), res, (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreviewChecklist()
    {
      return this.PreviewChecklist((PhaseTemplateDispositionMaint) null, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint)
    {
      return this.PreviewChecklist(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      return this.PreviewChecklist(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      result = (PhaseTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateDispositionMaintService) this._Channel).SaveAs(this._UserProfile, phaseTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateDispositionMaintMethod(phaseTemplateDispositionMaint, PhaseTemplateDispositionMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((PhaseTemplateDispositionMaint) null, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus SaveAs(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint)
    {
      return this.SaveAs(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus SaveAs(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      return this.SaveAs(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      result = (PhaseTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateDispositionMaintService) this._Channel).UnFreeze(this._UserProfile, phaseTemplateDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseTemplateDispositionMaintMethod(phaseTemplateDispositionMaint, PhaseTemplateDispositionMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) phaseTemplateDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((PhaseTemplateDispositionMaint) null, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint)
    {
      return this.UnFreeze(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      return this.UnFreeze(phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetApprovalSheetTemplate(
      DCObject phaseTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateDispositionMaint_Result result1;
        ResultStatus approvalSheetTemplate = this.GetApprovalSheetTemplate((PhaseTemplateDispositionMaint) phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) parameters, (PhaseTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return approvalSheetTemplate;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadBusinessRules(
      DCObject phaseTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.LoadBusinessRules((PhaseTemplateDispositionMaint) phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) parameters, (PhaseTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadChecklistTemplate(
      DCObject phaseTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.LoadChecklistTemplate((PhaseTemplateDispositionMaint) phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) parameters, (PhaseTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnPreviewChecklist(
      DCObject phaseTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.PreviewChecklist((PhaseTemplateDispositionMaint) phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) parameters, (PhaseTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject phaseTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.Delete((PhaseTemplateDispositionMaint) phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) parameters, (PhaseTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject phaseTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((PhaseTemplateDispositionMaint) phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) parameters, (PhaseTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject phaseTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PhaseTemplateDispositionMaint) phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_LoadESigDetails_Parameters) parameters, (PhaseTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject phaseTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.New((PhaseTemplateDispositionMaint) phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) parameters, (PhaseTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject phaseTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((PhaseTemplateDispositionMaint) phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) parameters, (PhaseTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject phaseTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((PhaseTemplateDispositionMaint) phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) parameters, (PhaseTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject phaseTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((PhaseTemplateDispositionMaint) phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) parameters, (PhaseTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject phaseTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.Load((PhaseTemplateDispositionMaint) phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) parameters, (PhaseTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject phaseTemplateDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseTemplateDispositionMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PhaseTemplateDispositionMaint) phaseTemplateDispositionMaint, (PhaseTemplateDispositionMaint_Parameters) parameters, (PhaseTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      result = (PhaseTemplateDispositionMaint_Result) null;
      try
      {
        PhaseTemplateDispositionMaintMethod[] methods = new PhaseTemplateDispositionMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPhaseTemplateDispositionMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PhaseTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PhaseTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PhaseTemplateDispositionMaint cdo,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      result = (PhaseTemplateDispositionMaint_Result) null;
      try
      {
        return ((IPhaseTemplateDispositionMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PhaseTemplateDispositionMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((PhaseTemplateDispositionMaint) cdo, (PhaseTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      return this.GetEnvironment((PhaseTemplateDispositionMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PhaseTemplateDispositionMaint cdo,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      result = (PhaseTemplateDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseTemplateDispositionMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PhaseTemplateDispositionMaintMethod(cdo, PhaseTemplateDispositionMaintMethods.ExecuteTransaction, (PhaseTemplateDispositionMaint_Parameters) null));
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
        PhaseTemplateDispositionMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PhaseTemplateDispositionMaint) cdo, (PhaseTemplateDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PhaseTemplateDispositionMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (PhaseTemplateDispositionMaint_Request) null, out PhaseTemplateDispositionMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result)
    {
      return this.ExecuteTransaction((PhaseTemplateDispositionMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PhaseTemplateDispositionMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PhaseTemplateDispositionMaintMethod(cdo, PhaseTemplateDispositionMaintMethods.AddDataTransaction, (PhaseTemplateDispositionMaint_Parameters) null));
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
        return this.AddDataTransaction((PhaseTemplateDispositionMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
