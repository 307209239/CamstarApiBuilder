// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ExportImportInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ExportImportInquiryService : InquiryBase
  {
    public ExportImportInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IExportImportInquiryService), userProfile);
    }

    public ResultStatus GetStatusDetails(
      ExportImportInquiry exportImportInquiry,
      ExportImportInquiry_Parameters parameters,
      ExportImportInquiry_Request request,
      out ExportImportInquiry_Result result)
    {
      result = (ExportImportInquiry_Result) null;
      this.OnBeforeCall(nameof (GetStatusDetails), (DCObject) exportImportInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportImportInquiryService) this._Channel).GetStatusDetails(this._UserProfile, exportImportInquiry, parameters, request, out result) : this.AddMethod((Method) new ExportImportInquiryMethod(exportImportInquiry, ExportImportInquiryMethods.GetStatusDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetStatusDetails), res, (DCObject) exportImportInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetStatusDetails()
    {
      return this.GetStatusDetails((ExportImportInquiry) null, (ExportImportInquiry_Parameters) null, (ExportImportInquiry_Request) null, out ExportImportInquiry_Result _);
    }

    public ResultStatus GetStatusDetails(ExportImportInquiry exportImportInquiry)
    {
      return this.GetStatusDetails(exportImportInquiry, (ExportImportInquiry_Parameters) null, (ExportImportInquiry_Request) null, out ExportImportInquiry_Result _);
    }

    public ResultStatus GetStatusDetails(
      ExportImportInquiry exportImportInquiry,
      ExportImportInquiry_Request request,
      out ExportImportInquiry_Result result)
    {
      return this.GetStatusDetails(exportImportInquiry, (ExportImportInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ExportImportInquiry exportImportInquiry,
      ExportImportInquiry_Parameters parameters,
      ExportImportInquiry_Request request,
      out ExportImportInquiry_Result result)
    {
      result = (ExportImportInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) exportImportInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportImportInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, exportImportInquiry, parameters, request, out result) : this.AddMethod((Method) new ExportImportInquiryMethod(exportImportInquiry, ExportImportInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) exportImportInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ExportImportInquiry) null, (ExportImportInquiry_Parameters) null, (ExportImportInquiry_Request) null, out ExportImportInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(ExportImportInquiry exportImportInquiry)
    {
      return this.GetWIPMsgs(exportImportInquiry, (ExportImportInquiry_Parameters) null, (ExportImportInquiry_Request) null, out ExportImportInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ExportImportInquiry exportImportInquiry,
      ExportImportInquiry_Request request,
      out ExportImportInquiry_Result result)
    {
      return this.GetWIPMsgs(exportImportInquiry, (ExportImportInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject exportImportInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExportImportInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ExportImportInquiry) exportImportInquiry, (ExportImportInquiry_Parameters) parameters, (ExportImportInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ExportImportInquiry_Request request,
      out ExportImportInquiry_Result result)
    {
      result = (ExportImportInquiry_Result) null;
      try
      {
        ExportImportInquiryMethod[] methods = new ExportImportInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IExportImportInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ExportImportInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ExportImportInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ExportImportInquiry cdo,
      ExportImportInquiry_Request request,
      out ExportImportInquiry_Result result)
    {
      result = (ExportImportInquiry_Result) null;
      try
      {
        return ((IExportImportInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ExportImportInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((ExportImportInquiry) cdo, (ExportImportInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ExportImportInquiry_Request request,
      out ExportImportInquiry_Result result)
    {
      return this.GetEnvironment((ExportImportInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ExportImportInquiry cdo,
      ExportImportInquiry_Request request,
      out ExportImportInquiry_Result result)
    {
      result = (ExportImportInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportImportInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ExportImportInquiryMethod(cdo, ExportImportInquiryMethods.ExecuteTransaction, (ExportImportInquiry_Parameters) null));
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
        ExportImportInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ExportImportInquiry) cdo, (ExportImportInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ExportImportInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (ExportImportInquiry_Request) null, out ExportImportInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ExportImportInquiry_Request request,
      out ExportImportInquiry_Result result)
    {
      return this.ExecuteTransaction((ExportImportInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ExportImportInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ExportImportInquiryMethod(cdo, ExportImportInquiryMethods.AddDataTransaction, (ExportImportInquiry_Parameters) null));
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
        return this.AddDataTransaction((ExportImportInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
