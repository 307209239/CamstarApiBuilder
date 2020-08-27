// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AssignPermissionsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class AssignPermissionsService : ShopFloorBase
  {
    public AssignPermissionsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IAssignPermissionsService), userProfile);
    }

    public ResultStatus CreateParametricData(
      AssignPermissions assignPermissions,
      AssignPermissions_Parameters parameters,
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      result = (AssignPermissions_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) assignPermissions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignPermissionsService) this._Channel).CreateParametricData(this._UserProfile, assignPermissions, parameters, request, out result) : this.AddMethod((Method) new AssignPermissionsMethod(assignPermissions, AssignPermissionsMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) assignPermissions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((AssignPermissions) null, (AssignPermissions_Parameters) null, (AssignPermissions_Request) null, out AssignPermissions_Result _);
    }

    public ResultStatus CreateParametricData(AssignPermissions assignPermissions)
    {
      return this.CreateParametricData(assignPermissions, (AssignPermissions_Parameters) null, (AssignPermissions_Request) null, out AssignPermissions_Result _);
    }

    public ResultStatus CreateParametricData(
      AssignPermissions assignPermissions,
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      return this.CreateParametricData(assignPermissions, (AssignPermissions_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      AssignPermissions assignPermissions,
      AssignPermissions_Parameters parameters,
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      result = (AssignPermissions_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) assignPermissions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignPermissionsService) this._Channel).GetActions(this._UserProfile, assignPermissions, parameters, request, out result) : this.AddMethod((Method) new AssignPermissionsMethod(assignPermissions, AssignPermissionsMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) assignPermissions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((AssignPermissions) null, (AssignPermissions_Parameters) null, (AssignPermissions_Request) null, out AssignPermissions_Result _);
    }

    public ResultStatus GetActions(AssignPermissions assignPermissions)
    {
      return this.GetActions(assignPermissions, (AssignPermissions_Parameters) null, (AssignPermissions_Request) null, out AssignPermissions_Result _);
    }

    public ResultStatus GetActions(
      AssignPermissions assignPermissions,
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      return this.GetActions(assignPermissions, (AssignPermissions_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      AssignPermissions assignPermissions,
      AssignPermissions_Parameters parameters,
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      result = (AssignPermissions_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) assignPermissions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignPermissionsService) this._Channel).GetDataPoints(this._UserProfile, assignPermissions, parameters, request, out result) : this.AddMethod((Method) new AssignPermissionsMethod(assignPermissions, AssignPermissionsMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) assignPermissions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((AssignPermissions) null, (AssignPermissions_Parameters) null, (AssignPermissions_Request) null, out AssignPermissions_Result _);
    }

    public ResultStatus GetDataPoints(AssignPermissions assignPermissions)
    {
      return this.GetDataPoints(assignPermissions, (AssignPermissions_Parameters) null, (AssignPermissions_Request) null, out AssignPermissions_Result _);
    }

    public ResultStatus GetDataPoints(
      AssignPermissions assignPermissions,
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      return this.GetDataPoints(assignPermissions, (AssignPermissions_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      AssignPermissions assignPermissions,
      AssignPermissions_Parameters parameters,
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      result = (AssignPermissions_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) assignPermissions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignPermissionsService) this._Channel).GetWIPMsgs(this._UserProfile, assignPermissions, parameters, request, out result) : this.AddMethod((Method) new AssignPermissionsMethod(assignPermissions, AssignPermissionsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) assignPermissions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((AssignPermissions) null, (AssignPermissions_Parameters) null, (AssignPermissions_Request) null, out AssignPermissions_Result _);
    }

    public ResultStatus GetWIPMsgs(AssignPermissions assignPermissions)
    {
      return this.GetWIPMsgs(assignPermissions, (AssignPermissions_Parameters) null, (AssignPermissions_Request) null, out AssignPermissions_Result _);
    }

    public ResultStatus GetWIPMsgs(
      AssignPermissions assignPermissions,
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      return this.GetWIPMsgs(assignPermissions, (AssignPermissions_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      AssignPermissions assignPermissions,
      AssignPermissions_Parameters parameters,
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      result = (AssignPermissions_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) assignPermissions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignPermissionsService) this._Channel).Load(this._UserProfile, assignPermissions, parameters, request, out result) : this.AddMethod((Method) new AssignPermissionsMethod(assignPermissions, AssignPermissionsMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) assignPermissions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((AssignPermissions) null, (AssignPermissions_Parameters) null, (AssignPermissions_Request) null, out AssignPermissions_Result _);
    }

    public ResultStatus Load(AssignPermissions assignPermissions)
    {
      return this.Load(assignPermissions, (AssignPermissions_Parameters) null, (AssignPermissions_Request) null, out AssignPermissions_Result _);
    }

    public ResultStatus Load(
      AssignPermissions assignPermissions,
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      return this.Load(assignPermissions, (AssignPermissions_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      AssignPermissions assignPermissions,
      AssignPermissions_LoadESigDetails_Parameters parameters,
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      result = (AssignPermissions_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) assignPermissions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignPermissionsService) this._Channel).LoadESigDetails(this._UserProfile, assignPermissions, parameters, request, out result) : this.AddMethod((Method) new AssignPermissionsMethod(assignPermissions, AssignPermissionsMethods.LoadESigDetails, (AssignPermissions_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) assignPermissions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((AssignPermissions) null, (AssignPermissions_LoadESigDetails_Parameters) null, (AssignPermissions_Request) null, out AssignPermissions_Result _);
    }

    public ResultStatus LoadESigDetails(AssignPermissions assignPermissions)
    {
      return this.LoadESigDetails(assignPermissions, (AssignPermissions_LoadESigDetails_Parameters) null, (AssignPermissions_Request) null, out AssignPermissions_Result _);
    }

    public ResultStatus LoadESigDetails(
      AssignPermissions assignPermissions,
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      return this.LoadESigDetails(assignPermissions, (AssignPermissions_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      AssignPermissions assignPermissions,
      AssignPermissions_Parameters parameters,
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      result = (AssignPermissions_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) assignPermissions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignPermissionsService) this._Channel).ProcessComputation(this._UserProfile, assignPermissions, parameters, request, out result) : this.AddMethod((Method) new AssignPermissionsMethod(assignPermissions, AssignPermissionsMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) assignPermissions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((AssignPermissions) null, (AssignPermissions_Parameters) null, (AssignPermissions_Request) null, out AssignPermissions_Result _);
    }

    public ResultStatus ProcessComputation(AssignPermissions assignPermissions)
    {
      return this.ProcessComputation(assignPermissions, (AssignPermissions_Parameters) null, (AssignPermissions_Request) null, out AssignPermissions_Result _);
    }

    public ResultStatus ProcessComputation(
      AssignPermissions assignPermissions,
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      return this.ProcessComputation(assignPermissions, (AssignPermissions_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      AssignPermissions assignPermissions,
      AssignPermissions_Parameters parameters,
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      result = (AssignPermissions_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) assignPermissions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignPermissionsService) this._Channel).ResolveParametricData(this._UserProfile, assignPermissions, parameters, request, out result) : this.AddMethod((Method) new AssignPermissionsMethod(assignPermissions, AssignPermissionsMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) assignPermissions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((AssignPermissions) null, (AssignPermissions_Parameters) null, (AssignPermissions_Request) null, out AssignPermissions_Result _);
    }

    public ResultStatus ResolveParametricData(AssignPermissions assignPermissions)
    {
      return this.ResolveParametricData(assignPermissions, (AssignPermissions_Parameters) null, (AssignPermissions_Request) null, out AssignPermissions_Result _);
    }

    public ResultStatus ResolveParametricData(
      AssignPermissions assignPermissions,
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      return this.ResolveParametricData(assignPermissions, (AssignPermissions_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject assignPermissions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignPermissions_Result result1;
        ResultStatus parametricData = this.CreateParametricData((AssignPermissions) assignPermissions, (AssignPermissions_Parameters) parameters, (AssignPermissions_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject assignPermissions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignPermissions_Result result1;
        ResultStatus actions = this.GetActions((AssignPermissions) assignPermissions, (AssignPermissions_Parameters) parameters, (AssignPermissions_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject assignPermissions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignPermissions_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((AssignPermissions) assignPermissions, (AssignPermissions_Parameters) parameters, (AssignPermissions_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject assignPermissions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignPermissions_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((AssignPermissions) assignPermissions, (AssignPermissions_LoadESigDetails_Parameters) parameters, (AssignPermissions_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject assignPermissions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignPermissions_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((AssignPermissions) assignPermissions, (AssignPermissions_Parameters) parameters, (AssignPermissions_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject assignPermissions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignPermissions_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((AssignPermissions) assignPermissions, (AssignPermissions_Parameters) parameters, (AssignPermissions_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject assignPermissions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignPermissions_Result result1;
        ResultStatus resultStatus = this.Load((AssignPermissions) assignPermissions, (AssignPermissions_Parameters) parameters, (AssignPermissions_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject assignPermissions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignPermissions_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((AssignPermissions) assignPermissions, (AssignPermissions_Parameters) parameters, (AssignPermissions_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      result = (AssignPermissions_Result) null;
      try
      {
        AssignPermissionsMethod[] methods = new AssignPermissionsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IAssignPermissionsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        AssignPermissions_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((AssignPermissions_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AssignPermissions cdo,
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      result = (AssignPermissions_Result) null;
      try
      {
        return ((IAssignPermissionsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        AssignPermissions_Result result1;
        ResultStatus environment = this.GetEnvironment((AssignPermissions) cdo, (AssignPermissions_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      return this.GetEnvironment((AssignPermissions) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      AssignPermissions cdo,
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      result = (AssignPermissions_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignPermissionsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new AssignPermissionsMethod(cdo, AssignPermissionsMethods.ExecuteTransaction, (AssignPermissions_Parameters) null));
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
        AssignPermissions_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((AssignPermissions) cdo, (AssignPermissions_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(AssignPermissions cdo)
    {
      return this.ExecuteTransaction(cdo, (AssignPermissions_Request) null, out AssignPermissions_Result _);
    }

    public ResultStatus ExecuteTransaction(
      AssignPermissions_Request request,
      out AssignPermissions_Result result)
    {
      return this.ExecuteTransaction((AssignPermissions) null, request, out result);
    }

    public ResultStatus AddDataTransaction(AssignPermissions cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new AssignPermissionsMethod(cdo, AssignPermissionsMethods.AddDataTransaction, (AssignPermissions_Parameters) null));
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
        return this.AddDataTransaction((AssignPermissions) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
