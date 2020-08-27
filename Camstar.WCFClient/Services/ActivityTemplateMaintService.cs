// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ActivityTemplateMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ActivityTemplateMaintService : ProcessObjectTemplateMaintBase
  {
    public ActivityTemplateMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IActivityTemplateMaintService), userProfile);
    }

    public ResultStatus Delete(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Parameters parameters,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      result = (ActivityTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateMaintService) this._Channel).Delete(this._UserProfile, activityTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateMaintMethod(activityTemplateMaint, ActivityTemplateMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ActivityTemplateMaint) null, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus Delete(ActivityTemplateMaint activityTemplateMaint)
    {
      return this.Delete(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus Delete(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      return this.Delete(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Parameters parameters,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      result = (ActivityTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateMaintService) this._Channel).Freeze(this._UserProfile, activityTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateMaintMethod(activityTemplateMaint, ActivityTemplateMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ActivityTemplateMaint) null, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus Freeze(ActivityTemplateMaint activityTemplateMaint)
    {
      return this.Freeze(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus Freeze(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      return this.Freeze(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Parameters parameters,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      result = (ActivityTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateMaintService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, activityTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateMaintMethod(activityTemplateMaint, ActivityTemplateMaintMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((ActivityTemplateMaint) null, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ActivityTemplateMaint activityTemplateMaint)
    {
      return this.GetApprovalSheetTemplate(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      return this.GetApprovalSheetTemplate(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Parameters parameters,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      result = (ActivityTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateMaintService) this._Channel).GetWIPMsgs(this._UserProfile, activityTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateMaintMethod(activityTemplateMaint, ActivityTemplateMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ActivityTemplateMaint) null, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ActivityTemplateMaint activityTemplateMaint)
    {
      return this.GetWIPMsgs(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      return this.GetWIPMsgs(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Parameters parameters,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      result = (ActivityTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateMaintService) this._Channel).Load(this._UserProfile, activityTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateMaintMethod(activityTemplateMaint, ActivityTemplateMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ActivityTemplateMaint) null, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus Load(ActivityTemplateMaint activityTemplateMaint)
    {
      return this.Load(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus Load(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      return this.Load(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadBusinessRules(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Parameters parameters,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      result = (ActivityTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (LoadBusinessRules), (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateMaintService) this._Channel).LoadBusinessRules(this._UserProfile, activityTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateMaintMethod(activityTemplateMaint, ActivityTemplateMaintMethods.LoadBusinessRules, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadBusinessRules), res, (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadBusinessRules()
    {
      return this.LoadBusinessRules((ActivityTemplateMaint) null, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(ActivityTemplateMaint activityTemplateMaint)
    {
      return this.LoadBusinessRules(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      return this.LoadBusinessRules(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadChecklistTemplate(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Parameters parameters,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      result = (ActivityTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (LoadChecklistTemplate), (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateMaintService) this._Channel).LoadChecklistTemplate(this._UserProfile, activityTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateMaintMethod(activityTemplateMaint, ActivityTemplateMaintMethods.LoadChecklistTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadChecklistTemplate), res, (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadChecklistTemplate()
    {
      return this.LoadChecklistTemplate((ActivityTemplateMaint) null, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      ActivityTemplateMaint activityTemplateMaint)
    {
      return this.LoadChecklistTemplate(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      return this.LoadChecklistTemplate(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_LoadESigDetails_Parameters parameters,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      result = (ActivityTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateMaintService) this._Channel).LoadESigDetails(this._UserProfile, activityTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateMaintMethod(activityTemplateMaint, ActivityTemplateMaintMethods.LoadESigDetails, (ActivityTemplateMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ActivityTemplateMaint) null, (ActivityTemplateMaint_LoadESigDetails_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ActivityTemplateMaint activityTemplateMaint)
    {
      return this.LoadESigDetails(activityTemplateMaint, (ActivityTemplateMaint_LoadESigDetails_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      return this.LoadESigDetails(activityTemplateMaint, (ActivityTemplateMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Parameters parameters,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      result = (ActivityTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateMaintService) this._Channel).New(this._UserProfile, activityTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateMaintMethod(activityTemplateMaint, ActivityTemplateMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ActivityTemplateMaint) null, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus New(ActivityTemplateMaint activityTemplateMaint)
    {
      return this.New(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus New(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      return this.New(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Parameters parameters,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      result = (ActivityTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateMaintService) this._Channel).NewCopy(this._UserProfile, activityTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateMaintMethod(activityTemplateMaint, ActivityTemplateMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ActivityTemplateMaint) null, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(ActivityTemplateMaint activityTemplateMaint)
    {
      return this.NewCopy(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      return this.NewCopy(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus PreviewChecklist(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Parameters parameters,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      result = (ActivityTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (PreviewChecklist), (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateMaintService) this._Channel).PreviewChecklist(this._UserProfile, activityTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateMaintMethod(activityTemplateMaint, ActivityTemplateMaintMethods.PreviewChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreviewChecklist), res, (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreviewChecklist()
    {
      return this.PreviewChecklist((ActivityTemplateMaint) null, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus PreviewChecklist(ActivityTemplateMaint activityTemplateMaint)
    {
      return this.PreviewChecklist(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      return this.PreviewChecklist(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Parameters parameters,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      result = (ActivityTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateMaintService) this._Channel).SaveAs(this._UserProfile, activityTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateMaintMethod(activityTemplateMaint, ActivityTemplateMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ActivityTemplateMaint) null, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(ActivityTemplateMaint activityTemplateMaint)
    {
      return this.SaveAs(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      return this.SaveAs(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Parameters parameters,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      result = (ActivityTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateMaintService) this._Channel).UnFreeze(this._UserProfile, activityTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateMaintMethod(activityTemplateMaint, ActivityTemplateMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) activityTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ActivityTemplateMaint) null, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(ActivityTemplateMaint activityTemplateMaint)
    {
      return this.UnFreeze(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ActivityTemplateMaint activityTemplateMaint,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      return this.UnFreeze(activityTemplateMaint, (ActivityTemplateMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetApprovalSheetTemplate(
      DCObject activityTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateMaint_Result result1;
        ResultStatus approvalSheetTemplate = this.GetApprovalSheetTemplate((ActivityTemplateMaint) activityTemplateMaint, (ActivityTemplateMaint_Parameters) parameters, (ActivityTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return approvalSheetTemplate;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadBusinessRules(
      DCObject activityTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateMaint_Result result1;
        ResultStatus resultStatus = this.LoadBusinessRules((ActivityTemplateMaint) activityTemplateMaint, (ActivityTemplateMaint_Parameters) parameters, (ActivityTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadChecklistTemplate(
      DCObject activityTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateMaint_Result result1;
        ResultStatus resultStatus = this.LoadChecklistTemplate((ActivityTemplateMaint) activityTemplateMaint, (ActivityTemplateMaint_Parameters) parameters, (ActivityTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnPreviewChecklist(
      DCObject activityTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateMaint_Result result1;
        ResultStatus resultStatus = this.PreviewChecklist((ActivityTemplateMaint) activityTemplateMaint, (ActivityTemplateMaint_Parameters) parameters, (ActivityTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject activityTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ActivityTemplateMaint) activityTemplateMaint, (ActivityTemplateMaint_Parameters) parameters, (ActivityTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject activityTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ActivityTemplateMaint) activityTemplateMaint, (ActivityTemplateMaint_Parameters) parameters, (ActivityTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject activityTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ActivityTemplateMaint) activityTemplateMaint, (ActivityTemplateMaint_LoadESigDetails_Parameters) parameters, (ActivityTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject activityTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateMaint_Result result1;
        ResultStatus resultStatus = this.New((ActivityTemplateMaint) activityTemplateMaint, (ActivityTemplateMaint_Parameters) parameters, (ActivityTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject activityTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ActivityTemplateMaint) activityTemplateMaint, (ActivityTemplateMaint_Parameters) parameters, (ActivityTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject activityTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ActivityTemplateMaint) activityTemplateMaint, (ActivityTemplateMaint_Parameters) parameters, (ActivityTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject activityTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ActivityTemplateMaint) activityTemplateMaint, (ActivityTemplateMaint_Parameters) parameters, (ActivityTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject activityTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Load((ActivityTemplateMaint) activityTemplateMaint, (ActivityTemplateMaint_Parameters) parameters, (ActivityTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject activityTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ActivityTemplateMaint) activityTemplateMaint, (ActivityTemplateMaint_Parameters) parameters, (ActivityTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      result = (ActivityTemplateMaint_Result) null;
      try
      {
        ActivityTemplateMaintMethod[] methods = new ActivityTemplateMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IActivityTemplateMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ActivityTemplateMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ActivityTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActivityTemplateMaint cdo,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      result = (ActivityTemplateMaint_Result) null;
      try
      {
        return ((IActivityTemplateMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ActivityTemplateMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ActivityTemplateMaint) cdo, (ActivityTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      return this.GetEnvironment((ActivityTemplateMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ActivityTemplateMaint cdo,
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      result = (ActivityTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ActivityTemplateMaintMethod(cdo, ActivityTemplateMaintMethods.ExecuteTransaction, (ActivityTemplateMaint_Parameters) null));
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
        ActivityTemplateMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ActivityTemplateMaint) cdo, (ActivityTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ActivityTemplateMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ActivityTemplateMaint_Request) null, out ActivityTemplateMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ActivityTemplateMaint_Request request,
      out ActivityTemplateMaint_Result result)
    {
      return this.ExecuteTransaction((ActivityTemplateMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ActivityTemplateMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ActivityTemplateMaintMethod(cdo, ActivityTemplateMaintMethods.AddDataTransaction, (ActivityTemplateMaint_Parameters) null));
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
        return this.AddDataTransaction((ActivityTemplateMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
