// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.OpenCPStatusService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class OpenCPStatusService : ChangeStatusTxnBase
  {
    public OpenCPStatusService(UserProfile userProfile)
    {
      this.Initialize(typeof (IOpenCPStatusService), userProfile);
    }

    public ResultStatus CreateParametricData(
      OpenCPStatus openCPStatus,
      OpenCPStatus_Parameters parameters,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      result = (OpenCPStatus_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) openCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenCPStatusService) this._Channel).CreateParametricData(this._UserProfile, openCPStatus, parameters, request, out result) : this.AddMethod((Method) new OpenCPStatusMethod(openCPStatus, OpenCPStatusMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) openCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((OpenCPStatus) null, (OpenCPStatus_Parameters) null, (OpenCPStatus_Request) null, out OpenCPStatus_Result _);
    }

    public ResultStatus CreateParametricData(OpenCPStatus openCPStatus)
    {
      return this.CreateParametricData(openCPStatus, (OpenCPStatus_Parameters) null, (OpenCPStatus_Request) null, out OpenCPStatus_Result _);
    }

    public ResultStatus CreateParametricData(
      OpenCPStatus openCPStatus,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      return this.CreateParametricData(openCPStatus, (OpenCPStatus_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      OpenCPStatus openCPStatus,
      OpenCPStatus_Parameters parameters,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      result = (OpenCPStatus_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) openCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenCPStatusService) this._Channel).GetActions(this._UserProfile, openCPStatus, parameters, request, out result) : this.AddMethod((Method) new OpenCPStatusMethod(openCPStatus, OpenCPStatusMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) openCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((OpenCPStatus) null, (OpenCPStatus_Parameters) null, (OpenCPStatus_Request) null, out OpenCPStatus_Result _);
    }

    public ResultStatus GetActions(OpenCPStatus openCPStatus)
    {
      return this.GetActions(openCPStatus, (OpenCPStatus_Parameters) null, (OpenCPStatus_Request) null, out OpenCPStatus_Result _);
    }

    public ResultStatus GetActions(
      OpenCPStatus openCPStatus,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      return this.GetActions(openCPStatus, (OpenCPStatus_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      OpenCPStatus openCPStatus,
      OpenCPStatus_Parameters parameters,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      result = (OpenCPStatus_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) openCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenCPStatusService) this._Channel).GetDataPoints(this._UserProfile, openCPStatus, parameters, request, out result) : this.AddMethod((Method) new OpenCPStatusMethod(openCPStatus, OpenCPStatusMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) openCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((OpenCPStatus) null, (OpenCPStatus_Parameters) null, (OpenCPStatus_Request) null, out OpenCPStatus_Result _);
    }

    public ResultStatus GetDataPoints(OpenCPStatus openCPStatus)
    {
      return this.GetDataPoints(openCPStatus, (OpenCPStatus_Parameters) null, (OpenCPStatus_Request) null, out OpenCPStatus_Result _);
    }

    public ResultStatus GetDataPoints(
      OpenCPStatus openCPStatus,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      return this.GetDataPoints(openCPStatus, (OpenCPStatus_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      OpenCPStatus openCPStatus,
      OpenCPStatus_Parameters parameters,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      result = (OpenCPStatus_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) openCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenCPStatusService) this._Channel).GetWIPMsgs(this._UserProfile, openCPStatus, parameters, request, out result) : this.AddMethod((Method) new OpenCPStatusMethod(openCPStatus, OpenCPStatusMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) openCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((OpenCPStatus) null, (OpenCPStatus_Parameters) null, (OpenCPStatus_Request) null, out OpenCPStatus_Result _);
    }

    public ResultStatus GetWIPMsgs(OpenCPStatus openCPStatus)
    {
      return this.GetWIPMsgs(openCPStatus, (OpenCPStatus_Parameters) null, (OpenCPStatus_Request) null, out OpenCPStatus_Result _);
    }

    public ResultStatus GetWIPMsgs(
      OpenCPStatus openCPStatus,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      return this.GetWIPMsgs(openCPStatus, (OpenCPStatus_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      OpenCPStatus openCPStatus,
      OpenCPStatus_Parameters parameters,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      result = (OpenCPStatus_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) openCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenCPStatusService) this._Channel).Load(this._UserProfile, openCPStatus, parameters, request, out result) : this.AddMethod((Method) new OpenCPStatusMethod(openCPStatus, OpenCPStatusMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) openCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((OpenCPStatus) null, (OpenCPStatus_Parameters) null, (OpenCPStatus_Request) null, out OpenCPStatus_Result _);
    }

    public ResultStatus Load(OpenCPStatus openCPStatus)
    {
      return this.Load(openCPStatus, (OpenCPStatus_Parameters) null, (OpenCPStatus_Request) null, out OpenCPStatus_Result _);
    }

    public ResultStatus Load(
      OpenCPStatus openCPStatus,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      return this.Load(openCPStatus, (OpenCPStatus_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      OpenCPStatus openCPStatus,
      OpenCPStatus_LoadESigDetails_Parameters parameters,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      result = (OpenCPStatus_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) openCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenCPStatusService) this._Channel).LoadESigDetails(this._UserProfile, openCPStatus, parameters, request, out result) : this.AddMethod((Method) new OpenCPStatusMethod(openCPStatus, OpenCPStatusMethods.LoadESigDetails, (OpenCPStatus_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) openCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((OpenCPStatus) null, (OpenCPStatus_LoadESigDetails_Parameters) null, (OpenCPStatus_Request) null, out OpenCPStatus_Result _);
    }

    public ResultStatus LoadESigDetails(OpenCPStatus openCPStatus)
    {
      return this.LoadESigDetails(openCPStatus, (OpenCPStatus_LoadESigDetails_Parameters) null, (OpenCPStatus_Request) null, out OpenCPStatus_Result _);
    }

    public ResultStatus LoadESigDetails(
      OpenCPStatus openCPStatus,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      return this.LoadESigDetails(openCPStatus, (OpenCPStatus_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      OpenCPStatus openCPStatus,
      OpenCPStatus_Parameters parameters,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      result = (OpenCPStatus_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) openCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenCPStatusService) this._Channel).ProcessComputation(this._UserProfile, openCPStatus, parameters, request, out result) : this.AddMethod((Method) new OpenCPStatusMethod(openCPStatus, OpenCPStatusMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) openCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((OpenCPStatus) null, (OpenCPStatus_Parameters) null, (OpenCPStatus_Request) null, out OpenCPStatus_Result _);
    }

    public ResultStatus ProcessComputation(OpenCPStatus openCPStatus)
    {
      return this.ProcessComputation(openCPStatus, (OpenCPStatus_Parameters) null, (OpenCPStatus_Request) null, out OpenCPStatus_Result _);
    }

    public ResultStatus ProcessComputation(
      OpenCPStatus openCPStatus,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      return this.ProcessComputation(openCPStatus, (OpenCPStatus_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      OpenCPStatus openCPStatus,
      OpenCPStatus_Parameters parameters,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      result = (OpenCPStatus_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) openCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenCPStatusService) this._Channel).ResolveParametricData(this._UserProfile, openCPStatus, parameters, request, out result) : this.AddMethod((Method) new OpenCPStatusMethod(openCPStatus, OpenCPStatusMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) openCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((OpenCPStatus) null, (OpenCPStatus_Parameters) null, (OpenCPStatus_Request) null, out OpenCPStatus_Result _);
    }

    public ResultStatus ResolveParametricData(OpenCPStatus openCPStatus)
    {
      return this.ResolveParametricData(openCPStatus, (OpenCPStatus_Parameters) null, (OpenCPStatus_Request) null, out OpenCPStatus_Result _);
    }

    public ResultStatus ResolveParametricData(
      OpenCPStatus openCPStatus,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      return this.ResolveParametricData(openCPStatus, (OpenCPStatus_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject openCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenCPStatus_Result result1;
        ResultStatus parametricData = this.CreateParametricData((OpenCPStatus) openCPStatus, (OpenCPStatus_Parameters) parameters, (OpenCPStatus_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject openCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenCPStatus_Result result1;
        ResultStatus actions = this.GetActions((OpenCPStatus) openCPStatus, (OpenCPStatus_Parameters) parameters, (OpenCPStatus_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject openCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenCPStatus_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((OpenCPStatus) openCPStatus, (OpenCPStatus_Parameters) parameters, (OpenCPStatus_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject openCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenCPStatus_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((OpenCPStatus) openCPStatus, (OpenCPStatus_LoadESigDetails_Parameters) parameters, (OpenCPStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject openCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenCPStatus_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((OpenCPStatus) openCPStatus, (OpenCPStatus_Parameters) parameters, (OpenCPStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject openCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenCPStatus_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((OpenCPStatus) openCPStatus, (OpenCPStatus_Parameters) parameters, (OpenCPStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject openCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenCPStatus_Result result1;
        ResultStatus resultStatus = this.Load((OpenCPStatus) openCPStatus, (OpenCPStatus_Parameters) parameters, (OpenCPStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject openCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenCPStatus_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((OpenCPStatus) openCPStatus, (OpenCPStatus_Parameters) parameters, (OpenCPStatus_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      result = (OpenCPStatus_Result) null;
      try
      {
        OpenCPStatusMethod[] methods = new OpenCPStatusMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IOpenCPStatusService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        OpenCPStatus_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((OpenCPStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OpenCPStatus cdo,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      result = (OpenCPStatus_Result) null;
      try
      {
        return ((IOpenCPStatusService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        OpenCPStatus_Result result1;
        ResultStatus environment = this.GetEnvironment((OpenCPStatus) cdo, (OpenCPStatus_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      return this.GetEnvironment((OpenCPStatus) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      OpenCPStatus cdo,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      result = (OpenCPStatus_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenCPStatusService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new OpenCPStatusMethod(cdo, OpenCPStatusMethods.ExecuteTransaction, (OpenCPStatus_Parameters) null));
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
        OpenCPStatus_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((OpenCPStatus) cdo, (OpenCPStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(OpenCPStatus cdo)
    {
      return this.ExecuteTransaction(cdo, (OpenCPStatus_Request) null, out OpenCPStatus_Result _);
    }

    public ResultStatus ExecuteTransaction(
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result)
    {
      return this.ExecuteTransaction((OpenCPStatus) null, request, out result);
    }

    public ResultStatus AddDataTransaction(OpenCPStatus cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new OpenCPStatusMethod(cdo, OpenCPStatusMethods.AddDataTransaction, (OpenCPStatus_Parameters) null));
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
        return this.AddDataTransaction((OpenCPStatus) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
