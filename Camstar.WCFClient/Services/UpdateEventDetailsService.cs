// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateEventDetailsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UpdateEventDetailsService : QualityTxnBase
  {
    public UpdateEventDetailsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUpdateEventDetailsService), userProfile);
    }

    public ResultStatus CreateParametricData(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      result = (UpdateEventDetails_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) updateEventDetails, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDetailsService) this._Channel).CreateParametricData(this._UserProfile, updateEventDetails, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDetailsMethod(updateEventDetails, UpdateEventDetailsMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) updateEventDetails, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((UpdateEventDetails) null, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus CreateParametricData(UpdateEventDetails updateEventDetails)
    {
      return this.CreateParametricData(updateEventDetails, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus CreateParametricData(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      return this.CreateParametricData(updateEventDetails, (UpdateEventDetails_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      result = (UpdateEventDetails_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) updateEventDetails, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDetailsService) this._Channel).GetActions(this._UserProfile, updateEventDetails, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDetailsMethod(updateEventDetails, UpdateEventDetailsMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) updateEventDetails, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((UpdateEventDetails) null, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus GetActions(UpdateEventDetails updateEventDetails)
    {
      return this.GetActions(updateEventDetails, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus GetActions(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      return this.GetActions(updateEventDetails, (UpdateEventDetails_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      result = (UpdateEventDetails_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) updateEventDetails, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDetailsService) this._Channel).GetDataPoints(this._UserProfile, updateEventDetails, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDetailsMethod(updateEventDetails, UpdateEventDetailsMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) updateEventDetails, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((UpdateEventDetails) null, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus GetDataPoints(UpdateEventDetails updateEventDetails)
    {
      return this.GetDataPoints(updateEventDetails, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus GetDataPoints(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      return this.GetDataPoints(updateEventDetails, (UpdateEventDetails_Parameters) null, request, out result);
    }

    public ResultStatus GetDetails(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      result = (UpdateEventDetails_Result) null;
      this.OnBeforeCall(nameof (GetDetails), (DCObject) updateEventDetails, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDetailsService) this._Channel).GetDetails(this._UserProfile, updateEventDetails, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDetailsMethod(updateEventDetails, UpdateEventDetailsMethods.GetDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDetails), res, (DCObject) updateEventDetails, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDetails()
    {
      return this.GetDetails((UpdateEventDetails) null, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus GetDetails(UpdateEventDetails updateEventDetails)
    {
      return this.GetDetails(updateEventDetails, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus GetDetails(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      return this.GetDetails(updateEventDetails, (UpdateEventDetails_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      result = (UpdateEventDetails_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) updateEventDetails, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDetailsService) this._Channel).GetWIPMsgs(this._UserProfile, updateEventDetails, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDetailsMethod(updateEventDetails, UpdateEventDetailsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) updateEventDetails, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UpdateEventDetails) null, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus GetWIPMsgs(UpdateEventDetails updateEventDetails)
    {
      return this.GetWIPMsgs(updateEventDetails, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      return this.GetWIPMsgs(updateEventDetails, (UpdateEventDetails_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      result = (UpdateEventDetails_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) updateEventDetails, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDetailsService) this._Channel).Load(this._UserProfile, updateEventDetails, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDetailsMethod(updateEventDetails, UpdateEventDetailsMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) updateEventDetails, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UpdateEventDetails) null, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus Load(UpdateEventDetails updateEventDetails)
    {
      return this.Load(updateEventDetails, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus Load(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      return this.Load(updateEventDetails, (UpdateEventDetails_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      result = (UpdateEventDetails_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) updateEventDetails, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDetailsService) this._Channel).LoadESigDetails(this._UserProfile, updateEventDetails, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDetailsMethod(updateEventDetails, UpdateEventDetailsMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) updateEventDetails, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UpdateEventDetails) null, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus LoadESigDetails(UpdateEventDetails updateEventDetails)
    {
      return this.LoadESigDetails(updateEventDetails, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      return this.LoadESigDetails(updateEventDetails, (UpdateEventDetails_Parameters) null, request, out result);
    }

    public ResultStatus ModifyDetails(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      result = (UpdateEventDetails_Result) null;
      this.OnBeforeCall(nameof (ModifyDetails), (DCObject) updateEventDetails, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDetailsService) this._Channel).ModifyDetails(this._UserProfile, updateEventDetails, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDetailsMethod(updateEventDetails, UpdateEventDetailsMethods.ModifyDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ModifyDetails), res, (DCObject) updateEventDetails, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ModifyDetails()
    {
      return this.ModifyDetails((UpdateEventDetails) null, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus ModifyDetails(UpdateEventDetails updateEventDetails)
    {
      return this.ModifyDetails(updateEventDetails, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus ModifyDetails(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      return this.ModifyDetails(updateEventDetails, (UpdateEventDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      result = (UpdateEventDetails_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) updateEventDetails, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDetailsService) this._Channel).ProcessComputation(this._UserProfile, updateEventDetails, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDetailsMethod(updateEventDetails, UpdateEventDetailsMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) updateEventDetails, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((UpdateEventDetails) null, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus ProcessComputation(UpdateEventDetails updateEventDetails)
    {
      return this.ProcessComputation(updateEventDetails, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus ProcessComputation(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      return this.ProcessComputation(updateEventDetails, (UpdateEventDetails_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      result = (UpdateEventDetails_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) updateEventDetails, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDetailsService) this._Channel).ResolveParametricData(this._UserProfile, updateEventDetails, parameters, request, out result) : this.AddMethod((Method) new UpdateEventDetailsMethod(updateEventDetails, UpdateEventDetailsMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) updateEventDetails, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((UpdateEventDetails) null, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus ResolveParametricData(UpdateEventDetails updateEventDetails)
    {
      return this.ResolveParametricData(updateEventDetails, (UpdateEventDetails_Parameters) null, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      return this.ResolveParametricData(updateEventDetails, (UpdateEventDetails_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject updateEventDetails,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventDetails_Result result1;
        ResultStatus parametricData = this.CreateParametricData((UpdateEventDetails) updateEventDetails, (UpdateEventDetails_Parameters) parameters, (UpdateEventDetails_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject updateEventDetails,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventDetails_Result result1;
        ResultStatus actions = this.GetActions((UpdateEventDetails) updateEventDetails, (UpdateEventDetails_Parameters) parameters, (UpdateEventDetails_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject updateEventDetails,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventDetails_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((UpdateEventDetails) updateEventDetails, (UpdateEventDetails_Parameters) parameters, (UpdateEventDetails_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject updateEventDetails,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventDetails_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UpdateEventDetails) updateEventDetails, (UpdateEventDetails_Parameters) parameters, (UpdateEventDetails_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject updateEventDetails,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventDetails_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((UpdateEventDetails) updateEventDetails, (UpdateEventDetails_Parameters) parameters, (UpdateEventDetails_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject updateEventDetails,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventDetails_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((UpdateEventDetails) updateEventDetails, (UpdateEventDetails_Parameters) parameters, (UpdateEventDetails_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject updateEventDetails,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventDetails_Result result1;
        ResultStatus resultStatus = this.Load((UpdateEventDetails) updateEventDetails, (UpdateEventDetails_Parameters) parameters, (UpdateEventDetails_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject updateEventDetails,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventDetails_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UpdateEventDetails) updateEventDetails, (UpdateEventDetails_Parameters) parameters, (UpdateEventDetails_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      result = (UpdateEventDetails_Result) null;
      try
      {
        UpdateEventDetailsMethod[] methods = new UpdateEventDetailsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUpdateEventDetailsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UpdateEventDetails_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UpdateEventDetails_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventDetails cdo,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      result = (UpdateEventDetails_Result) null;
      try
      {
        return ((IUpdateEventDetailsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UpdateEventDetails_Result result1;
        ResultStatus environment = this.GetEnvironment((UpdateEventDetails) cdo, (UpdateEventDetails_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      return this.GetEnvironment((UpdateEventDetails) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventDetails cdo,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      result = (UpdateEventDetails_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventDetailsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UpdateEventDetailsMethod(cdo, UpdateEventDetailsMethods.ExecuteTransaction, (UpdateEventDetails_Parameters) null));
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
        UpdateEventDetails_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UpdateEventDetails) cdo, (UpdateEventDetails_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UpdateEventDetails cdo)
    {
      return this.ExecuteTransaction(cdo, (UpdateEventDetails_Request) null, out UpdateEventDetails_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result)
    {
      return this.ExecuteTransaction((UpdateEventDetails) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UpdateEventDetails cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UpdateEventDetailsMethod(cdo, UpdateEventDetailsMethods.AddDataTransaction, (UpdateEventDetails_Parameters) null));
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
        return this.AddDataTransaction((UpdateEventDetails) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
