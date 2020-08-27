// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.FilterTagInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class FilterTagInquiryService : InquiryBase
  {
    public FilterTagInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IFilterTagInquiryService), userProfile);
    }

    public ResultStatus GetEmpFilterTags(
      FilterTagInquiry filterTagInquiry,
      FilterTagInquiry_Parameters parameters,
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result)
    {
      result = (FilterTagInquiry_Result) null;
      this.OnBeforeCall(nameof (GetEmpFilterTags), (DCObject) filterTagInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFilterTagInquiryService) this._Channel).GetEmpFilterTags(this._UserProfile, filterTagInquiry, parameters, request, out result) : this.AddMethod((Method) new FilterTagInquiryMethod(filterTagInquiry, FilterTagInquiryMethods.GetEmpFilterTags, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetEmpFilterTags), res, (DCObject) filterTagInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetEmpFilterTags()
    {
      return this.GetEmpFilterTags((FilterTagInquiry) null, (FilterTagInquiry_Parameters) null, (FilterTagInquiry_Request) null, out FilterTagInquiry_Result _);
    }

    public ResultStatus GetEmpFilterTags(FilterTagInquiry filterTagInquiry)
    {
      return this.GetEmpFilterTags(filterTagInquiry, (FilterTagInquiry_Parameters) null, (FilterTagInquiry_Request) null, out FilterTagInquiry_Result _);
    }

    public ResultStatus GetEmpFilterTags(
      FilterTagInquiry filterTagInquiry,
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result)
    {
      return this.GetEmpFilterTags(filterTagInquiry, (FilterTagInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetEmpSessionFilterTags(
      FilterTagInquiry filterTagInquiry,
      FilterTagInquiry_Parameters parameters,
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result)
    {
      result = (FilterTagInquiry_Result) null;
      this.OnBeforeCall(nameof (GetEmpSessionFilterTags), (DCObject) filterTagInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFilterTagInquiryService) this._Channel).GetEmpSessionFilterTags(this._UserProfile, filterTagInquiry, parameters, request, out result) : this.AddMethod((Method) new FilterTagInquiryMethod(filterTagInquiry, FilterTagInquiryMethods.GetEmpSessionFilterTags, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetEmpSessionFilterTags), res, (DCObject) filterTagInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetEmpSessionFilterTags()
    {
      return this.GetEmpSessionFilterTags((FilterTagInquiry) null, (FilterTagInquiry_Parameters) null, (FilterTagInquiry_Request) null, out FilterTagInquiry_Result _);
    }

    public ResultStatus GetEmpSessionFilterTags(FilterTagInquiry filterTagInquiry)
    {
      return this.GetEmpSessionFilterTags(filterTagInquiry, (FilterTagInquiry_Parameters) null, (FilterTagInquiry_Request) null, out FilterTagInquiry_Result _);
    }

    public ResultStatus GetEmpSessionFilterTags(
      FilterTagInquiry filterTagInquiry,
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result)
    {
      return this.GetEmpSessionFilterTags(filterTagInquiry, (FilterTagInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetFilterTags(
      FilterTagInquiry filterTagInquiry,
      FilterTagInquiry_Parameters parameters,
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result)
    {
      result = (FilterTagInquiry_Result) null;
      this.OnBeforeCall(nameof (GetFilterTags), (DCObject) filterTagInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFilterTagInquiryService) this._Channel).GetFilterTags(this._UserProfile, filterTagInquiry, parameters, request, out result) : this.AddMethod((Method) new FilterTagInquiryMethod(filterTagInquiry, FilterTagInquiryMethods.GetFilterTags, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetFilterTags), res, (DCObject) filterTagInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetFilterTags()
    {
      return this.GetFilterTags((FilterTagInquiry) null, (FilterTagInquiry_Parameters) null, (FilterTagInquiry_Request) null, out FilterTagInquiry_Result _);
    }

    public ResultStatus GetFilterTags(FilterTagInquiry filterTagInquiry)
    {
      return this.GetFilterTags(filterTagInquiry, (FilterTagInquiry_Parameters) null, (FilterTagInquiry_Request) null, out FilterTagInquiry_Result _);
    }

    public ResultStatus GetFilterTags(
      FilterTagInquiry filterTagInquiry,
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result)
    {
      return this.GetFilterTags(filterTagInquiry, (FilterTagInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      FilterTagInquiry filterTagInquiry,
      FilterTagInquiry_Parameters parameters,
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result)
    {
      result = (FilterTagInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) filterTagInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFilterTagInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, filterTagInquiry, parameters, request, out result) : this.AddMethod((Method) new FilterTagInquiryMethod(filterTagInquiry, FilterTagInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) filterTagInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((FilterTagInquiry) null, (FilterTagInquiry_Parameters) null, (FilterTagInquiry_Request) null, out FilterTagInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(FilterTagInquiry filterTagInquiry)
    {
      return this.GetWIPMsgs(filterTagInquiry, (FilterTagInquiry_Parameters) null, (FilterTagInquiry_Request) null, out FilterTagInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      FilterTagInquiry filterTagInquiry,
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result)
    {
      return this.GetWIPMsgs(filterTagInquiry, (FilterTagInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject filterTagInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FilterTagInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((FilterTagInquiry) filterTagInquiry, (FilterTagInquiry_Parameters) parameters, (FilterTagInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result)
    {
      result = (FilterTagInquiry_Result) null;
      try
      {
        FilterTagInquiryMethod[] methods = new FilterTagInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IFilterTagInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        FilterTagInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((FilterTagInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      FilterTagInquiry cdo,
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result)
    {
      result = (FilterTagInquiry_Result) null;
      try
      {
        return ((IFilterTagInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        FilterTagInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((FilterTagInquiry) cdo, (FilterTagInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result)
    {
      return this.GetEnvironment((FilterTagInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      FilterTagInquiry cdo,
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result)
    {
      result = (FilterTagInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFilterTagInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new FilterTagInquiryMethod(cdo, FilterTagInquiryMethods.ExecuteTransaction, (FilterTagInquiry_Parameters) null));
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
        FilterTagInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((FilterTagInquiry) cdo, (FilterTagInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(FilterTagInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (FilterTagInquiry_Request) null, out FilterTagInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result)
    {
      return this.ExecuteTransaction((FilterTagInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(FilterTagInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new FilterTagInquiryMethod(cdo, FilterTagInquiryMethods.AddDataTransaction, (FilterTagInquiry_Parameters) null));
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
        return this.AddDataTransaction((FilterTagInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
