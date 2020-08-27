// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.QualityObjectInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class QualityObjectInquiryService : InquiryBase
  {
    public QualityObjectInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IQualityObjectInquiryService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      QualityObjectInquiry qualityObjectInquiry,
      QualityObjectInquiry_Parameters parameters,
      QualityObjectInquiry_Request request,
      out QualityObjectInquiry_Result result)
    {
      result = (QualityObjectInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) qualityObjectInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityObjectInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, qualityObjectInquiry, parameters, request, out result) : this.AddMethod((Method) new QualityObjectInquiryMethod(qualityObjectInquiry, QualityObjectInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) qualityObjectInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((QualityObjectInquiry) null, (QualityObjectInquiry_Parameters) null, (QualityObjectInquiry_Request) null, out QualityObjectInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(QualityObjectInquiry qualityObjectInquiry)
    {
      return this.GetWIPMsgs(qualityObjectInquiry, (QualityObjectInquiry_Parameters) null, (QualityObjectInquiry_Request) null, out QualityObjectInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      QualityObjectInquiry qualityObjectInquiry,
      QualityObjectInquiry_Request request,
      out QualityObjectInquiry_Result result)
    {
      return this.GetWIPMsgs(qualityObjectInquiry, (QualityObjectInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject qualityObjectInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityObjectInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((QualityObjectInquiry) qualityObjectInquiry, (QualityObjectInquiry_Parameters) parameters, (QualityObjectInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      QualityObjectInquiry_Request request,
      out QualityObjectInquiry_Result result)
    {
      result = (QualityObjectInquiry_Result) null;
      try
      {
        QualityObjectInquiryMethod[] methods = new QualityObjectInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IQualityObjectInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        QualityObjectInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((QualityObjectInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      QualityObjectInquiry cdo,
      QualityObjectInquiry_Request request,
      out QualityObjectInquiry_Result result)
    {
      result = (QualityObjectInquiry_Result) null;
      try
      {
        return ((IQualityObjectInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        QualityObjectInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((QualityObjectInquiry) cdo, (QualityObjectInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      QualityObjectInquiry_Request request,
      out QualityObjectInquiry_Result result)
    {
      return this.GetEnvironment((QualityObjectInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      QualityObjectInquiry cdo,
      QualityObjectInquiry_Request request,
      out QualityObjectInquiry_Result result)
    {
      result = (QualityObjectInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityObjectInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new QualityObjectInquiryMethod(cdo, QualityObjectInquiryMethods.ExecuteTransaction, (QualityObjectInquiry_Parameters) null));
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
        QualityObjectInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((QualityObjectInquiry) cdo, (QualityObjectInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(QualityObjectInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (QualityObjectInquiry_Request) null, out QualityObjectInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      QualityObjectInquiry_Request request,
      out QualityObjectInquiry_Result result)
    {
      return this.ExecuteTransaction((QualityObjectInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(QualityObjectInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new QualityObjectInquiryMethod(cdo, QualityObjectInquiryMethods.AddDataTransaction, (QualityObjectInquiry_Parameters) null));
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
        return this.AddDataTransaction((QualityObjectInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
