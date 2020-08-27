// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CompleteMaintenanceService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CompleteMaintenanceService : ResourceTxnBase
  {
    public CompleteMaintenanceService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICompleteMaintenanceService), userProfile);
    }

    public ResultStatus CreateParametricData(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      result = (CompleteMaintenance_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) completeMaintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteMaintenanceService) this._Channel).CreateParametricData(this._UserProfile, completeMaintenance, parameters, request, out result) : this.AddMethod((Method) new CompleteMaintenanceMethod(completeMaintenance, CompleteMaintenanceMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) completeMaintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CompleteMaintenance) null, (CompleteMaintenance_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus CreateParametricData(CompleteMaintenance completeMaintenance)
    {
      return this.CreateParametricData(completeMaintenance, (CompleteMaintenance_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus CreateParametricData(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      return this.CreateParametricData(completeMaintenance, (CompleteMaintenance_Parameters) null, request, out result);
    }

    public ResultStatus CreateServiceDetail(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_CreateServiceDetail_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      result = (CompleteMaintenance_Result) null;
      this.OnBeforeCall(nameof (CreateServiceDetail), (DCObject) completeMaintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteMaintenanceService) this._Channel).CreateServiceDetail(this._UserProfile, completeMaintenance, parameters, request, out result) : this.AddMethod((Method) new CompleteMaintenanceMethod(completeMaintenance, CompleteMaintenanceMethods.CreateServiceDetail, (CompleteMaintenance_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateServiceDetail), res, (DCObject) completeMaintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateServiceDetail()
    {
      return this.CreateServiceDetail((CompleteMaintenance) null, (CompleteMaintenance_CreateServiceDetail_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus CreateServiceDetail(CompleteMaintenance completeMaintenance)
    {
      return this.CreateServiceDetail(completeMaintenance, (CompleteMaintenance_CreateServiceDetail_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus CreateServiceDetail(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      return this.CreateServiceDetail(completeMaintenance, (CompleteMaintenance_CreateServiceDetail_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      result = (CompleteMaintenance_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) completeMaintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteMaintenanceService) this._Channel).GetActions(this._UserProfile, completeMaintenance, parameters, request, out result) : this.AddMethod((Method) new CompleteMaintenanceMethod(completeMaintenance, CompleteMaintenanceMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) completeMaintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CompleteMaintenance) null, (CompleteMaintenance_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus GetActions(CompleteMaintenance completeMaintenance)
    {
      return this.GetActions(completeMaintenance, (CompleteMaintenance_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus GetActions(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      return this.GetActions(completeMaintenance, (CompleteMaintenance_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      result = (CompleteMaintenance_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) completeMaintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteMaintenanceService) this._Channel).GetDataPoints(this._UserProfile, completeMaintenance, parameters, request, out result) : this.AddMethod((Method) new CompleteMaintenanceMethod(completeMaintenance, CompleteMaintenanceMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) completeMaintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CompleteMaintenance) null, (CompleteMaintenance_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus GetDataPoints(CompleteMaintenance completeMaintenance)
    {
      return this.GetDataPoints(completeMaintenance, (CompleteMaintenance_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus GetDataPoints(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      return this.GetDataPoints(completeMaintenance, (CompleteMaintenance_Parameters) null, request, out result);
    }

    public ResultStatus GetESigReqFromMaintReq(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_GetESigReqFromMaintReq_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      result = (CompleteMaintenance_Result) null;
      this.OnBeforeCall(nameof (GetESigReqFromMaintReq), (DCObject) completeMaintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteMaintenanceService) this._Channel).GetESigReqFromMaintReq(this._UserProfile, completeMaintenance, parameters, request, out result) : this.AddMethod((Method) new CompleteMaintenanceMethod(completeMaintenance, CompleteMaintenanceMethods.GetESigReqFromMaintReq, (CompleteMaintenance_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetESigReqFromMaintReq), res, (DCObject) completeMaintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetESigReqFromMaintReq()
    {
      return this.GetESigReqFromMaintReq((CompleteMaintenance) null, (CompleteMaintenance_GetESigReqFromMaintReq_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus GetESigReqFromMaintReq(CompleteMaintenance completeMaintenance)
    {
      return this.GetESigReqFromMaintReq(completeMaintenance, (CompleteMaintenance_GetESigReqFromMaintReq_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus GetESigReqFromMaintReq(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      return this.GetESigReqFromMaintReq(completeMaintenance, (CompleteMaintenance_GetESigReqFromMaintReq_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      result = (CompleteMaintenance_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) completeMaintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteMaintenanceService) this._Channel).GetWIPMsgs(this._UserProfile, completeMaintenance, parameters, request, out result) : this.AddMethod((Method) new CompleteMaintenanceMethod(completeMaintenance, CompleteMaintenanceMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) completeMaintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CompleteMaintenance) null, (CompleteMaintenance_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus GetWIPMsgs(CompleteMaintenance completeMaintenance)
    {
      return this.GetWIPMsgs(completeMaintenance, (CompleteMaintenance_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      return this.GetWIPMsgs(completeMaintenance, (CompleteMaintenance_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      result = (CompleteMaintenance_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) completeMaintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteMaintenanceService) this._Channel).Load(this._UserProfile, completeMaintenance, parameters, request, out result) : this.AddMethod((Method) new CompleteMaintenanceMethod(completeMaintenance, CompleteMaintenanceMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) completeMaintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CompleteMaintenance) null, (CompleteMaintenance_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus Load(CompleteMaintenance completeMaintenance)
    {
      return this.Load(completeMaintenance, (CompleteMaintenance_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus Load(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      return this.Load(completeMaintenance, (CompleteMaintenance_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_LoadESigDetails_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      result = (CompleteMaintenance_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) completeMaintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteMaintenanceService) this._Channel).LoadESigDetails(this._UserProfile, completeMaintenance, parameters, request, out result) : this.AddMethod((Method) new CompleteMaintenanceMethod(completeMaintenance, CompleteMaintenanceMethods.LoadESigDetails, (CompleteMaintenance_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) completeMaintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CompleteMaintenance) null, (CompleteMaintenance_LoadESigDetails_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus LoadESigDetails(CompleteMaintenance completeMaintenance)
    {
      return this.LoadESigDetails(completeMaintenance, (CompleteMaintenance_LoadESigDetails_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus LoadESigDetails(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      return this.LoadESigDetails(completeMaintenance, (CompleteMaintenance_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      result = (CompleteMaintenance_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) completeMaintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteMaintenanceService) this._Channel).ProcessComputation(this._UserProfile, completeMaintenance, parameters, request, out result) : this.AddMethod((Method) new CompleteMaintenanceMethod(completeMaintenance, CompleteMaintenanceMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) completeMaintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CompleteMaintenance) null, (CompleteMaintenance_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus ProcessComputation(CompleteMaintenance completeMaintenance)
    {
      return this.ProcessComputation(completeMaintenance, (CompleteMaintenance_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus ProcessComputation(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      return this.ProcessComputation(completeMaintenance, (CompleteMaintenance_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      result = (CompleteMaintenance_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) completeMaintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteMaintenanceService) this._Channel).ResolveParametricData(this._UserProfile, completeMaintenance, parameters, request, out result) : this.AddMethod((Method) new CompleteMaintenanceMethod(completeMaintenance, CompleteMaintenanceMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) completeMaintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CompleteMaintenance) null, (CompleteMaintenance_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus ResolveParametricData(CompleteMaintenance completeMaintenance)
    {
      return this.ResolveParametricData(completeMaintenance, (CompleteMaintenance_Parameters) null, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus ResolveParametricData(
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      return this.ResolveParametricData(completeMaintenance, (CompleteMaintenance_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject completeMaintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteMaintenance_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CompleteMaintenance) completeMaintenance, (CompleteMaintenance_Parameters) parameters, (CompleteMaintenance_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject completeMaintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteMaintenance_Result result1;
        ResultStatus actions = this.GetActions((CompleteMaintenance) completeMaintenance, (CompleteMaintenance_Parameters) parameters, (CompleteMaintenance_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject completeMaintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteMaintenance_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CompleteMaintenance) completeMaintenance, (CompleteMaintenance_Parameters) parameters, (CompleteMaintenance_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject completeMaintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteMaintenance_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CompleteMaintenance) completeMaintenance, (CompleteMaintenance_LoadESigDetails_Parameters) parameters, (CompleteMaintenance_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject completeMaintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteMaintenance_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CompleteMaintenance) completeMaintenance, (CompleteMaintenance_Parameters) parameters, (CompleteMaintenance_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject completeMaintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteMaintenance_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CompleteMaintenance) completeMaintenance, (CompleteMaintenance_Parameters) parameters, (CompleteMaintenance_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject completeMaintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteMaintenance_Result result1;
        ResultStatus resultStatus = this.Load((CompleteMaintenance) completeMaintenance, (CompleteMaintenance_Parameters) parameters, (CompleteMaintenance_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject completeMaintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteMaintenance_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CompleteMaintenance) completeMaintenance, (CompleteMaintenance_Parameters) parameters, (CompleteMaintenance_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      result = (CompleteMaintenance_Result) null;
      try
      {
        CompleteMaintenanceMethod[] methods = new CompleteMaintenanceMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICompleteMaintenanceService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CompleteMaintenance_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CompleteMaintenance_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CompleteMaintenance cdo,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      result = (CompleteMaintenance_Result) null;
      try
      {
        return ((ICompleteMaintenanceService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CompleteMaintenance_Result result1;
        ResultStatus environment = this.GetEnvironment((CompleteMaintenance) cdo, (CompleteMaintenance_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      return this.GetEnvironment((CompleteMaintenance) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CompleteMaintenance cdo,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      result = (CompleteMaintenance_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteMaintenanceService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CompleteMaintenanceMethod(cdo, CompleteMaintenanceMethods.ExecuteTransaction, (CompleteMaintenance_Parameters) null));
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
        CompleteMaintenance_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CompleteMaintenance) cdo, (CompleteMaintenance_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CompleteMaintenance cdo)
    {
      return this.ExecuteTransaction(cdo, (CompleteMaintenance_Request) null, out CompleteMaintenance_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result)
    {
      return this.ExecuteTransaction((CompleteMaintenance) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CompleteMaintenance cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CompleteMaintenanceMethod(cdo, CompleteMaintenanceMethods.AddDataTransaction, (CompleteMaintenance_Parameters) null));
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
        return this.AddDataTransaction((CompleteMaintenance) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
