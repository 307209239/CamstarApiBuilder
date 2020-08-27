// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RouteApprovalService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RouteApprovalService : ApprovalTxnBase
  {
    public RouteApprovalService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRouteApprovalService), userProfile);
    }

    public ResultStatus CreateApprover(
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      result = (RouteApproval_Result) null;
      this.OnBeforeCall(nameof (CreateApprover), (DCObject) routeApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalService) this._Channel).CreateApprover(this._UserProfile, routeApproval, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalMethod(routeApproval, RouteApprovalMethods.CreateApprover, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateApprover), res, (DCObject) routeApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateApprover()
    {
      return this.CreateApprover((RouteApproval) null, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus CreateApprover(RouteApproval routeApproval)
    {
      return this.CreateApprover(routeApproval, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus CreateApprover(
      RouteApproval routeApproval,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      return this.CreateApprover(routeApproval, (RouteApproval_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      result = (RouteApproval_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) routeApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalService) this._Channel).CreateParametricData(this._UserProfile, routeApproval, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalMethod(routeApproval, RouteApprovalMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) routeApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((RouteApproval) null, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus CreateParametricData(RouteApproval routeApproval)
    {
      return this.CreateParametricData(routeApproval, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus CreateParametricData(
      RouteApproval routeApproval,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      return this.CreateParametricData(routeApproval, (RouteApproval_Parameters) null, request, out result);
    }

    public ResultStatus CreateSheet(
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      result = (RouteApproval_Result) null;
      this.OnBeforeCall(nameof (CreateSheet), (DCObject) routeApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalService) this._Channel).CreateSheet(this._UserProfile, routeApproval, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalMethod(routeApproval, RouteApprovalMethods.CreateSheet, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateSheet), res, (DCObject) routeApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateSheet()
    {
      return this.CreateSheet((RouteApproval) null, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus CreateSheet(RouteApproval routeApproval)
    {
      return this.CreateSheet(routeApproval, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus CreateSheet(
      RouteApproval routeApproval,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      return this.CreateSheet(routeApproval, (RouteApproval_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      result = (RouteApproval_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) routeApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalService) this._Channel).GetActions(this._UserProfile, routeApproval, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalMethod(routeApproval, RouteApprovalMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) routeApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((RouteApproval) null, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus GetActions(RouteApproval routeApproval)
    {
      return this.GetActions(routeApproval, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus GetActions(
      RouteApproval routeApproval,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      return this.GetActions(routeApproval, (RouteApproval_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheet(
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      result = (RouteApproval_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheet), (DCObject) routeApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalService) this._Channel).GetApprovalSheet(this._UserProfile, routeApproval, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalMethod(routeApproval, RouteApprovalMethods.GetApprovalSheet, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheet), res, (DCObject) routeApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheet()
    {
      return this.GetApprovalSheet((RouteApproval) null, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus GetApprovalSheet(RouteApproval routeApproval)
    {
      return this.GetApprovalSheet(routeApproval, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus GetApprovalSheet(
      RouteApproval routeApproval,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      return this.GetApprovalSheet(routeApproval, (RouteApproval_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetDetails(
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      result = (RouteApproval_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetDetails), (DCObject) routeApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalService) this._Channel).GetApprovalSheetDetails(this._UserProfile, routeApproval, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalMethod(routeApproval, RouteApprovalMethods.GetApprovalSheetDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetDetails), res, (DCObject) routeApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetDetails()
    {
      return this.GetApprovalSheetDetails((RouteApproval) null, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus GetApprovalSheetDetails(RouteApproval routeApproval)
    {
      return this.GetApprovalSheetDetails(routeApproval, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus GetApprovalSheetDetails(
      RouteApproval routeApproval,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      return this.GetApprovalSheetDetails(routeApproval, (RouteApproval_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      result = (RouteApproval_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) routeApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, routeApproval, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalMethod(routeApproval, RouteApprovalMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) routeApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((RouteApproval) null, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(RouteApproval routeApproval)
    {
      return this.GetApprovalSheetTemplate(routeApproval, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      RouteApproval routeApproval,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      return this.GetApprovalSheetTemplate(routeApproval, (RouteApproval_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      result = (RouteApproval_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) routeApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalService) this._Channel).GetDataPoints(this._UserProfile, routeApproval, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalMethod(routeApproval, RouteApprovalMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) routeApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((RouteApproval) null, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus GetDataPoints(RouteApproval routeApproval)
    {
      return this.GetDataPoints(routeApproval, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus GetDataPoints(
      RouteApproval routeApproval,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      return this.GetDataPoints(routeApproval, (RouteApproval_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      result = (RouteApproval_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) routeApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalService) this._Channel).GetWIPMsgs(this._UserProfile, routeApproval, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalMethod(routeApproval, RouteApprovalMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) routeApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RouteApproval) null, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus GetWIPMsgs(RouteApproval routeApproval)
    {
      return this.GetWIPMsgs(routeApproval, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RouteApproval routeApproval,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      return this.GetWIPMsgs(routeApproval, (RouteApproval_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      result = (RouteApproval_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) routeApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalService) this._Channel).Load(this._UserProfile, routeApproval, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalMethod(routeApproval, RouteApprovalMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) routeApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RouteApproval) null, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus Load(RouteApproval routeApproval)
    {
      return this.Load(routeApproval, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus Load(
      RouteApproval routeApproval,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      return this.Load(routeApproval, (RouteApproval_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RouteApproval routeApproval,
      RouteApproval_LoadESigDetails_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      result = (RouteApproval_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) routeApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalService) this._Channel).LoadESigDetails(this._UserProfile, routeApproval, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalMethod(routeApproval, RouteApprovalMethods.LoadESigDetails, (RouteApproval_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) routeApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RouteApproval) null, (RouteApproval_LoadESigDetails_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus LoadESigDetails(RouteApproval routeApproval)
    {
      return this.LoadESigDetails(routeApproval, (RouteApproval_LoadESigDetails_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus LoadESigDetails(
      RouteApproval routeApproval,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      return this.LoadESigDetails(routeApproval, (RouteApproval_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      result = (RouteApproval_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) routeApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalService) this._Channel).ProcessComputation(this._UserProfile, routeApproval, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalMethod(routeApproval, RouteApprovalMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) routeApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((RouteApproval) null, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus ProcessComputation(RouteApproval routeApproval)
    {
      return this.ProcessComputation(routeApproval, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus ProcessComputation(
      RouteApproval routeApproval,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      return this.ProcessComputation(routeApproval, (RouteApproval_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      result = (RouteApproval_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) routeApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalService) this._Channel).ResolveParametricData(this._UserProfile, routeApproval, parameters, request, out result) : this.AddMethod((Method) new RouteApprovalMethod(routeApproval, RouteApprovalMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) routeApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((RouteApproval) null, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus ResolveParametricData(RouteApproval routeApproval)
    {
      return this.ResolveParametricData(routeApproval, (RouteApproval_Parameters) null, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus ResolveParametricData(
      RouteApproval routeApproval,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      return this.ResolveParametricData(routeApproval, (RouteApproval_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject routeApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteApproval_Result result1;
        ResultStatus parametricData = this.CreateParametricData((RouteApproval) routeApproval, (RouteApproval_Parameters) parameters, (RouteApproval_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject routeApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteApproval_Result result1;
        ResultStatus actions = this.GetActions((RouteApproval) routeApproval, (RouteApproval_Parameters) parameters, (RouteApproval_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject routeApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteApproval_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((RouteApproval) routeApproval, (RouteApproval_Parameters) parameters, (RouteApproval_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject routeApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteApproval_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RouteApproval) routeApproval, (RouteApproval_LoadESigDetails_Parameters) parameters, (RouteApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject routeApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteApproval_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((RouteApproval) routeApproval, (RouteApproval_Parameters) parameters, (RouteApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject routeApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteApproval_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((RouteApproval) routeApproval, (RouteApproval_Parameters) parameters, (RouteApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject routeApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteApproval_Result result1;
        ResultStatus resultStatus = this.Load((RouteApproval) routeApproval, (RouteApproval_Parameters) parameters, (RouteApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject routeApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RouteApproval_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RouteApproval) routeApproval, (RouteApproval_Parameters) parameters, (RouteApproval_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      result = (RouteApproval_Result) null;
      try
      {
        RouteApprovalMethod[] methods = new RouteApprovalMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRouteApprovalService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        RouteApproval_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RouteApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RouteApproval cdo,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      result = (RouteApproval_Result) null;
      try
      {
        return ((IRouteApprovalService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        RouteApproval_Result result1;
        ResultStatus environment = this.GetEnvironment((RouteApproval) cdo, (RouteApproval_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      return this.GetEnvironment((RouteApproval) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RouteApproval cdo,
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      result = (RouteApproval_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRouteApprovalService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RouteApprovalMethod(cdo, RouteApprovalMethods.ExecuteTransaction, (RouteApproval_Parameters) null));
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
        RouteApproval_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RouteApproval) cdo, (RouteApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RouteApproval cdo)
    {
      return this.ExecuteTransaction(cdo, (RouteApproval_Request) null, out RouteApproval_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RouteApproval_Request request,
      out RouteApproval_Result result)
    {
      return this.ExecuteTransaction((RouteApproval) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RouteApproval cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RouteApprovalMethod(cdo, RouteApprovalMethods.AddDataTransaction, (RouteApproval_Parameters) null));
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
        return this.AddDataTransaction((RouteApproval) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
