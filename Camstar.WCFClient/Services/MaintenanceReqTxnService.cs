// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MaintenanceReqTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MaintenanceReqTxnService : ShopFloorBase
  {
    public MaintenanceReqTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMaintenanceReqTxnService), userProfile);
    }

    public ResultStatus CreateParametricData(
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Parameters parameters,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      result = (MaintenanceReqTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) maintenanceReqTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqTxnService) this._Channel).CreateParametricData(this._UserProfile, maintenanceReqTxn, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqTxnMethod(maintenanceReqTxn, MaintenanceReqTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) maintenanceReqTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((MaintenanceReqTxn) null, (MaintenanceReqTxn_Parameters) null, (MaintenanceReqTxn_Request) null, out MaintenanceReqTxn_Result _);
    }

    public ResultStatus CreateParametricData(MaintenanceReqTxn maintenanceReqTxn)
    {
      return this.CreateParametricData(maintenanceReqTxn, (MaintenanceReqTxn_Parameters) null, (MaintenanceReqTxn_Request) null, out MaintenanceReqTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      return this.CreateParametricData(maintenanceReqTxn, (MaintenanceReqTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Parameters parameters,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      result = (MaintenanceReqTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) maintenanceReqTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqTxnService) this._Channel).GetActions(this._UserProfile, maintenanceReqTxn, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqTxnMethod(maintenanceReqTxn, MaintenanceReqTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) maintenanceReqTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((MaintenanceReqTxn) null, (MaintenanceReqTxn_Parameters) null, (MaintenanceReqTxn_Request) null, out MaintenanceReqTxn_Result _);
    }

    public ResultStatus GetActions(MaintenanceReqTxn maintenanceReqTxn)
    {
      return this.GetActions(maintenanceReqTxn, (MaintenanceReqTxn_Parameters) null, (MaintenanceReqTxn_Request) null, out MaintenanceReqTxn_Result _);
    }

    public ResultStatus GetActions(
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      return this.GetActions(maintenanceReqTxn, (MaintenanceReqTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Parameters parameters,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      result = (MaintenanceReqTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) maintenanceReqTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqTxnService) this._Channel).GetDataPoints(this._UserProfile, maintenanceReqTxn, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqTxnMethod(maintenanceReqTxn, MaintenanceReqTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) maintenanceReqTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((MaintenanceReqTxn) null, (MaintenanceReqTxn_Parameters) null, (MaintenanceReqTxn_Request) null, out MaintenanceReqTxn_Result _);
    }

    public ResultStatus GetDataPoints(MaintenanceReqTxn maintenanceReqTxn)
    {
      return this.GetDataPoints(maintenanceReqTxn, (MaintenanceReqTxn_Parameters) null, (MaintenanceReqTxn_Request) null, out MaintenanceReqTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      return this.GetDataPoints(maintenanceReqTxn, (MaintenanceReqTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Parameters parameters,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      result = (MaintenanceReqTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) maintenanceReqTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqTxnService) this._Channel).GetWIPMsgs(this._UserProfile, maintenanceReqTxn, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqTxnMethod(maintenanceReqTxn, MaintenanceReqTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) maintenanceReqTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MaintenanceReqTxn) null, (MaintenanceReqTxn_Parameters) null, (MaintenanceReqTxn_Request) null, out MaintenanceReqTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(MaintenanceReqTxn maintenanceReqTxn)
    {
      return this.GetWIPMsgs(maintenanceReqTxn, (MaintenanceReqTxn_Parameters) null, (MaintenanceReqTxn_Request) null, out MaintenanceReqTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      return this.GetWIPMsgs(maintenanceReqTxn, (MaintenanceReqTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Parameters parameters,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      result = (MaintenanceReqTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) maintenanceReqTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqTxnService) this._Channel).Load(this._UserProfile, maintenanceReqTxn, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqTxnMethod(maintenanceReqTxn, MaintenanceReqTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) maintenanceReqTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MaintenanceReqTxn) null, (MaintenanceReqTxn_Parameters) null, (MaintenanceReqTxn_Request) null, out MaintenanceReqTxn_Result _);
    }

    public ResultStatus Load(MaintenanceReqTxn maintenanceReqTxn)
    {
      return this.Load(maintenanceReqTxn, (MaintenanceReqTxn_Parameters) null, (MaintenanceReqTxn_Request) null, out MaintenanceReqTxn_Result _);
    }

    public ResultStatus Load(
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      return this.Load(maintenanceReqTxn, (MaintenanceReqTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_LoadESigDetails_Parameters parameters,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      result = (MaintenanceReqTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) maintenanceReqTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqTxnService) this._Channel).LoadESigDetails(this._UserProfile, maintenanceReqTxn, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqTxnMethod(maintenanceReqTxn, MaintenanceReqTxnMethods.LoadESigDetails, (MaintenanceReqTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) maintenanceReqTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MaintenanceReqTxn) null, (MaintenanceReqTxn_LoadESigDetails_Parameters) null, (MaintenanceReqTxn_Request) null, out MaintenanceReqTxn_Result _);
    }

    public ResultStatus LoadESigDetails(MaintenanceReqTxn maintenanceReqTxn)
    {
      return this.LoadESigDetails(maintenanceReqTxn, (MaintenanceReqTxn_LoadESigDetails_Parameters) null, (MaintenanceReqTxn_Request) null, out MaintenanceReqTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      return this.LoadESigDetails(maintenanceReqTxn, (MaintenanceReqTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Parameters parameters,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      result = (MaintenanceReqTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) maintenanceReqTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqTxnService) this._Channel).ProcessComputation(this._UserProfile, maintenanceReqTxn, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqTxnMethod(maintenanceReqTxn, MaintenanceReqTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) maintenanceReqTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((MaintenanceReqTxn) null, (MaintenanceReqTxn_Parameters) null, (MaintenanceReqTxn_Request) null, out MaintenanceReqTxn_Result _);
    }

    public ResultStatus ProcessComputation(MaintenanceReqTxn maintenanceReqTxn)
    {
      return this.ProcessComputation(maintenanceReqTxn, (MaintenanceReqTxn_Parameters) null, (MaintenanceReqTxn_Request) null, out MaintenanceReqTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      return this.ProcessComputation(maintenanceReqTxn, (MaintenanceReqTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Parameters parameters,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      result = (MaintenanceReqTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) maintenanceReqTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqTxnService) this._Channel).ResolveParametricData(this._UserProfile, maintenanceReqTxn, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqTxnMethod(maintenanceReqTxn, MaintenanceReqTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) maintenanceReqTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((MaintenanceReqTxn) null, (MaintenanceReqTxn_Parameters) null, (MaintenanceReqTxn_Request) null, out MaintenanceReqTxn_Result _);
    }

    public ResultStatus ResolveParametricData(MaintenanceReqTxn maintenanceReqTxn)
    {
      return this.ResolveParametricData(maintenanceReqTxn, (MaintenanceReqTxn_Parameters) null, (MaintenanceReqTxn_Request) null, out MaintenanceReqTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      return this.ResolveParametricData(maintenanceReqTxn, (MaintenanceReqTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject maintenanceReqTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((MaintenanceReqTxn) maintenanceReqTxn, (MaintenanceReqTxn_Parameters) parameters, (MaintenanceReqTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject maintenanceReqTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqTxn_Result result1;
        ResultStatus actions = this.GetActions((MaintenanceReqTxn) maintenanceReqTxn, (MaintenanceReqTxn_Parameters) parameters, (MaintenanceReqTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject maintenanceReqTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((MaintenanceReqTxn) maintenanceReqTxn, (MaintenanceReqTxn_Parameters) parameters, (MaintenanceReqTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject maintenanceReqTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MaintenanceReqTxn) maintenanceReqTxn, (MaintenanceReqTxn_LoadESigDetails_Parameters) parameters, (MaintenanceReqTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject maintenanceReqTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((MaintenanceReqTxn) maintenanceReqTxn, (MaintenanceReqTxn_Parameters) parameters, (MaintenanceReqTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject maintenanceReqTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((MaintenanceReqTxn) maintenanceReqTxn, (MaintenanceReqTxn_Parameters) parameters, (MaintenanceReqTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject maintenanceReqTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqTxn_Result result1;
        ResultStatus resultStatus = this.Load((MaintenanceReqTxn) maintenanceReqTxn, (MaintenanceReqTxn_Parameters) parameters, (MaintenanceReqTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject maintenanceReqTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MaintenanceReqTxn) maintenanceReqTxn, (MaintenanceReqTxn_Parameters) parameters, (MaintenanceReqTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      result = (MaintenanceReqTxn_Result) null;
      try
      {
        MaintenanceReqTxnMethod[] methods = new MaintenanceReqTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMaintenanceReqTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MaintenanceReqTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MaintenanceReqTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MaintenanceReqTxn cdo,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      result = (MaintenanceReqTxn_Result) null;
      try
      {
        return ((IMaintenanceReqTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MaintenanceReqTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((MaintenanceReqTxn) cdo, (MaintenanceReqTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      return this.GetEnvironment((MaintenanceReqTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MaintenanceReqTxn cdo,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      result = (MaintenanceReqTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MaintenanceReqTxnMethod(cdo, MaintenanceReqTxnMethods.ExecuteTransaction, (MaintenanceReqTxn_Parameters) null));
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
        MaintenanceReqTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MaintenanceReqTxn) cdo, (MaintenanceReqTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MaintenanceReqTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (MaintenanceReqTxn_Request) null, out MaintenanceReqTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result)
    {
      return this.ExecuteTransaction((MaintenanceReqTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MaintenanceReqTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MaintenanceReqTxnMethod(cdo, MaintenanceReqTxnMethods.AddDataTransaction, (MaintenanceReqTxn_Parameters) null));
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
        return this.AddDataTransaction((MaintenanceReqTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
