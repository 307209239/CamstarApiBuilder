// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerTxnRevService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ContainerTxnRevService : ContainerTxnBase
  {
    public ContainerTxnRevService(UserProfile userProfile)
    {
      this.Initialize(typeof (IContainerTxnRevService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      result = (ContainerTxnRev_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) containerTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnRevService) this._Channel).CreateParametricData(this._UserProfile, containerTxnRev, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnRevMethod(containerTxnRev, ContainerTxnRevMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) containerTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ContainerTxnRev) null, (ContainerTxnRev_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus CreateParametricData(ContainerTxnRev containerTxnRev)
    {
      return this.CreateParametricData(containerTxnRev, (ContainerTxnRev_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus CreateParametricData(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      return this.CreateParametricData(containerTxnRev, (ContainerTxnRev_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      result = (ContainerTxnRev_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) containerTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnRevService) this._Channel).GetActions(this._UserProfile, containerTxnRev, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnRevMethod(containerTxnRev, ContainerTxnRevMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) containerTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ContainerTxnRev) null, (ContainerTxnRev_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus GetActions(ContainerTxnRev containerTxnRev)
    {
      return this.GetActions(containerTxnRev, (ContainerTxnRev_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus GetActions(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      return this.GetActions(containerTxnRev, (ContainerTxnRev_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      result = (ContainerTxnRev_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) containerTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnRevService) this._Channel).GetDataPoints(this._UserProfile, containerTxnRev, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnRevMethod(containerTxnRev, ContainerTxnRevMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) containerTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ContainerTxnRev) null, (ContainerTxnRev_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus GetDataPoints(ContainerTxnRev containerTxnRev)
    {
      return this.GetDataPoints(containerTxnRev, (ContainerTxnRev_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus GetDataPoints(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      return this.GetDataPoints(containerTxnRev, (ContainerTxnRev_Parameters) null, request, out result);
    }

    public ResultStatus GetLastTxnHistory(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      result = (ContainerTxnRev_Result) null;
      this.OnBeforeCall(nameof (GetLastTxnHistory), (DCObject) containerTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnRevService) this._Channel).GetLastTxnHistory(this._UserProfile, containerTxnRev, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnRevMethod(containerTxnRev, ContainerTxnRevMethods.GetLastTxnHistory, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetLastTxnHistory), res, (DCObject) containerTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetLastTxnHistory()
    {
      return this.GetLastTxnHistory((ContainerTxnRev) null, (ContainerTxnRev_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus GetLastTxnHistory(ContainerTxnRev containerTxnRev)
    {
      return this.GetLastTxnHistory(containerTxnRev, (ContainerTxnRev_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus GetLastTxnHistory(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      return this.GetLastTxnHistory(containerTxnRev, (ContainerTxnRev_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      result = (ContainerTxnRev_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) containerTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnRevService) this._Channel).GetWIPMsgs(this._UserProfile, containerTxnRev, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnRevMethod(containerTxnRev, ContainerTxnRevMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) containerTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ContainerTxnRev) null, (ContainerTxnRev_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus GetWIPMsgs(ContainerTxnRev containerTxnRev)
    {
      return this.GetWIPMsgs(containerTxnRev, (ContainerTxnRev_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      return this.GetWIPMsgs(containerTxnRev, (ContainerTxnRev_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      result = (ContainerTxnRev_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) containerTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnRevService) this._Channel).Load(this._UserProfile, containerTxnRev, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnRevMethod(containerTxnRev, ContainerTxnRevMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) containerTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ContainerTxnRev) null, (ContainerTxnRev_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus Load(ContainerTxnRev containerTxnRev)
    {
      return this.Load(containerTxnRev, (ContainerTxnRev_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus Load(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      return this.Load(containerTxnRev, (ContainerTxnRev_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_LoadESigDetails_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      result = (ContainerTxnRev_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) containerTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnRevService) this._Channel).LoadESigDetails(this._UserProfile, containerTxnRev, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnRevMethod(containerTxnRev, ContainerTxnRevMethods.LoadESigDetails, (ContainerTxnRev_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) containerTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ContainerTxnRev) null, (ContainerTxnRev_LoadESigDetails_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus LoadESigDetails(ContainerTxnRev containerTxnRev)
    {
      return this.LoadESigDetails(containerTxnRev, (ContainerTxnRev_LoadESigDetails_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus LoadESigDetails(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      return this.LoadESigDetails(containerTxnRev, (ContainerTxnRev_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      result = (ContainerTxnRev_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) containerTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnRevService) this._Channel).ProcessComputation(this._UserProfile, containerTxnRev, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnRevMethod(containerTxnRev, ContainerTxnRevMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) containerTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ContainerTxnRev) null, (ContainerTxnRev_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus ProcessComputation(ContainerTxnRev containerTxnRev)
    {
      return this.ProcessComputation(containerTxnRev, (ContainerTxnRev_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus ProcessComputation(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      return this.ProcessComputation(containerTxnRev, (ContainerTxnRev_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      result = (ContainerTxnRev_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) containerTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnRevService) this._Channel).ResolveParametricData(this._UserProfile, containerTxnRev, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnRevMethod(containerTxnRev, ContainerTxnRevMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) containerTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ContainerTxnRev) null, (ContainerTxnRev_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus ResolveParametricData(ContainerTxnRev containerTxnRev)
    {
      return this.ResolveParametricData(containerTxnRev, (ContainerTxnRev_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus ResolveParametricData(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      return this.ResolveParametricData(containerTxnRev, (ContainerTxnRev_Parameters) null, request, out result);
    }

    public ResultStatus SetTxnRevHistoryMainline(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_SetTxnRevHistoryMainline_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      result = (ContainerTxnRev_Result) null;
      this.OnBeforeCall(nameof (SetTxnRevHistoryMainline), (DCObject) containerTxnRev, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnRevService) this._Channel).SetTxnRevHistoryMainline(this._UserProfile, containerTxnRev, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnRevMethod(containerTxnRev, ContainerTxnRevMethods.SetTxnRevHistoryMainline, (ContainerTxnRev_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetTxnRevHistoryMainline), res, (DCObject) containerTxnRev, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetTxnRevHistoryMainline()
    {
      return this.SetTxnRevHistoryMainline((ContainerTxnRev) null, (ContainerTxnRev_SetTxnRevHistoryMainline_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus SetTxnRevHistoryMainline(ContainerTxnRev containerTxnRev)
    {
      return this.SetTxnRevHistoryMainline(containerTxnRev, (ContainerTxnRev_SetTxnRevHistoryMainline_Parameters) null, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus SetTxnRevHistoryMainline(
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      return this.SetTxnRevHistoryMainline(containerTxnRev, (ContainerTxnRev_SetTxnRevHistoryMainline_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject containerTxnRev,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerTxnRev_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ContainerTxnRev) containerTxnRev, (ContainerTxnRev_Parameters) parameters, (ContainerTxnRev_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject containerTxnRev,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerTxnRev_Result result1;
        ResultStatus actions = this.GetActions((ContainerTxnRev) containerTxnRev, (ContainerTxnRev_Parameters) parameters, (ContainerTxnRev_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject containerTxnRev,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerTxnRev_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ContainerTxnRev) containerTxnRev, (ContainerTxnRev_Parameters) parameters, (ContainerTxnRev_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject containerTxnRev,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerTxnRev_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ContainerTxnRev) containerTxnRev, (ContainerTxnRev_LoadESigDetails_Parameters) parameters, (ContainerTxnRev_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject containerTxnRev,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerTxnRev_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ContainerTxnRev) containerTxnRev, (ContainerTxnRev_Parameters) parameters, (ContainerTxnRev_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject containerTxnRev,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerTxnRev_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ContainerTxnRev) containerTxnRev, (ContainerTxnRev_Parameters) parameters, (ContainerTxnRev_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject containerTxnRev,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerTxnRev_Result result1;
        ResultStatus resultStatus = this.Load((ContainerTxnRev) containerTxnRev, (ContainerTxnRev_Parameters) parameters, (ContainerTxnRev_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject containerTxnRev,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerTxnRev_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ContainerTxnRev) containerTxnRev, (ContainerTxnRev_Parameters) parameters, (ContainerTxnRev_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      result = (ContainerTxnRev_Result) null;
      try
      {
        ContainerTxnRevMethod[] methods = new ContainerTxnRevMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IContainerTxnRevService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ContainerTxnRev_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ContainerTxnRev_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerTxnRev cdo,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      result = (ContainerTxnRev_Result) null;
      try
      {
        return ((IContainerTxnRevService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ContainerTxnRev_Result result1;
        ResultStatus environment = this.GetEnvironment((ContainerTxnRev) cdo, (ContainerTxnRev_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      return this.GetEnvironment((ContainerTxnRev) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ContainerTxnRev cdo,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      result = (ContainerTxnRev_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnRevService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ContainerTxnRevMethod(cdo, ContainerTxnRevMethods.ExecuteTransaction, (ContainerTxnRev_Parameters) null));
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
        ContainerTxnRev_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ContainerTxnRev) cdo, (ContainerTxnRev_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ContainerTxnRev cdo)
    {
      return this.ExecuteTransaction(cdo, (ContainerTxnRev_Request) null, out ContainerTxnRev_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result)
    {
      return this.ExecuteTransaction((ContainerTxnRev) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ContainerTxnRev cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ContainerTxnRevMethod(cdo, ContainerTxnRevMethods.AddDataTransaction, (ContainerTxnRev_Parameters) null));
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
        return this.AddDataTransaction((ContainerTxnRev) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
