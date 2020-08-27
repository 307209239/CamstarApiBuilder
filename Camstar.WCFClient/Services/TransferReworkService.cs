// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TransferReworkService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class TransferReworkService : ReworkBase
  {
    public TransferReworkService(UserProfile userProfile)
    {
      this.Initialize(typeof (ITransferReworkService), userProfile);
    }

    public ResultStatus CreateParametricData(
      TransferRework transferRework,
      TransferRework_Parameters parameters,
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      result = (TransferRework_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) transferRework, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITransferReworkService) this._Channel).CreateParametricData(this._UserProfile, transferRework, parameters, request, out result) : this.AddMethod((Method) new TransferReworkMethod(transferRework, TransferReworkMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) transferRework, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((TransferRework) null, (TransferRework_Parameters) null, (TransferRework_Request) null, out TransferRework_Result _);
    }

    public ResultStatus CreateParametricData(TransferRework transferRework)
    {
      return this.CreateParametricData(transferRework, (TransferRework_Parameters) null, (TransferRework_Request) null, out TransferRework_Result _);
    }

    public ResultStatus CreateParametricData(
      TransferRework transferRework,
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      return this.CreateParametricData(transferRework, (TransferRework_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      TransferRework transferRework,
      TransferRework_Parameters parameters,
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      result = (TransferRework_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) transferRework, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITransferReworkService) this._Channel).GetActions(this._UserProfile, transferRework, parameters, request, out result) : this.AddMethod((Method) new TransferReworkMethod(transferRework, TransferReworkMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) transferRework, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((TransferRework) null, (TransferRework_Parameters) null, (TransferRework_Request) null, out TransferRework_Result _);
    }

    public ResultStatus GetActions(TransferRework transferRework)
    {
      return this.GetActions(transferRework, (TransferRework_Parameters) null, (TransferRework_Request) null, out TransferRework_Result _);
    }

    public ResultStatus GetActions(
      TransferRework transferRework,
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      return this.GetActions(transferRework, (TransferRework_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      TransferRework transferRework,
      TransferRework_Parameters parameters,
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      result = (TransferRework_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) transferRework, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITransferReworkService) this._Channel).GetDataPoints(this._UserProfile, transferRework, parameters, request, out result) : this.AddMethod((Method) new TransferReworkMethod(transferRework, TransferReworkMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) transferRework, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((TransferRework) null, (TransferRework_Parameters) null, (TransferRework_Request) null, out TransferRework_Result _);
    }

    public ResultStatus GetDataPoints(TransferRework transferRework)
    {
      return this.GetDataPoints(transferRework, (TransferRework_Parameters) null, (TransferRework_Request) null, out TransferRework_Result _);
    }

    public ResultStatus GetDataPoints(
      TransferRework transferRework,
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      return this.GetDataPoints(transferRework, (TransferRework_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      TransferRework transferRework,
      TransferRework_Parameters parameters,
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      result = (TransferRework_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) transferRework, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITransferReworkService) this._Channel).GetWIPMsgs(this._UserProfile, transferRework, parameters, request, out result) : this.AddMethod((Method) new TransferReworkMethod(transferRework, TransferReworkMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) transferRework, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((TransferRework) null, (TransferRework_Parameters) null, (TransferRework_Request) null, out TransferRework_Result _);
    }

    public ResultStatus GetWIPMsgs(TransferRework transferRework)
    {
      return this.GetWIPMsgs(transferRework, (TransferRework_Parameters) null, (TransferRework_Request) null, out TransferRework_Result _);
    }

    public ResultStatus GetWIPMsgs(
      TransferRework transferRework,
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      return this.GetWIPMsgs(transferRework, (TransferRework_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      TransferRework transferRework,
      TransferRework_Parameters parameters,
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      result = (TransferRework_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) transferRework, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITransferReworkService) this._Channel).Load(this._UserProfile, transferRework, parameters, request, out result) : this.AddMethod((Method) new TransferReworkMethod(transferRework, TransferReworkMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) transferRework, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((TransferRework) null, (TransferRework_Parameters) null, (TransferRework_Request) null, out TransferRework_Result _);
    }

    public ResultStatus Load(TransferRework transferRework)
    {
      return this.Load(transferRework, (TransferRework_Parameters) null, (TransferRework_Request) null, out TransferRework_Result _);
    }

    public ResultStatus Load(
      TransferRework transferRework,
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      return this.Load(transferRework, (TransferRework_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      TransferRework transferRework,
      TransferRework_LoadESigDetails_Parameters parameters,
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      result = (TransferRework_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) transferRework, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITransferReworkService) this._Channel).LoadESigDetails(this._UserProfile, transferRework, parameters, request, out result) : this.AddMethod((Method) new TransferReworkMethod(transferRework, TransferReworkMethods.LoadESigDetails, (TransferRework_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) transferRework, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((TransferRework) null, (TransferRework_LoadESigDetails_Parameters) null, (TransferRework_Request) null, out TransferRework_Result _);
    }

    public ResultStatus LoadESigDetails(TransferRework transferRework)
    {
      return this.LoadESigDetails(transferRework, (TransferRework_LoadESigDetails_Parameters) null, (TransferRework_Request) null, out TransferRework_Result _);
    }

    public ResultStatus LoadESigDetails(
      TransferRework transferRework,
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      return this.LoadESigDetails(transferRework, (TransferRework_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      TransferRework transferRework,
      TransferRework_Parameters parameters,
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      result = (TransferRework_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) transferRework, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITransferReworkService) this._Channel).ProcessComputation(this._UserProfile, transferRework, parameters, request, out result) : this.AddMethod((Method) new TransferReworkMethod(transferRework, TransferReworkMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) transferRework, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((TransferRework) null, (TransferRework_Parameters) null, (TransferRework_Request) null, out TransferRework_Result _);
    }

    public ResultStatus ProcessComputation(TransferRework transferRework)
    {
      return this.ProcessComputation(transferRework, (TransferRework_Parameters) null, (TransferRework_Request) null, out TransferRework_Result _);
    }

    public ResultStatus ProcessComputation(
      TransferRework transferRework,
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      return this.ProcessComputation(transferRework, (TransferRework_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      TransferRework transferRework,
      TransferRework_Parameters parameters,
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      result = (TransferRework_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) transferRework, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITransferReworkService) this._Channel).ResolveParametricData(this._UserProfile, transferRework, parameters, request, out result) : this.AddMethod((Method) new TransferReworkMethod(transferRework, TransferReworkMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) transferRework, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((TransferRework) null, (TransferRework_Parameters) null, (TransferRework_Request) null, out TransferRework_Result _);
    }

    public ResultStatus ResolveParametricData(TransferRework transferRework)
    {
      return this.ResolveParametricData(transferRework, (TransferRework_Parameters) null, (TransferRework_Request) null, out TransferRework_Result _);
    }

    public ResultStatus ResolveParametricData(
      TransferRework transferRework,
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      return this.ResolveParametricData(transferRework, (TransferRework_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject transferRework,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TransferRework_Result result1;
        ResultStatus parametricData = this.CreateParametricData((TransferRework) transferRework, (TransferRework_Parameters) parameters, (TransferRework_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject transferRework,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TransferRework_Result result1;
        ResultStatus actions = this.GetActions((TransferRework) transferRework, (TransferRework_Parameters) parameters, (TransferRework_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject transferRework,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TransferRework_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((TransferRework) transferRework, (TransferRework_Parameters) parameters, (TransferRework_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject transferRework,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TransferRework_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((TransferRework) transferRework, (TransferRework_LoadESigDetails_Parameters) parameters, (TransferRework_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject transferRework,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TransferRework_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((TransferRework) transferRework, (TransferRework_Parameters) parameters, (TransferRework_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject transferRework,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TransferRework_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((TransferRework) transferRework, (TransferRework_Parameters) parameters, (TransferRework_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject transferRework,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TransferRework_Result result1;
        ResultStatus resultStatus = this.Load((TransferRework) transferRework, (TransferRework_Parameters) parameters, (TransferRework_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject transferRework,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TransferRework_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((TransferRework) transferRework, (TransferRework_Parameters) parameters, (TransferRework_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      result = (TransferRework_Result) null;
      try
      {
        TransferReworkMethod[] methods = new TransferReworkMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ITransferReworkService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        TransferRework_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((TransferRework_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TransferRework cdo,
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      result = (TransferRework_Result) null;
      try
      {
        return ((ITransferReworkService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        TransferRework_Result result1;
        ResultStatus environment = this.GetEnvironment((TransferRework) cdo, (TransferRework_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      return this.GetEnvironment((TransferRework) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      TransferRework cdo,
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      result = (TransferRework_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITransferReworkService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new TransferReworkMethod(cdo, TransferReworkMethods.ExecuteTransaction, (TransferRework_Parameters) null));
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
        TransferRework_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((TransferRework) cdo, (TransferRework_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(TransferRework cdo)
    {
      return this.ExecuteTransaction(cdo, (TransferRework_Request) null, out TransferRework_Result _);
    }

    public ResultStatus ExecuteTransaction(
      TransferRework_Request request,
      out TransferRework_Result result)
    {
      return this.ExecuteTransaction((TransferRework) null, request, out result);
    }

    public ResultStatus AddDataTransaction(TransferRework cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new TransferReworkMethod(cdo, TransferReworkMethods.AddDataTransaction, (TransferRework_Parameters) null));
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
        return this.AddDataTransaction((TransferRework) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
