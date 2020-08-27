// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CloseCPStatusesService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CloseCPStatusesService : ChangeStatusTxnsBase
  {
    public CloseCPStatusesService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICloseCPStatusesService), userProfile);
    }

    public ResultStatus CreateParametricData(
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Parameters parameters,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      result = (CloseCPStatuses_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) closeCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseCPStatusesService) this._Channel).CreateParametricData(this._UserProfile, closeCPStatuses, parameters, request, out result) : this.AddMethod((Method) new CloseCPStatusesMethod(closeCPStatuses, CloseCPStatusesMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) closeCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CloseCPStatuses) null, (CloseCPStatuses_Parameters) null, (CloseCPStatuses_Request) null, out CloseCPStatuses_Result _);
    }

    public ResultStatus CreateParametricData(CloseCPStatuses closeCPStatuses)
    {
      return this.CreateParametricData(closeCPStatuses, (CloseCPStatuses_Parameters) null, (CloseCPStatuses_Request) null, out CloseCPStatuses_Result _);
    }

    public ResultStatus CreateParametricData(
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      return this.CreateParametricData(closeCPStatuses, (CloseCPStatuses_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Parameters parameters,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      result = (CloseCPStatuses_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) closeCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseCPStatusesService) this._Channel).GetActions(this._UserProfile, closeCPStatuses, parameters, request, out result) : this.AddMethod((Method) new CloseCPStatusesMethod(closeCPStatuses, CloseCPStatusesMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) closeCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CloseCPStatuses) null, (CloseCPStatuses_Parameters) null, (CloseCPStatuses_Request) null, out CloseCPStatuses_Result _);
    }

    public ResultStatus GetActions(CloseCPStatuses closeCPStatuses)
    {
      return this.GetActions(closeCPStatuses, (CloseCPStatuses_Parameters) null, (CloseCPStatuses_Request) null, out CloseCPStatuses_Result _);
    }

    public ResultStatus GetActions(
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      return this.GetActions(closeCPStatuses, (CloseCPStatuses_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Parameters parameters,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      result = (CloseCPStatuses_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) closeCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseCPStatusesService) this._Channel).GetDataPoints(this._UserProfile, closeCPStatuses, parameters, request, out result) : this.AddMethod((Method) new CloseCPStatusesMethod(closeCPStatuses, CloseCPStatusesMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) closeCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CloseCPStatuses) null, (CloseCPStatuses_Parameters) null, (CloseCPStatuses_Request) null, out CloseCPStatuses_Result _);
    }

    public ResultStatus GetDataPoints(CloseCPStatuses closeCPStatuses)
    {
      return this.GetDataPoints(closeCPStatuses, (CloseCPStatuses_Parameters) null, (CloseCPStatuses_Request) null, out CloseCPStatuses_Result _);
    }

    public ResultStatus GetDataPoints(
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      return this.GetDataPoints(closeCPStatuses, (CloseCPStatuses_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Parameters parameters,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      result = (CloseCPStatuses_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) closeCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseCPStatusesService) this._Channel).GetWIPMsgs(this._UserProfile, closeCPStatuses, parameters, request, out result) : this.AddMethod((Method) new CloseCPStatusesMethod(closeCPStatuses, CloseCPStatusesMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) closeCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CloseCPStatuses) null, (CloseCPStatuses_Parameters) null, (CloseCPStatuses_Request) null, out CloseCPStatuses_Result _);
    }

    public ResultStatus GetWIPMsgs(CloseCPStatuses closeCPStatuses)
    {
      return this.GetWIPMsgs(closeCPStatuses, (CloseCPStatuses_Parameters) null, (CloseCPStatuses_Request) null, out CloseCPStatuses_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      return this.GetWIPMsgs(closeCPStatuses, (CloseCPStatuses_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Parameters parameters,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      result = (CloseCPStatuses_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) closeCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseCPStatusesService) this._Channel).Load(this._UserProfile, closeCPStatuses, parameters, request, out result) : this.AddMethod((Method) new CloseCPStatusesMethod(closeCPStatuses, CloseCPStatusesMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) closeCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CloseCPStatuses) null, (CloseCPStatuses_Parameters) null, (CloseCPStatuses_Request) null, out CloseCPStatuses_Result _);
    }

    public ResultStatus Load(CloseCPStatuses closeCPStatuses)
    {
      return this.Load(closeCPStatuses, (CloseCPStatuses_Parameters) null, (CloseCPStatuses_Request) null, out CloseCPStatuses_Result _);
    }

    public ResultStatus Load(
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      return this.Load(closeCPStatuses, (CloseCPStatuses_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_LoadESigDetails_Parameters parameters,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      result = (CloseCPStatuses_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) closeCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseCPStatusesService) this._Channel).LoadESigDetails(this._UserProfile, closeCPStatuses, parameters, request, out result) : this.AddMethod((Method) new CloseCPStatusesMethod(closeCPStatuses, CloseCPStatusesMethods.LoadESigDetails, (CloseCPStatuses_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) closeCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CloseCPStatuses) null, (CloseCPStatuses_LoadESigDetails_Parameters) null, (CloseCPStatuses_Request) null, out CloseCPStatuses_Result _);
    }

    public ResultStatus LoadESigDetails(CloseCPStatuses closeCPStatuses)
    {
      return this.LoadESigDetails(closeCPStatuses, (CloseCPStatuses_LoadESigDetails_Parameters) null, (CloseCPStatuses_Request) null, out CloseCPStatuses_Result _);
    }

    public ResultStatus LoadESigDetails(
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      return this.LoadESigDetails(closeCPStatuses, (CloseCPStatuses_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Parameters parameters,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      result = (CloseCPStatuses_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) closeCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseCPStatusesService) this._Channel).ProcessComputation(this._UserProfile, closeCPStatuses, parameters, request, out result) : this.AddMethod((Method) new CloseCPStatusesMethod(closeCPStatuses, CloseCPStatusesMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) closeCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CloseCPStatuses) null, (CloseCPStatuses_Parameters) null, (CloseCPStatuses_Request) null, out CloseCPStatuses_Result _);
    }

    public ResultStatus ProcessComputation(CloseCPStatuses closeCPStatuses)
    {
      return this.ProcessComputation(closeCPStatuses, (CloseCPStatuses_Parameters) null, (CloseCPStatuses_Request) null, out CloseCPStatuses_Result _);
    }

    public ResultStatus ProcessComputation(
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      return this.ProcessComputation(closeCPStatuses, (CloseCPStatuses_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Parameters parameters,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      result = (CloseCPStatuses_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) closeCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseCPStatusesService) this._Channel).ResolveParametricData(this._UserProfile, closeCPStatuses, parameters, request, out result) : this.AddMethod((Method) new CloseCPStatusesMethod(closeCPStatuses, CloseCPStatusesMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) closeCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CloseCPStatuses) null, (CloseCPStatuses_Parameters) null, (CloseCPStatuses_Request) null, out CloseCPStatuses_Result _);
    }

    public ResultStatus ResolveParametricData(CloseCPStatuses closeCPStatuses)
    {
      return this.ResolveParametricData(closeCPStatuses, (CloseCPStatuses_Parameters) null, (CloseCPStatuses_Request) null, out CloseCPStatuses_Result _);
    }

    public ResultStatus ResolveParametricData(
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      return this.ResolveParametricData(closeCPStatuses, (CloseCPStatuses_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject closeCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseCPStatuses_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CloseCPStatuses) closeCPStatuses, (CloseCPStatuses_Parameters) parameters, (CloseCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject closeCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseCPStatuses_Result result1;
        ResultStatus actions = this.GetActions((CloseCPStatuses) closeCPStatuses, (CloseCPStatuses_Parameters) parameters, (CloseCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject closeCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseCPStatuses_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CloseCPStatuses) closeCPStatuses, (CloseCPStatuses_Parameters) parameters, (CloseCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject closeCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseCPStatuses_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CloseCPStatuses) closeCPStatuses, (CloseCPStatuses_LoadESigDetails_Parameters) parameters, (CloseCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject closeCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseCPStatuses_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CloseCPStatuses) closeCPStatuses, (CloseCPStatuses_Parameters) parameters, (CloseCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject closeCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseCPStatuses_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CloseCPStatuses) closeCPStatuses, (CloseCPStatuses_Parameters) parameters, (CloseCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject closeCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseCPStatuses_Result result1;
        ResultStatus resultStatus = this.Load((CloseCPStatuses) closeCPStatuses, (CloseCPStatuses_Parameters) parameters, (CloseCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject closeCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseCPStatuses_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CloseCPStatuses) closeCPStatuses, (CloseCPStatuses_Parameters) parameters, (CloseCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      result = (CloseCPStatuses_Result) null;
      try
      {
        CloseCPStatusesMethod[] methods = new CloseCPStatusesMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICloseCPStatusesService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CloseCPStatuses_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CloseCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CloseCPStatuses cdo,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      result = (CloseCPStatuses_Result) null;
      try
      {
        return ((ICloseCPStatusesService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CloseCPStatuses_Result result1;
        ResultStatus environment = this.GetEnvironment((CloseCPStatuses) cdo, (CloseCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      return this.GetEnvironment((CloseCPStatuses) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CloseCPStatuses cdo,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      result = (CloseCPStatuses_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseCPStatusesService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CloseCPStatusesMethod(cdo, CloseCPStatusesMethods.ExecuteTransaction, (CloseCPStatuses_Parameters) null));
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
        CloseCPStatuses_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CloseCPStatuses) cdo, (CloseCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CloseCPStatuses cdo)
    {
      return this.ExecuteTransaction(cdo, (CloseCPStatuses_Request) null, out CloseCPStatuses_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result)
    {
      return this.ExecuteTransaction((CloseCPStatuses) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CloseCPStatuses cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CloseCPStatusesMethod(cdo, CloseCPStatusesMethods.AddDataTransaction, (CloseCPStatuses_Parameters) null));
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
        return this.AddDataTransaction((CloseCPStatuses) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
