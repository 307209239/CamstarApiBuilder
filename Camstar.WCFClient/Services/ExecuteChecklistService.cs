// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ExecuteChecklistService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ExecuteChecklistService : GenericTxnBase
  {
    public ExecuteChecklistService(UserProfile userProfile)
    {
      this.Initialize(typeof (IExecuteChecklistService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_Parameters parameters,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      result = (ExecuteChecklist_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) executeChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteChecklistService) this._Channel).CreateParametricData(this._UserProfile, executeChecklist, parameters, request, out result) : this.AddMethod((Method) new ExecuteChecklistMethod(executeChecklist, ExecuteChecklistMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) executeChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ExecuteChecklist) null, (ExecuteChecklist_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus CreateParametricData(ExecuteChecklist executeChecklist)
    {
      return this.CreateParametricData(executeChecklist, (ExecuteChecklist_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus CreateParametricData(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      return this.CreateParametricData(executeChecklist, (ExecuteChecklist_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_Parameters parameters,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      result = (ExecuteChecklist_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) executeChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteChecklistService) this._Channel).GetActions(this._UserProfile, executeChecklist, parameters, request, out result) : this.AddMethod((Method) new ExecuteChecklistMethod(executeChecklist, ExecuteChecklistMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) executeChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ExecuteChecklist) null, (ExecuteChecklist_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus GetActions(ExecuteChecklist executeChecklist)
    {
      return this.GetActions(executeChecklist, (ExecuteChecklist_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus GetActions(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      return this.GetActions(executeChecklist, (ExecuteChecklist_Parameters) null, request, out result);
    }

    public ResultStatus GetChecklistEntries(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_Parameters parameters,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      result = (ExecuteChecklist_Result) null;
      this.OnBeforeCall(nameof (GetChecklistEntries), (DCObject) executeChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteChecklistService) this._Channel).GetChecklistEntries(this._UserProfile, executeChecklist, parameters, request, out result) : this.AddMethod((Method) new ExecuteChecklistMethod(executeChecklist, ExecuteChecklistMethods.GetChecklistEntries, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetChecklistEntries), res, (DCObject) executeChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetChecklistEntries()
    {
      return this.GetChecklistEntries((ExecuteChecklist) null, (ExecuteChecklist_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus GetChecklistEntries(ExecuteChecklist executeChecklist)
    {
      return this.GetChecklistEntries(executeChecklist, (ExecuteChecklist_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus GetChecklistEntries(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      return this.GetChecklistEntries(executeChecklist, (ExecuteChecklist_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_Parameters parameters,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      result = (ExecuteChecklist_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) executeChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteChecklistService) this._Channel).GetDataPoints(this._UserProfile, executeChecklist, parameters, request, out result) : this.AddMethod((Method) new ExecuteChecklistMethod(executeChecklist, ExecuteChecklistMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) executeChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ExecuteChecklist) null, (ExecuteChecklist_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus GetDataPoints(ExecuteChecklist executeChecklist)
    {
      return this.GetDataPoints(executeChecklist, (ExecuteChecklist_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus GetDataPoints(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      return this.GetDataPoints(executeChecklist, (ExecuteChecklist_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_Parameters parameters,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      result = (ExecuteChecklist_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) executeChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteChecklistService) this._Channel).GetWIPMsgs(this._UserProfile, executeChecklist, parameters, request, out result) : this.AddMethod((Method) new ExecuteChecklistMethod(executeChecklist, ExecuteChecklistMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) executeChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ExecuteChecklist) null, (ExecuteChecklist_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus GetWIPMsgs(ExecuteChecklist executeChecklist)
    {
      return this.GetWIPMsgs(executeChecklist, (ExecuteChecklist_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      return this.GetWIPMsgs(executeChecklist, (ExecuteChecklist_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_Parameters parameters,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      result = (ExecuteChecklist_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) executeChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteChecklistService) this._Channel).Load(this._UserProfile, executeChecklist, parameters, request, out result) : this.AddMethod((Method) new ExecuteChecklistMethod(executeChecklist, ExecuteChecklistMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) executeChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ExecuteChecklist) null, (ExecuteChecklist_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus Load(ExecuteChecklist executeChecklist)
    {
      return this.Load(executeChecklist, (ExecuteChecklist_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus Load(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      return this.Load(executeChecklist, (ExecuteChecklist_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_LoadESigDetails_Parameters parameters,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      result = (ExecuteChecklist_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) executeChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteChecklistService) this._Channel).LoadESigDetails(this._UserProfile, executeChecklist, parameters, request, out result) : this.AddMethod((Method) new ExecuteChecklistMethod(executeChecklist, ExecuteChecklistMethods.LoadESigDetails, (ExecuteChecklist_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) executeChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ExecuteChecklist) null, (ExecuteChecklist_LoadESigDetails_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus LoadESigDetails(ExecuteChecklist executeChecklist)
    {
      return this.LoadESigDetails(executeChecklist, (ExecuteChecklist_LoadESigDetails_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus LoadESigDetails(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      return this.LoadESigDetails(executeChecklist, (ExecuteChecklist_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus PreviewChecklist(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_Parameters parameters,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      result = (ExecuteChecklist_Result) null;
      this.OnBeforeCall(nameof (PreviewChecklist), (DCObject) executeChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteChecklistService) this._Channel).PreviewChecklist(this._UserProfile, executeChecklist, parameters, request, out result) : this.AddMethod((Method) new ExecuteChecklistMethod(executeChecklist, ExecuteChecklistMethods.PreviewChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreviewChecklist), res, (DCObject) executeChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreviewChecklist()
    {
      return this.PreviewChecklist((ExecuteChecklist) null, (ExecuteChecklist_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus PreviewChecklist(ExecuteChecklist executeChecklist)
    {
      return this.PreviewChecklist(executeChecklist, (ExecuteChecklist_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus PreviewChecklist(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      return this.PreviewChecklist(executeChecklist, (ExecuteChecklist_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_Parameters parameters,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      result = (ExecuteChecklist_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) executeChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteChecklistService) this._Channel).ProcessComputation(this._UserProfile, executeChecklist, parameters, request, out result) : this.AddMethod((Method) new ExecuteChecklistMethod(executeChecklist, ExecuteChecklistMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) executeChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ExecuteChecklist) null, (ExecuteChecklist_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus ProcessComputation(ExecuteChecklist executeChecklist)
    {
      return this.ProcessComputation(executeChecklist, (ExecuteChecklist_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus ProcessComputation(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      return this.ProcessComputation(executeChecklist, (ExecuteChecklist_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_Parameters parameters,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      result = (ExecuteChecklist_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) executeChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteChecklistService) this._Channel).ResolveParametricData(this._UserProfile, executeChecklist, parameters, request, out result) : this.AddMethod((Method) new ExecuteChecklistMethod(executeChecklist, ExecuteChecklistMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) executeChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ExecuteChecklist) null, (ExecuteChecklist_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus ResolveParametricData(ExecuteChecklist executeChecklist)
    {
      return this.ResolveParametricData(executeChecklist, (ExecuteChecklist_Parameters) null, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus ResolveParametricData(
      ExecuteChecklist executeChecklist,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      return this.ResolveParametricData(executeChecklist, (ExecuteChecklist_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject executeChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteChecklist_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ExecuteChecklist) executeChecklist, (ExecuteChecklist_Parameters) parameters, (ExecuteChecklist_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject executeChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteChecklist_Result result1;
        ResultStatus actions = this.GetActions((ExecuteChecklist) executeChecklist, (ExecuteChecklist_Parameters) parameters, (ExecuteChecklist_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject executeChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteChecklist_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ExecuteChecklist) executeChecklist, (ExecuteChecklist_Parameters) parameters, (ExecuteChecklist_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject executeChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteChecklist_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ExecuteChecklist) executeChecklist, (ExecuteChecklist_LoadESigDetails_Parameters) parameters, (ExecuteChecklist_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject executeChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteChecklist_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ExecuteChecklist) executeChecklist, (ExecuteChecklist_Parameters) parameters, (ExecuteChecklist_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject executeChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteChecklist_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ExecuteChecklist) executeChecklist, (ExecuteChecklist_Parameters) parameters, (ExecuteChecklist_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject executeChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteChecklist_Result result1;
        ResultStatus resultStatus = this.Load((ExecuteChecklist) executeChecklist, (ExecuteChecklist_Parameters) parameters, (ExecuteChecklist_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject executeChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExecuteChecklist_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ExecuteChecklist) executeChecklist, (ExecuteChecklist_Parameters) parameters, (ExecuteChecklist_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      result = (ExecuteChecklist_Result) null;
      try
      {
        ExecuteChecklistMethod[] methods = new ExecuteChecklistMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IExecuteChecklistService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ExecuteChecklist_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ExecuteChecklist_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ExecuteChecklist cdo,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      result = (ExecuteChecklist_Result) null;
      try
      {
        return ((IExecuteChecklistService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ExecuteChecklist_Result result1;
        ResultStatus environment = this.GetEnvironment((ExecuteChecklist) cdo, (ExecuteChecklist_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      return this.GetEnvironment((ExecuteChecklist) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ExecuteChecklist cdo,
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      result = (ExecuteChecklist_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExecuteChecklistService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ExecuteChecklistMethod(cdo, ExecuteChecklistMethods.ExecuteTransaction, (ExecuteChecklist_Parameters) null));
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
        ExecuteChecklist_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ExecuteChecklist) cdo, (ExecuteChecklist_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ExecuteChecklist cdo)
    {
      return this.ExecuteTransaction(cdo, (ExecuteChecklist_Request) null, out ExecuteChecklist_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ExecuteChecklist_Request request,
      out ExecuteChecklist_Result result)
    {
      return this.ExecuteTransaction((ExecuteChecklist) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ExecuteChecklist cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ExecuteChecklistMethod(cdo, ExecuteChecklistMethods.AddDataTransaction, (ExecuteChecklist_Parameters) null));
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
        return this.AddDataTransaction((ExecuteChecklist) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
