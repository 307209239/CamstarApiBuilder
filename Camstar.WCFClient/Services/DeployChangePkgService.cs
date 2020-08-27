// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DeployChangePkgService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DeployChangePkgService : ChangeMgtTxnBase
  {
    public DeployChangePkgService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDeployChangePkgService), userProfile);
    }

    public ResultStatus CreateParametricData(
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Parameters parameters,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      result = (DeployChangePkg_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) deployChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDeployChangePkgService) this._Channel).CreateParametricData(this._UserProfile, deployChangePkg, parameters, request, out result) : this.AddMethod((Method) new DeployChangePkgMethod(deployChangePkg, DeployChangePkgMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) deployChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((DeployChangePkg) null, (DeployChangePkg_Parameters) null, (DeployChangePkg_Request) null, out DeployChangePkg_Result _);
    }

    public ResultStatus CreateParametricData(DeployChangePkg deployChangePkg)
    {
      return this.CreateParametricData(deployChangePkg, (DeployChangePkg_Parameters) null, (DeployChangePkg_Request) null, out DeployChangePkg_Result _);
    }

    public ResultStatus CreateParametricData(
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      return this.CreateParametricData(deployChangePkg, (DeployChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Parameters parameters,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      result = (DeployChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) deployChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDeployChangePkgService) this._Channel).GetActions(this._UserProfile, deployChangePkg, parameters, request, out result) : this.AddMethod((Method) new DeployChangePkgMethod(deployChangePkg, DeployChangePkgMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) deployChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((DeployChangePkg) null, (DeployChangePkg_Parameters) null, (DeployChangePkg_Request) null, out DeployChangePkg_Result _);
    }

    public ResultStatus GetActions(DeployChangePkg deployChangePkg)
    {
      return this.GetActions(deployChangePkg, (DeployChangePkg_Parameters) null, (DeployChangePkg_Request) null, out DeployChangePkg_Result _);
    }

    public ResultStatus GetActions(
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      return this.GetActions(deployChangePkg, (DeployChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Parameters parameters,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      result = (DeployChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) deployChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDeployChangePkgService) this._Channel).GetDataPoints(this._UserProfile, deployChangePkg, parameters, request, out result) : this.AddMethod((Method) new DeployChangePkgMethod(deployChangePkg, DeployChangePkgMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) deployChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((DeployChangePkg) null, (DeployChangePkg_Parameters) null, (DeployChangePkg_Request) null, out DeployChangePkg_Result _);
    }

    public ResultStatus GetDataPoints(DeployChangePkg deployChangePkg)
    {
      return this.GetDataPoints(deployChangePkg, (DeployChangePkg_Parameters) null, (DeployChangePkg_Request) null, out DeployChangePkg_Result _);
    }

    public ResultStatus GetDataPoints(
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      return this.GetDataPoints(deployChangePkg, (DeployChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Parameters parameters,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      result = (DeployChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) deployChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDeployChangePkgService) this._Channel).GetWIPMsgs(this._UserProfile, deployChangePkg, parameters, request, out result) : this.AddMethod((Method) new DeployChangePkgMethod(deployChangePkg, DeployChangePkgMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) deployChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DeployChangePkg) null, (DeployChangePkg_Parameters) null, (DeployChangePkg_Request) null, out DeployChangePkg_Result _);
    }

    public ResultStatus GetWIPMsgs(DeployChangePkg deployChangePkg)
    {
      return this.GetWIPMsgs(deployChangePkg, (DeployChangePkg_Parameters) null, (DeployChangePkg_Request) null, out DeployChangePkg_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      return this.GetWIPMsgs(deployChangePkg, (DeployChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Parameters parameters,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      result = (DeployChangePkg_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) deployChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDeployChangePkgService) this._Channel).Load(this._UserProfile, deployChangePkg, parameters, request, out result) : this.AddMethod((Method) new DeployChangePkgMethod(deployChangePkg, DeployChangePkgMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) deployChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DeployChangePkg) null, (DeployChangePkg_Parameters) null, (DeployChangePkg_Request) null, out DeployChangePkg_Result _);
    }

    public ResultStatus Load(DeployChangePkg deployChangePkg)
    {
      return this.Load(deployChangePkg, (DeployChangePkg_Parameters) null, (DeployChangePkg_Request) null, out DeployChangePkg_Result _);
    }

    public ResultStatus Load(
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      return this.Load(deployChangePkg, (DeployChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DeployChangePkg deployChangePkg,
      DeployChangePkg_LoadESigDetails_Parameters parameters,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      result = (DeployChangePkg_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) deployChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDeployChangePkgService) this._Channel).LoadESigDetails(this._UserProfile, deployChangePkg, parameters, request, out result) : this.AddMethod((Method) new DeployChangePkgMethod(deployChangePkg, DeployChangePkgMethods.LoadESigDetails, (DeployChangePkg_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) deployChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DeployChangePkg) null, (DeployChangePkg_LoadESigDetails_Parameters) null, (DeployChangePkg_Request) null, out DeployChangePkg_Result _);
    }

    public ResultStatus LoadESigDetails(DeployChangePkg deployChangePkg)
    {
      return this.LoadESigDetails(deployChangePkg, (DeployChangePkg_LoadESigDetails_Parameters) null, (DeployChangePkg_Request) null, out DeployChangePkg_Result _);
    }

    public ResultStatus LoadESigDetails(
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      return this.LoadESigDetails(deployChangePkg, (DeployChangePkg_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Parameters parameters,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      result = (DeployChangePkg_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) deployChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDeployChangePkgService) this._Channel).ProcessComputation(this._UserProfile, deployChangePkg, parameters, request, out result) : this.AddMethod((Method) new DeployChangePkgMethod(deployChangePkg, DeployChangePkgMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) deployChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((DeployChangePkg) null, (DeployChangePkg_Parameters) null, (DeployChangePkg_Request) null, out DeployChangePkg_Result _);
    }

    public ResultStatus ProcessComputation(DeployChangePkg deployChangePkg)
    {
      return this.ProcessComputation(deployChangePkg, (DeployChangePkg_Parameters) null, (DeployChangePkg_Request) null, out DeployChangePkg_Result _);
    }

    public ResultStatus ProcessComputation(
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      return this.ProcessComputation(deployChangePkg, (DeployChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Parameters parameters,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      result = (DeployChangePkg_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) deployChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDeployChangePkgService) this._Channel).ResolveParametricData(this._UserProfile, deployChangePkg, parameters, request, out result) : this.AddMethod((Method) new DeployChangePkgMethod(deployChangePkg, DeployChangePkgMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) deployChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((DeployChangePkg) null, (DeployChangePkg_Parameters) null, (DeployChangePkg_Request) null, out DeployChangePkg_Result _);
    }

    public ResultStatus ResolveParametricData(DeployChangePkg deployChangePkg)
    {
      return this.ResolveParametricData(deployChangePkg, (DeployChangePkg_Parameters) null, (DeployChangePkg_Request) null, out DeployChangePkg_Result _);
    }

    public ResultStatus ResolveParametricData(
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      return this.ResolveParametricData(deployChangePkg, (DeployChangePkg_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject deployChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DeployChangePkg_Result result1;
        ResultStatus parametricData = this.CreateParametricData((DeployChangePkg) deployChangePkg, (DeployChangePkg_Parameters) parameters, (DeployChangePkg_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject deployChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DeployChangePkg_Result result1;
        ResultStatus actions = this.GetActions((DeployChangePkg) deployChangePkg, (DeployChangePkg_Parameters) parameters, (DeployChangePkg_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject deployChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DeployChangePkg_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((DeployChangePkg) deployChangePkg, (DeployChangePkg_Parameters) parameters, (DeployChangePkg_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject deployChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DeployChangePkg_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DeployChangePkg) deployChangePkg, (DeployChangePkg_LoadESigDetails_Parameters) parameters, (DeployChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject deployChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DeployChangePkg_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((DeployChangePkg) deployChangePkg, (DeployChangePkg_Parameters) parameters, (DeployChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject deployChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DeployChangePkg_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((DeployChangePkg) deployChangePkg, (DeployChangePkg_Parameters) parameters, (DeployChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject deployChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DeployChangePkg_Result result1;
        ResultStatus resultStatus = this.Load((DeployChangePkg) deployChangePkg, (DeployChangePkg_Parameters) parameters, (DeployChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject deployChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DeployChangePkg_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DeployChangePkg) deployChangePkg, (DeployChangePkg_Parameters) parameters, (DeployChangePkg_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      result = (DeployChangePkg_Result) null;
      try
      {
        DeployChangePkgMethod[] methods = new DeployChangePkgMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDeployChangePkgService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DeployChangePkg_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DeployChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DeployChangePkg cdo,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      result = (DeployChangePkg_Result) null;
      try
      {
        return ((IDeployChangePkgService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DeployChangePkg_Result result1;
        ResultStatus environment = this.GetEnvironment((DeployChangePkg) cdo, (DeployChangePkg_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      return this.GetEnvironment((DeployChangePkg) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DeployChangePkg cdo,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      result = (DeployChangePkg_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDeployChangePkgService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DeployChangePkgMethod(cdo, DeployChangePkgMethods.ExecuteTransaction, (DeployChangePkg_Parameters) null));
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
        DeployChangePkg_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DeployChangePkg) cdo, (DeployChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DeployChangePkg cdo)
    {
      return this.ExecuteTransaction(cdo, (DeployChangePkg_Request) null, out DeployChangePkg_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result)
    {
      return this.ExecuteTransaction((DeployChangePkg) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DeployChangePkg cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DeployChangePkgMethod(cdo, DeployChangePkgMethods.AddDataTransaction, (DeployChangePkg_Parameters) null));
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
        return this.AddDataTransaction((DeployChangePkg) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
