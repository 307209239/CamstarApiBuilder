// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateEventCrossRefsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UpdateEventCrossRefsService : UpdateEventDetailsBase
  {
    public UpdateEventCrossRefsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUpdateEventCrossRefsService), userProfile);
    }

    public ResultStatus CreateParametricData(
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Parameters parameters,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      result = (UpdateEventCrossRefs_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) updateEventCrossRefs, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventCrossRefsService) this._Channel).CreateParametricData(this._UserProfile, updateEventCrossRefs, parameters, request, out result) : this.AddMethod((Method) new UpdateEventCrossRefsMethod(updateEventCrossRefs, UpdateEventCrossRefsMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) updateEventCrossRefs, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((UpdateEventCrossRefs) null, (UpdateEventCrossRefs_Parameters) null, (UpdateEventCrossRefs_Request) null, out UpdateEventCrossRefs_Result _);
    }

    public ResultStatus CreateParametricData(UpdateEventCrossRefs updateEventCrossRefs)
    {
      return this.CreateParametricData(updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) null, (UpdateEventCrossRefs_Request) null, out UpdateEventCrossRefs_Result _);
    }

    public ResultStatus CreateParametricData(
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      return this.CreateParametricData(updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Parameters parameters,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      result = (UpdateEventCrossRefs_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) updateEventCrossRefs, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventCrossRefsService) this._Channel).GetActions(this._UserProfile, updateEventCrossRefs, parameters, request, out result) : this.AddMethod((Method) new UpdateEventCrossRefsMethod(updateEventCrossRefs, UpdateEventCrossRefsMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) updateEventCrossRefs, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((UpdateEventCrossRefs) null, (UpdateEventCrossRefs_Parameters) null, (UpdateEventCrossRefs_Request) null, out UpdateEventCrossRefs_Result _);
    }

    public ResultStatus GetActions(UpdateEventCrossRefs updateEventCrossRefs)
    {
      return this.GetActions(updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) null, (UpdateEventCrossRefs_Request) null, out UpdateEventCrossRefs_Result _);
    }

    public ResultStatus GetActions(
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      return this.GetActions(updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Parameters parameters,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      result = (UpdateEventCrossRefs_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) updateEventCrossRefs, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventCrossRefsService) this._Channel).GetDataPoints(this._UserProfile, updateEventCrossRefs, parameters, request, out result) : this.AddMethod((Method) new UpdateEventCrossRefsMethod(updateEventCrossRefs, UpdateEventCrossRefsMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) updateEventCrossRefs, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((UpdateEventCrossRefs) null, (UpdateEventCrossRefs_Parameters) null, (UpdateEventCrossRefs_Request) null, out UpdateEventCrossRefs_Result _);
    }

    public ResultStatus GetDataPoints(UpdateEventCrossRefs updateEventCrossRefs)
    {
      return this.GetDataPoints(updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) null, (UpdateEventCrossRefs_Request) null, out UpdateEventCrossRefs_Result _);
    }

    public ResultStatus GetDataPoints(
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      return this.GetDataPoints(updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Parameters parameters,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      result = (UpdateEventCrossRefs_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) updateEventCrossRefs, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventCrossRefsService) this._Channel).GetWIPMsgs(this._UserProfile, updateEventCrossRefs, parameters, request, out result) : this.AddMethod((Method) new UpdateEventCrossRefsMethod(updateEventCrossRefs, UpdateEventCrossRefsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) updateEventCrossRefs, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UpdateEventCrossRefs) null, (UpdateEventCrossRefs_Parameters) null, (UpdateEventCrossRefs_Request) null, out UpdateEventCrossRefs_Result _);
    }

    public ResultStatus GetWIPMsgs(UpdateEventCrossRefs updateEventCrossRefs)
    {
      return this.GetWIPMsgs(updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) null, (UpdateEventCrossRefs_Request) null, out UpdateEventCrossRefs_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      return this.GetWIPMsgs(updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Parameters parameters,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      result = (UpdateEventCrossRefs_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) updateEventCrossRefs, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventCrossRefsService) this._Channel).Load(this._UserProfile, updateEventCrossRefs, parameters, request, out result) : this.AddMethod((Method) new UpdateEventCrossRefsMethod(updateEventCrossRefs, UpdateEventCrossRefsMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) updateEventCrossRefs, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UpdateEventCrossRefs) null, (UpdateEventCrossRefs_Parameters) null, (UpdateEventCrossRefs_Request) null, out UpdateEventCrossRefs_Result _);
    }

    public ResultStatus Load(UpdateEventCrossRefs updateEventCrossRefs)
    {
      return this.Load(updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) null, (UpdateEventCrossRefs_Request) null, out UpdateEventCrossRefs_Result _);
    }

    public ResultStatus Load(
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      return this.Load(updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Parameters parameters,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      result = (UpdateEventCrossRefs_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) updateEventCrossRefs, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventCrossRefsService) this._Channel).LoadESigDetails(this._UserProfile, updateEventCrossRefs, parameters, request, out result) : this.AddMethod((Method) new UpdateEventCrossRefsMethod(updateEventCrossRefs, UpdateEventCrossRefsMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) updateEventCrossRefs, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UpdateEventCrossRefs) null, (UpdateEventCrossRefs_Parameters) null, (UpdateEventCrossRefs_Request) null, out UpdateEventCrossRefs_Result _);
    }

    public ResultStatus LoadESigDetails(UpdateEventCrossRefs updateEventCrossRefs)
    {
      return this.LoadESigDetails(updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) null, (UpdateEventCrossRefs_Request) null, out UpdateEventCrossRefs_Result _);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      return this.LoadESigDetails(updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Parameters parameters,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      result = (UpdateEventCrossRefs_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) updateEventCrossRefs, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventCrossRefsService) this._Channel).ProcessComputation(this._UserProfile, updateEventCrossRefs, parameters, request, out result) : this.AddMethod((Method) new UpdateEventCrossRefsMethod(updateEventCrossRefs, UpdateEventCrossRefsMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) updateEventCrossRefs, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((UpdateEventCrossRefs) null, (UpdateEventCrossRefs_Parameters) null, (UpdateEventCrossRefs_Request) null, out UpdateEventCrossRefs_Result _);
    }

    public ResultStatus ProcessComputation(UpdateEventCrossRefs updateEventCrossRefs)
    {
      return this.ProcessComputation(updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) null, (UpdateEventCrossRefs_Request) null, out UpdateEventCrossRefs_Result _);
    }

    public ResultStatus ProcessComputation(
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      return this.ProcessComputation(updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Parameters parameters,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      result = (UpdateEventCrossRefs_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) updateEventCrossRefs, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventCrossRefsService) this._Channel).ResolveParametricData(this._UserProfile, updateEventCrossRefs, parameters, request, out result) : this.AddMethod((Method) new UpdateEventCrossRefsMethod(updateEventCrossRefs, UpdateEventCrossRefsMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) updateEventCrossRefs, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((UpdateEventCrossRefs) null, (UpdateEventCrossRefs_Parameters) null, (UpdateEventCrossRefs_Request) null, out UpdateEventCrossRefs_Result _);
    }

    public ResultStatus ResolveParametricData(UpdateEventCrossRefs updateEventCrossRefs)
    {
      return this.ResolveParametricData(updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) null, (UpdateEventCrossRefs_Request) null, out UpdateEventCrossRefs_Result _);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      return this.ResolveParametricData(updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject updateEventCrossRefs,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventCrossRefs_Result result1;
        ResultStatus parametricData = this.CreateParametricData((UpdateEventCrossRefs) updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) parameters, (UpdateEventCrossRefs_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject updateEventCrossRefs,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventCrossRefs_Result result1;
        ResultStatus actions = this.GetActions((UpdateEventCrossRefs) updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) parameters, (UpdateEventCrossRefs_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject updateEventCrossRefs,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventCrossRefs_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((UpdateEventCrossRefs) updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) parameters, (UpdateEventCrossRefs_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject updateEventCrossRefs,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventCrossRefs_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UpdateEventCrossRefs) updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) parameters, (UpdateEventCrossRefs_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject updateEventCrossRefs,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventCrossRefs_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((UpdateEventCrossRefs) updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) parameters, (UpdateEventCrossRefs_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject updateEventCrossRefs,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventCrossRefs_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((UpdateEventCrossRefs) updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) parameters, (UpdateEventCrossRefs_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject updateEventCrossRefs,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventCrossRefs_Result result1;
        ResultStatus resultStatus = this.Load((UpdateEventCrossRefs) updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) parameters, (UpdateEventCrossRefs_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject updateEventCrossRefs,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventCrossRefs_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UpdateEventCrossRefs) updateEventCrossRefs, (UpdateEventCrossRefs_Parameters) parameters, (UpdateEventCrossRefs_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      result = (UpdateEventCrossRefs_Result) null;
      try
      {
        UpdateEventCrossRefsMethod[] methods = new UpdateEventCrossRefsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUpdateEventCrossRefsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UpdateEventCrossRefs_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UpdateEventCrossRefs_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventCrossRefs cdo,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      result = (UpdateEventCrossRefs_Result) null;
      try
      {
        return ((IUpdateEventCrossRefsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UpdateEventCrossRefs_Result result1;
        ResultStatus environment = this.GetEnvironment((UpdateEventCrossRefs) cdo, (UpdateEventCrossRefs_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      return this.GetEnvironment((UpdateEventCrossRefs) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventCrossRefs cdo,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      result = (UpdateEventCrossRefs_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventCrossRefsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UpdateEventCrossRefsMethod(cdo, UpdateEventCrossRefsMethods.ExecuteTransaction, (UpdateEventCrossRefs_Parameters) null));
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
        UpdateEventCrossRefs_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UpdateEventCrossRefs) cdo, (UpdateEventCrossRefs_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UpdateEventCrossRefs cdo)
    {
      return this.ExecuteTransaction(cdo, (UpdateEventCrossRefs_Request) null, out UpdateEventCrossRefs_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result)
    {
      return this.ExecuteTransaction((UpdateEventCrossRefs) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UpdateEventCrossRefs cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UpdateEventCrossRefsMethod(cdo, UpdateEventCrossRefsMethods.AddDataTransaction, (UpdateEventCrossRefs_Parameters) null));
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
        return this.AddDataTransaction((UpdateEventCrossRefs) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
