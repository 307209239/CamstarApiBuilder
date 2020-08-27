// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateEventDispositionsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UpdateEventDispositionsService : UpdateEventDetailsBase
  {
    public UpdateEventDispositionsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUpdateEventDispositionsService), userProfile);
    }

    public ResultStatus CreateParametricData(
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Parameters parameters,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      result = (UpdateEventDispositions_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) updateEventDispositions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDispositionsService) this._Channel).CreateParametricData(this._UserProfile, updateEventDispositions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDispositionsMethod(updateEventDispositions, UpdateEventDispositionsMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) updateEventDispositions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((UpdateEventDispositions) null, (UpdateEventDispositions_Parameters) null, (UpdateEventDispositions_Request) null, out UpdateEventDispositions_Result _);
    }

    public ResultStatus CreateParametricData(
      UpdateEventDispositions updateEventDispositions)
    {
      return this.CreateParametricData(updateEventDispositions, (UpdateEventDispositions_Parameters) null, (UpdateEventDispositions_Request) null, out UpdateEventDispositions_Result _);
    }

    public ResultStatus CreateParametricData(
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      return this.CreateParametricData(updateEventDispositions, (UpdateEventDispositions_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Parameters parameters,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      result = (UpdateEventDispositions_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) updateEventDispositions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDispositionsService) this._Channel).GetActions(this._UserProfile, updateEventDispositions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDispositionsMethod(updateEventDispositions, UpdateEventDispositionsMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) updateEventDispositions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((UpdateEventDispositions) null, (UpdateEventDispositions_Parameters) null, (UpdateEventDispositions_Request) null, out UpdateEventDispositions_Result _);
    }

    public ResultStatus GetActions(UpdateEventDispositions updateEventDispositions)
    {
      return this.GetActions(updateEventDispositions, (UpdateEventDispositions_Parameters) null, (UpdateEventDispositions_Request) null, out UpdateEventDispositions_Result _);
    }

    public ResultStatus GetActions(
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      return this.GetActions(updateEventDispositions, (UpdateEventDispositions_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Parameters parameters,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      result = (UpdateEventDispositions_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) updateEventDispositions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDispositionsService) this._Channel).GetDataPoints(this._UserProfile, updateEventDispositions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDispositionsMethod(updateEventDispositions, UpdateEventDispositionsMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) updateEventDispositions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((UpdateEventDispositions) null, (UpdateEventDispositions_Parameters) null, (UpdateEventDispositions_Request) null, out UpdateEventDispositions_Result _);
    }

    public ResultStatus GetDataPoints(UpdateEventDispositions updateEventDispositions)
    {
      return this.GetDataPoints(updateEventDispositions, (UpdateEventDispositions_Parameters) null, (UpdateEventDispositions_Request) null, out UpdateEventDispositions_Result _);
    }

    public ResultStatus GetDataPoints(
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      return this.GetDataPoints(updateEventDispositions, (UpdateEventDispositions_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Parameters parameters,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      result = (UpdateEventDispositions_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) updateEventDispositions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDispositionsService) this._Channel).GetWIPMsgs(this._UserProfile, updateEventDispositions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDispositionsMethod(updateEventDispositions, UpdateEventDispositionsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) updateEventDispositions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UpdateEventDispositions) null, (UpdateEventDispositions_Parameters) null, (UpdateEventDispositions_Request) null, out UpdateEventDispositions_Result _);
    }

    public ResultStatus GetWIPMsgs(UpdateEventDispositions updateEventDispositions)
    {
      return this.GetWIPMsgs(updateEventDispositions, (UpdateEventDispositions_Parameters) null, (UpdateEventDispositions_Request) null, out UpdateEventDispositions_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      return this.GetWIPMsgs(updateEventDispositions, (UpdateEventDispositions_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Parameters parameters,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      result = (UpdateEventDispositions_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) updateEventDispositions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDispositionsService) this._Channel).Load(this._UserProfile, updateEventDispositions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDispositionsMethod(updateEventDispositions, UpdateEventDispositionsMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) updateEventDispositions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UpdateEventDispositions) null, (UpdateEventDispositions_Parameters) null, (UpdateEventDispositions_Request) null, out UpdateEventDispositions_Result _);
    }

    public ResultStatus Load(UpdateEventDispositions updateEventDispositions)
    {
      return this.Load(updateEventDispositions, (UpdateEventDispositions_Parameters) null, (UpdateEventDispositions_Request) null, out UpdateEventDispositions_Result _);
    }

    public ResultStatus Load(
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      return this.Load(updateEventDispositions, (UpdateEventDispositions_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Parameters parameters,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      result = (UpdateEventDispositions_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) updateEventDispositions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDispositionsService) this._Channel).LoadESigDetails(this._UserProfile, updateEventDispositions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDispositionsMethod(updateEventDispositions, UpdateEventDispositionsMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) updateEventDispositions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UpdateEventDispositions) null, (UpdateEventDispositions_Parameters) null, (UpdateEventDispositions_Request) null, out UpdateEventDispositions_Result _);
    }

    public ResultStatus LoadESigDetails(UpdateEventDispositions updateEventDispositions)
    {
      return this.LoadESigDetails(updateEventDispositions, (UpdateEventDispositions_Parameters) null, (UpdateEventDispositions_Request) null, out UpdateEventDispositions_Result _);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      return this.LoadESigDetails(updateEventDispositions, (UpdateEventDispositions_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Parameters parameters,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      result = (UpdateEventDispositions_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) updateEventDispositions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDispositionsService) this._Channel).ProcessComputation(this._UserProfile, updateEventDispositions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDispositionsMethod(updateEventDispositions, UpdateEventDispositionsMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) updateEventDispositions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((UpdateEventDispositions) null, (UpdateEventDispositions_Parameters) null, (UpdateEventDispositions_Request) null, out UpdateEventDispositions_Result _);
    }

    public ResultStatus ProcessComputation(
      UpdateEventDispositions updateEventDispositions)
    {
      return this.ProcessComputation(updateEventDispositions, (UpdateEventDispositions_Parameters) null, (UpdateEventDispositions_Request) null, out UpdateEventDispositions_Result _);
    }

    public ResultStatus ProcessComputation(
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      return this.ProcessComputation(updateEventDispositions, (UpdateEventDispositions_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Parameters parameters,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      result = (UpdateEventDispositions_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) updateEventDispositions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDispositionsService) this._Channel).ResolveParametricData(this._UserProfile, updateEventDispositions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDispositionsMethod(updateEventDispositions, UpdateEventDispositionsMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) updateEventDispositions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((UpdateEventDispositions) null, (UpdateEventDispositions_Parameters) null, (UpdateEventDispositions_Request) null, out UpdateEventDispositions_Result _);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventDispositions updateEventDispositions)
    {
      return this.ResolveParametricData(updateEventDispositions, (UpdateEventDispositions_Parameters) null, (UpdateEventDispositions_Request) null, out UpdateEventDispositions_Result _);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      return this.ResolveParametricData(updateEventDispositions, (UpdateEventDispositions_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject updateEventDispositions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventDispositions_Result result1;
        ResultStatus parametricData = this.CreateParametricData((UpdateEventDispositions) updateEventDispositions, (UpdateEventDispositions_Parameters) parameters, (UpdateEventDispositions_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject updateEventDispositions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventDispositions_Result result1;
        ResultStatus actions = this.GetActions((UpdateEventDispositions) updateEventDispositions, (UpdateEventDispositions_Parameters) parameters, (UpdateEventDispositions_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject updateEventDispositions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventDispositions_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((UpdateEventDispositions) updateEventDispositions, (UpdateEventDispositions_Parameters) parameters, (UpdateEventDispositions_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject updateEventDispositions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventDispositions_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UpdateEventDispositions) updateEventDispositions, (UpdateEventDispositions_Parameters) parameters, (UpdateEventDispositions_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject updateEventDispositions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventDispositions_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((UpdateEventDispositions) updateEventDispositions, (UpdateEventDispositions_Parameters) parameters, (UpdateEventDispositions_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject updateEventDispositions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventDispositions_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((UpdateEventDispositions) updateEventDispositions, (UpdateEventDispositions_Parameters) parameters, (UpdateEventDispositions_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject updateEventDispositions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventDispositions_Result result1;
        ResultStatus resultStatus = this.Load((UpdateEventDispositions) updateEventDispositions, (UpdateEventDispositions_Parameters) parameters, (UpdateEventDispositions_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject updateEventDispositions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventDispositions_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UpdateEventDispositions) updateEventDispositions, (UpdateEventDispositions_Parameters) parameters, (UpdateEventDispositions_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      result = (UpdateEventDispositions_Result) null;
      try
      {
        UpdateEventDispositionsMethod[] methods = new UpdateEventDispositionsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUpdateEventDispositionsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UpdateEventDispositions_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UpdateEventDispositions_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventDispositions cdo,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      result = (UpdateEventDispositions_Result) null;
      try
      {
        return ((IUpdateEventDispositionsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UpdateEventDispositions_Result result1;
        ResultStatus environment = this.GetEnvironment((UpdateEventDispositions) cdo, (UpdateEventDispositions_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      return this.GetEnvironment((UpdateEventDispositions) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventDispositions cdo,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      result = (UpdateEventDispositions_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDispositionsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UpdateEventDispositionsMethod(cdo, UpdateEventDispositionsMethods.ExecuteTransaction, (UpdateEventDispositions_Parameters) null));
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
        UpdateEventDispositions_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UpdateEventDispositions) cdo, (UpdateEventDispositions_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UpdateEventDispositions cdo)
    {
      return this.ExecuteTransaction(cdo, (UpdateEventDispositions_Request) null, out UpdateEventDispositions_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result)
    {
      return this.ExecuteTransaction((UpdateEventDispositions) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UpdateEventDispositions cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UpdateEventDispositionsMethod(cdo, UpdateEventDispositionsMethods.AddDataTransaction, (UpdateEventDispositions_Parameters) null));
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
        return this.AddDataTransaction((UpdateEventDispositions) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
