// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ThruputReqMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ThruputReqMaintService : MaintenanceReqMaintBase
  {
    public ThruputReqMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IThruputReqMaintService), userProfile);
    }

    public ResultStatus Delete(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      result = (ThruputReqMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputReqMaintService) this._Channel).Delete(this._UserProfile, thruputReqMaint, parameters, request, out result) : this.AddMethod((Method) new ThruputReqMaintMethod(thruputReqMaint, ThruputReqMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ThruputReqMaint) null, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus Delete(ThruputReqMaint thruputReqMaint)
    {
      return this.Delete(thruputReqMaint, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus Delete(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      return this.Delete(thruputReqMaint, (ThruputReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      result = (ThruputReqMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputReqMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, thruputReqMaint, parameters, request, out result) : this.AddMethod((Method) new ThruputReqMaintMethod(thruputReqMaint, ThruputReqMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((ThruputReqMaint) null, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(ThruputReqMaint thruputReqMaint)
    {
      return this.DeleteAllRevisions(thruputReqMaint, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      return this.DeleteAllRevisions(thruputReqMaint, (ThruputReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      result = (ThruputReqMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputReqMaintService) this._Channel).Freeze(this._UserProfile, thruputReqMaint, parameters, request, out result) : this.AddMethod((Method) new ThruputReqMaintMethod(thruputReqMaint, ThruputReqMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ThruputReqMaint) null, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus Freeze(ThruputReqMaint thruputReqMaint)
    {
      return this.Freeze(thruputReqMaint, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus Freeze(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      return this.Freeze(thruputReqMaint, (ThruputReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      result = (ThruputReqMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputReqMaintService) this._Channel).GetWIPMsgs(this._UserProfile, thruputReqMaint, parameters, request, out result) : this.AddMethod((Method) new ThruputReqMaintMethod(thruputReqMaint, ThruputReqMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ThruputReqMaint) null, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ThruputReqMaint thruputReqMaint)
    {
      return this.GetWIPMsgs(thruputReqMaint, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      return this.GetWIPMsgs(thruputReqMaint, (ThruputReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      result = (ThruputReqMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputReqMaintService) this._Channel).Load(this._UserProfile, thruputReqMaint, parameters, request, out result) : this.AddMethod((Method) new ThruputReqMaintMethod(thruputReqMaint, ThruputReqMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ThruputReqMaint) null, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus Load(ThruputReqMaint thruputReqMaint)
    {
      return this.Load(thruputReqMaint, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus Load(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      return this.Load(thruputReqMaint, (ThruputReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_LoadESigDetails_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      result = (ThruputReqMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputReqMaintService) this._Channel).LoadESigDetails(this._UserProfile, thruputReqMaint, parameters, request, out result) : this.AddMethod((Method) new ThruputReqMaintMethod(thruputReqMaint, ThruputReqMaintMethods.LoadESigDetails, (ThruputReqMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ThruputReqMaint) null, (ThruputReqMaint_LoadESigDetails_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ThruputReqMaint thruputReqMaint)
    {
      return this.LoadESigDetails(thruputReqMaint, (ThruputReqMaint_LoadESigDetails_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      return this.LoadESigDetails(thruputReqMaint, (ThruputReqMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      result = (ThruputReqMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputReqMaintService) this._Channel).New(this._UserProfile, thruputReqMaint, parameters, request, out result) : this.AddMethod((Method) new ThruputReqMaintMethod(thruputReqMaint, ThruputReqMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ThruputReqMaint) null, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus New(ThruputReqMaint thruputReqMaint)
    {
      return this.New(thruputReqMaint, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus New(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      return this.New(thruputReqMaint, (ThruputReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      result = (ThruputReqMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputReqMaintService) this._Channel).NewCopy(this._UserProfile, thruputReqMaint, parameters, request, out result) : this.AddMethod((Method) new ThruputReqMaintMethod(thruputReqMaint, ThruputReqMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ThruputReqMaint) null, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus NewCopy(ThruputReqMaint thruputReqMaint)
    {
      return this.NewCopy(thruputReqMaint, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus NewCopy(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      return this.NewCopy(thruputReqMaint, (ThruputReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      result = (ThruputReqMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputReqMaintService) this._Channel).NewRev(this._UserProfile, thruputReqMaint, parameters, request, out result) : this.AddMethod((Method) new ThruputReqMaintMethod(thruputReqMaint, ThruputReqMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((ThruputReqMaint) null, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus NewRev(ThruputReqMaint thruputReqMaint)
    {
      return this.NewRev(thruputReqMaint, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus NewRev(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      return this.NewRev(thruputReqMaint, (ThruputReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      result = (ThruputReqMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputReqMaintService) this._Channel).NewRevCopy(this._UserProfile, thruputReqMaint, parameters, request, out result) : this.AddMethod((Method) new ThruputReqMaintMethod(thruputReqMaint, ThruputReqMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((ThruputReqMaint) null, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus NewRevCopy(ThruputReqMaint thruputReqMaint)
    {
      return this.NewRevCopy(thruputReqMaint, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      return this.NewRevCopy(thruputReqMaint, (ThruputReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      result = (ThruputReqMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputReqMaintService) this._Channel).SaveAs(this._UserProfile, thruputReqMaint, parameters, request, out result) : this.AddMethod((Method) new ThruputReqMaintMethod(thruputReqMaint, ThruputReqMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ThruputReqMaint) null, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus SaveAs(ThruputReqMaint thruputReqMaint)
    {
      return this.SaveAs(thruputReqMaint, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus SaveAs(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      return this.SaveAs(thruputReqMaint, (ThruputReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      result = (ThruputReqMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputReqMaintService) this._Channel).SaveAsRev(this._UserProfile, thruputReqMaint, parameters, request, out result) : this.AddMethod((Method) new ThruputReqMaintMethod(thruputReqMaint, ThruputReqMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((ThruputReqMaint) null, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus SaveAsRev(ThruputReqMaint thruputReqMaint)
    {
      return this.SaveAsRev(thruputReqMaint, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      return this.SaveAsRev(thruputReqMaint, (ThruputReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      result = (ThruputReqMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputReqMaintService) this._Channel).UnFreeze(this._UserProfile, thruputReqMaint, parameters, request, out result) : this.AddMethod((Method) new ThruputReqMaintMethod(thruputReqMaint, ThruputReqMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) thruputReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ThruputReqMaint) null, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus UnFreeze(ThruputReqMaint thruputReqMaint)
    {
      return this.UnFreeze(thruputReqMaint, (ThruputReqMaint_Parameters) null, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      return this.UnFreeze(thruputReqMaint, (ThruputReqMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject thruputReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ThruputReqMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((ThruputReqMaint) thruputReqMaint, (ThruputReqMaint_Parameters) parameters, (ThruputReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject thruputReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ThruputReqMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((ThruputReqMaint) thruputReqMaint, (ThruputReqMaint_Parameters) parameters, (ThruputReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject thruputReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ThruputReqMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((ThruputReqMaint) thruputReqMaint, (ThruputReqMaint_Parameters) parameters, (ThruputReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject thruputReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ThruputReqMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((ThruputReqMaint) thruputReqMaint, (ThruputReqMaint_Parameters) parameters, (ThruputReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject thruputReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ThruputReqMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ThruputReqMaint) thruputReqMaint, (ThruputReqMaint_Parameters) parameters, (ThruputReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject thruputReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ThruputReqMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ThruputReqMaint) thruputReqMaint, (ThruputReqMaint_Parameters) parameters, (ThruputReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject thruputReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ThruputReqMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ThruputReqMaint) thruputReqMaint, (ThruputReqMaint_LoadESigDetails_Parameters) parameters, (ThruputReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject thruputReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ThruputReqMaint_Result result1;
        ResultStatus resultStatus = this.New((ThruputReqMaint) thruputReqMaint, (ThruputReqMaint_Parameters) parameters, (ThruputReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject thruputReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ThruputReqMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ThruputReqMaint) thruputReqMaint, (ThruputReqMaint_Parameters) parameters, (ThruputReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject thruputReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ThruputReqMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ThruputReqMaint) thruputReqMaint, (ThruputReqMaint_Parameters) parameters, (ThruputReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject thruputReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ThruputReqMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ThruputReqMaint) thruputReqMaint, (ThruputReqMaint_Parameters) parameters, (ThruputReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject thruputReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ThruputReqMaint_Result result1;
        ResultStatus resultStatus = this.Load((ThruputReqMaint) thruputReqMaint, (ThruputReqMaint_Parameters) parameters, (ThruputReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject thruputReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ThruputReqMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ThruputReqMaint) thruputReqMaint, (ThruputReqMaint_Parameters) parameters, (ThruputReqMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      result = (ThruputReqMaint_Result) null;
      try
      {
        ThruputReqMaintMethod[] methods = new ThruputReqMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IThruputReqMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ThruputReqMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ThruputReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ThruputReqMaint cdo,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      result = (ThruputReqMaint_Result) null;
      try
      {
        return ((IThruputReqMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ThruputReqMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ThruputReqMaint) cdo, (ThruputReqMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      return this.GetEnvironment((ThruputReqMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ThruputReqMaint cdo,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      result = (ThruputReqMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputReqMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ThruputReqMaintMethod(cdo, ThruputReqMaintMethods.ExecuteTransaction, (ThruputReqMaint_Parameters) null));
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
        ThruputReqMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ThruputReqMaint) cdo, (ThruputReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ThruputReqMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ThruputReqMaint_Request) null, out ThruputReqMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result)
    {
      return this.ExecuteTransaction((ThruputReqMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ThruputReqMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ThruputReqMaintMethod(cdo, ThruputReqMaintMethods.AddDataTransaction, (ThruputReqMaint_Parameters) null));
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
        return this.AddDataTransaction((ThruputReqMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
