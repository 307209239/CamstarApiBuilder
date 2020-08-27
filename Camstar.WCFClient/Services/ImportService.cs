// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ImportService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ImportService : ExportImportTxnsBase
  {
    public ImportService(UserProfile userProfile)
    {
      this.Initialize(typeof (IImportService), userProfile);
    }

    public ResultStatus GetImportContents(
      Import import,
      Import_Parameters parameters,
      Import_Request request,
      out Import_Result result)
    {
      result = (Import_Result) null;
      this.OnBeforeCall(nameof (GetImportContents), (DCObject) import, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IImportService) this._Channel).GetImportContents(this._UserProfile, import, parameters, request, out result) : this.AddMethod((Method) new ImportMethod(import, ImportMethods.GetImportContents, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetImportContents), res, (DCObject) import, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetImportContents()
    {
      return this.GetImportContents((Import) null, (Import_Parameters) null, (Import_Request) null, out Import_Result _);
    }

    public ResultStatus GetImportContents(Import import)
    {
      return this.GetImportContents(import, (Import_Parameters) null, (Import_Request) null, out Import_Result _);
    }

    public ResultStatus GetImportContents(
      Import import,
      Import_Request request,
      out Import_Result result)
    {
      return this.GetImportContents(import, (Import_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Import import,
      Import_Parameters parameters,
      Import_Request request,
      out Import_Result result)
    {
      result = (Import_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) import, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IImportService) this._Channel).GetWIPMsgs(this._UserProfile, import, parameters, request, out result) : this.AddMethod((Method) new ImportMethod(import, ImportMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) import, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Import) null, (Import_Parameters) null, (Import_Request) null, out Import_Result _);
    }

    public ResultStatus GetWIPMsgs(Import import)
    {
      return this.GetWIPMsgs(import, (Import_Parameters) null, (Import_Request) null, out Import_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Import import,
      Import_Request request,
      out Import_Result result)
    {
      return this.GetWIPMsgs(import, (Import_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Import import,
      Import_Parameters parameters,
      Import_Request request,
      out Import_Result result)
    {
      result = (Import_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) import, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IImportService) this._Channel).Load(this._UserProfile, import, parameters, request, out result) : this.AddMethod((Method) new ImportMethod(import, ImportMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) import, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Import) null, (Import_Parameters) null, (Import_Request) null, out Import_Result _);
    }

    public ResultStatus Load(Import import)
    {
      return this.Load(import, (Import_Parameters) null, (Import_Request) null, out Import_Result _);
    }

    public ResultStatus Load(
      Import import,
      Import_Request request,
      out Import_Result result)
    {
      return this.Load(import, (Import_Parameters) null, request, out result);
    }

    protected override ResultStatus OnLoad(
      DCObject import,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Import_Result result1;
        ResultStatus resultStatus = this.Load((Import) import, (Import_Parameters) parameters, (Import_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject import,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Import_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Import) import, (Import_Parameters) parameters, (Import_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Import_Request request,
      out Import_Result result)
    {
      result = (Import_Result) null;
      try
      {
        ImportMethod[] methods = new ImportMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IImportService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Import_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Import_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Import cdo,
      Import_Request request,
      out Import_Result result)
    {
      result = (Import_Result) null;
      try
      {
        return ((IImportService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Import_Result result1;
        ResultStatus environment = this.GetEnvironment((Import) cdo, (Import_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(Import_Request request, out Import_Result result)
    {
      return this.GetEnvironment((Import) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Import cdo,
      Import_Request request,
      out Import_Result result)
    {
      result = (Import_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IImportService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ImportMethod(cdo, ImportMethods.ExecuteTransaction, (Import_Parameters) null));
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
        Import_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Import) cdo, (Import_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Import cdo)
    {
      return this.ExecuteTransaction(cdo, (Import_Request) null, out Import_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Import_Request request,
      out Import_Result result)
    {
      return this.ExecuteTransaction((Import) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Import cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ImportMethod(cdo, ImportMethods.AddDataTransaction, (Import_Parameters) null));
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
        return this.AddDataTransaction((Import) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
