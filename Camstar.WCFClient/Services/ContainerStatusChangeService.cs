// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerStatusChangeService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ContainerStatusChangeService : ContainerTxnBase
  {
    public ContainerStatusChangeService(UserProfile userProfile)
    {
      this.Initialize(typeof (IContainerStatusChangeService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Parameters parameters,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      result = (ContainerStatusChange_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) containerStatusChange, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerStatusChangeService) this._Channel).CreateParametricData(this._UserProfile, containerStatusChange, parameters, request, out result) : this.AddMethod((Method) new ContainerStatusChangeMethod(containerStatusChange, ContainerStatusChangeMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) containerStatusChange, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ContainerStatusChange) null, (ContainerStatusChange_Parameters) null, (ContainerStatusChange_Request) null, out ContainerStatusChange_Result _);
    }

    public ResultStatus CreateParametricData(ContainerStatusChange containerStatusChange)
    {
      return this.CreateParametricData(containerStatusChange, (ContainerStatusChange_Parameters) null, (ContainerStatusChange_Request) null, out ContainerStatusChange_Result _);
    }

    public ResultStatus CreateParametricData(
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      return this.CreateParametricData(containerStatusChange, (ContainerStatusChange_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Parameters parameters,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      result = (ContainerStatusChange_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) containerStatusChange, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerStatusChangeService) this._Channel).GetActions(this._UserProfile, containerStatusChange, parameters, request, out result) : this.AddMethod((Method) new ContainerStatusChangeMethod(containerStatusChange, ContainerStatusChangeMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) containerStatusChange, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ContainerStatusChange) null, (ContainerStatusChange_Parameters) null, (ContainerStatusChange_Request) null, out ContainerStatusChange_Result _);
    }

    public ResultStatus GetActions(ContainerStatusChange containerStatusChange)
    {
      return this.GetActions(containerStatusChange, (ContainerStatusChange_Parameters) null, (ContainerStatusChange_Request) null, out ContainerStatusChange_Result _);
    }

    public ResultStatus GetActions(
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      return this.GetActions(containerStatusChange, (ContainerStatusChange_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Parameters parameters,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      result = (ContainerStatusChange_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) containerStatusChange, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerStatusChangeService) this._Channel).GetDataPoints(this._UserProfile, containerStatusChange, parameters, request, out result) : this.AddMethod((Method) new ContainerStatusChangeMethod(containerStatusChange, ContainerStatusChangeMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) containerStatusChange, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ContainerStatusChange) null, (ContainerStatusChange_Parameters) null, (ContainerStatusChange_Request) null, out ContainerStatusChange_Result _);
    }

    public ResultStatus GetDataPoints(ContainerStatusChange containerStatusChange)
    {
      return this.GetDataPoints(containerStatusChange, (ContainerStatusChange_Parameters) null, (ContainerStatusChange_Request) null, out ContainerStatusChange_Result _);
    }

    public ResultStatus GetDataPoints(
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      return this.GetDataPoints(containerStatusChange, (ContainerStatusChange_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Parameters parameters,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      result = (ContainerStatusChange_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) containerStatusChange, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerStatusChangeService) this._Channel).GetWIPMsgs(this._UserProfile, containerStatusChange, parameters, request, out result) : this.AddMethod((Method) new ContainerStatusChangeMethod(containerStatusChange, ContainerStatusChangeMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) containerStatusChange, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ContainerStatusChange) null, (ContainerStatusChange_Parameters) null, (ContainerStatusChange_Request) null, out ContainerStatusChange_Result _);
    }

    public ResultStatus GetWIPMsgs(ContainerStatusChange containerStatusChange)
    {
      return this.GetWIPMsgs(containerStatusChange, (ContainerStatusChange_Parameters) null, (ContainerStatusChange_Request) null, out ContainerStatusChange_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      return this.GetWIPMsgs(containerStatusChange, (ContainerStatusChange_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Parameters parameters,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      result = (ContainerStatusChange_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) containerStatusChange, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerStatusChangeService) this._Channel).Load(this._UserProfile, containerStatusChange, parameters, request, out result) : this.AddMethod((Method) new ContainerStatusChangeMethod(containerStatusChange, ContainerStatusChangeMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) containerStatusChange, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ContainerStatusChange) null, (ContainerStatusChange_Parameters) null, (ContainerStatusChange_Request) null, out ContainerStatusChange_Result _);
    }

    public ResultStatus Load(ContainerStatusChange containerStatusChange)
    {
      return this.Load(containerStatusChange, (ContainerStatusChange_Parameters) null, (ContainerStatusChange_Request) null, out ContainerStatusChange_Result _);
    }

    public ResultStatus Load(
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      return this.Load(containerStatusChange, (ContainerStatusChange_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_LoadESigDetails_Parameters parameters,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      result = (ContainerStatusChange_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) containerStatusChange, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerStatusChangeService) this._Channel).LoadESigDetails(this._UserProfile, containerStatusChange, parameters, request, out result) : this.AddMethod((Method) new ContainerStatusChangeMethod(containerStatusChange, ContainerStatusChangeMethods.LoadESigDetails, (ContainerStatusChange_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) containerStatusChange, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ContainerStatusChange) null, (ContainerStatusChange_LoadESigDetails_Parameters) null, (ContainerStatusChange_Request) null, out ContainerStatusChange_Result _);
    }

    public ResultStatus LoadESigDetails(ContainerStatusChange containerStatusChange)
    {
      return this.LoadESigDetails(containerStatusChange, (ContainerStatusChange_LoadESigDetails_Parameters) null, (ContainerStatusChange_Request) null, out ContainerStatusChange_Result _);
    }

    public ResultStatus LoadESigDetails(
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      return this.LoadESigDetails(containerStatusChange, (ContainerStatusChange_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Parameters parameters,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      result = (ContainerStatusChange_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) containerStatusChange, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerStatusChangeService) this._Channel).ProcessComputation(this._UserProfile, containerStatusChange, parameters, request, out result) : this.AddMethod((Method) new ContainerStatusChangeMethod(containerStatusChange, ContainerStatusChangeMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) containerStatusChange, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ContainerStatusChange) null, (ContainerStatusChange_Parameters) null, (ContainerStatusChange_Request) null, out ContainerStatusChange_Result _);
    }

    public ResultStatus ProcessComputation(ContainerStatusChange containerStatusChange)
    {
      return this.ProcessComputation(containerStatusChange, (ContainerStatusChange_Parameters) null, (ContainerStatusChange_Request) null, out ContainerStatusChange_Result _);
    }

    public ResultStatus ProcessComputation(
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      return this.ProcessComputation(containerStatusChange, (ContainerStatusChange_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Parameters parameters,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      result = (ContainerStatusChange_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) containerStatusChange, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerStatusChangeService) this._Channel).ResolveParametricData(this._UserProfile, containerStatusChange, parameters, request, out result) : this.AddMethod((Method) new ContainerStatusChangeMethod(containerStatusChange, ContainerStatusChangeMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) containerStatusChange, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ContainerStatusChange) null, (ContainerStatusChange_Parameters) null, (ContainerStatusChange_Request) null, out ContainerStatusChange_Result _);
    }

    public ResultStatus ResolveParametricData(
      ContainerStatusChange containerStatusChange)
    {
      return this.ResolveParametricData(containerStatusChange, (ContainerStatusChange_Parameters) null, (ContainerStatusChange_Request) null, out ContainerStatusChange_Result _);
    }

    public ResultStatus ResolveParametricData(
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      return this.ResolveParametricData(containerStatusChange, (ContainerStatusChange_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject containerStatusChange,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerStatusChange_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ContainerStatusChange) containerStatusChange, (ContainerStatusChange_Parameters) parameters, (ContainerStatusChange_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject containerStatusChange,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerStatusChange_Result result1;
        ResultStatus actions = this.GetActions((ContainerStatusChange) containerStatusChange, (ContainerStatusChange_Parameters) parameters, (ContainerStatusChange_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject containerStatusChange,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerStatusChange_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ContainerStatusChange) containerStatusChange, (ContainerStatusChange_Parameters) parameters, (ContainerStatusChange_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject containerStatusChange,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerStatusChange_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ContainerStatusChange) containerStatusChange, (ContainerStatusChange_LoadESigDetails_Parameters) parameters, (ContainerStatusChange_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject containerStatusChange,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerStatusChange_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ContainerStatusChange) containerStatusChange, (ContainerStatusChange_Parameters) parameters, (ContainerStatusChange_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject containerStatusChange,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerStatusChange_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ContainerStatusChange) containerStatusChange, (ContainerStatusChange_Parameters) parameters, (ContainerStatusChange_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject containerStatusChange,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerStatusChange_Result result1;
        ResultStatus resultStatus = this.Load((ContainerStatusChange) containerStatusChange, (ContainerStatusChange_Parameters) parameters, (ContainerStatusChange_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject containerStatusChange,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerStatusChange_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ContainerStatusChange) containerStatusChange, (ContainerStatusChange_Parameters) parameters, (ContainerStatusChange_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      result = (ContainerStatusChange_Result) null;
      try
      {
        ContainerStatusChangeMethod[] methods = new ContainerStatusChangeMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IContainerStatusChangeService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ContainerStatusChange_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ContainerStatusChange_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerStatusChange cdo,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      result = (ContainerStatusChange_Result) null;
      try
      {
        return ((IContainerStatusChangeService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ContainerStatusChange_Result result1;
        ResultStatus environment = this.GetEnvironment((ContainerStatusChange) cdo, (ContainerStatusChange_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      return this.GetEnvironment((ContainerStatusChange) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ContainerStatusChange cdo,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      result = (ContainerStatusChange_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerStatusChangeService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ContainerStatusChangeMethod(cdo, ContainerStatusChangeMethods.ExecuteTransaction, (ContainerStatusChange_Parameters) null));
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
        ContainerStatusChange_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ContainerStatusChange) cdo, (ContainerStatusChange_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ContainerStatusChange cdo)
    {
      return this.ExecuteTransaction(cdo, (ContainerStatusChange_Request) null, out ContainerStatusChange_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result)
    {
      return this.ExecuteTransaction((ContainerStatusChange) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ContainerStatusChange cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ContainerStatusChangeMethod(cdo, ContainerStatusChangeMethods.AddDataTransaction, (ContainerStatusChange_Parameters) null));
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
        return this.AddDataTransaction((ContainerStatusChange) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
