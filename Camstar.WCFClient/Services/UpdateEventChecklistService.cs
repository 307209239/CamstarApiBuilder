// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateEventChecklistService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UpdateEventChecklistService : UpdateEventDetailsBase
  {
    public UpdateEventChecklistService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUpdateEventChecklistService), userProfile);
    }

    public ResultStatus CreateParametricData(
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Parameters parameters,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      result = (UpdateEventChecklist_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) updateEventChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventChecklistService) this._Channel).CreateParametricData(this._UserProfile, updateEventChecklist, parameters, request, out result) : this.AddMethod((Method) new UpdateEventChecklistMethod(updateEventChecklist, UpdateEventChecklistMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) updateEventChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((UpdateEventChecklist) null, (UpdateEventChecklist_Parameters) null, (UpdateEventChecklist_Request) null, out UpdateEventChecklist_Result _);
    }

    public ResultStatus CreateParametricData(UpdateEventChecklist updateEventChecklist)
    {
      return this.CreateParametricData(updateEventChecklist, (UpdateEventChecklist_Parameters) null, (UpdateEventChecklist_Request) null, out UpdateEventChecklist_Result _);
    }

    public ResultStatus CreateParametricData(
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      return this.CreateParametricData(updateEventChecklist, (UpdateEventChecklist_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Parameters parameters,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      result = (UpdateEventChecklist_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) updateEventChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventChecklistService) this._Channel).GetActions(this._UserProfile, updateEventChecklist, parameters, request, out result) : this.AddMethod((Method) new UpdateEventChecklistMethod(updateEventChecklist, UpdateEventChecklistMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) updateEventChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((UpdateEventChecklist) null, (UpdateEventChecklist_Parameters) null, (UpdateEventChecklist_Request) null, out UpdateEventChecklist_Result _);
    }

    public ResultStatus GetActions(UpdateEventChecklist updateEventChecklist)
    {
      return this.GetActions(updateEventChecklist, (UpdateEventChecklist_Parameters) null, (UpdateEventChecklist_Request) null, out UpdateEventChecklist_Result _);
    }

    public ResultStatus GetActions(
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      return this.GetActions(updateEventChecklist, (UpdateEventChecklist_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Parameters parameters,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      result = (UpdateEventChecklist_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) updateEventChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventChecklistService) this._Channel).GetDataPoints(this._UserProfile, updateEventChecklist, parameters, request, out result) : this.AddMethod((Method) new UpdateEventChecklistMethod(updateEventChecklist, UpdateEventChecklistMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) updateEventChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((UpdateEventChecklist) null, (UpdateEventChecklist_Parameters) null, (UpdateEventChecklist_Request) null, out UpdateEventChecklist_Result _);
    }

    public ResultStatus GetDataPoints(UpdateEventChecklist updateEventChecklist)
    {
      return this.GetDataPoints(updateEventChecklist, (UpdateEventChecklist_Parameters) null, (UpdateEventChecklist_Request) null, out UpdateEventChecklist_Result _);
    }

    public ResultStatus GetDataPoints(
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      return this.GetDataPoints(updateEventChecklist, (UpdateEventChecklist_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Parameters parameters,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      result = (UpdateEventChecklist_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) updateEventChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventChecklistService) this._Channel).GetWIPMsgs(this._UserProfile, updateEventChecklist, parameters, request, out result) : this.AddMethod((Method) new UpdateEventChecklistMethod(updateEventChecklist, UpdateEventChecklistMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) updateEventChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UpdateEventChecklist) null, (UpdateEventChecklist_Parameters) null, (UpdateEventChecklist_Request) null, out UpdateEventChecklist_Result _);
    }

    public ResultStatus GetWIPMsgs(UpdateEventChecklist updateEventChecklist)
    {
      return this.GetWIPMsgs(updateEventChecklist, (UpdateEventChecklist_Parameters) null, (UpdateEventChecklist_Request) null, out UpdateEventChecklist_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      return this.GetWIPMsgs(updateEventChecklist, (UpdateEventChecklist_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Parameters parameters,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      result = (UpdateEventChecklist_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) updateEventChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventChecklistService) this._Channel).Load(this._UserProfile, updateEventChecklist, parameters, request, out result) : this.AddMethod((Method) new UpdateEventChecklistMethod(updateEventChecklist, UpdateEventChecklistMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) updateEventChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UpdateEventChecklist) null, (UpdateEventChecklist_Parameters) null, (UpdateEventChecklist_Request) null, out UpdateEventChecklist_Result _);
    }

    public ResultStatus Load(UpdateEventChecklist updateEventChecklist)
    {
      return this.Load(updateEventChecklist, (UpdateEventChecklist_Parameters) null, (UpdateEventChecklist_Request) null, out UpdateEventChecklist_Result _);
    }

    public ResultStatus Load(
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      return this.Load(updateEventChecklist, (UpdateEventChecklist_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Parameters parameters,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      result = (UpdateEventChecklist_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) updateEventChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventChecklistService) this._Channel).LoadESigDetails(this._UserProfile, updateEventChecklist, parameters, request, out result) : this.AddMethod((Method) new UpdateEventChecklistMethod(updateEventChecklist, UpdateEventChecklistMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) updateEventChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UpdateEventChecklist) null, (UpdateEventChecklist_Parameters) null, (UpdateEventChecklist_Request) null, out UpdateEventChecklist_Result _);
    }

    public ResultStatus LoadESigDetails(UpdateEventChecklist updateEventChecklist)
    {
      return this.LoadESigDetails(updateEventChecklist, (UpdateEventChecklist_Parameters) null, (UpdateEventChecklist_Request) null, out UpdateEventChecklist_Result _);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      return this.LoadESigDetails(updateEventChecklist, (UpdateEventChecklist_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Parameters parameters,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      result = (UpdateEventChecklist_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) updateEventChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventChecklistService) this._Channel).ProcessComputation(this._UserProfile, updateEventChecklist, parameters, request, out result) : this.AddMethod((Method) new UpdateEventChecklistMethod(updateEventChecklist, UpdateEventChecklistMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) updateEventChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((UpdateEventChecklist) null, (UpdateEventChecklist_Parameters) null, (UpdateEventChecklist_Request) null, out UpdateEventChecklist_Result _);
    }

    public ResultStatus ProcessComputation(UpdateEventChecklist updateEventChecklist)
    {
      return this.ProcessComputation(updateEventChecklist, (UpdateEventChecklist_Parameters) null, (UpdateEventChecklist_Request) null, out UpdateEventChecklist_Result _);
    }

    public ResultStatus ProcessComputation(
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      return this.ProcessComputation(updateEventChecklist, (UpdateEventChecklist_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Parameters parameters,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      result = (UpdateEventChecklist_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) updateEventChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventChecklistService) this._Channel).ResolveParametricData(this._UserProfile, updateEventChecklist, parameters, request, out result) : this.AddMethod((Method) new UpdateEventChecklistMethod(updateEventChecklist, UpdateEventChecklistMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) updateEventChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((UpdateEventChecklist) null, (UpdateEventChecklist_Parameters) null, (UpdateEventChecklist_Request) null, out UpdateEventChecklist_Result _);
    }

    public ResultStatus ResolveParametricData(UpdateEventChecklist updateEventChecklist)
    {
      return this.ResolveParametricData(updateEventChecklist, (UpdateEventChecklist_Parameters) null, (UpdateEventChecklist_Request) null, out UpdateEventChecklist_Result _);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      return this.ResolveParametricData(updateEventChecklist, (UpdateEventChecklist_Parameters) null, request, out result);
    }

    public ResultStatus ValidateIfChecklistHasResponses(
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Parameters parameters,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      result = (UpdateEventChecklist_Result) null;
      this.OnBeforeCall(nameof (ValidateIfChecklistHasResponses), (DCObject) updateEventChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventChecklistService) this._Channel).ValidateIfChecklistHasResponses(this._UserProfile, updateEventChecklist, parameters, request, out result) : this.AddMethod((Method) new UpdateEventChecklistMethod(updateEventChecklist, UpdateEventChecklistMethods.ValidateIfChecklistHasResponses, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateIfChecklistHasResponses), res, (DCObject) updateEventChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateIfChecklistHasResponses()
    {
      return this.ValidateIfChecklistHasResponses((UpdateEventChecklist) null, (UpdateEventChecklist_Parameters) null, (UpdateEventChecklist_Request) null, out UpdateEventChecklist_Result _);
    }

    public ResultStatus ValidateIfChecklistHasResponses(
      UpdateEventChecklist updateEventChecklist)
    {
      return this.ValidateIfChecklistHasResponses(updateEventChecklist, (UpdateEventChecklist_Parameters) null, (UpdateEventChecklist_Request) null, out UpdateEventChecklist_Result _);
    }

    public ResultStatus ValidateIfChecklistHasResponses(
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      return this.ValidateIfChecklistHasResponses(updateEventChecklist, (UpdateEventChecklist_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject updateEventChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventChecklist_Result result1;
        ResultStatus parametricData = this.CreateParametricData((UpdateEventChecklist) updateEventChecklist, (UpdateEventChecklist_Parameters) parameters, (UpdateEventChecklist_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject updateEventChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventChecklist_Result result1;
        ResultStatus actions = this.GetActions((UpdateEventChecklist) updateEventChecklist, (UpdateEventChecklist_Parameters) parameters, (UpdateEventChecklist_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject updateEventChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventChecklist_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((UpdateEventChecklist) updateEventChecklist, (UpdateEventChecklist_Parameters) parameters, (UpdateEventChecklist_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject updateEventChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventChecklist_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UpdateEventChecklist) updateEventChecklist, (UpdateEventChecklist_Parameters) parameters, (UpdateEventChecklist_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject updateEventChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventChecklist_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((UpdateEventChecklist) updateEventChecklist, (UpdateEventChecklist_Parameters) parameters, (UpdateEventChecklist_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject updateEventChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventChecklist_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((UpdateEventChecklist) updateEventChecklist, (UpdateEventChecklist_Parameters) parameters, (UpdateEventChecklist_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject updateEventChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventChecklist_Result result1;
        ResultStatus resultStatus = this.Load((UpdateEventChecklist) updateEventChecklist, (UpdateEventChecklist_Parameters) parameters, (UpdateEventChecklist_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject updateEventChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventChecklist_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UpdateEventChecklist) updateEventChecklist, (UpdateEventChecklist_Parameters) parameters, (UpdateEventChecklist_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      result = (UpdateEventChecklist_Result) null;
      try
      {
        UpdateEventChecklistMethod[] methods = new UpdateEventChecklistMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUpdateEventChecklistService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UpdateEventChecklist_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UpdateEventChecklist_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventChecklist cdo,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      result = (UpdateEventChecklist_Result) null;
      try
      {
        return ((IUpdateEventChecklistService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UpdateEventChecklist_Result result1;
        ResultStatus environment = this.GetEnvironment((UpdateEventChecklist) cdo, (UpdateEventChecklist_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      return this.GetEnvironment((UpdateEventChecklist) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventChecklist cdo,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      result = (UpdateEventChecklist_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventChecklistService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UpdateEventChecklistMethod(cdo, UpdateEventChecklistMethods.ExecuteTransaction, (UpdateEventChecklist_Parameters) null));
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
        UpdateEventChecklist_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UpdateEventChecklist) cdo, (UpdateEventChecklist_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UpdateEventChecklist cdo)
    {
      return this.ExecuteTransaction(cdo, (UpdateEventChecklist_Request) null, out UpdateEventChecklist_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result)
    {
      return this.ExecuteTransaction((UpdateEventChecklist) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UpdateEventChecklist cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UpdateEventChecklistMethod(cdo, UpdateEventChecklistMethods.AddDataTransaction, (UpdateEventChecklist_Parameters) null));
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
        return this.AddDataTransaction((UpdateEventChecklist) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
