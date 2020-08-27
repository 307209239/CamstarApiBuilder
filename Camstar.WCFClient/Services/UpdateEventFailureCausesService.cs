// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateEventFailureCausesService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UpdateEventFailureCausesService : UpdateEventDetailsBase
  {
    public UpdateEventFailureCausesService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUpdateEventFailureCausesService), userProfile);
    }

    public ResultStatus CreateParametricData(
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Parameters parameters,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      result = (UpdateEventFailureCauses_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) updateEventFailureCauses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureCausesService) this._Channel).CreateParametricData(this._UserProfile, updateEventFailureCauses, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureCausesMethod(updateEventFailureCauses, UpdateEventFailureCausesMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) updateEventFailureCauses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((UpdateEventFailureCauses) null, (UpdateEventFailureCauses_Parameters) null, (UpdateEventFailureCauses_Request) null, out UpdateEventFailureCauses_Result _);
    }

    public ResultStatus CreateParametricData(
      UpdateEventFailureCauses updateEventFailureCauses)
    {
      return this.CreateParametricData(updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) null, (UpdateEventFailureCauses_Request) null, out UpdateEventFailureCauses_Result _);
    }

    public ResultStatus CreateParametricData(
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      return this.CreateParametricData(updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Parameters parameters,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      result = (UpdateEventFailureCauses_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) updateEventFailureCauses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureCausesService) this._Channel).GetActions(this._UserProfile, updateEventFailureCauses, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureCausesMethod(updateEventFailureCauses, UpdateEventFailureCausesMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) updateEventFailureCauses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((UpdateEventFailureCauses) null, (UpdateEventFailureCauses_Parameters) null, (UpdateEventFailureCauses_Request) null, out UpdateEventFailureCauses_Result _);
    }

    public ResultStatus GetActions(UpdateEventFailureCauses updateEventFailureCauses)
    {
      return this.GetActions(updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) null, (UpdateEventFailureCauses_Request) null, out UpdateEventFailureCauses_Result _);
    }

    public ResultStatus GetActions(
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      return this.GetActions(updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Parameters parameters,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      result = (UpdateEventFailureCauses_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) updateEventFailureCauses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureCausesService) this._Channel).GetDataPoints(this._UserProfile, updateEventFailureCauses, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureCausesMethod(updateEventFailureCauses, UpdateEventFailureCausesMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) updateEventFailureCauses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((UpdateEventFailureCauses) null, (UpdateEventFailureCauses_Parameters) null, (UpdateEventFailureCauses_Request) null, out UpdateEventFailureCauses_Result _);
    }

    public ResultStatus GetDataPoints(UpdateEventFailureCauses updateEventFailureCauses)
    {
      return this.GetDataPoints(updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) null, (UpdateEventFailureCauses_Request) null, out UpdateEventFailureCauses_Result _);
    }

    public ResultStatus GetDataPoints(
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      return this.GetDataPoints(updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Parameters parameters,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      result = (UpdateEventFailureCauses_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) updateEventFailureCauses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureCausesService) this._Channel).GetWIPMsgs(this._UserProfile, updateEventFailureCauses, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureCausesMethod(updateEventFailureCauses, UpdateEventFailureCausesMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) updateEventFailureCauses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UpdateEventFailureCauses) null, (UpdateEventFailureCauses_Parameters) null, (UpdateEventFailureCauses_Request) null, out UpdateEventFailureCauses_Result _);
    }

    public ResultStatus GetWIPMsgs(UpdateEventFailureCauses updateEventFailureCauses)
    {
      return this.GetWIPMsgs(updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) null, (UpdateEventFailureCauses_Request) null, out UpdateEventFailureCauses_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      return this.GetWIPMsgs(updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Parameters parameters,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      result = (UpdateEventFailureCauses_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) updateEventFailureCauses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureCausesService) this._Channel).Load(this._UserProfile, updateEventFailureCauses, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureCausesMethod(updateEventFailureCauses, UpdateEventFailureCausesMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) updateEventFailureCauses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UpdateEventFailureCauses) null, (UpdateEventFailureCauses_Parameters) null, (UpdateEventFailureCauses_Request) null, out UpdateEventFailureCauses_Result _);
    }

    public ResultStatus Load(UpdateEventFailureCauses updateEventFailureCauses)
    {
      return this.Load(updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) null, (UpdateEventFailureCauses_Request) null, out UpdateEventFailureCauses_Result _);
    }

    public ResultStatus Load(
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      return this.Load(updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Parameters parameters,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      result = (UpdateEventFailureCauses_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) updateEventFailureCauses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureCausesService) this._Channel).LoadESigDetails(this._UserProfile, updateEventFailureCauses, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureCausesMethod(updateEventFailureCauses, UpdateEventFailureCausesMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) updateEventFailureCauses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UpdateEventFailureCauses) null, (UpdateEventFailureCauses_Parameters) null, (UpdateEventFailureCauses_Request) null, out UpdateEventFailureCauses_Result _);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventFailureCauses updateEventFailureCauses)
    {
      return this.LoadESigDetails(updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) null, (UpdateEventFailureCauses_Request) null, out UpdateEventFailureCauses_Result _);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      return this.LoadESigDetails(updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Parameters parameters,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      result = (UpdateEventFailureCauses_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) updateEventFailureCauses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureCausesService) this._Channel).ProcessComputation(this._UserProfile, updateEventFailureCauses, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureCausesMethod(updateEventFailureCauses, UpdateEventFailureCausesMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) updateEventFailureCauses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((UpdateEventFailureCauses) null, (UpdateEventFailureCauses_Parameters) null, (UpdateEventFailureCauses_Request) null, out UpdateEventFailureCauses_Result _);
    }

    public ResultStatus ProcessComputation(
      UpdateEventFailureCauses updateEventFailureCauses)
    {
      return this.ProcessComputation(updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) null, (UpdateEventFailureCauses_Request) null, out UpdateEventFailureCauses_Result _);
    }

    public ResultStatus ProcessComputation(
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      return this.ProcessComputation(updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Parameters parameters,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      result = (UpdateEventFailureCauses_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) updateEventFailureCauses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureCausesService) this._Channel).ResolveParametricData(this._UserProfile, updateEventFailureCauses, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureCausesMethod(updateEventFailureCauses, UpdateEventFailureCausesMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) updateEventFailureCauses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((UpdateEventFailureCauses) null, (UpdateEventFailureCauses_Parameters) null, (UpdateEventFailureCauses_Request) null, out UpdateEventFailureCauses_Result _);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventFailureCauses updateEventFailureCauses)
    {
      return this.ResolveParametricData(updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) null, (UpdateEventFailureCauses_Request) null, out UpdateEventFailureCauses_Result _);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      return this.ResolveParametricData(updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject updateEventFailureCauses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailureCauses_Result result1;
        ResultStatus parametricData = this.CreateParametricData((UpdateEventFailureCauses) updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) parameters, (UpdateEventFailureCauses_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject updateEventFailureCauses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailureCauses_Result result1;
        ResultStatus actions = this.GetActions((UpdateEventFailureCauses) updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) parameters, (UpdateEventFailureCauses_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject updateEventFailureCauses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailureCauses_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((UpdateEventFailureCauses) updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) parameters, (UpdateEventFailureCauses_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject updateEventFailureCauses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailureCauses_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UpdateEventFailureCauses) updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) parameters, (UpdateEventFailureCauses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject updateEventFailureCauses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailureCauses_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((UpdateEventFailureCauses) updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) parameters, (UpdateEventFailureCauses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject updateEventFailureCauses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailureCauses_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((UpdateEventFailureCauses) updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) parameters, (UpdateEventFailureCauses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject updateEventFailureCauses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailureCauses_Result result1;
        ResultStatus resultStatus = this.Load((UpdateEventFailureCauses) updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) parameters, (UpdateEventFailureCauses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject updateEventFailureCauses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailureCauses_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UpdateEventFailureCauses) updateEventFailureCauses, (UpdateEventFailureCauses_Parameters) parameters, (UpdateEventFailureCauses_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      result = (UpdateEventFailureCauses_Result) null;
      try
      {
        UpdateEventFailureCausesMethod[] methods = new UpdateEventFailureCausesMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUpdateEventFailureCausesService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UpdateEventFailureCauses_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UpdateEventFailureCauses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventFailureCauses cdo,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      result = (UpdateEventFailureCauses_Result) null;
      try
      {
        return ((IUpdateEventFailureCausesService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UpdateEventFailureCauses_Result result1;
        ResultStatus environment = this.GetEnvironment((UpdateEventFailureCauses) cdo, (UpdateEventFailureCauses_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      return this.GetEnvironment((UpdateEventFailureCauses) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventFailureCauses cdo,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      result = (UpdateEventFailureCauses_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureCausesService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UpdateEventFailureCausesMethod(cdo, UpdateEventFailureCausesMethods.ExecuteTransaction, (UpdateEventFailureCauses_Parameters) null));
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
        UpdateEventFailureCauses_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UpdateEventFailureCauses) cdo, (UpdateEventFailureCauses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UpdateEventFailureCauses cdo)
    {
      return this.ExecuteTransaction(cdo, (UpdateEventFailureCauses_Request) null, out UpdateEventFailureCauses_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result)
    {
      return this.ExecuteTransaction((UpdateEventFailureCauses) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UpdateEventFailureCauses cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UpdateEventFailureCausesMethod(cdo, UpdateEventFailureCausesMethods.AddDataTransaction, (UpdateEventFailureCauses_Parameters) null));
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
        return this.AddDataTransaction((UpdateEventFailureCauses) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
