// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SplitService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SplitService : ContainerTxnBase
  {
    public SplitService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISplitService), userProfile);
    }

    public ResultStatus CreateParametricData(
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result)
    {
      result = (Split_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) split, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISplitService) this._Channel).CreateParametricData(this._UserProfile, split, parameters, request, out result) : this.AddMethod((Method) new SplitMethod(split, SplitMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) split, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Split) null, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus CreateParametricData(Split split)
    {
      return this.CreateParametricData(split, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus CreateParametricData(
      Split split,
      Split_Request request,
      out Split_Result result)
    {
      return this.CreateParametricData(split, (Split_Parameters) null, request, out result);
    }

    public ResultStatus ExecuteContainerSplit(
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result)
    {
      result = (Split_Result) null;
      this.OnBeforeCall(nameof (ExecuteContainerSplit), (DCObject) split, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISplitService) this._Channel).ExecuteContainerSplit(this._UserProfile, split, parameters, request, out result) : this.AddMethod((Method) new SplitMethod(split, SplitMethods.ExecuteContainerSplit, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteContainerSplit), res, (DCObject) split, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ExecuteContainerSplit()
    {
      return this.ExecuteContainerSplit((Split) null, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus ExecuteContainerSplit(Split split)
    {
      return this.ExecuteContainerSplit(split, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus ExecuteContainerSplit(
      Split split,
      Split_Request request,
      out Split_Result result)
    {
      return this.ExecuteContainerSplit(split, (Split_Parameters) null, request, out result);
    }

    public ResultStatus ExecuteMaterialSplit(
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result)
    {
      result = (Split_Result) null;
      this.OnBeforeCall(nameof (ExecuteMaterialSplit), (DCObject) split, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISplitService) this._Channel).ExecuteMaterialSplit(this._UserProfile, split, parameters, request, out result) : this.AddMethod((Method) new SplitMethod(split, SplitMethods.ExecuteMaterialSplit, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteMaterialSplit), res, (DCObject) split, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ExecuteMaterialSplit()
    {
      return this.ExecuteMaterialSplit((Split) null, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus ExecuteMaterialSplit(Split split)
    {
      return this.ExecuteMaterialSplit(split, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus ExecuteMaterialSplit(
      Split split,
      Split_Request request,
      out Split_Result result)
    {
      return this.ExecuteMaterialSplit(split, (Split_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result)
    {
      result = (Split_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) split, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISplitService) this._Channel).GetActions(this._UserProfile, split, parameters, request, out result) : this.AddMethod((Method) new SplitMethod(split, SplitMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) split, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Split) null, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus GetActions(Split split)
    {
      return this.GetActions(split, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus GetActions(
      Split split,
      Split_Request request,
      out Split_Result result)
    {
      return this.GetActions(split, (Split_Parameters) null, request, out result);
    }

    public ResultStatus GetContainerName(
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result)
    {
      result = (Split_Result) null;
      this.OnBeforeCall(nameof (GetContainerName), (DCObject) split, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISplitService) this._Channel).GetContainerName(this._UserProfile, split, parameters, request, out result) : this.AddMethod((Method) new SplitMethod(split, SplitMethods.GetContainerName, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetContainerName), res, (DCObject) split, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetContainerName()
    {
      return this.GetContainerName((Split) null, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus GetContainerName(Split split)
    {
      return this.GetContainerName(split, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus GetContainerName(
      Split split,
      Split_Request request,
      out Split_Result result)
    {
      return this.GetContainerName(split, (Split_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result)
    {
      result = (Split_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) split, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISplitService) this._Channel).GetDataPoints(this._UserProfile, split, parameters, request, out result) : this.AddMethod((Method) new SplitMethod(split, SplitMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) split, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Split) null, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus GetDataPoints(Split split)
    {
      return this.GetDataPoints(split, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus GetDataPoints(
      Split split,
      Split_Request request,
      out Split_Result result)
    {
      return this.GetDataPoints(split, (Split_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result)
    {
      result = (Split_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) split, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISplitService) this._Channel).GetWIPMsgs(this._UserProfile, split, parameters, request, out result) : this.AddMethod((Method) new SplitMethod(split, SplitMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) split, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Split) null, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus GetWIPMsgs(Split split)
    {
      return this.GetWIPMsgs(split, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Split split,
      Split_Request request,
      out Split_Result result)
    {
      return this.GetWIPMsgs(split, (Split_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result)
    {
      result = (Split_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) split, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISplitService) this._Channel).Load(this._UserProfile, split, parameters, request, out result) : this.AddMethod((Method) new SplitMethod(split, SplitMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) split, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Split) null, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus Load(Split split)
    {
      return this.Load(split, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus Load(
      Split split,
      Split_Request request,
      out Split_Result result)
    {
      return this.Load(split, (Split_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Split split,
      Split_LoadESigDetails_Parameters parameters,
      Split_Request request,
      out Split_Result result)
    {
      result = (Split_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) split, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISplitService) this._Channel).LoadESigDetails(this._UserProfile, split, parameters, request, out result) : this.AddMethod((Method) new SplitMethod(split, SplitMethods.LoadESigDetails, (Split_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) split, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Split) null, (Split_LoadESigDetails_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus LoadESigDetails(Split split)
    {
      return this.LoadESigDetails(split, (Split_LoadESigDetails_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus LoadESigDetails(
      Split split,
      Split_Request request,
      out Split_Result result)
    {
      return this.LoadESigDetails(split, (Split_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessAutoNumbering(
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result)
    {
      result = (Split_Result) null;
      this.OnBeforeCall(nameof (ProcessAutoNumbering), (DCObject) split, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISplitService) this._Channel).ProcessAutoNumbering(this._UserProfile, split, parameters, request, out result) : this.AddMethod((Method) new SplitMethod(split, SplitMethods.ProcessAutoNumbering, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessAutoNumbering), res, (DCObject) split, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessAutoNumbering()
    {
      return this.ProcessAutoNumbering((Split) null, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus ProcessAutoNumbering(Split split)
    {
      return this.ProcessAutoNumbering(split, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus ProcessAutoNumbering(
      Split split,
      Split_Request request,
      out Split_Result result)
    {
      return this.ProcessAutoNumbering(split, (Split_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result)
    {
      result = (Split_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) split, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISplitService) this._Channel).ProcessComputation(this._UserProfile, split, parameters, request, out result) : this.AddMethod((Method) new SplitMethod(split, SplitMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) split, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Split) null, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus ProcessComputation(Split split)
    {
      return this.ProcessComputation(split, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus ProcessComputation(
      Split split,
      Split_Request request,
      out Split_Result result)
    {
      return this.ProcessComputation(split, (Split_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result)
    {
      result = (Split_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) split, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISplitService) this._Channel).ResolveParametricData(this._UserProfile, split, parameters, request, out result) : this.AddMethod((Method) new SplitMethod(split, SplitMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) split, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Split) null, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus ResolveParametricData(Split split)
    {
      return this.ResolveParametricData(split, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus ResolveParametricData(
      Split split,
      Split_Request request,
      out Split_Result result)
    {
      return this.ResolveParametricData(split, (Split_Parameters) null, request, out result);
    }

    public ResultStatus SetTxnXRefsToAncestors(
      Split split,
      Split_SetTxnXRefsToAncestors_Parameters parameters,
      Split_Request request,
      out Split_Result result)
    {
      result = (Split_Result) null;
      this.OnBeforeCall(nameof (SetTxnXRefsToAncestors), (DCObject) split, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISplitService) this._Channel).SetTxnXRefsToAncestors(this._UserProfile, split, parameters, request, out result) : this.AddMethod((Method) new SplitMethod(split, SplitMethods.SetTxnXRefsToAncestors, (Split_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetTxnXRefsToAncestors), res, (DCObject) split, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetTxnXRefsToAncestors()
    {
      return this.SetTxnXRefsToAncestors((Split) null, (Split_SetTxnXRefsToAncestors_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus SetTxnXRefsToAncestors(Split split)
    {
      return this.SetTxnXRefsToAncestors(split, (Split_SetTxnXRefsToAncestors_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus SetTxnXRefsToAncestors(
      Split split,
      Split_Request request,
      out Split_Result result)
    {
      return this.SetTxnXRefsToAncestors(split, (Split_SetTxnXRefsToAncestors_Parameters) null, request, out result);
    }

    public ResultStatus SplitContainer(
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result)
    {
      result = (Split_Result) null;
      this.OnBeforeCall(nameof (SplitContainer), (DCObject) split, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISplitService) this._Channel).SplitContainer(this._UserProfile, split, parameters, request, out result) : this.AddMethod((Method) new SplitMethod(split, SplitMethods.SplitContainer, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SplitContainer), res, (DCObject) split, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SplitContainer()
    {
      return this.SplitContainer((Split) null, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus SplitContainer(Split split)
    {
      return this.SplitContainer(split, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus SplitContainer(
      Split split,
      Split_Request request,
      out Split_Result result)
    {
      return this.SplitContainer(split, (Split_Parameters) null, request, out result);
    }

    public ResultStatus SplitMaterial(
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result)
    {
      result = (Split_Result) null;
      this.OnBeforeCall(nameof (SplitMaterial), (DCObject) split, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISplitService) this._Channel).SplitMaterial(this._UserProfile, split, parameters, request, out result) : this.AddMethod((Method) new SplitMethod(split, SplitMethods.SplitMaterial, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SplitMaterial), res, (DCObject) split, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SplitMaterial()
    {
      return this.SplitMaterial((Split) null, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus SplitMaterial(Split split)
    {
      return this.SplitMaterial(split, (Split_Parameters) null, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus SplitMaterial(
      Split split,
      Split_Request request,
      out Split_Result result)
    {
      return this.SplitMaterial(split, (Split_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject split,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Split_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Split) split, (Split_Parameters) parameters, (Split_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject split,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Split_Result result1;
        ResultStatus actions = this.GetActions((Split) split, (Split_Parameters) parameters, (Split_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject split,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Split_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Split) split, (Split_Parameters) parameters, (Split_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject split,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Split_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Split) split, (Split_LoadESigDetails_Parameters) parameters, (Split_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject split,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Split_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Split) split, (Split_Parameters) parameters, (Split_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject split,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Split_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Split) split, (Split_Parameters) parameters, (Split_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject split,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Split_Result result1;
        ResultStatus resultStatus = this.Load((Split) split, (Split_Parameters) parameters, (Split_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject split,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Split_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Split) split, (Split_Parameters) parameters, (Split_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Split_Request request,
      out Split_Result result)
    {
      result = (Split_Result) null;
      try
      {
        SplitMethod[] methods = new SplitMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISplitService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Split_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Split_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Split cdo,
      Split_Request request,
      out Split_Result result)
    {
      result = (Split_Result) null;
      try
      {
        return ((ISplitService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Split_Result result1;
        ResultStatus environment = this.GetEnvironment((Split) cdo, (Split_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(Split_Request request, out Split_Result result)
    {
      return this.GetEnvironment((Split) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Split cdo,
      Split_Request request,
      out Split_Result result)
    {
      result = (Split_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISplitService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SplitMethod(cdo, SplitMethods.ExecuteTransaction, (Split_Parameters) null));
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
        Split_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Split) cdo, (Split_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Split cdo)
    {
      return this.ExecuteTransaction(cdo, (Split_Request) null, out Split_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Split_Request request,
      out Split_Result result)
    {
      return this.ExecuteTransaction((Split) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Split cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SplitMethod(cdo, SplitMethods.AddDataTransaction, (Split_Parameters) null));
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
        return this.AddDataTransaction((Split) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
