// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangeOwnerService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ChangeOwnerService : QualityTxnBase
  {
    public ChangeOwnerService(UserProfile userProfile)
    {
      this.Initialize(typeof (IChangeOwnerService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ChangeOwner changeOwner,
      ChangeOwner_Parameters parameters,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      result = (ChangeOwner_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) changeOwner, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeOwnerService) this._Channel).CreateParametricData(this._UserProfile, changeOwner, parameters, request, out result) : this.AddMethod((Method) new ChangeOwnerMethod(changeOwner, ChangeOwnerMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) changeOwner, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ChangeOwner) null, (ChangeOwner_Parameters) null, (ChangeOwner_Request) null, out ChangeOwner_Result _);
    }

    public ResultStatus CreateParametricData(ChangeOwner changeOwner)
    {
      return this.CreateParametricData(changeOwner, (ChangeOwner_Parameters) null, (ChangeOwner_Request) null, out ChangeOwner_Result _);
    }

    public ResultStatus CreateParametricData(
      ChangeOwner changeOwner,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      return this.CreateParametricData(changeOwner, (ChangeOwner_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ChangeOwner changeOwner,
      ChangeOwner_Parameters parameters,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      result = (ChangeOwner_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) changeOwner, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeOwnerService) this._Channel).GetActions(this._UserProfile, changeOwner, parameters, request, out result) : this.AddMethod((Method) new ChangeOwnerMethod(changeOwner, ChangeOwnerMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) changeOwner, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ChangeOwner) null, (ChangeOwner_Parameters) null, (ChangeOwner_Request) null, out ChangeOwner_Result _);
    }

    public ResultStatus GetActions(ChangeOwner changeOwner)
    {
      return this.GetActions(changeOwner, (ChangeOwner_Parameters) null, (ChangeOwner_Request) null, out ChangeOwner_Result _);
    }

    public ResultStatus GetActions(
      ChangeOwner changeOwner,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      return this.GetActions(changeOwner, (ChangeOwner_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ChangeOwner changeOwner,
      ChangeOwner_Parameters parameters,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      result = (ChangeOwner_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) changeOwner, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeOwnerService) this._Channel).GetDataPoints(this._UserProfile, changeOwner, parameters, request, out result) : this.AddMethod((Method) new ChangeOwnerMethod(changeOwner, ChangeOwnerMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) changeOwner, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ChangeOwner) null, (ChangeOwner_Parameters) null, (ChangeOwner_Request) null, out ChangeOwner_Result _);
    }

    public ResultStatus GetDataPoints(ChangeOwner changeOwner)
    {
      return this.GetDataPoints(changeOwner, (ChangeOwner_Parameters) null, (ChangeOwner_Request) null, out ChangeOwner_Result _);
    }

    public ResultStatus GetDataPoints(
      ChangeOwner changeOwner,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      return this.GetDataPoints(changeOwner, (ChangeOwner_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ChangeOwner changeOwner,
      ChangeOwner_Parameters parameters,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      result = (ChangeOwner_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) changeOwner, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeOwnerService) this._Channel).GetWIPMsgs(this._UserProfile, changeOwner, parameters, request, out result) : this.AddMethod((Method) new ChangeOwnerMethod(changeOwner, ChangeOwnerMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) changeOwner, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ChangeOwner) null, (ChangeOwner_Parameters) null, (ChangeOwner_Request) null, out ChangeOwner_Result _);
    }

    public ResultStatus GetWIPMsgs(ChangeOwner changeOwner)
    {
      return this.GetWIPMsgs(changeOwner, (ChangeOwner_Parameters) null, (ChangeOwner_Request) null, out ChangeOwner_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChangeOwner changeOwner,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      return this.GetWIPMsgs(changeOwner, (ChangeOwner_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ChangeOwner changeOwner,
      ChangeOwner_Parameters parameters,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      result = (ChangeOwner_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) changeOwner, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeOwnerService) this._Channel).Load(this._UserProfile, changeOwner, parameters, request, out result) : this.AddMethod((Method) new ChangeOwnerMethod(changeOwner, ChangeOwnerMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) changeOwner, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ChangeOwner) null, (ChangeOwner_Parameters) null, (ChangeOwner_Request) null, out ChangeOwner_Result _);
    }

    public ResultStatus Load(ChangeOwner changeOwner)
    {
      return this.Load(changeOwner, (ChangeOwner_Parameters) null, (ChangeOwner_Request) null, out ChangeOwner_Result _);
    }

    public ResultStatus Load(
      ChangeOwner changeOwner,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      return this.Load(changeOwner, (ChangeOwner_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ChangeOwner changeOwner,
      ChangeOwner_Parameters parameters,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      result = (ChangeOwner_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) changeOwner, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeOwnerService) this._Channel).LoadESigDetails(this._UserProfile, changeOwner, parameters, request, out result) : this.AddMethod((Method) new ChangeOwnerMethod(changeOwner, ChangeOwnerMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) changeOwner, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ChangeOwner) null, (ChangeOwner_Parameters) null, (ChangeOwner_Request) null, out ChangeOwner_Result _);
    }

    public ResultStatus LoadESigDetails(ChangeOwner changeOwner)
    {
      return this.LoadESigDetails(changeOwner, (ChangeOwner_Parameters) null, (ChangeOwner_Request) null, out ChangeOwner_Result _);
    }

    public ResultStatus LoadESigDetails(
      ChangeOwner changeOwner,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      return this.LoadESigDetails(changeOwner, (ChangeOwner_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ChangeOwner changeOwner,
      ChangeOwner_Parameters parameters,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      result = (ChangeOwner_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) changeOwner, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeOwnerService) this._Channel).ProcessComputation(this._UserProfile, changeOwner, parameters, request, out result) : this.AddMethod((Method) new ChangeOwnerMethod(changeOwner, ChangeOwnerMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) changeOwner, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ChangeOwner) null, (ChangeOwner_Parameters) null, (ChangeOwner_Request) null, out ChangeOwner_Result _);
    }

    public ResultStatus ProcessComputation(ChangeOwner changeOwner)
    {
      return this.ProcessComputation(changeOwner, (ChangeOwner_Parameters) null, (ChangeOwner_Request) null, out ChangeOwner_Result _);
    }

    public ResultStatus ProcessComputation(
      ChangeOwner changeOwner,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      return this.ProcessComputation(changeOwner, (ChangeOwner_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ChangeOwner changeOwner,
      ChangeOwner_Parameters parameters,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      result = (ChangeOwner_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) changeOwner, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeOwnerService) this._Channel).ResolveParametricData(this._UserProfile, changeOwner, parameters, request, out result) : this.AddMethod((Method) new ChangeOwnerMethod(changeOwner, ChangeOwnerMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) changeOwner, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ChangeOwner) null, (ChangeOwner_Parameters) null, (ChangeOwner_Request) null, out ChangeOwner_Result _);
    }

    public ResultStatus ResolveParametricData(ChangeOwner changeOwner)
    {
      return this.ResolveParametricData(changeOwner, (ChangeOwner_Parameters) null, (ChangeOwner_Request) null, out ChangeOwner_Result _);
    }

    public ResultStatus ResolveParametricData(
      ChangeOwner changeOwner,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      return this.ResolveParametricData(changeOwner, (ChangeOwner_Parameters) null, request, out result);
    }

    public ResultStatus SetTriageComplete(
      ChangeOwner changeOwner,
      ChangeOwner_Parameters parameters,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      result = (ChangeOwner_Result) null;
      this.OnBeforeCall(nameof (SetTriageComplete), (DCObject) changeOwner, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeOwnerService) this._Channel).SetTriageComplete(this._UserProfile, changeOwner, parameters, request, out result) : this.AddMethod((Method) new ChangeOwnerMethod(changeOwner, ChangeOwnerMethods.SetTriageComplete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetTriageComplete), res, (DCObject) changeOwner, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetTriageComplete()
    {
      return this.SetTriageComplete((ChangeOwner) null, (ChangeOwner_Parameters) null, (ChangeOwner_Request) null, out ChangeOwner_Result _);
    }

    public ResultStatus SetTriageComplete(ChangeOwner changeOwner)
    {
      return this.SetTriageComplete(changeOwner, (ChangeOwner_Parameters) null, (ChangeOwner_Request) null, out ChangeOwner_Result _);
    }

    public ResultStatus SetTriageComplete(
      ChangeOwner changeOwner,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      return this.SetTriageComplete(changeOwner, (ChangeOwner_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject changeOwner,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeOwner_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ChangeOwner) changeOwner, (ChangeOwner_Parameters) parameters, (ChangeOwner_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject changeOwner,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeOwner_Result result1;
        ResultStatus actions = this.GetActions((ChangeOwner) changeOwner, (ChangeOwner_Parameters) parameters, (ChangeOwner_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject changeOwner,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeOwner_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ChangeOwner) changeOwner, (ChangeOwner_Parameters) parameters, (ChangeOwner_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject changeOwner,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeOwner_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ChangeOwner) changeOwner, (ChangeOwner_Parameters) parameters, (ChangeOwner_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject changeOwner,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeOwner_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ChangeOwner) changeOwner, (ChangeOwner_Parameters) parameters, (ChangeOwner_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject changeOwner,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeOwner_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ChangeOwner) changeOwner, (ChangeOwner_Parameters) parameters, (ChangeOwner_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject changeOwner,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeOwner_Result result1;
        ResultStatus resultStatus = this.Load((ChangeOwner) changeOwner, (ChangeOwner_Parameters) parameters, (ChangeOwner_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject changeOwner,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeOwner_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ChangeOwner) changeOwner, (ChangeOwner_Parameters) parameters, (ChangeOwner_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      result = (ChangeOwner_Result) null;
      try
      {
        ChangeOwnerMethod[] methods = new ChangeOwnerMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IChangeOwnerService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ChangeOwner_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ChangeOwner_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeOwner cdo,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      result = (ChangeOwner_Result) null;
      try
      {
        return ((IChangeOwnerService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ChangeOwner_Result result1;
        ResultStatus environment = this.GetEnvironment((ChangeOwner) cdo, (ChangeOwner_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      return this.GetEnvironment((ChangeOwner) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ChangeOwner cdo,
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      result = (ChangeOwner_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeOwnerService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ChangeOwnerMethod(cdo, ChangeOwnerMethods.ExecuteTransaction, (ChangeOwner_Parameters) null));
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
        ChangeOwner_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ChangeOwner) cdo, (ChangeOwner_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ChangeOwner cdo)
    {
      return this.ExecuteTransaction(cdo, (ChangeOwner_Request) null, out ChangeOwner_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ChangeOwner_Request request,
      out ChangeOwner_Result result)
    {
      return this.ExecuteTransaction((ChangeOwner) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ChangeOwner cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ChangeOwnerMethod(cdo, ChangeOwnerMethods.AddDataTransaction, (ChangeOwner_Parameters) null));
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
        return this.AddDataTransaction((ChangeOwner) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
