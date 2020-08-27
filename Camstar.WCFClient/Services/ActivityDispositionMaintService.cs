// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ActivityDispositionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ActivityDispositionMaintService : ActivityMaintBase
  {
    public ActivityDispositionMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IActivityDispositionMaintService), userProfile);
    }

    public ResultStatus Delete(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      result = (ActivityDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityDispositionMaintService) this._Channel).Delete(this._UserProfile, activityDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityDispositionMaintMethod(activityDispositionMaint, ActivityDispositionMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ActivityDispositionMaint) null, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus Delete(ActivityDispositionMaint activityDispositionMaint)
    {
      return this.Delete(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus Delete(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      return this.Delete(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      result = (ActivityDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityDispositionMaintService) this._Channel).Freeze(this._UserProfile, activityDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityDispositionMaintMethod(activityDispositionMaint, ActivityDispositionMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ActivityDispositionMaint) null, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus Freeze(ActivityDispositionMaint activityDispositionMaint)
    {
      return this.Freeze(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus Freeze(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      return this.Freeze(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      result = (ActivityDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityDispositionMaintService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, activityDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityDispositionMaintMethod(activityDispositionMaint, ActivityDispositionMaintMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((ActivityDispositionMaint) null, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ActivityDispositionMaint activityDispositionMaint)
    {
      return this.GetApprovalSheetTemplate(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      return this.GetApprovalSheetTemplate(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      result = (ActivityDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityDispositionMaintService) this._Channel).GetWIPMsgs(this._UserProfile, activityDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityDispositionMaintMethod(activityDispositionMaint, ActivityDispositionMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ActivityDispositionMaint) null, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ActivityDispositionMaint activityDispositionMaint)
    {
      return this.GetWIPMsgs(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      return this.GetWIPMsgs(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      result = (ActivityDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityDispositionMaintService) this._Channel).Load(this._UserProfile, activityDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityDispositionMaintMethod(activityDispositionMaint, ActivityDispositionMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ActivityDispositionMaint) null, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus Load(ActivityDispositionMaint activityDispositionMaint)
    {
      return this.Load(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus Load(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      return this.Load(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadBusinessRules(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      result = (ActivityDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadBusinessRules), (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityDispositionMaintService) this._Channel).LoadBusinessRules(this._UserProfile, activityDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityDispositionMaintMethod(activityDispositionMaint, ActivityDispositionMaintMethods.LoadBusinessRules, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadBusinessRules), res, (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadBusinessRules()
    {
      return this.LoadBusinessRules((ActivityDispositionMaint) null, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      ActivityDispositionMaint activityDispositionMaint)
    {
      return this.LoadBusinessRules(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      return this.LoadBusinessRules(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadChecklistTemplate(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      result = (ActivityDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadChecklistTemplate), (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityDispositionMaintService) this._Channel).LoadChecklistTemplate(this._UserProfile, activityDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityDispositionMaintMethod(activityDispositionMaint, ActivityDispositionMaintMethods.LoadChecklistTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadChecklistTemplate), res, (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadChecklistTemplate()
    {
      return this.LoadChecklistTemplate((ActivityDispositionMaint) null, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      ActivityDispositionMaint activityDispositionMaint)
    {
      return this.LoadChecklistTemplate(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      return this.LoadChecklistTemplate(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadDispositions(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      result = (ActivityDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadDispositions), (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityDispositionMaintService) this._Channel).LoadDispositions(this._UserProfile, activityDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityDispositionMaintMethod(activityDispositionMaint, ActivityDispositionMaintMethods.LoadDispositions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadDispositions), res, (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadDispositions()
    {
      return this.LoadDispositions((ActivityDispositionMaint) null, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus LoadDispositions(
      ActivityDispositionMaint activityDispositionMaint)
    {
      return this.LoadDispositions(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus LoadDispositions(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      return this.LoadDispositions(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_LoadESigDetails_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      result = (ActivityDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityDispositionMaintService) this._Channel).LoadESigDetails(this._UserProfile, activityDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityDispositionMaintMethod(activityDispositionMaint, ActivityDispositionMaintMethods.LoadESigDetails, (ActivityDispositionMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ActivityDispositionMaint) null, (ActivityDispositionMaint_LoadESigDetails_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ActivityDispositionMaint activityDispositionMaint)
    {
      return this.LoadESigDetails(activityDispositionMaint, (ActivityDispositionMaint_LoadESigDetails_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      return this.LoadESigDetails(activityDispositionMaint, (ActivityDispositionMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus LoadTemplate(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      result = (ActivityDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadTemplate), (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityDispositionMaintService) this._Channel).LoadTemplate(this._UserProfile, activityDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityDispositionMaintMethod(activityDispositionMaint, ActivityDispositionMaintMethods.LoadTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadTemplate), res, (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadTemplate()
    {
      return this.LoadTemplate((ActivityDispositionMaint) null, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus LoadTemplate(ActivityDispositionMaint activityDispositionMaint)
    {
      return this.LoadTemplate(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus LoadTemplate(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      return this.LoadTemplate(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      result = (ActivityDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityDispositionMaintService) this._Channel).New(this._UserProfile, activityDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityDispositionMaintMethod(activityDispositionMaint, ActivityDispositionMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ActivityDispositionMaint) null, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus New(ActivityDispositionMaint activityDispositionMaint)
    {
      return this.New(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus New(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      return this.New(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      result = (ActivityDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityDispositionMaintService) this._Channel).NewCopy(this._UserProfile, activityDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityDispositionMaintMethod(activityDispositionMaint, ActivityDispositionMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ActivityDispositionMaint) null, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus NewCopy(ActivityDispositionMaint activityDispositionMaint)
    {
      return this.NewCopy(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus NewCopy(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      return this.NewCopy(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus PreviewChecklist(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      result = (ActivityDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (PreviewChecklist), (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityDispositionMaintService) this._Channel).PreviewChecklist(this._UserProfile, activityDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityDispositionMaintMethod(activityDispositionMaint, ActivityDispositionMaintMethods.PreviewChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreviewChecklist), res, (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreviewChecklist()
    {
      return this.PreviewChecklist((ActivityDispositionMaint) null, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      ActivityDispositionMaint activityDispositionMaint)
    {
      return this.PreviewChecklist(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      return this.PreviewChecklist(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      result = (ActivityDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityDispositionMaintService) this._Channel).SaveAs(this._UserProfile, activityDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityDispositionMaintMethod(activityDispositionMaint, ActivityDispositionMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ActivityDispositionMaint) null, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus SaveAs(ActivityDispositionMaint activityDispositionMaint)
    {
      return this.SaveAs(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus SaveAs(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      return this.SaveAs(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      result = (ActivityDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityDispositionMaintService) this._Channel).UnFreeze(this._UserProfile, activityDispositionMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityDispositionMaintMethod(activityDispositionMaint, ActivityDispositionMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) activityDispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ActivityDispositionMaint) null, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus UnFreeze(ActivityDispositionMaint activityDispositionMaint)
    {
      return this.UnFreeze(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      return this.UnFreeze(activityDispositionMaint, (ActivityDispositionMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetApprovalSheetTemplate(
      DCObject activityDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityDispositionMaint_Result result1;
        ResultStatus approvalSheetTemplate = this.GetApprovalSheetTemplate((ActivityDispositionMaint) activityDispositionMaint, (ActivityDispositionMaint_Parameters) parameters, (ActivityDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return approvalSheetTemplate;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadBusinessRules(
      DCObject activityDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityDispositionMaint_Result result1;
        ResultStatus resultStatus = this.LoadBusinessRules((ActivityDispositionMaint) activityDispositionMaint, (ActivityDispositionMaint_Parameters) parameters, (ActivityDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadChecklistTemplate(
      DCObject activityDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityDispositionMaint_Result result1;
        ResultStatus resultStatus = this.LoadChecklistTemplate((ActivityDispositionMaint) activityDispositionMaint, (ActivityDispositionMaint_Parameters) parameters, (ActivityDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadTemplate(
      DCObject activityDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityDispositionMaint_Result result1;
        ResultStatus resultStatus = this.LoadTemplate((ActivityDispositionMaint) activityDispositionMaint, (ActivityDispositionMaint_Parameters) parameters, (ActivityDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnPreviewChecklist(
      DCObject activityDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityDispositionMaint_Result result1;
        ResultStatus resultStatus = this.PreviewChecklist((ActivityDispositionMaint) activityDispositionMaint, (ActivityDispositionMaint_Parameters) parameters, (ActivityDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject activityDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityDispositionMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ActivityDispositionMaint) activityDispositionMaint, (ActivityDispositionMaint_Parameters) parameters, (ActivityDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject activityDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityDispositionMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ActivityDispositionMaint) activityDispositionMaint, (ActivityDispositionMaint_Parameters) parameters, (ActivityDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject activityDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityDispositionMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ActivityDispositionMaint) activityDispositionMaint, (ActivityDispositionMaint_LoadESigDetails_Parameters) parameters, (ActivityDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject activityDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityDispositionMaint_Result result1;
        ResultStatus resultStatus = this.New((ActivityDispositionMaint) activityDispositionMaint, (ActivityDispositionMaint_Parameters) parameters, (ActivityDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject activityDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityDispositionMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ActivityDispositionMaint) activityDispositionMaint, (ActivityDispositionMaint_Parameters) parameters, (ActivityDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject activityDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityDispositionMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ActivityDispositionMaint) activityDispositionMaint, (ActivityDispositionMaint_Parameters) parameters, (ActivityDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject activityDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityDispositionMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ActivityDispositionMaint) activityDispositionMaint, (ActivityDispositionMaint_Parameters) parameters, (ActivityDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject activityDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityDispositionMaint_Result result1;
        ResultStatus resultStatus = this.Load((ActivityDispositionMaint) activityDispositionMaint, (ActivityDispositionMaint_Parameters) parameters, (ActivityDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject activityDispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityDispositionMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ActivityDispositionMaint) activityDispositionMaint, (ActivityDispositionMaint_Parameters) parameters, (ActivityDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      result = (ActivityDispositionMaint_Result) null;
      try
      {
        ActivityDispositionMaintMethod[] methods = new ActivityDispositionMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IActivityDispositionMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ActivityDispositionMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ActivityDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActivityDispositionMaint cdo,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      result = (ActivityDispositionMaint_Result) null;
      try
      {
        return ((IActivityDispositionMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ActivityDispositionMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ActivityDispositionMaint) cdo, (ActivityDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      return this.GetEnvironment((ActivityDispositionMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ActivityDispositionMaint cdo,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      result = (ActivityDispositionMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityDispositionMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ActivityDispositionMaintMethod(cdo, ActivityDispositionMaintMethods.ExecuteTransaction, (ActivityDispositionMaint_Parameters) null));
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
        ActivityDispositionMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ActivityDispositionMaint) cdo, (ActivityDispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ActivityDispositionMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ActivityDispositionMaint_Request) null, out ActivityDispositionMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result)
    {
      return this.ExecuteTransaction((ActivityDispositionMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ActivityDispositionMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ActivityDispositionMaintMethod(cdo, ActivityDispositionMaintMethods.AddDataTransaction, (ActivityDispositionMaint_Parameters) null));
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
        return this.AddDataTransaction((ActivityDispositionMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
