// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AutoHoldService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class AutoHoldService : HoldBase
  {
    public AutoHoldService(UserProfile userProfile)
    {
      this.Initialize(typeof (IAutoHoldService), userProfile);
    }

    public ResultStatus ContainerTxn_Validations(
      AutoHold autoHold,
      AutoHold_Parameters parameters,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      result = (AutoHold_Result) null;
      this.OnBeforeCall(nameof (ContainerTxn_Validations), (DCObject) autoHold, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAutoHoldService) this._Channel).ContainerTxn_Validations(this._UserProfile, autoHold, parameters, request, out result) : this.AddMethod((Method) new AutoHoldMethod(autoHold, AutoHoldMethods.ContainerTxn_Validations, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ContainerTxn_Validations), res, (DCObject) autoHold, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ContainerTxn_Validations()
    {
      return this.ContainerTxn_Validations((AutoHold) null, (AutoHold_Parameters) null, (AutoHold_Request) null, out AutoHold_Result _);
    }

    public ResultStatus ContainerTxn_Validations(AutoHold autoHold)
    {
      return this.ContainerTxn_Validations(autoHold, (AutoHold_Parameters) null, (AutoHold_Request) null, out AutoHold_Result _);
    }

    public ResultStatus ContainerTxn_Validations(
      AutoHold autoHold,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      return this.ContainerTxn_Validations(autoHold, (AutoHold_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      AutoHold autoHold,
      AutoHold_Parameters parameters,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      result = (AutoHold_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) autoHold, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAutoHoldService) this._Channel).CreateParametricData(this._UserProfile, autoHold, parameters, request, out result) : this.AddMethod((Method) new AutoHoldMethod(autoHold, AutoHoldMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) autoHold, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((AutoHold) null, (AutoHold_Parameters) null, (AutoHold_Request) null, out AutoHold_Result _);
    }

    public ResultStatus CreateParametricData(AutoHold autoHold)
    {
      return this.CreateParametricData(autoHold, (AutoHold_Parameters) null, (AutoHold_Request) null, out AutoHold_Result _);
    }

    public ResultStatus CreateParametricData(
      AutoHold autoHold,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      return this.CreateParametricData(autoHold, (AutoHold_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      AutoHold autoHold,
      AutoHold_Parameters parameters,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      result = (AutoHold_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) autoHold, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAutoHoldService) this._Channel).GetActions(this._UserProfile, autoHold, parameters, request, out result) : this.AddMethod((Method) new AutoHoldMethod(autoHold, AutoHoldMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) autoHold, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((AutoHold) null, (AutoHold_Parameters) null, (AutoHold_Request) null, out AutoHold_Result _);
    }

    public ResultStatus GetActions(AutoHold autoHold)
    {
      return this.GetActions(autoHold, (AutoHold_Parameters) null, (AutoHold_Request) null, out AutoHold_Result _);
    }

    public ResultStatus GetActions(
      AutoHold autoHold,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      return this.GetActions(autoHold, (AutoHold_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      AutoHold autoHold,
      AutoHold_Parameters parameters,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      result = (AutoHold_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) autoHold, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAutoHoldService) this._Channel).GetDataPoints(this._UserProfile, autoHold, parameters, request, out result) : this.AddMethod((Method) new AutoHoldMethod(autoHold, AutoHoldMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) autoHold, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((AutoHold) null, (AutoHold_Parameters) null, (AutoHold_Request) null, out AutoHold_Result _);
    }

    public ResultStatus GetDataPoints(AutoHold autoHold)
    {
      return this.GetDataPoints(autoHold, (AutoHold_Parameters) null, (AutoHold_Request) null, out AutoHold_Result _);
    }

    public ResultStatus GetDataPoints(
      AutoHold autoHold,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      return this.GetDataPoints(autoHold, (AutoHold_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      AutoHold autoHold,
      AutoHold_Parameters parameters,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      result = (AutoHold_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) autoHold, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAutoHoldService) this._Channel).GetWIPMsgs(this._UserProfile, autoHold, parameters, request, out result) : this.AddMethod((Method) new AutoHoldMethod(autoHold, AutoHoldMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) autoHold, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((AutoHold) null, (AutoHold_Parameters) null, (AutoHold_Request) null, out AutoHold_Result _);
    }

    public ResultStatus GetWIPMsgs(AutoHold autoHold)
    {
      return this.GetWIPMsgs(autoHold, (AutoHold_Parameters) null, (AutoHold_Request) null, out AutoHold_Result _);
    }

    public ResultStatus GetWIPMsgs(
      AutoHold autoHold,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      return this.GetWIPMsgs(autoHold, (AutoHold_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      AutoHold autoHold,
      AutoHold_Parameters parameters,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      result = (AutoHold_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) autoHold, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAutoHoldService) this._Channel).Load(this._UserProfile, autoHold, parameters, request, out result) : this.AddMethod((Method) new AutoHoldMethod(autoHold, AutoHoldMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) autoHold, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((AutoHold) null, (AutoHold_Parameters) null, (AutoHold_Request) null, out AutoHold_Result _);
    }

    public ResultStatus Load(AutoHold autoHold)
    {
      return this.Load(autoHold, (AutoHold_Parameters) null, (AutoHold_Request) null, out AutoHold_Result _);
    }

    public ResultStatus Load(
      AutoHold autoHold,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      return this.Load(autoHold, (AutoHold_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      AutoHold autoHold,
      AutoHold_LoadESigDetails_Parameters parameters,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      result = (AutoHold_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) autoHold, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAutoHoldService) this._Channel).LoadESigDetails(this._UserProfile, autoHold, parameters, request, out result) : this.AddMethod((Method) new AutoHoldMethod(autoHold, AutoHoldMethods.LoadESigDetails, (AutoHold_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) autoHold, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((AutoHold) null, (AutoHold_LoadESigDetails_Parameters) null, (AutoHold_Request) null, out AutoHold_Result _);
    }

    public ResultStatus LoadESigDetails(AutoHold autoHold)
    {
      return this.LoadESigDetails(autoHold, (AutoHold_LoadESigDetails_Parameters) null, (AutoHold_Request) null, out AutoHold_Result _);
    }

    public ResultStatus LoadESigDetails(
      AutoHold autoHold,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      return this.LoadESigDetails(autoHold, (AutoHold_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      AutoHold autoHold,
      AutoHold_Parameters parameters,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      result = (AutoHold_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) autoHold, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAutoHoldService) this._Channel).ProcessComputation(this._UserProfile, autoHold, parameters, request, out result) : this.AddMethod((Method) new AutoHoldMethod(autoHold, AutoHoldMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) autoHold, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((AutoHold) null, (AutoHold_Parameters) null, (AutoHold_Request) null, out AutoHold_Result _);
    }

    public ResultStatus ProcessComputation(AutoHold autoHold)
    {
      return this.ProcessComputation(autoHold, (AutoHold_Parameters) null, (AutoHold_Request) null, out AutoHold_Result _);
    }

    public ResultStatus ProcessComputation(
      AutoHold autoHold,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      return this.ProcessComputation(autoHold, (AutoHold_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      AutoHold autoHold,
      AutoHold_Parameters parameters,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      result = (AutoHold_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) autoHold, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAutoHoldService) this._Channel).ResolveParametricData(this._UserProfile, autoHold, parameters, request, out result) : this.AddMethod((Method) new AutoHoldMethod(autoHold, AutoHoldMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) autoHold, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((AutoHold) null, (AutoHold_Parameters) null, (AutoHold_Request) null, out AutoHold_Result _);
    }

    public ResultStatus ResolveParametricData(AutoHold autoHold)
    {
      return this.ResolveParametricData(autoHold, (AutoHold_Parameters) null, (AutoHold_Request) null, out AutoHold_Result _);
    }

    public ResultStatus ResolveParametricData(
      AutoHold autoHold,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      return this.ResolveParametricData(autoHold, (AutoHold_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject autoHold,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AutoHold_Result result1;
        ResultStatus parametricData = this.CreateParametricData((AutoHold) autoHold, (AutoHold_Parameters) parameters, (AutoHold_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject autoHold,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AutoHold_Result result1;
        ResultStatus actions = this.GetActions((AutoHold) autoHold, (AutoHold_Parameters) parameters, (AutoHold_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject autoHold,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AutoHold_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((AutoHold) autoHold, (AutoHold_Parameters) parameters, (AutoHold_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject autoHold,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AutoHold_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((AutoHold) autoHold, (AutoHold_LoadESigDetails_Parameters) parameters, (AutoHold_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject autoHold,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AutoHold_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((AutoHold) autoHold, (AutoHold_Parameters) parameters, (AutoHold_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject autoHold,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AutoHold_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((AutoHold) autoHold, (AutoHold_Parameters) parameters, (AutoHold_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject autoHold,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AutoHold_Result result1;
        ResultStatus resultStatus = this.Load((AutoHold) autoHold, (AutoHold_Parameters) parameters, (AutoHold_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject autoHold,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AutoHold_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((AutoHold) autoHold, (AutoHold_Parameters) parameters, (AutoHold_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      result = (AutoHold_Result) null;
      try
      {
        AutoHoldMethod[] methods = new AutoHoldMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IAutoHoldService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        AutoHold_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((AutoHold_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AutoHold cdo,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      result = (AutoHold_Result) null;
      try
      {
        return ((IAutoHoldService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        AutoHold_Result result1;
        ResultStatus environment = this.GetEnvironment((AutoHold) cdo, (AutoHold_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      return this.GetEnvironment((AutoHold) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      AutoHold cdo,
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      result = (AutoHold_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAutoHoldService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new AutoHoldMethod(cdo, AutoHoldMethods.ExecuteTransaction, (AutoHold_Parameters) null));
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
        AutoHold_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((AutoHold) cdo, (AutoHold_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(AutoHold cdo)
    {
      return this.ExecuteTransaction(cdo, (AutoHold_Request) null, out AutoHold_Result _);
    }

    public ResultStatus ExecuteTransaction(
      AutoHold_Request request,
      out AutoHold_Result result)
    {
      return this.ExecuteTransaction((AutoHold) null, request, out result);
    }

    public ResultStatus AddDataTransaction(AutoHold cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new AutoHoldMethod(cdo, AutoHoldMethods.AddDataTransaction, (AutoHold_Parameters) null));
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
        return this.AddDataTransaction((AutoHold) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
