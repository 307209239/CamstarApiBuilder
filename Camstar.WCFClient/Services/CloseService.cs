// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CloseService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CloseService : ContainerStatusChangeBase
  {
    public CloseService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICloseService), userProfile);
    }

    public ResultStatus CreateParametricData(
      Close close,
      Close_Parameters parameters,
      Close_Request request,
      out Close_Result result)
    {
      result = (Close_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) close, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseService) this._Channel).CreateParametricData(this._UserProfile, close, parameters, request, out result) : this.AddMethod((Method) new CloseMethod(close, CloseMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) close, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Close) null, (Close_Parameters) null, (Close_Request) null, out Close_Result _);
    }

    public ResultStatus CreateParametricData(Close close)
    {
      return this.CreateParametricData(close, (Close_Parameters) null, (Close_Request) null, out Close_Result _);
    }

    public ResultStatus CreateParametricData(
      Close close,
      Close_Request request,
      out Close_Result result)
    {
      return this.CreateParametricData(close, (Close_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Close close,
      Close_Parameters parameters,
      Close_Request request,
      out Close_Result result)
    {
      result = (Close_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) close, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseService) this._Channel).GetActions(this._UserProfile, close, parameters, request, out result) : this.AddMethod((Method) new CloseMethod(close, CloseMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) close, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Close) null, (Close_Parameters) null, (Close_Request) null, out Close_Result _);
    }

    public ResultStatus GetActions(Close close)
    {
      return this.GetActions(close, (Close_Parameters) null, (Close_Request) null, out Close_Result _);
    }

    public ResultStatus GetActions(
      Close close,
      Close_Request request,
      out Close_Result result)
    {
      return this.GetActions(close, (Close_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Close close,
      Close_Parameters parameters,
      Close_Request request,
      out Close_Result result)
    {
      result = (Close_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) close, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseService) this._Channel).GetDataPoints(this._UserProfile, close, parameters, request, out result) : this.AddMethod((Method) new CloseMethod(close, CloseMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) close, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Close) null, (Close_Parameters) null, (Close_Request) null, out Close_Result _);
    }

    public ResultStatus GetDataPoints(Close close)
    {
      return this.GetDataPoints(close, (Close_Parameters) null, (Close_Request) null, out Close_Result _);
    }

    public ResultStatus GetDataPoints(
      Close close,
      Close_Request request,
      out Close_Result result)
    {
      return this.GetDataPoints(close, (Close_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Close close,
      Close_Parameters parameters,
      Close_Request request,
      out Close_Result result)
    {
      result = (Close_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) close, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseService) this._Channel).GetWIPMsgs(this._UserProfile, close, parameters, request, out result) : this.AddMethod((Method) new CloseMethod(close, CloseMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) close, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Close) null, (Close_Parameters) null, (Close_Request) null, out Close_Result _);
    }

    public ResultStatus GetWIPMsgs(Close close)
    {
      return this.GetWIPMsgs(close, (Close_Parameters) null, (Close_Request) null, out Close_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Close close,
      Close_Request request,
      out Close_Result result)
    {
      return this.GetWIPMsgs(close, (Close_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Close close,
      Close_Parameters parameters,
      Close_Request request,
      out Close_Result result)
    {
      result = (Close_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) close, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseService) this._Channel).Load(this._UserProfile, close, parameters, request, out result) : this.AddMethod((Method) new CloseMethod(close, CloseMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) close, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Close) null, (Close_Parameters) null, (Close_Request) null, out Close_Result _);
    }

    public ResultStatus Load(Close close)
    {
      return this.Load(close, (Close_Parameters) null, (Close_Request) null, out Close_Result _);
    }

    public ResultStatus Load(
      Close close,
      Close_Request request,
      out Close_Result result)
    {
      return this.Load(close, (Close_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Close close,
      Close_LoadESigDetails_Parameters parameters,
      Close_Request request,
      out Close_Result result)
    {
      result = (Close_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) close, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseService) this._Channel).LoadESigDetails(this._UserProfile, close, parameters, request, out result) : this.AddMethod((Method) new CloseMethod(close, CloseMethods.LoadESigDetails, (Close_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) close, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Close) null, (Close_LoadESigDetails_Parameters) null, (Close_Request) null, out Close_Result _);
    }

    public ResultStatus LoadESigDetails(Close close)
    {
      return this.LoadESigDetails(close, (Close_LoadESigDetails_Parameters) null, (Close_Request) null, out Close_Result _);
    }

    public ResultStatus LoadESigDetails(
      Close close,
      Close_Request request,
      out Close_Result result)
    {
      return this.LoadESigDetails(close, (Close_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Close close,
      Close_Parameters parameters,
      Close_Request request,
      out Close_Result result)
    {
      result = (Close_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) close, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseService) this._Channel).ProcessComputation(this._UserProfile, close, parameters, request, out result) : this.AddMethod((Method) new CloseMethod(close, CloseMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) close, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Close) null, (Close_Parameters) null, (Close_Request) null, out Close_Result _);
    }

    public ResultStatus ProcessComputation(Close close)
    {
      return this.ProcessComputation(close, (Close_Parameters) null, (Close_Request) null, out Close_Result _);
    }

    public ResultStatus ProcessComputation(
      Close close,
      Close_Request request,
      out Close_Result result)
    {
      return this.ProcessComputation(close, (Close_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Close close,
      Close_Parameters parameters,
      Close_Request request,
      out Close_Result result)
    {
      result = (Close_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) close, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseService) this._Channel).ResolveParametricData(this._UserProfile, close, parameters, request, out result) : this.AddMethod((Method) new CloseMethod(close, CloseMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) close, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Close) null, (Close_Parameters) null, (Close_Request) null, out Close_Result _);
    }

    public ResultStatus ResolveParametricData(Close close)
    {
      return this.ResolveParametricData(close, (Close_Parameters) null, (Close_Request) null, out Close_Result _);
    }

    public ResultStatus ResolveParametricData(
      Close close,
      Close_Request request,
      out Close_Result result)
    {
      return this.ResolveParametricData(close, (Close_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject close,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Close_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Close) close, (Close_Parameters) parameters, (Close_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject close,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Close_Result result1;
        ResultStatus actions = this.GetActions((Close) close, (Close_Parameters) parameters, (Close_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject close,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Close_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Close) close, (Close_Parameters) parameters, (Close_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject close,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Close_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Close) close, (Close_LoadESigDetails_Parameters) parameters, (Close_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject close,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Close_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Close) close, (Close_Parameters) parameters, (Close_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject close,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Close_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Close) close, (Close_Parameters) parameters, (Close_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject close,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Close_Result result1;
        ResultStatus resultStatus = this.Load((Close) close, (Close_Parameters) parameters, (Close_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject close,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Close_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Close) close, (Close_Parameters) parameters, (Close_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Close_Request request,
      out Close_Result result)
    {
      result = (Close_Result) null;
      try
      {
        CloseMethod[] methods = new CloseMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICloseService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Close_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Close_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Close cdo,
      Close_Request request,
      out Close_Result result)
    {
      result = (Close_Result) null;
      try
      {
        return ((ICloseService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Close_Result result1;
        ResultStatus environment = this.GetEnvironment((Close) cdo, (Close_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(Close_Request request, out Close_Result result)
    {
      return this.GetEnvironment((Close) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Close cdo,
      Close_Request request,
      out Close_Result result)
    {
      result = (Close_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CloseMethod(cdo, CloseMethods.ExecuteTransaction, (Close_Parameters) null));
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
        Close_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Close) cdo, (Close_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Close cdo)
    {
      return this.ExecuteTransaction(cdo, (Close_Request) null, out Close_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Close_Request request,
      out Close_Result result)
    {
      return this.ExecuteTransaction((Close) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Close cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CloseMethod(cdo, CloseMethods.AddDataTransaction, (Close_Parameters) null));
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
        return this.AddDataTransaction((Close) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
