// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerStatusChangesService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ContainerStatusChangesService : ContainersTxnBase
  {
    public ContainerStatusChangesService(UserProfile userProfile)
    {
      this.Initialize(typeof (IContainerStatusChangesService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ContainerStatusChanges containerStatusChanges,
      ContainerStatusChanges_Parameters parameters,
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      result = (ContainerStatusChanges_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) containerStatusChanges, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerStatusChangesService) this._Channel).CreateParametricData(this._UserProfile, containerStatusChanges, parameters, request, out result) : this.AddMethod((Method) new ContainerStatusChangesMethod(containerStatusChanges, ContainerStatusChangesMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) containerStatusChanges, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ContainerStatusChanges) null, (ContainerStatusChanges_Parameters) null, (ContainerStatusChanges_Request) null, out ContainerStatusChanges_Result _);
    }

    public ResultStatus CreateParametricData(
      ContainerStatusChanges containerStatusChanges)
    {
      return this.CreateParametricData(containerStatusChanges, (ContainerStatusChanges_Parameters) null, (ContainerStatusChanges_Request) null, out ContainerStatusChanges_Result _);
    }

    public ResultStatus CreateParametricData(
      ContainerStatusChanges containerStatusChanges,
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      return this.CreateParametricData(containerStatusChanges, (ContainerStatusChanges_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ContainerStatusChanges containerStatusChanges,
      ContainerStatusChanges_Parameters parameters,
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      result = (ContainerStatusChanges_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) containerStatusChanges, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerStatusChangesService) this._Channel).GetActions(this._UserProfile, containerStatusChanges, parameters, request, out result) : this.AddMethod((Method) new ContainerStatusChangesMethod(containerStatusChanges, ContainerStatusChangesMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) containerStatusChanges, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ContainerStatusChanges) null, (ContainerStatusChanges_Parameters) null, (ContainerStatusChanges_Request) null, out ContainerStatusChanges_Result _);
    }

    public ResultStatus GetActions(ContainerStatusChanges containerStatusChanges)
    {
      return this.GetActions(containerStatusChanges, (ContainerStatusChanges_Parameters) null, (ContainerStatusChanges_Request) null, out ContainerStatusChanges_Result _);
    }

    public ResultStatus GetActions(
      ContainerStatusChanges containerStatusChanges,
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      return this.GetActions(containerStatusChanges, (ContainerStatusChanges_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ContainerStatusChanges containerStatusChanges,
      ContainerStatusChanges_Parameters parameters,
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      result = (ContainerStatusChanges_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) containerStatusChanges, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerStatusChangesService) this._Channel).GetDataPoints(this._UserProfile, containerStatusChanges, parameters, request, out result) : this.AddMethod((Method) new ContainerStatusChangesMethod(containerStatusChanges, ContainerStatusChangesMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) containerStatusChanges, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ContainerStatusChanges) null, (ContainerStatusChanges_Parameters) null, (ContainerStatusChanges_Request) null, out ContainerStatusChanges_Result _);
    }

    public ResultStatus GetDataPoints(ContainerStatusChanges containerStatusChanges)
    {
      return this.GetDataPoints(containerStatusChanges, (ContainerStatusChanges_Parameters) null, (ContainerStatusChanges_Request) null, out ContainerStatusChanges_Result _);
    }

    public ResultStatus GetDataPoints(
      ContainerStatusChanges containerStatusChanges,
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      return this.GetDataPoints(containerStatusChanges, (ContainerStatusChanges_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ContainerStatusChanges containerStatusChanges,
      ContainerStatusChanges_Parameters parameters,
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      result = (ContainerStatusChanges_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) containerStatusChanges, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerStatusChangesService) this._Channel).GetWIPMsgs(this._UserProfile, containerStatusChanges, parameters, request, out result) : this.AddMethod((Method) new ContainerStatusChangesMethod(containerStatusChanges, ContainerStatusChangesMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) containerStatusChanges, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ContainerStatusChanges) null, (ContainerStatusChanges_Parameters) null, (ContainerStatusChanges_Request) null, out ContainerStatusChanges_Result _);
    }

    public ResultStatus GetWIPMsgs(ContainerStatusChanges containerStatusChanges)
    {
      return this.GetWIPMsgs(containerStatusChanges, (ContainerStatusChanges_Parameters) null, (ContainerStatusChanges_Request) null, out ContainerStatusChanges_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ContainerStatusChanges containerStatusChanges,
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      return this.GetWIPMsgs(containerStatusChanges, (ContainerStatusChanges_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ContainerStatusChanges containerStatusChanges,
      ContainerStatusChanges_Parameters parameters,
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      result = (ContainerStatusChanges_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) containerStatusChanges, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerStatusChangesService) this._Channel).Load(this._UserProfile, containerStatusChanges, parameters, request, out result) : this.AddMethod((Method) new ContainerStatusChangesMethod(containerStatusChanges, ContainerStatusChangesMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) containerStatusChanges, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ContainerStatusChanges) null, (ContainerStatusChanges_Parameters) null, (ContainerStatusChanges_Request) null, out ContainerStatusChanges_Result _);
    }

    public ResultStatus Load(ContainerStatusChanges containerStatusChanges)
    {
      return this.Load(containerStatusChanges, (ContainerStatusChanges_Parameters) null, (ContainerStatusChanges_Request) null, out ContainerStatusChanges_Result _);
    }

    public ResultStatus Load(
      ContainerStatusChanges containerStatusChanges,
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      return this.Load(containerStatusChanges, (ContainerStatusChanges_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ContainerStatusChanges containerStatusChanges,
      ContainerStatusChanges_LoadESigDetails_Parameters parameters,
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      result = (ContainerStatusChanges_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) containerStatusChanges, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerStatusChangesService) this._Channel).LoadESigDetails(this._UserProfile, containerStatusChanges, parameters, request, out result) : this.AddMethod((Method) new ContainerStatusChangesMethod(containerStatusChanges, ContainerStatusChangesMethods.LoadESigDetails, (ContainerStatusChanges_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) containerStatusChanges, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ContainerStatusChanges) null, (ContainerStatusChanges_LoadESigDetails_Parameters) null, (ContainerStatusChanges_Request) null, out ContainerStatusChanges_Result _);
    }

    public ResultStatus LoadESigDetails(ContainerStatusChanges containerStatusChanges)
    {
      return this.LoadESigDetails(containerStatusChanges, (ContainerStatusChanges_LoadESigDetails_Parameters) null, (ContainerStatusChanges_Request) null, out ContainerStatusChanges_Result _);
    }

    public ResultStatus LoadESigDetails(
      ContainerStatusChanges containerStatusChanges,
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      return this.LoadESigDetails(containerStatusChanges, (ContainerStatusChanges_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ContainerStatusChanges containerStatusChanges,
      ContainerStatusChanges_Parameters parameters,
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      result = (ContainerStatusChanges_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) containerStatusChanges, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerStatusChangesService) this._Channel).ProcessComputation(this._UserProfile, containerStatusChanges, parameters, request, out result) : this.AddMethod((Method) new ContainerStatusChangesMethod(containerStatusChanges, ContainerStatusChangesMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) containerStatusChanges, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ContainerStatusChanges) null, (ContainerStatusChanges_Parameters) null, (ContainerStatusChanges_Request) null, out ContainerStatusChanges_Result _);
    }

    public ResultStatus ProcessComputation(ContainerStatusChanges containerStatusChanges)
    {
      return this.ProcessComputation(containerStatusChanges, (ContainerStatusChanges_Parameters) null, (ContainerStatusChanges_Request) null, out ContainerStatusChanges_Result _);
    }

    public ResultStatus ProcessComputation(
      ContainerStatusChanges containerStatusChanges,
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      return this.ProcessComputation(containerStatusChanges, (ContainerStatusChanges_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ContainerStatusChanges containerStatusChanges,
      ContainerStatusChanges_Parameters parameters,
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      result = (ContainerStatusChanges_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) containerStatusChanges, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerStatusChangesService) this._Channel).ResolveParametricData(this._UserProfile, containerStatusChanges, parameters, request, out result) : this.AddMethod((Method) new ContainerStatusChangesMethod(containerStatusChanges, ContainerStatusChangesMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) containerStatusChanges, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ContainerStatusChanges) null, (ContainerStatusChanges_Parameters) null, (ContainerStatusChanges_Request) null, out ContainerStatusChanges_Result _);
    }

    public ResultStatus ResolveParametricData(
      ContainerStatusChanges containerStatusChanges)
    {
      return this.ResolveParametricData(containerStatusChanges, (ContainerStatusChanges_Parameters) null, (ContainerStatusChanges_Request) null, out ContainerStatusChanges_Result _);
    }

    public ResultStatus ResolveParametricData(
      ContainerStatusChanges containerStatusChanges,
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      return this.ResolveParametricData(containerStatusChanges, (ContainerStatusChanges_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject containerStatusChanges,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerStatusChanges_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ContainerStatusChanges) containerStatusChanges, (ContainerStatusChanges_Parameters) parameters, (ContainerStatusChanges_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject containerStatusChanges,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerStatusChanges_Result result1;
        ResultStatus actions = this.GetActions((ContainerStatusChanges) containerStatusChanges, (ContainerStatusChanges_Parameters) parameters, (ContainerStatusChanges_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject containerStatusChanges,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerStatusChanges_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ContainerStatusChanges) containerStatusChanges, (ContainerStatusChanges_Parameters) parameters, (ContainerStatusChanges_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject containerStatusChanges,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerStatusChanges_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ContainerStatusChanges) containerStatusChanges, (ContainerStatusChanges_LoadESigDetails_Parameters) parameters, (ContainerStatusChanges_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject containerStatusChanges,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerStatusChanges_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ContainerStatusChanges) containerStatusChanges, (ContainerStatusChanges_Parameters) parameters, (ContainerStatusChanges_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject containerStatusChanges,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerStatusChanges_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ContainerStatusChanges) containerStatusChanges, (ContainerStatusChanges_Parameters) parameters, (ContainerStatusChanges_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject containerStatusChanges,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerStatusChanges_Result result1;
        ResultStatus resultStatus = this.Load((ContainerStatusChanges) containerStatusChanges, (ContainerStatusChanges_Parameters) parameters, (ContainerStatusChanges_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject containerStatusChanges,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerStatusChanges_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ContainerStatusChanges) containerStatusChanges, (ContainerStatusChanges_Parameters) parameters, (ContainerStatusChanges_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      result = (ContainerStatusChanges_Result) null;
      try
      {
        ContainerStatusChangesMethod[] methods = new ContainerStatusChangesMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IContainerStatusChangesService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ContainerStatusChanges_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ContainerStatusChanges_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerStatusChanges cdo,
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      result = (ContainerStatusChanges_Result) null;
      try
      {
        return ((IContainerStatusChangesService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ContainerStatusChanges_Result result1;
        ResultStatus environment = this.GetEnvironment((ContainerStatusChanges) cdo, (ContainerStatusChanges_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      return this.GetEnvironment((ContainerStatusChanges) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ContainerStatusChanges cdo,
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      result = (ContainerStatusChanges_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerStatusChangesService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ContainerStatusChangesMethod(cdo, ContainerStatusChangesMethods.ExecuteTransaction, (ContainerStatusChanges_Parameters) null));
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
        ContainerStatusChanges_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ContainerStatusChanges) cdo, (ContainerStatusChanges_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ContainerStatusChanges cdo)
    {
      return this.ExecuteTransaction(cdo, (ContainerStatusChanges_Request) null, out ContainerStatusChanges_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ContainerStatusChanges_Request request,
      out ContainerStatusChanges_Result result)
    {
      return this.ExecuteTransaction((ContainerStatusChanges) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ContainerStatusChanges cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ContainerStatusChangesMethod(cdo, ContainerStatusChangesMethods.AddDataTransaction, (ContainerStatusChanges_Parameters) null));
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
        return this.AddDataTransaction((ContainerStatusChanges) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
