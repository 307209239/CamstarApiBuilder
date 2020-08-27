// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MoveStdChangePkgService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MoveStdChangePkgService : BPMoveStdBase
  {
    public MoveStdChangePkgService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMoveStdChangePkgService), userProfile);
    }

    public ResultStatus CreateParametricData(
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Parameters parameters,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      result = (MoveStdChangePkg_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) moveStdChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdChangePkgService) this._Channel).CreateParametricData(this._UserProfile, moveStdChangePkg, parameters, request, out result) : this.AddMethod((Method) new MoveStdChangePkgMethod(moveStdChangePkg, MoveStdChangePkgMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) moveStdChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((MoveStdChangePkg) null, (MoveStdChangePkg_Parameters) null, (MoveStdChangePkg_Request) null, out MoveStdChangePkg_Result _);
    }

    public ResultStatus CreateParametricData(MoveStdChangePkg moveStdChangePkg)
    {
      return this.CreateParametricData(moveStdChangePkg, (MoveStdChangePkg_Parameters) null, (MoveStdChangePkg_Request) null, out MoveStdChangePkg_Result _);
    }

    public ResultStatus CreateParametricData(
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      return this.CreateParametricData(moveStdChangePkg, (MoveStdChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Parameters parameters,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      result = (MoveStdChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) moveStdChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdChangePkgService) this._Channel).GetActions(this._UserProfile, moveStdChangePkg, parameters, request, out result) : this.AddMethod((Method) new MoveStdChangePkgMethod(moveStdChangePkg, MoveStdChangePkgMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) moveStdChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((MoveStdChangePkg) null, (MoveStdChangePkg_Parameters) null, (MoveStdChangePkg_Request) null, out MoveStdChangePkg_Result _);
    }

    public ResultStatus GetActions(MoveStdChangePkg moveStdChangePkg)
    {
      return this.GetActions(moveStdChangePkg, (MoveStdChangePkg_Parameters) null, (MoveStdChangePkg_Request) null, out MoveStdChangePkg_Result _);
    }

    public ResultStatus GetActions(
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      return this.GetActions(moveStdChangePkg, (MoveStdChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Parameters parameters,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      result = (MoveStdChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) moveStdChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdChangePkgService) this._Channel).GetDataPoints(this._UserProfile, moveStdChangePkg, parameters, request, out result) : this.AddMethod((Method) new MoveStdChangePkgMethod(moveStdChangePkg, MoveStdChangePkgMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) moveStdChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((MoveStdChangePkg) null, (MoveStdChangePkg_Parameters) null, (MoveStdChangePkg_Request) null, out MoveStdChangePkg_Result _);
    }

    public ResultStatus GetDataPoints(MoveStdChangePkg moveStdChangePkg)
    {
      return this.GetDataPoints(moveStdChangePkg, (MoveStdChangePkg_Parameters) null, (MoveStdChangePkg_Request) null, out MoveStdChangePkg_Result _);
    }

    public ResultStatus GetDataPoints(
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      return this.GetDataPoints(moveStdChangePkg, (MoveStdChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Parameters parameters,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      result = (MoveStdChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) moveStdChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdChangePkgService) this._Channel).GetWIPMsgs(this._UserProfile, moveStdChangePkg, parameters, request, out result) : this.AddMethod((Method) new MoveStdChangePkgMethod(moveStdChangePkg, MoveStdChangePkgMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) moveStdChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MoveStdChangePkg) null, (MoveStdChangePkg_Parameters) null, (MoveStdChangePkg_Request) null, out MoveStdChangePkg_Result _);
    }

    public ResultStatus GetWIPMsgs(MoveStdChangePkg moveStdChangePkg)
    {
      return this.GetWIPMsgs(moveStdChangePkg, (MoveStdChangePkg_Parameters) null, (MoveStdChangePkg_Request) null, out MoveStdChangePkg_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      return this.GetWIPMsgs(moveStdChangePkg, (MoveStdChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Parameters parameters,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      result = (MoveStdChangePkg_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) moveStdChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdChangePkgService) this._Channel).Load(this._UserProfile, moveStdChangePkg, parameters, request, out result) : this.AddMethod((Method) new MoveStdChangePkgMethod(moveStdChangePkg, MoveStdChangePkgMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) moveStdChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MoveStdChangePkg) null, (MoveStdChangePkg_Parameters) null, (MoveStdChangePkg_Request) null, out MoveStdChangePkg_Result _);
    }

    public ResultStatus Load(MoveStdChangePkg moveStdChangePkg)
    {
      return this.Load(moveStdChangePkg, (MoveStdChangePkg_Parameters) null, (MoveStdChangePkg_Request) null, out MoveStdChangePkg_Result _);
    }

    public ResultStatus Load(
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      return this.Load(moveStdChangePkg, (MoveStdChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_LoadESigDetails_Parameters parameters,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      result = (MoveStdChangePkg_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) moveStdChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdChangePkgService) this._Channel).LoadESigDetails(this._UserProfile, moveStdChangePkg, parameters, request, out result) : this.AddMethod((Method) new MoveStdChangePkgMethod(moveStdChangePkg, MoveStdChangePkgMethods.LoadESigDetails, (MoveStdChangePkg_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) moveStdChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MoveStdChangePkg) null, (MoveStdChangePkg_LoadESigDetails_Parameters) null, (MoveStdChangePkg_Request) null, out MoveStdChangePkg_Result _);
    }

    public ResultStatus LoadESigDetails(MoveStdChangePkg moveStdChangePkg)
    {
      return this.LoadESigDetails(moveStdChangePkg, (MoveStdChangePkg_LoadESigDetails_Parameters) null, (MoveStdChangePkg_Request) null, out MoveStdChangePkg_Result _);
    }

    public ResultStatus LoadESigDetails(
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      return this.LoadESigDetails(moveStdChangePkg, (MoveStdChangePkg_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Parameters parameters,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      result = (MoveStdChangePkg_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) moveStdChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdChangePkgService) this._Channel).ProcessComputation(this._UserProfile, moveStdChangePkg, parameters, request, out result) : this.AddMethod((Method) new MoveStdChangePkgMethod(moveStdChangePkg, MoveStdChangePkgMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) moveStdChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((MoveStdChangePkg) null, (MoveStdChangePkg_Parameters) null, (MoveStdChangePkg_Request) null, out MoveStdChangePkg_Result _);
    }

    public ResultStatus ProcessComputation(MoveStdChangePkg moveStdChangePkg)
    {
      return this.ProcessComputation(moveStdChangePkg, (MoveStdChangePkg_Parameters) null, (MoveStdChangePkg_Request) null, out MoveStdChangePkg_Result _);
    }

    public ResultStatus ProcessComputation(
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      return this.ProcessComputation(moveStdChangePkg, (MoveStdChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Parameters parameters,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      result = (MoveStdChangePkg_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) moveStdChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdChangePkgService) this._Channel).ResolveParametricData(this._UserProfile, moveStdChangePkg, parameters, request, out result) : this.AddMethod((Method) new MoveStdChangePkgMethod(moveStdChangePkg, MoveStdChangePkgMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) moveStdChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((MoveStdChangePkg) null, (MoveStdChangePkg_Parameters) null, (MoveStdChangePkg_Request) null, out MoveStdChangePkg_Result _);
    }

    public ResultStatus ResolveParametricData(MoveStdChangePkg moveStdChangePkg)
    {
      return this.ResolveParametricData(moveStdChangePkg, (MoveStdChangePkg_Parameters) null, (MoveStdChangePkg_Request) null, out MoveStdChangePkg_Result _);
    }

    public ResultStatus ResolveParametricData(
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      return this.ResolveParametricData(moveStdChangePkg, (MoveStdChangePkg_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject moveStdChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveStdChangePkg_Result result1;
        ResultStatus parametricData = this.CreateParametricData((MoveStdChangePkg) moveStdChangePkg, (MoveStdChangePkg_Parameters) parameters, (MoveStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject moveStdChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveStdChangePkg_Result result1;
        ResultStatus actions = this.GetActions((MoveStdChangePkg) moveStdChangePkg, (MoveStdChangePkg_Parameters) parameters, (MoveStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject moveStdChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveStdChangePkg_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((MoveStdChangePkg) moveStdChangePkg, (MoveStdChangePkg_Parameters) parameters, (MoveStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject moveStdChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveStdChangePkg_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MoveStdChangePkg) moveStdChangePkg, (MoveStdChangePkg_LoadESigDetails_Parameters) parameters, (MoveStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject moveStdChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveStdChangePkg_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((MoveStdChangePkg) moveStdChangePkg, (MoveStdChangePkg_Parameters) parameters, (MoveStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject moveStdChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveStdChangePkg_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((MoveStdChangePkg) moveStdChangePkg, (MoveStdChangePkg_Parameters) parameters, (MoveStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject moveStdChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveStdChangePkg_Result result1;
        ResultStatus resultStatus = this.Load((MoveStdChangePkg) moveStdChangePkg, (MoveStdChangePkg_Parameters) parameters, (MoveStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject moveStdChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveStdChangePkg_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MoveStdChangePkg) moveStdChangePkg, (MoveStdChangePkg_Parameters) parameters, (MoveStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      result = (MoveStdChangePkg_Result) null;
      try
      {
        MoveStdChangePkgMethod[] methods = new MoveStdChangePkgMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMoveStdChangePkgService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MoveStdChangePkg_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MoveStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MoveStdChangePkg cdo,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      result = (MoveStdChangePkg_Result) null;
      try
      {
        return ((IMoveStdChangePkgService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MoveStdChangePkg_Result result1;
        ResultStatus environment = this.GetEnvironment((MoveStdChangePkg) cdo, (MoveStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      return this.GetEnvironment((MoveStdChangePkg) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MoveStdChangePkg cdo,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      result = (MoveStdChangePkg_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveStdChangePkgService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MoveStdChangePkgMethod(cdo, MoveStdChangePkgMethods.ExecuteTransaction, (MoveStdChangePkg_Parameters) null));
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
        MoveStdChangePkg_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MoveStdChangePkg) cdo, (MoveStdChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MoveStdChangePkg cdo)
    {
      return this.ExecuteTransaction(cdo, (MoveStdChangePkg_Request) null, out MoveStdChangePkg_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result)
    {
      return this.ExecuteTransaction((MoveStdChangePkg) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MoveStdChangePkg cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MoveStdChangePkgMethod(cdo, MoveStdChangePkgMethods.AddDataTransaction, (MoveStdChangePkg_Parameters) null));
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
        return this.AddDataTransaction((MoveStdChangePkg) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
