// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ActivityTmpltDispMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ActivityTmpltDispMaintService : ActivityTemplateMaintBase
  {
    public ActivityTmpltDispMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IActivityTmpltDispMaintService), userProfile);
    }

    public ResultStatus Delete(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      result = (ActivityTmpltDispMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTmpltDispMaintService) this._Channel).Delete(this._UserProfile, activityTmpltDispMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTmpltDispMaintMethod(activityTmpltDispMaint, ActivityTmpltDispMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ActivityTmpltDispMaint) null, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus Delete(ActivityTmpltDispMaint activityTmpltDispMaint)
    {
      return this.Delete(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus Delete(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      return this.Delete(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      result = (ActivityTmpltDispMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTmpltDispMaintService) this._Channel).Freeze(this._UserProfile, activityTmpltDispMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTmpltDispMaintMethod(activityTmpltDispMaint, ActivityTmpltDispMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ActivityTmpltDispMaint) null, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus Freeze(ActivityTmpltDispMaint activityTmpltDispMaint)
    {
      return this.Freeze(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus Freeze(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      return this.Freeze(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      result = (ActivityTmpltDispMaint_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTmpltDispMaintService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, activityTmpltDispMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTmpltDispMaintMethod(activityTmpltDispMaint, ActivityTmpltDispMaintMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((ActivityTmpltDispMaint) null, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ActivityTmpltDispMaint activityTmpltDispMaint)
    {
      return this.GetApprovalSheetTemplate(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      return this.GetApprovalSheetTemplate(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      result = (ActivityTmpltDispMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTmpltDispMaintService) this._Channel).GetWIPMsgs(this._UserProfile, activityTmpltDispMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTmpltDispMaintMethod(activityTmpltDispMaint, ActivityTmpltDispMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ActivityTmpltDispMaint) null, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ActivityTmpltDispMaint activityTmpltDispMaint)
    {
      return this.GetWIPMsgs(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      return this.GetWIPMsgs(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      result = (ActivityTmpltDispMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTmpltDispMaintService) this._Channel).Load(this._UserProfile, activityTmpltDispMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTmpltDispMaintMethod(activityTmpltDispMaint, ActivityTmpltDispMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ActivityTmpltDispMaint) null, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus Load(ActivityTmpltDispMaint activityTmpltDispMaint)
    {
      return this.Load(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus Load(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      return this.Load(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadBusinessRules(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      result = (ActivityTmpltDispMaint_Result) null;
      this.OnBeforeCall(nameof (LoadBusinessRules), (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTmpltDispMaintService) this._Channel).LoadBusinessRules(this._UserProfile, activityTmpltDispMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTmpltDispMaintMethod(activityTmpltDispMaint, ActivityTmpltDispMaintMethods.LoadBusinessRules, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadBusinessRules), res, (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadBusinessRules()
    {
      return this.LoadBusinessRules((ActivityTmpltDispMaint) null, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(ActivityTmpltDispMaint activityTmpltDispMaint)
    {
      return this.LoadBusinessRules(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      return this.LoadBusinessRules(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadChecklistTemplate(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      result = (ActivityTmpltDispMaint_Result) null;
      this.OnBeforeCall(nameof (LoadChecklistTemplate), (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTmpltDispMaintService) this._Channel).LoadChecklistTemplate(this._UserProfile, activityTmpltDispMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTmpltDispMaintMethod(activityTmpltDispMaint, ActivityTmpltDispMaintMethods.LoadChecklistTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadChecklistTemplate), res, (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadChecklistTemplate()
    {
      return this.LoadChecklistTemplate((ActivityTmpltDispMaint) null, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      ActivityTmpltDispMaint activityTmpltDispMaint)
    {
      return this.LoadChecklistTemplate(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      return this.LoadChecklistTemplate(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_LoadESigDetails_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      result = (ActivityTmpltDispMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTmpltDispMaintService) this._Channel).LoadESigDetails(this._UserProfile, activityTmpltDispMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTmpltDispMaintMethod(activityTmpltDispMaint, ActivityTmpltDispMaintMethods.LoadESigDetails, (ActivityTmpltDispMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ActivityTmpltDispMaint) null, (ActivityTmpltDispMaint_LoadESigDetails_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ActivityTmpltDispMaint activityTmpltDispMaint)
    {
      return this.LoadESigDetails(activityTmpltDispMaint, (ActivityTmpltDispMaint_LoadESigDetails_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      return this.LoadESigDetails(activityTmpltDispMaint, (ActivityTmpltDispMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      result = (ActivityTmpltDispMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTmpltDispMaintService) this._Channel).New(this._UserProfile, activityTmpltDispMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTmpltDispMaintMethod(activityTmpltDispMaint, ActivityTmpltDispMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ActivityTmpltDispMaint) null, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus New(ActivityTmpltDispMaint activityTmpltDispMaint)
    {
      return this.New(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus New(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      return this.New(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      result = (ActivityTmpltDispMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTmpltDispMaintService) this._Channel).NewCopy(this._UserProfile, activityTmpltDispMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTmpltDispMaintMethod(activityTmpltDispMaint, ActivityTmpltDispMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ActivityTmpltDispMaint) null, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus NewCopy(ActivityTmpltDispMaint activityTmpltDispMaint)
    {
      return this.NewCopy(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus NewCopy(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      return this.NewCopy(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, request, out result);
    }

    public ResultStatus PreviewChecklist(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      result = (ActivityTmpltDispMaint_Result) null;
      this.OnBeforeCall(nameof (PreviewChecklist), (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTmpltDispMaintService) this._Channel).PreviewChecklist(this._UserProfile, activityTmpltDispMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTmpltDispMaintMethod(activityTmpltDispMaint, ActivityTmpltDispMaintMethods.PreviewChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreviewChecklist), res, (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreviewChecklist()
    {
      return this.PreviewChecklist((ActivityTmpltDispMaint) null, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus PreviewChecklist(ActivityTmpltDispMaint activityTmpltDispMaint)
    {
      return this.PreviewChecklist(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      return this.PreviewChecklist(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      result = (ActivityTmpltDispMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTmpltDispMaintService) this._Channel).SaveAs(this._UserProfile, activityTmpltDispMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTmpltDispMaintMethod(activityTmpltDispMaint, ActivityTmpltDispMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ActivityTmpltDispMaint) null, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus SaveAs(ActivityTmpltDispMaint activityTmpltDispMaint)
    {
      return this.SaveAs(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus SaveAs(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      return this.SaveAs(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      result = (ActivityTmpltDispMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTmpltDispMaintService) this._Channel).UnFreeze(this._UserProfile, activityTmpltDispMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTmpltDispMaintMethod(activityTmpltDispMaint, ActivityTmpltDispMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) activityTmpltDispMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ActivityTmpltDispMaint) null, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus UnFreeze(ActivityTmpltDispMaint activityTmpltDispMaint)
    {
      return this.UnFreeze(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      return this.UnFreeze(activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetApprovalSheetTemplate(
      DCObject activityTmpltDispMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTmpltDispMaint_Result result1;
        ResultStatus approvalSheetTemplate = this.GetApprovalSheetTemplate((ActivityTmpltDispMaint) activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) parameters, (ActivityTmpltDispMaint_Request) request, out result1);
        result = (Result) result1;
        return approvalSheetTemplate;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadBusinessRules(
      DCObject activityTmpltDispMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTmpltDispMaint_Result result1;
        ResultStatus resultStatus = this.LoadBusinessRules((ActivityTmpltDispMaint) activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) parameters, (ActivityTmpltDispMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadChecklistTemplate(
      DCObject activityTmpltDispMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTmpltDispMaint_Result result1;
        ResultStatus resultStatus = this.LoadChecklistTemplate((ActivityTmpltDispMaint) activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) parameters, (ActivityTmpltDispMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnPreviewChecklist(
      DCObject activityTmpltDispMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTmpltDispMaint_Result result1;
        ResultStatus resultStatus = this.PreviewChecklist((ActivityTmpltDispMaint) activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) parameters, (ActivityTmpltDispMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject activityTmpltDispMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTmpltDispMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ActivityTmpltDispMaint) activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) parameters, (ActivityTmpltDispMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject activityTmpltDispMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTmpltDispMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ActivityTmpltDispMaint) activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) parameters, (ActivityTmpltDispMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject activityTmpltDispMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTmpltDispMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ActivityTmpltDispMaint) activityTmpltDispMaint, (ActivityTmpltDispMaint_LoadESigDetails_Parameters) parameters, (ActivityTmpltDispMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject activityTmpltDispMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTmpltDispMaint_Result result1;
        ResultStatus resultStatus = this.New((ActivityTmpltDispMaint) activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) parameters, (ActivityTmpltDispMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject activityTmpltDispMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTmpltDispMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ActivityTmpltDispMaint) activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) parameters, (ActivityTmpltDispMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject activityTmpltDispMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTmpltDispMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ActivityTmpltDispMaint) activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) parameters, (ActivityTmpltDispMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject activityTmpltDispMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTmpltDispMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ActivityTmpltDispMaint) activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) parameters, (ActivityTmpltDispMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject activityTmpltDispMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTmpltDispMaint_Result result1;
        ResultStatus resultStatus = this.Load((ActivityTmpltDispMaint) activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) parameters, (ActivityTmpltDispMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject activityTmpltDispMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTmpltDispMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ActivityTmpltDispMaint) activityTmpltDispMaint, (ActivityTmpltDispMaint_Parameters) parameters, (ActivityTmpltDispMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      result = (ActivityTmpltDispMaint_Result) null;
      try
      {
        ActivityTmpltDispMaintMethod[] methods = new ActivityTmpltDispMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IActivityTmpltDispMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ActivityTmpltDispMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ActivityTmpltDispMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActivityTmpltDispMaint cdo,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      result = (ActivityTmpltDispMaint_Result) null;
      try
      {
        return ((IActivityTmpltDispMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ActivityTmpltDispMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ActivityTmpltDispMaint) cdo, (ActivityTmpltDispMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      return this.GetEnvironment((ActivityTmpltDispMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ActivityTmpltDispMaint cdo,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      result = (ActivityTmpltDispMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTmpltDispMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ActivityTmpltDispMaintMethod(cdo, ActivityTmpltDispMaintMethods.ExecuteTransaction, (ActivityTmpltDispMaint_Parameters) null));
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
        ActivityTmpltDispMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ActivityTmpltDispMaint) cdo, (ActivityTmpltDispMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ActivityTmpltDispMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ActivityTmpltDispMaint_Request) null, out ActivityTmpltDispMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result)
    {
      return this.ExecuteTransaction((ActivityTmpltDispMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ActivityTmpltDispMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ActivityTmpltDispMaintMethod(cdo, ActivityTmpltDispMaintMethods.AddDataTransaction, (ActivityTmpltDispMaint_Parameters) null));
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
        return this.AddDataTransaction((ActivityTmpltDispMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
