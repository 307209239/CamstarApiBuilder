// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ActivityMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ActivityMaintService : ProcessObjectMaintBase
  {
    public ActivityMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IActivityMaintService), userProfile);
    }

    public ResultStatus Delete(
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      result = (ActivityMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) activityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityMaintService) this._Channel).Delete(this._UserProfile, activityMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityMaintMethod(activityMaint, ActivityMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) activityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ActivityMaint) null, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus Delete(ActivityMaint activityMaint)
    {
      return this.Delete(activityMaint, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus Delete(
      ActivityMaint activityMaint,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      return this.Delete(activityMaint, (ActivityMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      result = (ActivityMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) activityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityMaintService) this._Channel).Freeze(this._UserProfile, activityMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityMaintMethod(activityMaint, ActivityMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) activityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ActivityMaint) null, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus Freeze(ActivityMaint activityMaint)
    {
      return this.Freeze(activityMaint, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus Freeze(
      ActivityMaint activityMaint,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      return this.Freeze(activityMaint, (ActivityMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      result = (ActivityMaint_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) activityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityMaintService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, activityMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityMaintMethod(activityMaint, ActivityMaintMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) activityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((ActivityMaint) null, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(ActivityMaint activityMaint)
    {
      return this.GetApprovalSheetTemplate(activityMaint, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ActivityMaint activityMaint,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      return this.GetApprovalSheetTemplate(activityMaint, (ActivityMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      result = (ActivityMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) activityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityMaintService) this._Channel).GetWIPMsgs(this._UserProfile, activityMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityMaintMethod(activityMaint, ActivityMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) activityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ActivityMaint) null, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ActivityMaint activityMaint)
    {
      return this.GetWIPMsgs(activityMaint, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ActivityMaint activityMaint,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      return this.GetWIPMsgs(activityMaint, (ActivityMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      result = (ActivityMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) activityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityMaintService) this._Channel).Load(this._UserProfile, activityMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityMaintMethod(activityMaint, ActivityMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) activityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ActivityMaint) null, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus Load(ActivityMaint activityMaint)
    {
      return this.Load(activityMaint, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus Load(
      ActivityMaint activityMaint,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      return this.Load(activityMaint, (ActivityMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadBusinessRules(
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      result = (ActivityMaint_Result) null;
      this.OnBeforeCall(nameof (LoadBusinessRules), (DCObject) activityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityMaintService) this._Channel).LoadBusinessRules(this._UserProfile, activityMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityMaintMethod(activityMaint, ActivityMaintMethods.LoadBusinessRules, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadBusinessRules), res, (DCObject) activityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadBusinessRules()
    {
      return this.LoadBusinessRules((ActivityMaint) null, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(ActivityMaint activityMaint)
    {
      return this.LoadBusinessRules(activityMaint, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      ActivityMaint activityMaint,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      return this.LoadBusinessRules(activityMaint, (ActivityMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadChecklistTemplate(
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      result = (ActivityMaint_Result) null;
      this.OnBeforeCall(nameof (LoadChecklistTemplate), (DCObject) activityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityMaintService) this._Channel).LoadChecklistTemplate(this._UserProfile, activityMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityMaintMethod(activityMaint, ActivityMaintMethods.LoadChecklistTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadChecklistTemplate), res, (DCObject) activityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadChecklistTemplate()
    {
      return this.LoadChecklistTemplate((ActivityMaint) null, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(ActivityMaint activityMaint)
    {
      return this.LoadChecklistTemplate(activityMaint, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      ActivityMaint activityMaint,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      return this.LoadChecklistTemplate(activityMaint, (ActivityMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ActivityMaint activityMaint,
      ActivityMaint_LoadESigDetails_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      result = (ActivityMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) activityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityMaintService) this._Channel).LoadESigDetails(this._UserProfile, activityMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityMaintMethod(activityMaint, ActivityMaintMethods.LoadESigDetails, (ActivityMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) activityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ActivityMaint) null, (ActivityMaint_LoadESigDetails_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ActivityMaint activityMaint)
    {
      return this.LoadESigDetails(activityMaint, (ActivityMaint_LoadESigDetails_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ActivityMaint activityMaint,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      return this.LoadESigDetails(activityMaint, (ActivityMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus LoadTemplate(
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      result = (ActivityMaint_Result) null;
      this.OnBeforeCall(nameof (LoadTemplate), (DCObject) activityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityMaintService) this._Channel).LoadTemplate(this._UserProfile, activityMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityMaintMethod(activityMaint, ActivityMaintMethods.LoadTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadTemplate), res, (DCObject) activityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadTemplate()
    {
      return this.LoadTemplate((ActivityMaint) null, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus LoadTemplate(ActivityMaint activityMaint)
    {
      return this.LoadTemplate(activityMaint, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus LoadTemplate(
      ActivityMaint activityMaint,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      return this.LoadTemplate(activityMaint, (ActivityMaint_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      result = (ActivityMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) activityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityMaintService) this._Channel).New(this._UserProfile, activityMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityMaintMethod(activityMaint, ActivityMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) activityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ActivityMaint) null, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus New(ActivityMaint activityMaint)
    {
      return this.New(activityMaint, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus New(
      ActivityMaint activityMaint,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      return this.New(activityMaint, (ActivityMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      result = (ActivityMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) activityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityMaintService) this._Channel).NewCopy(this._UserProfile, activityMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityMaintMethod(activityMaint, ActivityMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) activityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ActivityMaint) null, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus NewCopy(ActivityMaint activityMaint)
    {
      return this.NewCopy(activityMaint, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus NewCopy(
      ActivityMaint activityMaint,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      return this.NewCopy(activityMaint, (ActivityMaint_Parameters) null, request, out result);
    }

    public ResultStatus PreviewChecklist(
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      result = (ActivityMaint_Result) null;
      this.OnBeforeCall(nameof (PreviewChecklist), (DCObject) activityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityMaintService) this._Channel).PreviewChecklist(this._UserProfile, activityMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityMaintMethod(activityMaint, ActivityMaintMethods.PreviewChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreviewChecklist), res, (DCObject) activityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreviewChecklist()
    {
      return this.PreviewChecklist((ActivityMaint) null, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus PreviewChecklist(ActivityMaint activityMaint)
    {
      return this.PreviewChecklist(activityMaint, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      ActivityMaint activityMaint,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      return this.PreviewChecklist(activityMaint, (ActivityMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      result = (ActivityMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) activityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityMaintService) this._Channel).SaveAs(this._UserProfile, activityMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityMaintMethod(activityMaint, ActivityMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) activityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ActivityMaint) null, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus SaveAs(ActivityMaint activityMaint)
    {
      return this.SaveAs(activityMaint, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus SaveAs(
      ActivityMaint activityMaint,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      return this.SaveAs(activityMaint, (ActivityMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      result = (ActivityMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) activityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityMaintService) this._Channel).UnFreeze(this._UserProfile, activityMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityMaintMethod(activityMaint, ActivityMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) activityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ActivityMaint) null, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus UnFreeze(ActivityMaint activityMaint)
    {
      return this.UnFreeze(activityMaint, (ActivityMaint_Parameters) null, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ActivityMaint activityMaint,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      return this.UnFreeze(activityMaint, (ActivityMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetApprovalSheetTemplate(
      DCObject activityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityMaint_Result result1;
        ResultStatus approvalSheetTemplate = this.GetApprovalSheetTemplate((ActivityMaint) activityMaint, (ActivityMaint_Parameters) parameters, (ActivityMaint_Request) request, out result1);
        result = (Result) result1;
        return approvalSheetTemplate;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadBusinessRules(
      DCObject activityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityMaint_Result result1;
        ResultStatus resultStatus = this.LoadBusinessRules((ActivityMaint) activityMaint, (ActivityMaint_Parameters) parameters, (ActivityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadChecklistTemplate(
      DCObject activityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityMaint_Result result1;
        ResultStatus resultStatus = this.LoadChecklistTemplate((ActivityMaint) activityMaint, (ActivityMaint_Parameters) parameters, (ActivityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadTemplate(
      DCObject activityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityMaint_Result result1;
        ResultStatus resultStatus = this.LoadTemplate((ActivityMaint) activityMaint, (ActivityMaint_Parameters) parameters, (ActivityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnPreviewChecklist(
      DCObject activityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityMaint_Result result1;
        ResultStatus resultStatus = this.PreviewChecklist((ActivityMaint) activityMaint, (ActivityMaint_Parameters) parameters, (ActivityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject activityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ActivityMaint) activityMaint, (ActivityMaint_Parameters) parameters, (ActivityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject activityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ActivityMaint) activityMaint, (ActivityMaint_Parameters) parameters, (ActivityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject activityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ActivityMaint) activityMaint, (ActivityMaint_LoadESigDetails_Parameters) parameters, (ActivityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject activityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityMaint_Result result1;
        ResultStatus resultStatus = this.New((ActivityMaint) activityMaint, (ActivityMaint_Parameters) parameters, (ActivityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject activityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ActivityMaint) activityMaint, (ActivityMaint_Parameters) parameters, (ActivityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject activityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ActivityMaint) activityMaint, (ActivityMaint_Parameters) parameters, (ActivityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject activityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ActivityMaint) activityMaint, (ActivityMaint_Parameters) parameters, (ActivityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject activityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityMaint_Result result1;
        ResultStatus resultStatus = this.Load((ActivityMaint) activityMaint, (ActivityMaint_Parameters) parameters, (ActivityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject activityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ActivityMaint) activityMaint, (ActivityMaint_Parameters) parameters, (ActivityMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      result = (ActivityMaint_Result) null;
      try
      {
        ActivityMaintMethod[] methods = new ActivityMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IActivityMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ActivityMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ActivityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActivityMaint cdo,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      result = (ActivityMaint_Result) null;
      try
      {
        return ((IActivityMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ActivityMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ActivityMaint) cdo, (ActivityMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      return this.GetEnvironment((ActivityMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ActivityMaint cdo,
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      result = (ActivityMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ActivityMaintMethod(cdo, ActivityMaintMethods.ExecuteTransaction, (ActivityMaint_Parameters) null));
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
        ActivityMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ActivityMaint) cdo, (ActivityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ActivityMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ActivityMaint_Request) null, out ActivityMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ActivityMaint_Request request,
      out ActivityMaint_Result result)
    {
      return this.ExecuteTransaction((ActivityMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ActivityMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ActivityMaintMethod(cdo, ActivityMaintMethods.AddDataTransaction, (ActivityMaint_Parameters) null));
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
        return this.AddDataTransaction((ActivityMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
