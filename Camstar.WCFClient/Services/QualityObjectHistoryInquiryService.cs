// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.QualityObjectHistoryInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class QualityObjectHistoryInquiryService : ContainerHistoryInquiryBase
  {
    public QualityObjectHistoryInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IQualityObjectHistoryInquiryService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      QualityObjectHistoryInquiry qualityObjectHistoryInquiry,
      QualityObjectHistoryInquiry_Parameters parameters,
      QualityObjectHistoryInquiry_Request request,
      out QualityObjectHistoryInquiry_Result result)
    {
      result = (QualityObjectHistoryInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) qualityObjectHistoryInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityObjectHistoryInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, qualityObjectHistoryInquiry, parameters, request, out result) : this.AddMethod((Method) new QualityObjectHistoryInquiryMethod(qualityObjectHistoryInquiry, QualityObjectHistoryInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) qualityObjectHistoryInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((QualityObjectHistoryInquiry) null, (QualityObjectHistoryInquiry_Parameters) null, (QualityObjectHistoryInquiry_Request) null, out QualityObjectHistoryInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      QualityObjectHistoryInquiry qualityObjectHistoryInquiry)
    {
      return this.GetWIPMsgs(qualityObjectHistoryInquiry, (QualityObjectHistoryInquiry_Parameters) null, (QualityObjectHistoryInquiry_Request) null, out QualityObjectHistoryInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      QualityObjectHistoryInquiry qualityObjectHistoryInquiry,
      QualityObjectHistoryInquiry_Request request,
      out QualityObjectHistoryInquiry_Result result)
    {
      return this.GetWIPMsgs(qualityObjectHistoryInquiry, (QualityObjectHistoryInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject qualityObjectHistoryInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityObjectHistoryInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((QualityObjectHistoryInquiry) qualityObjectHistoryInquiry, (QualityObjectHistoryInquiry_Parameters) parameters, (QualityObjectHistoryInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      QualityObjectHistoryInquiry_Request request,
      out QualityObjectHistoryInquiry_Result result)
    {
      result = (QualityObjectHistoryInquiry_Result) null;
      try
      {
        QualityObjectHistoryInquiryMethod[] methods = new QualityObjectHistoryInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IQualityObjectHistoryInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        QualityObjectHistoryInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((QualityObjectHistoryInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      QualityObjectHistoryInquiry cdo,
      QualityObjectHistoryInquiry_Request request,
      out QualityObjectHistoryInquiry_Result result)
    {
      result = (QualityObjectHistoryInquiry_Result) null;
      try
      {
        return ((IQualityObjectHistoryInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        QualityObjectHistoryInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((QualityObjectHistoryInquiry) cdo, (QualityObjectHistoryInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      QualityObjectHistoryInquiry_Request request,
      out QualityObjectHistoryInquiry_Result result)
    {
      return this.GetEnvironment((QualityObjectHistoryInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      QualityObjectHistoryInquiry cdo,
      QualityObjectHistoryInquiry_Request request,
      out QualityObjectHistoryInquiry_Result result)
    {
      result = (QualityObjectHistoryInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityObjectHistoryInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new QualityObjectHistoryInquiryMethod(cdo, QualityObjectHistoryInquiryMethods.ExecuteTransaction, (QualityObjectHistoryInquiry_Parameters) null));
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
        QualityObjectHistoryInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((QualityObjectHistoryInquiry) cdo, (QualityObjectHistoryInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(QualityObjectHistoryInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (QualityObjectHistoryInquiry_Request) null, out QualityObjectHistoryInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      QualityObjectHistoryInquiry_Request request,
      out QualityObjectHistoryInquiry_Result result)
    {
      return this.ExecuteTransaction((QualityObjectHistoryInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(QualityObjectHistoryInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new QualityObjectHistoryInquiryMethod(cdo, QualityObjectHistoryInquiryMethods.AddDataTransaction, (QualityObjectHistoryInquiry_Parameters) null));
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
        return this.AddDataTransaction((QualityObjectHistoryInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
