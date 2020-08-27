// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShippingReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ShippingReasonMaintService : UserCodeWithWMMaintBase
  {
    public ShippingReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IShippingReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Parameters parameters,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      result = (ShippingReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) shippingReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonMaintService) this._Channel).Delete(this._UserProfile, shippingReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ShippingReasonMaintMethod(shippingReasonMaint, ShippingReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) shippingReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ShippingReasonMaint) null, (ShippingReasonMaint_Parameters) null, (ShippingReasonMaint_Request) null, out ShippingReasonMaint_Result _);
    }

    public ResultStatus Delete(ShippingReasonMaint shippingReasonMaint)
    {
      return this.Delete(shippingReasonMaint, (ShippingReasonMaint_Parameters) null, (ShippingReasonMaint_Request) null, out ShippingReasonMaint_Result _);
    }

    public ResultStatus Delete(
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      return this.Delete(shippingReasonMaint, (ShippingReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Parameters parameters,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      result = (ShippingReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) shippingReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonMaintService) this._Channel).Freeze(this._UserProfile, shippingReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ShippingReasonMaintMethod(shippingReasonMaint, ShippingReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) shippingReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ShippingReasonMaint) null, (ShippingReasonMaint_Parameters) null, (ShippingReasonMaint_Request) null, out ShippingReasonMaint_Result _);
    }

    public ResultStatus Freeze(ShippingReasonMaint shippingReasonMaint)
    {
      return this.Freeze(shippingReasonMaint, (ShippingReasonMaint_Parameters) null, (ShippingReasonMaint_Request) null, out ShippingReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      return this.Freeze(shippingReasonMaint, (ShippingReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Parameters parameters,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      result = (ShippingReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) shippingReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, shippingReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ShippingReasonMaintMethod(shippingReasonMaint, ShippingReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) shippingReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ShippingReasonMaint) null, (ShippingReasonMaint_Parameters) null, (ShippingReasonMaint_Request) null, out ShippingReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ShippingReasonMaint shippingReasonMaint)
    {
      return this.GetWIPMsgs(shippingReasonMaint, (ShippingReasonMaint_Parameters) null, (ShippingReasonMaint_Request) null, out ShippingReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      return this.GetWIPMsgs(shippingReasonMaint, (ShippingReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Parameters parameters,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      result = (ShippingReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) shippingReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonMaintService) this._Channel).Load(this._UserProfile, shippingReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ShippingReasonMaintMethod(shippingReasonMaint, ShippingReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) shippingReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ShippingReasonMaint) null, (ShippingReasonMaint_Parameters) null, (ShippingReasonMaint_Request) null, out ShippingReasonMaint_Result _);
    }

    public ResultStatus Load(ShippingReasonMaint shippingReasonMaint)
    {
      return this.Load(shippingReasonMaint, (ShippingReasonMaint_Parameters) null, (ShippingReasonMaint_Request) null, out ShippingReasonMaint_Result _);
    }

    public ResultStatus Load(
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      return this.Load(shippingReasonMaint, (ShippingReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_LoadESigDetails_Parameters parameters,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      result = (ShippingReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) shippingReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, shippingReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ShippingReasonMaintMethod(shippingReasonMaint, ShippingReasonMaintMethods.LoadESigDetails, (ShippingReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) shippingReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ShippingReasonMaint) null, (ShippingReasonMaint_LoadESigDetails_Parameters) null, (ShippingReasonMaint_Request) null, out ShippingReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ShippingReasonMaint shippingReasonMaint)
    {
      return this.LoadESigDetails(shippingReasonMaint, (ShippingReasonMaint_LoadESigDetails_Parameters) null, (ShippingReasonMaint_Request) null, out ShippingReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      return this.LoadESigDetails(shippingReasonMaint, (ShippingReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Parameters parameters,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      result = (ShippingReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) shippingReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonMaintService) this._Channel).New(this._UserProfile, shippingReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ShippingReasonMaintMethod(shippingReasonMaint, ShippingReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) shippingReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ShippingReasonMaint) null, (ShippingReasonMaint_Parameters) null, (ShippingReasonMaint_Request) null, out ShippingReasonMaint_Result _);
    }

    public ResultStatus New(ShippingReasonMaint shippingReasonMaint)
    {
      return this.New(shippingReasonMaint, (ShippingReasonMaint_Parameters) null, (ShippingReasonMaint_Request) null, out ShippingReasonMaint_Result _);
    }

    public ResultStatus New(
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      return this.New(shippingReasonMaint, (ShippingReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Parameters parameters,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      result = (ShippingReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) shippingReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonMaintService) this._Channel).NewCopy(this._UserProfile, shippingReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ShippingReasonMaintMethod(shippingReasonMaint, ShippingReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) shippingReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ShippingReasonMaint) null, (ShippingReasonMaint_Parameters) null, (ShippingReasonMaint_Request) null, out ShippingReasonMaint_Result _);
    }

    public ResultStatus NewCopy(ShippingReasonMaint shippingReasonMaint)
    {
      return this.NewCopy(shippingReasonMaint, (ShippingReasonMaint_Parameters) null, (ShippingReasonMaint_Request) null, out ShippingReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      return this.NewCopy(shippingReasonMaint, (ShippingReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Parameters parameters,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      result = (ShippingReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) shippingReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonMaintService) this._Channel).SaveAs(this._UserProfile, shippingReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ShippingReasonMaintMethod(shippingReasonMaint, ShippingReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) shippingReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ShippingReasonMaint) null, (ShippingReasonMaint_Parameters) null, (ShippingReasonMaint_Request) null, out ShippingReasonMaint_Result _);
    }

    public ResultStatus SaveAs(ShippingReasonMaint shippingReasonMaint)
    {
      return this.SaveAs(shippingReasonMaint, (ShippingReasonMaint_Parameters) null, (ShippingReasonMaint_Request) null, out ShippingReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      return this.SaveAs(shippingReasonMaint, (ShippingReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Parameters parameters,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      result = (ShippingReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) shippingReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonMaintService) this._Channel).UnFreeze(this._UserProfile, shippingReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ShippingReasonMaintMethod(shippingReasonMaint, ShippingReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) shippingReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ShippingReasonMaint) null, (ShippingReasonMaint_Parameters) null, (ShippingReasonMaint_Request) null, out ShippingReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(ShippingReasonMaint shippingReasonMaint)
    {
      return this.UnFreeze(shippingReasonMaint, (ShippingReasonMaint_Parameters) null, (ShippingReasonMaint_Request) null, out ShippingReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      return this.UnFreeze(shippingReasonMaint, (ShippingReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject shippingReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShippingReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ShippingReasonMaint) shippingReasonMaint, (ShippingReasonMaint_Parameters) parameters, (ShippingReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject shippingReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShippingReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ShippingReasonMaint) shippingReasonMaint, (ShippingReasonMaint_Parameters) parameters, (ShippingReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject shippingReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShippingReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ShippingReasonMaint) shippingReasonMaint, (ShippingReasonMaint_LoadESigDetails_Parameters) parameters, (ShippingReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject shippingReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShippingReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((ShippingReasonMaint) shippingReasonMaint, (ShippingReasonMaint_Parameters) parameters, (ShippingReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject shippingReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShippingReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ShippingReasonMaint) shippingReasonMaint, (ShippingReasonMaint_Parameters) parameters, (ShippingReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject shippingReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShippingReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ShippingReasonMaint) shippingReasonMaint, (ShippingReasonMaint_Parameters) parameters, (ShippingReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject shippingReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShippingReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ShippingReasonMaint) shippingReasonMaint, (ShippingReasonMaint_Parameters) parameters, (ShippingReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject shippingReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShippingReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((ShippingReasonMaint) shippingReasonMaint, (ShippingReasonMaint_Parameters) parameters, (ShippingReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject shippingReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShippingReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ShippingReasonMaint) shippingReasonMaint, (ShippingReasonMaint_Parameters) parameters, (ShippingReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      result = (ShippingReasonMaint_Result) null;
      try
      {
        ShippingReasonMaintMethod[] methods = new ShippingReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IShippingReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ShippingReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ShippingReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ShippingReasonMaint cdo,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      result = (ShippingReasonMaint_Result) null;
      try
      {
        return ((IShippingReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ShippingReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ShippingReasonMaint) cdo, (ShippingReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      return this.GetEnvironment((ShippingReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ShippingReasonMaint cdo,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      result = (ShippingReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShippingReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ShippingReasonMaintMethod(cdo, ShippingReasonMaintMethods.ExecuteTransaction, (ShippingReasonMaint_Parameters) null));
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
        ShippingReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ShippingReasonMaint) cdo, (ShippingReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ShippingReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ShippingReasonMaint_Request) null, out ShippingReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result)
    {
      return this.ExecuteTransaction((ShippingReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ShippingReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ShippingReasonMaintMethod(cdo, ShippingReasonMaintMethods.AddDataTransaction, (ShippingReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((ShippingReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
