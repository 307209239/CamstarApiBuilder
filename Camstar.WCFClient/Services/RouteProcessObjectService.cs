// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RouteProcessObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RouteProcessObjectService : ProcessObjectTxnBase
  {
    public RouteProcessObjectService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRouteProcessObjectService), userProfile);
    }

    public ResultStatus CreateParametricData(
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Parameters parameters,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      result = (RouteProcessObject_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) routeProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteProcessObjectService) this._Channel).CreateParametricData(this._UserProfile, routeProcessObject, parameters, request, out result) : this.AddMethod((Method) new RouteProcessObjectMethod(routeProcessObject, RouteProcessObjectMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) routeProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((RouteProcessObject) null, (RouteProcessObject_Parameters) null, (RouteProcessObject_Request) null, out RouteProcessObject_Result _);
    }

    public ResultStatus CreateParametricData(RouteProcessObject routeProcessObject)
    {
      return this.CreateParametricData(routeProcessObject, (RouteProcessObject_Parameters) null, (RouteProcessObject_Request) null, out RouteProcessObject_Result _);
    }

    public ResultStatus CreateParametricData(
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      return this.CreateParametricData(routeProcessObject, (RouteProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Parameters parameters,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      result = (RouteProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) routeProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteProcessObjectService) this._Channel).GetActions(this._UserProfile, routeProcessObject, parameters, request, out result) : this.AddMethod((Method) new RouteProcessObjectMethod(routeProcessObject, RouteProcessObjectMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) routeProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((RouteProcessObject) null, (RouteProcessObject_Parameters) null, (RouteProcessObject_Request) null, out RouteProcessObject_Result _);
    }

    public ResultStatus GetActions(RouteProcessObject routeProcessObject)
    {
      return this.GetActions(routeProcessObject, (RouteProcessObject_Parameters) null, (RouteProcessObject_Request) null, out RouteProcessObject_Result _);
    }

    public ResultStatus GetActions(
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      return this.GetActions(routeProcessObject, (RouteProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Parameters parameters,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      result = (RouteProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) routeProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteProcessObjectService) this._Channel).GetDataPoints(this._UserProfile, routeProcessObject, parameters, request, out result) : this.AddMethod((Method) new RouteProcessObjectMethod(routeProcessObject, RouteProcessObjectMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) routeProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((RouteProcessObject) null, (RouteProcessObject_Parameters) null, (RouteProcessObject_Request) null, out RouteProcessObject_Result _);
    }

    public ResultStatus GetDataPoints(RouteProcessObject routeProcessObject)
    {
      return this.GetDataPoints(routeProcessObject, (RouteProcessObject_Parameters) null, (RouteProcessObject_Request) null, out RouteProcessObject_Result _);
    }

    public ResultStatus GetDataPoints(
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      return this.GetDataPoints(routeProcessObject, (RouteProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Parameters parameters,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      result = (RouteProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) routeProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteProcessObjectService) this._Channel).GetWIPMsgs(this._UserProfile, routeProcessObject, parameters, request, out result) : this.AddMethod((Method) new RouteProcessObjectMethod(routeProcessObject, RouteProcessObjectMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) routeProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RouteProcessObject) null, (RouteProcessObject_Parameters) null, (RouteProcessObject_Request) null, out RouteProcessObject_Result _);
    }

    public ResultStatus GetWIPMsgs(RouteProcessObject routeProcessObject)
    {
      return this.GetWIPMsgs(routeProcessObject, (RouteProcessObject_Parameters) null, (RouteProcessObject_Request) null, out RouteProcessObject_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      return this.GetWIPMsgs(routeProcessObject, (RouteProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Parameters parameters,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      result = (RouteProcessObject_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) routeProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteProcessObjectService) this._Channel).Load(this._UserProfile, routeProcessObject, parameters, request, out result) : this.AddMethod((Method) new RouteProcessObjectMethod(routeProcessObject, RouteProcessObjectMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) routeProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RouteProcessObject) null, (RouteProcessObject_Parameters) null, (RouteProcessObject_Request) null, out RouteProcessObject_Result _);
    }

    public ResultStatus Load(RouteProcessObject routeProcessObject)
    {
      return this.Load(routeProcessObject, (RouteProcessObject_Parameters) null, (RouteProcessObject_Request) null, out RouteProcessObject_Result _);
    }

    public ResultStatus Load(
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      return this.Load(routeProcessObject, (RouteProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Parameters parameters,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      result = (RouteProcessObject_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) routeProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteProcessObjectService) this._Channel).LoadESigDetails(this._UserProfile, routeProcessObject, parameters, request, out result) : this.AddMethod((Method) new RouteProcessObjectMethod(routeProcessObject, RouteProcessObjectMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) routeProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RouteProcessObject) null, (RouteProcessObject_Parameters) null, (RouteProcessObject_Request) null, out RouteProcessObject_Result _);
    }

    public ResultStatus LoadESigDetails(RouteProcessObject routeProcessObject)
    {
      return this.LoadESigDetails(routeProcessObject, (RouteProcessObject_Parameters) null, (RouteProcessObject_Request) null, out RouteProcessObject_Result _);
    }

    public ResultStatus LoadESigDetails(
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      return this.LoadESigDetails(routeProcessObject, (RouteProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Parameters parameters,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      result = (RouteProcessObject_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) routeProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteProcessObjectService) this._Channel).ProcessComputation(this._UserProfile, routeProcessObject, parameters, request, out result) : this.AddMethod((Method) new RouteProcessObjectMethod(routeProcessObject, RouteProcessObjectMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) routeProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((RouteProcessObject) null, (RouteProcessObject_Parameters) null, (RouteProcessObject_Request) null, out RouteProcessObject_Result _);
    }

    public ResultStatus ProcessComputation(RouteProcessObject routeProcessObject)
    {
      return this.ProcessComputation(routeProcessObject, (RouteProcessObject_Parameters) null, (RouteProcessObject_Request) null, out RouteProcessObject_Result _);
    }

    public ResultStatus ProcessComputation(
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      return this.ProcessComputation(routeProcessObject, (RouteProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Parameters parameters,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      result = (RouteProcessObject_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) routeProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteProcessObjectService) this._Channel).ResolveParametricData(this._UserProfile, routeProcessObject, parameters, request, out result) : this.AddMethod((Method) new RouteProcessObjectMethod(routeProcessObject, RouteProcessObjectMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) routeProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((RouteProcessObject) null, (RouteProcessObject_Parameters) null, (RouteProcessObject_Request) null, out RouteProcessObject_Result _);
    }

    public ResultStatus ResolveParametricData(RouteProcessObject routeProcessObject)
    {
      return this.ResolveParametricData(routeProcessObject, (RouteProcessObject_Parameters) null, (RouteProcessObject_Request) null, out RouteProcessObject_Result _);
    }

    public ResultStatus ResolveParametricData(
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      return this.ResolveParametricData(routeProcessObject, (RouteProcessObject_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject routeProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteProcessObject_Result result1;
        ResultStatus parametricData = this.CreateParametricData((RouteProcessObject) routeProcessObject, (RouteProcessObject_Parameters) parameters, (RouteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject routeProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteProcessObject_Result result1;
        ResultStatus actions = this.GetActions((RouteProcessObject) routeProcessObject, (RouteProcessObject_Parameters) parameters, (RouteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject routeProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteProcessObject_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((RouteProcessObject) routeProcessObject, (RouteProcessObject_Parameters) parameters, (RouteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject routeProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteProcessObject_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RouteProcessObject) routeProcessObject, (RouteProcessObject_Parameters) parameters, (RouteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject routeProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteProcessObject_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((RouteProcessObject) routeProcessObject, (RouteProcessObject_Parameters) parameters, (RouteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject routeProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteProcessObject_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((RouteProcessObject) routeProcessObject, (RouteProcessObject_Parameters) parameters, (RouteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject routeProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteProcessObject_Result result1;
        ResultStatus resultStatus = this.Load((RouteProcessObject) routeProcessObject, (RouteProcessObject_Parameters) parameters, (RouteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject routeProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteProcessObject_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RouteProcessObject) routeProcessObject, (RouteProcessObject_Parameters) parameters, (RouteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      result = (RouteProcessObject_Result) null;
      try
      {
        RouteProcessObjectMethod[] methods = new RouteProcessObjectMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRouteProcessObjectService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        RouteProcessObject_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RouteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RouteProcessObject cdo,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      result = (RouteProcessObject_Result) null;
      try
      {
        return ((IRouteProcessObjectService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        RouteProcessObject_Result result1;
        ResultStatus environment = this.GetEnvironment((RouteProcessObject) cdo, (RouteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      return this.GetEnvironment((RouteProcessObject) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RouteProcessObject cdo,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      result = (RouteProcessObject_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteProcessObjectService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RouteProcessObjectMethod(cdo, RouteProcessObjectMethods.ExecuteTransaction, (RouteProcessObject_Parameters) null));
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
        RouteProcessObject_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RouteProcessObject) cdo, (RouteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RouteProcessObject cdo)
    {
      return this.ExecuteTransaction(cdo, (RouteProcessObject_Request) null, out RouteProcessObject_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result)
    {
      return this.ExecuteTransaction((RouteProcessObject) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RouteProcessObject cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RouteProcessObjectMethod(cdo, RouteProcessObjectMethods.AddDataTransaction, (RouteProcessObject_Parameters) null));
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
        return this.AddDataTransaction((RouteProcessObject) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
