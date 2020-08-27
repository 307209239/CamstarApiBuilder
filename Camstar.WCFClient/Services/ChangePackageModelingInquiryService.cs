// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangePackageModelingInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ChangePackageModelingInquiryService : InquiryBase
  {
    public ChangePackageModelingInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IChangePackageModelingInquiryService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      ChangePackageModelingInquiry changePackageModelingInquiry,
      ChangePackageModelingInquiry_Parameters parameters,
      ChangePackageModelingInquiry_Request request,
      out ChangePackageModelingInquiry_Result result)
    {
      result = (ChangePackageModelingInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) changePackageModelingInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackageModelingInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, changePackageModelingInquiry, parameters, request, out result) : this.AddMethod((Method) new ChangePackageModelingInquiryMethod(changePackageModelingInquiry, ChangePackageModelingInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) changePackageModelingInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ChangePackageModelingInquiry) null, (ChangePackageModelingInquiry_Parameters) null, (ChangePackageModelingInquiry_Request) null, out ChangePackageModelingInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChangePackageModelingInquiry changePackageModelingInquiry)
    {
      return this.GetWIPMsgs(changePackageModelingInquiry, (ChangePackageModelingInquiry_Parameters) null, (ChangePackageModelingInquiry_Request) null, out ChangePackageModelingInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChangePackageModelingInquiry changePackageModelingInquiry,
      ChangePackageModelingInquiry_Request request,
      out ChangePackageModelingInquiry_Result result)
    {
      return this.GetWIPMsgs(changePackageModelingInquiry, (ChangePackageModelingInquiry_Parameters) null, request, out result);
    }

    public ResultStatus IsChangeMgtSave(
      ChangePackageModelingInquiry changePackageModelingInquiry,
      ChangePackageModelingInquiry_Parameters parameters,
      ChangePackageModelingInquiry_Request request,
      out ChangePackageModelingInquiry_Result result)
    {
      result = (ChangePackageModelingInquiry_Result) null;
      this.OnBeforeCall(nameof (IsChangeMgtSave), (DCObject) changePackageModelingInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackageModelingInquiryService) this._Channel).IsChangeMgtSave(this._UserProfile, changePackageModelingInquiry, parameters, request, out result) : this.AddMethod((Method) new ChangePackageModelingInquiryMethod(changePackageModelingInquiry, ChangePackageModelingInquiryMethods.IsChangeMgtSave, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (IsChangeMgtSave), res, (DCObject) changePackageModelingInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus IsChangeMgtSave()
    {
      return this.IsChangeMgtSave((ChangePackageModelingInquiry) null, (ChangePackageModelingInquiry_Parameters) null, (ChangePackageModelingInquiry_Request) null, out ChangePackageModelingInquiry_Result _);
    }

    public ResultStatus IsChangeMgtSave(
      ChangePackageModelingInquiry changePackageModelingInquiry)
    {
      return this.IsChangeMgtSave(changePackageModelingInquiry, (ChangePackageModelingInquiry_Parameters) null, (ChangePackageModelingInquiry_Request) null, out ChangePackageModelingInquiry_Result _);
    }

    public ResultStatus IsChangeMgtSave(
      ChangePackageModelingInquiry changePackageModelingInquiry,
      ChangePackageModelingInquiry_Request request,
      out ChangePackageModelingInquiry_Result result)
    {
      return this.IsChangeMgtSave(changePackageModelingInquiry, (ChangePackageModelingInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject changePackageModelingInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackageModelingInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ChangePackageModelingInquiry) changePackageModelingInquiry, (ChangePackageModelingInquiry_Parameters) parameters, (ChangePackageModelingInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ChangePackageModelingInquiry_Request request,
      out ChangePackageModelingInquiry_Result result)
    {
      result = (ChangePackageModelingInquiry_Result) null;
      try
      {
        ChangePackageModelingInquiryMethod[] methods = new ChangePackageModelingInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IChangePackageModelingInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ChangePackageModelingInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ChangePackageModelingInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangePackageModelingInquiry cdo,
      ChangePackageModelingInquiry_Request request,
      out ChangePackageModelingInquiry_Result result)
    {
      result = (ChangePackageModelingInquiry_Result) null;
      try
      {
        return ((IChangePackageModelingInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ChangePackageModelingInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((ChangePackageModelingInquiry) cdo, (ChangePackageModelingInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangePackageModelingInquiry_Request request,
      out ChangePackageModelingInquiry_Result result)
    {
      return this.GetEnvironment((ChangePackageModelingInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ChangePackageModelingInquiry cdo,
      ChangePackageModelingInquiry_Request request,
      out ChangePackageModelingInquiry_Result result)
    {
      result = (ChangePackageModelingInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackageModelingInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ChangePackageModelingInquiryMethod(cdo, ChangePackageModelingInquiryMethods.ExecuteTransaction, (ChangePackageModelingInquiry_Parameters) null));
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
        ChangePackageModelingInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ChangePackageModelingInquiry) cdo, (ChangePackageModelingInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ChangePackageModelingInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (ChangePackageModelingInquiry_Request) null, out ChangePackageModelingInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ChangePackageModelingInquiry_Request request,
      out ChangePackageModelingInquiry_Result result)
    {
      return this.ExecuteTransaction((ChangePackageModelingInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ChangePackageModelingInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ChangePackageModelingInquiryMethod(cdo, ChangePackageModelingInquiryMethods.AddDataTransaction, (ChangePackageModelingInquiry_Parameters) null));
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
        return this.AddDataTransaction((ChangePackageModelingInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
