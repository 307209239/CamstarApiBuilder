// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DateReqMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DateReqMaintService : MaintenanceReqMaintBase
  {
    public DateReqMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDateReqMaintService), userProfile);
    }

    public ResultStatus Delete(
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      result = (DateReqMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) dateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDateReqMaintService) this._Channel).Delete(this._UserProfile, dateReqMaint, parameters, request, out result) : this.AddMethod((Method) new DateReqMaintMethod(dateReqMaint, DateReqMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) dateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((DateReqMaint) null, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus Delete(DateReqMaint dateReqMaint)
    {
      return this.Delete(dateReqMaint, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus Delete(
      DateReqMaint dateReqMaint,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      return this.Delete(dateReqMaint, (DateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      result = (DateReqMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) dateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDateReqMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, dateReqMaint, parameters, request, out result) : this.AddMethod((Method) new DateReqMaintMethod(dateReqMaint, DateReqMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) dateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((DateReqMaint) null, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(DateReqMaint dateReqMaint)
    {
      return this.DeleteAllRevisions(dateReqMaint, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      DateReqMaint dateReqMaint,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      return this.DeleteAllRevisions(dateReqMaint, (DateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      result = (DateReqMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) dateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDateReqMaintService) this._Channel).Freeze(this._UserProfile, dateReqMaint, parameters, request, out result) : this.AddMethod((Method) new DateReqMaintMethod(dateReqMaint, DateReqMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) dateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((DateReqMaint) null, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus Freeze(DateReqMaint dateReqMaint)
    {
      return this.Freeze(dateReqMaint, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus Freeze(
      DateReqMaint dateReqMaint,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      return this.Freeze(dateReqMaint, (DateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      result = (DateReqMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) dateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDateReqMaintService) this._Channel).GetWIPMsgs(this._UserProfile, dateReqMaint, parameters, request, out result) : this.AddMethod((Method) new DateReqMaintMethod(dateReqMaint, DateReqMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) dateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DateReqMaint) null, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(DateReqMaint dateReqMaint)
    {
      return this.GetWIPMsgs(dateReqMaint, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DateReqMaint dateReqMaint,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      return this.GetWIPMsgs(dateReqMaint, (DateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      result = (DateReqMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) dateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDateReqMaintService) this._Channel).Load(this._UserProfile, dateReqMaint, parameters, request, out result) : this.AddMethod((Method) new DateReqMaintMethod(dateReqMaint, DateReqMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) dateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DateReqMaint) null, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus Load(DateReqMaint dateReqMaint)
    {
      return this.Load(dateReqMaint, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus Load(
      DateReqMaint dateReqMaint,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      return this.Load(dateReqMaint, (DateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DateReqMaint dateReqMaint,
      DateReqMaint_LoadESigDetails_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      result = (DateReqMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) dateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDateReqMaintService) this._Channel).LoadESigDetails(this._UserProfile, dateReqMaint, parameters, request, out result) : this.AddMethod((Method) new DateReqMaintMethod(dateReqMaint, DateReqMaintMethods.LoadESigDetails, (DateReqMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) dateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DateReqMaint) null, (DateReqMaint_LoadESigDetails_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus LoadESigDetails(DateReqMaint dateReqMaint)
    {
      return this.LoadESigDetails(dateReqMaint, (DateReqMaint_LoadESigDetails_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      DateReqMaint dateReqMaint,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      return this.LoadESigDetails(dateReqMaint, (DateReqMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      result = (DateReqMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) dateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDateReqMaintService) this._Channel).New(this._UserProfile, dateReqMaint, parameters, request, out result) : this.AddMethod((Method) new DateReqMaintMethod(dateReqMaint, DateReqMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) dateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((DateReqMaint) null, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus New(DateReqMaint dateReqMaint)
    {
      return this.New(dateReqMaint, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus New(
      DateReqMaint dateReqMaint,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      return this.New(dateReqMaint, (DateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      result = (DateReqMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) dateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDateReqMaintService) this._Channel).NewCopy(this._UserProfile, dateReqMaint, parameters, request, out result) : this.AddMethod((Method) new DateReqMaintMethod(dateReqMaint, DateReqMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) dateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((DateReqMaint) null, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus NewCopy(DateReqMaint dateReqMaint)
    {
      return this.NewCopy(dateReqMaint, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus NewCopy(
      DateReqMaint dateReqMaint,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      return this.NewCopy(dateReqMaint, (DateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      result = (DateReqMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) dateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDateReqMaintService) this._Channel).NewRev(this._UserProfile, dateReqMaint, parameters, request, out result) : this.AddMethod((Method) new DateReqMaintMethod(dateReqMaint, DateReqMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) dateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((DateReqMaint) null, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus NewRev(DateReqMaint dateReqMaint)
    {
      return this.NewRev(dateReqMaint, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus NewRev(
      DateReqMaint dateReqMaint,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      return this.NewRev(dateReqMaint, (DateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      result = (DateReqMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) dateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDateReqMaintService) this._Channel).NewRevCopy(this._UserProfile, dateReqMaint, parameters, request, out result) : this.AddMethod((Method) new DateReqMaintMethod(dateReqMaint, DateReqMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) dateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((DateReqMaint) null, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus NewRevCopy(DateReqMaint dateReqMaint)
    {
      return this.NewRevCopy(dateReqMaint, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      DateReqMaint dateReqMaint,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      return this.NewRevCopy(dateReqMaint, (DateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      result = (DateReqMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) dateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDateReqMaintService) this._Channel).SaveAs(this._UserProfile, dateReqMaint, parameters, request, out result) : this.AddMethod((Method) new DateReqMaintMethod(dateReqMaint, DateReqMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) dateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((DateReqMaint) null, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus SaveAs(DateReqMaint dateReqMaint)
    {
      return this.SaveAs(dateReqMaint, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus SaveAs(
      DateReqMaint dateReqMaint,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      return this.SaveAs(dateReqMaint, (DateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      result = (DateReqMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) dateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDateReqMaintService) this._Channel).SaveAsRev(this._UserProfile, dateReqMaint, parameters, request, out result) : this.AddMethod((Method) new DateReqMaintMethod(dateReqMaint, DateReqMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) dateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((DateReqMaint) null, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus SaveAsRev(DateReqMaint dateReqMaint)
    {
      return this.SaveAsRev(dateReqMaint, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      DateReqMaint dateReqMaint,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      return this.SaveAsRev(dateReqMaint, (DateReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      result = (DateReqMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) dateReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDateReqMaintService) this._Channel).UnFreeze(this._UserProfile, dateReqMaint, parameters, request, out result) : this.AddMethod((Method) new DateReqMaintMethod(dateReqMaint, DateReqMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) dateReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((DateReqMaint) null, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus UnFreeze(DateReqMaint dateReqMaint)
    {
      return this.UnFreeze(dateReqMaint, (DateReqMaint_Parameters) null, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus UnFreeze(
      DateReqMaint dateReqMaint,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      return this.UnFreeze(dateReqMaint, (DateReqMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject dateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DateReqMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((DateReqMaint) dateReqMaint, (DateReqMaint_Parameters) parameters, (DateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject dateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DateReqMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((DateReqMaint) dateReqMaint, (DateReqMaint_Parameters) parameters, (DateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject dateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DateReqMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((DateReqMaint) dateReqMaint, (DateReqMaint_Parameters) parameters, (DateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject dateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DateReqMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((DateReqMaint) dateReqMaint, (DateReqMaint_Parameters) parameters, (DateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject dateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DateReqMaint_Result result1;
        ResultStatus resultStatus = this.Delete((DateReqMaint) dateReqMaint, (DateReqMaint_Parameters) parameters, (DateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject dateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DateReqMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((DateReqMaint) dateReqMaint, (DateReqMaint_Parameters) parameters, (DateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject dateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DateReqMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DateReqMaint) dateReqMaint, (DateReqMaint_LoadESigDetails_Parameters) parameters, (DateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject dateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DateReqMaint_Result result1;
        ResultStatus resultStatus = this.New((DateReqMaint) dateReqMaint, (DateReqMaint_Parameters) parameters, (DateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject dateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DateReqMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((DateReqMaint) dateReqMaint, (DateReqMaint_Parameters) parameters, (DateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject dateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DateReqMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((DateReqMaint) dateReqMaint, (DateReqMaint_Parameters) parameters, (DateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject dateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DateReqMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((DateReqMaint) dateReqMaint, (DateReqMaint_Parameters) parameters, (DateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject dateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DateReqMaint_Result result1;
        ResultStatus resultStatus = this.Load((DateReqMaint) dateReqMaint, (DateReqMaint_Parameters) parameters, (DateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject dateReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DateReqMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DateReqMaint) dateReqMaint, (DateReqMaint_Parameters) parameters, (DateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      result = (DateReqMaint_Result) null;
      try
      {
        DateReqMaintMethod[] methods = new DateReqMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDateReqMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DateReqMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DateReqMaint cdo,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      result = (DateReqMaint_Result) null;
      try
      {
        return ((IDateReqMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DateReqMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((DateReqMaint) cdo, (DateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      return this.GetEnvironment((DateReqMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DateReqMaint cdo,
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      result = (DateReqMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDateReqMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DateReqMaintMethod(cdo, DateReqMaintMethods.ExecuteTransaction, (DateReqMaint_Parameters) null));
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
        DateReqMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DateReqMaint) cdo, (DateReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DateReqMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (DateReqMaint_Request) null, out DateReqMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DateReqMaint_Request request,
      out DateReqMaint_Result result)
    {
      return this.ExecuteTransaction((DateReqMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DateReqMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DateReqMaintMethod(cdo, DateReqMaintMethods.AddDataTransaction, (DateReqMaint_Parameters) null));
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
        return this.AddDataTransaction((DateReqMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
