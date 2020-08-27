// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChecklistTemplateMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ChecklistTemplateMaintService : RevisionedObjectMaintBase
  {
    public ChecklistTemplateMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IChecklistTemplateMaintService), userProfile);
    }

    public ResultStatus Delete(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      result = (ChecklistTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChecklistTemplateMaintService) this._Channel).Delete(this._UserProfile, checklistTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ChecklistTemplateMaintMethod(checklistTemplateMaint, ChecklistTemplateMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ChecklistTemplateMaint) null, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus Delete(ChecklistTemplateMaint checklistTemplateMaint)
    {
      return this.Delete(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus Delete(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      return this.Delete(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      result = (ChecklistTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChecklistTemplateMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, checklistTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ChecklistTemplateMaintMethod(checklistTemplateMaint, ChecklistTemplateMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((ChecklistTemplateMaint) null, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(ChecklistTemplateMaint checklistTemplateMaint)
    {
      return this.DeleteAllRevisions(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      return this.DeleteAllRevisions(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      result = (ChecklistTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChecklistTemplateMaintService) this._Channel).Freeze(this._UserProfile, checklistTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ChecklistTemplateMaintMethod(checklistTemplateMaint, ChecklistTemplateMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ChecklistTemplateMaint) null, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus Freeze(ChecklistTemplateMaint checklistTemplateMaint)
    {
      return this.Freeze(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus Freeze(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      return this.Freeze(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      result = (ChecklistTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChecklistTemplateMaintService) this._Channel).GetWIPMsgs(this._UserProfile, checklistTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ChecklistTemplateMaintMethod(checklistTemplateMaint, ChecklistTemplateMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ChecklistTemplateMaint) null, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ChecklistTemplateMaint checklistTemplateMaint)
    {
      return this.GetWIPMsgs(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      return this.GetWIPMsgs(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      result = (ChecklistTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChecklistTemplateMaintService) this._Channel).Load(this._UserProfile, checklistTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ChecklistTemplateMaintMethod(checklistTemplateMaint, ChecklistTemplateMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ChecklistTemplateMaint) null, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus Load(ChecklistTemplateMaint checklistTemplateMaint)
    {
      return this.Load(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus Load(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      return this.Load(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_LoadESigDetails_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      result = (ChecklistTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChecklistTemplateMaintService) this._Channel).LoadESigDetails(this._UserProfile, checklistTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ChecklistTemplateMaintMethod(checklistTemplateMaint, ChecklistTemplateMaintMethods.LoadESigDetails, (ChecklistTemplateMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ChecklistTemplateMaint) null, (ChecklistTemplateMaint_LoadESigDetails_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ChecklistTemplateMaint checklistTemplateMaint)
    {
      return this.LoadESigDetails(checklistTemplateMaint, (ChecklistTemplateMaint_LoadESigDetails_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      return this.LoadESigDetails(checklistTemplateMaint, (ChecklistTemplateMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      result = (ChecklistTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChecklistTemplateMaintService) this._Channel).New(this._UserProfile, checklistTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ChecklistTemplateMaintMethod(checklistTemplateMaint, ChecklistTemplateMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ChecklistTemplateMaint) null, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus New(ChecklistTemplateMaint checklistTemplateMaint)
    {
      return this.New(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus New(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      return this.New(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      result = (ChecklistTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChecklistTemplateMaintService) this._Channel).NewCopy(this._UserProfile, checklistTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ChecklistTemplateMaintMethod(checklistTemplateMaint, ChecklistTemplateMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ChecklistTemplateMaint) null, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(ChecklistTemplateMaint checklistTemplateMaint)
    {
      return this.NewCopy(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      return this.NewCopy(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      result = (ChecklistTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChecklistTemplateMaintService) this._Channel).NewRev(this._UserProfile, checklistTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ChecklistTemplateMaintMethod(checklistTemplateMaint, ChecklistTemplateMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((ChecklistTemplateMaint) null, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus NewRev(ChecklistTemplateMaint checklistTemplateMaint)
    {
      return this.NewRev(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus NewRev(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      return this.NewRev(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      result = (ChecklistTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChecklistTemplateMaintService) this._Channel).NewRevCopy(this._UserProfile, checklistTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ChecklistTemplateMaintMethod(checklistTemplateMaint, ChecklistTemplateMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((ChecklistTemplateMaint) null, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus NewRevCopy(ChecklistTemplateMaint checklistTemplateMaint)
    {
      return this.NewRevCopy(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      return this.NewRevCopy(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      result = (ChecklistTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChecklistTemplateMaintService) this._Channel).SaveAs(this._UserProfile, checklistTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ChecklistTemplateMaintMethod(checklistTemplateMaint, ChecklistTemplateMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ChecklistTemplateMaint) null, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(ChecklistTemplateMaint checklistTemplateMaint)
    {
      return this.SaveAs(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      return this.SaveAs(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      result = (ChecklistTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChecklistTemplateMaintService) this._Channel).SaveAsRev(this._UserProfile, checklistTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ChecklistTemplateMaintMethod(checklistTemplateMaint, ChecklistTemplateMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((ChecklistTemplateMaint) null, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus SaveAsRev(ChecklistTemplateMaint checklistTemplateMaint)
    {
      return this.SaveAsRev(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      return this.SaveAsRev(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      result = (ChecklistTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChecklistTemplateMaintService) this._Channel).UnFreeze(this._UserProfile, checklistTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ChecklistTemplateMaintMethod(checklistTemplateMaint, ChecklistTemplateMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) checklistTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ChecklistTemplateMaint) null, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(ChecklistTemplateMaint checklistTemplateMaint)
    {
      return this.UnFreeze(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      return this.UnFreeze(checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject checklistTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChecklistTemplateMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((ChecklistTemplateMaint) checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) parameters, (ChecklistTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject checklistTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChecklistTemplateMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((ChecklistTemplateMaint) checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) parameters, (ChecklistTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject checklistTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChecklistTemplateMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((ChecklistTemplateMaint) checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) parameters, (ChecklistTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject checklistTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChecklistTemplateMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((ChecklistTemplateMaint) checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) parameters, (ChecklistTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject checklistTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChecklistTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ChecklistTemplateMaint) checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) parameters, (ChecklistTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject checklistTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChecklistTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ChecklistTemplateMaint) checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) parameters, (ChecklistTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject checklistTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChecklistTemplateMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ChecklistTemplateMaint) checklistTemplateMaint, (ChecklistTemplateMaint_LoadESigDetails_Parameters) parameters, (ChecklistTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject checklistTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChecklistTemplateMaint_Result result1;
        ResultStatus resultStatus = this.New((ChecklistTemplateMaint) checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) parameters, (ChecklistTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject checklistTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChecklistTemplateMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ChecklistTemplateMaint) checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) parameters, (ChecklistTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject checklistTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChecklistTemplateMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ChecklistTemplateMaint) checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) parameters, (ChecklistTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject checklistTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChecklistTemplateMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ChecklistTemplateMaint) checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) parameters, (ChecklistTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject checklistTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChecklistTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Load((ChecklistTemplateMaint) checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) parameters, (ChecklistTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject checklistTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChecklistTemplateMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ChecklistTemplateMaint) checklistTemplateMaint, (ChecklistTemplateMaint_Parameters) parameters, (ChecklistTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      result = (ChecklistTemplateMaint_Result) null;
      try
      {
        ChecklistTemplateMaintMethod[] methods = new ChecklistTemplateMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IChecklistTemplateMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ChecklistTemplateMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ChecklistTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChecklistTemplateMaint cdo,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      result = (ChecklistTemplateMaint_Result) null;
      try
      {
        return ((IChecklistTemplateMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ChecklistTemplateMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ChecklistTemplateMaint) cdo, (ChecklistTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      return this.GetEnvironment((ChecklistTemplateMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ChecklistTemplateMaint cdo,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      result = (ChecklistTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChecklistTemplateMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ChecklistTemplateMaintMethod(cdo, ChecklistTemplateMaintMethods.ExecuteTransaction, (ChecklistTemplateMaint_Parameters) null));
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
        ChecklistTemplateMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ChecklistTemplateMaint) cdo, (ChecklistTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ChecklistTemplateMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ChecklistTemplateMaint_Request) null, out ChecklistTemplateMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result)
    {
      return this.ExecuteTransaction((ChecklistTemplateMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ChecklistTemplateMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ChecklistTemplateMaintMethod(cdo, ChecklistTemplateMaintMethods.AddDataTransaction, (ChecklistTemplateMaint_Parameters) null));
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
        return this.AddDataTransaction((ChecklistTemplateMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
