// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ReorderProcessObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ReorderProcessObjectService : ProcessObjectTxnBase
  {
    public ReorderProcessObjectService(UserProfile userProfile)
    {
      this.Initialize(typeof (IReorderProcessObjectService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Parameters parameters,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      result = (ReorderProcessObject_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) reorderProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReorderProcessObjectService) this._Channel).CreateParametricData(this._UserProfile, reorderProcessObject, parameters, request, out result) : this.AddMethod((Method) new ReorderProcessObjectMethod(reorderProcessObject, ReorderProcessObjectMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) reorderProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ReorderProcessObject) null, (ReorderProcessObject_Parameters) null, (ReorderProcessObject_Request) null, out ReorderProcessObject_Result _);
    }

    public ResultStatus CreateParametricData(ReorderProcessObject reorderProcessObject)
    {
      return this.CreateParametricData(reorderProcessObject, (ReorderProcessObject_Parameters) null, (ReorderProcessObject_Request) null, out ReorderProcessObject_Result _);
    }

    public ResultStatus CreateParametricData(
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      return this.CreateParametricData(reorderProcessObject, (ReorderProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Parameters parameters,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      result = (ReorderProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) reorderProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReorderProcessObjectService) this._Channel).GetActions(this._UserProfile, reorderProcessObject, parameters, request, out result) : this.AddMethod((Method) new ReorderProcessObjectMethod(reorderProcessObject, ReorderProcessObjectMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) reorderProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ReorderProcessObject) null, (ReorderProcessObject_Parameters) null, (ReorderProcessObject_Request) null, out ReorderProcessObject_Result _);
    }

    public ResultStatus GetActions(ReorderProcessObject reorderProcessObject)
    {
      return this.GetActions(reorderProcessObject, (ReorderProcessObject_Parameters) null, (ReorderProcessObject_Request) null, out ReorderProcessObject_Result _);
    }

    public ResultStatus GetActions(
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      return this.GetActions(reorderProcessObject, (ReorderProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Parameters parameters,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      result = (ReorderProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) reorderProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReorderProcessObjectService) this._Channel).GetDataPoints(this._UserProfile, reorderProcessObject, parameters, request, out result) : this.AddMethod((Method) new ReorderProcessObjectMethod(reorderProcessObject, ReorderProcessObjectMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) reorderProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ReorderProcessObject) null, (ReorderProcessObject_Parameters) null, (ReorderProcessObject_Request) null, out ReorderProcessObject_Result _);
    }

    public ResultStatus GetDataPoints(ReorderProcessObject reorderProcessObject)
    {
      return this.GetDataPoints(reorderProcessObject, (ReorderProcessObject_Parameters) null, (ReorderProcessObject_Request) null, out ReorderProcessObject_Result _);
    }

    public ResultStatus GetDataPoints(
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      return this.GetDataPoints(reorderProcessObject, (ReorderProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Parameters parameters,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      result = (ReorderProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) reorderProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReorderProcessObjectService) this._Channel).GetWIPMsgs(this._UserProfile, reorderProcessObject, parameters, request, out result) : this.AddMethod((Method) new ReorderProcessObjectMethod(reorderProcessObject, ReorderProcessObjectMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) reorderProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ReorderProcessObject) null, (ReorderProcessObject_Parameters) null, (ReorderProcessObject_Request) null, out ReorderProcessObject_Result _);
    }

    public ResultStatus GetWIPMsgs(ReorderProcessObject reorderProcessObject)
    {
      return this.GetWIPMsgs(reorderProcessObject, (ReorderProcessObject_Parameters) null, (ReorderProcessObject_Request) null, out ReorderProcessObject_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      return this.GetWIPMsgs(reorderProcessObject, (ReorderProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Parameters parameters,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      result = (ReorderProcessObject_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) reorderProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReorderProcessObjectService) this._Channel).Load(this._UserProfile, reorderProcessObject, parameters, request, out result) : this.AddMethod((Method) new ReorderProcessObjectMethod(reorderProcessObject, ReorderProcessObjectMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) reorderProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ReorderProcessObject) null, (ReorderProcessObject_Parameters) null, (ReorderProcessObject_Request) null, out ReorderProcessObject_Result _);
    }

    public ResultStatus Load(ReorderProcessObject reorderProcessObject)
    {
      return this.Load(reorderProcessObject, (ReorderProcessObject_Parameters) null, (ReorderProcessObject_Request) null, out ReorderProcessObject_Result _);
    }

    public ResultStatus Load(
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      return this.Load(reorderProcessObject, (ReorderProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Parameters parameters,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      result = (ReorderProcessObject_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) reorderProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReorderProcessObjectService) this._Channel).LoadESigDetails(this._UserProfile, reorderProcessObject, parameters, request, out result) : this.AddMethod((Method) new ReorderProcessObjectMethod(reorderProcessObject, ReorderProcessObjectMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) reorderProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ReorderProcessObject) null, (ReorderProcessObject_Parameters) null, (ReorderProcessObject_Request) null, out ReorderProcessObject_Result _);
    }

    public ResultStatus LoadESigDetails(ReorderProcessObject reorderProcessObject)
    {
      return this.LoadESigDetails(reorderProcessObject, (ReorderProcessObject_Parameters) null, (ReorderProcessObject_Request) null, out ReorderProcessObject_Result _);
    }

    public ResultStatus LoadESigDetails(
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      return this.LoadESigDetails(reorderProcessObject, (ReorderProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Parameters parameters,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      result = (ReorderProcessObject_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) reorderProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReorderProcessObjectService) this._Channel).ProcessComputation(this._UserProfile, reorderProcessObject, parameters, request, out result) : this.AddMethod((Method) new ReorderProcessObjectMethod(reorderProcessObject, ReorderProcessObjectMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) reorderProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ReorderProcessObject) null, (ReorderProcessObject_Parameters) null, (ReorderProcessObject_Request) null, out ReorderProcessObject_Result _);
    }

    public ResultStatus ProcessComputation(ReorderProcessObject reorderProcessObject)
    {
      return this.ProcessComputation(reorderProcessObject, (ReorderProcessObject_Parameters) null, (ReorderProcessObject_Request) null, out ReorderProcessObject_Result _);
    }

    public ResultStatus ProcessComputation(
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      return this.ProcessComputation(reorderProcessObject, (ReorderProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Parameters parameters,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      result = (ReorderProcessObject_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) reorderProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReorderProcessObjectService) this._Channel).ResolveParametricData(this._UserProfile, reorderProcessObject, parameters, request, out result) : this.AddMethod((Method) new ReorderProcessObjectMethod(reorderProcessObject, ReorderProcessObjectMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) reorderProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ReorderProcessObject) null, (ReorderProcessObject_Parameters) null, (ReorderProcessObject_Request) null, out ReorderProcessObject_Result _);
    }

    public ResultStatus ResolveParametricData(ReorderProcessObject reorderProcessObject)
    {
      return this.ResolveParametricData(reorderProcessObject, (ReorderProcessObject_Parameters) null, (ReorderProcessObject_Request) null, out ReorderProcessObject_Result _);
    }

    public ResultStatus ResolveParametricData(
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      return this.ResolveParametricData(reorderProcessObject, (ReorderProcessObject_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject reorderProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReorderProcessObject_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ReorderProcessObject) reorderProcessObject, (ReorderProcessObject_Parameters) parameters, (ReorderProcessObject_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject reorderProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReorderProcessObject_Result result1;
        ResultStatus actions = this.GetActions((ReorderProcessObject) reorderProcessObject, (ReorderProcessObject_Parameters) parameters, (ReorderProcessObject_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject reorderProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReorderProcessObject_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ReorderProcessObject) reorderProcessObject, (ReorderProcessObject_Parameters) parameters, (ReorderProcessObject_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject reorderProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReorderProcessObject_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ReorderProcessObject) reorderProcessObject, (ReorderProcessObject_Parameters) parameters, (ReorderProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject reorderProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReorderProcessObject_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ReorderProcessObject) reorderProcessObject, (ReorderProcessObject_Parameters) parameters, (ReorderProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject reorderProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReorderProcessObject_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ReorderProcessObject) reorderProcessObject, (ReorderProcessObject_Parameters) parameters, (ReorderProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject reorderProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReorderProcessObject_Result result1;
        ResultStatus resultStatus = this.Load((ReorderProcessObject) reorderProcessObject, (ReorderProcessObject_Parameters) parameters, (ReorderProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject reorderProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReorderProcessObject_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ReorderProcessObject) reorderProcessObject, (ReorderProcessObject_Parameters) parameters, (ReorderProcessObject_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      result = (ReorderProcessObject_Result) null;
      try
      {
        ReorderProcessObjectMethod[] methods = new ReorderProcessObjectMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IReorderProcessObjectService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ReorderProcessObject_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ReorderProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReorderProcessObject cdo,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      result = (ReorderProcessObject_Result) null;
      try
      {
        return ((IReorderProcessObjectService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ReorderProcessObject_Result result1;
        ResultStatus environment = this.GetEnvironment((ReorderProcessObject) cdo, (ReorderProcessObject_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      return this.GetEnvironment((ReorderProcessObject) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ReorderProcessObject cdo,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      result = (ReorderProcessObject_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReorderProcessObjectService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ReorderProcessObjectMethod(cdo, ReorderProcessObjectMethods.ExecuteTransaction, (ReorderProcessObject_Parameters) null));
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
        ReorderProcessObject_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ReorderProcessObject) cdo, (ReorderProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ReorderProcessObject cdo)
    {
      return this.ExecuteTransaction(cdo, (ReorderProcessObject_Request) null, out ReorderProcessObject_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result)
    {
      return this.ExecuteTransaction((ReorderProcessObject) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ReorderProcessObject cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ReorderProcessObjectMethod(cdo, ReorderProcessObjectMethods.AddDataTransaction, (ReorderProcessObject_Parameters) null));
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
        return this.AddDataTransaction((ReorderProcessObject) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
