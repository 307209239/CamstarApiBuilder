// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RemoteReceiveService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RemoteReceiveService : CompoundTxnBase
  {
    public RemoteReceiveService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRemoteReceiveService), userProfile);
    }

    public ResultStatus CreateParametricData(
      RemoteReceive remoteReceive,
      RemoteReceive_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      result = (RemoteReceive_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) remoteReceive, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteReceiveService) this._Channel).CreateParametricData(this._UserProfile, remoteReceive, parameters, request, out result) : this.AddMethod((Method) new RemoteReceiveMethod(remoteReceive, RemoteReceiveMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) remoteReceive, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((RemoteReceive) null, (RemoteReceive_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus CreateParametricData(RemoteReceive remoteReceive)
    {
      return this.CreateParametricData(remoteReceive, (RemoteReceive_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus CreateParametricData(
      RemoteReceive remoteReceive,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      return this.CreateParametricData(remoteReceive, (RemoteReceive_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      RemoteReceive remoteReceive,
      RemoteReceive_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      result = (RemoteReceive_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) remoteReceive, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteReceiveService) this._Channel).GetActions(this._UserProfile, remoteReceive, parameters, request, out result) : this.AddMethod((Method) new RemoteReceiveMethod(remoteReceive, RemoteReceiveMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) remoteReceive, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((RemoteReceive) null, (RemoteReceive_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus GetActions(RemoteReceive remoteReceive)
    {
      return this.GetActions(remoteReceive, (RemoteReceive_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus GetActions(
      RemoteReceive remoteReceive,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      return this.GetActions(remoteReceive, (RemoteReceive_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      RemoteReceive remoteReceive,
      RemoteReceive_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      result = (RemoteReceive_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) remoteReceive, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteReceiveService) this._Channel).GetDataPoints(this._UserProfile, remoteReceive, parameters, request, out result) : this.AddMethod((Method) new RemoteReceiveMethod(remoteReceive, RemoteReceiveMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) remoteReceive, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((RemoteReceive) null, (RemoteReceive_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus GetDataPoints(RemoteReceive remoteReceive)
    {
      return this.GetDataPoints(remoteReceive, (RemoteReceive_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus GetDataPoints(
      RemoteReceive remoteReceive,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      return this.GetDataPoints(remoteReceive, (RemoteReceive_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RemoteReceive remoteReceive,
      RemoteReceive_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      result = (RemoteReceive_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) remoteReceive, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteReceiveService) this._Channel).GetWIPMsgs(this._UserProfile, remoteReceive, parameters, request, out result) : this.AddMethod((Method) new RemoteReceiveMethod(remoteReceive, RemoteReceiveMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) remoteReceive, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RemoteReceive) null, (RemoteReceive_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus GetWIPMsgs(RemoteReceive remoteReceive)
    {
      return this.GetWIPMsgs(remoteReceive, (RemoteReceive_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RemoteReceive remoteReceive,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      return this.GetWIPMsgs(remoteReceive, (RemoteReceive_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RemoteReceive remoteReceive,
      RemoteReceive_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      result = (RemoteReceive_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) remoteReceive, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteReceiveService) this._Channel).Load(this._UserProfile, remoteReceive, parameters, request, out result) : this.AddMethod((Method) new RemoteReceiveMethod(remoteReceive, RemoteReceiveMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) remoteReceive, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RemoteReceive) null, (RemoteReceive_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus Load(RemoteReceive remoteReceive)
    {
      return this.Load(remoteReceive, (RemoteReceive_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus Load(
      RemoteReceive remoteReceive,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      return this.Load(remoteReceive, (RemoteReceive_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RemoteReceive remoteReceive,
      RemoteReceive_LoadESigDetails_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      result = (RemoteReceive_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) remoteReceive, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteReceiveService) this._Channel).LoadESigDetails(this._UserProfile, remoteReceive, parameters, request, out result) : this.AddMethod((Method) new RemoteReceiveMethod(remoteReceive, RemoteReceiveMethods.LoadESigDetails, (RemoteReceive_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) remoteReceive, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RemoteReceive) null, (RemoteReceive_LoadESigDetails_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus LoadESigDetails(RemoteReceive remoteReceive)
    {
      return this.LoadESigDetails(remoteReceive, (RemoteReceive_LoadESigDetails_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus LoadESigDetails(
      RemoteReceive remoteReceive,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      return this.LoadESigDetails(remoteReceive, (RemoteReceive_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      RemoteReceive remoteReceive,
      RemoteReceive_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      result = (RemoteReceive_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) remoteReceive, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteReceiveService) this._Channel).ProcessComputation(this._UserProfile, remoteReceive, parameters, request, out result) : this.AddMethod((Method) new RemoteReceiveMethod(remoteReceive, RemoteReceiveMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) remoteReceive, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((RemoteReceive) null, (RemoteReceive_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus ProcessComputation(RemoteReceive remoteReceive)
    {
      return this.ProcessComputation(remoteReceive, (RemoteReceive_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus ProcessComputation(
      RemoteReceive remoteReceive,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      return this.ProcessComputation(remoteReceive, (RemoteReceive_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      RemoteReceive remoteReceive,
      RemoteReceive_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      result = (RemoteReceive_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) remoteReceive, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteReceiveService) this._Channel).ResolveParametricData(this._UserProfile, remoteReceive, parameters, request, out result) : this.AddMethod((Method) new RemoteReceiveMethod(remoteReceive, RemoteReceiveMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) remoteReceive, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((RemoteReceive) null, (RemoteReceive_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus ResolveParametricData(RemoteReceive remoteReceive)
    {
      return this.ResolveParametricData(remoteReceive, (RemoteReceive_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus ResolveParametricData(
      RemoteReceive remoteReceive,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      return this.ResolveParametricData(remoteReceive, (RemoteReceive_Parameters) null, request, out result);
    }

    public ResultStatus SetupRemoteStart(
      RemoteReceive remoteReceive,
      RemoteReceive_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      result = (RemoteReceive_Result) null;
      this.OnBeforeCall(nameof (SetupRemoteStart), (DCObject) remoteReceive, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteReceiveService) this._Channel).SetupRemoteStart(this._UserProfile, remoteReceive, parameters, request, out result) : this.AddMethod((Method) new RemoteReceiveMethod(remoteReceive, RemoteReceiveMethods.SetupRemoteStart, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetupRemoteStart), res, (DCObject) remoteReceive, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetupRemoteStart()
    {
      return this.SetupRemoteStart((RemoteReceive) null, (RemoteReceive_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus SetupRemoteStart(RemoteReceive remoteReceive)
    {
      return this.SetupRemoteStart(remoteReceive, (RemoteReceive_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus SetupRemoteStart(
      RemoteReceive remoteReceive,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      return this.SetupRemoteStart(remoteReceive, (RemoteReceive_Parameters) null, request, out result);
    }

    public ResultStatus SetupShip(
      RemoteReceive remoteReceive,
      RemoteReceive_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      result = (RemoteReceive_Result) null;
      this.OnBeforeCall(nameof (SetupShip), (DCObject) remoteReceive, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteReceiveService) this._Channel).SetupShip(this._UserProfile, remoteReceive, parameters, request, out result) : this.AddMethod((Method) new RemoteReceiveMethod(remoteReceive, RemoteReceiveMethods.SetupShip, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetupShip), res, (DCObject) remoteReceive, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetupShip()
    {
      return this.SetupShip((RemoteReceive) null, (RemoteReceive_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus SetupShip(RemoteReceive remoteReceive)
    {
      return this.SetupShip(remoteReceive, (RemoteReceive_Parameters) null, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus SetupShip(
      RemoteReceive remoteReceive,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      return this.SetupShip(remoteReceive, (RemoteReceive_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject remoteReceive,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoteReceive_Result result1;
        ResultStatus parametricData = this.CreateParametricData((RemoteReceive) remoteReceive, (RemoteReceive_Parameters) parameters, (RemoteReceive_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject remoteReceive,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoteReceive_Result result1;
        ResultStatus actions = this.GetActions((RemoteReceive) remoteReceive, (RemoteReceive_Parameters) parameters, (RemoteReceive_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject remoteReceive,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoteReceive_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((RemoteReceive) remoteReceive, (RemoteReceive_Parameters) parameters, (RemoteReceive_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject remoteReceive,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoteReceive_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RemoteReceive) remoteReceive, (RemoteReceive_LoadESigDetails_Parameters) parameters, (RemoteReceive_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject remoteReceive,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoteReceive_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((RemoteReceive) remoteReceive, (RemoteReceive_Parameters) parameters, (RemoteReceive_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject remoteReceive,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoteReceive_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((RemoteReceive) remoteReceive, (RemoteReceive_Parameters) parameters, (RemoteReceive_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject remoteReceive,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoteReceive_Result result1;
        ResultStatus resultStatus = this.Load((RemoteReceive) remoteReceive, (RemoteReceive_Parameters) parameters, (RemoteReceive_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject remoteReceive,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoteReceive_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RemoteReceive) remoteReceive, (RemoteReceive_Parameters) parameters, (RemoteReceive_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      result = (RemoteReceive_Result) null;
      try
      {
        RemoteReceiveMethod[] methods = new RemoteReceiveMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRemoteReceiveService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        RemoteReceive_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RemoteReceive_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RemoteReceive cdo,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      result = (RemoteReceive_Result) null;
      try
      {
        return ((IRemoteReceiveService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        RemoteReceive_Result result1;
        ResultStatus environment = this.GetEnvironment((RemoteReceive) cdo, (RemoteReceive_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      return this.GetEnvironment((RemoteReceive) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RemoteReceive cdo,
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      result = (RemoteReceive_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoteReceiveService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RemoteReceiveMethod(cdo, RemoteReceiveMethods.ExecuteTransaction, (RemoteReceive_Parameters) null));
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
        RemoteReceive_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RemoteReceive) cdo, (RemoteReceive_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RemoteReceive cdo)
    {
      return this.ExecuteTransaction(cdo, (RemoteReceive_Request) null, out RemoteReceive_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RemoteReceive_Request request,
      out RemoteReceive_Result result)
    {
      return this.ExecuteTransaction((RemoteReceive) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RemoteReceive cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RemoteReceiveMethod(cdo, RemoteReceiveMethods.AddDataTransaction, (RemoteReceive_Parameters) null));
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
        return this.AddDataTransaction((RemoteReceive) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
