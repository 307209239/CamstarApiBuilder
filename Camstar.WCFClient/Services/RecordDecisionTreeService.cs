// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RecordDecisionTreeService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RecordDecisionTreeService : QualityTxnBase
  {
    public RecordDecisionTreeService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRecordDecisionTreeService), userProfile);
    }

    public ResultStatus CreateParametricData(
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Parameters parameters,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      result = (RecordDecisionTree_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) recordDecisionTree, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecordDecisionTreeService) this._Channel).CreateParametricData(this._UserProfile, recordDecisionTree, parameters, request, out result) : this.AddMethod((Method) new RecordDecisionTreeMethod(recordDecisionTree, RecordDecisionTreeMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) recordDecisionTree, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((RecordDecisionTree) null, (RecordDecisionTree_Parameters) null, (RecordDecisionTree_Request) null, out RecordDecisionTree_Result _);
    }

    public ResultStatus CreateParametricData(RecordDecisionTree recordDecisionTree)
    {
      return this.CreateParametricData(recordDecisionTree, (RecordDecisionTree_Parameters) null, (RecordDecisionTree_Request) null, out RecordDecisionTree_Result _);
    }

    public ResultStatus CreateParametricData(
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      return this.CreateParametricData(recordDecisionTree, (RecordDecisionTree_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Parameters parameters,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      result = (RecordDecisionTree_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) recordDecisionTree, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecordDecisionTreeService) this._Channel).GetActions(this._UserProfile, recordDecisionTree, parameters, request, out result) : this.AddMethod((Method) new RecordDecisionTreeMethod(recordDecisionTree, RecordDecisionTreeMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) recordDecisionTree, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((RecordDecisionTree) null, (RecordDecisionTree_Parameters) null, (RecordDecisionTree_Request) null, out RecordDecisionTree_Result _);
    }

    public ResultStatus GetActions(RecordDecisionTree recordDecisionTree)
    {
      return this.GetActions(recordDecisionTree, (RecordDecisionTree_Parameters) null, (RecordDecisionTree_Request) null, out RecordDecisionTree_Result _);
    }

    public ResultStatus GetActions(
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      return this.GetActions(recordDecisionTree, (RecordDecisionTree_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Parameters parameters,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      result = (RecordDecisionTree_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) recordDecisionTree, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecordDecisionTreeService) this._Channel).GetDataPoints(this._UserProfile, recordDecisionTree, parameters, request, out result) : this.AddMethod((Method) new RecordDecisionTreeMethod(recordDecisionTree, RecordDecisionTreeMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) recordDecisionTree, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((RecordDecisionTree) null, (RecordDecisionTree_Parameters) null, (RecordDecisionTree_Request) null, out RecordDecisionTree_Result _);
    }

    public ResultStatus GetDataPoints(RecordDecisionTree recordDecisionTree)
    {
      return this.GetDataPoints(recordDecisionTree, (RecordDecisionTree_Parameters) null, (RecordDecisionTree_Request) null, out RecordDecisionTree_Result _);
    }

    public ResultStatus GetDataPoints(
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      return this.GetDataPoints(recordDecisionTree, (RecordDecisionTree_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Parameters parameters,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      result = (RecordDecisionTree_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) recordDecisionTree, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecordDecisionTreeService) this._Channel).GetWIPMsgs(this._UserProfile, recordDecisionTree, parameters, request, out result) : this.AddMethod((Method) new RecordDecisionTreeMethod(recordDecisionTree, RecordDecisionTreeMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) recordDecisionTree, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RecordDecisionTree) null, (RecordDecisionTree_Parameters) null, (RecordDecisionTree_Request) null, out RecordDecisionTree_Result _);
    }

    public ResultStatus GetWIPMsgs(RecordDecisionTree recordDecisionTree)
    {
      return this.GetWIPMsgs(recordDecisionTree, (RecordDecisionTree_Parameters) null, (RecordDecisionTree_Request) null, out RecordDecisionTree_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      return this.GetWIPMsgs(recordDecisionTree, (RecordDecisionTree_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Parameters parameters,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      result = (RecordDecisionTree_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) recordDecisionTree, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecordDecisionTreeService) this._Channel).Load(this._UserProfile, recordDecisionTree, parameters, request, out result) : this.AddMethod((Method) new RecordDecisionTreeMethod(recordDecisionTree, RecordDecisionTreeMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) recordDecisionTree, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RecordDecisionTree) null, (RecordDecisionTree_Parameters) null, (RecordDecisionTree_Request) null, out RecordDecisionTree_Result _);
    }

    public ResultStatus Load(RecordDecisionTree recordDecisionTree)
    {
      return this.Load(recordDecisionTree, (RecordDecisionTree_Parameters) null, (RecordDecisionTree_Request) null, out RecordDecisionTree_Result _);
    }

    public ResultStatus Load(
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      return this.Load(recordDecisionTree, (RecordDecisionTree_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Parameters parameters,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      result = (RecordDecisionTree_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) recordDecisionTree, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecordDecisionTreeService) this._Channel).LoadESigDetails(this._UserProfile, recordDecisionTree, parameters, request, out result) : this.AddMethod((Method) new RecordDecisionTreeMethod(recordDecisionTree, RecordDecisionTreeMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) recordDecisionTree, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RecordDecisionTree) null, (RecordDecisionTree_Parameters) null, (RecordDecisionTree_Request) null, out RecordDecisionTree_Result _);
    }

    public ResultStatus LoadESigDetails(RecordDecisionTree recordDecisionTree)
    {
      return this.LoadESigDetails(recordDecisionTree, (RecordDecisionTree_Parameters) null, (RecordDecisionTree_Request) null, out RecordDecisionTree_Result _);
    }

    public ResultStatus LoadESigDetails(
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      return this.LoadESigDetails(recordDecisionTree, (RecordDecisionTree_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Parameters parameters,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      result = (RecordDecisionTree_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) recordDecisionTree, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecordDecisionTreeService) this._Channel).ProcessComputation(this._UserProfile, recordDecisionTree, parameters, request, out result) : this.AddMethod((Method) new RecordDecisionTreeMethod(recordDecisionTree, RecordDecisionTreeMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) recordDecisionTree, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((RecordDecisionTree) null, (RecordDecisionTree_Parameters) null, (RecordDecisionTree_Request) null, out RecordDecisionTree_Result _);
    }

    public ResultStatus ProcessComputation(RecordDecisionTree recordDecisionTree)
    {
      return this.ProcessComputation(recordDecisionTree, (RecordDecisionTree_Parameters) null, (RecordDecisionTree_Request) null, out RecordDecisionTree_Result _);
    }

    public ResultStatus ProcessComputation(
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      return this.ProcessComputation(recordDecisionTree, (RecordDecisionTree_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Parameters parameters,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      result = (RecordDecisionTree_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) recordDecisionTree, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecordDecisionTreeService) this._Channel).ResolveParametricData(this._UserProfile, recordDecisionTree, parameters, request, out result) : this.AddMethod((Method) new RecordDecisionTreeMethod(recordDecisionTree, RecordDecisionTreeMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) recordDecisionTree, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((RecordDecisionTree) null, (RecordDecisionTree_Parameters) null, (RecordDecisionTree_Request) null, out RecordDecisionTree_Result _);
    }

    public ResultStatus ResolveParametricData(RecordDecisionTree recordDecisionTree)
    {
      return this.ResolveParametricData(recordDecisionTree, (RecordDecisionTree_Parameters) null, (RecordDecisionTree_Request) null, out RecordDecisionTree_Result _);
    }

    public ResultStatus ResolveParametricData(
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      return this.ResolveParametricData(recordDecisionTree, (RecordDecisionTree_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject recordDecisionTree,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecordDecisionTree_Result result1;
        ResultStatus parametricData = this.CreateParametricData((RecordDecisionTree) recordDecisionTree, (RecordDecisionTree_Parameters) parameters, (RecordDecisionTree_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject recordDecisionTree,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecordDecisionTree_Result result1;
        ResultStatus actions = this.GetActions((RecordDecisionTree) recordDecisionTree, (RecordDecisionTree_Parameters) parameters, (RecordDecisionTree_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject recordDecisionTree,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecordDecisionTree_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((RecordDecisionTree) recordDecisionTree, (RecordDecisionTree_Parameters) parameters, (RecordDecisionTree_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject recordDecisionTree,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecordDecisionTree_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RecordDecisionTree) recordDecisionTree, (RecordDecisionTree_Parameters) parameters, (RecordDecisionTree_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject recordDecisionTree,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecordDecisionTree_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((RecordDecisionTree) recordDecisionTree, (RecordDecisionTree_Parameters) parameters, (RecordDecisionTree_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject recordDecisionTree,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecordDecisionTree_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((RecordDecisionTree) recordDecisionTree, (RecordDecisionTree_Parameters) parameters, (RecordDecisionTree_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject recordDecisionTree,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecordDecisionTree_Result result1;
        ResultStatus resultStatus = this.Load((RecordDecisionTree) recordDecisionTree, (RecordDecisionTree_Parameters) parameters, (RecordDecisionTree_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject recordDecisionTree,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecordDecisionTree_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RecordDecisionTree) recordDecisionTree, (RecordDecisionTree_Parameters) parameters, (RecordDecisionTree_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      result = (RecordDecisionTree_Result) null;
      try
      {
        RecordDecisionTreeMethod[] methods = new RecordDecisionTreeMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRecordDecisionTreeService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        RecordDecisionTree_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RecordDecisionTree_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RecordDecisionTree cdo,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      result = (RecordDecisionTree_Result) null;
      try
      {
        return ((IRecordDecisionTreeService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        RecordDecisionTree_Result result1;
        ResultStatus environment = this.GetEnvironment((RecordDecisionTree) cdo, (RecordDecisionTree_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      return this.GetEnvironment((RecordDecisionTree) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RecordDecisionTree cdo,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      result = (RecordDecisionTree_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecordDecisionTreeService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RecordDecisionTreeMethod(cdo, RecordDecisionTreeMethods.ExecuteTransaction, (RecordDecisionTree_Parameters) null));
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
        RecordDecisionTree_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RecordDecisionTree) cdo, (RecordDecisionTree_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RecordDecisionTree cdo)
    {
      return this.ExecuteTransaction(cdo, (RecordDecisionTree_Request) null, out RecordDecisionTree_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result)
    {
      return this.ExecuteTransaction((RecordDecisionTree) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RecordDecisionTree cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RecordDecisionTreeMethod(cdo, RecordDecisionTreeMethods.AddDataTransaction, (RecordDecisionTree_Parameters) null));
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
        return this.AddDataTransaction((RecordDecisionTree) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
