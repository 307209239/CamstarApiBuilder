// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ActivityInvestigationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ActivityInvestigationMaintService : ActivityMaintBase
  {
    public ActivityInvestigationMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IActivityInvestigationMaintService), userProfile);
    }

    public ResultStatus Delete(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      result = (ActivityInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityInvestigationMaintService) this._Channel).Delete(this._UserProfile, activityInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityInvestigationMaintMethod(activityInvestigationMaint, ActivityInvestigationMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ActivityInvestigationMaint) null, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus Delete(
      ActivityInvestigationMaint activityInvestigationMaint)
    {
      return this.Delete(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus Delete(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      return this.Delete(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      result = (ActivityInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityInvestigationMaintService) this._Channel).Freeze(this._UserProfile, activityInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityInvestigationMaintMethod(activityInvestigationMaint, ActivityInvestigationMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ActivityInvestigationMaint) null, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus Freeze(
      ActivityInvestigationMaint activityInvestigationMaint)
    {
      return this.Freeze(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus Freeze(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      return this.Freeze(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      result = (ActivityInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityInvestigationMaintService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, activityInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityInvestigationMaintMethod(activityInvestigationMaint, ActivityInvestigationMaintMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((ActivityInvestigationMaint) null, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ActivityInvestigationMaint activityInvestigationMaint)
    {
      return this.GetApprovalSheetTemplate(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      return this.GetApprovalSheetTemplate(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      result = (ActivityInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityInvestigationMaintService) this._Channel).GetWIPMsgs(this._UserProfile, activityInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityInvestigationMaintMethod(activityInvestigationMaint, ActivityInvestigationMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ActivityInvestigationMaint) null, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ActivityInvestigationMaint activityInvestigationMaint)
    {
      return this.GetWIPMsgs(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      return this.GetWIPMsgs(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      result = (ActivityInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityInvestigationMaintService) this._Channel).Load(this._UserProfile, activityInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityInvestigationMaintMethod(activityInvestigationMaint, ActivityInvestigationMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ActivityInvestigationMaint) null, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus Load(
      ActivityInvestigationMaint activityInvestigationMaint)
    {
      return this.Load(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus Load(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      return this.Load(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadBusinessRules(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      result = (ActivityInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (LoadBusinessRules), (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityInvestigationMaintService) this._Channel).LoadBusinessRules(this._UserProfile, activityInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityInvestigationMaintMethod(activityInvestigationMaint, ActivityInvestigationMaintMethods.LoadBusinessRules, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadBusinessRules), res, (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadBusinessRules()
    {
      return this.LoadBusinessRules((ActivityInvestigationMaint) null, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      ActivityInvestigationMaint activityInvestigationMaint)
    {
      return this.LoadBusinessRules(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      return this.LoadBusinessRules(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadChecklistTemplate(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      result = (ActivityInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (LoadChecklistTemplate), (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityInvestigationMaintService) this._Channel).LoadChecklistTemplate(this._UserProfile, activityInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityInvestigationMaintMethod(activityInvestigationMaint, ActivityInvestigationMaintMethods.LoadChecklistTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadChecklistTemplate), res, (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadChecklistTemplate()
    {
      return this.LoadChecklistTemplate((ActivityInvestigationMaint) null, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      ActivityInvestigationMaint activityInvestigationMaint)
    {
      return this.LoadChecklistTemplate(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      return this.LoadChecklistTemplate(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_LoadESigDetails_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      result = (ActivityInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityInvestigationMaintService) this._Channel).LoadESigDetails(this._UserProfile, activityInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityInvestigationMaintMethod(activityInvestigationMaint, ActivityInvestigationMaintMethods.LoadESigDetails, (ActivityInvestigationMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ActivityInvestigationMaint) null, (ActivityInvestigationMaint_LoadESigDetails_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ActivityInvestigationMaint activityInvestigationMaint)
    {
      return this.LoadESigDetails(activityInvestigationMaint, (ActivityInvestigationMaint_LoadESigDetails_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      return this.LoadESigDetails(activityInvestigationMaint, (ActivityInvestigationMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus LoadTemplate(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      result = (ActivityInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (LoadTemplate), (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityInvestigationMaintService) this._Channel).LoadTemplate(this._UserProfile, activityInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityInvestigationMaintMethod(activityInvestigationMaint, ActivityInvestigationMaintMethods.LoadTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadTemplate), res, (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadTemplate()
    {
      return this.LoadTemplate((ActivityInvestigationMaint) null, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus LoadTemplate(
      ActivityInvestigationMaint activityInvestigationMaint)
    {
      return this.LoadTemplate(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus LoadTemplate(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      return this.LoadTemplate(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      result = (ActivityInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityInvestigationMaintService) this._Channel).New(this._UserProfile, activityInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityInvestigationMaintMethod(activityInvestigationMaint, ActivityInvestigationMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ActivityInvestigationMaint) null, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus New(
      ActivityInvestigationMaint activityInvestigationMaint)
    {
      return this.New(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus New(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      return this.New(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      result = (ActivityInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityInvestigationMaintService) this._Channel).NewCopy(this._UserProfile, activityInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityInvestigationMaintMethod(activityInvestigationMaint, ActivityInvestigationMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ActivityInvestigationMaint) null, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus NewCopy(
      ActivityInvestigationMaint activityInvestigationMaint)
    {
      return this.NewCopy(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus NewCopy(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      return this.NewCopy(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus PreviewChecklist(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      result = (ActivityInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (PreviewChecklist), (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityInvestigationMaintService) this._Channel).PreviewChecklist(this._UserProfile, activityInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityInvestigationMaintMethod(activityInvestigationMaint, ActivityInvestigationMaintMethods.PreviewChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreviewChecklist), res, (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreviewChecklist()
    {
      return this.PreviewChecklist((ActivityInvestigationMaint) null, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      ActivityInvestigationMaint activityInvestigationMaint)
    {
      return this.PreviewChecklist(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      return this.PreviewChecklist(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      result = (ActivityInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityInvestigationMaintService) this._Channel).SaveAs(this._UserProfile, activityInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityInvestigationMaintMethod(activityInvestigationMaint, ActivityInvestigationMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ActivityInvestigationMaint) null, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus SaveAs(
      ActivityInvestigationMaint activityInvestigationMaint)
    {
      return this.SaveAs(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus SaveAs(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      return this.SaveAs(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      result = (ActivityInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityInvestigationMaintService) this._Channel).UnFreeze(this._UserProfile, activityInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityInvestigationMaintMethod(activityInvestigationMaint, ActivityInvestigationMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) activityInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ActivityInvestigationMaint) null, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ActivityInvestigationMaint activityInvestigationMaint)
    {
      return this.UnFreeze(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      return this.UnFreeze(activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetApprovalSheetTemplate(
      DCObject activityInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityInvestigationMaint_Result result1;
        ResultStatus approvalSheetTemplate = this.GetApprovalSheetTemplate((ActivityInvestigationMaint) activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) parameters, (ActivityInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return approvalSheetTemplate;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadBusinessRules(
      DCObject activityInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.LoadBusinessRules((ActivityInvestigationMaint) activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) parameters, (ActivityInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadChecklistTemplate(
      DCObject activityInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.LoadChecklistTemplate((ActivityInvestigationMaint) activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) parameters, (ActivityInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadTemplate(
      DCObject activityInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.LoadTemplate((ActivityInvestigationMaint) activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) parameters, (ActivityInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnPreviewChecklist(
      DCObject activityInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.PreviewChecklist((ActivityInvestigationMaint) activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) parameters, (ActivityInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject activityInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ActivityInvestigationMaint) activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) parameters, (ActivityInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject activityInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ActivityInvestigationMaint) activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) parameters, (ActivityInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject activityInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ActivityInvestigationMaint) activityInvestigationMaint, (ActivityInvestigationMaint_LoadESigDetails_Parameters) parameters, (ActivityInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject activityInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.New((ActivityInvestigationMaint) activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) parameters, (ActivityInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject activityInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ActivityInvestigationMaint) activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) parameters, (ActivityInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject activityInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ActivityInvestigationMaint) activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) parameters, (ActivityInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject activityInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ActivityInvestigationMaint) activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) parameters, (ActivityInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject activityInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.Load((ActivityInvestigationMaint) activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) parameters, (ActivityInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject activityInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityInvestigationMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ActivityInvestigationMaint) activityInvestigationMaint, (ActivityInvestigationMaint_Parameters) parameters, (ActivityInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      result = (ActivityInvestigationMaint_Result) null;
      try
      {
        ActivityInvestigationMaintMethod[] methods = new ActivityInvestigationMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IActivityInvestigationMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ActivityInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ActivityInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActivityInvestigationMaint cdo,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      result = (ActivityInvestigationMaint_Result) null;
      try
      {
        return ((IActivityInvestigationMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ActivityInvestigationMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ActivityInvestigationMaint) cdo, (ActivityInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      return this.GetEnvironment((ActivityInvestigationMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ActivityInvestigationMaint cdo,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      result = (ActivityInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityInvestigationMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ActivityInvestigationMaintMethod(cdo, ActivityInvestigationMaintMethods.ExecuteTransaction, (ActivityInvestigationMaint_Parameters) null));
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
        ActivityInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ActivityInvestigationMaint) cdo, (ActivityInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ActivityInvestigationMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ActivityInvestigationMaint_Request) null, out ActivityInvestigationMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result)
    {
      return this.ExecuteTransaction((ActivityInvestigationMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ActivityInvestigationMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ActivityInvestigationMaintMethod(cdo, ActivityInvestigationMaintMethods.AddDataTransaction, (ActivityInvestigationMaint_Parameters) null));
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
        return this.AddDataTransaction((ActivityInvestigationMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
