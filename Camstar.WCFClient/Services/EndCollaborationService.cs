// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.EndCollaborationService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class EndCollaborationService : ProcessObjectTxnBase
  {
    public EndCollaborationService(UserProfile userProfile)
    {
      this.Initialize(typeof (IEndCollaborationService), userProfile);
    }

    public ResultStatus CreateParametricData(
      EndCollaboration endCollaboration,
      EndCollaboration_Parameters parameters,
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      result = (EndCollaboration_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) endCollaboration, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEndCollaborationService) this._Channel).CreateParametricData(this._UserProfile, endCollaboration, parameters, request, out result) : this.AddMethod((Method) new EndCollaborationMethod(endCollaboration, EndCollaborationMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) endCollaboration, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((EndCollaboration) null, (EndCollaboration_Parameters) null, (EndCollaboration_Request) null, out EndCollaboration_Result _);
    }

    public ResultStatus CreateParametricData(EndCollaboration endCollaboration)
    {
      return this.CreateParametricData(endCollaboration, (EndCollaboration_Parameters) null, (EndCollaboration_Request) null, out EndCollaboration_Result _);
    }

    public ResultStatus CreateParametricData(
      EndCollaboration endCollaboration,
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      return this.CreateParametricData(endCollaboration, (EndCollaboration_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      EndCollaboration endCollaboration,
      EndCollaboration_Parameters parameters,
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      result = (EndCollaboration_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) endCollaboration, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEndCollaborationService) this._Channel).GetActions(this._UserProfile, endCollaboration, parameters, request, out result) : this.AddMethod((Method) new EndCollaborationMethod(endCollaboration, EndCollaborationMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) endCollaboration, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((EndCollaboration) null, (EndCollaboration_Parameters) null, (EndCollaboration_Request) null, out EndCollaboration_Result _);
    }

    public ResultStatus GetActions(EndCollaboration endCollaboration)
    {
      return this.GetActions(endCollaboration, (EndCollaboration_Parameters) null, (EndCollaboration_Request) null, out EndCollaboration_Result _);
    }

    public ResultStatus GetActions(
      EndCollaboration endCollaboration,
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      return this.GetActions(endCollaboration, (EndCollaboration_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      EndCollaboration endCollaboration,
      EndCollaboration_Parameters parameters,
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      result = (EndCollaboration_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) endCollaboration, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEndCollaborationService) this._Channel).GetDataPoints(this._UserProfile, endCollaboration, parameters, request, out result) : this.AddMethod((Method) new EndCollaborationMethod(endCollaboration, EndCollaborationMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) endCollaboration, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((EndCollaboration) null, (EndCollaboration_Parameters) null, (EndCollaboration_Request) null, out EndCollaboration_Result _);
    }

    public ResultStatus GetDataPoints(EndCollaboration endCollaboration)
    {
      return this.GetDataPoints(endCollaboration, (EndCollaboration_Parameters) null, (EndCollaboration_Request) null, out EndCollaboration_Result _);
    }

    public ResultStatus GetDataPoints(
      EndCollaboration endCollaboration,
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      return this.GetDataPoints(endCollaboration, (EndCollaboration_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      EndCollaboration endCollaboration,
      EndCollaboration_Parameters parameters,
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      result = (EndCollaboration_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) endCollaboration, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEndCollaborationService) this._Channel).GetWIPMsgs(this._UserProfile, endCollaboration, parameters, request, out result) : this.AddMethod((Method) new EndCollaborationMethod(endCollaboration, EndCollaborationMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) endCollaboration, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((EndCollaboration) null, (EndCollaboration_Parameters) null, (EndCollaboration_Request) null, out EndCollaboration_Result _);
    }

    public ResultStatus GetWIPMsgs(EndCollaboration endCollaboration)
    {
      return this.GetWIPMsgs(endCollaboration, (EndCollaboration_Parameters) null, (EndCollaboration_Request) null, out EndCollaboration_Result _);
    }

    public ResultStatus GetWIPMsgs(
      EndCollaboration endCollaboration,
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      return this.GetWIPMsgs(endCollaboration, (EndCollaboration_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      EndCollaboration endCollaboration,
      EndCollaboration_Parameters parameters,
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      result = (EndCollaboration_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) endCollaboration, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEndCollaborationService) this._Channel).Load(this._UserProfile, endCollaboration, parameters, request, out result) : this.AddMethod((Method) new EndCollaborationMethod(endCollaboration, EndCollaborationMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) endCollaboration, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((EndCollaboration) null, (EndCollaboration_Parameters) null, (EndCollaboration_Request) null, out EndCollaboration_Result _);
    }

    public ResultStatus Load(EndCollaboration endCollaboration)
    {
      return this.Load(endCollaboration, (EndCollaboration_Parameters) null, (EndCollaboration_Request) null, out EndCollaboration_Result _);
    }

    public ResultStatus Load(
      EndCollaboration endCollaboration,
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      return this.Load(endCollaboration, (EndCollaboration_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      EndCollaboration endCollaboration,
      EndCollaboration_Parameters parameters,
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      result = (EndCollaboration_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) endCollaboration, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEndCollaborationService) this._Channel).LoadESigDetails(this._UserProfile, endCollaboration, parameters, request, out result) : this.AddMethod((Method) new EndCollaborationMethod(endCollaboration, EndCollaborationMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) endCollaboration, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((EndCollaboration) null, (EndCollaboration_Parameters) null, (EndCollaboration_Request) null, out EndCollaboration_Result _);
    }

    public ResultStatus LoadESigDetails(EndCollaboration endCollaboration)
    {
      return this.LoadESigDetails(endCollaboration, (EndCollaboration_Parameters) null, (EndCollaboration_Request) null, out EndCollaboration_Result _);
    }

    public ResultStatus LoadESigDetails(
      EndCollaboration endCollaboration,
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      return this.LoadESigDetails(endCollaboration, (EndCollaboration_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      EndCollaboration endCollaboration,
      EndCollaboration_Parameters parameters,
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      result = (EndCollaboration_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) endCollaboration, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEndCollaborationService) this._Channel).ProcessComputation(this._UserProfile, endCollaboration, parameters, request, out result) : this.AddMethod((Method) new EndCollaborationMethod(endCollaboration, EndCollaborationMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) endCollaboration, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((EndCollaboration) null, (EndCollaboration_Parameters) null, (EndCollaboration_Request) null, out EndCollaboration_Result _);
    }

    public ResultStatus ProcessComputation(EndCollaboration endCollaboration)
    {
      return this.ProcessComputation(endCollaboration, (EndCollaboration_Parameters) null, (EndCollaboration_Request) null, out EndCollaboration_Result _);
    }

    public ResultStatus ProcessComputation(
      EndCollaboration endCollaboration,
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      return this.ProcessComputation(endCollaboration, (EndCollaboration_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      EndCollaboration endCollaboration,
      EndCollaboration_Parameters parameters,
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      result = (EndCollaboration_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) endCollaboration, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEndCollaborationService) this._Channel).ResolveParametricData(this._UserProfile, endCollaboration, parameters, request, out result) : this.AddMethod((Method) new EndCollaborationMethod(endCollaboration, EndCollaborationMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) endCollaboration, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((EndCollaboration) null, (EndCollaboration_Parameters) null, (EndCollaboration_Request) null, out EndCollaboration_Result _);
    }

    public ResultStatus ResolveParametricData(EndCollaboration endCollaboration)
    {
      return this.ResolveParametricData(endCollaboration, (EndCollaboration_Parameters) null, (EndCollaboration_Request) null, out EndCollaboration_Result _);
    }

    public ResultStatus ResolveParametricData(
      EndCollaboration endCollaboration,
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      return this.ResolveParametricData(endCollaboration, (EndCollaboration_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject endCollaboration,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EndCollaboration_Result result1;
        ResultStatus parametricData = this.CreateParametricData((EndCollaboration) endCollaboration, (EndCollaboration_Parameters) parameters, (EndCollaboration_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject endCollaboration,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EndCollaboration_Result result1;
        ResultStatus actions = this.GetActions((EndCollaboration) endCollaboration, (EndCollaboration_Parameters) parameters, (EndCollaboration_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject endCollaboration,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EndCollaboration_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((EndCollaboration) endCollaboration, (EndCollaboration_Parameters) parameters, (EndCollaboration_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject endCollaboration,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EndCollaboration_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((EndCollaboration) endCollaboration, (EndCollaboration_Parameters) parameters, (EndCollaboration_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject endCollaboration,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EndCollaboration_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((EndCollaboration) endCollaboration, (EndCollaboration_Parameters) parameters, (EndCollaboration_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject endCollaboration,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EndCollaboration_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((EndCollaboration) endCollaboration, (EndCollaboration_Parameters) parameters, (EndCollaboration_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject endCollaboration,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EndCollaboration_Result result1;
        ResultStatus resultStatus = this.Load((EndCollaboration) endCollaboration, (EndCollaboration_Parameters) parameters, (EndCollaboration_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject endCollaboration,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EndCollaboration_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((EndCollaboration) endCollaboration, (EndCollaboration_Parameters) parameters, (EndCollaboration_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      result = (EndCollaboration_Result) null;
      try
      {
        EndCollaborationMethod[] methods = new EndCollaborationMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IEndCollaborationService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        EndCollaboration_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((EndCollaboration_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EndCollaboration cdo,
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      result = (EndCollaboration_Result) null;
      try
      {
        return ((IEndCollaborationService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        EndCollaboration_Result result1;
        ResultStatus environment = this.GetEnvironment((EndCollaboration) cdo, (EndCollaboration_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      return this.GetEnvironment((EndCollaboration) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      EndCollaboration cdo,
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      result = (EndCollaboration_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEndCollaborationService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new EndCollaborationMethod(cdo, EndCollaborationMethods.ExecuteTransaction, (EndCollaboration_Parameters) null));
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
        EndCollaboration_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((EndCollaboration) cdo, (EndCollaboration_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(EndCollaboration cdo)
    {
      return this.ExecuteTransaction(cdo, (EndCollaboration_Request) null, out EndCollaboration_Result _);
    }

    public ResultStatus ExecuteTransaction(
      EndCollaboration_Request request,
      out EndCollaboration_Result result)
    {
      return this.ExecuteTransaction((EndCollaboration) null, request, out result);
    }

    public ResultStatus AddDataTransaction(EndCollaboration cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new EndCollaborationMethod(cdo, EndCollaborationMethods.AddDataTransaction, (EndCollaboration_Parameters) null));
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
        return this.AddDataTransaction((EndCollaboration) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
