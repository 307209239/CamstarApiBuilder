// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ActivateChangePkgService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ActivateChangePkgService : ChangeMgtTxnBase
  {
    public ActivateChangePkgService(UserProfile userProfile)
    {
      this.Initialize(typeof (IActivateChangePkgService), userProfile);
    }

    public ResultStatus CheckIfPreReqPkgsActivated(
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Parameters parameters,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      result = (ActivateChangePkg_Result) null;
      this.OnBeforeCall(nameof (CheckIfPreReqPkgsActivated), (DCObject) activateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivateChangePkgService) this._Channel).CheckIfPreReqPkgsActivated(this._UserProfile, activateChangePkg, parameters, request, out result) : this.AddMethod((Method) new ActivateChangePkgMethod(activateChangePkg, ActivateChangePkgMethods.CheckIfPreReqPkgsActivated, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CheckIfPreReqPkgsActivated), res, (DCObject) activateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CheckIfPreReqPkgsActivated()
    {
      return this.CheckIfPreReqPkgsActivated((ActivateChangePkg) null, (ActivateChangePkg_Parameters) null, (ActivateChangePkg_Request) null, out ActivateChangePkg_Result _);
    }

    public ResultStatus CheckIfPreReqPkgsActivated(ActivateChangePkg activateChangePkg)
    {
      return this.CheckIfPreReqPkgsActivated(activateChangePkg, (ActivateChangePkg_Parameters) null, (ActivateChangePkg_Request) null, out ActivateChangePkg_Result _);
    }

    public ResultStatus CheckIfPreReqPkgsActivated(
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      return this.CheckIfPreReqPkgsActivated(activateChangePkg, (ActivateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Parameters parameters,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      result = (ActivateChangePkg_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) activateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivateChangePkgService) this._Channel).CreateParametricData(this._UserProfile, activateChangePkg, parameters, request, out result) : this.AddMethod((Method) new ActivateChangePkgMethod(activateChangePkg, ActivateChangePkgMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) activateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ActivateChangePkg) null, (ActivateChangePkg_Parameters) null, (ActivateChangePkg_Request) null, out ActivateChangePkg_Result _);
    }

    public ResultStatus CreateParametricData(ActivateChangePkg activateChangePkg)
    {
      return this.CreateParametricData(activateChangePkg, (ActivateChangePkg_Parameters) null, (ActivateChangePkg_Request) null, out ActivateChangePkg_Result _);
    }

    public ResultStatus CreateParametricData(
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      return this.CreateParametricData(activateChangePkg, (ActivateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Parameters parameters,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      result = (ActivateChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) activateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivateChangePkgService) this._Channel).GetActions(this._UserProfile, activateChangePkg, parameters, request, out result) : this.AddMethod((Method) new ActivateChangePkgMethod(activateChangePkg, ActivateChangePkgMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) activateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ActivateChangePkg) null, (ActivateChangePkg_Parameters) null, (ActivateChangePkg_Request) null, out ActivateChangePkg_Result _);
    }

    public ResultStatus GetActions(ActivateChangePkg activateChangePkg)
    {
      return this.GetActions(activateChangePkg, (ActivateChangePkg_Parameters) null, (ActivateChangePkg_Request) null, out ActivateChangePkg_Result _);
    }

    public ResultStatus GetActions(
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      return this.GetActions(activateChangePkg, (ActivateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Parameters parameters,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      result = (ActivateChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) activateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivateChangePkgService) this._Channel).GetDataPoints(this._UserProfile, activateChangePkg, parameters, request, out result) : this.AddMethod((Method) new ActivateChangePkgMethod(activateChangePkg, ActivateChangePkgMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) activateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ActivateChangePkg) null, (ActivateChangePkg_Parameters) null, (ActivateChangePkg_Request) null, out ActivateChangePkg_Result _);
    }

    public ResultStatus GetDataPoints(ActivateChangePkg activateChangePkg)
    {
      return this.GetDataPoints(activateChangePkg, (ActivateChangePkg_Parameters) null, (ActivateChangePkg_Request) null, out ActivateChangePkg_Result _);
    }

    public ResultStatus GetDataPoints(
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      return this.GetDataPoints(activateChangePkg, (ActivateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Parameters parameters,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      result = (ActivateChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) activateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivateChangePkgService) this._Channel).GetWIPMsgs(this._UserProfile, activateChangePkg, parameters, request, out result) : this.AddMethod((Method) new ActivateChangePkgMethod(activateChangePkg, ActivateChangePkgMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) activateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ActivateChangePkg) null, (ActivateChangePkg_Parameters) null, (ActivateChangePkg_Request) null, out ActivateChangePkg_Result _);
    }

    public ResultStatus GetWIPMsgs(ActivateChangePkg activateChangePkg)
    {
      return this.GetWIPMsgs(activateChangePkg, (ActivateChangePkg_Parameters) null, (ActivateChangePkg_Request) null, out ActivateChangePkg_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      return this.GetWIPMsgs(activateChangePkg, (ActivateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Parameters parameters,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      result = (ActivateChangePkg_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) activateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivateChangePkgService) this._Channel).Load(this._UserProfile, activateChangePkg, parameters, request, out result) : this.AddMethod((Method) new ActivateChangePkgMethod(activateChangePkg, ActivateChangePkgMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) activateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ActivateChangePkg) null, (ActivateChangePkg_Parameters) null, (ActivateChangePkg_Request) null, out ActivateChangePkg_Result _);
    }

    public ResultStatus Load(ActivateChangePkg activateChangePkg)
    {
      return this.Load(activateChangePkg, (ActivateChangePkg_Parameters) null, (ActivateChangePkg_Request) null, out ActivateChangePkg_Result _);
    }

    public ResultStatus Load(
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      return this.Load(activateChangePkg, (ActivateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_LoadESigDetails_Parameters parameters,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      result = (ActivateChangePkg_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) activateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivateChangePkgService) this._Channel).LoadESigDetails(this._UserProfile, activateChangePkg, parameters, request, out result) : this.AddMethod((Method) new ActivateChangePkgMethod(activateChangePkg, ActivateChangePkgMethods.LoadESigDetails, (ActivateChangePkg_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) activateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ActivateChangePkg) null, (ActivateChangePkg_LoadESigDetails_Parameters) null, (ActivateChangePkg_Request) null, out ActivateChangePkg_Result _);
    }

    public ResultStatus LoadESigDetails(ActivateChangePkg activateChangePkg)
    {
      return this.LoadESigDetails(activateChangePkg, (ActivateChangePkg_LoadESigDetails_Parameters) null, (ActivateChangePkg_Request) null, out ActivateChangePkg_Result _);
    }

    public ResultStatus LoadESigDetails(
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      return this.LoadESigDetails(activateChangePkg, (ActivateChangePkg_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Parameters parameters,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      result = (ActivateChangePkg_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) activateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivateChangePkgService) this._Channel).ProcessComputation(this._UserProfile, activateChangePkg, parameters, request, out result) : this.AddMethod((Method) new ActivateChangePkgMethod(activateChangePkg, ActivateChangePkgMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) activateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ActivateChangePkg) null, (ActivateChangePkg_Parameters) null, (ActivateChangePkg_Request) null, out ActivateChangePkg_Result _);
    }

    public ResultStatus ProcessComputation(ActivateChangePkg activateChangePkg)
    {
      return this.ProcessComputation(activateChangePkg, (ActivateChangePkg_Parameters) null, (ActivateChangePkg_Request) null, out ActivateChangePkg_Result _);
    }

    public ResultStatus ProcessComputation(
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      return this.ProcessComputation(activateChangePkg, (ActivateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Parameters parameters,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      result = (ActivateChangePkg_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) activateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivateChangePkgService) this._Channel).ResolveParametricData(this._UserProfile, activateChangePkg, parameters, request, out result) : this.AddMethod((Method) new ActivateChangePkgMethod(activateChangePkg, ActivateChangePkgMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) activateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ActivateChangePkg) null, (ActivateChangePkg_Parameters) null, (ActivateChangePkg_Request) null, out ActivateChangePkg_Result _);
    }

    public ResultStatus ResolveParametricData(ActivateChangePkg activateChangePkg)
    {
      return this.ResolveParametricData(activateChangePkg, (ActivateChangePkg_Parameters) null, (ActivateChangePkg_Request) null, out ActivateChangePkg_Result _);
    }

    public ResultStatus ResolveParametricData(
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      return this.ResolveParametricData(activateChangePkg, (ActivateChangePkg_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject activateChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivateChangePkg_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ActivateChangePkg) activateChangePkg, (ActivateChangePkg_Parameters) parameters, (ActivateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject activateChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivateChangePkg_Result result1;
        ResultStatus actions = this.GetActions((ActivateChangePkg) activateChangePkg, (ActivateChangePkg_Parameters) parameters, (ActivateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject activateChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivateChangePkg_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ActivateChangePkg) activateChangePkg, (ActivateChangePkg_Parameters) parameters, (ActivateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject activateChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivateChangePkg_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ActivateChangePkg) activateChangePkg, (ActivateChangePkg_LoadESigDetails_Parameters) parameters, (ActivateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject activateChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivateChangePkg_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ActivateChangePkg) activateChangePkg, (ActivateChangePkg_Parameters) parameters, (ActivateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject activateChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivateChangePkg_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ActivateChangePkg) activateChangePkg, (ActivateChangePkg_Parameters) parameters, (ActivateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject activateChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivateChangePkg_Result result1;
        ResultStatus resultStatus = this.Load((ActivateChangePkg) activateChangePkg, (ActivateChangePkg_Parameters) parameters, (ActivateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject activateChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivateChangePkg_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ActivateChangePkg) activateChangePkg, (ActivateChangePkg_Parameters) parameters, (ActivateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      result = (ActivateChangePkg_Result) null;
      try
      {
        ActivateChangePkgMethod[] methods = new ActivateChangePkgMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IActivateChangePkgService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ActivateChangePkg_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ActivateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActivateChangePkg cdo,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      result = (ActivateChangePkg_Result) null;
      try
      {
        return ((IActivateChangePkgService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ActivateChangePkg_Result result1;
        ResultStatus environment = this.GetEnvironment((ActivateChangePkg) cdo, (ActivateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      return this.GetEnvironment((ActivateChangePkg) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ActivateChangePkg cdo,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      result = (ActivateChangePkg_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivateChangePkgService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ActivateChangePkgMethod(cdo, ActivateChangePkgMethods.ExecuteTransaction, (ActivateChangePkg_Parameters) null));
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
        ActivateChangePkg_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ActivateChangePkg) cdo, (ActivateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ActivateChangePkg cdo)
    {
      return this.ExecuteTransaction(cdo, (ActivateChangePkg_Request) null, out ActivateChangePkg_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result)
    {
      return this.ExecuteTransaction((ActivateChangePkg) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ActivateChangePkg cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ActivateChangePkgMethod(cdo, ActivateChangePkgMethods.AddDataTransaction, (ActivateChangePkg_Parameters) null));
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
        return this.AddDataTransaction((ActivateChangePkg) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
