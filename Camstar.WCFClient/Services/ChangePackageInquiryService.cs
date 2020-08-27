// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangePackageInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ChangePackageInquiryService : InquiryBase
  {
    public ChangePackageInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IChangePackageInquiryService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      ChangePackageInquiry changePackageInquiry,
      ChangePackageInquiry_Parameters parameters,
      ChangePackageInquiry_Request request,
      out ChangePackageInquiry_Result result)
    {
      result = (ChangePackageInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) changePackageInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackageInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, changePackageInquiry, parameters, request, out result) : this.AddMethod((Method) new ChangePackageInquiryMethod(changePackageInquiry, ChangePackageInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) changePackageInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ChangePackageInquiry) null, (ChangePackageInquiry_Parameters) null, (ChangePackageInquiry_Request) null, out ChangePackageInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(ChangePackageInquiry changePackageInquiry)
    {
      return this.GetWIPMsgs(changePackageInquiry, (ChangePackageInquiry_Parameters) null, (ChangePackageInquiry_Request) null, out ChangePackageInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChangePackageInquiry changePackageInquiry,
      ChangePackageInquiry_Request request,
      out ChangePackageInquiry_Result result)
    {
      return this.GetWIPMsgs(changePackageInquiry, (ChangePackageInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject changePackageInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackageInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ChangePackageInquiry) changePackageInquiry, (ChangePackageInquiry_Parameters) parameters, (ChangePackageInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ChangePackageInquiry_Request request,
      out ChangePackageInquiry_Result result)
    {
      result = (ChangePackageInquiry_Result) null;
      try
      {
        ChangePackageInquiryMethod[] methods = new ChangePackageInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IChangePackageInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ChangePackageInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ChangePackageInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangePackageInquiry cdo,
      ChangePackageInquiry_Request request,
      out ChangePackageInquiry_Result result)
    {
      result = (ChangePackageInquiry_Result) null;
      try
      {
        return ((IChangePackageInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ChangePackageInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((ChangePackageInquiry) cdo, (ChangePackageInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangePackageInquiry_Request request,
      out ChangePackageInquiry_Result result)
    {
      return this.GetEnvironment((ChangePackageInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ChangePackageInquiry cdo,
      ChangePackageInquiry_Request request,
      out ChangePackageInquiry_Result result)
    {
      result = (ChangePackageInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackageInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ChangePackageInquiryMethod(cdo, ChangePackageInquiryMethods.ExecuteTransaction, (ChangePackageInquiry_Parameters) null));
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
        ChangePackageInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ChangePackageInquiry) cdo, (ChangePackageInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ChangePackageInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (ChangePackageInquiry_Request) null, out ChangePackageInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ChangePackageInquiry_Request request,
      out ChangePackageInquiry_Result result)
    {
      return this.ExecuteTransaction((ChangePackageInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ChangePackageInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ChangePackageInquiryMethod(cdo, ChangePackageInquiryMethods.AddDataTransaction, (ChangePackageInquiry_Parameters) null));
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
        return this.AddDataTransaction((ChangePackageInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
