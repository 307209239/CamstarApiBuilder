// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DocAttachmentsTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DocAttachmentsTxnService : ShopFloorBase
  {
    public DocAttachmentsTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDocAttachmentsTxnService), userProfile);
    }

    public ResultStatus CreateParametricData(
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Parameters parameters,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      result = (DocAttachmentsTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) docAttachmentsTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocAttachmentsTxnService) this._Channel).CreateParametricData(this._UserProfile, docAttachmentsTxn, parameters, request, out result) : this.AddMethod((Method) new DocAttachmentsTxnMethod(docAttachmentsTxn, DocAttachmentsTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) docAttachmentsTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((DocAttachmentsTxn) null, (DocAttachmentsTxn_Parameters) null, (DocAttachmentsTxn_Request) null, out DocAttachmentsTxn_Result _);
    }

    public ResultStatus CreateParametricData(DocAttachmentsTxn docAttachmentsTxn)
    {
      return this.CreateParametricData(docAttachmentsTxn, (DocAttachmentsTxn_Parameters) null, (DocAttachmentsTxn_Request) null, out DocAttachmentsTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      return this.CreateParametricData(docAttachmentsTxn, (DocAttachmentsTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Parameters parameters,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      result = (DocAttachmentsTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) docAttachmentsTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocAttachmentsTxnService) this._Channel).GetActions(this._UserProfile, docAttachmentsTxn, parameters, request, out result) : this.AddMethod((Method) new DocAttachmentsTxnMethod(docAttachmentsTxn, DocAttachmentsTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) docAttachmentsTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((DocAttachmentsTxn) null, (DocAttachmentsTxn_Parameters) null, (DocAttachmentsTxn_Request) null, out DocAttachmentsTxn_Result _);
    }

    public ResultStatus GetActions(DocAttachmentsTxn docAttachmentsTxn)
    {
      return this.GetActions(docAttachmentsTxn, (DocAttachmentsTxn_Parameters) null, (DocAttachmentsTxn_Request) null, out DocAttachmentsTxn_Result _);
    }

    public ResultStatus GetActions(
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      return this.GetActions(docAttachmentsTxn, (DocAttachmentsTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Parameters parameters,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      result = (DocAttachmentsTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) docAttachmentsTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocAttachmentsTxnService) this._Channel).GetDataPoints(this._UserProfile, docAttachmentsTxn, parameters, request, out result) : this.AddMethod((Method) new DocAttachmentsTxnMethod(docAttachmentsTxn, DocAttachmentsTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) docAttachmentsTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((DocAttachmentsTxn) null, (DocAttachmentsTxn_Parameters) null, (DocAttachmentsTxn_Request) null, out DocAttachmentsTxn_Result _);
    }

    public ResultStatus GetDataPoints(DocAttachmentsTxn docAttachmentsTxn)
    {
      return this.GetDataPoints(docAttachmentsTxn, (DocAttachmentsTxn_Parameters) null, (DocAttachmentsTxn_Request) null, out DocAttachmentsTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      return this.GetDataPoints(docAttachmentsTxn, (DocAttachmentsTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Parameters parameters,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      result = (DocAttachmentsTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) docAttachmentsTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocAttachmentsTxnService) this._Channel).GetWIPMsgs(this._UserProfile, docAttachmentsTxn, parameters, request, out result) : this.AddMethod((Method) new DocAttachmentsTxnMethod(docAttachmentsTxn, DocAttachmentsTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) docAttachmentsTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DocAttachmentsTxn) null, (DocAttachmentsTxn_Parameters) null, (DocAttachmentsTxn_Request) null, out DocAttachmentsTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(DocAttachmentsTxn docAttachmentsTxn)
    {
      return this.GetWIPMsgs(docAttachmentsTxn, (DocAttachmentsTxn_Parameters) null, (DocAttachmentsTxn_Request) null, out DocAttachmentsTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      return this.GetWIPMsgs(docAttachmentsTxn, (DocAttachmentsTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Parameters parameters,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      result = (DocAttachmentsTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) docAttachmentsTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocAttachmentsTxnService) this._Channel).Load(this._UserProfile, docAttachmentsTxn, parameters, request, out result) : this.AddMethod((Method) new DocAttachmentsTxnMethod(docAttachmentsTxn, DocAttachmentsTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) docAttachmentsTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DocAttachmentsTxn) null, (DocAttachmentsTxn_Parameters) null, (DocAttachmentsTxn_Request) null, out DocAttachmentsTxn_Result _);
    }

    public ResultStatus Load(DocAttachmentsTxn docAttachmentsTxn)
    {
      return this.Load(docAttachmentsTxn, (DocAttachmentsTxn_Parameters) null, (DocAttachmentsTxn_Request) null, out DocAttachmentsTxn_Result _);
    }

    public ResultStatus Load(
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      return this.Load(docAttachmentsTxn, (DocAttachmentsTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_LoadESigDetails_Parameters parameters,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      result = (DocAttachmentsTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) docAttachmentsTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocAttachmentsTxnService) this._Channel).LoadESigDetails(this._UserProfile, docAttachmentsTxn, parameters, request, out result) : this.AddMethod((Method) new DocAttachmentsTxnMethod(docAttachmentsTxn, DocAttachmentsTxnMethods.LoadESigDetails, (DocAttachmentsTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) docAttachmentsTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DocAttachmentsTxn) null, (DocAttachmentsTxn_LoadESigDetails_Parameters) null, (DocAttachmentsTxn_Request) null, out DocAttachmentsTxn_Result _);
    }

    public ResultStatus LoadESigDetails(DocAttachmentsTxn docAttachmentsTxn)
    {
      return this.LoadESigDetails(docAttachmentsTxn, (DocAttachmentsTxn_LoadESigDetails_Parameters) null, (DocAttachmentsTxn_Request) null, out DocAttachmentsTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      return this.LoadESigDetails(docAttachmentsTxn, (DocAttachmentsTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Parameters parameters,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      result = (DocAttachmentsTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) docAttachmentsTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocAttachmentsTxnService) this._Channel).ProcessComputation(this._UserProfile, docAttachmentsTxn, parameters, request, out result) : this.AddMethod((Method) new DocAttachmentsTxnMethod(docAttachmentsTxn, DocAttachmentsTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) docAttachmentsTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((DocAttachmentsTxn) null, (DocAttachmentsTxn_Parameters) null, (DocAttachmentsTxn_Request) null, out DocAttachmentsTxn_Result _);
    }

    public ResultStatus ProcessComputation(DocAttachmentsTxn docAttachmentsTxn)
    {
      return this.ProcessComputation(docAttachmentsTxn, (DocAttachmentsTxn_Parameters) null, (DocAttachmentsTxn_Request) null, out DocAttachmentsTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      return this.ProcessComputation(docAttachmentsTxn, (DocAttachmentsTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Parameters parameters,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      result = (DocAttachmentsTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) docAttachmentsTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocAttachmentsTxnService) this._Channel).ResolveParametricData(this._UserProfile, docAttachmentsTxn, parameters, request, out result) : this.AddMethod((Method) new DocAttachmentsTxnMethod(docAttachmentsTxn, DocAttachmentsTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) docAttachmentsTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((DocAttachmentsTxn) null, (DocAttachmentsTxn_Parameters) null, (DocAttachmentsTxn_Request) null, out DocAttachmentsTxn_Result _);
    }

    public ResultStatus ResolveParametricData(DocAttachmentsTxn docAttachmentsTxn)
    {
      return this.ResolveParametricData(docAttachmentsTxn, (DocAttachmentsTxn_Parameters) null, (DocAttachmentsTxn_Request) null, out DocAttachmentsTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      return this.ResolveParametricData(docAttachmentsTxn, (DocAttachmentsTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject docAttachmentsTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocAttachmentsTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((DocAttachmentsTxn) docAttachmentsTxn, (DocAttachmentsTxn_Parameters) parameters, (DocAttachmentsTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject docAttachmentsTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocAttachmentsTxn_Result result1;
        ResultStatus actions = this.GetActions((DocAttachmentsTxn) docAttachmentsTxn, (DocAttachmentsTxn_Parameters) parameters, (DocAttachmentsTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject docAttachmentsTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocAttachmentsTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((DocAttachmentsTxn) docAttachmentsTxn, (DocAttachmentsTxn_Parameters) parameters, (DocAttachmentsTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject docAttachmentsTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocAttachmentsTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DocAttachmentsTxn) docAttachmentsTxn, (DocAttachmentsTxn_LoadESigDetails_Parameters) parameters, (DocAttachmentsTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject docAttachmentsTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocAttachmentsTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((DocAttachmentsTxn) docAttachmentsTxn, (DocAttachmentsTxn_Parameters) parameters, (DocAttachmentsTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject docAttachmentsTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocAttachmentsTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((DocAttachmentsTxn) docAttachmentsTxn, (DocAttachmentsTxn_Parameters) parameters, (DocAttachmentsTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject docAttachmentsTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocAttachmentsTxn_Result result1;
        ResultStatus resultStatus = this.Load((DocAttachmentsTxn) docAttachmentsTxn, (DocAttachmentsTxn_Parameters) parameters, (DocAttachmentsTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject docAttachmentsTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocAttachmentsTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DocAttachmentsTxn) docAttachmentsTxn, (DocAttachmentsTxn_Parameters) parameters, (DocAttachmentsTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      result = (DocAttachmentsTxn_Result) null;
      try
      {
        DocAttachmentsTxnMethod[] methods = new DocAttachmentsTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDocAttachmentsTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DocAttachmentsTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DocAttachmentsTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DocAttachmentsTxn cdo,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      result = (DocAttachmentsTxn_Result) null;
      try
      {
        return ((IDocAttachmentsTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DocAttachmentsTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((DocAttachmentsTxn) cdo, (DocAttachmentsTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      return this.GetEnvironment((DocAttachmentsTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DocAttachmentsTxn cdo,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      result = (DocAttachmentsTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocAttachmentsTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DocAttachmentsTxnMethod(cdo, DocAttachmentsTxnMethods.ExecuteTransaction, (DocAttachmentsTxn_Parameters) null));
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
        DocAttachmentsTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DocAttachmentsTxn) cdo, (DocAttachmentsTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DocAttachmentsTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (DocAttachmentsTxn_Request) null, out DocAttachmentsTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result)
    {
      return this.ExecuteTransaction((DocAttachmentsTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DocAttachmentsTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DocAttachmentsTxnMethod(cdo, DocAttachmentsTxnMethods.AddDataTransaction, (DocAttachmentsTxn_Parameters) null));
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
        return this.AddDataTransaction((DocAttachmentsTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
