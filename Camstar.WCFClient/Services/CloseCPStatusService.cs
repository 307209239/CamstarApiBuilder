// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CloseCPStatusService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CloseCPStatusService : ChangeStatusTxnBase
  {
    public CloseCPStatusService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICloseCPStatusService), userProfile);
    }

    public ResultStatus CreateParametricData(
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Parameters parameters,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      result = (CloseCPStatus_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) closeCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseCPStatusService) this._Channel).CreateParametricData(this._UserProfile, closeCPStatus, parameters, request, out result) : this.AddMethod((Method) new CloseCPStatusMethod(closeCPStatus, CloseCPStatusMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) closeCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CloseCPStatus) null, (CloseCPStatus_Parameters) null, (CloseCPStatus_Request) null, out CloseCPStatus_Result _);
    }

    public ResultStatus CreateParametricData(CloseCPStatus closeCPStatus)
    {
      return this.CreateParametricData(closeCPStatus, (CloseCPStatus_Parameters) null, (CloseCPStatus_Request) null, out CloseCPStatus_Result _);
    }

    public ResultStatus CreateParametricData(
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      return this.CreateParametricData(closeCPStatus, (CloseCPStatus_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Parameters parameters,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      result = (CloseCPStatus_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) closeCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseCPStatusService) this._Channel).GetActions(this._UserProfile, closeCPStatus, parameters, request, out result) : this.AddMethod((Method) new CloseCPStatusMethod(closeCPStatus, CloseCPStatusMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) closeCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CloseCPStatus) null, (CloseCPStatus_Parameters) null, (CloseCPStatus_Request) null, out CloseCPStatus_Result _);
    }

    public ResultStatus GetActions(CloseCPStatus closeCPStatus)
    {
      return this.GetActions(closeCPStatus, (CloseCPStatus_Parameters) null, (CloseCPStatus_Request) null, out CloseCPStatus_Result _);
    }

    public ResultStatus GetActions(
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      return this.GetActions(closeCPStatus, (CloseCPStatus_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Parameters parameters,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      result = (CloseCPStatus_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) closeCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseCPStatusService) this._Channel).GetDataPoints(this._UserProfile, closeCPStatus, parameters, request, out result) : this.AddMethod((Method) new CloseCPStatusMethod(closeCPStatus, CloseCPStatusMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) closeCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CloseCPStatus) null, (CloseCPStatus_Parameters) null, (CloseCPStatus_Request) null, out CloseCPStatus_Result _);
    }

    public ResultStatus GetDataPoints(CloseCPStatus closeCPStatus)
    {
      return this.GetDataPoints(closeCPStatus, (CloseCPStatus_Parameters) null, (CloseCPStatus_Request) null, out CloseCPStatus_Result _);
    }

    public ResultStatus GetDataPoints(
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      return this.GetDataPoints(closeCPStatus, (CloseCPStatus_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Parameters parameters,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      result = (CloseCPStatus_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) closeCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseCPStatusService) this._Channel).GetWIPMsgs(this._UserProfile, closeCPStatus, parameters, request, out result) : this.AddMethod((Method) new CloseCPStatusMethod(closeCPStatus, CloseCPStatusMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) closeCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CloseCPStatus) null, (CloseCPStatus_Parameters) null, (CloseCPStatus_Request) null, out CloseCPStatus_Result _);
    }

    public ResultStatus GetWIPMsgs(CloseCPStatus closeCPStatus)
    {
      return this.GetWIPMsgs(closeCPStatus, (CloseCPStatus_Parameters) null, (CloseCPStatus_Request) null, out CloseCPStatus_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      return this.GetWIPMsgs(closeCPStatus, (CloseCPStatus_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Parameters parameters,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      result = (CloseCPStatus_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) closeCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseCPStatusService) this._Channel).Load(this._UserProfile, closeCPStatus, parameters, request, out result) : this.AddMethod((Method) new CloseCPStatusMethod(closeCPStatus, CloseCPStatusMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) closeCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CloseCPStatus) null, (CloseCPStatus_Parameters) null, (CloseCPStatus_Request) null, out CloseCPStatus_Result _);
    }

    public ResultStatus Load(CloseCPStatus closeCPStatus)
    {
      return this.Load(closeCPStatus, (CloseCPStatus_Parameters) null, (CloseCPStatus_Request) null, out CloseCPStatus_Result _);
    }

    public ResultStatus Load(
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      return this.Load(closeCPStatus, (CloseCPStatus_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CloseCPStatus closeCPStatus,
      CloseCPStatus_LoadESigDetails_Parameters parameters,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      result = (CloseCPStatus_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) closeCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseCPStatusService) this._Channel).LoadESigDetails(this._UserProfile, closeCPStatus, parameters, request, out result) : this.AddMethod((Method) new CloseCPStatusMethod(closeCPStatus, CloseCPStatusMethods.LoadESigDetails, (CloseCPStatus_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) closeCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CloseCPStatus) null, (CloseCPStatus_LoadESigDetails_Parameters) null, (CloseCPStatus_Request) null, out CloseCPStatus_Result _);
    }

    public ResultStatus LoadESigDetails(CloseCPStatus closeCPStatus)
    {
      return this.LoadESigDetails(closeCPStatus, (CloseCPStatus_LoadESigDetails_Parameters) null, (CloseCPStatus_Request) null, out CloseCPStatus_Result _);
    }

    public ResultStatus LoadESigDetails(
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      return this.LoadESigDetails(closeCPStatus, (CloseCPStatus_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Parameters parameters,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      result = (CloseCPStatus_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) closeCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseCPStatusService) this._Channel).ProcessComputation(this._UserProfile, closeCPStatus, parameters, request, out result) : this.AddMethod((Method) new CloseCPStatusMethod(closeCPStatus, CloseCPStatusMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) closeCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CloseCPStatus) null, (CloseCPStatus_Parameters) null, (CloseCPStatus_Request) null, out CloseCPStatus_Result _);
    }

    public ResultStatus ProcessComputation(CloseCPStatus closeCPStatus)
    {
      return this.ProcessComputation(closeCPStatus, (CloseCPStatus_Parameters) null, (CloseCPStatus_Request) null, out CloseCPStatus_Result _);
    }

    public ResultStatus ProcessComputation(
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      return this.ProcessComputation(closeCPStatus, (CloseCPStatus_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Parameters parameters,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      result = (CloseCPStatus_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) closeCPStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseCPStatusService) this._Channel).ResolveParametricData(this._UserProfile, closeCPStatus, parameters, request, out result) : this.AddMethod((Method) new CloseCPStatusMethod(closeCPStatus, CloseCPStatusMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) closeCPStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CloseCPStatus) null, (CloseCPStatus_Parameters) null, (CloseCPStatus_Request) null, out CloseCPStatus_Result _);
    }

    public ResultStatus ResolveParametricData(CloseCPStatus closeCPStatus)
    {
      return this.ResolveParametricData(closeCPStatus, (CloseCPStatus_Parameters) null, (CloseCPStatus_Request) null, out CloseCPStatus_Result _);
    }

    public ResultStatus ResolveParametricData(
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      return this.ResolveParametricData(closeCPStatus, (CloseCPStatus_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject closeCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseCPStatus_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CloseCPStatus) closeCPStatus, (CloseCPStatus_Parameters) parameters, (CloseCPStatus_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject closeCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseCPStatus_Result result1;
        ResultStatus actions = this.GetActions((CloseCPStatus) closeCPStatus, (CloseCPStatus_Parameters) parameters, (CloseCPStatus_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject closeCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseCPStatus_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CloseCPStatus) closeCPStatus, (CloseCPStatus_Parameters) parameters, (CloseCPStatus_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject closeCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseCPStatus_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CloseCPStatus) closeCPStatus, (CloseCPStatus_LoadESigDetails_Parameters) parameters, (CloseCPStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject closeCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseCPStatus_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CloseCPStatus) closeCPStatus, (CloseCPStatus_Parameters) parameters, (CloseCPStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject closeCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseCPStatus_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CloseCPStatus) closeCPStatus, (CloseCPStatus_Parameters) parameters, (CloseCPStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject closeCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseCPStatus_Result result1;
        ResultStatus resultStatus = this.Load((CloseCPStatus) closeCPStatus, (CloseCPStatus_Parameters) parameters, (CloseCPStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject closeCPStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseCPStatus_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CloseCPStatus) closeCPStatus, (CloseCPStatus_Parameters) parameters, (CloseCPStatus_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      result = (CloseCPStatus_Result) null;
      try
      {
        CloseCPStatusMethod[] methods = new CloseCPStatusMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICloseCPStatusService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CloseCPStatus_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CloseCPStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CloseCPStatus cdo,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      result = (CloseCPStatus_Result) null;
      try
      {
        return ((ICloseCPStatusService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CloseCPStatus_Result result1;
        ResultStatus environment = this.GetEnvironment((CloseCPStatus) cdo, (CloseCPStatus_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      return this.GetEnvironment((CloseCPStatus) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CloseCPStatus cdo,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      result = (CloseCPStatus_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseCPStatusService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CloseCPStatusMethod(cdo, CloseCPStatusMethods.ExecuteTransaction, (CloseCPStatus_Parameters) null));
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
        CloseCPStatus_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CloseCPStatus) cdo, (CloseCPStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CloseCPStatus cdo)
    {
      return this.ExecuteTransaction(cdo, (CloseCPStatus_Request) null, out CloseCPStatus_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result)
    {
      return this.ExecuteTransaction((CloseCPStatus) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CloseCPStatus cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CloseCPStatusMethod(cdo, CloseCPStatusMethods.AddDataTransaction, (CloseCPStatus_Parameters) null));
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
        return this.AddDataTransaction((CloseCPStatus) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
