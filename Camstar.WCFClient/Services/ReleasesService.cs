// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ReleasesService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ReleasesService : HoldStatusTxnsBase
  {
    public ReleasesService(UserProfile userProfile)
    {
      this.Initialize(typeof (IReleasesService), userProfile);
    }

    public ResultStatus CreateParametricData(
      Releases releases,
      Releases_Parameters parameters,
      Releases_Request request,
      out Releases_Result result)
    {
      result = (Releases_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) releases, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleasesService) this._Channel).CreateParametricData(this._UserProfile, releases, parameters, request, out result) : this.AddMethod((Method) new ReleasesMethod(releases, ReleasesMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) releases, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Releases) null, (Releases_Parameters) null, (Releases_Request) null, out Releases_Result _);
    }

    public ResultStatus CreateParametricData(Releases releases)
    {
      return this.CreateParametricData(releases, (Releases_Parameters) null, (Releases_Request) null, out Releases_Result _);
    }

    public ResultStatus CreateParametricData(
      Releases releases,
      Releases_Request request,
      out Releases_Result result)
    {
      return this.CreateParametricData(releases, (Releases_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Releases releases,
      Releases_Parameters parameters,
      Releases_Request request,
      out Releases_Result result)
    {
      result = (Releases_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) releases, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleasesService) this._Channel).GetActions(this._UserProfile, releases, parameters, request, out result) : this.AddMethod((Method) new ReleasesMethod(releases, ReleasesMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) releases, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Releases) null, (Releases_Parameters) null, (Releases_Request) null, out Releases_Result _);
    }

    public ResultStatus GetActions(Releases releases)
    {
      return this.GetActions(releases, (Releases_Parameters) null, (Releases_Request) null, out Releases_Result _);
    }

    public ResultStatus GetActions(
      Releases releases,
      Releases_Request request,
      out Releases_Result result)
    {
      return this.GetActions(releases, (Releases_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Releases releases,
      Releases_Parameters parameters,
      Releases_Request request,
      out Releases_Result result)
    {
      result = (Releases_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) releases, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleasesService) this._Channel).GetDataPoints(this._UserProfile, releases, parameters, request, out result) : this.AddMethod((Method) new ReleasesMethod(releases, ReleasesMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) releases, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Releases) null, (Releases_Parameters) null, (Releases_Request) null, out Releases_Result _);
    }

    public ResultStatus GetDataPoints(Releases releases)
    {
      return this.GetDataPoints(releases, (Releases_Parameters) null, (Releases_Request) null, out Releases_Result _);
    }

    public ResultStatus GetDataPoints(
      Releases releases,
      Releases_Request request,
      out Releases_Result result)
    {
      return this.GetDataPoints(releases, (Releases_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Releases releases,
      Releases_Parameters parameters,
      Releases_Request request,
      out Releases_Result result)
    {
      result = (Releases_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) releases, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleasesService) this._Channel).GetWIPMsgs(this._UserProfile, releases, parameters, request, out result) : this.AddMethod((Method) new ReleasesMethod(releases, ReleasesMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) releases, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Releases) null, (Releases_Parameters) null, (Releases_Request) null, out Releases_Result _);
    }

    public ResultStatus GetWIPMsgs(Releases releases)
    {
      return this.GetWIPMsgs(releases, (Releases_Parameters) null, (Releases_Request) null, out Releases_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Releases releases,
      Releases_Request request,
      out Releases_Result result)
    {
      return this.GetWIPMsgs(releases, (Releases_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Releases releases,
      Releases_Parameters parameters,
      Releases_Request request,
      out Releases_Result result)
    {
      result = (Releases_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) releases, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleasesService) this._Channel).Load(this._UserProfile, releases, parameters, request, out result) : this.AddMethod((Method) new ReleasesMethod(releases, ReleasesMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) releases, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Releases) null, (Releases_Parameters) null, (Releases_Request) null, out Releases_Result _);
    }

    public ResultStatus Load(Releases releases)
    {
      return this.Load(releases, (Releases_Parameters) null, (Releases_Request) null, out Releases_Result _);
    }

    public ResultStatus Load(
      Releases releases,
      Releases_Request request,
      out Releases_Result result)
    {
      return this.Load(releases, (Releases_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Releases releases,
      Releases_LoadESigDetails_Parameters parameters,
      Releases_Request request,
      out Releases_Result result)
    {
      result = (Releases_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) releases, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleasesService) this._Channel).LoadESigDetails(this._UserProfile, releases, parameters, request, out result) : this.AddMethod((Method) new ReleasesMethod(releases, ReleasesMethods.LoadESigDetails, (Releases_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) releases, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Releases) null, (Releases_LoadESigDetails_Parameters) null, (Releases_Request) null, out Releases_Result _);
    }

    public ResultStatus LoadESigDetails(Releases releases)
    {
      return this.LoadESigDetails(releases, (Releases_LoadESigDetails_Parameters) null, (Releases_Request) null, out Releases_Result _);
    }

    public ResultStatus LoadESigDetails(
      Releases releases,
      Releases_Request request,
      out Releases_Result result)
    {
      return this.LoadESigDetails(releases, (Releases_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Releases releases,
      Releases_Parameters parameters,
      Releases_Request request,
      out Releases_Result result)
    {
      result = (Releases_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) releases, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleasesService) this._Channel).ProcessComputation(this._UserProfile, releases, parameters, request, out result) : this.AddMethod((Method) new ReleasesMethod(releases, ReleasesMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) releases, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Releases) null, (Releases_Parameters) null, (Releases_Request) null, out Releases_Result _);
    }

    public ResultStatus ProcessComputation(Releases releases)
    {
      return this.ProcessComputation(releases, (Releases_Parameters) null, (Releases_Request) null, out Releases_Result _);
    }

    public ResultStatus ProcessComputation(
      Releases releases,
      Releases_Request request,
      out Releases_Result result)
    {
      return this.ProcessComputation(releases, (Releases_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Releases releases,
      Releases_Parameters parameters,
      Releases_Request request,
      out Releases_Result result)
    {
      result = (Releases_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) releases, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleasesService) this._Channel).ResolveParametricData(this._UserProfile, releases, parameters, request, out result) : this.AddMethod((Method) new ReleasesMethod(releases, ReleasesMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) releases, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Releases) null, (Releases_Parameters) null, (Releases_Request) null, out Releases_Result _);
    }

    public ResultStatus ResolveParametricData(Releases releases)
    {
      return this.ResolveParametricData(releases, (Releases_Parameters) null, (Releases_Request) null, out Releases_Result _);
    }

    public ResultStatus ResolveParametricData(
      Releases releases,
      Releases_Request request,
      out Releases_Result result)
    {
      return this.ResolveParametricData(releases, (Releases_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject releases,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Releases_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Releases) releases, (Releases_Parameters) parameters, (Releases_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject releases,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Releases_Result result1;
        ResultStatus actions = this.GetActions((Releases) releases, (Releases_Parameters) parameters, (Releases_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject releases,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Releases_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Releases) releases, (Releases_Parameters) parameters, (Releases_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject releases,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Releases_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Releases) releases, (Releases_LoadESigDetails_Parameters) parameters, (Releases_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject releases,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Releases_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Releases) releases, (Releases_Parameters) parameters, (Releases_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject releases,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Releases_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Releases) releases, (Releases_Parameters) parameters, (Releases_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject releases,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Releases_Result result1;
        ResultStatus resultStatus = this.Load((Releases) releases, (Releases_Parameters) parameters, (Releases_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject releases,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Releases_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Releases) releases, (Releases_Parameters) parameters, (Releases_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Releases_Request request,
      out Releases_Result result)
    {
      result = (Releases_Result) null;
      try
      {
        ReleasesMethod[] methods = new ReleasesMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IReleasesService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Releases_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Releases_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Releases cdo,
      Releases_Request request,
      out Releases_Result result)
    {
      result = (Releases_Result) null;
      try
      {
        return ((IReleasesService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Releases_Result result1;
        ResultStatus environment = this.GetEnvironment((Releases) cdo, (Releases_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Releases_Request request,
      out Releases_Result result)
    {
      return this.GetEnvironment((Releases) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Releases cdo,
      Releases_Request request,
      out Releases_Result result)
    {
      result = (Releases_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleasesService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ReleasesMethod(cdo, ReleasesMethods.ExecuteTransaction, (Releases_Parameters) null));
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
        Releases_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Releases) cdo, (Releases_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Releases cdo)
    {
      return this.ExecuteTransaction(cdo, (Releases_Request) null, out Releases_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Releases_Request request,
      out Releases_Result result)
    {
      return this.ExecuteTransaction((Releases) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Releases cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ReleasesMethod(cdo, ReleasesMethods.AddDataTransaction, (Releases_Parameters) null));
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
        return this.AddDataTransaction((Releases) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
