// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MoveNonStdChangePkgService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MoveNonStdChangePkgService : BPMoveNonStdBase
  {
    public MoveNonStdChangePkgService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMoveNonStdChangePkgService), userProfile);
    }

    public ResultStatus CreateParametricData(
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Parameters parameters,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      result = (MoveNonStdChangePkg_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) moveNonStdChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdChangePkgService) this._Channel).CreateParametricData(this._UserProfile, moveNonStdChangePkg, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdChangePkgMethod(moveNonStdChangePkg, MoveNonStdChangePkgMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) moveNonStdChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((MoveNonStdChangePkg) null, (MoveNonStdChangePkg_Parameters) null, (MoveNonStdChangePkg_Request) null, out MoveNonStdChangePkg_Result _);
    }

    public ResultStatus CreateParametricData(MoveNonStdChangePkg moveNonStdChangePkg)
    {
      return this.CreateParametricData(moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) null, (MoveNonStdChangePkg_Request) null, out MoveNonStdChangePkg_Result _);
    }

    public ResultStatus CreateParametricData(
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      return this.CreateParametricData(moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Parameters parameters,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      result = (MoveNonStdChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) moveNonStdChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdChangePkgService) this._Channel).GetActions(this._UserProfile, moveNonStdChangePkg, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdChangePkgMethod(moveNonStdChangePkg, MoveNonStdChangePkgMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) moveNonStdChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((MoveNonStdChangePkg) null, (MoveNonStdChangePkg_Parameters) null, (MoveNonStdChangePkg_Request) null, out MoveNonStdChangePkg_Result _);
    }

    public ResultStatus GetActions(MoveNonStdChangePkg moveNonStdChangePkg)
    {
      return this.GetActions(moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) null, (MoveNonStdChangePkg_Request) null, out MoveNonStdChangePkg_Result _);
    }

    public ResultStatus GetActions(
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      return this.GetActions(moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Parameters parameters,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      result = (MoveNonStdChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) moveNonStdChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdChangePkgService) this._Channel).GetDataPoints(this._UserProfile, moveNonStdChangePkg, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdChangePkgMethod(moveNonStdChangePkg, MoveNonStdChangePkgMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) moveNonStdChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((MoveNonStdChangePkg) null, (MoveNonStdChangePkg_Parameters) null, (MoveNonStdChangePkg_Request) null, out MoveNonStdChangePkg_Result _);
    }

    public ResultStatus GetDataPoints(MoveNonStdChangePkg moveNonStdChangePkg)
    {
      return this.GetDataPoints(moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) null, (MoveNonStdChangePkg_Request) null, out MoveNonStdChangePkg_Result _);
    }

    public ResultStatus GetDataPoints(
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      return this.GetDataPoints(moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Parameters parameters,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      result = (MoveNonStdChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) moveNonStdChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdChangePkgService) this._Channel).GetWIPMsgs(this._UserProfile, moveNonStdChangePkg, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdChangePkgMethod(moveNonStdChangePkg, MoveNonStdChangePkgMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) moveNonStdChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MoveNonStdChangePkg) null, (MoveNonStdChangePkg_Parameters) null, (MoveNonStdChangePkg_Request) null, out MoveNonStdChangePkg_Result _);
    }

    public ResultStatus GetWIPMsgs(MoveNonStdChangePkg moveNonStdChangePkg)
    {
      return this.GetWIPMsgs(moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) null, (MoveNonStdChangePkg_Request) null, out MoveNonStdChangePkg_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      return this.GetWIPMsgs(moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Parameters parameters,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      result = (MoveNonStdChangePkg_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) moveNonStdChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdChangePkgService) this._Channel).Load(this._UserProfile, moveNonStdChangePkg, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdChangePkgMethod(moveNonStdChangePkg, MoveNonStdChangePkgMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) moveNonStdChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MoveNonStdChangePkg) null, (MoveNonStdChangePkg_Parameters) null, (MoveNonStdChangePkg_Request) null, out MoveNonStdChangePkg_Result _);
    }

    public ResultStatus Load(MoveNonStdChangePkg moveNonStdChangePkg)
    {
      return this.Load(moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) null, (MoveNonStdChangePkg_Request) null, out MoveNonStdChangePkg_Result _);
    }

    public ResultStatus Load(
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      return this.Load(moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_LoadESigDetails_Parameters parameters,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      result = (MoveNonStdChangePkg_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) moveNonStdChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdChangePkgService) this._Channel).LoadESigDetails(this._UserProfile, moveNonStdChangePkg, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdChangePkgMethod(moveNonStdChangePkg, MoveNonStdChangePkgMethods.LoadESigDetails, (MoveNonStdChangePkg_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) moveNonStdChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MoveNonStdChangePkg) null, (MoveNonStdChangePkg_LoadESigDetails_Parameters) null, (MoveNonStdChangePkg_Request) null, out MoveNonStdChangePkg_Result _);
    }

    public ResultStatus LoadESigDetails(MoveNonStdChangePkg moveNonStdChangePkg)
    {
      return this.LoadESigDetails(moveNonStdChangePkg, (MoveNonStdChangePkg_LoadESigDetails_Parameters) null, (MoveNonStdChangePkg_Request) null, out MoveNonStdChangePkg_Result _);
    }

    public ResultStatus LoadESigDetails(
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      return this.LoadESigDetails(moveNonStdChangePkg, (MoveNonStdChangePkg_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Parameters parameters,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      result = (MoveNonStdChangePkg_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) moveNonStdChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdChangePkgService) this._Channel).ProcessComputation(this._UserProfile, moveNonStdChangePkg, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdChangePkgMethod(moveNonStdChangePkg, MoveNonStdChangePkgMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) moveNonStdChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((MoveNonStdChangePkg) null, (MoveNonStdChangePkg_Parameters) null, (MoveNonStdChangePkg_Request) null, out MoveNonStdChangePkg_Result _);
    }

    public ResultStatus ProcessComputation(MoveNonStdChangePkg moveNonStdChangePkg)
    {
      return this.ProcessComputation(moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) null, (MoveNonStdChangePkg_Request) null, out MoveNonStdChangePkg_Result _);
    }

    public ResultStatus ProcessComputation(
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      return this.ProcessComputation(moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Parameters parameters,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      result = (MoveNonStdChangePkg_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) moveNonStdChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdChangePkgService) this._Channel).ResolveParametricData(this._UserProfile, moveNonStdChangePkg, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdChangePkgMethod(moveNonStdChangePkg, MoveNonStdChangePkgMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) moveNonStdChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((MoveNonStdChangePkg) null, (MoveNonStdChangePkg_Parameters) null, (MoveNonStdChangePkg_Request) null, out MoveNonStdChangePkg_Result _);
    }

    public ResultStatus ResolveParametricData(MoveNonStdChangePkg moveNonStdChangePkg)
    {
      return this.ResolveParametricData(moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) null, (MoveNonStdChangePkg_Request) null, out MoveNonStdChangePkg_Result _);
    }

    public ResultStatus ResolveParametricData(
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      return this.ResolveParametricData(moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject moveNonStdChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStdChangePkg_Result result1;
        ResultStatus parametricData = this.CreateParametricData((MoveNonStdChangePkg) moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) parameters, (MoveNonStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject moveNonStdChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStdChangePkg_Result result1;
        ResultStatus actions = this.GetActions((MoveNonStdChangePkg) moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) parameters, (MoveNonStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject moveNonStdChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStdChangePkg_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((MoveNonStdChangePkg) moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) parameters, (MoveNonStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject moveNonStdChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStdChangePkg_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MoveNonStdChangePkg) moveNonStdChangePkg, (MoveNonStdChangePkg_LoadESigDetails_Parameters) parameters, (MoveNonStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject moveNonStdChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStdChangePkg_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((MoveNonStdChangePkg) moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) parameters, (MoveNonStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject moveNonStdChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStdChangePkg_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((MoveNonStdChangePkg) moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) parameters, (MoveNonStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject moveNonStdChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStdChangePkg_Result result1;
        ResultStatus resultStatus = this.Load((MoveNonStdChangePkg) moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) parameters, (MoveNonStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject moveNonStdChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStdChangePkg_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MoveNonStdChangePkg) moveNonStdChangePkg, (MoveNonStdChangePkg_Parameters) parameters, (MoveNonStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      result = (MoveNonStdChangePkg_Result) null;
      try
      {
        MoveNonStdChangePkgMethod[] methods = new MoveNonStdChangePkgMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMoveNonStdChangePkgService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MoveNonStdChangePkg_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MoveNonStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MoveNonStdChangePkg cdo,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      result = (MoveNonStdChangePkg_Result) null;
      try
      {
        return ((IMoveNonStdChangePkgService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MoveNonStdChangePkg_Result result1;
        ResultStatus environment = this.GetEnvironment((MoveNonStdChangePkg) cdo, (MoveNonStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      return this.GetEnvironment((MoveNonStdChangePkg) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MoveNonStdChangePkg cdo,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      result = (MoveNonStdChangePkg_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdChangePkgService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MoveNonStdChangePkgMethod(cdo, MoveNonStdChangePkgMethods.ExecuteTransaction, (MoveNonStdChangePkg_Parameters) null));
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
        MoveNonStdChangePkg_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MoveNonStdChangePkg) cdo, (MoveNonStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MoveNonStdChangePkg cdo)
    {
      return this.ExecuteTransaction(cdo, (MoveNonStdChangePkg_Request) null, out MoveNonStdChangePkg_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result)
    {
      return this.ExecuteTransaction((MoveNonStdChangePkg) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MoveNonStdChangePkg cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MoveNonStdChangePkgMethod(cdo, MoveNonStdChangePkgMethods.AddDataTransaction, (MoveNonStdChangePkg_Parameters) null));
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
        return this.AddDataTransaction((MoveNonStdChangePkg) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
