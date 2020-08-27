// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ReprocessActivityService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ReprocessActivityService : ProcessObjectTxnBase
  {
    public ReprocessActivityService(UserProfile userProfile)
    {
      this.Initialize(typeof (IReprocessActivityService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Parameters parameters,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      result = (ReprocessActivity_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) reprocessActivity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprocessActivityService) this._Channel).CreateParametricData(this._UserProfile, reprocessActivity, parameters, request, out result) : this.AddMethod((Method) new ReprocessActivityMethod(reprocessActivity, ReprocessActivityMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) reprocessActivity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ReprocessActivity) null, (ReprocessActivity_Parameters) null, (ReprocessActivity_Request) null, out ReprocessActivity_Result _);
    }

    public ResultStatus CreateParametricData(ReprocessActivity reprocessActivity)
    {
      return this.CreateParametricData(reprocessActivity, (ReprocessActivity_Parameters) null, (ReprocessActivity_Request) null, out ReprocessActivity_Result _);
    }

    public ResultStatus CreateParametricData(
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      return this.CreateParametricData(reprocessActivity, (ReprocessActivity_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Parameters parameters,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      result = (ReprocessActivity_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) reprocessActivity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprocessActivityService) this._Channel).GetActions(this._UserProfile, reprocessActivity, parameters, request, out result) : this.AddMethod((Method) new ReprocessActivityMethod(reprocessActivity, ReprocessActivityMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) reprocessActivity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ReprocessActivity) null, (ReprocessActivity_Parameters) null, (ReprocessActivity_Request) null, out ReprocessActivity_Result _);
    }

    public ResultStatus GetActions(ReprocessActivity reprocessActivity)
    {
      return this.GetActions(reprocessActivity, (ReprocessActivity_Parameters) null, (ReprocessActivity_Request) null, out ReprocessActivity_Result _);
    }

    public ResultStatus GetActions(
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      return this.GetActions(reprocessActivity, (ReprocessActivity_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Parameters parameters,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      result = (ReprocessActivity_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) reprocessActivity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprocessActivityService) this._Channel).GetDataPoints(this._UserProfile, reprocessActivity, parameters, request, out result) : this.AddMethod((Method) new ReprocessActivityMethod(reprocessActivity, ReprocessActivityMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) reprocessActivity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ReprocessActivity) null, (ReprocessActivity_Parameters) null, (ReprocessActivity_Request) null, out ReprocessActivity_Result _);
    }

    public ResultStatus GetDataPoints(ReprocessActivity reprocessActivity)
    {
      return this.GetDataPoints(reprocessActivity, (ReprocessActivity_Parameters) null, (ReprocessActivity_Request) null, out ReprocessActivity_Result _);
    }

    public ResultStatus GetDataPoints(
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      return this.GetDataPoints(reprocessActivity, (ReprocessActivity_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Parameters parameters,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      result = (ReprocessActivity_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) reprocessActivity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprocessActivityService) this._Channel).GetWIPMsgs(this._UserProfile, reprocessActivity, parameters, request, out result) : this.AddMethod((Method) new ReprocessActivityMethod(reprocessActivity, ReprocessActivityMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) reprocessActivity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ReprocessActivity) null, (ReprocessActivity_Parameters) null, (ReprocessActivity_Request) null, out ReprocessActivity_Result _);
    }

    public ResultStatus GetWIPMsgs(ReprocessActivity reprocessActivity)
    {
      return this.GetWIPMsgs(reprocessActivity, (ReprocessActivity_Parameters) null, (ReprocessActivity_Request) null, out ReprocessActivity_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      return this.GetWIPMsgs(reprocessActivity, (ReprocessActivity_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Parameters parameters,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      result = (ReprocessActivity_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) reprocessActivity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprocessActivityService) this._Channel).Load(this._UserProfile, reprocessActivity, parameters, request, out result) : this.AddMethod((Method) new ReprocessActivityMethod(reprocessActivity, ReprocessActivityMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) reprocessActivity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ReprocessActivity) null, (ReprocessActivity_Parameters) null, (ReprocessActivity_Request) null, out ReprocessActivity_Result _);
    }

    public ResultStatus Load(ReprocessActivity reprocessActivity)
    {
      return this.Load(reprocessActivity, (ReprocessActivity_Parameters) null, (ReprocessActivity_Request) null, out ReprocessActivity_Result _);
    }

    public ResultStatus Load(
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      return this.Load(reprocessActivity, (ReprocessActivity_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Parameters parameters,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      result = (ReprocessActivity_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) reprocessActivity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprocessActivityService) this._Channel).LoadESigDetails(this._UserProfile, reprocessActivity, parameters, request, out result) : this.AddMethod((Method) new ReprocessActivityMethod(reprocessActivity, ReprocessActivityMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) reprocessActivity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ReprocessActivity) null, (ReprocessActivity_Parameters) null, (ReprocessActivity_Request) null, out ReprocessActivity_Result _);
    }

    public ResultStatus LoadESigDetails(ReprocessActivity reprocessActivity)
    {
      return this.LoadESigDetails(reprocessActivity, (ReprocessActivity_Parameters) null, (ReprocessActivity_Request) null, out ReprocessActivity_Result _);
    }

    public ResultStatus LoadESigDetails(
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      return this.LoadESigDetails(reprocessActivity, (ReprocessActivity_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Parameters parameters,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      result = (ReprocessActivity_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) reprocessActivity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprocessActivityService) this._Channel).ProcessComputation(this._UserProfile, reprocessActivity, parameters, request, out result) : this.AddMethod((Method) new ReprocessActivityMethod(reprocessActivity, ReprocessActivityMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) reprocessActivity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ReprocessActivity) null, (ReprocessActivity_Parameters) null, (ReprocessActivity_Request) null, out ReprocessActivity_Result _);
    }

    public ResultStatus ProcessComputation(ReprocessActivity reprocessActivity)
    {
      return this.ProcessComputation(reprocessActivity, (ReprocessActivity_Parameters) null, (ReprocessActivity_Request) null, out ReprocessActivity_Result _);
    }

    public ResultStatus ProcessComputation(
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      return this.ProcessComputation(reprocessActivity, (ReprocessActivity_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Parameters parameters,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      result = (ReprocessActivity_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) reprocessActivity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprocessActivityService) this._Channel).ResolveParametricData(this._UserProfile, reprocessActivity, parameters, request, out result) : this.AddMethod((Method) new ReprocessActivityMethod(reprocessActivity, ReprocessActivityMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) reprocessActivity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ReprocessActivity) null, (ReprocessActivity_Parameters) null, (ReprocessActivity_Request) null, out ReprocessActivity_Result _);
    }

    public ResultStatus ResolveParametricData(ReprocessActivity reprocessActivity)
    {
      return this.ResolveParametricData(reprocessActivity, (ReprocessActivity_Parameters) null, (ReprocessActivity_Request) null, out ReprocessActivity_Result _);
    }

    public ResultStatus ResolveParametricData(
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      return this.ResolveParametricData(reprocessActivity, (ReprocessActivity_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject reprocessActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprocessActivity_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ReprocessActivity) reprocessActivity, (ReprocessActivity_Parameters) parameters, (ReprocessActivity_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject reprocessActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprocessActivity_Result result1;
        ResultStatus actions = this.GetActions((ReprocessActivity) reprocessActivity, (ReprocessActivity_Parameters) parameters, (ReprocessActivity_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject reprocessActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprocessActivity_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ReprocessActivity) reprocessActivity, (ReprocessActivity_Parameters) parameters, (ReprocessActivity_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject reprocessActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprocessActivity_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ReprocessActivity) reprocessActivity, (ReprocessActivity_Parameters) parameters, (ReprocessActivity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject reprocessActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprocessActivity_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ReprocessActivity) reprocessActivity, (ReprocessActivity_Parameters) parameters, (ReprocessActivity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject reprocessActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprocessActivity_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ReprocessActivity) reprocessActivity, (ReprocessActivity_Parameters) parameters, (ReprocessActivity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject reprocessActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprocessActivity_Result result1;
        ResultStatus resultStatus = this.Load((ReprocessActivity) reprocessActivity, (ReprocessActivity_Parameters) parameters, (ReprocessActivity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject reprocessActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprocessActivity_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ReprocessActivity) reprocessActivity, (ReprocessActivity_Parameters) parameters, (ReprocessActivity_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      result = (ReprocessActivity_Result) null;
      try
      {
        ReprocessActivityMethod[] methods = new ReprocessActivityMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IReprocessActivityService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ReprocessActivity_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ReprocessActivity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReprocessActivity cdo,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      result = (ReprocessActivity_Result) null;
      try
      {
        return ((IReprocessActivityService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ReprocessActivity_Result result1;
        ResultStatus environment = this.GetEnvironment((ReprocessActivity) cdo, (ReprocessActivity_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      return this.GetEnvironment((ReprocessActivity) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ReprocessActivity cdo,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      result = (ReprocessActivity_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprocessActivityService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ReprocessActivityMethod(cdo, ReprocessActivityMethods.ExecuteTransaction, (ReprocessActivity_Parameters) null));
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
        ReprocessActivity_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ReprocessActivity) cdo, (ReprocessActivity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ReprocessActivity cdo)
    {
      return this.ExecuteTransaction(cdo, (ReprocessActivity_Request) null, out ReprocessActivity_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result)
    {
      return this.ExecuteTransaction((ReprocessActivity) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ReprocessActivity cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ReprocessActivityMethod(cdo, ReprocessActivityMethods.AddDataTransaction, (ReprocessActivity_Parameters) null));
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
        return this.AddDataTransaction((ReprocessActivity) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
