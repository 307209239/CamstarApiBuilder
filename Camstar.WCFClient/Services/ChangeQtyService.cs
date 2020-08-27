// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangeQtyService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ChangeQtyService : ContainerTxnBase
  {
    public ChangeQtyService(UserProfile userProfile)
    {
      this.Initialize(typeof (IChangeQtyService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ChangeQty changeQty,
      ChangeQty_Parameters parameters,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      result = (ChangeQty_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) changeQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeQtyService) this._Channel).CreateParametricData(this._UserProfile, changeQty, parameters, request, out result) : this.AddMethod((Method) new ChangeQtyMethod(changeQty, ChangeQtyMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) changeQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ChangeQty) null, (ChangeQty_Parameters) null, (ChangeQty_Request) null, out ChangeQty_Result _);
    }

    public ResultStatus CreateParametricData(ChangeQty changeQty)
    {
      return this.CreateParametricData(changeQty, (ChangeQty_Parameters) null, (ChangeQty_Request) null, out ChangeQty_Result _);
    }

    public ResultStatus CreateParametricData(
      ChangeQty changeQty,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      return this.CreateParametricData(changeQty, (ChangeQty_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ChangeQty changeQty,
      ChangeQty_Parameters parameters,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      result = (ChangeQty_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) changeQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeQtyService) this._Channel).GetActions(this._UserProfile, changeQty, parameters, request, out result) : this.AddMethod((Method) new ChangeQtyMethod(changeQty, ChangeQtyMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) changeQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ChangeQty) null, (ChangeQty_Parameters) null, (ChangeQty_Request) null, out ChangeQty_Result _);
    }

    public ResultStatus GetActions(ChangeQty changeQty)
    {
      return this.GetActions(changeQty, (ChangeQty_Parameters) null, (ChangeQty_Request) null, out ChangeQty_Result _);
    }

    public ResultStatus GetActions(
      ChangeQty changeQty,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      return this.GetActions(changeQty, (ChangeQty_Parameters) null, request, out result);
    }

    public ResultStatus GetChangeQtyDetails(
      ChangeQty changeQty,
      ChangeQty_GetChangeQtyDetails_Parameters parameters,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      result = (ChangeQty_Result) null;
      this.OnBeforeCall(nameof (GetChangeQtyDetails), (DCObject) changeQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeQtyService) this._Channel).GetChangeQtyDetails(this._UserProfile, changeQty, parameters, request, out result) : this.AddMethod((Method) new ChangeQtyMethod(changeQty, ChangeQtyMethods.GetChangeQtyDetails, (ChangeQty_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetChangeQtyDetails), res, (DCObject) changeQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetChangeQtyDetails()
    {
      return this.GetChangeQtyDetails((ChangeQty) null, (ChangeQty_GetChangeQtyDetails_Parameters) null, (ChangeQty_Request) null, out ChangeQty_Result _);
    }

    public ResultStatus GetChangeQtyDetails(ChangeQty changeQty)
    {
      return this.GetChangeQtyDetails(changeQty, (ChangeQty_GetChangeQtyDetails_Parameters) null, (ChangeQty_Request) null, out ChangeQty_Result _);
    }

    public ResultStatus GetChangeQtyDetails(
      ChangeQty changeQty,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      return this.GetChangeQtyDetails(changeQty, (ChangeQty_GetChangeQtyDetails_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ChangeQty changeQty,
      ChangeQty_Parameters parameters,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      result = (ChangeQty_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) changeQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeQtyService) this._Channel).GetDataPoints(this._UserProfile, changeQty, parameters, request, out result) : this.AddMethod((Method) new ChangeQtyMethod(changeQty, ChangeQtyMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) changeQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ChangeQty) null, (ChangeQty_Parameters) null, (ChangeQty_Request) null, out ChangeQty_Result _);
    }

    public ResultStatus GetDataPoints(ChangeQty changeQty)
    {
      return this.GetDataPoints(changeQty, (ChangeQty_Parameters) null, (ChangeQty_Request) null, out ChangeQty_Result _);
    }

    public ResultStatus GetDataPoints(
      ChangeQty changeQty,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      return this.GetDataPoints(changeQty, (ChangeQty_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ChangeQty changeQty,
      ChangeQty_Parameters parameters,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      result = (ChangeQty_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) changeQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeQtyService) this._Channel).GetWIPMsgs(this._UserProfile, changeQty, parameters, request, out result) : this.AddMethod((Method) new ChangeQtyMethod(changeQty, ChangeQtyMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) changeQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ChangeQty) null, (ChangeQty_Parameters) null, (ChangeQty_Request) null, out ChangeQty_Result _);
    }

    public ResultStatus GetWIPMsgs(ChangeQty changeQty)
    {
      return this.GetWIPMsgs(changeQty, (ChangeQty_Parameters) null, (ChangeQty_Request) null, out ChangeQty_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChangeQty changeQty,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      return this.GetWIPMsgs(changeQty, (ChangeQty_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ChangeQty changeQty,
      ChangeQty_Parameters parameters,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      result = (ChangeQty_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) changeQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeQtyService) this._Channel).Load(this._UserProfile, changeQty, parameters, request, out result) : this.AddMethod((Method) new ChangeQtyMethod(changeQty, ChangeQtyMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) changeQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ChangeQty) null, (ChangeQty_Parameters) null, (ChangeQty_Request) null, out ChangeQty_Result _);
    }

    public ResultStatus Load(ChangeQty changeQty)
    {
      return this.Load(changeQty, (ChangeQty_Parameters) null, (ChangeQty_Request) null, out ChangeQty_Result _);
    }

    public ResultStatus Load(
      ChangeQty changeQty,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      return this.Load(changeQty, (ChangeQty_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ChangeQty changeQty,
      ChangeQty_LoadESigDetails_Parameters parameters,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      result = (ChangeQty_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) changeQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeQtyService) this._Channel).LoadESigDetails(this._UserProfile, changeQty, parameters, request, out result) : this.AddMethod((Method) new ChangeQtyMethod(changeQty, ChangeQtyMethods.LoadESigDetails, (ChangeQty_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) changeQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ChangeQty) null, (ChangeQty_LoadESigDetails_Parameters) null, (ChangeQty_Request) null, out ChangeQty_Result _);
    }

    public ResultStatus LoadESigDetails(ChangeQty changeQty)
    {
      return this.LoadESigDetails(changeQty, (ChangeQty_LoadESigDetails_Parameters) null, (ChangeQty_Request) null, out ChangeQty_Result _);
    }

    public ResultStatus LoadESigDetails(
      ChangeQty changeQty,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      return this.LoadESigDetails(changeQty, (ChangeQty_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ChangeQty changeQty,
      ChangeQty_Parameters parameters,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      result = (ChangeQty_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) changeQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeQtyService) this._Channel).ProcessComputation(this._UserProfile, changeQty, parameters, request, out result) : this.AddMethod((Method) new ChangeQtyMethod(changeQty, ChangeQtyMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) changeQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ChangeQty) null, (ChangeQty_Parameters) null, (ChangeQty_Request) null, out ChangeQty_Result _);
    }

    public ResultStatus ProcessComputation(ChangeQty changeQty)
    {
      return this.ProcessComputation(changeQty, (ChangeQty_Parameters) null, (ChangeQty_Request) null, out ChangeQty_Result _);
    }

    public ResultStatus ProcessComputation(
      ChangeQty changeQty,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      return this.ProcessComputation(changeQty, (ChangeQty_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ChangeQty changeQty,
      ChangeQty_Parameters parameters,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      result = (ChangeQty_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) changeQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeQtyService) this._Channel).ResolveParametricData(this._UserProfile, changeQty, parameters, request, out result) : this.AddMethod((Method) new ChangeQtyMethod(changeQty, ChangeQtyMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) changeQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ChangeQty) null, (ChangeQty_Parameters) null, (ChangeQty_Request) null, out ChangeQty_Result _);
    }

    public ResultStatus ResolveParametricData(ChangeQty changeQty)
    {
      return this.ResolveParametricData(changeQty, (ChangeQty_Parameters) null, (ChangeQty_Request) null, out ChangeQty_Result _);
    }

    public ResultStatus ResolveParametricData(
      ChangeQty changeQty,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      return this.ResolveParametricData(changeQty, (ChangeQty_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject changeQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeQty_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ChangeQty) changeQty, (ChangeQty_Parameters) parameters, (ChangeQty_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject changeQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeQty_Result result1;
        ResultStatus actions = this.GetActions((ChangeQty) changeQty, (ChangeQty_Parameters) parameters, (ChangeQty_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject changeQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeQty_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ChangeQty) changeQty, (ChangeQty_Parameters) parameters, (ChangeQty_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject changeQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeQty_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ChangeQty) changeQty, (ChangeQty_LoadESigDetails_Parameters) parameters, (ChangeQty_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject changeQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeQty_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ChangeQty) changeQty, (ChangeQty_Parameters) parameters, (ChangeQty_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject changeQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeQty_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ChangeQty) changeQty, (ChangeQty_Parameters) parameters, (ChangeQty_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject changeQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeQty_Result result1;
        ResultStatus resultStatus = this.Load((ChangeQty) changeQty, (ChangeQty_Parameters) parameters, (ChangeQty_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject changeQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeQty_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ChangeQty) changeQty, (ChangeQty_Parameters) parameters, (ChangeQty_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      result = (ChangeQty_Result) null;
      try
      {
        ChangeQtyMethod[] methods = new ChangeQtyMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IChangeQtyService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ChangeQty_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ChangeQty_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeQty cdo,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      result = (ChangeQty_Result) null;
      try
      {
        return ((IChangeQtyService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ChangeQty_Result result1;
        ResultStatus environment = this.GetEnvironment((ChangeQty) cdo, (ChangeQty_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      return this.GetEnvironment((ChangeQty) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ChangeQty cdo,
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      result = (ChangeQty_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeQtyService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ChangeQtyMethod(cdo, ChangeQtyMethods.ExecuteTransaction, (ChangeQty_Parameters) null));
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
        ChangeQty_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ChangeQty) cdo, (ChangeQty_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ChangeQty cdo)
    {
      return this.ExecuteTransaction(cdo, (ChangeQty_Request) null, out ChangeQty_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ChangeQty_Request request,
      out ChangeQty_Result result)
    {
      return this.ExecuteTransaction((ChangeQty) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ChangeQty cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ChangeQtyMethod(cdo, ChangeQtyMethods.AddDataTransaction, (ChangeQty_Parameters) null));
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
        return this.AddDataTransaction((ChangeQty) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
