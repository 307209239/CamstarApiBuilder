// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResponseSetMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ResponseSetMaintService : NamedDataObjectMaintBase
  {
    public ResponseSetMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IResponseSetMaintService), userProfile);
    }

    public ResultStatus Delete(
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Parameters parameters,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      result = (ResponseSetMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) responseSetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResponseSetMaintService) this._Channel).Delete(this._UserProfile, responseSetMaint, parameters, request, out result) : this.AddMethod((Method) new ResponseSetMaintMethod(responseSetMaint, ResponseSetMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) responseSetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ResponseSetMaint) null, (ResponseSetMaint_Parameters) null, (ResponseSetMaint_Request) null, out ResponseSetMaint_Result _);
    }

    public ResultStatus Delete(ResponseSetMaint responseSetMaint)
    {
      return this.Delete(responseSetMaint, (ResponseSetMaint_Parameters) null, (ResponseSetMaint_Request) null, out ResponseSetMaint_Result _);
    }

    public ResultStatus Delete(
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      return this.Delete(responseSetMaint, (ResponseSetMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Parameters parameters,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      result = (ResponseSetMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) responseSetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResponseSetMaintService) this._Channel).Freeze(this._UserProfile, responseSetMaint, parameters, request, out result) : this.AddMethod((Method) new ResponseSetMaintMethod(responseSetMaint, ResponseSetMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) responseSetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ResponseSetMaint) null, (ResponseSetMaint_Parameters) null, (ResponseSetMaint_Request) null, out ResponseSetMaint_Result _);
    }

    public ResultStatus Freeze(ResponseSetMaint responseSetMaint)
    {
      return this.Freeze(responseSetMaint, (ResponseSetMaint_Parameters) null, (ResponseSetMaint_Request) null, out ResponseSetMaint_Result _);
    }

    public ResultStatus Freeze(
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      return this.Freeze(responseSetMaint, (ResponseSetMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Parameters parameters,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      result = (ResponseSetMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) responseSetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResponseSetMaintService) this._Channel).GetWIPMsgs(this._UserProfile, responseSetMaint, parameters, request, out result) : this.AddMethod((Method) new ResponseSetMaintMethod(responseSetMaint, ResponseSetMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) responseSetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ResponseSetMaint) null, (ResponseSetMaint_Parameters) null, (ResponseSetMaint_Request) null, out ResponseSetMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ResponseSetMaint responseSetMaint)
    {
      return this.GetWIPMsgs(responseSetMaint, (ResponseSetMaint_Parameters) null, (ResponseSetMaint_Request) null, out ResponseSetMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      return this.GetWIPMsgs(responseSetMaint, (ResponseSetMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Parameters parameters,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      result = (ResponseSetMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) responseSetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResponseSetMaintService) this._Channel).Load(this._UserProfile, responseSetMaint, parameters, request, out result) : this.AddMethod((Method) new ResponseSetMaintMethod(responseSetMaint, ResponseSetMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) responseSetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ResponseSetMaint) null, (ResponseSetMaint_Parameters) null, (ResponseSetMaint_Request) null, out ResponseSetMaint_Result _);
    }

    public ResultStatus Load(ResponseSetMaint responseSetMaint)
    {
      return this.Load(responseSetMaint, (ResponseSetMaint_Parameters) null, (ResponseSetMaint_Request) null, out ResponseSetMaint_Result _);
    }

    public ResultStatus Load(
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      return this.Load(responseSetMaint, (ResponseSetMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_LoadESigDetails_Parameters parameters,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      result = (ResponseSetMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) responseSetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResponseSetMaintService) this._Channel).LoadESigDetails(this._UserProfile, responseSetMaint, parameters, request, out result) : this.AddMethod((Method) new ResponseSetMaintMethod(responseSetMaint, ResponseSetMaintMethods.LoadESigDetails, (ResponseSetMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) responseSetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ResponseSetMaint) null, (ResponseSetMaint_LoadESigDetails_Parameters) null, (ResponseSetMaint_Request) null, out ResponseSetMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ResponseSetMaint responseSetMaint)
    {
      return this.LoadESigDetails(responseSetMaint, (ResponseSetMaint_LoadESigDetails_Parameters) null, (ResponseSetMaint_Request) null, out ResponseSetMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      return this.LoadESigDetails(responseSetMaint, (ResponseSetMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Parameters parameters,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      result = (ResponseSetMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) responseSetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResponseSetMaintService) this._Channel).New(this._UserProfile, responseSetMaint, parameters, request, out result) : this.AddMethod((Method) new ResponseSetMaintMethod(responseSetMaint, ResponseSetMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) responseSetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ResponseSetMaint) null, (ResponseSetMaint_Parameters) null, (ResponseSetMaint_Request) null, out ResponseSetMaint_Result _);
    }

    public ResultStatus New(ResponseSetMaint responseSetMaint)
    {
      return this.New(responseSetMaint, (ResponseSetMaint_Parameters) null, (ResponseSetMaint_Request) null, out ResponseSetMaint_Result _);
    }

    public ResultStatus New(
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      return this.New(responseSetMaint, (ResponseSetMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Parameters parameters,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      result = (ResponseSetMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) responseSetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResponseSetMaintService) this._Channel).NewCopy(this._UserProfile, responseSetMaint, parameters, request, out result) : this.AddMethod((Method) new ResponseSetMaintMethod(responseSetMaint, ResponseSetMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) responseSetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ResponseSetMaint) null, (ResponseSetMaint_Parameters) null, (ResponseSetMaint_Request) null, out ResponseSetMaint_Result _);
    }

    public ResultStatus NewCopy(ResponseSetMaint responseSetMaint)
    {
      return this.NewCopy(responseSetMaint, (ResponseSetMaint_Parameters) null, (ResponseSetMaint_Request) null, out ResponseSetMaint_Result _);
    }

    public ResultStatus NewCopy(
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      return this.NewCopy(responseSetMaint, (ResponseSetMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Parameters parameters,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      result = (ResponseSetMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) responseSetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResponseSetMaintService) this._Channel).SaveAs(this._UserProfile, responseSetMaint, parameters, request, out result) : this.AddMethod((Method) new ResponseSetMaintMethod(responseSetMaint, ResponseSetMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) responseSetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ResponseSetMaint) null, (ResponseSetMaint_Parameters) null, (ResponseSetMaint_Request) null, out ResponseSetMaint_Result _);
    }

    public ResultStatus SaveAs(ResponseSetMaint responseSetMaint)
    {
      return this.SaveAs(responseSetMaint, (ResponseSetMaint_Parameters) null, (ResponseSetMaint_Request) null, out ResponseSetMaint_Result _);
    }

    public ResultStatus SaveAs(
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      return this.SaveAs(responseSetMaint, (ResponseSetMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Parameters parameters,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      result = (ResponseSetMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) responseSetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResponseSetMaintService) this._Channel).UnFreeze(this._UserProfile, responseSetMaint, parameters, request, out result) : this.AddMethod((Method) new ResponseSetMaintMethod(responseSetMaint, ResponseSetMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) responseSetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ResponseSetMaint) null, (ResponseSetMaint_Parameters) null, (ResponseSetMaint_Request) null, out ResponseSetMaint_Result _);
    }

    public ResultStatus UnFreeze(ResponseSetMaint responseSetMaint)
    {
      return this.UnFreeze(responseSetMaint, (ResponseSetMaint_Parameters) null, (ResponseSetMaint_Request) null, out ResponseSetMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      return this.UnFreeze(responseSetMaint, (ResponseSetMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject responseSetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResponseSetMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ResponseSetMaint) responseSetMaint, (ResponseSetMaint_Parameters) parameters, (ResponseSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject responseSetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResponseSetMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ResponseSetMaint) responseSetMaint, (ResponseSetMaint_Parameters) parameters, (ResponseSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject responseSetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResponseSetMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ResponseSetMaint) responseSetMaint, (ResponseSetMaint_LoadESigDetails_Parameters) parameters, (ResponseSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject responseSetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResponseSetMaint_Result result1;
        ResultStatus resultStatus = this.New((ResponseSetMaint) responseSetMaint, (ResponseSetMaint_Parameters) parameters, (ResponseSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject responseSetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResponseSetMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ResponseSetMaint) responseSetMaint, (ResponseSetMaint_Parameters) parameters, (ResponseSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject responseSetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResponseSetMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ResponseSetMaint) responseSetMaint, (ResponseSetMaint_Parameters) parameters, (ResponseSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject responseSetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResponseSetMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ResponseSetMaint) responseSetMaint, (ResponseSetMaint_Parameters) parameters, (ResponseSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject responseSetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResponseSetMaint_Result result1;
        ResultStatus resultStatus = this.Load((ResponseSetMaint) responseSetMaint, (ResponseSetMaint_Parameters) parameters, (ResponseSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject responseSetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResponseSetMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ResponseSetMaint) responseSetMaint, (ResponseSetMaint_Parameters) parameters, (ResponseSetMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      result = (ResponseSetMaint_Result) null;
      try
      {
        ResponseSetMaintMethod[] methods = new ResponseSetMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IResponseSetMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ResponseSetMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ResponseSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResponseSetMaint cdo,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      result = (ResponseSetMaint_Result) null;
      try
      {
        return ((IResponseSetMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ResponseSetMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ResponseSetMaint) cdo, (ResponseSetMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      return this.GetEnvironment((ResponseSetMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ResponseSetMaint cdo,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      result = (ResponseSetMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResponseSetMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ResponseSetMaintMethod(cdo, ResponseSetMaintMethods.ExecuteTransaction, (ResponseSetMaint_Parameters) null));
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
        ResponseSetMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ResponseSetMaint) cdo, (ResponseSetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ResponseSetMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ResponseSetMaint_Request) null, out ResponseSetMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result)
    {
      return this.ExecuteTransaction((ResponseSetMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ResponseSetMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ResponseSetMaintMethod(cdo, ResponseSetMaintMethods.AddDataTransaction, (ResponseSetMaint_Parameters) null));
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
        return this.AddDataTransaction((ResponseSetMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
