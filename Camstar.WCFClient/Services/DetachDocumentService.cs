// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DetachDocumentService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DetachDocumentService : AttachDocumentBase
  {
    public DetachDocumentService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDetachDocumentService), userProfile);
    }

    public ResultStatus CreateParametricData(
      DetachDocument detachDocument,
      DetachDocument_Parameters parameters,
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      result = (DetachDocument_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) detachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDetachDocumentService) this._Channel).CreateParametricData(this._UserProfile, detachDocument, parameters, request, out result) : this.AddMethod((Method) new DetachDocumentMethod(detachDocument, DetachDocumentMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) detachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((DetachDocument) null, (DetachDocument_Parameters) null, (DetachDocument_Request) null, out DetachDocument_Result _);
    }

    public ResultStatus CreateParametricData(DetachDocument detachDocument)
    {
      return this.CreateParametricData(detachDocument, (DetachDocument_Parameters) null, (DetachDocument_Request) null, out DetachDocument_Result _);
    }

    public ResultStatus CreateParametricData(
      DetachDocument detachDocument,
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      return this.CreateParametricData(detachDocument, (DetachDocument_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      DetachDocument detachDocument,
      DetachDocument_Parameters parameters,
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      result = (DetachDocument_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) detachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDetachDocumentService) this._Channel).GetActions(this._UserProfile, detachDocument, parameters, request, out result) : this.AddMethod((Method) new DetachDocumentMethod(detachDocument, DetachDocumentMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) detachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((DetachDocument) null, (DetachDocument_Parameters) null, (DetachDocument_Request) null, out DetachDocument_Result _);
    }

    public ResultStatus GetActions(DetachDocument detachDocument)
    {
      return this.GetActions(detachDocument, (DetachDocument_Parameters) null, (DetachDocument_Request) null, out DetachDocument_Result _);
    }

    public ResultStatus GetActions(
      DetachDocument detachDocument,
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      return this.GetActions(detachDocument, (DetachDocument_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      DetachDocument detachDocument,
      DetachDocument_Parameters parameters,
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      result = (DetachDocument_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) detachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDetachDocumentService) this._Channel).GetDataPoints(this._UserProfile, detachDocument, parameters, request, out result) : this.AddMethod((Method) new DetachDocumentMethod(detachDocument, DetachDocumentMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) detachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((DetachDocument) null, (DetachDocument_Parameters) null, (DetachDocument_Request) null, out DetachDocument_Result _);
    }

    public ResultStatus GetDataPoints(DetachDocument detachDocument)
    {
      return this.GetDataPoints(detachDocument, (DetachDocument_Parameters) null, (DetachDocument_Request) null, out DetachDocument_Result _);
    }

    public ResultStatus GetDataPoints(
      DetachDocument detachDocument,
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      return this.GetDataPoints(detachDocument, (DetachDocument_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DetachDocument detachDocument,
      DetachDocument_Parameters parameters,
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      result = (DetachDocument_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) detachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDetachDocumentService) this._Channel).GetWIPMsgs(this._UserProfile, detachDocument, parameters, request, out result) : this.AddMethod((Method) new DetachDocumentMethod(detachDocument, DetachDocumentMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) detachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DetachDocument) null, (DetachDocument_Parameters) null, (DetachDocument_Request) null, out DetachDocument_Result _);
    }

    public ResultStatus GetWIPMsgs(DetachDocument detachDocument)
    {
      return this.GetWIPMsgs(detachDocument, (DetachDocument_Parameters) null, (DetachDocument_Request) null, out DetachDocument_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DetachDocument detachDocument,
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      return this.GetWIPMsgs(detachDocument, (DetachDocument_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DetachDocument detachDocument,
      DetachDocument_Parameters parameters,
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      result = (DetachDocument_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) detachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDetachDocumentService) this._Channel).Load(this._UserProfile, detachDocument, parameters, request, out result) : this.AddMethod((Method) new DetachDocumentMethod(detachDocument, DetachDocumentMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) detachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DetachDocument) null, (DetachDocument_Parameters) null, (DetachDocument_Request) null, out DetachDocument_Result _);
    }

    public ResultStatus Load(DetachDocument detachDocument)
    {
      return this.Load(detachDocument, (DetachDocument_Parameters) null, (DetachDocument_Request) null, out DetachDocument_Result _);
    }

    public ResultStatus Load(
      DetachDocument detachDocument,
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      return this.Load(detachDocument, (DetachDocument_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DetachDocument detachDocument,
      DetachDocument_LoadESigDetails_Parameters parameters,
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      result = (DetachDocument_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) detachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDetachDocumentService) this._Channel).LoadESigDetails(this._UserProfile, detachDocument, parameters, request, out result) : this.AddMethod((Method) new DetachDocumentMethod(detachDocument, DetachDocumentMethods.LoadESigDetails, (DetachDocument_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) detachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DetachDocument) null, (DetachDocument_LoadESigDetails_Parameters) null, (DetachDocument_Request) null, out DetachDocument_Result _);
    }

    public ResultStatus LoadESigDetails(DetachDocument detachDocument)
    {
      return this.LoadESigDetails(detachDocument, (DetachDocument_LoadESigDetails_Parameters) null, (DetachDocument_Request) null, out DetachDocument_Result _);
    }

    public ResultStatus LoadESigDetails(
      DetachDocument detachDocument,
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      return this.LoadESigDetails(detachDocument, (DetachDocument_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      DetachDocument detachDocument,
      DetachDocument_Parameters parameters,
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      result = (DetachDocument_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) detachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDetachDocumentService) this._Channel).ProcessComputation(this._UserProfile, detachDocument, parameters, request, out result) : this.AddMethod((Method) new DetachDocumentMethod(detachDocument, DetachDocumentMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) detachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((DetachDocument) null, (DetachDocument_Parameters) null, (DetachDocument_Request) null, out DetachDocument_Result _);
    }

    public ResultStatus ProcessComputation(DetachDocument detachDocument)
    {
      return this.ProcessComputation(detachDocument, (DetachDocument_Parameters) null, (DetachDocument_Request) null, out DetachDocument_Result _);
    }

    public ResultStatus ProcessComputation(
      DetachDocument detachDocument,
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      return this.ProcessComputation(detachDocument, (DetachDocument_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      DetachDocument detachDocument,
      DetachDocument_Parameters parameters,
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      result = (DetachDocument_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) detachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDetachDocumentService) this._Channel).ResolveParametricData(this._UserProfile, detachDocument, parameters, request, out result) : this.AddMethod((Method) new DetachDocumentMethod(detachDocument, DetachDocumentMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) detachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((DetachDocument) null, (DetachDocument_Parameters) null, (DetachDocument_Request) null, out DetachDocument_Result _);
    }

    public ResultStatus ResolveParametricData(DetachDocument detachDocument)
    {
      return this.ResolveParametricData(detachDocument, (DetachDocument_Parameters) null, (DetachDocument_Request) null, out DetachDocument_Result _);
    }

    public ResultStatus ResolveParametricData(
      DetachDocument detachDocument,
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      return this.ResolveParametricData(detachDocument, (DetachDocument_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject detachDocument,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DetachDocument_Result result1;
        ResultStatus parametricData = this.CreateParametricData((DetachDocument) detachDocument, (DetachDocument_Parameters) parameters, (DetachDocument_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject detachDocument,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DetachDocument_Result result1;
        ResultStatus actions = this.GetActions((DetachDocument) detachDocument, (DetachDocument_Parameters) parameters, (DetachDocument_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject detachDocument,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DetachDocument_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((DetachDocument) detachDocument, (DetachDocument_Parameters) parameters, (DetachDocument_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject detachDocument,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DetachDocument_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DetachDocument) detachDocument, (DetachDocument_LoadESigDetails_Parameters) parameters, (DetachDocument_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject detachDocument,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DetachDocument_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((DetachDocument) detachDocument, (DetachDocument_Parameters) parameters, (DetachDocument_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject detachDocument,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DetachDocument_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((DetachDocument) detachDocument, (DetachDocument_Parameters) parameters, (DetachDocument_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject detachDocument,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DetachDocument_Result result1;
        ResultStatus resultStatus = this.Load((DetachDocument) detachDocument, (DetachDocument_Parameters) parameters, (DetachDocument_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject detachDocument,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DetachDocument_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DetachDocument) detachDocument, (DetachDocument_Parameters) parameters, (DetachDocument_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      result = (DetachDocument_Result) null;
      try
      {
        DetachDocumentMethod[] methods = new DetachDocumentMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDetachDocumentService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DetachDocument_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DetachDocument_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DetachDocument cdo,
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      result = (DetachDocument_Result) null;
      try
      {
        return ((IDetachDocumentService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DetachDocument_Result result1;
        ResultStatus environment = this.GetEnvironment((DetachDocument) cdo, (DetachDocument_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      return this.GetEnvironment((DetachDocument) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DetachDocument cdo,
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      result = (DetachDocument_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDetachDocumentService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DetachDocumentMethod(cdo, DetachDocumentMethods.ExecuteTransaction, (DetachDocument_Parameters) null));
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
        DetachDocument_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DetachDocument) cdo, (DetachDocument_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DetachDocument cdo)
    {
      return this.ExecuteTransaction(cdo, (DetachDocument_Request) null, out DetachDocument_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DetachDocument_Request request,
      out DetachDocument_Result result)
    {
      return this.ExecuteTransaction((DetachDocument) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DetachDocument cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DetachDocumentMethod(cdo, DetachDocumentMethods.AddDataTransaction, (DetachDocument_Parameters) null));
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
        return this.AddDataTransaction((DetachDocument) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
