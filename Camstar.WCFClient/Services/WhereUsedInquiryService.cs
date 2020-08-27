// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.WhereUsedInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class WhereUsedInquiryService : InquiryBase
  {
    public WhereUsedInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IWhereUsedInquiryService), userProfile);
    }

    public ResultStatus GetConfig(
      WhereUsedInquiry whereUsedInquiry,
      WhereUsedInquiry_GetConfig_Parameters parameters,
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result)
    {
      result = (WhereUsedInquiry_Result) null;
      this.OnBeforeCall(nameof (GetConfig), (DCObject) whereUsedInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWhereUsedInquiryService) this._Channel).GetConfig(this._UserProfile, whereUsedInquiry, parameters, request, out result) : this.AddMethod((Method) new WhereUsedInquiryMethod(whereUsedInquiry, WhereUsedInquiryMethods.GetConfig, (WhereUsedInquiry_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetConfig), res, (DCObject) whereUsedInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetConfig()
    {
      return this.GetConfig((WhereUsedInquiry) null, (WhereUsedInquiry_GetConfig_Parameters) null, (WhereUsedInquiry_Request) null, out WhereUsedInquiry_Result _);
    }

    public ResultStatus GetConfig(WhereUsedInquiry whereUsedInquiry)
    {
      return this.GetConfig(whereUsedInquiry, (WhereUsedInquiry_GetConfig_Parameters) null, (WhereUsedInquiry_Request) null, out WhereUsedInquiry_Result _);
    }

    public ResultStatus GetConfig(
      WhereUsedInquiry whereUsedInquiry,
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result)
    {
      return this.GetConfig(whereUsedInquiry, (WhereUsedInquiry_GetConfig_Parameters) null, request, out result);
    }

    public ResultStatus GetResult_NDO(
      WhereUsedInquiry whereUsedInquiry,
      WhereUsedInquiry_Parameters parameters,
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result)
    {
      result = (WhereUsedInquiry_Result) null;
      this.OnBeforeCall(nameof (GetResult_NDO), (DCObject) whereUsedInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWhereUsedInquiryService) this._Channel).GetResult_NDO(this._UserProfile, whereUsedInquiry, parameters, request, out result) : this.AddMethod((Method) new WhereUsedInquiryMethod(whereUsedInquiry, WhereUsedInquiryMethods.GetResult_NDO, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetResult_NDO), res, (DCObject) whereUsedInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetResult_NDO()
    {
      return this.GetResult_NDO((WhereUsedInquiry) null, (WhereUsedInquiry_Parameters) null, (WhereUsedInquiry_Request) null, out WhereUsedInquiry_Result _);
    }

    public ResultStatus GetResult_NDO(WhereUsedInquiry whereUsedInquiry)
    {
      return this.GetResult_NDO(whereUsedInquiry, (WhereUsedInquiry_Parameters) null, (WhereUsedInquiry_Request) null, out WhereUsedInquiry_Result _);
    }

    public ResultStatus GetResult_NDO(
      WhereUsedInquiry whereUsedInquiry,
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result)
    {
      return this.GetResult_NDO(whereUsedInquiry, (WhereUsedInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetResult_RO(
      WhereUsedInquiry whereUsedInquiry,
      WhereUsedInquiry_Parameters parameters,
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result)
    {
      result = (WhereUsedInquiry_Result) null;
      this.OnBeforeCall(nameof (GetResult_RO), (DCObject) whereUsedInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWhereUsedInquiryService) this._Channel).GetResult_RO(this._UserProfile, whereUsedInquiry, parameters, request, out result) : this.AddMethod((Method) new WhereUsedInquiryMethod(whereUsedInquiry, WhereUsedInquiryMethods.GetResult_RO, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetResult_RO), res, (DCObject) whereUsedInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetResult_RO()
    {
      return this.GetResult_RO((WhereUsedInquiry) null, (WhereUsedInquiry_Parameters) null, (WhereUsedInquiry_Request) null, out WhereUsedInquiry_Result _);
    }

    public ResultStatus GetResult_RO(WhereUsedInquiry whereUsedInquiry)
    {
      return this.GetResult_RO(whereUsedInquiry, (WhereUsedInquiry_Parameters) null, (WhereUsedInquiry_Request) null, out WhereUsedInquiry_Result _);
    }

    public ResultStatus GetResult_RO(
      WhereUsedInquiry whereUsedInquiry,
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result)
    {
      return this.GetResult_RO(whereUsedInquiry, (WhereUsedInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      WhereUsedInquiry whereUsedInquiry,
      WhereUsedInquiry_Parameters parameters,
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result)
    {
      result = (WhereUsedInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) whereUsedInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWhereUsedInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, whereUsedInquiry, parameters, request, out result) : this.AddMethod((Method) new WhereUsedInquiryMethod(whereUsedInquiry, WhereUsedInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) whereUsedInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((WhereUsedInquiry) null, (WhereUsedInquiry_Parameters) null, (WhereUsedInquiry_Request) null, out WhereUsedInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(WhereUsedInquiry whereUsedInquiry)
    {
      return this.GetWIPMsgs(whereUsedInquiry, (WhereUsedInquiry_Parameters) null, (WhereUsedInquiry_Request) null, out WhereUsedInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      WhereUsedInquiry whereUsedInquiry,
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result)
    {
      return this.GetWIPMsgs(whereUsedInquiry, (WhereUsedInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject whereUsedInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WhereUsedInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((WhereUsedInquiry) whereUsedInquiry, (WhereUsedInquiry_Parameters) parameters, (WhereUsedInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result)
    {
      result = (WhereUsedInquiry_Result) null;
      try
      {
        WhereUsedInquiryMethod[] methods = new WhereUsedInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IWhereUsedInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        WhereUsedInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((WhereUsedInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      WhereUsedInquiry cdo,
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result)
    {
      result = (WhereUsedInquiry_Result) null;
      try
      {
        return ((IWhereUsedInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        WhereUsedInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((WhereUsedInquiry) cdo, (WhereUsedInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result)
    {
      return this.GetEnvironment((WhereUsedInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      WhereUsedInquiry cdo,
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result)
    {
      result = (WhereUsedInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWhereUsedInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new WhereUsedInquiryMethod(cdo, WhereUsedInquiryMethods.ExecuteTransaction, (WhereUsedInquiry_Parameters) null));
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
        WhereUsedInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((WhereUsedInquiry) cdo, (WhereUsedInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(WhereUsedInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (WhereUsedInquiry_Request) null, out WhereUsedInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result)
    {
      return this.ExecuteTransaction((WhereUsedInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(WhereUsedInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new WhereUsedInquiryMethod(cdo, WhereUsedInquiryMethods.AddDataTransaction, (WhereUsedInquiry_Parameters) null));
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
        return this.AddDataTransaction((WhereUsedInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
