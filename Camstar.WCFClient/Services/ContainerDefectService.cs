// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerDefectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ContainerDefectService : DefectBase
  {
    public ContainerDefectService(UserProfile userProfile)
    {
      this.Initialize(typeof (IContainerDefectService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ContainerDefect containerDefect,
      ContainerDefect_Parameters parameters,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      result = (ContainerDefect_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) containerDefect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectService) this._Channel).CreateParametricData(this._UserProfile, containerDefect, parameters, request, out result) : this.AddMethod((Method) new ContainerDefectMethod(containerDefect, ContainerDefectMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) containerDefect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ContainerDefect) null, (ContainerDefect_Parameters) null, (ContainerDefect_Request) null, out ContainerDefect_Result _);
    }

    public ResultStatus CreateParametricData(ContainerDefect containerDefect)
    {
      return this.CreateParametricData(containerDefect, (ContainerDefect_Parameters) null, (ContainerDefect_Request) null, out ContainerDefect_Result _);
    }

    public ResultStatus CreateParametricData(
      ContainerDefect containerDefect,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      return this.CreateParametricData(containerDefect, (ContainerDefect_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ContainerDefect containerDefect,
      ContainerDefect_Parameters parameters,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      result = (ContainerDefect_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) containerDefect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectService) this._Channel).GetActions(this._UserProfile, containerDefect, parameters, request, out result) : this.AddMethod((Method) new ContainerDefectMethod(containerDefect, ContainerDefectMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) containerDefect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ContainerDefect) null, (ContainerDefect_Parameters) null, (ContainerDefect_Request) null, out ContainerDefect_Result _);
    }

    public ResultStatus GetActions(ContainerDefect containerDefect)
    {
      return this.GetActions(containerDefect, (ContainerDefect_Parameters) null, (ContainerDefect_Request) null, out ContainerDefect_Result _);
    }

    public ResultStatus GetActions(
      ContainerDefect containerDefect,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      return this.GetActions(containerDefect, (ContainerDefect_Parameters) null, request, out result);
    }

    public ResultStatus GetActuals(
      ContainerDefect containerDefect,
      ContainerDefect_Parameters parameters,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      result = (ContainerDefect_Result) null;
      this.OnBeforeCall(nameof (GetActuals), (DCObject) containerDefect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectService) this._Channel).GetActuals(this._UserProfile, containerDefect, parameters, request, out result) : this.AddMethod((Method) new ContainerDefectMethod(containerDefect, ContainerDefectMethods.GetActuals, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActuals), res, (DCObject) containerDefect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActuals()
    {
      return this.GetActuals((ContainerDefect) null, (ContainerDefect_Parameters) null, (ContainerDefect_Request) null, out ContainerDefect_Result _);
    }

    public ResultStatus GetActuals(ContainerDefect containerDefect)
    {
      return this.GetActuals(containerDefect, (ContainerDefect_Parameters) null, (ContainerDefect_Request) null, out ContainerDefect_Result _);
    }

    public ResultStatus GetActuals(
      ContainerDefect containerDefect,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      return this.GetActuals(containerDefect, (ContainerDefect_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ContainerDefect containerDefect,
      ContainerDefect_Parameters parameters,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      result = (ContainerDefect_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) containerDefect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectService) this._Channel).GetDataPoints(this._UserProfile, containerDefect, parameters, request, out result) : this.AddMethod((Method) new ContainerDefectMethod(containerDefect, ContainerDefectMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) containerDefect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ContainerDefect) null, (ContainerDefect_Parameters) null, (ContainerDefect_Request) null, out ContainerDefect_Result _);
    }

    public ResultStatus GetDataPoints(ContainerDefect containerDefect)
    {
      return this.GetDataPoints(containerDefect, (ContainerDefect_Parameters) null, (ContainerDefect_Request) null, out ContainerDefect_Result _);
    }

    public ResultStatus GetDataPoints(
      ContainerDefect containerDefect,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      return this.GetDataPoints(containerDefect, (ContainerDefect_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ContainerDefect containerDefect,
      ContainerDefect_Parameters parameters,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      result = (ContainerDefect_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) containerDefect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectService) this._Channel).GetWIPMsgs(this._UserProfile, containerDefect, parameters, request, out result) : this.AddMethod((Method) new ContainerDefectMethod(containerDefect, ContainerDefectMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) containerDefect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ContainerDefect) null, (ContainerDefect_Parameters) null, (ContainerDefect_Request) null, out ContainerDefect_Result _);
    }

    public ResultStatus GetWIPMsgs(ContainerDefect containerDefect)
    {
      return this.GetWIPMsgs(containerDefect, (ContainerDefect_Parameters) null, (ContainerDefect_Request) null, out ContainerDefect_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ContainerDefect containerDefect,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      return this.GetWIPMsgs(containerDefect, (ContainerDefect_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ContainerDefect containerDefect,
      ContainerDefect_Parameters parameters,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      result = (ContainerDefect_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) containerDefect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectService) this._Channel).Load(this._UserProfile, containerDefect, parameters, request, out result) : this.AddMethod((Method) new ContainerDefectMethod(containerDefect, ContainerDefectMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) containerDefect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ContainerDefect) null, (ContainerDefect_Parameters) null, (ContainerDefect_Request) null, out ContainerDefect_Result _);
    }

    public ResultStatus Load(ContainerDefect containerDefect)
    {
      return this.Load(containerDefect, (ContainerDefect_Parameters) null, (ContainerDefect_Request) null, out ContainerDefect_Result _);
    }

    public ResultStatus Load(
      ContainerDefect containerDefect,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      return this.Load(containerDefect, (ContainerDefect_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ContainerDefect containerDefect,
      ContainerDefect_LoadESigDetails_Parameters parameters,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      result = (ContainerDefect_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) containerDefect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectService) this._Channel).LoadESigDetails(this._UserProfile, containerDefect, parameters, request, out result) : this.AddMethod((Method) new ContainerDefectMethod(containerDefect, ContainerDefectMethods.LoadESigDetails, (ContainerDefect_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) containerDefect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ContainerDefect) null, (ContainerDefect_LoadESigDetails_Parameters) null, (ContainerDefect_Request) null, out ContainerDefect_Result _);
    }

    public ResultStatus LoadESigDetails(ContainerDefect containerDefect)
    {
      return this.LoadESigDetails(containerDefect, (ContainerDefect_LoadESigDetails_Parameters) null, (ContainerDefect_Request) null, out ContainerDefect_Result _);
    }

    public ResultStatus LoadESigDetails(
      ContainerDefect containerDefect,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      return this.LoadESigDetails(containerDefect, (ContainerDefect_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ContainerDefect containerDefect,
      ContainerDefect_Parameters parameters,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      result = (ContainerDefect_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) containerDefect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectService) this._Channel).ProcessComputation(this._UserProfile, containerDefect, parameters, request, out result) : this.AddMethod((Method) new ContainerDefectMethod(containerDefect, ContainerDefectMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) containerDefect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ContainerDefect) null, (ContainerDefect_Parameters) null, (ContainerDefect_Request) null, out ContainerDefect_Result _);
    }

    public ResultStatus ProcessComputation(ContainerDefect containerDefect)
    {
      return this.ProcessComputation(containerDefect, (ContainerDefect_Parameters) null, (ContainerDefect_Request) null, out ContainerDefect_Result _);
    }

    public ResultStatus ProcessComputation(
      ContainerDefect containerDefect,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      return this.ProcessComputation(containerDefect, (ContainerDefect_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ContainerDefect containerDefect,
      ContainerDefect_Parameters parameters,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      result = (ContainerDefect_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) containerDefect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectService) this._Channel).ResolveParametricData(this._UserProfile, containerDefect, parameters, request, out result) : this.AddMethod((Method) new ContainerDefectMethod(containerDefect, ContainerDefectMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) containerDefect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ContainerDefect) null, (ContainerDefect_Parameters) null, (ContainerDefect_Request) null, out ContainerDefect_Result _);
    }

    public ResultStatus ResolveParametricData(ContainerDefect containerDefect)
    {
      return this.ResolveParametricData(containerDefect, (ContainerDefect_Parameters) null, (ContainerDefect_Request) null, out ContainerDefect_Result _);
    }

    public ResultStatus ResolveParametricData(
      ContainerDefect containerDefect,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      return this.ResolveParametricData(containerDefect, (ContainerDefect_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetActuals(
      DCObject containerDefect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerDefect_Result result1;
        ResultStatus actuals = this.GetActuals((ContainerDefect) containerDefect, (ContainerDefect_Parameters) parameters, (ContainerDefect_Request) request, out result1);
        result = (Result) result1;
        return actuals;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject containerDefect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerDefect_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ContainerDefect) containerDefect, (ContainerDefect_Parameters) parameters, (ContainerDefect_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject containerDefect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerDefect_Result result1;
        ResultStatus actions = this.GetActions((ContainerDefect) containerDefect, (ContainerDefect_Parameters) parameters, (ContainerDefect_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject containerDefect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerDefect_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ContainerDefect) containerDefect, (ContainerDefect_Parameters) parameters, (ContainerDefect_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject containerDefect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerDefect_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ContainerDefect) containerDefect, (ContainerDefect_LoadESigDetails_Parameters) parameters, (ContainerDefect_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject containerDefect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerDefect_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ContainerDefect) containerDefect, (ContainerDefect_Parameters) parameters, (ContainerDefect_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject containerDefect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerDefect_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ContainerDefect) containerDefect, (ContainerDefect_Parameters) parameters, (ContainerDefect_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject containerDefect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerDefect_Result result1;
        ResultStatus resultStatus = this.Load((ContainerDefect) containerDefect, (ContainerDefect_Parameters) parameters, (ContainerDefect_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject containerDefect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerDefect_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ContainerDefect) containerDefect, (ContainerDefect_Parameters) parameters, (ContainerDefect_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      result = (ContainerDefect_Result) null;
      try
      {
        ContainerDefectMethod[] methods = new ContainerDefectMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IContainerDefectService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ContainerDefect_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ContainerDefect_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerDefect cdo,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      result = (ContainerDefect_Result) null;
      try
      {
        return ((IContainerDefectService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ContainerDefect_Result result1;
        ResultStatus environment = this.GetEnvironment((ContainerDefect) cdo, (ContainerDefect_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      return this.GetEnvironment((ContainerDefect) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ContainerDefect cdo,
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      result = (ContainerDefect_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ContainerDefectMethod(cdo, ContainerDefectMethods.ExecuteTransaction, (ContainerDefect_Parameters) null));
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
        ContainerDefect_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ContainerDefect) cdo, (ContainerDefect_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ContainerDefect cdo)
    {
      return this.ExecuteTransaction(cdo, (ContainerDefect_Request) null, out ContainerDefect_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ContainerDefect_Request request,
      out ContainerDefect_Result result)
    {
      return this.ExecuteTransaction((ContainerDefect) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ContainerDefect cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ContainerDefectMethod(cdo, ContainerDefectMethods.AddDataTransaction, (ContainerDefect_Parameters) null));
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
        return this.AddDataTransaction((ContainerDefect) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
