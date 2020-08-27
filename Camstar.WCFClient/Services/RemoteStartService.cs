// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RemoteStartService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RemoteStartService : ContainerTxnBase
  {
    public RemoteStartService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRemoteStartService), userProfile);
    }

    public ResultStatus CreateParametricData(
      RemoteStart remoteStart,
      RemoteStart_Parameters parameters,
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      result = (RemoteStart_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) remoteStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteStartService) this._Channel).CreateParametricData(this._UserProfile, remoteStart, parameters, request, out result) : this.AddMethod((Method) new RemoteStartMethod(remoteStart, RemoteStartMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) remoteStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((RemoteStart) null, (RemoteStart_Parameters) null, (RemoteStart_Request) null, out RemoteStart_Result _);
    }

    public ResultStatus CreateParametricData(RemoteStart remoteStart)
    {
      return this.CreateParametricData(remoteStart, (RemoteStart_Parameters) null, (RemoteStart_Request) null, out RemoteStart_Result _);
    }

    public ResultStatus CreateParametricData(
      RemoteStart remoteStart,
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      return this.CreateParametricData(remoteStart, (RemoteStart_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      RemoteStart remoteStart,
      RemoteStart_Parameters parameters,
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      result = (RemoteStart_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) remoteStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteStartService) this._Channel).GetActions(this._UserProfile, remoteStart, parameters, request, out result) : this.AddMethod((Method) new RemoteStartMethod(remoteStart, RemoteStartMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) remoteStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((RemoteStart) null, (RemoteStart_Parameters) null, (RemoteStart_Request) null, out RemoteStart_Result _);
    }

    public ResultStatus GetActions(RemoteStart remoteStart)
    {
      return this.GetActions(remoteStart, (RemoteStart_Parameters) null, (RemoteStart_Request) null, out RemoteStart_Result _);
    }

    public ResultStatus GetActions(
      RemoteStart remoteStart,
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      return this.GetActions(remoteStart, (RemoteStart_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      RemoteStart remoteStart,
      RemoteStart_Parameters parameters,
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      result = (RemoteStart_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) remoteStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteStartService) this._Channel).GetDataPoints(this._UserProfile, remoteStart, parameters, request, out result) : this.AddMethod((Method) new RemoteStartMethod(remoteStart, RemoteStartMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) remoteStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((RemoteStart) null, (RemoteStart_Parameters) null, (RemoteStart_Request) null, out RemoteStart_Result _);
    }

    public ResultStatus GetDataPoints(RemoteStart remoteStart)
    {
      return this.GetDataPoints(remoteStart, (RemoteStart_Parameters) null, (RemoteStart_Request) null, out RemoteStart_Result _);
    }

    public ResultStatus GetDataPoints(
      RemoteStart remoteStart,
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      return this.GetDataPoints(remoteStart, (RemoteStart_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RemoteStart remoteStart,
      RemoteStart_Parameters parameters,
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      result = (RemoteStart_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) remoteStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteStartService) this._Channel).GetWIPMsgs(this._UserProfile, remoteStart, parameters, request, out result) : this.AddMethod((Method) new RemoteStartMethod(remoteStart, RemoteStartMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) remoteStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RemoteStart) null, (RemoteStart_Parameters) null, (RemoteStart_Request) null, out RemoteStart_Result _);
    }

    public ResultStatus GetWIPMsgs(RemoteStart remoteStart)
    {
      return this.GetWIPMsgs(remoteStart, (RemoteStart_Parameters) null, (RemoteStart_Request) null, out RemoteStart_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RemoteStart remoteStart,
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      return this.GetWIPMsgs(remoteStart, (RemoteStart_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RemoteStart remoteStart,
      RemoteStart_Parameters parameters,
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      result = (RemoteStart_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) remoteStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteStartService) this._Channel).Load(this._UserProfile, remoteStart, parameters, request, out result) : this.AddMethod((Method) new RemoteStartMethod(remoteStart, RemoteStartMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) remoteStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RemoteStart) null, (RemoteStart_Parameters) null, (RemoteStart_Request) null, out RemoteStart_Result _);
    }

    public ResultStatus Load(RemoteStart remoteStart)
    {
      return this.Load(remoteStart, (RemoteStart_Parameters) null, (RemoteStart_Request) null, out RemoteStart_Result _);
    }

    public ResultStatus Load(
      RemoteStart remoteStart,
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      return this.Load(remoteStart, (RemoteStart_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RemoteStart remoteStart,
      RemoteStart_LoadESigDetails_Parameters parameters,
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      result = (RemoteStart_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) remoteStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteStartService) this._Channel).LoadESigDetails(this._UserProfile, remoteStart, parameters, request, out result) : this.AddMethod((Method) new RemoteStartMethod(remoteStart, RemoteStartMethods.LoadESigDetails, (RemoteStart_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) remoteStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RemoteStart) null, (RemoteStart_LoadESigDetails_Parameters) null, (RemoteStart_Request) null, out RemoteStart_Result _);
    }

    public ResultStatus LoadESigDetails(RemoteStart remoteStart)
    {
      return this.LoadESigDetails(remoteStart, (RemoteStart_LoadESigDetails_Parameters) null, (RemoteStart_Request) null, out RemoteStart_Result _);
    }

    public ResultStatus LoadESigDetails(
      RemoteStart remoteStart,
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      return this.LoadESigDetails(remoteStart, (RemoteStart_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      RemoteStart remoteStart,
      RemoteStart_Parameters parameters,
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      result = (RemoteStart_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) remoteStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteStartService) this._Channel).ProcessComputation(this._UserProfile, remoteStart, parameters, request, out result) : this.AddMethod((Method) new RemoteStartMethod(remoteStart, RemoteStartMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) remoteStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((RemoteStart) null, (RemoteStart_Parameters) null, (RemoteStart_Request) null, out RemoteStart_Result _);
    }

    public ResultStatus ProcessComputation(RemoteStart remoteStart)
    {
      return this.ProcessComputation(remoteStart, (RemoteStart_Parameters) null, (RemoteStart_Request) null, out RemoteStart_Result _);
    }

    public ResultStatus ProcessComputation(
      RemoteStart remoteStart,
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      return this.ProcessComputation(remoteStart, (RemoteStart_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      RemoteStart remoteStart,
      RemoteStart_Parameters parameters,
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      result = (RemoteStart_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) remoteStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteStartService) this._Channel).ResolveParametricData(this._UserProfile, remoteStart, parameters, request, out result) : this.AddMethod((Method) new RemoteStartMethod(remoteStart, RemoteStartMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) remoteStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((RemoteStart) null, (RemoteStart_Parameters) null, (RemoteStart_Request) null, out RemoteStart_Result _);
    }

    public ResultStatus ResolveParametricData(RemoteStart remoteStart)
    {
      return this.ResolveParametricData(remoteStart, (RemoteStart_Parameters) null, (RemoteStart_Request) null, out RemoteStart_Result _);
    }

    public ResultStatus ResolveParametricData(
      RemoteStart remoteStart,
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      return this.ResolveParametricData(remoteStart, (RemoteStart_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject remoteStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoteStart_Result result1;
        ResultStatus parametricData = this.CreateParametricData((RemoteStart) remoteStart, (RemoteStart_Parameters) parameters, (RemoteStart_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject remoteStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoteStart_Result result1;
        ResultStatus actions = this.GetActions((RemoteStart) remoteStart, (RemoteStart_Parameters) parameters, (RemoteStart_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject remoteStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoteStart_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((RemoteStart) remoteStart, (RemoteStart_Parameters) parameters, (RemoteStart_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject remoteStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoteStart_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RemoteStart) remoteStart, (RemoteStart_LoadESigDetails_Parameters) parameters, (RemoteStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject remoteStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoteStart_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((RemoteStart) remoteStart, (RemoteStart_Parameters) parameters, (RemoteStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject remoteStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoteStart_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((RemoteStart) remoteStart, (RemoteStart_Parameters) parameters, (RemoteStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject remoteStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoteStart_Result result1;
        ResultStatus resultStatus = this.Load((RemoteStart) remoteStart, (RemoteStart_Parameters) parameters, (RemoteStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject remoteStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoteStart_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RemoteStart) remoteStart, (RemoteStart_Parameters) parameters, (RemoteStart_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      result = (RemoteStart_Result) null;
      try
      {
        RemoteStartMethod[] methods = new RemoteStartMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRemoteStartService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        RemoteStart_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RemoteStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RemoteStart cdo,
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      result = (RemoteStart_Result) null;
      try
      {
        return ((IRemoteStartService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        RemoteStart_Result result1;
        ResultStatus environment = this.GetEnvironment((RemoteStart) cdo, (RemoteStart_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      return this.GetEnvironment((RemoteStart) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RemoteStart cdo,
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      result = (RemoteStart_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteStartService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RemoteStartMethod(cdo, RemoteStartMethods.ExecuteTransaction, (RemoteStart_Parameters) null));
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
        RemoteStart_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RemoteStart) cdo, (RemoteStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RemoteStart cdo)
    {
      return this.ExecuteTransaction(cdo, (RemoteStart_Request) null, out RemoteStart_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RemoteStart_Request request,
      out RemoteStart_Result result)
    {
      return this.ExecuteTransaction((RemoteStart) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RemoteStart cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RemoteStartMethod(cdo, RemoteStartMethods.AddDataTransaction, (RemoteStart_Parameters) null));
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
        return this.AddDataTransaction((RemoteStart) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
