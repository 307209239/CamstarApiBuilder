// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ImportStatusInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ImportStatusInquiryService : ExportImportInquiryBase
  {
    public ImportStatusInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IImportStatusInquiryService), userProfile);
    }

    public ResultStatus GetImportSetStatus(
      ImportStatusInquiry importStatusInquiry,
      ImportStatusInquiry_Parameters parameters,
      ImportStatusInquiry_Request request,
      out ImportStatusInquiry_Result result)
    {
      result = (ImportStatusInquiry_Result) null;
      this.OnBeforeCall(nameof (GetImportSetStatus), (DCObject) importStatusInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IImportStatusInquiryService) this._Channel).GetImportSetStatus(this._UserProfile, importStatusInquiry, parameters, request, out result) : this.AddMethod((Method) new ImportStatusInquiryMethod(importStatusInquiry, ImportStatusInquiryMethods.GetImportSetStatus, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetImportSetStatus), res, (DCObject) importStatusInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetImportSetStatus()
    {
      return this.GetImportSetStatus((ImportStatusInquiry) null, (ImportStatusInquiry_Parameters) null, (ImportStatusInquiry_Request) null, out ImportStatusInquiry_Result _);
    }

    public ResultStatus GetImportSetStatus(ImportStatusInquiry importStatusInquiry)
    {
      return this.GetImportSetStatus(importStatusInquiry, (ImportStatusInquiry_Parameters) null, (ImportStatusInquiry_Request) null, out ImportStatusInquiry_Result _);
    }

    public ResultStatus GetImportSetStatus(
      ImportStatusInquiry importStatusInquiry,
      ImportStatusInquiry_Request request,
      out ImportStatusInquiry_Result result)
    {
      return this.GetImportSetStatus(importStatusInquiry, (ImportStatusInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetStatusDetails(
      ImportStatusInquiry importStatusInquiry,
      ImportStatusInquiry_Parameters parameters,
      ImportStatusInquiry_Request request,
      out ImportStatusInquiry_Result result)
    {
      result = (ImportStatusInquiry_Result) null;
      this.OnBeforeCall(nameof (GetStatusDetails), (DCObject) importStatusInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IImportStatusInquiryService) this._Channel).GetStatusDetails(this._UserProfile, importStatusInquiry, parameters, request, out result) : this.AddMethod((Method) new ImportStatusInquiryMethod(importStatusInquiry, ImportStatusInquiryMethods.GetStatusDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetStatusDetails), res, (DCObject) importStatusInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetStatusDetails()
    {
      return this.GetStatusDetails((ImportStatusInquiry) null, (ImportStatusInquiry_Parameters) null, (ImportStatusInquiry_Request) null, out ImportStatusInquiry_Result _);
    }

    public ResultStatus GetStatusDetails(ImportStatusInquiry importStatusInquiry)
    {
      return this.GetStatusDetails(importStatusInquiry, (ImportStatusInquiry_Parameters) null, (ImportStatusInquiry_Request) null, out ImportStatusInquiry_Result _);
    }

    public ResultStatus GetStatusDetails(
      ImportStatusInquiry importStatusInquiry,
      ImportStatusInquiry_Request request,
      out ImportStatusInquiry_Result result)
    {
      return this.GetStatusDetails(importStatusInquiry, (ImportStatusInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ImportStatusInquiry importStatusInquiry,
      ImportStatusInquiry_Parameters parameters,
      ImportStatusInquiry_Request request,
      out ImportStatusInquiry_Result result)
    {
      result = (ImportStatusInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) importStatusInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IImportStatusInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, importStatusInquiry, parameters, request, out result) : this.AddMethod((Method) new ImportStatusInquiryMethod(importStatusInquiry, ImportStatusInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) importStatusInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ImportStatusInquiry) null, (ImportStatusInquiry_Parameters) null, (ImportStatusInquiry_Request) null, out ImportStatusInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(ImportStatusInquiry importStatusInquiry)
    {
      return this.GetWIPMsgs(importStatusInquiry, (ImportStatusInquiry_Parameters) null, (ImportStatusInquiry_Request) null, out ImportStatusInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ImportStatusInquiry importStatusInquiry,
      ImportStatusInquiry_Request request,
      out ImportStatusInquiry_Result result)
    {
      return this.GetWIPMsgs(importStatusInquiry, (ImportStatusInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetStatusDetails(
      DCObject importStatusInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ImportStatusInquiry_Result result1;
        ResultStatus statusDetails = this.GetStatusDetails((ImportStatusInquiry) importStatusInquiry, (ImportStatusInquiry_Parameters) parameters, (ImportStatusInquiry_Request) request, out result1);
        result = (Result) result1;
        return statusDetails;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject importStatusInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ImportStatusInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ImportStatusInquiry) importStatusInquiry, (ImportStatusInquiry_Parameters) parameters, (ImportStatusInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ImportStatusInquiry_Request request,
      out ImportStatusInquiry_Result result)
    {
      result = (ImportStatusInquiry_Result) null;
      try
      {
        ImportStatusInquiryMethod[] methods = new ImportStatusInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IImportStatusInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ImportStatusInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ImportStatusInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ImportStatusInquiry cdo,
      ImportStatusInquiry_Request request,
      out ImportStatusInquiry_Result result)
    {
      result = (ImportStatusInquiry_Result) null;
      try
      {
        return ((IImportStatusInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ImportStatusInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((ImportStatusInquiry) cdo, (ImportStatusInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ImportStatusInquiry_Request request,
      out ImportStatusInquiry_Result result)
    {
      return this.GetEnvironment((ImportStatusInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ImportStatusInquiry cdo,
      ImportStatusInquiry_Request request,
      out ImportStatusInquiry_Result result)
    {
      result = (ImportStatusInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IImportStatusInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ImportStatusInquiryMethod(cdo, ImportStatusInquiryMethods.ExecuteTransaction, (ImportStatusInquiry_Parameters) null));
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
        ImportStatusInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ImportStatusInquiry) cdo, (ImportStatusInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ImportStatusInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (ImportStatusInquiry_Request) null, out ImportStatusInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ImportStatusInquiry_Request request,
      out ImportStatusInquiry_Result result)
    {
      return this.ExecuteTransaction((ImportStatusInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ImportStatusInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ImportStatusInquiryMethod(cdo, ImportStatusInquiryMethods.AddDataTransaction, (ImportStatusInquiry_Parameters) null));
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
        return this.AddDataTransaction((ImportStatusInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
