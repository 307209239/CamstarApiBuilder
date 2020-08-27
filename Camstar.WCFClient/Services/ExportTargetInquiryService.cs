// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ExportTargetInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ExportTargetInquiryService : ExportImportInquiryBase
  {
    public ExportTargetInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IExportTargetInquiryService), userProfile);
    }

    public ResultStatus GetStatusDetails(
      ExportTargetInquiry exportTargetInquiry,
      ExportTargetInquiry_Parameters parameters,
      ExportTargetInquiry_Request request,
      out ExportTargetInquiry_Result result)
    {
      result = (ExportTargetInquiry_Result) null;
      this.OnBeforeCall(nameof (GetStatusDetails), (DCObject) exportTargetInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportTargetInquiryService) this._Channel).GetStatusDetails(this._UserProfile, exportTargetInquiry, parameters, request, out result) : this.AddMethod((Method) new ExportTargetInquiryMethod(exportTargetInquiry, ExportTargetInquiryMethods.GetStatusDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetStatusDetails), res, (DCObject) exportTargetInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetStatusDetails()
    {
      return this.GetStatusDetails((ExportTargetInquiry) null, (ExportTargetInquiry_Parameters) null, (ExportTargetInquiry_Request) null, out ExportTargetInquiry_Result _);
    }

    public ResultStatus GetStatusDetails(ExportTargetInquiry exportTargetInquiry)
    {
      return this.GetStatusDetails(exportTargetInquiry, (ExportTargetInquiry_Parameters) null, (ExportTargetInquiry_Request) null, out ExportTargetInquiry_Result _);
    }

    public ResultStatus GetStatusDetails(
      ExportTargetInquiry exportTargetInquiry,
      ExportTargetInquiry_Request request,
      out ExportTargetInquiry_Result result)
    {
      return this.GetStatusDetails(exportTargetInquiry, (ExportTargetInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ExportTargetInquiry exportTargetInquiry,
      ExportTargetInquiry_Parameters parameters,
      ExportTargetInquiry_Request request,
      out ExportTargetInquiry_Result result)
    {
      result = (ExportTargetInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) exportTargetInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportTargetInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, exportTargetInquiry, parameters, request, out result) : this.AddMethod((Method) new ExportTargetInquiryMethod(exportTargetInquiry, ExportTargetInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) exportTargetInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ExportTargetInquiry) null, (ExportTargetInquiry_Parameters) null, (ExportTargetInquiry_Request) null, out ExportTargetInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(ExportTargetInquiry exportTargetInquiry)
    {
      return this.GetWIPMsgs(exportTargetInquiry, (ExportTargetInquiry_Parameters) null, (ExportTargetInquiry_Request) null, out ExportTargetInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ExportTargetInquiry exportTargetInquiry,
      ExportTargetInquiry_Request request,
      out ExportTargetInquiry_Result result)
    {
      return this.GetWIPMsgs(exportTargetInquiry, (ExportTargetInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetStatusDetails(
      DCObject exportTargetInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExportTargetInquiry_Result result1;
        ResultStatus statusDetails = this.GetStatusDetails((ExportTargetInquiry) exportTargetInquiry, (ExportTargetInquiry_Parameters) parameters, (ExportTargetInquiry_Request) request, out result1);
        result = (Result) result1;
        return statusDetails;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject exportTargetInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExportTargetInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ExportTargetInquiry) exportTargetInquiry, (ExportTargetInquiry_Parameters) parameters, (ExportTargetInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ExportTargetInquiry_Request request,
      out ExportTargetInquiry_Result result)
    {
      result = (ExportTargetInquiry_Result) null;
      try
      {
        ExportTargetInquiryMethod[] methods = new ExportTargetInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IExportTargetInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ExportTargetInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ExportTargetInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ExportTargetInquiry cdo,
      ExportTargetInquiry_Request request,
      out ExportTargetInquiry_Result result)
    {
      result = (ExportTargetInquiry_Result) null;
      try
      {
        return ((IExportTargetInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ExportTargetInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((ExportTargetInquiry) cdo, (ExportTargetInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ExportTargetInquiry_Request request,
      out ExportTargetInquiry_Result result)
    {
      return this.GetEnvironment((ExportTargetInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ExportTargetInquiry cdo,
      ExportTargetInquiry_Request request,
      out ExportTargetInquiry_Result result)
    {
      result = (ExportTargetInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportTargetInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ExportTargetInquiryMethod(cdo, ExportTargetInquiryMethods.ExecuteTransaction, (ExportTargetInquiry_Parameters) null));
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
        ExportTargetInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ExportTargetInquiry) cdo, (ExportTargetInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ExportTargetInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (ExportTargetInquiry_Request) null, out ExportTargetInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ExportTargetInquiry_Request request,
      out ExportTargetInquiry_Result result)
    {
      return this.ExecuteTransaction((ExportTargetInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ExportTargetInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ExportTargetInquiryMethod(cdo, ExportTargetInquiryMethods.AddDataTransaction, (ExportTargetInquiry_Parameters) null));
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
        return this.AddDataTransaction((ExportTargetInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
