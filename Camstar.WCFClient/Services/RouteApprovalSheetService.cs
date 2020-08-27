// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RouteApprovalSheetService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RouteApprovalSheetService : QualityTxnBase
  {
    public RouteApprovalSheetService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRouteApprovalSheetService), userProfile);
    }

    public ResultStatus CreateParametricData(
      RouteApprovalSheet routeApprovalSheet,
      RouteApprovalSheet_Parameters parameters,
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      result = (RouteApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) routeApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalSheetService) this._Channel).CreateParametricData(this._UserProfile, routeApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalSheetMethod(routeApprovalSheet, RouteApprovalSheetMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) routeApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((RouteApprovalSheet) null, (RouteApprovalSheet_Parameters) null, (RouteApprovalSheet_Request) null, out RouteApprovalSheet_Result _);
    }

    public ResultStatus CreateParametricData(RouteApprovalSheet routeApprovalSheet)
    {
      return this.CreateParametricData(routeApprovalSheet, (RouteApprovalSheet_Parameters) null, (RouteApprovalSheet_Request) null, out RouteApprovalSheet_Result _);
    }

    public ResultStatus CreateParametricData(
      RouteApprovalSheet routeApprovalSheet,
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      return this.CreateParametricData(routeApprovalSheet, (RouteApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      RouteApprovalSheet routeApprovalSheet,
      RouteApprovalSheet_Parameters parameters,
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      result = (RouteApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) routeApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalSheetService) this._Channel).GetActions(this._UserProfile, routeApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalSheetMethod(routeApprovalSheet, RouteApprovalSheetMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) routeApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((RouteApprovalSheet) null, (RouteApprovalSheet_Parameters) null, (RouteApprovalSheet_Request) null, out RouteApprovalSheet_Result _);
    }

    public ResultStatus GetActions(RouteApprovalSheet routeApprovalSheet)
    {
      return this.GetActions(routeApprovalSheet, (RouteApprovalSheet_Parameters) null, (RouteApprovalSheet_Request) null, out RouteApprovalSheet_Result _);
    }

    public ResultStatus GetActions(
      RouteApprovalSheet routeApprovalSheet,
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      return this.GetActions(routeApprovalSheet, (RouteApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      RouteApprovalSheet routeApprovalSheet,
      RouteApprovalSheet_Parameters parameters,
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      result = (RouteApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) routeApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalSheetService) this._Channel).GetDataPoints(this._UserProfile, routeApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalSheetMethod(routeApprovalSheet, RouteApprovalSheetMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) routeApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((RouteApprovalSheet) null, (RouteApprovalSheet_Parameters) null, (RouteApprovalSheet_Request) null, out RouteApprovalSheet_Result _);
    }

    public ResultStatus GetDataPoints(RouteApprovalSheet routeApprovalSheet)
    {
      return this.GetDataPoints(routeApprovalSheet, (RouteApprovalSheet_Parameters) null, (RouteApprovalSheet_Request) null, out RouteApprovalSheet_Result _);
    }

    public ResultStatus GetDataPoints(
      RouteApprovalSheet routeApprovalSheet,
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      return this.GetDataPoints(routeApprovalSheet, (RouteApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RouteApprovalSheet routeApprovalSheet,
      RouteApprovalSheet_Parameters parameters,
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      result = (RouteApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) routeApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalSheetService) this._Channel).GetWIPMsgs(this._UserProfile, routeApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalSheetMethod(routeApprovalSheet, RouteApprovalSheetMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) routeApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RouteApprovalSheet) null, (RouteApprovalSheet_Parameters) null, (RouteApprovalSheet_Request) null, out RouteApprovalSheet_Result _);
    }

    public ResultStatus GetWIPMsgs(RouteApprovalSheet routeApprovalSheet)
    {
      return this.GetWIPMsgs(routeApprovalSheet, (RouteApprovalSheet_Parameters) null, (RouteApprovalSheet_Request) null, out RouteApprovalSheet_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RouteApprovalSheet routeApprovalSheet,
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      return this.GetWIPMsgs(routeApprovalSheet, (RouteApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RouteApprovalSheet routeApprovalSheet,
      RouteApprovalSheet_Parameters parameters,
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      result = (RouteApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) routeApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalSheetService) this._Channel).Load(this._UserProfile, routeApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalSheetMethod(routeApprovalSheet, RouteApprovalSheetMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) routeApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RouteApprovalSheet) null, (RouteApprovalSheet_Parameters) null, (RouteApprovalSheet_Request) null, out RouteApprovalSheet_Result _);
    }

    public ResultStatus Load(RouteApprovalSheet routeApprovalSheet)
    {
      return this.Load(routeApprovalSheet, (RouteApprovalSheet_Parameters) null, (RouteApprovalSheet_Request) null, out RouteApprovalSheet_Result _);
    }

    public ResultStatus Load(
      RouteApprovalSheet routeApprovalSheet,
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      return this.Load(routeApprovalSheet, (RouteApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RouteApprovalSheet routeApprovalSheet,
      RouteApprovalSheet_Parameters parameters,
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      result = (RouteApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) routeApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalSheetService) this._Channel).LoadESigDetails(this._UserProfile, routeApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalSheetMethod(routeApprovalSheet, RouteApprovalSheetMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) routeApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RouteApprovalSheet) null, (RouteApprovalSheet_Parameters) null, (RouteApprovalSheet_Request) null, out RouteApprovalSheet_Result _);
    }

    public ResultStatus LoadESigDetails(RouteApprovalSheet routeApprovalSheet)
    {
      return this.LoadESigDetails(routeApprovalSheet, (RouteApprovalSheet_Parameters) null, (RouteApprovalSheet_Request) null, out RouteApprovalSheet_Result _);
    }

    public ResultStatus LoadESigDetails(
      RouteApprovalSheet routeApprovalSheet,
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      return this.LoadESigDetails(routeApprovalSheet, (RouteApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      RouteApprovalSheet routeApprovalSheet,
      RouteApprovalSheet_Parameters parameters,
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      result = (RouteApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) routeApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalSheetService) this._Channel).ProcessComputation(this._UserProfile, routeApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalSheetMethod(routeApprovalSheet, RouteApprovalSheetMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) routeApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((RouteApprovalSheet) null, (RouteApprovalSheet_Parameters) null, (RouteApprovalSheet_Request) null, out RouteApprovalSheet_Result _);
    }

    public ResultStatus ProcessComputation(RouteApprovalSheet routeApprovalSheet)
    {
      return this.ProcessComputation(routeApprovalSheet, (RouteApprovalSheet_Parameters) null, (RouteApprovalSheet_Request) null, out RouteApprovalSheet_Result _);
    }

    public ResultStatus ProcessComputation(
      RouteApprovalSheet routeApprovalSheet,
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      return this.ProcessComputation(routeApprovalSheet, (RouteApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      RouteApprovalSheet routeApprovalSheet,
      RouteApprovalSheet_Parameters parameters,
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      result = (RouteApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) routeApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalSheetService) this._Channel).ResolveParametricData(this._UserProfile, routeApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalSheetMethod(routeApprovalSheet, RouteApprovalSheetMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) routeApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((RouteApprovalSheet) null, (RouteApprovalSheet_Parameters) null, (RouteApprovalSheet_Request) null, out RouteApprovalSheet_Result _);
    }

    public ResultStatus ResolveParametricData(RouteApprovalSheet routeApprovalSheet)
    {
      return this.ResolveParametricData(routeApprovalSheet, (RouteApprovalSheet_Parameters) null, (RouteApprovalSheet_Request) null, out RouteApprovalSheet_Result _);
    }

    public ResultStatus ResolveParametricData(
      RouteApprovalSheet routeApprovalSheet,
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      return this.ResolveParametricData(routeApprovalSheet, (RouteApprovalSheet_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject routeApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteApprovalSheet_Result result1;
        ResultStatus parametricData = this.CreateParametricData((RouteApprovalSheet) routeApprovalSheet, (RouteApprovalSheet_Parameters) parameters, (RouteApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject routeApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteApprovalSheet_Result result1;
        ResultStatus actions = this.GetActions((RouteApprovalSheet) routeApprovalSheet, (RouteApprovalSheet_Parameters) parameters, (RouteApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject routeApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteApprovalSheet_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((RouteApprovalSheet) routeApprovalSheet, (RouteApprovalSheet_Parameters) parameters, (RouteApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject routeApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteApprovalSheet_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RouteApprovalSheet) routeApprovalSheet, (RouteApprovalSheet_Parameters) parameters, (RouteApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject routeApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteApprovalSheet_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((RouteApprovalSheet) routeApprovalSheet, (RouteApprovalSheet_Parameters) parameters, (RouteApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject routeApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteApprovalSheet_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((RouteApprovalSheet) routeApprovalSheet, (RouteApprovalSheet_Parameters) parameters, (RouteApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject routeApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteApprovalSheet_Result result1;
        ResultStatus resultStatus = this.Load((RouteApprovalSheet) routeApprovalSheet, (RouteApprovalSheet_Parameters) parameters, (RouteApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject routeApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteApprovalSheet_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RouteApprovalSheet) routeApprovalSheet, (RouteApprovalSheet_Parameters) parameters, (RouteApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      result = (RouteApprovalSheet_Result) null;
      try
      {
        RouteApprovalSheetMethod[] methods = new RouteApprovalSheetMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRouteApprovalSheetService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        RouteApprovalSheet_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RouteApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RouteApprovalSheet cdo,
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      result = (RouteApprovalSheet_Result) null;
      try
      {
        return ((IRouteApprovalSheetService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        RouteApprovalSheet_Result result1;
        ResultStatus environment = this.GetEnvironment((RouteApprovalSheet) cdo, (RouteApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      return this.GetEnvironment((RouteApprovalSheet) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RouteApprovalSheet cdo,
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      result = (RouteApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalSheetService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RouteApprovalSheetMethod(cdo, RouteApprovalSheetMethods.ExecuteTransaction, (RouteApprovalSheet_Parameters) null));
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
        RouteApprovalSheet_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RouteApprovalSheet) cdo, (RouteApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RouteApprovalSheet cdo)
    {
      return this.ExecuteTransaction(cdo, (RouteApprovalSheet_Request) null, out RouteApprovalSheet_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RouteApprovalSheet_Request request,
      out RouteApprovalSheet_Result result)
    {
      return this.ExecuteTransaction((RouteApprovalSheet) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RouteApprovalSheet cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RouteApprovalSheetMethod(cdo, RouteApprovalSheetMethods.AddDataTransaction, (RouteApprovalSheet_Parameters) null));
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
        return this.AddDataTransaction((RouteApprovalSheet) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
