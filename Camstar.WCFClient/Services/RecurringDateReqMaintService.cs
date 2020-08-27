// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RecurringDateReqMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RecurringDateReqMaintService : MaintenanceReqMaintBase
  {
    public RecurringDateReqMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRecurringDateReqMaintService), userProfile);
    }

    public ResultStatus Delete(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      result = (RecurringDateReqMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecurringDateReqMaintService) this._Channel).Delete(this._UserProfile, recurringDateReqMaint, parameters, request, out result) : this.AddMethod((Method) new RecurringDateReqMaintMethod(recurringDateReqMaint, RecurringDateReqMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((RecurringDateReqMaint) null, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus Delete(RecurringDateReqMaint recurringDateReqMaint)
    {
      return this.Delete(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus Delete(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      return this.Delete(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      result = (RecurringDateReqMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecurringDateReqMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, recurringDateReqMaint, parameters, request, out result) : this.AddMethod((Method) new RecurringDateReqMaintMethod(recurringDateReqMaint, RecurringDateReqMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((RecurringDateReqMaint) null, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(RecurringDateReqMaint recurringDateReqMaint)
    {
      return this.DeleteAllRevisions(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      return this.DeleteAllRevisions(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      result = (RecurringDateReqMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecurringDateReqMaintService) this._Channel).Freeze(this._UserProfile, recurringDateReqMaint, parameters, request, out result) : this.AddMethod((Method) new RecurringDateReqMaintMethod(recurringDateReqMaint, RecurringDateReqMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((RecurringDateReqMaint) null, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus Freeze(RecurringDateReqMaint recurringDateReqMaint)
    {
      return this.Freeze(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus Freeze(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      return this.Freeze(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      result = (RecurringDateReqMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecurringDateReqMaintService) this._Channel).GetWIPMsgs(this._UserProfile, recurringDateReqMaint, parameters, request, out result) : this.AddMethod((Method) new RecurringDateReqMaintMethod(recurringDateReqMaint, RecurringDateReqMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RecurringDateReqMaint) null, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(RecurringDateReqMaint recurringDateReqMaint)
    {
      return this.GetWIPMsgs(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      return this.GetWIPMsgs(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      result = (RecurringDateReqMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecurringDateReqMaintService) this._Channel).Load(this._UserProfile, recurringDateReqMaint, parameters, request, out result) : this.AddMethod((Method) new RecurringDateReqMaintMethod(recurringDateReqMaint, RecurringDateReqMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RecurringDateReqMaint) null, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus Load(RecurringDateReqMaint recurringDateReqMaint)
    {
      return this.Load(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus Load(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      return this.Load(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_LoadESigDetails_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      result = (RecurringDateReqMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecurringDateReqMaintService) this._Channel).LoadESigDetails(this._UserProfile, recurringDateReqMaint, parameters, request, out result) : this.AddMethod((Method) new RecurringDateReqMaintMethod(recurringDateReqMaint, RecurringDateReqMaintMethods.LoadESigDetails, (RecurringDateReqMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RecurringDateReqMaint) null, (RecurringDateReqMaint_LoadESigDetails_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus LoadESigDetails(RecurringDateReqMaint recurringDateReqMaint)
    {
      return this.LoadESigDetails(recurringDateReqMaint, (RecurringDateReqMaint_LoadESigDetails_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      return this.LoadESigDetails(recurringDateReqMaint, (RecurringDateReqMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      result = (RecurringDateReqMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecurringDateReqMaintService) this._Channel).New(this._UserProfile, recurringDateReqMaint, parameters, request, out result) : this.AddMethod((Method) new RecurringDateReqMaintMethod(recurringDateReqMaint, RecurringDateReqMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((RecurringDateReqMaint) null, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus New(RecurringDateReqMaint recurringDateReqMaint)
    {
      return this.New(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus New(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      return this.New(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      result = (RecurringDateReqMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecurringDateReqMaintService) this._Channel).NewCopy(this._UserProfile, recurringDateReqMaint, parameters, request, out result) : this.AddMethod((Method) new RecurringDateReqMaintMethod(recurringDateReqMaint, RecurringDateReqMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((RecurringDateReqMaint) null, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus NewCopy(RecurringDateReqMaint recurringDateReqMaint)
    {
      return this.NewCopy(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus NewCopy(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      return this.NewCopy(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      result = (RecurringDateReqMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecurringDateReqMaintService) this._Channel).NewRev(this._UserProfile, recurringDateReqMaint, parameters, request, out result) : this.AddMethod((Method) new RecurringDateReqMaintMethod(recurringDateReqMaint, RecurringDateReqMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((RecurringDateReqMaint) null, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus NewRev(RecurringDateReqMaint recurringDateReqMaint)
    {
      return this.NewRev(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus NewRev(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      return this.NewRev(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      result = (RecurringDateReqMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecurringDateReqMaintService) this._Channel).NewRevCopy(this._UserProfile, recurringDateReqMaint, parameters, request, out result) : this.AddMethod((Method) new RecurringDateReqMaintMethod(recurringDateReqMaint, RecurringDateReqMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((RecurringDateReqMaint) null, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus NewRevCopy(RecurringDateReqMaint recurringDateReqMaint)
    {
      return this.NewRevCopy(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      return this.NewRevCopy(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      result = (RecurringDateReqMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecurringDateReqMaintService) this._Channel).SaveAs(this._UserProfile, recurringDateReqMaint, parameters, request, out result) : this.AddMethod((Method) new RecurringDateReqMaintMethod(recurringDateReqMaint, RecurringDateReqMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((RecurringDateReqMaint) null, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus SaveAs(RecurringDateReqMaint recurringDateReqMaint)
    {
      return this.SaveAs(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus SaveAs(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      return this.SaveAs(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      result = (RecurringDateReqMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecurringDateReqMaintService) this._Channel).SaveAsRev(this._UserProfile, recurringDateReqMaint, parameters, request, out result) : this.AddMethod((Method) new RecurringDateReqMaintMethod(recurringDateReqMaint, RecurringDateReqMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((RecurringDateReqMaint) null, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus SaveAsRev(RecurringDateReqMaint recurringDateReqMaint)
    {
      return this.SaveAsRev(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      return this.SaveAsRev(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      result = (RecurringDateReqMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecurringDateReqMaintService) this._Channel).UnFreeze(this._UserProfile, recurringDateReqMaint, parameters, request, out result) : this.AddMethod((Method) new RecurringDateReqMaintMethod(recurringDateReqMaint, RecurringDateReqMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) recurringDateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((RecurringDateReqMaint) null, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus UnFreeze(RecurringDateReqMaint recurringDateReqMaint)
    {
      return this.UnFreeze(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus UnFreeze(
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      return this.UnFreeze(recurringDateReqMaint, (RecurringDateReqMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject recurringDateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecurringDateReqMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((RecurringDateReqMaint) recurringDateReqMaint, (RecurringDateReqMaint_Parameters) parameters, (RecurringDateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject recurringDateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecurringDateReqMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((RecurringDateReqMaint) recurringDateReqMaint, (RecurringDateReqMaint_Parameters) parameters, (RecurringDateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject recurringDateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecurringDateReqMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((RecurringDateReqMaint) recurringDateReqMaint, (RecurringDateReqMaint_Parameters) parameters, (RecurringDateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject recurringDateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecurringDateReqMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((RecurringDateReqMaint) recurringDateReqMaint, (RecurringDateReqMaint_Parameters) parameters, (RecurringDateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject recurringDateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecurringDateReqMaint_Result result1;
        ResultStatus resultStatus = this.Delete((RecurringDateReqMaint) recurringDateReqMaint, (RecurringDateReqMaint_Parameters) parameters, (RecurringDateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject recurringDateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecurringDateReqMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((RecurringDateReqMaint) recurringDateReqMaint, (RecurringDateReqMaint_Parameters) parameters, (RecurringDateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject recurringDateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecurringDateReqMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RecurringDateReqMaint) recurringDateReqMaint, (RecurringDateReqMaint_LoadESigDetails_Parameters) parameters, (RecurringDateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject recurringDateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecurringDateReqMaint_Result result1;
        ResultStatus resultStatus = this.New((RecurringDateReqMaint) recurringDateReqMaint, (RecurringDateReqMaint_Parameters) parameters, (RecurringDateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject recurringDateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecurringDateReqMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((RecurringDateReqMaint) recurringDateReqMaint, (RecurringDateReqMaint_Parameters) parameters, (RecurringDateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject recurringDateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecurringDateReqMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((RecurringDateReqMaint) recurringDateReqMaint, (RecurringDateReqMaint_Parameters) parameters, (RecurringDateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject recurringDateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecurringDateReqMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((RecurringDateReqMaint) recurringDateReqMaint, (RecurringDateReqMaint_Parameters) parameters, (RecurringDateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject recurringDateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecurringDateReqMaint_Result result1;
        ResultStatus resultStatus = this.Load((RecurringDateReqMaint) recurringDateReqMaint, (RecurringDateReqMaint_Parameters) parameters, (RecurringDateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject recurringDateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecurringDateReqMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RecurringDateReqMaint) recurringDateReqMaint, (RecurringDateReqMaint_Parameters) parameters, (RecurringDateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      result = (RecurringDateReqMaint_Result) null;
      try
      {
        RecurringDateReqMaintMethod[] methods = new RecurringDateReqMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRecurringDateReqMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        RecurringDateReqMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RecurringDateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RecurringDateReqMaint cdo,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      result = (RecurringDateReqMaint_Result) null;
      try
      {
        return ((IRecurringDateReqMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        RecurringDateReqMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((RecurringDateReqMaint) cdo, (RecurringDateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      return this.GetEnvironment((RecurringDateReqMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RecurringDateReqMaint cdo,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      result = (RecurringDateReqMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecurringDateReqMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RecurringDateReqMaintMethod(cdo, RecurringDateReqMaintMethods.ExecuteTransaction, (RecurringDateReqMaint_Parameters) null));
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
        RecurringDateReqMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RecurringDateReqMaint) cdo, (RecurringDateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RecurringDateReqMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (RecurringDateReqMaint_Request) null, out RecurringDateReqMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result)
    {
      return this.ExecuteTransaction((RecurringDateReqMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RecurringDateReqMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RecurringDateReqMaintMethod(cdo, RecurringDateReqMaintMethods.AddDataTransaction, (RecurringDateReqMaint_Parameters) null));
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
        return this.AddDataTransaction((RecurringDateReqMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
