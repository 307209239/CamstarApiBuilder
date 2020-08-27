// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MaintClassActivationService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MaintClassActivationService : MaintenanceReqTxnBase
  {
    public MaintClassActivationService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMaintClassActivationService), userProfile);
    }

    public ResultStatus CreateParametricData(
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Parameters parameters,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      result = (MaintClassActivation_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) maintClassActivation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintClassActivationService) this._Channel).CreateParametricData(this._UserProfile, maintClassActivation, parameters, request, out result) : this.AddMethod((Method) new MaintClassActivationMethod(maintClassActivation, MaintClassActivationMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) maintClassActivation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((MaintClassActivation) null, (MaintClassActivation_Parameters) null, (MaintClassActivation_Request) null, out MaintClassActivation_Result _);
    }

    public ResultStatus CreateParametricData(MaintClassActivation maintClassActivation)
    {
      return this.CreateParametricData(maintClassActivation, (MaintClassActivation_Parameters) null, (MaintClassActivation_Request) null, out MaintClassActivation_Result _);
    }

    public ResultStatus CreateParametricData(
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      return this.CreateParametricData(maintClassActivation, (MaintClassActivation_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Parameters parameters,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      result = (MaintClassActivation_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) maintClassActivation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintClassActivationService) this._Channel).GetActions(this._UserProfile, maintClassActivation, parameters, request, out result) : this.AddMethod((Method) new MaintClassActivationMethod(maintClassActivation, MaintClassActivationMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) maintClassActivation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((MaintClassActivation) null, (MaintClassActivation_Parameters) null, (MaintClassActivation_Request) null, out MaintClassActivation_Result _);
    }

    public ResultStatus GetActions(MaintClassActivation maintClassActivation)
    {
      return this.GetActions(maintClassActivation, (MaintClassActivation_Parameters) null, (MaintClassActivation_Request) null, out MaintClassActivation_Result _);
    }

    public ResultStatus GetActions(
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      return this.GetActions(maintClassActivation, (MaintClassActivation_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Parameters parameters,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      result = (MaintClassActivation_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) maintClassActivation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintClassActivationService) this._Channel).GetDataPoints(this._UserProfile, maintClassActivation, parameters, request, out result) : this.AddMethod((Method) new MaintClassActivationMethod(maintClassActivation, MaintClassActivationMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) maintClassActivation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((MaintClassActivation) null, (MaintClassActivation_Parameters) null, (MaintClassActivation_Request) null, out MaintClassActivation_Result _);
    }

    public ResultStatus GetDataPoints(MaintClassActivation maintClassActivation)
    {
      return this.GetDataPoints(maintClassActivation, (MaintClassActivation_Parameters) null, (MaintClassActivation_Request) null, out MaintClassActivation_Result _);
    }

    public ResultStatus GetDataPoints(
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      return this.GetDataPoints(maintClassActivation, (MaintClassActivation_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Parameters parameters,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      result = (MaintClassActivation_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) maintClassActivation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintClassActivationService) this._Channel).GetWIPMsgs(this._UserProfile, maintClassActivation, parameters, request, out result) : this.AddMethod((Method) new MaintClassActivationMethod(maintClassActivation, MaintClassActivationMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) maintClassActivation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MaintClassActivation) null, (MaintClassActivation_Parameters) null, (MaintClassActivation_Request) null, out MaintClassActivation_Result _);
    }

    public ResultStatus GetWIPMsgs(MaintClassActivation maintClassActivation)
    {
      return this.GetWIPMsgs(maintClassActivation, (MaintClassActivation_Parameters) null, (MaintClassActivation_Request) null, out MaintClassActivation_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      return this.GetWIPMsgs(maintClassActivation, (MaintClassActivation_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Parameters parameters,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      result = (MaintClassActivation_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) maintClassActivation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintClassActivationService) this._Channel).Load(this._UserProfile, maintClassActivation, parameters, request, out result) : this.AddMethod((Method) new MaintClassActivationMethod(maintClassActivation, MaintClassActivationMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) maintClassActivation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MaintClassActivation) null, (MaintClassActivation_Parameters) null, (MaintClassActivation_Request) null, out MaintClassActivation_Result _);
    }

    public ResultStatus Load(MaintClassActivation maintClassActivation)
    {
      return this.Load(maintClassActivation, (MaintClassActivation_Parameters) null, (MaintClassActivation_Request) null, out MaintClassActivation_Result _);
    }

    public ResultStatus Load(
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      return this.Load(maintClassActivation, (MaintClassActivation_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MaintClassActivation maintClassActivation,
      MaintClassActivation_LoadESigDetails_Parameters parameters,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      result = (MaintClassActivation_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) maintClassActivation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintClassActivationService) this._Channel).LoadESigDetails(this._UserProfile, maintClassActivation, parameters, request, out result) : this.AddMethod((Method) new MaintClassActivationMethod(maintClassActivation, MaintClassActivationMethods.LoadESigDetails, (MaintClassActivation_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) maintClassActivation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MaintClassActivation) null, (MaintClassActivation_LoadESigDetails_Parameters) null, (MaintClassActivation_Request) null, out MaintClassActivation_Result _);
    }

    public ResultStatus LoadESigDetails(MaintClassActivation maintClassActivation)
    {
      return this.LoadESigDetails(maintClassActivation, (MaintClassActivation_LoadESigDetails_Parameters) null, (MaintClassActivation_Request) null, out MaintClassActivation_Result _);
    }

    public ResultStatus LoadESigDetails(
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      return this.LoadESigDetails(maintClassActivation, (MaintClassActivation_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Parameters parameters,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      result = (MaintClassActivation_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) maintClassActivation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintClassActivationService) this._Channel).ProcessComputation(this._UserProfile, maintClassActivation, parameters, request, out result) : this.AddMethod((Method) new MaintClassActivationMethod(maintClassActivation, MaintClassActivationMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) maintClassActivation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((MaintClassActivation) null, (MaintClassActivation_Parameters) null, (MaintClassActivation_Request) null, out MaintClassActivation_Result _);
    }

    public ResultStatus ProcessComputation(MaintClassActivation maintClassActivation)
    {
      return this.ProcessComputation(maintClassActivation, (MaintClassActivation_Parameters) null, (MaintClassActivation_Request) null, out MaintClassActivation_Result _);
    }

    public ResultStatus ProcessComputation(
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      return this.ProcessComputation(maintClassActivation, (MaintClassActivation_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Parameters parameters,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      result = (MaintClassActivation_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) maintClassActivation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintClassActivationService) this._Channel).ResolveParametricData(this._UserProfile, maintClassActivation, parameters, request, out result) : this.AddMethod((Method) new MaintClassActivationMethod(maintClassActivation, MaintClassActivationMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) maintClassActivation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((MaintClassActivation) null, (MaintClassActivation_Parameters) null, (MaintClassActivation_Request) null, out MaintClassActivation_Result _);
    }

    public ResultStatus ResolveParametricData(MaintClassActivation maintClassActivation)
    {
      return this.ResolveParametricData(maintClassActivation, (MaintClassActivation_Parameters) null, (MaintClassActivation_Request) null, out MaintClassActivation_Result _);
    }

    public ResultStatus ResolveParametricData(
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      return this.ResolveParametricData(maintClassActivation, (MaintClassActivation_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject maintClassActivation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintClassActivation_Result result1;
        ResultStatus parametricData = this.CreateParametricData((MaintClassActivation) maintClassActivation, (MaintClassActivation_Parameters) parameters, (MaintClassActivation_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject maintClassActivation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintClassActivation_Result result1;
        ResultStatus actions = this.GetActions((MaintClassActivation) maintClassActivation, (MaintClassActivation_Parameters) parameters, (MaintClassActivation_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject maintClassActivation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintClassActivation_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((MaintClassActivation) maintClassActivation, (MaintClassActivation_Parameters) parameters, (MaintClassActivation_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject maintClassActivation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintClassActivation_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MaintClassActivation) maintClassActivation, (MaintClassActivation_LoadESigDetails_Parameters) parameters, (MaintClassActivation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject maintClassActivation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintClassActivation_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((MaintClassActivation) maintClassActivation, (MaintClassActivation_Parameters) parameters, (MaintClassActivation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject maintClassActivation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintClassActivation_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((MaintClassActivation) maintClassActivation, (MaintClassActivation_Parameters) parameters, (MaintClassActivation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject maintClassActivation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintClassActivation_Result result1;
        ResultStatus resultStatus = this.Load((MaintClassActivation) maintClassActivation, (MaintClassActivation_Parameters) parameters, (MaintClassActivation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject maintClassActivation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintClassActivation_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MaintClassActivation) maintClassActivation, (MaintClassActivation_Parameters) parameters, (MaintClassActivation_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      result = (MaintClassActivation_Result) null;
      try
      {
        MaintClassActivationMethod[] methods = new MaintClassActivationMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMaintClassActivationService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MaintClassActivation_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MaintClassActivation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MaintClassActivation cdo,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      result = (MaintClassActivation_Result) null;
      try
      {
        return ((IMaintClassActivationService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MaintClassActivation_Result result1;
        ResultStatus environment = this.GetEnvironment((MaintClassActivation) cdo, (MaintClassActivation_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      return this.GetEnvironment((MaintClassActivation) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MaintClassActivation cdo,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      result = (MaintClassActivation_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintClassActivationService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MaintClassActivationMethod(cdo, MaintClassActivationMethods.ExecuteTransaction, (MaintClassActivation_Parameters) null));
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
        MaintClassActivation_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MaintClassActivation) cdo, (MaintClassActivation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MaintClassActivation cdo)
    {
      return this.ExecuteTransaction(cdo, (MaintClassActivation_Request) null, out MaintClassActivation_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result)
    {
      return this.ExecuteTransaction((MaintClassActivation) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MaintClassActivation cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MaintClassActivationMethod(cdo, MaintClassActivationMethods.AddDataTransaction, (MaintClassActivation_Parameters) null));
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
        return this.AddDataTransaction((MaintClassActivation) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
