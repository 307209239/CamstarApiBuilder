// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CombineService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CombineService : ContainerTxnBase
  {
    public CombineService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICombineService), userProfile);
    }

    public ResultStatus Combine_ContainerExecute(
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result)
    {
      result = (Combine_Result) null;
      this.OnBeforeCall(nameof (Combine_ContainerExecute), (DCObject) combine, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICombineService) this._Channel).Combine_ContainerExecute(this._UserProfile, combine, parameters, request, out result) : this.AddMethod((Method) new CombineMethod(combine, CombineMethods.Combine_ContainerExecute, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Combine_ContainerExecute), res, (DCObject) combine, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Combine_ContainerExecute()
    {
      return this.Combine_ContainerExecute((Combine) null, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus Combine_ContainerExecute(Combine combine)
    {
      return this.Combine_ContainerExecute(combine, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus Combine_ContainerExecute(
      Combine combine,
      Combine_Request request,
      out Combine_Result result)
    {
      return this.Combine_ContainerExecute(combine, (Combine_Parameters) null, request, out result);
    }

    public ResultStatus Combine_QuantityExecute(
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result)
    {
      result = (Combine_Result) null;
      this.OnBeforeCall(nameof (Combine_QuantityExecute), (DCObject) combine, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICombineService) this._Channel).Combine_QuantityExecute(this._UserProfile, combine, parameters, request, out result) : this.AddMethod((Method) new CombineMethod(combine, CombineMethods.Combine_QuantityExecute, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Combine_QuantityExecute), res, (DCObject) combine, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Combine_QuantityExecute()
    {
      return this.Combine_QuantityExecute((Combine) null, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus Combine_QuantityExecute(Combine combine)
    {
      return this.Combine_QuantityExecute(combine, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus Combine_QuantityExecute(
      Combine combine,
      Combine_Request request,
      out Combine_Result result)
    {
      return this.Combine_QuantityExecute(combine, (Combine_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result)
    {
      result = (Combine_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) combine, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICombineService) this._Channel).CreateParametricData(this._UserProfile, combine, parameters, request, out result) : this.AddMethod((Method) new CombineMethod(combine, CombineMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) combine, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Combine) null, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus CreateParametricData(Combine combine)
    {
      return this.CreateParametricData(combine, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus CreateParametricData(
      Combine combine,
      Combine_Request request,
      out Combine_Result result)
    {
      return this.CreateParametricData(combine, (Combine_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result)
    {
      result = (Combine_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) combine, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICombineService) this._Channel).GetActions(this._UserProfile, combine, parameters, request, out result) : this.AddMethod((Method) new CombineMethod(combine, CombineMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) combine, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Combine) null, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus GetActions(Combine combine)
    {
      return this.GetActions(combine, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus GetActions(
      Combine combine,
      Combine_Request request,
      out Combine_Result result)
    {
      return this.GetActions(combine, (Combine_Parameters) null, request, out result);
    }

    public ResultStatus GetCombineToContainers(
      Combine combine,
      Combine_GetCombineToContainers_Parameters parameters,
      Combine_Request request,
      out Combine_Result result)
    {
      result = (Combine_Result) null;
      this.OnBeforeCall(nameof (GetCombineToContainers), (DCObject) combine, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICombineService) this._Channel).GetCombineToContainers(this._UserProfile, combine, parameters, request, out result) : this.AddMethod((Method) new CombineMethod(combine, CombineMethods.GetCombineToContainers, (Combine_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetCombineToContainers), res, (DCObject) combine, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetCombineToContainers()
    {
      return this.GetCombineToContainers((Combine) null, (Combine_GetCombineToContainers_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus GetCombineToContainers(Combine combine)
    {
      return this.GetCombineToContainers(combine, (Combine_GetCombineToContainers_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus GetCombineToContainers(
      Combine combine,
      Combine_Request request,
      out Combine_Result result)
    {
      return this.GetCombineToContainers(combine, (Combine_GetCombineToContainers_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result)
    {
      result = (Combine_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) combine, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICombineService) this._Channel).GetDataPoints(this._UserProfile, combine, parameters, request, out result) : this.AddMethod((Method) new CombineMethod(combine, CombineMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) combine, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Combine) null, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus GetDataPoints(Combine combine)
    {
      return this.GetDataPoints(combine, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus GetDataPoints(
      Combine combine,
      Combine_Request request,
      out Combine_Result result)
    {
      return this.GetDataPoints(combine, (Combine_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result)
    {
      result = (Combine_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) combine, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICombineService) this._Channel).GetWIPMsgs(this._UserProfile, combine, parameters, request, out result) : this.AddMethod((Method) new CombineMethod(combine, CombineMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) combine, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Combine) null, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus GetWIPMsgs(Combine combine)
    {
      return this.GetWIPMsgs(combine, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Combine combine,
      Combine_Request request,
      out Combine_Result result)
    {
      return this.GetWIPMsgs(combine, (Combine_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result)
    {
      result = (Combine_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) combine, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICombineService) this._Channel).Load(this._UserProfile, combine, parameters, request, out result) : this.AddMethod((Method) new CombineMethod(combine, CombineMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) combine, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Combine) null, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus Load(Combine combine)
    {
      return this.Load(combine, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus Load(
      Combine combine,
      Combine_Request request,
      out Combine_Result result)
    {
      return this.Load(combine, (Combine_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Combine combine,
      Combine_LoadESigDetails_Parameters parameters,
      Combine_Request request,
      out Combine_Result result)
    {
      result = (Combine_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) combine, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICombineService) this._Channel).LoadESigDetails(this._UserProfile, combine, parameters, request, out result) : this.AddMethod((Method) new CombineMethod(combine, CombineMethods.LoadESigDetails, (Combine_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) combine, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Combine) null, (Combine_LoadESigDetails_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus LoadESigDetails(Combine combine)
    {
      return this.LoadESigDetails(combine, (Combine_LoadESigDetails_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus LoadESigDetails(
      Combine combine,
      Combine_Request request,
      out Combine_Result result)
    {
      return this.LoadESigDetails(combine, (Combine_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result)
    {
      result = (Combine_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) combine, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICombineService) this._Channel).ProcessComputation(this._UserProfile, combine, parameters, request, out result) : this.AddMethod((Method) new CombineMethod(combine, CombineMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) combine, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Combine) null, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus ProcessComputation(Combine combine)
    {
      return this.ProcessComputation(combine, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus ProcessComputation(
      Combine combine,
      Combine_Request request,
      out Combine_Result result)
    {
      return this.ProcessComputation(combine, (Combine_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result)
    {
      result = (Combine_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) combine, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICombineService) this._Channel).ResolveParametricData(this._UserProfile, combine, parameters, request, out result) : this.AddMethod((Method) new CombineMethod(combine, CombineMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) combine, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Combine) null, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus ResolveParametricData(Combine combine)
    {
      return this.ResolveParametricData(combine, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus ResolveParametricData(
      Combine combine,
      Combine_Request request,
      out Combine_Result result)
    {
      return this.ResolveParametricData(combine, (Combine_Parameters) null, request, out result);
    }

    public ResultStatus ValidateContainerCombine(
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result)
    {
      result = (Combine_Result) null;
      this.OnBeforeCall(nameof (ValidateContainerCombine), (DCObject) combine, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICombineService) this._Channel).ValidateContainerCombine(this._UserProfile, combine, parameters, request, out result) : this.AddMethod((Method) new CombineMethod(combine, CombineMethods.ValidateContainerCombine, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateContainerCombine), res, (DCObject) combine, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateContainerCombine()
    {
      return this.ValidateContainerCombine((Combine) null, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus ValidateContainerCombine(Combine combine)
    {
      return this.ValidateContainerCombine(combine, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus ValidateContainerCombine(
      Combine combine,
      Combine_Request request,
      out Combine_Result result)
    {
      return this.ValidateContainerCombine(combine, (Combine_Parameters) null, request, out result);
    }

    public ResultStatus ValidateQtyCombine(
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result)
    {
      result = (Combine_Result) null;
      this.OnBeforeCall(nameof (ValidateQtyCombine), (DCObject) combine, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICombineService) this._Channel).ValidateQtyCombine(this._UserProfile, combine, parameters, request, out result) : this.AddMethod((Method) new CombineMethod(combine, CombineMethods.ValidateQtyCombine, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateQtyCombine), res, (DCObject) combine, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateQtyCombine()
    {
      return this.ValidateQtyCombine((Combine) null, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus ValidateQtyCombine(Combine combine)
    {
      return this.ValidateQtyCombine(combine, (Combine_Parameters) null, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus ValidateQtyCombine(
      Combine combine,
      Combine_Request request,
      out Combine_Result result)
    {
      return this.ValidateQtyCombine(combine, (Combine_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject combine,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Combine_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Combine) combine, (Combine_Parameters) parameters, (Combine_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject combine,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Combine_Result result1;
        ResultStatus actions = this.GetActions((Combine) combine, (Combine_Parameters) parameters, (Combine_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject combine,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Combine_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Combine) combine, (Combine_Parameters) parameters, (Combine_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject combine,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Combine_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Combine) combine, (Combine_LoadESigDetails_Parameters) parameters, (Combine_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject combine,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Combine_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Combine) combine, (Combine_Parameters) parameters, (Combine_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject combine,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Combine_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Combine) combine, (Combine_Parameters) parameters, (Combine_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject combine,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Combine_Result result1;
        ResultStatus resultStatus = this.Load((Combine) combine, (Combine_Parameters) parameters, (Combine_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject combine,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Combine_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Combine) combine, (Combine_Parameters) parameters, (Combine_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Combine_Request request,
      out Combine_Result result)
    {
      result = (Combine_Result) null;
      try
      {
        CombineMethod[] methods = new CombineMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICombineService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Combine_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Combine_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Combine cdo,
      Combine_Request request,
      out Combine_Result result)
    {
      result = (Combine_Result) null;
      try
      {
        return ((ICombineService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Combine_Result result1;
        ResultStatus environment = this.GetEnvironment((Combine) cdo, (Combine_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Combine_Request request,
      out Combine_Result result)
    {
      return this.GetEnvironment((Combine) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Combine cdo,
      Combine_Request request,
      out Combine_Result result)
    {
      result = (Combine_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICombineService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CombineMethod(cdo, CombineMethods.ExecuteTransaction, (Combine_Parameters) null));
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
        Combine_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Combine) cdo, (Combine_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Combine cdo)
    {
      return this.ExecuteTransaction(cdo, (Combine_Request) null, out Combine_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Combine_Request request,
      out Combine_Result result)
    {
      return this.ExecuteTransaction((Combine) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Combine cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CombineMethod(cdo, CombineMethods.AddDataTransaction, (Combine_Parameters) null));
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
        return this.AddDataTransaction((Combine) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
