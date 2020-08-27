// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PhaseDispositionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PhaseDispositionMaintService : PhaseMaintBase
  {
    public PhaseDispositionMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPhaseDispositionMaintService), userProfile);
    }

    public ResultStatus Delete(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      result = (PhaseDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseDispositionMaintService) this._Channel).Delete(this._UserProfile, phaseDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseDispositionMaintMethod(phaseDispositionMaint, PhaseDispositionMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((PhaseDispositionMaint) null, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus Delete(PhaseDispositionMaint phaseDispositionMaint)
    {
      return this.Delete(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus Delete(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      return this.Delete(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      result = (PhaseDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseDispositionMaintService) this._Channel).Freeze(this._UserProfile, phaseDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseDispositionMaintMethod(phaseDispositionMaint, PhaseDispositionMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((PhaseDispositionMaint) null, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus Freeze(PhaseDispositionMaint phaseDispositionMaint)
    {
      return this.Freeze(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus Freeze(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      return this.Freeze(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      result = (PhaseDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseDispositionMaintService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, phaseDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseDispositionMaintMethod(phaseDispositionMaint, PhaseDispositionMaintMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((PhaseDispositionMaint) null, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PhaseDispositionMaint phaseDispositionMaint)
    {
      return this.GetApprovalSheetTemplate(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      return this.GetApprovalSheetTemplate(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      result = (PhaseDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseDispositionMaintService) this._Channel).GetWIPMsgs(this._UserProfile, phaseDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseDispositionMaintMethod(phaseDispositionMaint, PhaseDispositionMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PhaseDispositionMaint) null, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(PhaseDispositionMaint phaseDispositionMaint)
    {
      return this.GetWIPMsgs(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      return this.GetWIPMsgs(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      result = (PhaseDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseDispositionMaintService) this._Channel).Load(this._UserProfile, phaseDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseDispositionMaintMethod(phaseDispositionMaint, PhaseDispositionMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PhaseDispositionMaint) null, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus Load(PhaseDispositionMaint phaseDispositionMaint)
    {
      return this.Load(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus Load(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      return this.Load(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadBusinessRules(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      result = (PhaseDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadBusinessRules), (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseDispositionMaintService) this._Channel).LoadBusinessRules(this._UserProfile, phaseDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseDispositionMaintMethod(phaseDispositionMaint, PhaseDispositionMaintMethods.LoadBusinessRules, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadBusinessRules), res, (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadBusinessRules()
    {
      return this.LoadBusinessRules((PhaseDispositionMaint) null, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(PhaseDispositionMaint phaseDispositionMaint)
    {
      return this.LoadBusinessRules(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      return this.LoadBusinessRules(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadChecklistTemplate(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      result = (PhaseDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadChecklistTemplate), (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseDispositionMaintService) this._Channel).LoadChecklistTemplate(this._UserProfile, phaseDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseDispositionMaintMethod(phaseDispositionMaint, PhaseDispositionMaintMethods.LoadChecklistTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadChecklistTemplate), res, (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadChecklistTemplate()
    {
      return this.LoadChecklistTemplate((PhaseDispositionMaint) null, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      PhaseDispositionMaint phaseDispositionMaint)
    {
      return this.LoadChecklistTemplate(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      return this.LoadChecklistTemplate(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_LoadESigDetails_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      result = (PhaseDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseDispositionMaintService) this._Channel).LoadESigDetails(this._UserProfile, phaseDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseDispositionMaintMethod(phaseDispositionMaint, PhaseDispositionMaintMethods.LoadESigDetails, (PhaseDispositionMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PhaseDispositionMaint) null, (PhaseDispositionMaint_LoadESigDetails_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(PhaseDispositionMaint phaseDispositionMaint)
    {
      return this.LoadESigDetails(phaseDispositionMaint, (PhaseDispositionMaint_LoadESigDetails_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      return this.LoadESigDetails(phaseDispositionMaint, (PhaseDispositionMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus LoadTemplate(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      result = (PhaseDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadTemplate), (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseDispositionMaintService) this._Channel).LoadTemplate(this._UserProfile, phaseDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseDispositionMaintMethod(phaseDispositionMaint, PhaseDispositionMaintMethods.LoadTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadTemplate), res, (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadTemplate()
    {
      return this.LoadTemplate((PhaseDispositionMaint) null, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus LoadTemplate(PhaseDispositionMaint phaseDispositionMaint)
    {
      return this.LoadTemplate(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus LoadTemplate(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      return this.LoadTemplate(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus New(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      result = (PhaseDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseDispositionMaintService) this._Channel).New(this._UserProfile, phaseDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseDispositionMaintMethod(phaseDispositionMaint, PhaseDispositionMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((PhaseDispositionMaint) null, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus New(PhaseDispositionMaint phaseDispositionMaint)
    {
      return this.New(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus New(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      return this.New(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      result = (PhaseDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseDispositionMaintService) this._Channel).NewCopy(this._UserProfile, phaseDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseDispositionMaintMethod(phaseDispositionMaint, PhaseDispositionMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((PhaseDispositionMaint) null, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus NewCopy(PhaseDispositionMaint phaseDispositionMaint)
    {
      return this.NewCopy(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus NewCopy(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      return this.NewCopy(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus PreviewChecklist(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      result = (PhaseDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (PreviewChecklist), (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseDispositionMaintService) this._Channel).PreviewChecklist(this._UserProfile, phaseDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseDispositionMaintMethod(phaseDispositionMaint, PhaseDispositionMaintMethods.PreviewChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreviewChecklist), res, (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreviewChecklist()
    {
      return this.PreviewChecklist((PhaseDispositionMaint) null, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus PreviewChecklist(PhaseDispositionMaint phaseDispositionMaint)
    {
      return this.PreviewChecklist(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      return this.PreviewChecklist(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      result = (PhaseDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseDispositionMaintService) this._Channel).SaveAs(this._UserProfile, phaseDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseDispositionMaintMethod(phaseDispositionMaint, PhaseDispositionMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((PhaseDispositionMaint) null, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus SaveAs(PhaseDispositionMaint phaseDispositionMaint)
    {
      return this.SaveAs(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus SaveAs(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      return this.SaveAs(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      result = (PhaseDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseDispositionMaintService) this._Channel).UnFreeze(this._UserProfile, phaseDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new PhaseDispositionMaintMethod(phaseDispositionMaint, PhaseDispositionMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) phaseDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((PhaseDispositionMaint) null, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus UnFreeze(PhaseDispositionMaint phaseDispositionMaint)
    {
      return this.UnFreeze(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      return this.UnFreeze(phaseDispositionMaint, (PhaseDispositionMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetApprovalSheetTemplate(
      DCObject phaseDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseDispositionMaint_Result result1;
        ResultStatus approvalSheetTemplate = this.GetApprovalSheetTemplate((PhaseDispositionMaint) phaseDispositionMaint, (PhaseDispositionMaint_Parameters) parameters, (PhaseDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return approvalSheetTemplate;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadBusinessRules(
      DCObject phaseDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseDispositionMaint_Result result1;
        ResultStatus resultStatus = this.LoadBusinessRules((PhaseDispositionMaint) phaseDispositionMaint, (PhaseDispositionMaint_Parameters) parameters, (PhaseDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadChecklistTemplate(
      DCObject phaseDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseDispositionMaint_Result result1;
        ResultStatus resultStatus = this.LoadChecklistTemplate((PhaseDispositionMaint) phaseDispositionMaint, (PhaseDispositionMaint_Parameters) parameters, (PhaseDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadTemplate(
      DCObject phaseDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseDispositionMaint_Result result1;
        ResultStatus resultStatus = this.LoadTemplate((PhaseDispositionMaint) phaseDispositionMaint, (PhaseDispositionMaint_Parameters) parameters, (PhaseDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnPreviewChecklist(
      DCObject phaseDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseDispositionMaint_Result result1;
        ResultStatus resultStatus = this.PreviewChecklist((PhaseDispositionMaint) phaseDispositionMaint, (PhaseDispositionMaint_Parameters) parameters, (PhaseDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject phaseDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseDispositionMaint_Result result1;
        ResultStatus resultStatus = this.Delete((PhaseDispositionMaint) phaseDispositionMaint, (PhaseDispositionMaint_Parameters) parameters, (PhaseDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject phaseDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseDispositionMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((PhaseDispositionMaint) phaseDispositionMaint, (PhaseDispositionMaint_Parameters) parameters, (PhaseDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject phaseDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseDispositionMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PhaseDispositionMaint) phaseDispositionMaint, (PhaseDispositionMaint_LoadESigDetails_Parameters) parameters, (PhaseDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject phaseDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseDispositionMaint_Result result1;
        ResultStatus resultStatus = this.New((PhaseDispositionMaint) phaseDispositionMaint, (PhaseDispositionMaint_Parameters) parameters, (PhaseDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject phaseDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseDispositionMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((PhaseDispositionMaint) phaseDispositionMaint, (PhaseDispositionMaint_Parameters) parameters, (PhaseDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject phaseDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseDispositionMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((PhaseDispositionMaint) phaseDispositionMaint, (PhaseDispositionMaint_Parameters) parameters, (PhaseDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject phaseDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseDispositionMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((PhaseDispositionMaint) phaseDispositionMaint, (PhaseDispositionMaint_Parameters) parameters, (PhaseDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject phaseDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseDispositionMaint_Result result1;
        ResultStatus resultStatus = this.Load((PhaseDispositionMaint) phaseDispositionMaint, (PhaseDispositionMaint_Parameters) parameters, (PhaseDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject phaseDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PhaseDispositionMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PhaseDispositionMaint) phaseDispositionMaint, (PhaseDispositionMaint_Parameters) parameters, (PhaseDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      result = (PhaseDispositionMaint_Result) null;
      try
      {
        PhaseDispositionMaintMethod[] methods = new PhaseDispositionMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPhaseDispositionMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PhaseDispositionMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PhaseDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PhaseDispositionMaint cdo,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      result = (PhaseDispositionMaint_Result) null;
      try
      {
        return ((IPhaseDispositionMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PhaseDispositionMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((PhaseDispositionMaint) cdo, (PhaseDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      return this.GetEnvironment((PhaseDispositionMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PhaseDispositionMaint cdo,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      result = (PhaseDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPhaseDispositionMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PhaseDispositionMaintMethod(cdo, PhaseDispositionMaintMethods.ExecuteTransaction, (PhaseDispositionMaint_Parameters) null));
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
        PhaseDispositionMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PhaseDispositionMaint) cdo, (PhaseDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PhaseDispositionMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (PhaseDispositionMaint_Request) null, out PhaseDispositionMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result)
    {
      return this.ExecuteTransaction((PhaseDispositionMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PhaseDispositionMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PhaseDispositionMaintMethod(cdo, PhaseDispositionMaintMethods.AddDataTransaction, (PhaseDispositionMaint_Parameters) null));
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
        return this.AddDataTransaction((PhaseDispositionMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
