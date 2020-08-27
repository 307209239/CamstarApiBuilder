// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.OpenCPStatusesService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class OpenCPStatusesService : ChangeStatusTxnsBase
  {
    public OpenCPStatusesService(UserProfile userProfile)
    {
      this.Initialize(typeof (IOpenCPStatusesService), userProfile);
    }

    public ResultStatus CreateParametricData(
      OpenCPStatuses openCPStatuses,
      OpenCPStatuses_Parameters parameters,
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      result = (OpenCPStatuses_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) openCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenCPStatusesService) this._Channel).CreateParametricData(this._UserProfile, openCPStatuses, parameters, request, out result) : this.AddMethod((Method) new OpenCPStatusesMethod(openCPStatuses, OpenCPStatusesMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) openCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((OpenCPStatuses) null, (OpenCPStatuses_Parameters) null, (OpenCPStatuses_Request) null, out OpenCPStatuses_Result _);
    }

    public ResultStatus CreateParametricData(OpenCPStatuses openCPStatuses)
    {
      return this.CreateParametricData(openCPStatuses, (OpenCPStatuses_Parameters) null, (OpenCPStatuses_Request) null, out OpenCPStatuses_Result _);
    }

    public ResultStatus CreateParametricData(
      OpenCPStatuses openCPStatuses,
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      return this.CreateParametricData(openCPStatuses, (OpenCPStatuses_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      OpenCPStatuses openCPStatuses,
      OpenCPStatuses_Parameters parameters,
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      result = (OpenCPStatuses_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) openCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenCPStatusesService) this._Channel).GetActions(this._UserProfile, openCPStatuses, parameters, request, out result) : this.AddMethod((Method) new OpenCPStatusesMethod(openCPStatuses, OpenCPStatusesMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) openCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((OpenCPStatuses) null, (OpenCPStatuses_Parameters) null, (OpenCPStatuses_Request) null, out OpenCPStatuses_Result _);
    }

    public ResultStatus GetActions(OpenCPStatuses openCPStatuses)
    {
      return this.GetActions(openCPStatuses, (OpenCPStatuses_Parameters) null, (OpenCPStatuses_Request) null, out OpenCPStatuses_Result _);
    }

    public ResultStatus GetActions(
      OpenCPStatuses openCPStatuses,
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      return this.GetActions(openCPStatuses, (OpenCPStatuses_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      OpenCPStatuses openCPStatuses,
      OpenCPStatuses_Parameters parameters,
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      result = (OpenCPStatuses_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) openCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenCPStatusesService) this._Channel).GetDataPoints(this._UserProfile, openCPStatuses, parameters, request, out result) : this.AddMethod((Method) new OpenCPStatusesMethod(openCPStatuses, OpenCPStatusesMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) openCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((OpenCPStatuses) null, (OpenCPStatuses_Parameters) null, (OpenCPStatuses_Request) null, out OpenCPStatuses_Result _);
    }

    public ResultStatus GetDataPoints(OpenCPStatuses openCPStatuses)
    {
      return this.GetDataPoints(openCPStatuses, (OpenCPStatuses_Parameters) null, (OpenCPStatuses_Request) null, out OpenCPStatuses_Result _);
    }

    public ResultStatus GetDataPoints(
      OpenCPStatuses openCPStatuses,
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      return this.GetDataPoints(openCPStatuses, (OpenCPStatuses_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      OpenCPStatuses openCPStatuses,
      OpenCPStatuses_Parameters parameters,
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      result = (OpenCPStatuses_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) openCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenCPStatusesService) this._Channel).GetWIPMsgs(this._UserProfile, openCPStatuses, parameters, request, out result) : this.AddMethod((Method) new OpenCPStatusesMethod(openCPStatuses, OpenCPStatusesMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) openCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((OpenCPStatuses) null, (OpenCPStatuses_Parameters) null, (OpenCPStatuses_Request) null, out OpenCPStatuses_Result _);
    }

    public ResultStatus GetWIPMsgs(OpenCPStatuses openCPStatuses)
    {
      return this.GetWIPMsgs(openCPStatuses, (OpenCPStatuses_Parameters) null, (OpenCPStatuses_Request) null, out OpenCPStatuses_Result _);
    }

    public ResultStatus GetWIPMsgs(
      OpenCPStatuses openCPStatuses,
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      return this.GetWIPMsgs(openCPStatuses, (OpenCPStatuses_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      OpenCPStatuses openCPStatuses,
      OpenCPStatuses_Parameters parameters,
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      result = (OpenCPStatuses_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) openCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenCPStatusesService) this._Channel).Load(this._UserProfile, openCPStatuses, parameters, request, out result) : this.AddMethod((Method) new OpenCPStatusesMethod(openCPStatuses, OpenCPStatusesMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) openCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((OpenCPStatuses) null, (OpenCPStatuses_Parameters) null, (OpenCPStatuses_Request) null, out OpenCPStatuses_Result _);
    }

    public ResultStatus Load(OpenCPStatuses openCPStatuses)
    {
      return this.Load(openCPStatuses, (OpenCPStatuses_Parameters) null, (OpenCPStatuses_Request) null, out OpenCPStatuses_Result _);
    }

    public ResultStatus Load(
      OpenCPStatuses openCPStatuses,
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      return this.Load(openCPStatuses, (OpenCPStatuses_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      OpenCPStatuses openCPStatuses,
      OpenCPStatuses_LoadESigDetails_Parameters parameters,
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      result = (OpenCPStatuses_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) openCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenCPStatusesService) this._Channel).LoadESigDetails(this._UserProfile, openCPStatuses, parameters, request, out result) : this.AddMethod((Method) new OpenCPStatusesMethod(openCPStatuses, OpenCPStatusesMethods.LoadESigDetails, (OpenCPStatuses_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) openCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((OpenCPStatuses) null, (OpenCPStatuses_LoadESigDetails_Parameters) null, (OpenCPStatuses_Request) null, out OpenCPStatuses_Result _);
    }

    public ResultStatus LoadESigDetails(OpenCPStatuses openCPStatuses)
    {
      return this.LoadESigDetails(openCPStatuses, (OpenCPStatuses_LoadESigDetails_Parameters) null, (OpenCPStatuses_Request) null, out OpenCPStatuses_Result _);
    }

    public ResultStatus LoadESigDetails(
      OpenCPStatuses openCPStatuses,
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      return this.LoadESigDetails(openCPStatuses, (OpenCPStatuses_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      OpenCPStatuses openCPStatuses,
      OpenCPStatuses_Parameters parameters,
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      result = (OpenCPStatuses_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) openCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenCPStatusesService) this._Channel).ProcessComputation(this._UserProfile, openCPStatuses, parameters, request, out result) : this.AddMethod((Method) new OpenCPStatusesMethod(openCPStatuses, OpenCPStatusesMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) openCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((OpenCPStatuses) null, (OpenCPStatuses_Parameters) null, (OpenCPStatuses_Request) null, out OpenCPStatuses_Result _);
    }

    public ResultStatus ProcessComputation(OpenCPStatuses openCPStatuses)
    {
      return this.ProcessComputation(openCPStatuses, (OpenCPStatuses_Parameters) null, (OpenCPStatuses_Request) null, out OpenCPStatuses_Result _);
    }

    public ResultStatus ProcessComputation(
      OpenCPStatuses openCPStatuses,
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      return this.ProcessComputation(openCPStatuses, (OpenCPStatuses_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      OpenCPStatuses openCPStatuses,
      OpenCPStatuses_Parameters parameters,
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      result = (OpenCPStatuses_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) openCPStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenCPStatusesService) this._Channel).ResolveParametricData(this._UserProfile, openCPStatuses, parameters, request, out result) : this.AddMethod((Method) new OpenCPStatusesMethod(openCPStatuses, OpenCPStatusesMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) openCPStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((OpenCPStatuses) null, (OpenCPStatuses_Parameters) null, (OpenCPStatuses_Request) null, out OpenCPStatuses_Result _);
    }

    public ResultStatus ResolveParametricData(OpenCPStatuses openCPStatuses)
    {
      return this.ResolveParametricData(openCPStatuses, (OpenCPStatuses_Parameters) null, (OpenCPStatuses_Request) null, out OpenCPStatuses_Result _);
    }

    public ResultStatus ResolveParametricData(
      OpenCPStatuses openCPStatuses,
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      return this.ResolveParametricData(openCPStatuses, (OpenCPStatuses_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject openCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenCPStatuses_Result result1;
        ResultStatus parametricData = this.CreateParametricData((OpenCPStatuses) openCPStatuses, (OpenCPStatuses_Parameters) parameters, (OpenCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject openCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenCPStatuses_Result result1;
        ResultStatus actions = this.GetActions((OpenCPStatuses) openCPStatuses, (OpenCPStatuses_Parameters) parameters, (OpenCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject openCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenCPStatuses_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((OpenCPStatuses) openCPStatuses, (OpenCPStatuses_Parameters) parameters, (OpenCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject openCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenCPStatuses_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((OpenCPStatuses) openCPStatuses, (OpenCPStatuses_LoadESigDetails_Parameters) parameters, (OpenCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject openCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenCPStatuses_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((OpenCPStatuses) openCPStatuses, (OpenCPStatuses_Parameters) parameters, (OpenCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject openCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenCPStatuses_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((OpenCPStatuses) openCPStatuses, (OpenCPStatuses_Parameters) parameters, (OpenCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject openCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenCPStatuses_Result result1;
        ResultStatus resultStatus = this.Load((OpenCPStatuses) openCPStatuses, (OpenCPStatuses_Parameters) parameters, (OpenCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject openCPStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenCPStatuses_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((OpenCPStatuses) openCPStatuses, (OpenCPStatuses_Parameters) parameters, (OpenCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      result = (OpenCPStatuses_Result) null;
      try
      {
        OpenCPStatusesMethod[] methods = new OpenCPStatusesMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IOpenCPStatusesService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        OpenCPStatuses_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((OpenCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OpenCPStatuses cdo,
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      result = (OpenCPStatuses_Result) null;
      try
      {
        return ((IOpenCPStatusesService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        OpenCPStatuses_Result result1;
        ResultStatus environment = this.GetEnvironment((OpenCPStatuses) cdo, (OpenCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      return this.GetEnvironment((OpenCPStatuses) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      OpenCPStatuses cdo,
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      result = (OpenCPStatuses_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenCPStatusesService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new OpenCPStatusesMethod(cdo, OpenCPStatusesMethods.ExecuteTransaction, (OpenCPStatuses_Parameters) null));
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
        OpenCPStatuses_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((OpenCPStatuses) cdo, (OpenCPStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(OpenCPStatuses cdo)
    {
      return this.ExecuteTransaction(cdo, (OpenCPStatuses_Request) null, out OpenCPStatuses_Result _);
    }

    public ResultStatus ExecuteTransaction(
      OpenCPStatuses_Request request,
      out OpenCPStatuses_Result result)
    {
      return this.ExecuteTransaction((OpenCPStatuses) null, request, out result);
    }

    public ResultStatus AddDataTransaction(OpenCPStatuses cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new OpenCPStatusesMethod(cdo, OpenCPStatusesMethods.AddDataTransaction, (OpenCPStatuses_Parameters) null));
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
        return this.AddDataTransaction((OpenCPStatuses) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
