// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShippingReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ShippingReasonGroupMaintService : UserCodeGroupMaintBase
  {
    public ShippingReasonGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IShippingReasonGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Parameters parameters,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      result = (ShippingReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) shippingReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonGroupMaintService) this._Channel).Delete(this._UserProfile, shippingReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ShippingReasonGroupMaintMethod(shippingReasonGroupMaint, ShippingReasonGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) shippingReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ShippingReasonGroupMaint) null, (ShippingReasonGroupMaint_Parameters) null, (ShippingReasonGroupMaint_Request) null, out ShippingReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(ShippingReasonGroupMaint shippingReasonGroupMaint)
    {
      return this.Delete(shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) null, (ShippingReasonGroupMaint_Request) null, out ShippingReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      return this.Delete(shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Parameters parameters,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      result = (ShippingReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) shippingReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonGroupMaintService) this._Channel).Freeze(this._UserProfile, shippingReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ShippingReasonGroupMaintMethod(shippingReasonGroupMaint, ShippingReasonGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) shippingReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ShippingReasonGroupMaint) null, (ShippingReasonGroupMaint_Parameters) null, (ShippingReasonGroupMaint_Request) null, out ShippingReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(ShippingReasonGroupMaint shippingReasonGroupMaint)
    {
      return this.Freeze(shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) null, (ShippingReasonGroupMaint_Request) null, out ShippingReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      return this.Freeze(shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Parameters parameters,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      result = (ShippingReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) shippingReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, shippingReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ShippingReasonGroupMaintMethod(shippingReasonGroupMaint, ShippingReasonGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) shippingReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ShippingReasonGroupMaint) null, (ShippingReasonGroupMaint_Parameters) null, (ShippingReasonGroupMaint_Request) null, out ShippingReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ShippingReasonGroupMaint shippingReasonGroupMaint)
    {
      return this.GetWIPMsgs(shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) null, (ShippingReasonGroupMaint_Request) null, out ShippingReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      return this.GetWIPMsgs(shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Parameters parameters,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      result = (ShippingReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) shippingReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonGroupMaintService) this._Channel).Load(this._UserProfile, shippingReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ShippingReasonGroupMaintMethod(shippingReasonGroupMaint, ShippingReasonGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) shippingReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ShippingReasonGroupMaint) null, (ShippingReasonGroupMaint_Parameters) null, (ShippingReasonGroupMaint_Request) null, out ShippingReasonGroupMaint_Result _);
    }

    public ResultStatus Load(ShippingReasonGroupMaint shippingReasonGroupMaint)
    {
      return this.Load(shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) null, (ShippingReasonGroupMaint_Request) null, out ShippingReasonGroupMaint_Result _);
    }

    public ResultStatus Load(
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      return this.Load(shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_LoadESigDetails_Parameters parameters,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      result = (ShippingReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) shippingReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, shippingReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ShippingReasonGroupMaintMethod(shippingReasonGroupMaint, ShippingReasonGroupMaintMethods.LoadESigDetails, (ShippingReasonGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) shippingReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ShippingReasonGroupMaint) null, (ShippingReasonGroupMaint_LoadESigDetails_Parameters) null, (ShippingReasonGroupMaint_Request) null, out ShippingReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ShippingReasonGroupMaint shippingReasonGroupMaint)
    {
      return this.LoadESigDetails(shippingReasonGroupMaint, (ShippingReasonGroupMaint_LoadESigDetails_Parameters) null, (ShippingReasonGroupMaint_Request) null, out ShippingReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      return this.LoadESigDetails(shippingReasonGroupMaint, (ShippingReasonGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Parameters parameters,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      result = (ShippingReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) shippingReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonGroupMaintService) this._Channel).New(this._UserProfile, shippingReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ShippingReasonGroupMaintMethod(shippingReasonGroupMaint, ShippingReasonGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) shippingReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ShippingReasonGroupMaint) null, (ShippingReasonGroupMaint_Parameters) null, (ShippingReasonGroupMaint_Request) null, out ShippingReasonGroupMaint_Result _);
    }

    public ResultStatus New(ShippingReasonGroupMaint shippingReasonGroupMaint)
    {
      return this.New(shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) null, (ShippingReasonGroupMaint_Request) null, out ShippingReasonGroupMaint_Result _);
    }

    public ResultStatus New(
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      return this.New(shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Parameters parameters,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      result = (ShippingReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) shippingReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonGroupMaintService) this._Channel).NewCopy(this._UserProfile, shippingReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ShippingReasonGroupMaintMethod(shippingReasonGroupMaint, ShippingReasonGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) shippingReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ShippingReasonGroupMaint) null, (ShippingReasonGroupMaint_Parameters) null, (ShippingReasonGroupMaint_Request) null, out ShippingReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(ShippingReasonGroupMaint shippingReasonGroupMaint)
    {
      return this.NewCopy(shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) null, (ShippingReasonGroupMaint_Request) null, out ShippingReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      return this.NewCopy(shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Parameters parameters,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      result = (ShippingReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) shippingReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonGroupMaintService) this._Channel).SaveAs(this._UserProfile, shippingReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ShippingReasonGroupMaintMethod(shippingReasonGroupMaint, ShippingReasonGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) shippingReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ShippingReasonGroupMaint) null, (ShippingReasonGroupMaint_Parameters) null, (ShippingReasonGroupMaint_Request) null, out ShippingReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(ShippingReasonGroupMaint shippingReasonGroupMaint)
    {
      return this.SaveAs(shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) null, (ShippingReasonGroupMaint_Request) null, out ShippingReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      return this.SaveAs(shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Parameters parameters,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      result = (ShippingReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) shippingReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonGroupMaintService) this._Channel).UnFreeze(this._UserProfile, shippingReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ShippingReasonGroupMaintMethod(shippingReasonGroupMaint, ShippingReasonGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) shippingReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ShippingReasonGroupMaint) null, (ShippingReasonGroupMaint_Parameters) null, (ShippingReasonGroupMaint_Request) null, out ShippingReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(ShippingReasonGroupMaint shippingReasonGroupMaint)
    {
      return this.UnFreeze(shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) null, (ShippingReasonGroupMaint_Request) null, out ShippingReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      return this.UnFreeze(shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject shippingReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShippingReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ShippingReasonGroupMaint) shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) parameters, (ShippingReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject shippingReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShippingReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ShippingReasonGroupMaint) shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) parameters, (ShippingReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject shippingReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShippingReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ShippingReasonGroupMaint) shippingReasonGroupMaint, (ShippingReasonGroupMaint_LoadESigDetails_Parameters) parameters, (ShippingReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject shippingReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShippingReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((ShippingReasonGroupMaint) shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) parameters, (ShippingReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject shippingReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShippingReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ShippingReasonGroupMaint) shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) parameters, (ShippingReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject shippingReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShippingReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ShippingReasonGroupMaint) shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) parameters, (ShippingReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject shippingReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShippingReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ShippingReasonGroupMaint) shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) parameters, (ShippingReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject shippingReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShippingReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((ShippingReasonGroupMaint) shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) parameters, (ShippingReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject shippingReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShippingReasonGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ShippingReasonGroupMaint) shippingReasonGroupMaint, (ShippingReasonGroupMaint_Parameters) parameters, (ShippingReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      result = (ShippingReasonGroupMaint_Result) null;
      try
      {
        ShippingReasonGroupMaintMethod[] methods = new ShippingReasonGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IShippingReasonGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ShippingReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ShippingReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ShippingReasonGroupMaint cdo,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      result = (ShippingReasonGroupMaint_Result) null;
      try
      {
        return ((IShippingReasonGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ShippingReasonGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ShippingReasonGroupMaint) cdo, (ShippingReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      return this.GetEnvironment((ShippingReasonGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ShippingReasonGroupMaint cdo,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      result = (ShippingReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ShippingReasonGroupMaintMethod(cdo, ShippingReasonGroupMaintMethods.ExecuteTransaction, (ShippingReasonGroupMaint_Parameters) null));
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
        ShippingReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ShippingReasonGroupMaint) cdo, (ShippingReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ShippingReasonGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ShippingReasonGroupMaint_Request) null, out ShippingReasonGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result)
    {
      return this.ExecuteTransaction((ShippingReasonGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ShippingReasonGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ShippingReasonGroupMaintMethod(cdo, ShippingReasonGroupMaintMethods.AddDataTransaction, (ShippingReasonGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((ShippingReasonGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
