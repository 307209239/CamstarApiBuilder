// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ExportStatusInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ExportStatusInquiryService : ExportImportInquiryBase
  {
    public ExportStatusInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IExportStatusInquiryService), userProfile);
    }

    public ResultStatus GetStatusDetails(
      ExportStatusInquiry exportStatusInquiry,
      ExportStatusInquiry_Parameters parameters,
      ExportStatusInquiry_Request request,
      out ExportStatusInquiry_Result result)
    {
      result = (ExportStatusInquiry_Result) null;
      this.OnBeforeCall(nameof (GetStatusDetails), (DCObject) exportStatusInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportStatusInquiryService) this._Channel).GetStatusDetails(this._UserProfile, exportStatusInquiry, parameters, request, out result) : this.AddMethod((Method) new ExportStatusInquiryMethod(exportStatusInquiry, ExportStatusInquiryMethods.GetStatusDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetStatusDetails), res, (DCObject) exportStatusInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetStatusDetails()
    {
      return this.GetStatusDetails((ExportStatusInquiry) null, (ExportStatusInquiry_Parameters) null, (ExportStatusInquiry_Request) null, out ExportStatusInquiry_Result _);
    }

    public ResultStatus GetStatusDetails(ExportStatusInquiry exportStatusInquiry)
    {
      return this.GetStatusDetails(exportStatusInquiry, (ExportStatusInquiry_Parameters) null, (ExportStatusInquiry_Request) null, out ExportStatusInquiry_Result _);
    }

    public ResultStatus GetStatusDetails(
      ExportStatusInquiry exportStatusInquiry,
      ExportStatusInquiry_Request request,
      out ExportStatusInquiry_Result result)
    {
      return this.GetStatusDetails(exportStatusInquiry, (ExportStatusInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ExportStatusInquiry exportStatusInquiry,
      ExportStatusInquiry_Parameters parameters,
      ExportStatusInquiry_Request request,
      out ExportStatusInquiry_Result result)
    {
      result = (ExportStatusInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) exportStatusInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportStatusInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, exportStatusInquiry, parameters, request, out result) : this.AddMethod((Method) new ExportStatusInquiryMethod(exportStatusInquiry, ExportStatusInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) exportStatusInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ExportStatusInquiry) null, (ExportStatusInquiry_Parameters) null, (ExportStatusInquiry_Request) null, out ExportStatusInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(ExportStatusInquiry exportStatusInquiry)
    {
      return this.GetWIPMsgs(exportStatusInquiry, (ExportStatusInquiry_Parameters) null, (ExportStatusInquiry_Request) null, out ExportStatusInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ExportStatusInquiry exportStatusInquiry,
      ExportStatusInquiry_Request request,
      out ExportStatusInquiry_Result result)
    {
      return this.GetWIPMsgs(exportStatusInquiry, (ExportStatusInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetStatusDetails(
      DCObject exportStatusInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExportStatusInquiry_Result result1;
        ResultStatus statusDetails = this.GetStatusDetails((ExportStatusInquiry) exportStatusInquiry, (ExportStatusInquiry_Parameters) parameters, (ExportStatusInquiry_Request) request, out result1);
        result = (Result) result1;
        return statusDetails;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject exportStatusInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExportStatusInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ExportStatusInquiry) exportStatusInquiry, (ExportStatusInquiry_Parameters) parameters, (ExportStatusInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ExportStatusInquiry_Request request,
      out ExportStatusInquiry_Result result)
    {
      result = (ExportStatusInquiry_Result) null;
      try
      {
        ExportStatusInquiryMethod[] methods = new ExportStatusInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IExportStatusInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ExportStatusInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ExportStatusInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ExportStatusInquiry cdo,
      ExportStatusInquiry_Request request,
      out ExportStatusInquiry_Result result)
    {
      result = (ExportStatusInquiry_Result) null;
      try
      {
        return ((IExportStatusInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ExportStatusInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((ExportStatusInquiry) cdo, (ExportStatusInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ExportStatusInquiry_Request request,
      out ExportStatusInquiry_Result result)
    {
      return this.GetEnvironment((ExportStatusInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ExportStatusInquiry cdo,
      ExportStatusInquiry_Request request,
      out ExportStatusInquiry_Result result)
    {
      result = (ExportStatusInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportStatusInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ExportStatusInquiryMethod(cdo, ExportStatusInquiryMethods.ExecuteTransaction, (ExportStatusInquiry_Parameters) null));
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
        ExportStatusInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ExportStatusInquiry) cdo, (ExportStatusInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ExportStatusInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (ExportStatusInquiry_Request) null, out ExportStatusInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ExportStatusInquiry_Request request,
      out ExportStatusInquiry_Result result)
    {
      return this.ExecuteTransaction((ExportStatusInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ExportStatusInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ExportStatusInquiryMethod(cdo, ExportStatusInquiryMethods.AddDataTransaction, (ExportStatusInquiry_Parameters) null));
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
        return this.AddDataTransaction((ExportStatusInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
