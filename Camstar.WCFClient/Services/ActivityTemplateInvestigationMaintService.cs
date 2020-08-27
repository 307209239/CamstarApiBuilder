// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ActivityTemplateInvestigationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ActivityTemplateInvestigationMaintService : ActivityTemplateMaintBase
  {
    public ActivityTemplateInvestigationMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IActivityTemplateInvestigationMaintService), userProfile);
    }

    public ResultStatus Delete(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      result = (ActivityTemplateInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateInvestigationMaintService) this._Channel).Delete(this._UserProfile, activityTemplateInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateInvestigationMaintMethod(activityTemplateInvestigationMaint, ActivityTemplateInvestigationMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ActivityTemplateInvestigationMaint) null, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus Delete(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint)
    {
      return this.Delete(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus Delete(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      return this.Delete(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      result = (ActivityTemplateInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateInvestigationMaintService) this._Channel).Freeze(this._UserProfile, activityTemplateInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateInvestigationMaintMethod(activityTemplateInvestigationMaint, ActivityTemplateInvestigationMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ActivityTemplateInvestigationMaint) null, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus Freeze(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint)
    {
      return this.Freeze(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus Freeze(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      return this.Freeze(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      result = (ActivityTemplateInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateInvestigationMaintService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, activityTemplateInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateInvestigationMaintMethod(activityTemplateInvestigationMaint, ActivityTemplateInvestigationMaintMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((ActivityTemplateInvestigationMaint) null, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint)
    {
      return this.GetApprovalSheetTemplate(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      return this.GetApprovalSheetTemplate(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      result = (ActivityTemplateInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateInvestigationMaintService) this._Channel).GetWIPMsgs(this._UserProfile, activityTemplateInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateInvestigationMaintMethod(activityTemplateInvestigationMaint, ActivityTemplateInvestigationMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ActivityTemplateInvestigationMaint) null, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint)
    {
      return this.GetWIPMsgs(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      return this.GetWIPMsgs(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      result = (ActivityTemplateInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateInvestigationMaintService) this._Channel).Load(this._UserProfile, activityTemplateInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateInvestigationMaintMethod(activityTemplateInvestigationMaint, ActivityTemplateInvestigationMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ActivityTemplateInvestigationMaint) null, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus Load(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint)
    {
      return this.Load(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus Load(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      return this.Load(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadBusinessRules(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      result = (ActivityTemplateInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (LoadBusinessRules), (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateInvestigationMaintService) this._Channel).LoadBusinessRules(this._UserProfile, activityTemplateInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateInvestigationMaintMethod(activityTemplateInvestigationMaint, ActivityTemplateInvestigationMaintMethods.LoadBusinessRules, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadBusinessRules), res, (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadBusinessRules()
    {
      return this.LoadBusinessRules((ActivityTemplateInvestigationMaint) null, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint)
    {
      return this.LoadBusinessRules(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      return this.LoadBusinessRules(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadChecklistTemplate(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      result = (ActivityTemplateInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (LoadChecklistTemplate), (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateInvestigationMaintService) this._Channel).LoadChecklistTemplate(this._UserProfile, activityTemplateInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateInvestigationMaintMethod(activityTemplateInvestigationMaint, ActivityTemplateInvestigationMaintMethods.LoadChecklistTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadChecklistTemplate), res, (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadChecklistTemplate()
    {
      return this.LoadChecklistTemplate((ActivityTemplateInvestigationMaint) null, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint)
    {
      return this.LoadChecklistTemplate(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      return this.LoadChecklistTemplate(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_LoadESigDetails_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      result = (ActivityTemplateInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateInvestigationMaintService) this._Channel).LoadESigDetails(this._UserProfile, activityTemplateInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateInvestigationMaintMethod(activityTemplateInvestigationMaint, ActivityTemplateInvestigationMaintMethods.LoadESigDetails, (ActivityTemplateInvestigationMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ActivityTemplateInvestigationMaint) null, (ActivityTemplateInvestigationMaint_LoadESigDetails_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint)
    {
      return this.LoadESigDetails(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_LoadESigDetails_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      return this.LoadESigDetails(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      result = (ActivityTemplateInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateInvestigationMaintService) this._Channel).New(this._UserProfile, activityTemplateInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateInvestigationMaintMethod(activityTemplateInvestigationMaint, ActivityTemplateInvestigationMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ActivityTemplateInvestigationMaint) null, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus New(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint)
    {
      return this.New(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus New(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      return this.New(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      result = (ActivityTemplateInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateInvestigationMaintService) this._Channel).NewCopy(this._UserProfile, activityTemplateInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateInvestigationMaintMethod(activityTemplateInvestigationMaint, ActivityTemplateInvestigationMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ActivityTemplateInvestigationMaint) null, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus NewCopy(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint)
    {
      return this.NewCopy(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus NewCopy(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      return this.NewCopy(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus PreviewChecklist(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      result = (ActivityTemplateInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (PreviewChecklist), (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateInvestigationMaintService) this._Channel).PreviewChecklist(this._UserProfile, activityTemplateInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateInvestigationMaintMethod(activityTemplateInvestigationMaint, ActivityTemplateInvestigationMaintMethods.PreviewChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreviewChecklist), res, (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreviewChecklist()
    {
      return this.PreviewChecklist((ActivityTemplateInvestigationMaint) null, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint)
    {
      return this.PreviewChecklist(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      return this.PreviewChecklist(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      result = (ActivityTemplateInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateInvestigationMaintService) this._Channel).SaveAs(this._UserProfile, activityTemplateInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateInvestigationMaintMethod(activityTemplateInvestigationMaint, ActivityTemplateInvestigationMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ActivityTemplateInvestigationMaint) null, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus SaveAs(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint)
    {
      return this.SaveAs(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus SaveAs(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      return this.SaveAs(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      result = (ActivityTemplateInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateInvestigationMaintService) this._Channel).UnFreeze(this._UserProfile, activityTemplateInvestigationMaint, parameters, request, out result) : this.AddMethod((Method) new ActivityTemplateInvestigationMaintMethod(activityTemplateInvestigationMaint, ActivityTemplateInvestigationMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) activityTemplateInvestigationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ActivityTemplateInvestigationMaint) null, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint)
    {
      return this.UnFreeze(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      return this.UnFreeze(activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetApprovalSheetTemplate(
      DCObject activityTemplateInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateInvestigationMaint_Result result1;
        ResultStatus approvalSheetTemplate = this.GetApprovalSheetTemplate((ActivityTemplateInvestigationMaint) activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) parameters, (ActivityTemplateInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return approvalSheetTemplate;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadBusinessRules(
      DCObject activityTemplateInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.LoadBusinessRules((ActivityTemplateInvestigationMaint) activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) parameters, (ActivityTemplateInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadChecklistTemplate(
      DCObject activityTemplateInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.LoadChecklistTemplate((ActivityTemplateInvestigationMaint) activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) parameters, (ActivityTemplateInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnPreviewChecklist(
      DCObject activityTemplateInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.PreviewChecklist((ActivityTemplateInvestigationMaint) activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) parameters, (ActivityTemplateInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject activityTemplateInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ActivityTemplateInvestigationMaint) activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) parameters, (ActivityTemplateInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject activityTemplateInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ActivityTemplateInvestigationMaint) activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) parameters, (ActivityTemplateInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject activityTemplateInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ActivityTemplateInvestigationMaint) activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_LoadESigDetails_Parameters) parameters, (ActivityTemplateInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject activityTemplateInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.New((ActivityTemplateInvestigationMaint) activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) parameters, (ActivityTemplateInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject activityTemplateInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ActivityTemplateInvestigationMaint) activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) parameters, (ActivityTemplateInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject activityTemplateInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ActivityTemplateInvestigationMaint) activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) parameters, (ActivityTemplateInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject activityTemplateInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ActivityTemplateInvestigationMaint) activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) parameters, (ActivityTemplateInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject activityTemplateInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.Load((ActivityTemplateInvestigationMaint) activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) parameters, (ActivityTemplateInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject activityTemplateInvestigationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivityTemplateInvestigationMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ActivityTemplateInvestigationMaint) activityTemplateInvestigationMaint, (ActivityTemplateInvestigationMaint_Parameters) parameters, (ActivityTemplateInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      result = (ActivityTemplateInvestigationMaint_Result) null;
      try
      {
        ActivityTemplateInvestigationMaintMethod[] methods = new ActivityTemplateInvestigationMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IActivityTemplateInvestigationMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ActivityTemplateInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ActivityTemplateInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActivityTemplateInvestigationMaint cdo,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      result = (ActivityTemplateInvestigationMaint_Result) null;
      try
      {
        return ((IActivityTemplateInvestigationMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ActivityTemplateInvestigationMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ActivityTemplateInvestigationMaint) cdo, (ActivityTemplateInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      return this.GetEnvironment((ActivityTemplateInvestigationMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ActivityTemplateInvestigationMaint cdo,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      result = (ActivityTemplateInvestigationMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivityTemplateInvestigationMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ActivityTemplateInvestigationMaintMethod(cdo, ActivityTemplateInvestigationMaintMethods.ExecuteTransaction, (ActivityTemplateInvestigationMaint_Parameters) null));
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
        ActivityTemplateInvestigationMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ActivityTemplateInvestigationMaint) cdo, (ActivityTemplateInvestigationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ActivityTemplateInvestigationMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ActivityTemplateInvestigationMaint_Request) null, out ActivityTemplateInvestigationMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result)
    {
      return this.ExecuteTransaction((ActivityTemplateInvestigationMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ActivityTemplateInvestigationMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ActivityTemplateInvestigationMaintMethod(cdo, ActivityTemplateInvestigationMaintMethods.AddDataTransaction, (ActivityTemplateInvestigationMaint_Parameters) null));
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
        return this.AddDataTransaction((ActivityTemplateInvestigationMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
