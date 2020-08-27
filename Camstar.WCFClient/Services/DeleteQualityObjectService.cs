// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DeleteQualityObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DeleteQualityObjectService : QualityTxnBase
  {
    public DeleteQualityObjectService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDeleteQualityObjectService), userProfile);
    }

    public ResultStatus CreateParametricData(
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Parameters parameters,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      result = (DeleteQualityObject_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) deleteQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDeleteQualityObjectService) this._Channel).CreateParametricData(this._UserProfile, deleteQualityObject, parameters, request, out result) : this.AddMethod((Method) new DeleteQualityObjectMethod(deleteQualityObject, DeleteQualityObjectMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) deleteQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((DeleteQualityObject) null, (DeleteQualityObject_Parameters) null, (DeleteQualityObject_Request) null, out DeleteQualityObject_Result _);
    }

    public ResultStatus CreateParametricData(DeleteQualityObject deleteQualityObject)
    {
      return this.CreateParametricData(deleteQualityObject, (DeleteQualityObject_Parameters) null, (DeleteQualityObject_Request) null, out DeleteQualityObject_Result _);
    }

    public ResultStatus CreateParametricData(
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      return this.CreateParametricData(deleteQualityObject, (DeleteQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus DeleteCrossReference(
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_DeleteCrossReference_Parameters parameters,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      result = (DeleteQualityObject_Result) null;
      this.OnBeforeCall(nameof (DeleteCrossReference), (DCObject) deleteQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDeleteQualityObjectService) this._Channel).DeleteCrossReference(this._UserProfile, deleteQualityObject, parameters, request, out result) : this.AddMethod((Method) new DeleteQualityObjectMethod(deleteQualityObject, DeleteQualityObjectMethods.DeleteCrossReference, (DeleteQualityObject_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteCrossReference), res, (DCObject) deleteQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteCrossReference()
    {
      return this.DeleteCrossReference((DeleteQualityObject) null, (DeleteQualityObject_DeleteCrossReference_Parameters) null, (DeleteQualityObject_Request) null, out DeleteQualityObject_Result _);
    }

    public ResultStatus DeleteCrossReference(DeleteQualityObject deleteQualityObject)
    {
      return this.DeleteCrossReference(deleteQualityObject, (DeleteQualityObject_DeleteCrossReference_Parameters) null, (DeleteQualityObject_Request) null, out DeleteQualityObject_Result _);
    }

    public ResultStatus DeleteCrossReference(
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      return this.DeleteCrossReference(deleteQualityObject, (DeleteQualityObject_DeleteCrossReference_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Parameters parameters,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      result = (DeleteQualityObject_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) deleteQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDeleteQualityObjectService) this._Channel).GetActions(this._UserProfile, deleteQualityObject, parameters, request, out result) : this.AddMethod((Method) new DeleteQualityObjectMethod(deleteQualityObject, DeleteQualityObjectMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) deleteQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((DeleteQualityObject) null, (DeleteQualityObject_Parameters) null, (DeleteQualityObject_Request) null, out DeleteQualityObject_Result _);
    }

    public ResultStatus GetActions(DeleteQualityObject deleteQualityObject)
    {
      return this.GetActions(deleteQualityObject, (DeleteQualityObject_Parameters) null, (DeleteQualityObject_Request) null, out DeleteQualityObject_Result _);
    }

    public ResultStatus GetActions(
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      return this.GetActions(deleteQualityObject, (DeleteQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Parameters parameters,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      result = (DeleteQualityObject_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) deleteQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDeleteQualityObjectService) this._Channel).GetDataPoints(this._UserProfile, deleteQualityObject, parameters, request, out result) : this.AddMethod((Method) new DeleteQualityObjectMethod(deleteQualityObject, DeleteQualityObjectMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) deleteQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((DeleteQualityObject) null, (DeleteQualityObject_Parameters) null, (DeleteQualityObject_Request) null, out DeleteQualityObject_Result _);
    }

    public ResultStatus GetDataPoints(DeleteQualityObject deleteQualityObject)
    {
      return this.GetDataPoints(deleteQualityObject, (DeleteQualityObject_Parameters) null, (DeleteQualityObject_Request) null, out DeleteQualityObject_Result _);
    }

    public ResultStatus GetDataPoints(
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      return this.GetDataPoints(deleteQualityObject, (DeleteQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Parameters parameters,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      result = (DeleteQualityObject_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) deleteQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDeleteQualityObjectService) this._Channel).GetWIPMsgs(this._UserProfile, deleteQualityObject, parameters, request, out result) : this.AddMethod((Method) new DeleteQualityObjectMethod(deleteQualityObject, DeleteQualityObjectMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) deleteQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DeleteQualityObject) null, (DeleteQualityObject_Parameters) null, (DeleteQualityObject_Request) null, out DeleteQualityObject_Result _);
    }

    public ResultStatus GetWIPMsgs(DeleteQualityObject deleteQualityObject)
    {
      return this.GetWIPMsgs(deleteQualityObject, (DeleteQualityObject_Parameters) null, (DeleteQualityObject_Request) null, out DeleteQualityObject_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      return this.GetWIPMsgs(deleteQualityObject, (DeleteQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Parameters parameters,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      result = (DeleteQualityObject_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) deleteQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDeleteQualityObjectService) this._Channel).Load(this._UserProfile, deleteQualityObject, parameters, request, out result) : this.AddMethod((Method) new DeleteQualityObjectMethod(deleteQualityObject, DeleteQualityObjectMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) deleteQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DeleteQualityObject) null, (DeleteQualityObject_Parameters) null, (DeleteQualityObject_Request) null, out DeleteQualityObject_Result _);
    }

    public ResultStatus Load(DeleteQualityObject deleteQualityObject)
    {
      return this.Load(deleteQualityObject, (DeleteQualityObject_Parameters) null, (DeleteQualityObject_Request) null, out DeleteQualityObject_Result _);
    }

    public ResultStatus Load(
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      return this.Load(deleteQualityObject, (DeleteQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Parameters parameters,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      result = (DeleteQualityObject_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) deleteQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDeleteQualityObjectService) this._Channel).LoadESigDetails(this._UserProfile, deleteQualityObject, parameters, request, out result) : this.AddMethod((Method) new DeleteQualityObjectMethod(deleteQualityObject, DeleteQualityObjectMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) deleteQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DeleteQualityObject) null, (DeleteQualityObject_Parameters) null, (DeleteQualityObject_Request) null, out DeleteQualityObject_Result _);
    }

    public ResultStatus LoadESigDetails(DeleteQualityObject deleteQualityObject)
    {
      return this.LoadESigDetails(deleteQualityObject, (DeleteQualityObject_Parameters) null, (DeleteQualityObject_Request) null, out DeleteQualityObject_Result _);
    }

    public ResultStatus LoadESigDetails(
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      return this.LoadESigDetails(deleteQualityObject, (DeleteQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Parameters parameters,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      result = (DeleteQualityObject_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) deleteQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDeleteQualityObjectService) this._Channel).ProcessComputation(this._UserProfile, deleteQualityObject, parameters, request, out result) : this.AddMethod((Method) new DeleteQualityObjectMethod(deleteQualityObject, DeleteQualityObjectMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) deleteQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((DeleteQualityObject) null, (DeleteQualityObject_Parameters) null, (DeleteQualityObject_Request) null, out DeleteQualityObject_Result _);
    }

    public ResultStatus ProcessComputation(DeleteQualityObject deleteQualityObject)
    {
      return this.ProcessComputation(deleteQualityObject, (DeleteQualityObject_Parameters) null, (DeleteQualityObject_Request) null, out DeleteQualityObject_Result _);
    }

    public ResultStatus ProcessComputation(
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      return this.ProcessComputation(deleteQualityObject, (DeleteQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Parameters parameters,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      result = (DeleteQualityObject_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) deleteQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDeleteQualityObjectService) this._Channel).ResolveParametricData(this._UserProfile, deleteQualityObject, parameters, request, out result) : this.AddMethod((Method) new DeleteQualityObjectMethod(deleteQualityObject, DeleteQualityObjectMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) deleteQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((DeleteQualityObject) null, (DeleteQualityObject_Parameters) null, (DeleteQualityObject_Request) null, out DeleteQualityObject_Result _);
    }

    public ResultStatus ResolveParametricData(DeleteQualityObject deleteQualityObject)
    {
      return this.ResolveParametricData(deleteQualityObject, (DeleteQualityObject_Parameters) null, (DeleteQualityObject_Request) null, out DeleteQualityObject_Result _);
    }

    public ResultStatus ResolveParametricData(
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      return this.ResolveParametricData(deleteQualityObject, (DeleteQualityObject_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject deleteQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DeleteQualityObject_Result result1;
        ResultStatus parametricData = this.CreateParametricData((DeleteQualityObject) deleteQualityObject, (DeleteQualityObject_Parameters) parameters, (DeleteQualityObject_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject deleteQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DeleteQualityObject_Result result1;
        ResultStatus actions = this.GetActions((DeleteQualityObject) deleteQualityObject, (DeleteQualityObject_Parameters) parameters, (DeleteQualityObject_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject deleteQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DeleteQualityObject_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((DeleteQualityObject) deleteQualityObject, (DeleteQualityObject_Parameters) parameters, (DeleteQualityObject_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject deleteQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DeleteQualityObject_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DeleteQualityObject) deleteQualityObject, (DeleteQualityObject_Parameters) parameters, (DeleteQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject deleteQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DeleteQualityObject_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((DeleteQualityObject) deleteQualityObject, (DeleteQualityObject_Parameters) parameters, (DeleteQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject deleteQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DeleteQualityObject_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((DeleteQualityObject) deleteQualityObject, (DeleteQualityObject_Parameters) parameters, (DeleteQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject deleteQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DeleteQualityObject_Result result1;
        ResultStatus resultStatus = this.Load((DeleteQualityObject) deleteQualityObject, (DeleteQualityObject_Parameters) parameters, (DeleteQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject deleteQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DeleteQualityObject_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DeleteQualityObject) deleteQualityObject, (DeleteQualityObject_Parameters) parameters, (DeleteQualityObject_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      result = (DeleteQualityObject_Result) null;
      try
      {
        DeleteQualityObjectMethod[] methods = new DeleteQualityObjectMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDeleteQualityObjectService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DeleteQualityObject_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DeleteQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DeleteQualityObject cdo,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      result = (DeleteQualityObject_Result) null;
      try
      {
        return ((IDeleteQualityObjectService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DeleteQualityObject_Result result1;
        ResultStatus environment = this.GetEnvironment((DeleteQualityObject) cdo, (DeleteQualityObject_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      return this.GetEnvironment((DeleteQualityObject) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DeleteQualityObject cdo,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      result = (DeleteQualityObject_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDeleteQualityObjectService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DeleteQualityObjectMethod(cdo, DeleteQualityObjectMethods.ExecuteTransaction, (DeleteQualityObject_Parameters) null));
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
        DeleteQualityObject_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DeleteQualityObject) cdo, (DeleteQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DeleteQualityObject cdo)
    {
      return this.ExecuteTransaction(cdo, (DeleteQualityObject_Request) null, out DeleteQualityObject_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result)
    {
      return this.ExecuteTransaction((DeleteQualityObject) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DeleteQualityObject cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DeleteQualityObjectMethod(cdo, DeleteQualityObjectMethods.AddDataTransaction, (DeleteQualityObject_Parameters) null));
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
        return this.AddDataTransaction((DeleteQualityObject) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
