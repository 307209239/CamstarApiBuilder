// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.OpenProcessObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class OpenProcessObjectService : ProcessObjectTxnBase
  {
    public OpenProcessObjectService(UserProfile userProfile)
    {
      this.Initialize(typeof (IOpenProcessObjectService), userProfile);
    }

    public ResultStatus CreateParametricData(
      OpenProcessObject openProcessObject,
      OpenProcessObject_Parameters parameters,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      result = (OpenProcessObject_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) openProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenProcessObjectService) this._Channel).CreateParametricData(this._UserProfile, openProcessObject, parameters, request, out result) : this.AddMethod((Method) new OpenProcessObjectMethod(openProcessObject, OpenProcessObjectMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) openProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((OpenProcessObject) null, (OpenProcessObject_Parameters) null, (OpenProcessObject_Request) null, out OpenProcessObject_Result _);
    }

    public ResultStatus CreateParametricData(OpenProcessObject openProcessObject)
    {
      return this.CreateParametricData(openProcessObject, (OpenProcessObject_Parameters) null, (OpenProcessObject_Request) null, out OpenProcessObject_Result _);
    }

    public ResultStatus CreateParametricData(
      OpenProcessObject openProcessObject,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      return this.CreateParametricData(openProcessObject, (OpenProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      OpenProcessObject openProcessObject,
      OpenProcessObject_Parameters parameters,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      result = (OpenProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) openProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenProcessObjectService) this._Channel).GetActions(this._UserProfile, openProcessObject, parameters, request, out result) : this.AddMethod((Method) new OpenProcessObjectMethod(openProcessObject, OpenProcessObjectMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) openProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((OpenProcessObject) null, (OpenProcessObject_Parameters) null, (OpenProcessObject_Request) null, out OpenProcessObject_Result _);
    }

    public ResultStatus GetActions(OpenProcessObject openProcessObject)
    {
      return this.GetActions(openProcessObject, (OpenProcessObject_Parameters) null, (OpenProcessObject_Request) null, out OpenProcessObject_Result _);
    }

    public ResultStatus GetActions(
      OpenProcessObject openProcessObject,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      return this.GetActions(openProcessObject, (OpenProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetDetails(
      OpenProcessObject openProcessObject,
      OpenProcessObject_Parameters parameters,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      result = (OpenProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetDetails), (DCObject) openProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenProcessObjectService) this._Channel).GetApprovalSheetDetails(this._UserProfile, openProcessObject, parameters, request, out result) : this.AddMethod((Method) new OpenProcessObjectMethod(openProcessObject, OpenProcessObjectMethods.GetApprovalSheetDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetDetails), res, (DCObject) openProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetDetails()
    {
      return this.GetApprovalSheetDetails((OpenProcessObject) null, (OpenProcessObject_Parameters) null, (OpenProcessObject_Request) null, out OpenProcessObject_Result _);
    }

    public ResultStatus GetApprovalSheetDetails(OpenProcessObject openProcessObject)
    {
      return this.GetApprovalSheetDetails(openProcessObject, (OpenProcessObject_Parameters) null, (OpenProcessObject_Request) null, out OpenProcessObject_Result _);
    }

    public ResultStatus GetApprovalSheetDetails(
      OpenProcessObject openProcessObject,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      return this.GetApprovalSheetDetails(openProcessObject, (OpenProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      OpenProcessObject openProcessObject,
      OpenProcessObject_Parameters parameters,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      result = (OpenProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) openProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenProcessObjectService) this._Channel).GetDataPoints(this._UserProfile, openProcessObject, parameters, request, out result) : this.AddMethod((Method) new OpenProcessObjectMethod(openProcessObject, OpenProcessObjectMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) openProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((OpenProcessObject) null, (OpenProcessObject_Parameters) null, (OpenProcessObject_Request) null, out OpenProcessObject_Result _);
    }

    public ResultStatus GetDataPoints(OpenProcessObject openProcessObject)
    {
      return this.GetDataPoints(openProcessObject, (OpenProcessObject_Parameters) null, (OpenProcessObject_Request) null, out OpenProcessObject_Result _);
    }

    public ResultStatus GetDataPoints(
      OpenProcessObject openProcessObject,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      return this.GetDataPoints(openProcessObject, (OpenProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      OpenProcessObject openProcessObject,
      OpenProcessObject_Parameters parameters,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      result = (OpenProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) openProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenProcessObjectService) this._Channel).GetWIPMsgs(this._UserProfile, openProcessObject, parameters, request, out result) : this.AddMethod((Method) new OpenProcessObjectMethod(openProcessObject, OpenProcessObjectMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) openProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((OpenProcessObject) null, (OpenProcessObject_Parameters) null, (OpenProcessObject_Request) null, out OpenProcessObject_Result _);
    }

    public ResultStatus GetWIPMsgs(OpenProcessObject openProcessObject)
    {
      return this.GetWIPMsgs(openProcessObject, (OpenProcessObject_Parameters) null, (OpenProcessObject_Request) null, out OpenProcessObject_Result _);
    }

    public ResultStatus GetWIPMsgs(
      OpenProcessObject openProcessObject,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      return this.GetWIPMsgs(openProcessObject, (OpenProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      OpenProcessObject openProcessObject,
      OpenProcessObject_Parameters parameters,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      result = (OpenProcessObject_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) openProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenProcessObjectService) this._Channel).Load(this._UserProfile, openProcessObject, parameters, request, out result) : this.AddMethod((Method) new OpenProcessObjectMethod(openProcessObject, OpenProcessObjectMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) openProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((OpenProcessObject) null, (OpenProcessObject_Parameters) null, (OpenProcessObject_Request) null, out OpenProcessObject_Result _);
    }

    public ResultStatus Load(OpenProcessObject openProcessObject)
    {
      return this.Load(openProcessObject, (OpenProcessObject_Parameters) null, (OpenProcessObject_Request) null, out OpenProcessObject_Result _);
    }

    public ResultStatus Load(
      OpenProcessObject openProcessObject,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      return this.Load(openProcessObject, (OpenProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      OpenProcessObject openProcessObject,
      OpenProcessObject_Parameters parameters,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      result = (OpenProcessObject_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) openProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenProcessObjectService) this._Channel).LoadESigDetails(this._UserProfile, openProcessObject, parameters, request, out result) : this.AddMethod((Method) new OpenProcessObjectMethod(openProcessObject, OpenProcessObjectMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) openProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((OpenProcessObject) null, (OpenProcessObject_Parameters) null, (OpenProcessObject_Request) null, out OpenProcessObject_Result _);
    }

    public ResultStatus LoadESigDetails(OpenProcessObject openProcessObject)
    {
      return this.LoadESigDetails(openProcessObject, (OpenProcessObject_Parameters) null, (OpenProcessObject_Request) null, out OpenProcessObject_Result _);
    }

    public ResultStatus LoadESigDetails(
      OpenProcessObject openProcessObject,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      return this.LoadESigDetails(openProcessObject, (OpenProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      OpenProcessObject openProcessObject,
      OpenProcessObject_Parameters parameters,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      result = (OpenProcessObject_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) openProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenProcessObjectService) this._Channel).ProcessComputation(this._UserProfile, openProcessObject, parameters, request, out result) : this.AddMethod((Method) new OpenProcessObjectMethod(openProcessObject, OpenProcessObjectMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) openProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((OpenProcessObject) null, (OpenProcessObject_Parameters) null, (OpenProcessObject_Request) null, out OpenProcessObject_Result _);
    }

    public ResultStatus ProcessComputation(OpenProcessObject openProcessObject)
    {
      return this.ProcessComputation(openProcessObject, (OpenProcessObject_Parameters) null, (OpenProcessObject_Request) null, out OpenProcessObject_Result _);
    }

    public ResultStatus ProcessComputation(
      OpenProcessObject openProcessObject,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      return this.ProcessComputation(openProcessObject, (OpenProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      OpenProcessObject openProcessObject,
      OpenProcessObject_Parameters parameters,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      result = (OpenProcessObject_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) openProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenProcessObjectService) this._Channel).ResolveParametricData(this._UserProfile, openProcessObject, parameters, request, out result) : this.AddMethod((Method) new OpenProcessObjectMethod(openProcessObject, OpenProcessObjectMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) openProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((OpenProcessObject) null, (OpenProcessObject_Parameters) null, (OpenProcessObject_Request) null, out OpenProcessObject_Result _);
    }

    public ResultStatus ResolveParametricData(OpenProcessObject openProcessObject)
    {
      return this.ResolveParametricData(openProcessObject, (OpenProcessObject_Parameters) null, (OpenProcessObject_Request) null, out OpenProcessObject_Result _);
    }

    public ResultStatus ResolveParametricData(
      OpenProcessObject openProcessObject,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      return this.ResolveParametricData(openProcessObject, (OpenProcessObject_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject openProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenProcessObject_Result result1;
        ResultStatus parametricData = this.CreateParametricData((OpenProcessObject) openProcessObject, (OpenProcessObject_Parameters) parameters, (OpenProcessObject_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject openProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenProcessObject_Result result1;
        ResultStatus actions = this.GetActions((OpenProcessObject) openProcessObject, (OpenProcessObject_Parameters) parameters, (OpenProcessObject_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject openProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenProcessObject_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((OpenProcessObject) openProcessObject, (OpenProcessObject_Parameters) parameters, (OpenProcessObject_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject openProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenProcessObject_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((OpenProcessObject) openProcessObject, (OpenProcessObject_Parameters) parameters, (OpenProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject openProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenProcessObject_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((OpenProcessObject) openProcessObject, (OpenProcessObject_Parameters) parameters, (OpenProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject openProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenProcessObject_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((OpenProcessObject) openProcessObject, (OpenProcessObject_Parameters) parameters, (OpenProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject openProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenProcessObject_Result result1;
        ResultStatus resultStatus = this.Load((OpenProcessObject) openProcessObject, (OpenProcessObject_Parameters) parameters, (OpenProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject openProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenProcessObject_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((OpenProcessObject) openProcessObject, (OpenProcessObject_Parameters) parameters, (OpenProcessObject_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      result = (OpenProcessObject_Result) null;
      try
      {
        OpenProcessObjectMethod[] methods = new OpenProcessObjectMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IOpenProcessObjectService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        OpenProcessObject_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((OpenProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OpenProcessObject cdo,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      result = (OpenProcessObject_Result) null;
      try
      {
        return ((IOpenProcessObjectService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        OpenProcessObject_Result result1;
        ResultStatus environment = this.GetEnvironment((OpenProcessObject) cdo, (OpenProcessObject_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      return this.GetEnvironment((OpenProcessObject) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      OpenProcessObject cdo,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      result = (OpenProcessObject_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenProcessObjectService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new OpenProcessObjectMethod(cdo, OpenProcessObjectMethods.ExecuteTransaction, (OpenProcessObject_Parameters) null));
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
        OpenProcessObject_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((OpenProcessObject) cdo, (OpenProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(OpenProcessObject cdo)
    {
      return this.ExecuteTransaction(cdo, (OpenProcessObject_Request) null, out OpenProcessObject_Result _);
    }

    public ResultStatus ExecuteTransaction(
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result)
    {
      return this.ExecuteTransaction((OpenProcessObject) null, request, out result);
    }

    public ResultStatus AddDataTransaction(OpenProcessObject cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new OpenProcessObjectMethod(cdo, OpenProcessObjectMethods.AddDataTransaction, (OpenProcessObject_Parameters) null));
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
        return this.AddDataTransaction((OpenProcessObject) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
